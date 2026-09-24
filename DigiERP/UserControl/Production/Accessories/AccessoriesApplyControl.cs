using DigiERP.Common;
using DigiERP.Models;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production.Accessories
{
    // ── 零件申請單：比照 PITS-2025.accdb「P-零件申請單」及其子表單
    //    「P-零件申請明細」之控制項座標與配色還原。單號採「G」+2碼民國年+3碼
    //    流水號格式，沿用既有 MiscMfgRepository.GetMiscMfgNo() 產生。
    //
    //    按鈕邏輯對照原巨集：
    //      修改/儲存：需 業務權限.編修；儲存前需已選擇專案序號(未有序號請輸入
    //                "XXXX"，比照原提示)；建檔為空表示第一次存檔。
    //      生效/取消生效：需 業務權限.核准；已作廢或已生效者擋下；取消生效時
    //                若該單已收款沖帳(專案應收沖款明細.實收金額>0)則擋下。原
    //                巨集另有 5 個companion查詢(零件申請轉採購/維修申請轉組測/
    //                維修明細轉組測/零件工令新增/零件申請立帳)，分屬採購/組測/
    //                工令/應收帳款等獨立子系統，本次未實作。
    //      紀錄作廢：已生效者不得作廢，否則寫入 主旨="此單作廢"。
    //      查詢客戶專案機台零件：原巨集開啟「P-零件申請選項」(BOM零件挑選)，
    //                本次尚未建立對應畫面。
    //      客戶挑選"…"按鈕：原巨集開啟「P-零件單客戶篩選」，本次尚未建立。
    //      收款進度查詢/總覽/列印：分屬應收帳款/總覽清單/報表等獨立功能，本次
    //                尚未建立，暫以提示取代 ─────────────────────────────
    public partial class AccessoriesApplyControl : CommonUserControl
    {
        private static string id = "3496AA86-54B0-4D92-8DC9-F6BAA614C01C";

        private string _orderNo;
        private bool _isNew;
        private List<工令單> _workOrders = new List<工令單>();

        public event Action Closed;

        public AccessoriesApplyControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
            DigiERP.Common.UIStyle.ApplyControlStyle(this);
            initStaffCombo();
            initWorkOrderCombo();
            cmb專案序號.SelectedIndexChanged += cmb專案序號_SelectedIndexChanged;
        }

        private void initStaffCombo()
        {
            var rep = new GeneralExpensesController().GetActiveEmployeeList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            var names = (rep.resultList ?? new List<H員工清冊>()).Select(e => e.姓名).Where(n => !string.IsNullOrEmpty(n)).Distinct().ToArray();
            cmb申請人.Items.Clear();
            cmb申請人.Items.AddRange(names);
        }

        private void initWorkOrderCombo()
        {
            var rep = new MfgController().GetWorkOrderPickList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _workOrders = rep.resultList ?? new List<工令單>();
            cmb專案序號.Items.Clear();
            foreach (var w in _workOrders)
            {
                cmb專案序號.Items.Add(w.專案序號);
            }
        }

        // ── 專案序號選擇後，比照原ComboBox RowSource 帶出機台型號/機台名稱/
        //    客戶簡稱 ─────────────────────────────────────────────────
        private void cmb專案序號_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picked = _workOrders.FirstOrDefault(w => w.專案序號 == cmb專案序號.Text);
            if (picked == null) return;
            txt機台型號.Text = picked.機台型號;
            txt機台名稱.Text = picked.機台名稱;
            if (string.IsNullOrEmpty(txt客戶簡稱.Text)) txt客戶簡稱.Text = picked.客戶簡稱;
        }

        // ── 載入資料：orderNo 為 null 時為新增模式(直接可編輯，並預先取號)，
        //    否則依單號讀取既有主檔與明細清單(預設鎖定，需按修改解鎖) ─────────
        public void LoadData(string orderNo)
        {
            _orderNo = orderNo;
            _isNew = string.IsNullOrEmpty(orderNo);
            dataGridView1.Rows.Clear();

            if (_isNew)
            {
                var noRep = new MfgController().GetMiscMfgNo();
                txt單號.Text = string.IsNullOrEmpty(noRep.ErrorMessage) ? noRep.result : "";
                dt申請日期.Value = DateTime.Today;
                SetEditable(true);
                btnApprove.Visible = false;
                btnUnapprove.Visible = false;
            }
            else
            {
                var rep = new MfgController().GetMiscMfgByNo(orderNo);
                if (!string.IsNullOrEmpty(rep.ErrorMessage) || rep.result == null)
                {
                    if (!string.IsNullOrEmpty(rep.ErrorMessage)) MessageBox.Show(rep.ErrorMessage);
                    else MessageBox.Show("查無此零件申請單資料!");
                    return;
                }
                var m = rep.result;
                txt單號.Text = m.單號;
                cmb申請用途.Text = m.申請用途;
                if (DateTime.TryParse(m.申請日期, out var d1)) dt申請日期.Value = d1;
                cmb收費機制.Text = m.收費機制;
                txt客戶編號.Text = m.客戶編號;
                txt客戶簡稱.Text = m.客戶簡稱;
                cmb專案序號.Text = m.專案序號;
                txt機台型號.Text = m.機台型號;
                txt機台名稱.Text = m.機台名稱;
                cmb運送方式.Text = m.運送方式;
                if (DateTime.TryParse(m.交貨日期, out var d2)) dt交貨日期.Value = d2;
                if (DateTime.TryParse(m.保固效期, out var d3)) dt保固效期.Value = d3;
                txt主旨.Text = m.主旨;
                cmb申請人.Text = m.申請人;

                txtF核准.Text = m.核准;
                txtF核准日.Text = ShortDate(m.核准日);
                txtF修改.Text = m.修改;
                txtF修改日.Text = ShortDate(m.修改日);
                txtF建檔.Text = m.建檔;
                txtF建檔日.Text = ShortDate(m.建檔日);

                foreach (var x in m.detailList ?? new List<零件申請明細>())
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

                SetEditable(false);
                btnEdit.Enabled = true;
                btnSave.Enabled = false;

                bool approved = !string.IsNullOrEmpty(txtF核准.Text);
                btnApprove.Visible = !approved;
                btnUnapprove.Visible = approved;
            }
        }

        private static string ShortDate(string dt)
        {
            if (string.IsNullOrWhiteSpace(dt)) return "";
            int sp = dt.IndexOf(' ');
            return sp > 0 ? dt.Substring(0, sp) : dt;
        }

        // ── 解鎖/鎖定業務欄位與明細清單；簽核紀錄與單號永遠唯讀 ────────────
        private void SetEditable(bool editable)
        {
            cmb申請用途.Enabled = editable;
            dt申請日期.Enabled = editable;
            cmb收費機制.Enabled = editable;
            txt客戶編號.Enabled = editable;
            txt客戶簡稱.Enabled = editable;
            btnPickCustomer.Enabled = editable;
            cmb專案序號.Enabled = editable;
            txt機台型號.Enabled = editable;
            txt機台名稱.Enabled = editable;
            cmb運送方式.Enabled = editable;
            dt交貨日期.Enabled = editable;
            dt保固效期.Enabled = editable;
            txt主旨.Enabled = editable;
            cmb申請人.Enabled = editable;
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

        // ── 儲存：儲存前需已選擇專案序號，比照原提示「請選擇"專案序號"，如未有
        //    序號，則輸入"XXXX"」 ─────────────────────────────────────────
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!chkEditPrivilege(id))
            {
                MessageBox.Show("抱歉：非經授權，不得進入！");
                return;
            }
            if (string.IsNullOrEmpty(cmb專案序號.Text))
            {
                MessageBox.Show("請選擇\"專案序號\"，如未有序號，則輸入\"XXXX\"，謝謝！");
                return;
            }

            var model = new 零件申請單
            {
                單號 = txt單號.Text,
                申請用途 = cmb申請用途.Text,
                申請日期 = dt申請日期.Value.ToString("yyyy-MM-dd"),
                收費機制 = cmb收費機制.Text,
                客戶編號 = txt客戶編號.Text,
                客戶簡稱 = txt客戶簡稱.Text,
                專案序號 = cmb專案序號.Text,
                機台型號 = txt機台型號.Text,
                機台名稱 = txt機台名稱.Text,
                運送方式 = cmb運送方式.Text,
                交貨日期 = dt交貨日期.Value.ToString("yyyy-MM-dd"),
                保固效期 = dt保固效期.Value.ToString("yyyy-MM-dd"),
                主旨 = txt主旨.Text,
                申請人 = cmb申請人.Text,
            };
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                string partNo = row.Cells[colPartNo.Index].Value?.ToString();
                string itemName = row.Cells[colItemName.Index].Value?.ToString();
                if (string.IsNullOrEmpty(partNo) && string.IsNullOrEmpty(itemName)) continue;
                model.detailList.Add(new 零件申請明細
                {
                    零件分類 = row.Cells[colPartType.Index].Value?.ToString(),
                    零件號碼 = partNo,
                    品名 = itemName,
                    描述 = row.Cells[colDesc.Index].Value?.ToString(),
                    單位 = row.Cells[colUnit.Index].Value?.ToString(),
                    數量 = int.TryParse(row.Cells[colQty.Index].Value?.ToString(), out var qty) ? qty : (int?)null,
                    附屬模組 = row.Cells[colOwner.Index].Value?.ToString(),
                    備註 = row.Cells[colRemark.Index].Value?.ToString(),
                });
            }

            string username = AppSession.User?.username;
            string today = DateTime.Now.ToString("yyyy-MM-dd");
            if (_isNew)
            {
                model.建檔 = username;
                model.建檔日 = today;
                var rep = new MfgController().CreateMiscMfgOrder(model);
                if (!string.IsNullOrEmpty(rep.ErrorMessage))
                {
                    MessageBox.Show(rep.ErrorMessage);
                    return;
                }
            }
            else
            {
                model.建檔 = txtF建檔.Text;
                model.建檔日 = txtF建檔日.Text;
                model.修改 = username;
                model.修改日 = today;
                var rep = new MfgController().UpdateMiscMfgOrder(model);
                if (!string.IsNullOrEmpty(rep.ErrorMessage))
                {
                    MessageBox.Show(rep.ErrorMessage);
                    return;
                }
            }

            MessageBox.Show("儲存成功!");
            _isNew = false;
            LoadData(model.單號);
        }

        // ── 生效 ─────────────────────────────────────────────────────
        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (!chkApprovePrivilege(id))
            {
                MessageBox.Show("抱歉：非經授權，不得進入！");
                return;
            }
            var rep = new MfgController().ApproveMiscMfg(_orderNo, AppSession.User?.username);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            MessageBox.Show("生效成功!");
            LoadData(_orderNo);
        }

        private void btnUnapprove_Click(object sender, EventArgs e)
        {
            if (!chkApprovePrivilege(id))
            {
                MessageBox.Show("抱歉：非經授權，不得進入！");
                return;
            }
            if (MessageBox.Show("您確定要取消生效", "請選擇", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            var rep = new MfgController().UnapproveMiscMfg(_orderNo);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            MessageBox.Show("已取消生效!");
            LoadData(_orderNo);
        }

        // ── 紀錄作廢 ───────────────────────────────────────────────────
        private void btnVoid_Click(object sender, EventArgs e)
        {
            if (!chkEditPrivilege(id))
            {
                MessageBox.Show("非經授權，不得進入！");
                return;
            }
            if (string.IsNullOrEmpty(_orderNo))
            {
                MessageBox.Show("請先儲存後再進行作廢!");
                return;
            }
            var rep = new MfgController().VoidMiscMfg(_orderNo);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            MessageBox.Show("已標記此單作廢!");
            LoadData(_orderNo);
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

        // ── 查詢客戶專案機台零件：比照原巨集先執行"BRG-零件"查詢，將對應客戶/
        //    專案的採購計畫零件暫存至 零件申請BRG，再開啟「P-零件申請選項」勾選 ──
        private void btnQueryParts_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt單號.Text))
            {
                MessageBox.Show("請先儲存單據後再查詢零件!");
                return;
            }
            if (string.IsNullOrEmpty(cmb專案序號.Text))
            {
                MessageBox.Show("請先選擇\"專案序號\"，謝謝！");
                return;
            }
            var stageRep = new MfgController().StageBRGParts(txt單號.Text, txt客戶簡稱.Text, cmb專案序號.Text);
            if (!string.IsNullOrEmpty(stageRep.ErrorMessage))
            {
                MessageBox.Show(stageRep.ErrorMessage);
                return;
            }
            var picker = new PartsBOMSelectControl(txt單號.Text) { Dock = DockStyle.Fill };
            using (var frm = new Form())
            {
                frm.Text = "查詢客戶專案機台零件";
                frm.StartPosition = FormStartPosition.CenterParent;
                // ── 內含 Grid 8欄(單號/零件號碼/零件分類/品名/描述/附屬模組等)設計寬
                //    度達1100px，原900px視窗會裁切最右側欄位，故放大視窗並直接最大化
                //    ，確保全部欄位可完整顯示 ─────────────────────────────────
                frm.Size = new System.Drawing.Size(1200, 700);
                frm.MinimumSize = new System.Drawing.Size(1150, 650);
                frm.WindowState = FormWindowState.Maximized;
                frm.Controls.Add(picker);
                bool confirmed = false;
                picker.Closed += ok => { confirmed = ok; frm.Close(); };
                frm.ShowDialog(this);
                if (confirmed)
                {
                    LoadData(txt單號.Text);
                }
            }
        }

        // ── 客戶挑選"…"：比照原巨集開啟「P-零件單客戶篩選」，雙擊帶回客戶名稱/
        //    正航編號 ────────────────────────────────────────────────────
        private void btnPickCustomer_Click(object sender, EventArgs e)
        {
            var picker = new CustomerSearchControl { Dock = DockStyle.Fill };
            using (var frm = new Form())
            {
                frm.Text = "零件單客戶篩選";
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.Size = new System.Drawing.Size(900, 560);
                frm.Controls.Add(picker);
                picker.Picked += (company, custNo) =>
                {
                    txt客戶簡稱.Text = company;
                    txt客戶編號.Text = custNo;
                    frm.Close();
                };
                frm.ShowDialog(this);
            }
        }

        // ── 收款進度查詢：開啟(或切換至)該專案序號的 S-專案應收沖款 分頁 ────────
        private void btnPaymentProgress_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmb專案序號.Text))
            {
                MessageBox.Show("請先選擇\"專案序號\"，謝謝！");
                return;
            }
            OpenInTab("Receivables_" + cmb專案序號.Text, "收款進度查詢-" + cmb專案序號.Text,
                () => { var ctrl = new ReceivablesControl { Dock = DockStyle.Fill }; ctrl.LoadData(cmb專案序號.Text); return ctrl; });
        }

        // ── 總覽：開啟(或切換至) 零件申請單總覽 分頁 ─────────────────────────
        private void btnOverview_Click(object sender, EventArgs e)
        {
            OpenInTab("AccessoriesApplyList", "零件申請單總覽",
                () => new AccessoriesApplyListControl { Dock = DockStyle.Fill });
        }

        // ── 列印：比照 Access Report「零件工令單」，開啟預覽列印視窗(含匯出PDF) ──
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt單號.Text))
            {
                MessageBox.Show("請先儲存單據後再列印!");
                return;
            }
            var rep = new MfgController().GetMiscMfgByNo(txt單號.Text);
            if (!string.IsNullOrEmpty(rep.ErrorMessage) || rep.result == null)
            {
                MessageBox.Show(string.IsNullOrEmpty(rep.ErrorMessage) ? "查無此零件申請單資料!" : rep.ErrorMessage);
                return;
            }
            using (var frm = new DigiERP.Forms.Production.Accessories.FrmAccessoriesApplyPrint(rep.result))
            {
                frm.ShowDialog(this);
            }
        }

        // ── 共用：於同一 TabControl 開啟(或切換至)指定名稱的分頁；找不到父層
        //    TabControl(獨立顯示)時則直接以子控制項疊加顯示。關閉時自動切回
        //    開啟當下所在的來源分頁，邏輯見 DigiERP.Common.TabNavigator ────────
        private void OpenInTab(string tabName, string tabTitle, Func<System.Windows.Forms.Control> createControl)
        {
            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl))
            {
                var standalone = createControl();
                standalone.Dock = DockStyle.Fill;
                return;
            }
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            DigiERP.Common.TabNavigator.Open(tabControl, tabName, tabTitle, createControl);
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
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
