using DigiERP.Common;
using DigiERP.Models;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.HR.Calendar
{
    // ── 日曆休假表：比照 PITS-2025.accdb「H-日曆休假表」(Caption="日曆休假表"，
    //    畫面標題"日曆休假及出勤紀錄")還原，含內嵌子表單「H-請假紀錄查詢」
    //    (請假紀錄表)與「H-每日出勤紀錄」(出勤紀錄表)，皆依 日期 連動查詢，兩
    //    者皆為查詢結果、比照唯讀呈現(修改/儲存僅針對本表 H日曆 主檔)。
    //    「總覽」原巨集 OpenForm "H-日曆總覽"，開啟既有 CalendarControl，非新
    //    建。「生效」設定 核准生效=Yes、核准人=登入者；「取消生效」清空兩者，
    //    皆透過既有 SaveCalendarFull 寫回(與 CalendarControl 共用同一儲存路
    //    徑)。「列印」原表單未綁定巨集；「年度假別統計」對應 Access
    //    「H-年度假別統計表」查無既有畫面，兩者暫以提示訊息取代 ─────────────
    public partial class CalendarVacationControl : CommonUserControl
    {
        private static string id = "D629C23A-8A97-45A3-910A-9E20499A67E3";

        private string _date;
        private bool _isNew;

        public event Action SavedOrClosed;

        public CalendarVacationControl()
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
            SetEditable(false);
        }

        private void initStaffCombo()
        {
            var rep = new HRController().GetEmployeeList();
            var names = string.IsNullOrEmpty(rep.ErrorMessage)
                ? (rep.resultList ?? new List<員工清冊列表>()).Select(e => e.姓名).Where(n => !string.IsNullOrEmpty(n)).Distinct().ToArray()
                : new string[0];
            cmb人事經辦.Items.Clear();
            cmb人事經辦.Items.AddRange(names);
        }

        public void LoadData(string date)
        {
            _date = date;
            var rep = new HRController().GetCalendarByDate(date);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            var t = rep.result;
            _isNew = t == null;
            if (t == null)
            {
                t = new H日曆 { 日期 = date };
            }

            string[] weekdayNames = { "日", "一", "二", "三", "四", "五", "六" };
            txt日期.Text = t.日期;
            txt週次.Text = DateTime.TryParse(t.日期, out var d) ? weekdayNames[(int)d.DayOfWeek] : "";
            chk例假日.Checked = t.例假日 ?? false;
            txt公告事項.Text = t.公告事項;
            cmb人事經辦.Text = t.人事經辦;
            chk核准生效.Checked = t.核准生效 ?? false;
            txt核准人.Text = t.核准人;

            LoadLeaveGrid(date);
            LoadAttendGrid(date);

            SetEditable(false);
            btnEdit.Enabled = true;
            btnSave.Enabled = false;

            bool approved = t.核准生效 ?? false;
            btnApprove.Visible = !approved;
            btnUnapprove.Visible = approved;
        }

        private void LoadLeaveGrid(string date)
        {
            dataGridViewLeave.Rows.Clear();
            var rep = new HRController().GetLeaveRecordList(date);
            if (!string.IsNullOrEmpty(rep.ErrorMessage)) return;
            foreach (var x in rep.resultList ?? new List<請假紀錄列表>())
            {
                int i = dataGridViewLeave.Rows.Add();
                var row = dataGridViewLeave.Rows[i];
                row.Cells[colLeaveEmpNo.Index].Value = x.員工編號;
                row.Cells[colLeaveName.Index].Value = x.姓名;
                row.Cells[colLeavePersonal.Index].Value = x.事假;
                row.Cells[colLeaveSick.Index].Value = x.病假;
                row.Cells[colLeaveAnnual.Index].Value = x.特休假;
                row.Cells[colLeaveMaternity.Index].Value = x.產假;
                row.Cells[colLeaveOfficial.Index].Value = x.公假;
                row.Cells[colLeavePhysiological.Index].Value = x.生理假;
                row.Cells[colLeaveFamily.Index].Value = x.親情假;
                row.Cells[colLeaveAbsent.Index].Value = x.曠職;
                row.Cells[colLeaveRemark.Index].Value = x.備註;
                row.Cells[colLeaveDeductFactor.Index].Value = x.請假扣款乘數;
            }
        }

        private void LoadAttendGrid(string date)
        {
            dataGridViewAttend.Rows.Clear();
            var rep = new HRController().GetAttendanceList(date);
            if (!string.IsNullOrEmpty(rep.ErrorMessage)) return;
            foreach (var x in rep.resultList ?? new List<考勤紀錄列表>())
            {
                int i = dataGridViewAttend.Rows.Add();
                var row = dataGridViewAttend.Rows[i];
                row.Cells[colAttEmpNo.Index].Value = x.員工編號;
                row.Cells[colAttName.Index].Value = x.姓名;
                row.Cells[colAttCard.Index].Value = x.卡號;
                row.Cells[colAttShift.Index].Value = x.班次;
                row.Cells[colAttNormalIn.Index].Value = x.正規上班;
                row.Cells[colAttNormalOut.Index].Value = x.正規下班;
                row.Cells[colAttOTIn.Index].Value = x.加班上班;
                row.Cells[colAttOTOut.Index].Value = x.加班下班;
                row.Cells[colAttHours.Index].Value = x.出勤時數;
                row.Cells[colAttLeaveHours.Index].Value = x.請休時數;
                row.Cells[colAttLate.Index].Value = x.遲到分鐘數;
                row.Cells[colAttForgetCard.Index].Value = x.忘卡;
                row.Cells[colAttLeaveType.Index].Value = x.假別;
            }
        }

        private void SetEditable(bool editable)
        {
            chk例假日.Enabled = editable;
            txt公告事項.ReadOnly = !editable;
            cmb人事經辦.Enabled = editable;
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
            var form = new H日曆
            {
                日期 = _date,
                例假日 = chk例假日.Checked,
                公告事項 = txt公告事項.Text,
                人事經辦 = cmb人事經辦.Text,
                核准生效 = chk核准生效.Checked,
                核准人 = txt核准人.Text,
            };
            var rep = new HRController().SaveCalendarFull(form);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            MessageBox.Show("儲存成功!");
            SetEditable(false);
            LoadData(_date);
            SavedOrClosed?.Invoke();
        }

        // ── 生效：SetValue 核准生效=Yes、核准人=登入者 ──────────────────────────
        private void btnApprove_Click(object sender, EventArgs e)
        {
            var form = new H日曆
            {
                日期 = _date,
                例假日 = chk例假日.Checked,
                公告事項 = txt公告事項.Text,
                人事經辦 = cmb人事經辦.Text,
                核准生效 = true,
                核准人 = AppSession.User?.name,
            };
            var rep = new HRController().SaveCalendarFull(form);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            MessageBox.Show("生效成功!");
            btnApprove.Visible = false;
            btnUnapprove.Visible = true;
            LoadData(_date);
        }

        private void btnUnapprove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您確定要取消生效", "請選擇", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            var form = new H日曆
            {
                日期 = _date,
                例假日 = chk例假日.Checked,
                公告事項 = txt公告事項.Text,
                人事經辦 = cmb人事經辦.Text,
                核准生效 = false,
                核准人 = null,
            };
            var rep = new HRController().SaveCalendarFull(form);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            MessageBox.Show("已取消生效!");
            btnApprove.Visible = true;
            btnUnapprove.Visible = false;
            LoadData(_date);
        }

        // ── 總覽：原巨集 OpenForm "H-日曆總覽"，開啟既有 CalendarControl ────────
        private void btnOverview_Click(object sender, EventArgs e)
        {
            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl))
            {
                var standalone = new CalendarControl { Dock = DockStyle.Fill };
                return;
            }
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            const string tabName = "CalendarOverview";
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == tabName)
                {
                    tabControl.SelectedTab = page;
                    return;
                }
            }
            var ctrl = new CalendarControl { Dock = DockStyle.Fill };
            var tab = new TabPage("日曆總覽") { Name = tabName };
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
        }

        // ── 年度假別統計/列印：原表單分屬 Access Report 及查無既有畫面的獨立
        //    表單，暫以提示訊息取代 ─────────────────────────────────────────
        private void btnAnnualStats_Click(object sender, EventArgs e) => MessageBox.Show("此功能尚未開放(對應 Access「H-年度假別統計表」，查無既有畫面)，如需要請另行告知");
        private void btnPrint_Click(object sender, EventArgs e) => MessageBox.Show("此功能尚未開放(原表單未綁定列印巨集)");

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
