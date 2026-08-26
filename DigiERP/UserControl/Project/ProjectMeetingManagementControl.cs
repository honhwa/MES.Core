using DigiERP.Common;
using DigiERP.Models;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Project
{
    // ── 專案管理紀錄表：比照 PITS-2025.accdb「P-專案管理紀錄表」及其子表單
    //    「P-專案管理紀錄明細」。由「P-會議」(ProjectMeetingControl)的「新增
    //    紀錄」按鈕開啟(Add模式，預帶專案序號)，或由清單雙擊某筆紀錄單號開啟
    //    (編輯模式)。原表單無表單尾(FormFooter Height=0)，故本畫面亦不設footer。
    //    儲存＝RunCommand(SaveRecord)：本處對應同時儲存主檔(專案管理紀錄表)與
    //    明細清單(專案管理紀錄明細，delete-then-reinsert) ─────────────────
    public partial class ProjectMeetingManagementControl : CommonUserControl
    {
        private static string id = "439B1335-038C-44F1-842B-22276163A553";

        private string _projectNo;
        private string _recordNo;
        private bool _isNew;
        private List<account> _activeAccounts = new List<account>();

        public event Action SavedOrClosed;

        public ProjectMeetingManagementControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
            initAccountCombo();
        }

        private void initAccountCombo()
        {
            var rep = new ProjectMeetingController().GetActiveAccountList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _activeAccounts = rep.resultList ?? new List<account>();
            var names = _activeAccounts.Select(a => a.姓名).Where(n => !string.IsNullOrEmpty(n)).Distinct().ToArray();
            colProposer.Items.Clear();
            colProposer.Items.AddRange(names);
            colReplyPerson.Items.Clear();
            colReplyPerson.Items.AddRange(names);
        }

        // ── 載入資料：recordNo 為 null 時為新增模式(比照原巨集 Add 並預帶專案序號)，
        //    否則依紀錄單號讀取既有主檔與明細清單 ──────────────────────────
        public void LoadData(string projectNo, string recordNo)
        {
            _projectNo = projectNo;
            _recordNo = recordNo;
            _isNew = string.IsNullOrEmpty(recordNo);

            txt專案序號.Text = _projectNo;
            dataGridView1.Rows.Clear();

            if (_isNew)
            {
                dt日期.Value = DateTime.Today;
                txt記錄人員.Text = AppSession.User?.username;
                txt紀錄單號.Text = "";
                txt紀錄單號.ReadOnly = false;
            }
            else
            {
                txt紀錄單號.Text = _recordNo;
                txt紀錄單號.ReadOnly = true;

                var rep = new ProjectMeetingController().GetMeetingRecord(_recordNo);
                if (!string.IsNullOrEmpty(rep.ErrorMessage))
                {
                    MessageBox.Show(rep.ErrorMessage);
                }
                else if (rep.result != null)
                {
                    var m = rep.result;
                    if (DateTime.TryParse(m.日期, out var dt)) dt日期.Value = dt;
                    cmb紀錄類別.Text = m.紀錄類別;
                    txt記錄人員.Text = m.記錄人員;
                    txt備註.Text = m.備註;
                }

                var detailRep = new ProjectMeetingController().GetMeetingDetailList(_recordNo);
                if (!string.IsNullOrEmpty(detailRep.ErrorMessage))
                {
                    MessageBox.Show(detailRep.ErrorMessage);
                }
                else
                {
                    foreach (var d in detailRep.resultList ?? new List<專案管理紀錄明細>())
                    {
                        int i = dataGridView1.Rows.Add();
                        var row = dataGridView1.Rows[i];
                        row.Cells[colProposer.Index].Value = d.事項提議人;
                        row.Cells[colOwnerUnit.Index].Value = d.權責處理單位;
                        row.Cells[colTopic.Index].Value = d.登載或注意事項;
                        row.Cells[colResolution.Index].Value = d.決議;
                        row.Cells[colNeedReply.Index].Value = d.回報要求 ?? false;
                        row.Cells[colReplyPerson.Index].Value = d.應回報人員;
                        row.Cells[colExpectDate.Index].Value = ShortDate(d.預計回報日期);
                        row.Cells[colActualDate.Index].Value = ShortDate(d.實際回報日期);
                        row.Cells[colReplyDesc.Index].Value = d.回報說明;
                        row.Cells[colManagerReview.Index].Value = d.管理者審閱 ?? false;
                    }
                }
            }
        }

        private static string ShortDate(string dt)
        {
            if (string.IsNullOrWhiteSpace(dt)) return "";
            int sp = dt.IndexOf(' ');
            return sp > 0 ? dt.Substring(0, sp) : dt;
        }

        // ── 儲存：RunCommand(SaveRecord) 對應同時存主檔與明細清單 ───────────────
        private void btnSave_Click(object sender, EventArgs e)
        {
            string recordNo = txt紀錄單號.Text.Trim();
            if (string.IsNullOrEmpty(recordNo))
            {
                MessageBox.Show("紀錄單號不可空白!");
                return;
            }

            var header = new 專案管理紀錄表
            {
                紀錄單號 = recordNo,
                日期 = dt日期.Value.ToString("yyyy-MM-dd"),
                專案序號 = _projectNo,
                紀錄類別 = cmb紀錄類別.Text,
                記錄人員 = txt記錄人員.Text,
                備註 = txt備註.Text,
            };

            if (_isNew)
            {
                var rep = new ProjectMeetingController().InsertMeetingRecord(header);
                if (!string.IsNullOrEmpty(rep.ErrorMessage))
                {
                    MessageBox.Show(rep.ErrorMessage);
                    return;
                }
            }
            else
            {
                var rep = new ProjectMeetingController().UpdateMeetingRecord(header);
                if (!string.IsNullOrEmpty(rep.ErrorMessage))
                {
                    MessageBox.Show(rep.ErrorMessage);
                    return;
                }
            }

            var list = new List<專案管理紀錄明細>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                string topic = row.Cells[colTopic.Index].Value?.ToString();
                string proposer = row.Cells[colProposer.Index].Value?.ToString();
                if (string.IsNullOrEmpty(topic) && string.IsNullOrEmpty(proposer)) continue;
                list.Add(new 專案管理紀錄明細
                {
                    事項提議人 = proposer,
                    權責處理單位 = row.Cells[colOwnerUnit.Index].Value?.ToString(),
                    登載或注意事項 = topic,
                    決議 = row.Cells[colResolution.Index].Value?.ToString(),
                    回報要求 = row.Cells[colNeedReply.Index].Value as bool? ?? false,
                    應回報人員 = row.Cells[colReplyPerson.Index].Value?.ToString(),
                    預計回報日期 = row.Cells[colExpectDate.Index].Value?.ToString(),
                    實際回報日期 = row.Cells[colActualDate.Index].Value?.ToString(),
                    回報說明 = row.Cells[colReplyDesc.Index].Value?.ToString(),
                    管理者審閱 = row.Cells[colManagerReview.Index].Value as bool? ?? false,
                });
            }
            var saveRep = new ProjectMeetingController().SaveMeetingDetailList(new SaveMeetingDetailRequest { RecordNo = recordNo, List = list });
            if (!string.IsNullOrEmpty(saveRep.ErrorMessage))
            {
                MessageBox.Show(saveRep.ErrorMessage);
                return;
            }

            MessageBox.Show("儲存成功!");
            _isNew = false;
            _recordNo = recordNo;
            txt紀錄單號.ReadOnly = true;
            SavedOrClosed?.Invoke();
        }

        // ── 列印：原巨集 OpenReport "專案管理紀錄表"，尚未建立對應報表 ───────────
        private void btnPrint_Click(object sender, EventArgs e) => MessageBox.Show("此功能尚未開放");

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

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }
    }
}
