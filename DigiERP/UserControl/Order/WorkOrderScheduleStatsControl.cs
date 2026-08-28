using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigiERP.UserControl.Order
{
    // ── 日誌工時統計：比照 PITS-2025.accdb「P-工令時程」，由「P-工令時程表」
    //    (WorkOrderScheduleControl)「日誌工時統計」按鈕開啟。比較5段(設計/加工/
    //    組裝/電控/試車)之預估工時(工令時程表.預估工時 依工序代號A~E加總)與
    //    實際耗用工時(工作日誌/工作紀錄A 依職務或任務分類加總)。
    //    原巨集「專案工時查詢」WHERE 條件「任務分類<>"整機試車" OR 任務分類<>
    //    "機台驗收"」恆為真、形同無過濾，判斷為原設計錯誤(應為 AND/NOT IN)，
    //    已於後端 WorkOrderScheduleMiddle.getHoursComparison 修正 ─────────────
    public partial class WorkOrderScheduleStatsControl : System.Windows.Forms.UserControl
    {
        public WorkOrderScheduleStatsControl()
        {
            InitializeComponent();
        }

        public void LoadData(string projectNo)
        {
            txt專案序號.Text = projectNo;
            dataGridView1.Rows.Clear();
            var rep = new WorkOrderScheduleController().GetWorkOrderScheduleHoursComparison(projectNo);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            foreach (var x in rep.resultList ?? new List<工令時程統計>())
            {
                int i = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                row.Cells[colPhase.Index].Value = x.工段名稱;
                row.Cells[colEst.Index].Value = x.預估工時;
                row.Cells[colActual.Index].Value = x.耗用工時;
                row.Cells[colRatio.Index].Value = x.比率 == null ? "" : x.比率.Value.ToString("P1");
            }
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
