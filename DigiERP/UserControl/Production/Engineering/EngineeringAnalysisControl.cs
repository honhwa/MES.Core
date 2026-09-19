using DigiERP.Common;
using DigiERP.Models;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production.Engineering
{
    // ── 工程分析表：比照 PITS-2025.accdb「P-工程」表單(按鈕標題即為「工程分析
    //    表」)。RecordSource 直接就是 工令單(非另建資料表)，畫面上半部為工令單
    //    既有欄位的唯讀參考顯示；中央清單為子表單「P-工程分析」(繫結資料表
    //    工程分析表)，逐模組(模組編碼A-Z)拆解製圖/加工/組裝/電控預估工時；下方
    //    為 建檔_工程/修改_工程/核准_工程(+日期) 6 個本表單專屬簽核欄位。
    //
    //    按鈕邏輯對照原巨集(與 WorkOrderControl/ProductSpecControl 同款式)：
    //      修改：需 業務權限.編修 或 設計權限.編修(簡化為 chkEditPrivilege)；
    //            已生效(核准_工程 已填)者不得修改；解鎖後可編輯模組清單。
    //      儲存：RunMacro「儲存-工程」，建檔_工程 為空表示第一次存檔，否則視為
    //            修改；同時儲存模組清單(先刪除該專案序號全部舊紀錄再重新新增)。
    //      生效：需 chkApprovePrivilege；寫入 核准_工程/核准日_工程，並比照原
    //            巨集查詢「設計派案移轉」，將 工程分析表 中 製圖>0 的模組(依
    //            設計模組表 取得檢查分類)轉入 設計派案，作為後續設計派工依據。
    //      取消生效：需 chkApprovePrivilege；清空 核准_工程/核准日_工程，並比
    //            照原巨集查詢「設計派案收回」，刪除尚未實際開工的對應 設計派案
    //            紀錄。
    //      列印：原巨集此按鈕未附加任何動作，暫以提示取代。
    //      總覽：原巨集開啟「P-工程總覽」，本次尚未建立對應畫面，暫以提示取代。
    //      關閉：關閉本分頁 ──────────────────────────────────────────────
    public partial class EngineeringAnalysisControl : CommonUserControl
    {
        private static string id = "94536306-165E-4091-9573-A4E75EBFD17A";

        private string _loadedProjectNo;
        private List<設計模組表> _designModules = new List<設計模組表>();
        private Dictionary<string, string> _checkCategoryByModule = new Dictionary<string, string>();
        private bool _loading;

        public event Action Closed;

        public EngineeringAnalysisControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
            DigiERP.Common.UIStyle.ApplyControlStyle(this);
            initDesignModuleCombo();
        }

        // ── 模組名稱下拉：全部 設計模組表 模組，並建立「模組名稱→檢查分類」查表 ──
        private void initDesignModuleCombo()
        {
            var rep = new EngineeringAnalysisController().GetAllDesignModuleList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _designModules = rep.resultList ?? new List<設計模組表>();
            colModuleName.Items.Clear();
            foreach (var m in _designModules)
            {
                if (!string.IsNullOrEmpty(m.模組名稱) && !colModuleName.Items.Contains(m.模組名稱))
                {
                    colModuleName.Items.Add(m.模組名稱);
                }
                if (!string.IsNullOrEmpty(m.模組名稱) && !_checkCategoryByModule.ContainsKey(m.模組名稱))
                {
                    _checkCategoryByModule[m.模組名稱] = m.檢查分類;
                }
            }
        }

        // ── 是否具備「核准」權限：比照 CommonUserControl.chkEditPrivilege 的寫法，
        //    改判斷 核准 旗標(業務權限.核准) ───────────────────────────────
        private bool chkApprovePrivilege(string privId)
        {
            if (AppSession.User?.name?.ToUpper() == "ADMIN") return true;
            foreach (var item in AppSession.User.privilegeList)
            {
                if (item.授權子表單?.ToString().ToLower() == privId.ToLower())
                {
                    return (bool)(item.高管 ?? false) || (bool)(item.核准 ?? false);
                }
            }
            return false;
        }

        public void LoadData(string projectNo)
        {
            _loading = true;
            _loadedProjectNo = projectNo;

            var rep = new WorkOrderController().GetWorkOrderDetail(projectNo);
            工令單 model = (!string.IsNullOrEmpty(rep.ErrorMessage) || rep.result == null) ? new 工令單() : rep.result;
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
            }

            txt專案序號.Text = model.專案序號;
            txt訂單日期.Text = ShortDate(model.訂單日期);
            txt客戶簡稱.Text = model.客戶簡稱;
            txt客戶名稱.Text = model.客戶名稱;
            txt國家地區.Text = model.國家地區;
            chk結案.Checked = ToBool(model.結案);
            txt機台型號.Text = model.機台型號;
            txt機台類型.Text = model.機台類型;
            txt驗機日期.Text = ShortDate(model.驗機日期);
            txt交貨日期.Text = ShortDate(model.交貨日期);
            txt機台名稱.Text = model.機台名稱;
            txt廠驗.Text = model.廠驗;
            txt裝機.Text = model.裝機;

            txtF核准.Text = model.核准_工程;
            txtF核准日.Text = ShortDate(model.核准日_工程);
            txtF修改.Text = model.修改_工程;
            txtF修改日.Text = ShortDate(model.修改日_工程);
            txtF建檔.Text = model.建檔_工程;
            txtF建檔日.Text = ShortDate(model.建檔日_工程);

            var moduleRep = new EngineeringAnalysisController().GetEngineeringModuleList(projectNo);
            dataGridView1.Rows.Clear();
            if (!string.IsNullOrEmpty(moduleRep.ErrorMessage))
            {
                MessageBox.Show(moduleRep.ErrorMessage);
            }
            else
            {
                foreach (var x in moduleRep.resultList ?? new List<工程分析表>())
                {
                    int i = dataGridView1.Rows.Add();
                    var row = dataGridView1.Rows[i];
                    row.Cells[colModuleCode.Index].Value = x.模組編碼;
                    row.Cells[colModuleName.Index].Value = x.模組名稱;
                    row.Cells[colCheckCategory.Index].Value = LookupCheckCategory(x.模組名稱);
                    row.Cells[colMakeType.Index].Value = x.製作區分;
                    row.Cells[colLeadDays.Index].Value = x.採購前置天數;
                    row.Cells[colDrawHours.Index].Value = x.製圖;
                    row.Cells[colProcessHours.Index].Value = x.加工;
                    row.Cells[colAssembleHours.Index].Value = x.組裝;
                    row.Cells[colElecHours.Index].Value = x.電控;
                    row.Cells[colTotalHours.Index].Value = x.預估總工時;
                }
            }

            SetEditable(false);
            btnEdit.Enabled = true;
            btnSave.Enabled = false;

            bool approved = !string.IsNullOrEmpty(txtF核准.Text);
            btnApprove.Visible = !approved;
            btnUnapprove.Visible = approved;
            _loading = false;
        }

        private string LookupCheckCategory(string moduleName)
        {
            if (string.IsNullOrEmpty(moduleName)) return "";
            return _checkCategoryByModule.TryGetValue(moduleName, out var cat) ? cat : "";
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

        // ── 解鎖/鎖定模組清單(工令單參考欄位一律唯讀，不受此開關影響) ────────────
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
            if (!string.IsNullOrEmpty(txtF核准.Text))
            {
                MessageBox.Show("請主管先取消生效\n(已生效無法修改喔!)");
                return;
            }
            SetEditable(true);
            btnSave.Enabled = true;
        }

        // ── 儲存 (RunMacro「儲存-工程」)：建檔_工程 為空表示第一次存檔；同時存回
        //    模組清單 ─────────────────────────────────────────────────
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!chkEditPrivilege(id))
            {
                MessageBox.Show("抱歉：非經授權，不得進入！");
                return;
            }
            if (string.IsNullOrEmpty(_loadedProjectNo)) return;

            var list = new List<工程分析表>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                string moduleCode = row.Cells[colModuleCode.Index].Value?.ToString();
                string moduleName = row.Cells[colModuleName.Index].Value?.ToString();
                if (string.IsNullOrEmpty(moduleCode) && string.IsNullOrEmpty(moduleName)) continue;
                list.Add(new 工程分析表
                {
                    模組編碼 = moduleCode,
                    模組名稱 = moduleName,
                    製作區分 = row.Cells[colMakeType.Index].Value?.ToString(),
                    採購前置天數 = ParseInt(row.Cells[colLeadDays.Index].Value),
                    製圖 = ParseDecimal(row.Cells[colDrawHours.Index].Value),
                    加工 = ParseDecimal(row.Cells[colProcessHours.Index].Value),
                    組裝 = ParseDecimal(row.Cells[colAssembleHours.Index].Value),
                    電控 = ParseDecimal(row.Cells[colElecHours.Index].Value),
                    預估總工時 = ParseDecimal(row.Cells[colTotalHours.Index].Value),
                });
            }
            var saveRep = new EngineeringAnalysisController().SaveEngineeringModuleList(new SaveModuleListRequest { ProjectNo = _loadedProjectNo, List = list });
            if (!string.IsNullOrEmpty(saveRep.ErrorMessage))
            {
                MessageBox.Show(saveRep.ErrorMessage);
                return;
            }

            string username = AppSession.User?.username;
            string today = DateTime.Now.ToString("yyyy-MM-dd");
            string createdBy = string.IsNullOrEmpty(txtF建檔.Text) ? username : txtF建檔.Text;
            string createdDate = string.IsNullOrEmpty(txtF建檔日.Text) ? today : txtF建檔日.Text;

            var rep = new WorkOrderController().UpdateEngineeringAudit(_loadedProjectNo, createdBy, createdDate, username, today);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            MessageBox.Show("儲存成功!");
            LoadData(_loadedProjectNo);
        }

        private static int? ParseInt(object v) => int.TryParse(v?.ToString(), out var r) ? r : (int?)null;
        private static decimal? ParseDecimal(object v) => decimal.TryParse(v?.ToString(), out var r) ? r : (decimal?)null;

        // ── 模組名稱變更時查表帶出檢查分類；工時欄位變更時重新加總預估總工時 ────
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (_loading || e.RowIndex < 0) return;
            var row = dataGridView1.Rows[e.RowIndex];

            if (e.ColumnIndex == colModuleName.Index)
            {
                string moduleName = row.Cells[colModuleName.Index].Value?.ToString();
                row.Cells[colCheckCategory.Index].Value = LookupCheckCategory(moduleName);
            }

            if (e.ColumnIndex == colDrawHours.Index || e.ColumnIndex == colProcessHours.Index ||
                e.ColumnIndex == colAssembleHours.Index || e.ColumnIndex == colElecHours.Index)
            {
                decimal total = (ParseDecimal(row.Cells[colDrawHours.Index].Value) ?? 0)
                               + (ParseDecimal(row.Cells[colProcessHours.Index].Value) ?? 0)
                               + (ParseDecimal(row.Cells[colAssembleHours.Index].Value) ?? 0)
                               + (ParseDecimal(row.Cells[colElecHours.Index].Value) ?? 0);
                row.Cells[colTotalHours.Index].Value = total;
            }
        }

        // ── 下拉選單選擇後立即提交，讓 CellValueChanged 即時觸發查表/加總 ────────
        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        // ── 生效：寫入 核准_工程/核准日_工程，並觸發設計派案移轉(於 Middle 層以
        //    交易一併處理) ─────────────────────────────────────────────
        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (!chkApprovePrivilege(id))
            {
                MessageBox.Show("抱歉：非經授權，不得進入！");
                return;
            }
            var rep = new WorkOrderController().ApproveEngineering(_loadedProjectNo, AppSession.User?.username);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            MessageBox.Show("生效成功，已建立設計派案!");
            LoadData(_loadedProjectNo);
        }

        private void btnUnapprove_Click(object sender, EventArgs e)
        {
            if (!chkApprovePrivilege(id))
            {
                MessageBox.Show("抱歉：非經授權，不得進入！");
                return;
            }
            if (MessageBox.Show("您確定要取消生效", "請選擇", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            var rep = new WorkOrderController().UnapproveEngineering(_loadedProjectNo);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            MessageBox.Show("已取消生效!");
            LoadData(_loadedProjectNo);
        }

        // ── 列印：原巨集此按鈕未附加任何動作 ─────────────────────────────
        private void btnPrint_Click(object sender, EventArgs e) => MessageBox.Show("此功能尚未開放");

        // ── 總覽 (原巨集開啟 P-工程總覽)：開啟(或切換至)工程分析表篩選單分頁 ──────
        private void btnOverview_Click(object sender, EventArgs e)
        {
            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl))
            {
                var ctrlStandalone = new EngineeringAnalysisListControl { Dock = DockStyle.Fill };
                return;
            }
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            const string tabName = "EngineeringOverview";
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == tabName)
                {
                    tabControl.SelectedTab = page;
                    return;
                }
            }
            var ctrl = new EngineeringAnalysisListControl { Dock = DockStyle.Fill };
            var tab = new TabPage("工程分析表篩選單") { Name = tabName };
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
                Closed?.Invoke();
                return;
            }
            if (parentCtrl != null)
            {
                parentCtrl.Controls.Remove(this);
            }
            Dispose();
            Closed?.Invoke();
        }
    }
}
