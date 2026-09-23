using DigiERP.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Order
{
    // ── 專案管制進度追蹤：比照 PITS-2025.accdb「P-專案管制進度」，由「P-工令
    //    時程表」(WorkOrderScheduleControl)「專案進度追蹤」按鈕開啟(原巨集
    //    Command223，非開啟既有 ProjectProgressDetailControl，屬先前誤判，
    //    已改正)。以 工令時程表(LEFT JOIN 工序設定) 每筆時程列，相對「今天」
    //    滾動 12 週逐週標示 Start/WIP/Finished/C(空白=尚未開始)，資料/欄位對照
    //    原查詢「專案管制進度追蹤」───────────────────────────────────────────
    public partial class ProjectProgressGanttControl : CommonUserControl
    {
        private static string id = "CFE40E0A-F5DA-472F-A999-79FCAC8C060D";

        private static readonly string[] _ordinals =
        {
            "1st", "2nd", "3rd", "4th", "5th", "6th", "7th", "8th", "9th", "10th", "11th", "12th"
        };

        public ProjectProgressGanttControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
            DigiERP.Common.UIStyle.ApplyControlStyle(this);
        }

        public void LoadData(string projectNo)
        {
            txt專案序號.Text = projectNo;

            var procRep = new WorkOrderScheduleController().GetProcedureList();
            var procedures = string.IsNullOrEmpty(procRep.ErrorMessage) ? (procRep.resultList ?? new List<工序設定>()) : new List<工序設定>();

            var rep = new WorkOrderScheduleController().GetWorkOrderScheduleList(projectNo);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }

            var today = DateTime.Today;
            var weekStarts = new DateTime[12];
            for (int i = 0; i < 12; i++) weekStarts[i] = today.AddDays(7 * i);
            var weekCols = GetWeekColumns();
            for (int i = 0; i < 12; i++)
            {
                weekCols[i].HeaderText = _ordinals[i] + " W\n" + weekStarts[i].ToString("MM/dd");
            }

            dataGridView1.Rows.Clear();
            foreach (var x in rep.resultList ?? new List<工令時程表>())
            {
                var proc = procedures.FirstOrDefault(p => p.工序代號 == x.工序代號);
                int r = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[r];
                row.Cells[colProjectNo.Index].Value = x.專案序號;
                row.Cells[colProcCode.Index].Value = x.工序代號;
                row.Cells[colProcName.Index].Value = proc?.工序名稱;
                row.Cells[colHours.Index].Value = x.預估工時;
                row.Cells[colStartDate.Index].Value = ShortDate(x.起始日);
                row.Cells[colEndDate.Index].Value = ShortDate(x.完成日);
                row.Cells[colUnit.Index].Value = proc?.隸屬單位;
                row.Cells[colHandler.Index].Value = x.執行單位;

                DateTime? start = DateTime.TryParse(x.起始日, out var sd) ? sd : (DateTime?)null;
                DateTime? end = DateTime.TryParse(x.完成日, out var ed) ? ed : (DateTime?)null;
                for (int i = 0; i < 12; i++)
                {
                    row.Cells[weekCols[i].Index].Value = ComputeWeekStatus(start, end, weekStarts[i], weekStarts[i].AddDays(7));
                }
            }
        }

        // ── 對照原查詢「專案管制進度追蹤」12 組 IIf() 計算欄位邏輯，[ws,we) 為
        //    該週區間 ────────────────────────────────────────────────────────
        private static string ComputeWeekStatus(DateTime? start, DateTime? end, DateTime ws, DateTime we)
        {
            if (start == null) return "";
            if (start.Value >= ws)
            {
                return start.Value >= we ? "" : "Start";
            }
            if (end == null) return "WIP";
            if (end.Value < we)
            {
                return end.Value < ws ? "C" : "Finished";
            }
            return "WIP";
        }

        private DataGridViewColumn[] GetWeekColumns() => new DataGridViewColumn[]
        {
            colWeek1, colWeek2, colWeek3, colWeek4, colWeek5, colWeek6,
            colWeek7, colWeek8, colWeek9, colWeek10, colWeek11, colWeek12
        };

        // ── 週狀態欄位著色，比照原表單格式化條件 ─────────────────────────────
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var col = dataGridView1.Columns[e.ColumnIndex];
            if (!col.Name.StartsWith("colWeek")) return;
            switch (e.Value?.ToString())
            {
                case "Start":
                    e.CellStyle.BackColor = Color.FromArgb(186, 213, 168);
                    break;
                case "WIP":
                    e.CellStyle.BackColor = Color.FromArgb(141, 207, 239);
                    break;
                case "Finished":
                    e.CellStyle.BackColor = Color.FromArgb(120, 149, 226);
                    break;
                case "C":
                    e.CellStyle.BackColor = Color.FromArgb(200, 200, 200);
                    break;
            }
        }

        private static string ShortDate(string dt)
        {
            if (string.IsNullOrWhiteSpace(dt)) return "";
            int sp = dt.IndexOf(' ');
            return sp > 0 ? dt.Substring(0, sp) : dt;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var parentCtrl = Parent;
            if (parentCtrl is TabPage tabPage && tabPage.Parent is TabControl tabControl)
            {
                tabControl.TabPages.Remove(tabPage);
                Dispose();
                return;
            }
            if (parentCtrl != null)
            {
                parentCtrl.Controls.Remove(this);
            }
            Dispose();
        }
    }
}
