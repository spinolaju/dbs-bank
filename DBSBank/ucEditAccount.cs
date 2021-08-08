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


namespace DBSBank
{
    public partial class ucEditAccount : UserControl
    {
        SelectData selD = new SelectData();
        string accNo;
        public ucEditAccount()
        {
            InitializeComponent();
        }
        FormValidator fm;

        private void ucEditAccount_Load(object sender, EventArgs e)
        {
            List<string> cboItems = selD.PComboBox();

            foreach (string item in cboItems)
            {
                cboSelectAcc.Items.Add(item);
            }

        }

        private void cboSelectAcc_SelectedIndexChanged(object sender, EventArgs e)
        {
            accNo = cboSelectAcc.SelectedItem.ToString();
            txtBalance.Text = (selD.PopulateFields(accNo, "Balance"));
            txtFn.Text = (selD.PopulateFields(accNo, "FirstName"));
            txtSn.Text = (selD.PopulateFields(accNo, "Surname"));
            txtPhone.Text = (selD.PopulateFields(accNo, "Phone"));
            txtEmail.Text = (selD.PopulateFields(accNo, "Email"));
            txtAddr1.Text = (selD.PopulateFields(accNo, "Address1"));
            txtAddr2.Text = (selD.PopulateFields(accNo, "Address2"));
            txtCity.Text = (selD.PopulateFields(accNo, "City"));
            txtCounty.Text = (selD.PopulateFields(accNo, "County"));
            txtSortCode.Text = (selD.PopulateFields(accNo, "SortCode"));
            txtAccType.Text = (selD.PopulateFields(accNo, "AccountType"));
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            accNo = cboSelectAcc.SelectedItem.ToString();
            string phoneNo = txtPhone.Text;
            string email = txtEmail.Text;
            string address1 = txtAddr1.Text;
            string address2 = txtAddr2.Text;
            string city = txtCity.Text;
            string county = txtCounty.Text;

            selD.UpdateBankAcc(phoneNo, email, address1, address2, city, county, accNo);

            MessageBox.Show("Account Updated Successfully!");

            this.Dispose();
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            fm = new FormValidator();
            fm.ValidatingFields(epEA, txtPhone, e);
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            fm = new FormValidator();
            fm.ValidantingEmail(epEA, txtEmail, e);
        }

        private void txtAddr1_Validating(object sender, CancelEventArgs e)
        {
            fm = new FormValidator();
            fm.ValidatingFields(epEA, txtAddr1, e);
        }

        private void txtAddr2_Validating(object sender, CancelEventArgs e)
        {
            fm = new FormValidator();
            fm.ValidatingFields(epEA, txtAddr2, e);
        }

        private void txtCity_Validating(object sender, CancelEventArgs e)
        {
            fm = new FormValidator();
            fm.ValidatingFields(epEA, txtCity, e);
        }

        private void txtCounty_Validating(object sender, CancelEventArgs e)
        {
            fm = new FormValidator();
            fm.ValidatingFields(epEA, txtCounty, e);
        }

        private void txtPhone_Validated(object sender, EventArgs e)
        {
            epEA.Clear();
        }

        private void txtEmail_Validated(object sender, EventArgs e)
        {
            epEA.Clear();
        }

        private void txtAddr1_Validated(object sender, EventArgs e)
        {
            epEA.Clear();
        }

        private void txtAddr2_Validated(object sender, EventArgs e)
        {
            epEA.Clear();
        }

        private void txtCity_Validated(object sender, EventArgs e)
        {
            epEA.Clear();
        }

        private void txtCounty_Validated(object sender, EventArgs e)
        {
            epEA.Clear();
        }
    }
}
