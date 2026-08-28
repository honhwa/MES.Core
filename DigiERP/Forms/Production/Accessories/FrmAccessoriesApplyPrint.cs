using DigiERP.Forms.Reports;
using MES.Core.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigiERP.Forms.Production.Accessories
{
    // ── 零件工令單列印預覽：比照 PITS-2025.accdb Report「零件工令單」。原表單
    //    Caption標示「核准人員/建檔人員」欄位，其 ControlSource 實際分別綁定
    //    核准/建檔(而非核准人員/建檔人員本身)，已依標準作法採信 ControlSource ──
    public partial class FrmAccessoriesApplyPrint : DigiERP.Forms.CommonForm
    {
        private readonly 零件申請單 _form;

        public FrmAccessoriesApplyPrint(零件申請單 form)
        {
            InitializeComponent();
            _form = form;
            initData();
        }

        private void initData()
        {
            if (_form == null) return;
            txt單號.Text = _form.單號;
            txt申請日期.Text = ShortDate(_form.申請日期);
            txt申請用途.Text = _form.申請用途;
            txt專案序號.Text = _form.專案序號;
            txt客戶名稱.Text = _form.客戶簡稱;
            txt申請人.Text = _form.申請人;
            txt運送方式.Text = _form.運送方式;
            txt收費機制.Text = _form.收費機制;
            txt交貨日期.Text = ShortDate(_form.交貨日期);
            txt機台名稱.Text = _form.機台名稱;
            txt保固效期.Text = ShortDate(_form.保固效期);
            txt機台型號.Text = _form.機台型號;
            txt主旨.Text = _form.主旨;

            txt核准人員.Text = _form.核准;
            txt核准日.Text = ShortDate(_form.核准日);
            txt建檔人員.Text = _form.建檔;
            txt建檔日.Text = ShortDate(_form.建檔日);

            dataGridView1.Rows.Clear();
            foreach (var x in _form.detailList ?? new List<零件申請明細>())
            {
                int i = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                row.Cells[colPartType.Index].Value = x.零件分類;
                row.Cells[colPartNo.Index].Value = x.零件號碼;
                row.Cells[colItemName.Index].Value = x.品名;
                row.Cells[colDesc.Index].Value = x.描述;
                row.Cells[colUnit.Index].Value = x.單位;
                row.Cells[colQty.Index].Value = x.數量;
                row.Cells[colOwner.Index].Value = x.附屬模組;
                row.Cells[colRemark.Index].Value = x.備註;
            }
        }

        private static string ShortDate(string dt)
        {
            if (string.IsNullOrWhiteSpace(dt)) return "";
            int sp = dt.IndexOf(' ');
            return sp > 0 ? dt.Substring(0, sp) : dt;
        }

        // ── 匯出PDF：比照 ReportLayoutHelper.PreviewAndExportPdf 之全畫面點陣圖轉
        //    單頁PDF作法(共用於本次新建之全部報表列印畫面)。刻意傳入 pnlContent
        //    (而非整個Form)，使「列印/匯出PDF/EXIT」按鈕不會被印入PDF內容 ───────
        private void btnPreviewPrint_Click(object sender, EventArgs e)
        {
            ReportLayoutHelper.PreviewAndExportPdf(pnlContent, $"零件工令單{_form?.單號}_{DateTime.Now:yyyyMMddHHmmssfff}.pdf");
        }

        // ── 列印：彈出印表機選擇對話框直接送印 ────────────────────────────────
        private void btnPrint_Click(object sender, EventArgs e)
        {
            ReportLayoutHelper.PrintDirect(pnlContent);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
