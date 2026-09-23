using DigiERP.Common;
using DigiERP.Models;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace DigiERP.UserControl.Order
{
    // ── 工令單明細：版面逐一比照 PITS-2025.accdb「P-工令單H」表單之控制項座標
    //    (twips/15=px)還原，包含表單首按鈕列、詳細資料(全部欄位)、表單尾簽核列。
    //    原表單依機台類型(H/M/FB/GT/S&PJ)分為 5 個版面，經比對皆為同一張 工令單
    //    資料表(113欄位)不同欄位子集/標籤的版面配置，並無各自明細子表，故統一
    //    以 H 型版面呈現(其餘機台類型專屬欄位如 焊接控制器X13 等本畫面未顯示，
    //    但仍為合法資料庫欄位，可日後視需要擴充版面)。
    //    原「PLCTYPE」控制項對應之欄位在 CHINYO 資料庫中不存在，僅保留版面外觀
    //    、不綁定資料、不參與載入/儲存 ──────────────────────────────────
    //
    //    按鈕邏輯對照原巨集：
    //      修改 (Command276)：需 業務權限.編修(簡化為 chkEditPrivilege)；若已核准
    //                          (核准 IS NOT NULL) 則擋下「請主管先取消生效」。
    //      儲存 (Command363)：需 chkEditPrivilege；建檔 為空則寫入 建檔/建檔日，
    //                          否則寫入 修改/修改日；存檔後重新鎖定畫面。
    //      生效 (原"生效")：需 業務權限.核准(簡化為 chkApprovePrivilege)；若已核
    //                          准則擋下「已經生效」；寫入 核准/核准日。原巨集另
    //                          會觸發「專案機台立帳」查詢建立應收帳款，本次簡化
    //                          未實作，如需要請另行告知。
    //      取消生效 (Command361)：需 chkApprovePrivilege；確認後清空 核准/核准日。
    //      列印：原巨集 OpenReport "工令單內容-H"，尚未建立對應報表，暫以提示取代。
    //      總覽/關閉：關閉本分頁(回到工令單總覽)。
    //      產品規格單/工程分析表/專案會議紀錄：原巨集分別開啟外部物件 P-規格/
    //          P-工程/P-會議，皆為獨立資料表/畫面，本次僅先預留按鈕位置，尚未
    //          建立對應功能，如需要請另行告知 ──────────────────────────────
    public partial class WorkOrderControl : CommonUserControl
    {
        private static string id = "3D04EE66-D76D-4777-AE47-F294A2124791";

        private readonly Dictionary<string, Control> _fieldControls = new Dictionary<string, Control>();
        private readonly HashSet<string> _alwaysReadOnlyFields = new HashSet<string>
        {
            "核准", "修改", "建檔", "核准日", "修改日", "建檔日"
        };
        private bool _isNew;
        private bool _readOnlyView;
        private string _loadedProjectNo;

        public event Action SavedOrClosed;

        private static readonly PropertyInfo[] _props = typeof(工令單).GetProperties();

        public WorkOrderControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
            DigiERP.Common.UIStyle.ApplyControlStyle(this);
            RegisterFieldControls();
        }

        private void RegisterFieldControls()
        {
            _fieldControls["專案序號"] = txt_專案序號;
            _fieldControls["訂單日期"] = txt_訂單日期;
            _fieldControls["參考序號"] = txt_參考序號;
            _fieldControls["機台型號"] = txt_機台型號;
            _fieldControls["機台類型"] = cmb_機台類型;
            _fieldControls["機台名稱"] = txt_機台名稱;
            _fieldControls["操作控制箱"] = cmb_操作控制箱;
            _fieldControls["三點組合"] = cmb_三點組合;
            _fieldControls["PLC控制器"] = cmb_PLC控制器;
            _fieldControls["入力線方向"] = cmb_入力線方向;
            _fieldControls["安全光照簾"] = cmb_安全光照簾;
            _fieldControls["安全柵欄"] = cmb_安全柵欄;
            _fieldControls["安全門火花檔板"] = cmb_安全門火花檔板;
            _fieldControls["蜂鳴器"] = cmb_蜂鳴器;
            _fieldControls["無熔絲開關"] = cmb_無熔絲開關;
            _fieldControls["三色燈"] = cmb_三色燈;
            _fieldControls["水流浮球"] = cmb_水流浮球;
            _fieldControls["水流水壓"] = cmb_水流水壓;
            _fieldControls["冰水機_熱交換器"] = cmb_冰水機_熱交換器;
            _fieldControls["馬達"] = cmb_馬達;
            _fieldControls["顏色"] = cmb_顏色;
            _fieldControls["啟動方式"] = cmb_啟動方式;
            _fieldControls["其他氣缸電磁閥"] = cmb_其他氣缸電磁閥;
            _fieldControls["其他氣缸"] = cmb_其他氣缸;
            _fieldControls["風壓壓力開關"] = cmb_風壓壓力開關;
            _fieldControls["壓力比例閥"] = cmb_壓力比例閥;
            _fieldControls["氣壓配管"] = cmb_氣壓配管;
            _fieldControls["空氣儲存桶"] = cmb_空氣儲存桶;
            _fieldControls["空氣儲存桶ps"] = cmb_空氣儲存桶ps;
            _fieldControls["啟動方式ps"] = cmb_啟動方式ps;
            _fieldControls["操作控制箱ps"] = cmb_操作控制箱ps;
            _fieldControls["安全光照簾ps"] = cmb_安全光照簾ps;
            _fieldControls["無熔絲開關ps"] = cmb_無熔絲開關ps;
            _fieldControls["馬達ps"] = cmb_馬達ps;
            _fieldControls["三色燈ps"] = cmb_三色燈ps;
            _fieldControls["人機介面"] = cmb_人機介面;
            _fieldControls["人機介面ps"] = cmb_人機介面ps;
            _fieldControls["說明"] = txt_說明;
            _fieldControls["備註"] = txt_備註;
            _fieldControls["結案"] = chk_結案;
            _fieldControls["國家地區"] = txt_國家地區;
            _fieldControls["客戶名稱"] = txt_客戶名稱;
            _fieldControls["客戶簡稱"] = txt_客戶簡稱;
            _fieldControls["焊接控制器Y13"] = cmb_焊接控制器Y13;
            _fieldControls["驗機日期"] = txt_驗機日期;
            _fieldControls["交貨日期"] = txt_交貨日期;
            _fieldControls["廠驗"] = cmb_廠驗;
            _fieldControls["裝機"] = cmb_裝機;
            _fieldControls["電流"] = cmb_電流;
            _fieldControls["焊接電壓v"] = cmb_焊接電壓v;
            _fieldControls["焊接物"] = cmb_焊接物;
            _fieldControls["圖面設計"] = cmb_圖面設計;
            _fieldControls["安規要求"] = cmb_安規要求;
            _fieldControls["生產速率"] = txt_生產速率;
            _fieldControls["焊接電壓hz"] = cmb_焊接電壓hz;
            _fieldControls["焊接電壓"] = cmb_焊接電壓;
            _fieldControls["核准"] = txtF_核准;
            _fieldControls["修改"] = txtF_修改;
            _fieldControls["建檔"] = txtF_建檔;
            _fieldControls["核准日"] = txtF_核准日;
            _fieldControls["修改日"] = txtF_修改日;
            _fieldControls["建檔日"] = txtF_建檔日;
        }

        // ── 是否具備「核准」權限：比照 CommonUserControl.chkEditPrivilege 的寫法，
        //    改判斷 核准 旗標(業務權限.核准)，而非 編修 旗標 ─────────────────
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

        // ── 載入資料：projectNo 為 null 時為新增模式(直接可編輯)，否則依專案序號
        //    讀取既有資料(預設鎖定，需按「修改」才能編輯)；readOnlyView=true 時
        //    比照原「開啟對照工令單」，全部按鈕/欄位鎖定僅供檢視 ─────────────
        public void LoadData(string projectNo, bool isNew, bool readOnlyView = false)
        {
            _isNew = isNew;
            _readOnlyView = readOnlyView;
            _loadedProjectNo = projectNo;

            工令單 model;
            if (isNew || string.IsNullOrEmpty(projectNo))
            {
                model = new 工令單();
            }
            else
            {
                var rep = new WorkOrderController().GetWorkOrderDetail(projectNo);
                if (!string.IsNullOrEmpty(rep.ErrorMessage))
                {
                    MessageBox.Show(rep.ErrorMessage);
                    model = new 工令單();
                }
                else if (rep.result == null)
                {
                    MessageBox.Show("查無此工令單資料!");
                    model = new 工令單();
                }
                else
                {
                    model = rep.result;
                }
            }

            foreach (var kv in _fieldControls)
            {
                var prop = _props.FirstOrDefault(p => p.Name == kv.Key);
                if (prop == null) continue;
                SetControlValue(kv.Value, prop.GetValue(model) as string);
            }

            lblTitle.Text = readOnlyView ? "工令單(對照檢視-唯讀)" : "工令單";
            SetEditable(isNew && !readOnlyView);
            txt_專案序號.ReadOnly = !isNew; // 專案序號為主鍵，新增時才可輸入

            btnEdit.Enabled = !isNew && !readOnlyView;
            btnSave.Enabled = isNew && !readOnlyView; // 既有資料需先按「修改」解鎖才能儲存

            // ── 生效/取消生效互斥顯示：比照 OrderMaintainControl 的 btnActivate/
            //    btnCancelActivate 慣例，依 核准 是否已填(而非 Enabled)切換 Visible ──
            bool approved = !string.IsNullOrEmpty(txtF_核准.Text);
            btnApprove.Visible = !readOnlyView && !approved;
            btnUnapprove.Visible = !readOnlyView && approved;
        }

        private static void SetControlValue(Control ctrl, string value)
        {
            if (ctrl is CheckBox chk)
            {
                chk.Checked = ToBool(value);
            }
            else if (ctrl is DateTimePicker dtp)
            {
                dtp.Value = DateTime.TryParse(value, out var d) ? d : DateTime.Parse("1900-01-01");
            }
            else if (ctrl is ComboBox || ctrl is TextBox)
            {
                ctrl.Text = string.IsNullOrWhiteSpace(value) ? "" : ShortDate(value);
            }
        }

        private static string ShortDate(string dt)
        {
            int sp = dt.IndexOf(' ');
            return sp > 0 ? dt.Substring(0, sp) : dt;
        }

        private static bool ToBool(string v)
        {
            if (string.IsNullOrWhiteSpace(v)) return false;
            if (bool.TryParse(v, out bool b)) return b;
            return v == "1";
        }

        // ── 解鎖/鎖定全部欄位；簽核紀錄(建檔/修改/核准等)永遠唯讀 ────────────
        private void SetEditable(bool editable)
        {
            foreach (var kv in _fieldControls)
            {
                if (_alwaysReadOnlyFields.Contains(kv.Key)) continue;
                kv.Value.Enabled = editable;
            }
            if (!_isNew) txt_專案序號.Enabled = false; // 專案序號一律不可修改(僅新增時可輸入)
        }

        // ── 修改 (原Command276)：需編修權限；已核准者不得修改 ────────────────
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!chkEditPrivilege(id))
            {
                MessageBox.Show("抱歉：非經授權，不得進入！");
                return;
            }
            if (!string.IsNullOrEmpty(txtF_核准.Text))
            {
                MessageBox.Show("請主管先取消生效\n(已生效無法修改喔!)");
                return;
            }
            SetEditable(true);
            btnSave.Enabled = true;
        }

        // ── 儲存 (原Command363)：建檔為空表示第一次存檔，否則視為修改 ──────────
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!chkEditPrivilege(id))
            {
                MessageBox.Show("抱歉：非經授權，不得進入！");
                return;
            }
            string projectNo = txt_專案序號.Text.Trim();
            if (string.IsNullOrEmpty(projectNo))
            {
                MessageBox.Show("專案序號不可空白!");
                return;
            }

            var model = new 工令單 { 專案序號 = projectNo };
            foreach (var kv in _fieldControls)
            {
                if (kv.Key == "專案序號") continue;
                var prop = _props.FirstOrDefault(p => p.Name == kv.Key);
                if (prop == null) continue;
                prop.SetValue(model, GetControlValue(kv.Value));
            }

            if (_isNew)
            {
                model.建檔 = AppSession.User?.username;
                model.建檔日 = DateTime.Now.ToString("yyyy-MM-dd");
                var rep = new WorkOrderController().InsertWorkOrder(model);
                if (!string.IsNullOrEmpty(rep.ErrorMessage))
                {
                    MessageBox.Show(rep.ErrorMessage);
                    return;
                }
            }
            else
            {
                model.修改 = AppSession.User?.username;
                model.修改日 = DateTime.Now.ToString("yyyy-MM-dd");
                var rep = new WorkOrderController().UpdateWorkOrder(model);
                if (!string.IsNullOrEmpty(rep.ErrorMessage))
                {
                    MessageBox.Show(rep.ErrorMessage);
                    return;
                }
            }

            MessageBox.Show("儲存成功!");
            LoadData(projectNo, false); // 存檔後重新鎖定並重新載入
            SavedOrClosed?.Invoke();
        }

        private static string GetControlValue(Control ctrl)
        {
            if (ctrl is CheckBox chk) return chk.Checked.ToString();
            if (ctrl is DateTimePicker dtp) return dtp.Value.ToString("yyyy-MM-dd");
            return ctrl.Text;
        }

        // ── 生效 (原"生效")：需核准權限；已核准者不得重複生效。原巨集另會檢查
        //    專案應收沖款是否已建立、若無則觸發「專案機台立帳」查詢，本次簡化
        //    未實作此自動立帳流程，如需要請另行告知 ────────────────────────
        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (!chkApprovePrivilege(id))
            {
                MessageBox.Show("抱歉：非經授權，不得進入！");
                return;
            }
            if (string.IsNullOrEmpty(_loadedProjectNo))
            {
                MessageBox.Show("請先儲存後再進行生效!");
                return;
            }
            if (!string.IsNullOrEmpty(txtF_核准.Text))
            {
                MessageBox.Show("提醒您集中精神\n(已經生效,您按錯囉!)");
                return;
            }

            var rep = new WorkOrderController().ApproveWorkOrder(_loadedProjectNo, AppSession.User?.username);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            MessageBox.Show("生效成功!");
            LoadData(_loadedProjectNo, false);
            SavedOrClosed?.Invoke();
        }

        // ── 取消生效 (原Command361)：需核准權限 ─────────────────────────────
        private void btnUnapprove_Click(object sender, EventArgs e)
        {
            if (!chkApprovePrivilege(id))
            {
                MessageBox.Show("抱歉：非經授權，不得進入！");
                return;
            }
            if (string.IsNullOrEmpty(_loadedProjectNo)) return;
            if (MessageBox.Show("您確定要取消生效", "請選擇", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            var rep = new WorkOrderController().UnapproveWorkOrder(_loadedProjectNo);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            MessageBox.Show("已取消生效!");
            LoadData(_loadedProjectNo, false);
            SavedOrClosed?.Invoke();
        }

        // ── 列印：原巨集 OpenReport "工令單內容-H"，開啟預覽列印視窗(含匯出PDF) ──
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_loadedProjectNo))
            {
                MessageBox.Show("請先儲存工令單後再列印!");
                return;
            }
            using (var frm = new DigiERP.Forms.Order.FrmWorkOrderPrint(_loadedProjectNo))
            {
                frm.ShowDialog(this);
            }
        }

        // ── 產品規格單 (原Command262)：開啟 P-規格 對應的 ProductSpecControl ────
        private void btnProductSpec_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_loadedProjectNo))
            {
                MessageBox.Show("請先儲存工令單後再開啟產品規格單!");
                return;
            }
            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl))
            {
                var ctrlStandalone = new DigiERP.UserControl.Production.Spec.ProductSpecControl { Dock = DockStyle.Fill };
                ctrlStandalone.LoadData(_loadedProjectNo);
                return;
            }
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            string tabName = "ProductSpec_" + _loadedProjectNo;
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == tabName)
                {
                    tabControl.SelectedTab = page;
                    return;
                }
            }
            var ctrl = new DigiERP.UserControl.Production.Spec.ProductSpecControl { Dock = DockStyle.Fill };
            var tab = new TabPage("產品規格單-" + _loadedProjectNo) { Name = tabName };
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
            ctrl.LoadData(_loadedProjectNo);
        }

        // ── 工程分析表 (原Command263)：開啟 P-工程 對應的 EngineeringAnalysisControl ──
        private void btnEngAnalysis_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_loadedProjectNo))
            {
                MessageBox.Show("請先儲存工令單後再開啟工程分析表!");
                return;
            }
            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl))
            {
                var ctrlStandalone = new DigiERP.UserControl.Production.Engineering.EngineeringAnalysisControl { Dock = DockStyle.Fill };
                ctrlStandalone.LoadData(_loadedProjectNo);
                return;
            }
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            string tabName = "Engineering_" + _loadedProjectNo;
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == tabName)
                {
                    tabControl.SelectedTab = page;
                    return;
                }
            }
            var ctrl = new DigiERP.UserControl.Production.Engineering.EngineeringAnalysisControl { Dock = DockStyle.Fill };
            var tab = new TabPage("工程分析表-" + _loadedProjectNo) { Name = tabName };
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
            ctrl.LoadData(_loadedProjectNo);
        }

        // ── 專案會議紀錄 (原Command264)：開啟 P-會議 對應的 ProjectMeetingControl ──
        private void btnMeetingLog_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_loadedProjectNo))
            {
                MessageBox.Show("請先儲存工令單後再開啟專案會議履歷!");
                return;
            }
            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl))
            {
                var ctrlStandalone = new DigiERP.UserControl.Project.ProjectMeetingControl { Dock = DockStyle.Fill };
                ctrlStandalone.LoadData(_loadedProjectNo);
                return;
            }
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            string tabName = "Meeting_" + _loadedProjectNo;
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == tabName)
                {
                    tabControl.SelectedTab = page;
                    return;
                }
            }
            var ctrl = new DigiERP.UserControl.Project.ProjectMeetingControl { Dock = DockStyle.Fill };
            var tab = new TabPage("專案會議履歷-" + _loadedProjectNo) { Name = tabName };
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
            ctrl.LoadData(_loadedProjectNo);
        }

        // ── 工令時程表：開啟(或切換至) WorkOrderScheduleControl 分頁，比照
        //    P-工令單H 巨集開啟 P-工令時程表 之邏輯 ────────────────────────────
        private void btnSchedule_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_loadedProjectNo))
            {
                MessageBox.Show("請先儲存工令單後再開啟工令時程表!");
                return;
            }
            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl))
            {
                var ctrlStandalone = new WorkOrderScheduleControl { Dock = DockStyle.Fill };
                ctrlStandalone.LoadData(_loadedProjectNo);
                return;
            }
            TabControl scheduleTabControl = (TabControl)((TabPage)Parent).Parent;
            string scheduleTabName = "Schedule_" + _loadedProjectNo;
            foreach (TabPage page in scheduleTabControl.TabPages)
            {
                if (page.Name == scheduleTabName)
                {
                    scheduleTabControl.SelectedTab = page;
                    return;
                }
            }
            var scheduleCtrl = new WorkOrderScheduleControl { Dock = DockStyle.Fill };
            var scheduleTab = new TabPage("工令時程表-" + _loadedProjectNo) { Name = scheduleTabName };
            scheduleTab.Controls.Add(scheduleCtrl);
            scheduleTabControl.TabPages.Add(scheduleTab);
            scheduleTabControl.SelectedTab = scheduleTab;
            scheduleCtrl.LoadData(_loadedProjectNo);
        }

        // ── 總覽/關閉：皆為關閉本分頁，回到工令單總覽 ─────────────────────────
        private void btnBackToList_Click(object sender, EventArgs e) => CloseTab();
        private void btnExit_Click(object sender, EventArgs e) => CloseTab();

        private void CloseTab()
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
