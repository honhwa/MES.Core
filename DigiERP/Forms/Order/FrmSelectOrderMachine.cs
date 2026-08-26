using DigiERP.Models;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigiERP.Forms.Order
{
    // ── 自訂單新增機台2025：比照 PITS-2025.accdb「P-專案機台一覽2025」表單，
    //    列出業務訂單明細中已填專案序號、但尚未建立工令單者，選擇後按「轉開
    //    工令單」比照原巨集(Command1)依序執行「成交機台轉工令2025」+「成交機
    //    台轉產規2025」兩個新增查詢，於本專案改為單一交易內完成 ─────────────
    public partial class FrmSelectOrderMachine : Form
    {
        public string ConvertedProjectNo { get; private set; }

        public FrmSelectOrderMachine()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            var rep = new WorkOrderController().GetUnconvertedOrderMachineList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            dataGridView1.Rows.Clear();
            foreach (var x in rep.resultList ?? new List<訂單機台候選>())
            {
                int i = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                row.Cells[colProjectNo.Index].Value = x.專案序號;
                row.Cells[colOrderDate.Index].Value = ShortDate(x.訂單日期);
                row.Cells[colCustNo.Index].Value = x.客戶編號;
                row.Cells[colCustName.Index].Value = x.客戶名稱;
                row.Cells[colMachineType.Index].Value = x.機台類型;
                row.Cells[colMachineModel.Index].Value = x.機台型號;
                row.Cells[colMachineName.Index].Value = x.機台名稱;
            }
        }

        private static string ShortDate(string dt)
        {
            if (string.IsNullOrWhiteSpace(dt)) return "";
            int sp = dt.IndexOf(' ');
            return sp > 0 ? dt.Substring(0, sp) : dt;
        }

        // ── 轉開工令單：比照 Command1，機台類型(MTYPE)未指定時擋下 ───────────
        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("請先選擇一筆專案!");
                return;
            }
            string projectNo = dataGridView1.CurrentRow.Cells[colProjectNo.Index].Value?.ToString();
            if (string.IsNullOrEmpty(projectNo)) return;

            string machineType = dataGridView1.CurrentRow.Cells[colMachineType.Index].Value?.ToString();
            if (string.IsNullOrEmpty(machineType))
            {
                MessageBox.Show("機台類型尚未指定，請回訂單輸入後再轉工令！");
                return;
            }

            var rep = new WorkOrderController().ConvertOrderMachineToWorkOrder(projectNo, AppSession.User?.username);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }

            MessageBox.Show("轉開工令單成功!");
            ConvertedProjectNo = projectNo;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
