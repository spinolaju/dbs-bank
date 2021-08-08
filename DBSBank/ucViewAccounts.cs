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
using BIZ;
using System.Xml.Serialization;
using System.Xml;


namespace DBSBank
{
    public partial class ucViewAccounts : UserControl
    {
        SelectData sd = new SelectData();
        public ucViewAccounts()
        {
            InitializeComponent();
        }

        private void btnSerialise_Click(object sender, EventArgs e)
        {
            if (dgvAccounts.SelectedRows.Count > 0)
            {
                int rowindex = dgvAccounts.CurrentCell.RowIndex;
                //DataGridViewSelectedRowCollection row = dgvAccounts.SelectedRows;
                int accNum = int.Parse(dgvAccounts.Rows[rowindex].Cells[0].FormattedValue.ToString());
                string fn = dgvAccounts.Rows[rowindex].Cells[1].FormattedValue.ToString();
                string sn = dgvAccounts.Rows[rowindex].Cells[2].FormattedValue.ToString();
                string email = dgvAccounts.Rows[rowindex].Cells[3].FormattedValue.ToString();
                string phone = dgvAccounts.Rows[rowindex].Cells[4].FormattedValue.ToString();
                string addr1 = dgvAccounts.Rows[rowindex].Cells[5].FormattedValue.ToString();
                string addr2 = dgvAccounts.Rows[rowindex].Cells[6].FormattedValue.ToString();
                string city = dgvAccounts.Rows[rowindex].Cells[7].FormattedValue.ToString();
                string county = dgvAccounts.Rows[rowindex].Cells[8].FormattedValue.ToString();
                string acctype = dgvAccounts.Rows[rowindex].Cells[9].FormattedValue.ToString();
                decimal overdraft = decimal.Parse(dgvAccounts.Rows[rowindex].Cells[12].FormattedValue.ToString());
                decimal balance = decimal.Parse(dgvAccounts.Rows[rowindex].Cells[11].FormattedValue.ToString());

                BankAccount acc = new BankAccount(balance, fn, sn, email, phone, addr1, addr2, city, county, acctype, overdraft);
                XmlSerializer serial = new XmlSerializer(typeof(BankAccount));
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "XML|*.xml";


                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var stream = sfd.OpenFile();
                    XmlWriter xmlw = XmlWriter.Create(stream);
                    serial.Serialize(xmlw, acc);
                    MessageBox.Show("Serialised Successfully!");
                }
            }
        }

        private void ucViewAccounts_Load(object sender, EventArgs e)
        {
            DGVStyle();
            dgvAccounts.DataSource = sd.SelectAllAccounts();
            
        }



        void DGVStyle()
        {
            dgvAccounts.BorderStyle = BorderStyle.None;
            dgvAccounts.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvAccounts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAccounts.DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
            dgvAccounts.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvAccounts.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvAccounts.EnableHeadersVisualStyles = false;
            dgvAccounts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvAccounts.ColumnHeadersDefaultCellStyle.BackColor = Color.PaleTurquoise;
            dgvAccounts.ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkCyan;
        }
    }
}
