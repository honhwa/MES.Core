using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.Forms.Reports
{
    // ── 報表列印共用排版工具：對於欄位數量龐大(60+)的 Access Report(如「工令單
    //    內容-H」「產品規格書」)，逐一在 Designer.cs 手刻座標既繁瑣、亦容易在
    //    Visual Studio 表單設計工具重新序列化時失真(自訂輔助方法無法被序列化，
    //    詳見 FrmAccessoriesApplyPrint 曾發生之版面遺失事件)。故改以此類別在
    //    一般 .cs 程式碼(非 Designer.cs)中，於執行期動態產生「標題:唯讀值」欄
    //    位群組，Designer.cs 僅保留外層容器與固定按鈕 ─────────────────────
    public static class ReportLayoutHelper
    {
        public static readonly Font DefaultFont = new Font("微軟正黑體", 9F);
        private static readonly Font BoldFont = new Font("微軟正黑體", 9F, FontStyle.Bold);
        private static readonly Font TitleFont = new Font("微軟正黑體", 10.5F, FontStyle.Bold);
        private static readonly Color TitleColor = Color.FromArgb(69, 98, 135);

        // ── 區段標題(粗體+底線)，傳回下一個可用的Y座標 ─────────────────────
        public static int AddSectionTitle(Panel panel, string text, int startY, int width, int marginX = 8)
        {
            var lbl = new Label
            {
                Text = text,
                AutoSize = false,
                Location = new Point(marginX, startY),
                Size = new Size(width, 22),
                Font = TitleFont,
                ForeColor = TitleColor
            };
            panel.Controls.Add(lbl);
            var line = new Panel
            {
                Location = new Point(marginX, startY + 22),
                Size = new Size(width, 2),
                BackColor = TitleColor
            };
            panel.Controls.Add(line);
            return startY + 30;
        }

        // ── N欄「標題:唯讀值」網格，傳回下一個可用的Y座標 ───────────────────
        public static int AddFieldGrid(Panel panel, List<(string Caption, string Value)> fields, int startY,
            int columns = 3, int colWidth = 255, int marginX = 8, int labelWidth = 85, int rowHeight = 24)
        {
            int col = 0, row = 0;
            foreach (var f in fields)
            {
                int x = marginX + col * colWidth;
                int y = startY + row * rowHeight;
                var lbl = new Label
                {
                    Text = f.Caption,
                    AutoSize = false,
                    Location = new Point(x, y),
                    Size = new Size(labelWidth, 21),
                    Font = DefaultFont,
                    TextAlign = ContentAlignment.MiddleLeft
                };
                var val = new Label
                {
                    Text = string.IsNullOrEmpty(f.Value) ? "" : f.Value,
                    AutoSize = false,
                    Location = new Point(x + labelWidth, y),
                    Size = new Size(colWidth - labelWidth - 6, 21),
                    Font = DefaultFont,
                    TextAlign = ContentAlignment.MiddleLeft,
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.White
                };
                panel.Controls.Add(lbl);
                panel.Controls.Add(val);
                col++;
                if (col >= columns) { col = 0; row++; }
            }
            if (col != 0) row++;
            return startY + row * rowHeight + 4;
        }

        // ── 單一長文字區塊(自動依內容量測所需高度)，傳回下一個可用的Y座標 ──────
        public static int AddLongTextBlock(Panel panel, string caption, string value, int startY, int width,
            int marginX = 8, int minHeight = 40)
        {
            var lbl = new Label
            {
                Text = caption,
                AutoSize = false,
                Location = new Point(marginX, startY),
                Size = new Size(width, 20),
                Font = BoldFont,
                ForeColor = TitleColor
            };
            panel.Controls.Add(lbl);

            int textHeight = Math.Max(minHeight, TextRenderer.MeasureText(
                string.IsNullOrEmpty(value) ? " " : value,
                DefaultFont,
                new Size(width - 12, int.MaxValue),
                TextFormatFlags.WordBreak | TextFormatFlags.TextBoxControl).Height + 10);

            var box = new Label
            {
                Text = value ?? "",
                AutoSize = false,
                Location = new Point(marginX, startY + 20),
                Size = new Size(width, textHeight),
                Font = DefaultFont,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White,
                Padding = new Padding(4)
            };
            panel.Controls.Add(box);
            return startY + 20 + textHeight + 6;
        }

        // ── 比照既有 FrmPrintSalesOrderPT.btnPreviewPrint_Click 之作法：將指定
        //    Control 轉點陣圖，輸出成單頁PDF後另存新檔。刻意傳入內容 Panel 本身
        //    (而非外層 Form)，是因為 DrawToBitmap 依 Control 自身 Size 繪製，只要
        //    內容 Panel 的 Size 已依動態欄位量測涵蓋全部內容，即使外層以
        //    AutoScroll Panel 包裹只顯示部分畫面，匯出的PDF仍會包含完整內容 ────
        public static void PreviewAndExportPdf(Control content, string suggestedFileName)
        {
            int w = Math.Max(1, content.Width);
            int h = Math.Max(1, content.Height);
            var bmp = new System.Drawing.Bitmap(w, h);
            content.DrawToBitmap(bmp, new Rectangle(0, 0, w, h));

            var doc = new PdfSharp.Pdf.PdfDocument();
            var page = doc.AddPage();
            page.Width = PdfSharp.Drawing.XUnit.FromPoint(w * 72.0 / 96.0);
            page.Height = PdfSharp.Drawing.XUnit.FromPoint(h * 72.0 / 96.0);

            using (var gfx = PdfSharp.Drawing.XGraphics.FromPdfPage(page))
            using (var ms = new System.IO.MemoryStream())
            {
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                ms.Position = 0;
                var img = PdfSharp.Drawing.XImage.FromStream(ms);
                gfx.DrawImage(img, 0, 0, page.Width, page.Height);
            }

            doc.Save(suggestedFileName);
            byte[] pdfBytes = System.IO.File.ReadAllBytes(".\\" + suggestedFileName);
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF Files (*.pdf)|*.pdf";
                sfd.FileName = suggestedFileName;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllBytes(sfd.FileName, pdfBytes);
                    MessageBox.Show("PDF已儲存");
                }
            }
        }

        // ── 實體列印：彈出印表機選擇對話框後，將內容 Control 依所選印表機的可
        //    列印範圍等比例縮放後送印(單頁)。與 PreviewAndExportPdf 共用同一份
        //    點陣圖快照邏輯 ───────────────────────────────────────────────
        public static void PrintDirect(Control content)
        {
            int w = Math.Max(1, content.Width);
            int h = Math.Max(1, content.Height);
            var bmp = new System.Drawing.Bitmap(w, h);
            content.DrawToBitmap(bmp, new Rectangle(0, 0, w, h));

            using (var pd = new System.Drawing.Printing.PrintDocument())
            using (var dlg = new PrintDialog { Document = pd, UseEXDialog = true })
            {
                if (dlg.ShowDialog() != DialogResult.OK) return;

                pd.PrintPage += (s, e) =>
                {
                    var bounds = e.MarginBounds;
                    float scale = Math.Min((float)bounds.Width / w, (float)bounds.Height / h);
                    int drawW = (int)(w * scale);
                    int drawH = (int)(h * scale);
                    e.Graphics.DrawImage(bmp, bounds.Left, bounds.Top, drawW, drawH);
                };
                pd.Print();
            }
        }
    }
}
