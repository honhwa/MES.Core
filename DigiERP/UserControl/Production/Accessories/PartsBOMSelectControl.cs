using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production.Accessories
{
    // ── 專案零件選項：比照 PITS-2025.accdb「P-零件申請選項」(Caption="專案零件
    //    選項")。由「查詢客戶專案機台零件」按鈕開啟前，會先執行"BRG-零件"查詢
    //    將對應客戶/專案的 採購計畫 零件暫存到 零件申請BRG(見
    //    AccessoriesApplyControl.btnQueryParts_Click)，本畫面僅負責勾選、確認。
    //    確定：先依畫面勾選狀態回寫 零件申請BRG.選項，再比照"BRG-零件轉申請"
    //    將已勾選列轉入 零件申請明細，最後比照"BRG-零件選項刪除"清空暫存 ──────
    public partial class PartsBOMSelectControl : System.Windows.Forms.UserControl
    {
        private readonly string _orderNo;

        public bool Confirmed { get; private set; }
        public event Action<bool> Closed;

        public PartsBOMSelectControl(string orderNo)
        {
            InitializeComponent();
            _orderNo = orderNo;
            LoadData();
        }

        private void LoadData()
        {
            var rep = new MfgController().GetBRGPartsList(_orderNo);
            dataGridView1.Rows.Clear();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            foreach (var x in rep.resultList ?? new List<零件申請BRG>())
            {
                int i = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                row.Cells[colId.Index].Value = x.識別碼;
                row.Cells[colCheck.Index].Value = false;
                row.Cells[colOrderNo.Index].Value = x.單號;
                row.Cells[colPartNo.Index].Value = x.零件號碼;
                row.Cells[colPartType.Index].Value = x.零件分類;
                row.Cells[colItemName.Index].Value = x.品名;
                row.Cells[colDesc.Index].Value = x.描述;
                row.Cells[colModule.Index].Value = x.附屬模組;
            }
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("查無此客戶/專案的機台零件清單(採購計畫)可供選擇。");
            }
        }

        // ── 確定：需先勾選至少一筆，回寫勾選狀態後轉入 零件申請明細 ──────────────
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            var checkedIds = new List<int>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[colCheck.Index].Value is bool b && b && row.Cells[colId.Index].Value != null)
                {
                    checkedIds.Add(Convert.ToInt32(row.Cells[colId.Index].Value));
                }
            }
            if (checkedIds.Count == 0)
            {
                MessageBox.Show("請至少勾選一筆零件!");
                return;
            }
            if (MessageBox.Show("您已確定選項?", "請選擇", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            var setRep = new MfgController().SetBRGSelected(new SetBRGSelectedRequest { OrderNo = _orderNo, CheckedIds = checkedIds });
            if (!string.IsNullOrEmpty(setRep.ErrorMessage))
            {
                MessageBox.Show(setRep.ErrorMessage);
                return;
            }

            var rep = new MfgController().ConfirmBRGSelection(_orderNo);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            Confirmed = true;
            Closed?.Invoke(true);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Confirmed = false;
            Closed?.Invoke(false);
        }
    }
}
