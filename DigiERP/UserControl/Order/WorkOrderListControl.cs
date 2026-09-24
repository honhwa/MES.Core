using DigiERP.Common;
using DigiERP.Forms.Order;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigiERP.UserControl.Order
{
    // ── 工令單總覽：比照 PITS-2025.accdb 之「P-工令單總覽」表單，RecordSource 原
    //    查詢「工令單專案查詢」之 dbo_工令單 在 CHINYO 不存在，已修正為 工令單；
    //    原查詢排除 備註="零件工令" 及 專案序號 開頭為"G"者，此處沿用；查詢框
    //    (專案序號/客戶簡稱/機台類型/僅顯示未結案)為原巨集所無，方便維護大量
    //    資料而新增 ────────────────────────────────────────────────────
    //    按鈕對照原巨集：
    //      直接新增機台專案 (Command66)：開啟新分頁的空白 WorkOrderControl
    //      刪除工令單 (Command76)：DLookUp(編修,業務權限) 簡化為 chkEditPrivilege(id)，
    //                              若 核准 已填(已生效)則不可刪除，由後端 deleteWorkOrder 把關
    //      EXIT (Command75)：關閉本頁籤
    //    專案序號 OnDblClick 依機台類型路由至 5 個不同編輯畫面(P-工令單S&PJ/FB/
    //    GT/M/H)，經比對 5 個畫面皆為同一張 工令單 資料表不同欄位子集的版面，
    //    故此處統一以單一 WorkOrderControl 開啟(不論機台類型)。
    //    自訂單新增機台 (Command81 → P-專案機台一覽2025)：列出業務訂單明細中
    //    已填專案序號、尚未建立工令單者，選定後執行原「成交機台轉工令2025」+
    //    「成交機台轉產規2025」兩個新增查詢建立 工令單/產品規格單。
    //    開啟對照工令單 (Command82)：原巨集依機台類型開啟對應的"-S"唯讀比對畫面
    //    (RecordSource 皆為「工令單內容-Others」查詢，AllowEdits/Additions/
    //    Deletions 皆關閉)，經比對其篩選條件與主畫面相同(同一專案序號)，僅差在
    //    唯讀，故此處以現有 WorkOrderControl 加上唯讀模式取代 5 個"-S"畫面 ───
    public partial class WorkOrderListControl : CommonUserControl
    {
        private static string id = "EC2A2CB7-E758-4A4B-94FD-FE0809EA2AD2";

        public WorkOrderListControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
            DigiERP.Common.UIStyle.ApplyControlStyle(this);
            LoadData();
        }

        private void LoadData()
        {
            var rep = new WorkOrderController().GetWorkOrderOverviewList(
                txtProjectNo.Text.Trim(), txtCustName.Text.Trim(), cmbMachineType.Text.Trim(), chkOnlyOpen.Checked);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            dataGridView1.Rows.Clear();
            foreach (var x in rep.resultList ?? new List<工令單>())
            {
                int i = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                row.Cells[colProjectNo.Index].Value = x.專案序號;
                row.Cells[colOrderDate.Index].Value = ShortDate(x.訂單日期);
                row.Cells[colCustName.Index].Value = x.客戶簡稱;
                row.Cells[colCountry.Index].Value = x.國家地區;
                row.Cells[colRefNo.Index].Value = x.參考序號;
                row.Cells[colMachineType.Index].Value = x.機台類型;
                row.Cells[colMachineModel.Index].Value = x.機台型號;
                row.Cells[colMachineName.Index].Value = x.機台名稱;
                row.Cells[colTestDate.Index].Value = ShortDate(x.驗機日期);
                row.Cells[colFactoryTest.Index].Value = x.廠驗;
                row.Cells[colDeliveryDate.Index].Value = ShortDate(x.交貨日期);
                row.Cells[colInstall.Index].Value = x.裝機;
                row.Cells[colClosed.Index].Value = ToBool(x.結案);
                row.Tag = x.專案序號;
            }
        }

        private static string ShortDate(string dt)
        {
            if (string.IsNullOrWhiteSpace(dt)) return "";
            int sp = dt.IndexOf(' ');
            return sp > 0 ? dt.Substring(0, sp) : dt;
        }

        private static bool ToBool(string v)
        {
            if (string.IsNullOrWhiteSpace(v)) return false;
            if (bool.TryParse(v, out bool b)) return b;
            return v == "1";
        }

        private void btnQuery_Click(object sender, EventArgs e) => LoadData();

        // ── 直接新增機台專案：比照 Command66，開新分頁的空白編輯畫面 ─────────
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!chkEditPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法新增!");
                return;
            }
            OpenDetailTab(null, true);
        }

        // ── 自訂單新增機台2025 (Command81)：開啟訂單機台選擇畫面，轉開工令單成功
        //    後直接開啟該筆新工令單的編輯畫面 ─────────────────────────────
        private void btnAddFromOrder_Click(object sender, EventArgs e)
        {
            if (!chkEditPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法新增!");
                return;
            }
            using var frm = new FrmSelectOrderMachine();
            if (frm.ShowDialog(FindForm()) == DialogResult.OK && !string.IsNullOrEmpty(frm.ConvertedProjectNo))
            {
                LoadData();
                OpenDetailTab(frm.ConvertedProjectNo, false);
            }
        }

        // ── 開啟對照工令單 (Command82)：比照 DLookUp(編修,業務權限) 簡化為
        //    chkEditPrivilege(id)；以唯讀模式開啟目前選取列的工令單明細 ────────
        private void btnCompare_Click(object sender, EventArgs e)
        {
            if (!chkEditPrivilege(id))
            {
                MessageBox.Show("抱歉：非經授權，不得進入！");
                return;
            }
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("請先選擇要對照的紀錄!");
                return;
            }
            string projectNo = dataGridView1.CurrentRow.Cells[colProjectNo.Index].Value?.ToString();
            if (string.IsNullOrEmpty(projectNo)) return;
            OpenDetailTab(projectNo, false, readOnly: true);
        }

        // ── 刪除工令單：比照 Command76 ────────────────────────────────────
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!chkEditPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法刪除!");
                return;
            }
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("請先選擇要刪除的紀錄!");
                return;
            }
            string projectNo = dataGridView1.CurrentRow.Cells[colProjectNo.Index].Value?.ToString();
            if (string.IsNullOrEmpty(projectNo)) return;

            if (MessageBox.Show("請確認游標所在位置是您要刪除的紀錄?", "確認刪除", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            var rep = new WorkOrderController().DeleteWorkOrder(projectNo);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            MessageBox.Show("刪除成功!");
            LoadData();
        }

        // ── 結案：比照 專案序號 OnDblClick 旁的 結案 欄位 OnDblClick，簡化為直接
        //    UPDATE(原巨集透過隱藏表單"P-規格"間接寫入) ─────────────────────
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string projectNo = dataGridView1.Rows[e.RowIndex].Cells[colProjectNo.Index].Value?.ToString();
            if (string.IsNullOrEmpty(projectNo)) return;

            if (dataGridView1.Columns[e.ColumnIndex] == colProjectNo)
            {
                OpenDetailTab(projectNo, false);
                return;
            }

            if (dataGridView1.Columns[e.ColumnIndex] == colClosed)
            {
                if (!chkEditPrivilege(id))
                {
                    MessageBox.Show("非授權使用者無法進行結案!");
                    return;
                }
                bool current = ToBool(dataGridView1.Rows[e.RowIndex].Cells[colClosed.Index].Value?.ToString());
                if (current) return; // 已結案不重複詢問
                if (MessageBox.Show("您確定要將此工令單進行結案?", "結案確認", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

                var rep = new WorkOrderController().CloseWorkOrder(projectNo, true);
                if (!string.IsNullOrEmpty(rep.ErrorMessage))
                {
                    MessageBox.Show(rep.ErrorMessage);
                    return;
                }
                LoadData();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 保留供未來單擊互動使用(目前互動皆採雙擊，比照原巨集之 OnDblClick)
        }

        // ── 專案序號 OnDblClick：原巨集依機台類型路由至 5 個不同編輯畫面，經比對
        //    皆為同一資料表不同欄位子集，故統一開啟同一個 WorkOrderControl ────
        private void OpenDetailTab(string projectNo, bool isNew, bool readOnly = false)
        {
            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl))
            {
                var ctrlStandalone = new WorkOrderControl { Dock = DockStyle.Fill };
                ctrlStandalone.LoadData(projectNo, isNew, readOnly);
                return;
            }
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            string tabName = isNew ? "WorkOrder_NEW" : (readOnly ? "WorkOrderView_" : "WorkOrder_") + projectNo;
            string tabText = isNew ? "新增工令單" : (readOnly ? "工令單對照-" + projectNo : "工令單-" + projectNo);
            DigiERP.Common.TabNavigator.Open(tabControl, tabName, tabText, () =>
            {
                var ctrl = new WorkOrderControl { Dock = DockStyle.Fill };
                ctrl.SavedOrClosed += () =>
                {
                    foreach (TabPage page in tabControl.TabPages)
                    {
                        if (page.Name == tabName)
                        {
                            tabControl.TabPages.Remove(page);
                            break;
                        }
                    }
                    LoadData();
                };
                ctrl.LoadData(projectNo, isNew, readOnly);
                return ctrl;
            });
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
