using DigiERP.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigiERP.UserControl.Project
{
    // ── 專案會議履歷：比照 PITS-2025.accdb「P-會議」表單(Caption="專案會議履
    //    歷")。上半部為工令單既有欄位的唯讀參考顯示；中央清單為子表單
    //    「P-專案追蹤履歷」(查詢「專案追蹤履歷」= 專案管理紀錄明細 LEFT JOIN
    //    專案管理紀錄表)，唯讀顯示該專案下所有會議紀錄的討論事項。
    //
    //    按鈕邏輯對照原巨集：
    //      新增紀錄：原巨集開啟「P-專案管理紀錄表」(Add模式)並預帶專案序號，
    //                比照以新分頁開啟 ProjectMeetingManagementControl(新增模式)。
    //      重新整理：RunCommand(Refresh)，重新載入清單。
    //      關閉表單：關閉本分頁。
    //    清單雙擊：以新分頁開啟該筆紀錄單號對應的 ProjectMeetingManagementControl
    //              (編輯模式) ────────────────────────────────────────────
    public partial class ProjectMeetingControl : CommonUserControl
    {
        private static string id = "439B1335-038C-44F1-842B-22276163A553";

        private string _loadedProjectNo;

        public event Action Closed;

        public ProjectMeetingControl()
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
            _loadedProjectNo = projectNo;

            var rep = new WorkOrderController().GetWorkOrderDetail(projectNo);
            工令單 model = (!string.IsNullOrEmpty(rep.ErrorMessage) || rep.result == null) ? new 工令單() : rep.result;
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
            }

            txt專案序號.Text = model.專案序號;
            txt訂單日期.Text = ShortDate(model.訂單日期??new DateTime(1900, 01, 01).ToString("yyyy-MM-dd"));
            txt客戶簡稱.Text = model.客戶簡稱;
            txt客戶名稱.Text = model.客戶名稱;
            txt國家地區.Text = model.國家地區;
            chk結案.Checked = ToBool(model.結案??"false");
            txt參考序號.Text = model.參考序號;
            txt電流.Text = model.電流;
            txt圖面設計.Text = model.圖面設計;
            txt驗機日期.Text = ShortDate(model.驗機日期 ?? new DateTime(1900, 01, 01).ToString("yyyy-MM-dd"));
            txt機台型號.Text = model.機台型號;
            txt焊接電壓v.Text = model.焊接電壓v;
            txt焊接電壓hz.Text = model.焊接電壓hz;
            txt焊接電壓.Text = model.焊接電壓;
            txt安規要求.Text = model.安規要求;
            txt廠驗.Text = model.廠驗;
            txt機台類型.Text = model.機台類型;
            txt焊接物.Text = model.焊接物;

            txt生產速率.Text = model.生產速率;
            txt交貨日期.Text = ShortDate(model.交貨日期 ?? new DateTime(1900, 01, 01).ToString("yyyy-MM-dd"));
            txt機台名稱.Text = model.機台名稱;
            txt裝機.Text = model.裝機;

            LoadTrackList();
        }

        private void LoadTrackList()
        {
            var rep = new ProjectMeetingController().GetMeetingTrackList(_loadedProjectNo);
            dataGridView1.Rows.Clear();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            foreach (var x in rep.resultList ?? new List<專案追蹤履歷列表>())
            {
                int i = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                row.Cells[colRecordNo.Index].Value = x.紀錄單號;
                row.Cells[colDate.Index].Value = ShortDate(x.日期);
                row.Cells[colType.Index].Value = x.紀錄類別;
                row.Cells[colRecorder.Index].Value = x.記錄人員;
                row.Cells[colProposer.Index].Value = x.事項提議人;
                row.Cells[colOwnerUnit.Index].Value = x.權責處理單位;
                row.Cells[colTopic.Index].Value = x.登載或注意事項;
                row.Cells[colResolution.Index].Value = x.決議;
                row.Cells[colNeedReply.Index].Value = x.回報要求 ?? false;
                row.Cells[colReplyPerson.Index].Value = x.應回報人員;
                row.Cells[colExpectDate.Index].Value = ShortDate(x.預計回報日期);
                row.Cells[colActualDate.Index].Value = ShortDate(x.實際回報日期);
                row.Cells[colReplyDesc.Index].Value = x.回報說明;
                row.Cells[colManagerReview.Index].Value = x.管理者審閱 ?? false;
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

        // ── 新增紀錄：比照原巨集開啟 P-專案管理紀錄表(Add模式)並預帶專案序號，
        //    以新分頁開啟 ProjectMeetingManagementControl ───────────────────
        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenManagementTab(null);
        }

        // ── 重新整理：RunCommand(Refresh) ─────────────────────────────────
        private void btnRefresh_Click(object sender, EventArgs e) => LoadTrackList();

        // ── 清單雙擊：開啟該筆紀錄單號對應的會議紀錄(編輯模式) ─────────────────
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string recordNo = dataGridView1.Rows[e.RowIndex].Cells[colRecordNo.Index].Value?.ToString();
            if (string.IsNullOrEmpty(recordNo)) return;

            OpenManagementTab(recordNo);
        }

        private void OpenManagementTab(string recordNo)
        {
            bool isNew = string.IsNullOrEmpty(recordNo);
            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl))
            {
                var ctrlStandalone = new ProjectMeetingManagementControl { Dock = DockStyle.Fill };
                ctrlStandalone.LoadData(_loadedProjectNo, recordNo);
                return;
            }
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            string tabName = isNew ? "MeetingMgmt_NEW_" + _loadedProjectNo : "MeetingMgmt_" + recordNo;
            DigiERP.Common.TabNavigator.Open(tabControl, tabName, isNew ? "新增會議紀錄" : "會議紀錄-" + recordNo, () =>
            {
                var ctrl = new ProjectMeetingManagementControl { Dock = DockStyle.Fill };
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
                    LoadTrackList();
                };
                ctrl.LoadData(_loadedProjectNo, recordNo);
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
