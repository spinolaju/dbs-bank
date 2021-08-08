using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BIZ;

namespace DBSBank
{
    public partial class ucNewAccount : UserControl
    {
        public ucNewAccount()
        {
            InitializeComponent();
        }
        FormValidator fm;
        private void btnNextAccInfo_Click(object sender, EventArgs e)
        {
            tabNewAcc.SelectTab(tbPersonal);

        }

        private void btnPrevPersonal_Click(object sender, EventArgs e)
        {
            tabNewAcc.SelectTab(tbAcc);
        }

        private void btnNextPersonal_Click(object sender, EventArgs e)
        {
            tabNewAcc.SelectTab(tbResAdd);
        }

        private void btnPrevRes_Click(object sender, EventArgs e)
        {
            tabNewAcc.SelectTab(tbPersonal);
        }

        private void btnNextRes_Click(object sender, EventArgs e)
        {
            tabNewAcc.SelectTab(tbReview);
            AccInfo();
        }

        private void btnPrevRev_Click(object sender, EventArgs e)
        {
            tabNewAcc.SelectTab(tbResAdd);

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string accType = "Savings";
            decimal overdraftLim = 0;

            if (rdoCurrent.Checked)
            {
                accType = "Current";
                overdraftLim = 100;
            }
            int initialBal;
            Int32.TryParse(txtInitialBal.Text, out initialBal);

            string fName = txtFName.Text;
            string surname = txtSurn.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            string add1 = txtAddress1.Text;
            string add2 = txtAddress2.Text;
            string city = txtCity.Text;
            string county = cboCounty.SelectedItem.ToString();


            BankAccount ba = new BankAccount(initialBal, fName, surname, email, phone, add1, add2, city, county, accType, overdraftLim);

            ba.AddNewAccDB();

            MessageBox.Show("Account created successfully!");
            this.Dispose();
        }

        private void UCNewAccount_Load(object sender, EventArgs e)
        {
            cboCounty.DataSource = Enum.GetValues(typeof(Counties));
        }


        void AccInfo()
        {
            lblInfo.Text = $"Account Information: Initial Deposit: {txtInitialBal.Text}" +
               $" \nName: {txtFName.Text} {txtSurn.Text}" +
               $"\nPhone Number: {txtPhone.Text} " +
               $"\nEmail: {txtEmail.Text}" +
               $"\nAddress: {txtAddress1.Text}, {txtAddress2.Text}" +
               $"\nCity: {txtCity.Text} " +
               $"\nCounty: {cboCounty.SelectedItem.ToString()}";
        }

        private void txtInitialBal_Validating(object sender, CancelEventArgs e)
        {
            fm = new FormValidator();
            fm.ValidatingInt(epInitialDep, txtInitialBal, e);
            
        }

        private void txtInitialBal_Validated(object sender, EventArgs e)
        {
            epInitialDep.Clear();
        }

        private void txtFName_Validating(object sender, CancelEventArgs e)
        {
            fm = new FormValidator();
            fm.ValidatingFields(epFn, txtFName, e);
           
        }

        private void txtFName_Validated(object sender, EventArgs e)
        {
            epFn.Clear();
        }

        private void txtSurn_Validated(object sender, EventArgs e)
        {
            epFn.Clear();
        }

        private void txtSurn_Validating(object sender, CancelEventArgs e)
        {
            fm = new FormValidator();
            fm.ValidatingFields(epFn, txtSurn, e);

        }

        private void txtPhone_Validated(object sender, EventArgs e)
        {
            epFn.Clear();
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            fm = new FormValidator();
            fm.ValidatingFields(epFn, txtPhone, e);
        }

        private void txtEmail_Validated(object sender, EventArgs e)
        {
            epFn.Clear();
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            fm = new FormValidator();
            fm.ValidantingEmail(epFn, txtEmail, e);
        }

        private void txtAddress1_Validating(object sender, CancelEventArgs e)
        {
            fm = new FormValidator();
            fm.ValidatingFields(epFn, txtAddress1, e);

        }

        private void txtAddress1_Validated(object sender, EventArgs e)
        {
            epFn.Clear();
        }

        private void txtAddress2_Validated(object sender, EventArgs e)
        {
            epFn.Clear();
        }

        private void txtAddress2_Validating(object sender, CancelEventArgs e)
        {
            fm = new FormValidator();
            fm.ValidatingFields(epFn, txtAddress2, e);
        }

        private void txtCity_Validated(object sender, EventArgs e)
        {
            epFn.Clear();
        }

        private void txtCity_Validating(object sender, CancelEventArgs e)
        {
            fm = new FormValidator();
            fm.ValidatingFields(epFn, txtCity, e);
        }
    }
}
