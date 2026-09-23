using DigiERP.Common;
using DigiERP.Models;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Order
{
    // ── 工令時程表：比照 PITS-2025.accdb「P-工令時程表」(Caption="機台管制表")
    //    還原，含內嵌子表單「P-工令時程明細」(Caption誤植"P-工程分析"，屬複製
    //    貼上殘留，RecordSource=dbo_工令時程表，真實表名 工令時程表)。表頭欄位
    //    來自 工令單 直接讀取(專案序號/訂單日期/客戶簡稱/機台型號/機台類型/機台
    //    名稱/驗機日期/交貨日期/廠驗/裝機/客戶名稱/結案)。
    //    明細Grid「執行人員」ComboBox 之 ControlSource 實際指向 執行單位 欄位
    //    (原表單另有一同區塊的唯讀 DLookUp 顯示欄位，僅供UI提示隸屬單位、不寫
    //    入資料庫，本次未納入)；「工序名稱」「統合工段」「工時成本小計」皆為
    //    DLookUp/計算衍生欄位，非資料表實際欄位，本畫面改為依 工序代號 於本機
    //    快取之 工序設定 清單即時查表計算。
    //    按鈕邏輯對照原巨集：
    //      專案進度追蹤 → 開啟新建 ProjectProgressGanttControl(同資料夾，
    //                     12週滾動甘特圖，比照 P-專案管制進度；原先誤判為
    //                     ProjectProgressDetailControl，已改正)。
    //      總覽         → 開啟新建 ProjectScheduleListControl(同資料夾，全專案
    //                     A~E工時總覽，比照 P-專案管制進度總覽；原先誤判為
    //                     ProjectProgressControl，已改正)。
    //      日誌工時統計 → 開啟新建 WorkOrderScheduleStatsControl(同資料夾)，比
    //                     較5段(設計/加工/組裝/電控/試車)預估與實際耗用工時。
    //      修改/儲存/關閉 → 標準編輯流程 ─────────────────────────────────────
    public partial class WorkOrderScheduleControl : CommonUserControl
    {
        private static string id = "60C78435-EFCC-4A95-BA2F-F616D62693B3";

        private string _projectNo;
        private List<工序設定> _procedures = new List<工序設定>();

        public event Action SavedOrClosed;

        public WorkOrderScheduleControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
            DigiERP.Common.UIStyle.ApplyControlStyle(this);
            initCombos();
            SetEditable(false);
        }

        private void initCombos()
        {
            var procRep = new WorkOrderScheduleController().GetProcedureList();
            _procedures = string.IsNullOrEmpty(procRep.ErrorMessage) ? (procRep.resultList ?? new List<工序設定>()) : new List<工序設定>();
            colProcCode.Items.Clear();
            colProcCode.Items.AddRange(_procedures.Select(p => p.工序代號).Where(c => !string.IsNullOrEmpty(c)).ToArray());

            var staffRep = new ProjectMeetingController().GetActiveAccountList();
            var staffNames = string.IsNullOrEmpty(staffRep.ErrorMessage)
                ? (staffRep.resultList ?? new List<account>()).Select(a => a.姓名).Where(n => !string.IsNullOrEmpty(n)).Distinct().ToArray()
                : new string[0];
            colHandler.Items.Clear();
            colHandler.Items.AddRange(staffNames);
        }

        public void LoadData(string projectNo)
        {
            _projectNo = projectNo;
            var woRep = new WorkOrderController().GetWorkOrderDetail(projectNo);
            工令單 w = (!string.IsNullOrEmpty(woRep.ErrorMessage) || woRep.result == null) ? new 工令單() : woRep.result;

            txt專案序號.Text = w.專案序號;
            SetDate(txt訂單日期, w.訂單日期);
            txt客戶簡稱.Text = w.客戶簡稱;
            txt客戶名稱.Text = w.客戶名稱;
            txt機台型號.Text = w.機台型號;
            txt機台類型.Text = w.機台類型;
            txt機台名稱.Text = w.機台名稱;
            txt驗機日期.Text = ShortDate(w.驗機日期);
            SetDate(txt交貨日期, w.交貨日期);
            txt廠驗.Text = w.廠驗;
            txt裝機.Text = w.裝機;
            chk結案.Checked = ToBool(w.結案);

            LoadScheduleGrid(projectNo);
            SetEditable(false);
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
        }

        private void LoadScheduleGrid(string projectNo)
        {
            dataGridView1.Rows.Clear();
            var rep = new WorkOrderScheduleController().GetWorkOrderScheduleList(projectNo);
            if (string.IsNullOrEmpty(rep.ErrorMessage))
            {
                foreach (var d in rep.resultList ?? new List<工令時程表>())
                {
                    int i = dataGridView1.Rows.Add();
                    var row = dataGridView1.Rows[i];
                    row.Cells[colProcCode.Index].Value = d.工序代號;
                    row.Cells[colEstHours.Index].Value = d.預估工時;
                    row.Cells[colHourCost.Index].Value = d.工時成本;
                    row.Cells[colStartDate.Index].Value = ShortDate(d.起始日);
                    row.Cells[colEndDate.Index].Value = ShortDate(d.完成日);
                    row.Cells[colHandler.Index].Value = d.執行單位;
                    row.Cells[colModify.Index].Value = d.修改;
                    row.Cells[colModifyDate.Index].Value = ShortDate(d.修改日);
                    row.Cells[colCreate.Index].Value = d.建檔;
                    row.Cells[colCreateDate.Index].Value = ShortDate(d.建檔日);
                    RefreshDerivedColumns(row);
                }
            }
            RecalcSum();
        }

        // ── 依 工序代號 於本機快取之 工序設定 帶出 工序名稱/統合工段，並計算
        //    工時成本小計=預估工時*工時成本(比照原表單 HRCOST 計算欄位) ─────────
        private void RefreshDerivedColumns(DataGridViewRow row)
        {
            string code = row.Cells[colProcCode.Index].Value?.ToString();
            var proc = _procedures.FirstOrDefault(p => p.工序代號 == code);
            row.Cells[colProcName.Index].Value = proc?.工序名稱;
            row.Cells[colConsolidated.Index].Value = proc?.統合工段 ?? false;

            decimal.TryParse(row.Cells[colEstHours.Index].Value?.ToString(), out var hours);
            decimal.TryParse(row.Cells[colHourCost.Index].Value?.ToString(), out var cost);
            row.Cells[colCostSub.Index].Value = hours * cost;
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty) dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dataGridView1.Rows[e.RowIndex];
            if (e.ColumnIndex == colProcCode.Index || e.ColumnIndex == colEstHours.Index || e.ColumnIndex == colHourCost.Index)
            {
                RefreshDerivedColumns(row);
            }
            RecalcSum();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        // ── 合計數：Sum(預估工時)/Sum(工時成本小計)，比照原表單 Text833/Text834
        //    (本畫面改為直接加總畫面上明細列，不再另行查詢彙總查詢) ─────────────
        private void RecalcSum()
        {
            decimal sumHours = 0, sumCost = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                if (decimal.TryParse(row.Cells[colEstHours.Index].Value?.ToString(), out var h)) sumHours += h;
                if (decimal.TryParse(row.Cells[colCostSub.Index].Value?.ToString(), out var c)) sumCost += c;
            }
            txtSumEstHours.Text = sumHours.ToString();
            txtSumCost.Text = sumCost.ToString();
        }

        private static string ShortDate(string dt)
        {
            if (string.IsNullOrWhiteSpace(dt)) return "";
            int sp = dt.IndexOf(' ');
            return sp > 0 ? dt.Substring(0, sp) : dt;
        }

        private static void SetDate(DateTimePicker dtp, string value)
        {
            dtp.Value = DateTime.TryParse(value, out var d) ? d : DateTime.Parse("1900-01-01");
        }

        private static bool ToBool(string v)
        {
            if (string.IsNullOrWhiteSpace(v)) return false;
            if (bool.TryParse(v, out bool b)) return b;
            return v == "1";
        }

        private void SetEditable(bool editable)
        {
            dataGridView1.ReadOnly = !editable;
            dataGridView1.AllowUserToAddRows = editable;
            dataGridView1.AllowUserToDeleteRows = editable;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!chkEditPrivilege(id))
            {
                MessageBox.Show("抱歉：非經授權，不得進入！");
                return;
            }
            SetEditable(true);
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!chkEditPrivilege(id))
            {
                MessageBox.Show("抱歉：非經授權，不得進入！");
                return;
            }
            dataGridView1.EndEdit();

            string username = AppSession.User?.username;
            string today = DateTime.Now.ToString("yyyy-MM-dd");
            var list = new List<工令時程表>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                string code = row.Cells[colProcCode.Index].Value?.ToString();
                if (string.IsNullOrEmpty(code)) continue;

                string existingCreate = row.Cells[colCreate.Index].Value?.ToString();
                string existingCreateDate = row.Cells[colCreateDate.Index].Value?.ToString();

                decimal.TryParse(row.Cells[colEstHours.Index].Value?.ToString(), out var hours);
                decimal.TryParse(row.Cells[colHourCost.Index].Value?.ToString(), out var cost);

                list.Add(new 工令時程表
                {
                    工序代號 = code,
                    預估工時 = hours,
                    工時成本 = cost,
                    起始日 = row.Cells[colStartDate.Index].Value?.ToString(),
                    完成日 = row.Cells[colEndDate.Index].Value?.ToString(),
                    執行單位 = row.Cells[colHandler.Index].Value?.ToString(),
                    建檔 = string.IsNullOrEmpty(existingCreate) ? username : existingCreate,
                    建檔日 = string.IsNullOrEmpty(existingCreateDate) ? today : existingCreateDate,
                    修改 = username,
                    修改日 = today,
                });
            }

            var rep = new WorkOrderScheduleController().SaveWorkOrderScheduleList(new SaveWorkOrderScheduleRequest { ProjectNo = _projectNo, List = list });
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }

            MessageBox.Show("儲存成功!");
            SetEditable(false);
            LoadData(_projectNo);
            SavedOrClosed?.Invoke();
        }

        // ── 專案進度追蹤：原巨集(Command223) OpenForm "P-專案管制進度"，
        //    開啟新建 ProjectProgressGanttControl(同資料夾，12週滾動甘特圖) ────
        private void btnProgress_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_projectNo))
            {
                MessageBox.Show("請先選擇專案序號!");
                return;
            }
            OpenInTab("ProjectProgressGantt_" + _projectNo, "專案進度追蹤-" + _projectNo,
                () => { var ctrl = new ProjectProgressGanttControl { Dock = DockStyle.Fill }; ctrl.LoadData(_projectNo); return ctrl; });
        }

        // ── 總覽：原巨集(Command"總覽") OpenForm "P-專案管制進度總覽"(Caption=
        //    "專案時程總覽")，開啟新建 ProjectScheduleListControl(同資料夾；原
        //    先前誤植沿用 ProjectProgressControl，非同一物件，已改正)。原巨集
        //    另會 Close 呼叫端 P-工令時程表，本畫面改採分頁並存，不強制關閉 ──
        private void btnOverview_Click(object sender, EventArgs e)
        {
            OpenInTab("ProjectScheduleList", "專案時程總覽",
                () => new ProjectScheduleListControl { Dock = DockStyle.Fill });
        }

        // ── 日誌工時統計：原巨集 OpenForm "P-工令時程"，開啟新建
        //    WorkOrderScheduleStatsControl ─────────────────────────────────────
        private void btnHoursStats_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_projectNo))
            {
                MessageBox.Show("請先選擇專案序號!");
                return;
            }
            OpenInTab("ScheduleStats_" + _projectNo, "日誌工時統計-" + _projectNo,
                () => { var ctrl = new WorkOrderScheduleStatsControl { Dock = DockStyle.Fill }; ctrl.LoadData(_projectNo); return ctrl; });
        }

        // ── 共用：於同一 TabControl 開啟(或切換至)指定名稱的分頁 ─────────────────
        private void OpenInTab(string tabName, string tabTitle, Func<System.Windows.Forms.Control> createControl)
        {
            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl))
            {
                var standalone = createControl();
                standalone.Dock = DockStyle.Fill;
                return;
            }
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == tabName)
                {
                    tabControl.SelectedTab = page;
                    return;
                }
            }
            var ctrl = createControl();
            var tab = new TabPage(tabTitle) { Name = tabName };
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var parentCtrl = Parent;
            if (parentCtrl is TabPage tabPage && tabPage.Parent is TabControl tabControl)
            {
                tabControl.TabPages.Remove(tabPage);
                Dispose();
                SavedOrClosed?.Invoke();
                return;
            }
            if (parentCtrl != null)
            {
                parentCtrl.Controls.Remove(this);
            }
            Dispose();
            SavedOrClosed?.Invoke();
        }
    }
}
