using DigiERP.Common;
using DigiERP.Forms.Production;
using DigiERP.Models;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production.Spec
{
    // ── 產品規格單：版面逐一比照 PITS-2025.accdb「P-規格」表單之控制項座標
    //    (twips/15=px)還原。RecordSource 原查詢「產品規格查詢」為 工令單 LEFT
    //    JOIN 產品規格單，畫面上半部為 工令單 唯讀參考欄位(重用
    //    WorkOrderController.GetWorkOrderDetail)，其餘為 產品規格單 本身可編輯
    //    欄位。專案負責人為挑選職務="業務"人員的下拉(重用既有
    //    ProjectProgressController.GetSalesStaffList + FrmSelectStaff)。
    //
    //    按鈕邏輯對照原巨集(與 WorkOrderControl 同款式)：
    //      修改/儲存：需 chkEditPrivilege；已核准者不得修改。
    //      生效：需 chkApprovePrivilege；寫入 核准/核准日，並依 設計模組表
    //            檢查分類="電控" 的每個模組，於 專案電控排程 建立待派工紀錄
    //            (原巨集查詢「專案電控派案」)。
    //      取消生效：需 chkApprovePrivilege；清空 核准/核准日，並刪除該專案
    //            序號的全部 專案電控排程 紀錄(原巨集查詢「電控排程收回」)。
    //      結案/取消結案：需 chkApprovePrivilege；重用 WorkOrderController 既
    //            有的 CloseWorkOrder，寫回 工令單.結案。
    //      列印：原巨集 OpenReport "產品規格書"，尚未建立對應報表，暫以提示取代。
    //      總覽(回到工令單)/關閉：皆為關閉本分頁 ─────────────────────────────
    public partial class ProductSpecControl : CommonUserControl
    {
        private static string id = "8D859D48-720B-4ED4-803F-5373143E089B";

        private readonly Dictionary<string, Control> _specControls = new Dictionary<string, Control>();
        private readonly Dictionary<string, Control> _refControls = new Dictionary<string, Control>();
        private bool _isNew;
        private string _loadedProjectNo;
        private List<成本單位人員配置> _salesStaffList = new List<成本單位人員配置>();

        public event Action Closed;

        private static readonly PropertyInfo[] _specProps = typeof(產品規格單).GetProperties();
        private static readonly PropertyInfo[] _refProps = typeof(工令單).GetProperties();

        public ProductSpecControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
            DigiERP.Common.UIStyle.ApplyControlStyle(this);
            RegisterControls();
            initSalesStaffCombo();
        }

        private void RegisterControls()
        {
            _specControls["專案負責人"] = cmb_專案負責人;
            _specControls["客戶需求陳述"] = txt_客戶需求陳述;
            _specControls["驗收物件規格"] = txt_驗收物件規格;
            _specControls["驗收基本要求1"] = txt_驗收基本要求1;
            _specControls["機台最大及最小能力"] = txt_機台最大及最小能力;
            _specControls["補充說明"] = txt_補充說明;
            _specControls["機台動作規劃1"] = txt_機台動作規劃1;
            _specControls["MQC_油壓委外單元"] = cmb_MQC_油壓委外單元;
            _specControls["MQC_自動化程控"] = cmb_MQC_自動化程控;
            _specControls["MQC_變壓器"] = cmb_MQC_變壓器;
            _specControls["FQC_製成參數"] = cmb_FQC_製成參數;
            _specControls["OQC_出機檢查"] = cmb_OQC_出機檢查;
            _specControls["驗收規範說明1"] = txt_驗收規範說明1;
            _specControls["驗收規範說明2"] = txt_驗收規範說明2;
            _specControls["驗收規範說明3"] = txt_驗收規範說明3;
            _specControls["驗收規範說明4"] = txt_驗收規範說明4;
            _specControls["驗收規範說明5"] = txt_驗收規範說明5;
            _specControls["驗收規範說明6"] = txt_驗收規範說明6;
            _specControls["流程路徑圖"] = txt_流程路徑圖;
            _specControls["驗收規範項目3"] = txt_驗收規範項目3;
            _specControls["驗收規範項目4"] = txt_驗收規範項目4;
            _specControls["驗收規範項目5"] = txt_驗收規範項目5;
            _specControls["驗收規範項目6"] = txt_驗收規範項目6;
            _specControls["核准"] = txtF_核准;
            _specControls["修改"] = txtF_修改;
            _specControls["建檔"] = txtF_建檔;
            _specControls["核准日"] = txtF_核准日;
            _specControls["修改日"] = txtF_修改日;
            _specControls["建檔日"] = txtF_建檔日;

            _refControls["專案序號"] = txt_專案序號;
            _refControls["參考序號"] = txt_參考序號;
            _refControls["機台型號"] = txt_機台型號;
            _refControls["機台名稱"] = txt_機台名稱;
            _refControls["驗機日期"] = dt_驗機日期;
            _refControls["交貨日期"] = dt_交貨日期;
            _refControls["生產速率"] = txt_生產速率;
            _refControls["廠驗"] = txt_廠驗;
            _refControls["裝機"] = txt_裝機;
            _refControls["圖面設計"] = txt_圖面設計;
            _refControls["安規要求"] = txt_安規要求;
            _refControls["電流"] = txt_電流;
            _refControls["焊接電壓"] = txt_焊接電壓;
            _refControls["焊接物"] = txt_焊接物;
            _refControls["機台類型"] = txt_機台類型;
            _refControls["結案"] = chk_結案;
            _refControls["訂單日期"] = dt_訂單日期;
            _refControls["國家地區"] = txt_國家地區;
            _refControls["客戶名稱"] = txt_客戶名稱;
            _refControls["客戶簡稱"] = txt_客戶簡稱;
            _refControls["焊接電壓v"] = txt_焊接電壓v;
            _refControls["焊接電壓hz"] = txt_焊接電壓hz;
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

        // ── 專案負責人下拉：職務="業務"的成本單位人員配置，重用既有 API/picker ──
        private void initSalesStaffCombo()
        {
            var rep = new ProjectProgressController().GetSalesStaffList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _salesStaffList = rep.resultList ?? new List<成本單位人員配置>();
        }

        private void cmb_專案負責人_DropDown(object sender, EventArgs e)
        {
            var combo = (ComboBox)sender;
            BeginInvoke(new Action(() =>
            {
                combo.DroppedDown = false;
                using var frm = new FrmSelectStaff(_salesStaffList);
                if (frm.ShowDialog(FindForm()) == DialogResult.OK && frm.SelectedItem != null)
                {
                    combo.Text = frm.SelectedItem.姓名;
                }
            }));
        }

        // ── 載入資料：projectNo 一律來自既有工令單，本畫面不支援獨立新增 ─────────
        public void LoadData(string projectNo)
        {
            _loadedProjectNo = projectNo;

            var workOrderRep = new WorkOrderController().GetWorkOrderDetail(projectNo);
            工令單 workOrder = (!string.IsNullOrEmpty(workOrderRep.ErrorMessage) || workOrderRep.result == null)
                ? new 工令單()
                : workOrderRep.result;
            foreach (var kv in _refControls)
            {
                var prop = _refProps.FirstOrDefault(p => p.Name == kv.Key);
                if (prop == null) continue;
                SetControlValue(kv.Value, prop.GetValue(workOrder) as string);
            }

            var specRep = new ProductSpecController().GetProductSpecDetail(projectNo);
            產品規格單 spec;
            if (!string.IsNullOrEmpty(specRep.ErrorMessage))
            {
                MessageBox.Show(specRep.ErrorMessage);
                spec = new 產品規格單();
            }
            else
            {
                spec = specRep.result;
            }
            _isNew = spec == null;
            spec ??= new 產品規格單();

            foreach (var kv in _specControls)
            {
                var prop = _specProps.FirstOrDefault(p => p.Name == kv.Key);
                if (prop == null) continue;
                SetControlValue(kv.Value, prop.GetValue(spec) as string);
            }

            SetEditable(_isNew);
            btnEdit.Enabled = !_isNew;
            btnSave.Enabled = _isNew;

            bool approved = !string.IsNullOrEmpty(txtF_核准.Text);
            btnApprove.Visible = !approved;
            btnUnapprove.Visible = approved;

            btnClose2.Visible = !chk_結案.Checked;
            btnReopen.Visible = chk_結案.Checked;
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

        // ── 解鎖/鎖定產品規格單欄位；簽核紀錄(建檔/修改/核准等)永遠唯讀，
        //    工令單參考欄位(_refControls)永遠唯讀，不受此開關影響 ────────────
        private void SetEditable(bool editable)
        {
            var alwaysReadOnly = new HashSet<string> { "核准", "修改", "建檔", "核准日", "修改日", "建檔日" };
            foreach (var kv in _specControls)
            {
                if (alwaysReadOnly.Contains(kv.Key)) continue;
                kv.Value.Enabled = editable;
            }
        }

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!chkEditPrivilege(id))
            {
                MessageBox.Show("抱歉：非經授權，不得進入！");
                return;
            }
            if (string.IsNullOrEmpty(_loadedProjectNo))
            {
                MessageBox.Show("查無專案序號，無法儲存!");
                return;
            }

            var model = new 產品規格單 { 專案序號 = _loadedProjectNo };
            foreach (var kv in _specControls)
            {
                var prop = _specProps.FirstOrDefault(p => p.Name == kv.Key);
                if (prop == null) continue;
                prop.SetValue(model, GetControlValue(kv.Value));
            }

            if (_isNew)
            {
                model.建檔 = AppSession.User?.username;
                model.建檔日 = DateTime.Now.ToString("yyyy-MM-dd");
                var rep = new ProductSpecController().InsertProductSpec(model);
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
                var rep = new ProductSpecController().UpdateProductSpec(model);
                if (!string.IsNullOrEmpty(rep.ErrorMessage))
                {
                    MessageBox.Show(rep.ErrorMessage);
                    return;
                }
            }

            MessageBox.Show("儲存成功!");
            LoadData(_loadedProjectNo);
        }

        private static string GetControlValue(Control ctrl)
        {
            if (ctrl is CheckBox chk) return chk.Checked.ToString();
            return ctrl.Text;
        }

        // ── 生效：寫入核准並觸發電控派案(於 Middle 層以交易一併處理) ───────────
        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (!chkApprovePrivilege(id))
            {
                MessageBox.Show("抱歉：非經授權，不得進入！");
                return;
            }
            var rep = new ProductSpecController().ApproveProductSpec(_loadedProjectNo, AppSession.User?.username);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            MessageBox.Show("生效成功，已建立電控派案排程!");
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

            var rep = new ProductSpecController().UnapproveProductSpec(_loadedProjectNo);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            MessageBox.Show("已取消生效，電控派案排程已收回!");
            LoadData(_loadedProjectNo);
        }

        // ── 結案/取消結案：重用 WorkOrderController 既有的 CloseWorkOrder，
        //    寫回 工令單.結案(此畫面之結案為工令單參考欄位，非產品規格單自身) ────
        private void btnClose2_Click(object sender, EventArgs e)
        {
            if (!chkApprovePrivilege(id))
            {
                MessageBox.Show("抱歉：有業務核准權限者，才能結案喔！");
                return;
            }
            if (MessageBox.Show("您確定要將此工令單進行結案?", "請選擇", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            var rep = new WorkOrderController().CloseWorkOrder(_loadedProjectNo, true);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            LoadData(_loadedProjectNo);
        }

        private void btnReopen_Click(object sender, EventArgs e)
        {
            if (!chkApprovePrivilege(id))
            {
                MessageBox.Show("抱歉：有業務核准權限者，才能結案喔！");
                return;
            }
            if (MessageBox.Show("您確定要取消結案?", "請選擇", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            var rep = new WorkOrderController().CloseWorkOrder(_loadedProjectNo, false);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            LoadData(_loadedProjectNo);
        }

        // ── 列印：原巨集 OpenReport "產品規格書"，尚未建立對應報表 ─────────────
        // ── 列印：原巨集 OpenReport "產品規格書"，開啟預覽列印視窗(含匯出PDF) ────
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_loadedProjectNo))
            {
                MessageBox.Show("請先儲存產品規格單後再列印!");
                return;
            }
            using (var frm = new DigiERP.Forms.Production.Spec.FrmProductSpecPrint(_loadedProjectNo))
            {
                frm.ShowDialog(this);
            }
        }

        // ── 總覽 (原巨集開啟 P-規格總覽)：開啟(或切換至)產品規格單總覽分頁 ────────
        private void btnOverview_Click(object sender, EventArgs e)
        {
            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl))
            {
                var ctrlStandalone = new ProductSpecListControl { Dock = DockStyle.Fill };
                return;
            }
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            const string tabName = "ProductSpecOverview";
            DigiERP.Common.TabNavigator.Open(tabControl, tabName, "產品規格單總覽", () =>
            {
                var ctrl = new ProductSpecListControl { Dock = DockStyle.Fill };
                return ctrl;
            });
        }

        private void btnExit_Click(object sender, EventArgs e) => CloseTab();

        private void CloseTab()
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
