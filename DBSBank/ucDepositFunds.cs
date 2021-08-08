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
    public partial class ucDepositFunds : UserControl
    {
        SelectData selD = new SelectData();
        string accNo;
        public ucDepositFunds()
        {
            InitializeComponent();
        }
        
        private void ucDepositFunds_Load(object sender, EventArgs e)
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
            lblAccDetails.Text = $"Account Holder: {selD.PopulateFields(accNo, "FirstName")} {selD.PopulateFields(accNo, "Surname")}" +
                $"\nBalance: {selD.PopulateFields(accNo, "Balance")}";
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            int accountNumber = int.Parse(cboSelectAcc.SelectedItem.ToString());
            DateTime transactionTime = DateTime.Now;
            decimal amount = decimal.Parse(txtAmount.Text);
            decimal balance = decimal.Parse(selD.PopulateFields(accNo, "Balance"));
            string ttype = "Deposit";
            decimal newbalance = balance + amount;
            TransactionsToDB tDB = new TransactionsToDB();

            tDB.DepositToAcc(accountNumber, ttype, amount, transactionTime.ToString(), newbalance); ;

            MessageBox.Show($"Amount Deposited Successfully to Account {accountNumber}");

            this.Dispose();
        }

        private void txtAmount_Validating(object sender, CancelEventArgs e)
        {
            FormValidator fm = new FormValidator();
            fm.ValidatingDecimal(epDepFunds, txtAmount, e);
        }

        private void txtAmount_Validated(object sender, EventArgs e)
        {
            epDepFunds.Clear();
        }
    }
}
