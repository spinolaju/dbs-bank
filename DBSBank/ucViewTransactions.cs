using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace DBSBank
{
    public partial class ucViewTransactions : UserControl
    {
        SelectData sd = new SelectData();
        public ucViewTransactions()
        {
            InitializeComponent();
        }

        private void ucViewTransactions_Load(object sender, EventArgs e)
        {
            DGVStyle();
            dgvTransaction.DataSource = sd.SelectAllTransaction();
        }
    

        private void txtAccountNumber_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAccountNumber.Text))
                dgvTransaction.DataSource = sd.SelectAllTransaction();

            else
            {
                int accNum = int.Parse(txtAccountNumber.Text);
                dgvTransaction.DataSource = sd.SelectTransactionByAcc(accNum);
            }
        }

        void DGVStyle()
        {
            dgvTransaction.BorderStyle = BorderStyle.None;
            dgvTransaction.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvTransaction.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTransaction.DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
            dgvTransaction.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvTransaction.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvTransaction.EnableHeadersVisualStyles = false;
            dgvTransaction.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvTransaction.ColumnHeadersDefaultCellStyle.BackColor = Color.PaleTurquoise;
            dgvTransaction.ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkCyan;
        }
    }
}
