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
    public partial class ucWithdrawFunds : UserControl
    {
        public ucWithdrawFunds()
        {
            InitializeComponent();
        }
        SelectData selD = new SelectData();
        string accNo;
        CheckTransaction ct = new CheckTransaction();
        private void cboSelectAcc_SelectedIndexChanged(object sender, EventArgs e)
        {
            accNo = cboSelectAcc.SelectedItem.ToString();
            lblAccDetails.Text = $"Account Holder: {selD.PopulateFields(accNo, "FirstName")} {selD.PopulateFields(accNo, "Surname")} \n" +
                $"Balance: {selD.PopulateFields(accNo, "Balance")}";
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {

            int accountNumber = int.Parse(cboSelectAcc.SelectedItem.ToString());
            DateTime transactionTime = DateTime.Now;
            decimal amount = decimal.Parse(txtAmount.Text);
            decimal balance = decimal.Parse(selD.PopulateFields(accNo, "Balance"));
            decimal overdraft = decimal.Parse(selD.PopulateFields(accNo, "Overdraft"));
            string ttype = "Withdraw";
            decimal newbalance = balance - amount;

            if (ct.CheckOverDraft(overdraft, balance, amount))
            {
                TransactionsToDB tDB = new TransactionsToDB();

                tDB.WithdrawFromAcc(accountNumber, ttype, amount, transactionTime.ToString(), newbalance); ;

                MessageBox.Show($"Amount Withdrawn Successfully From Account {accountNumber}");
                this.Dispose();
            }
            else
                MessageBox.Show("Transaction not Authorised. Not enough funds!");

        }

        private void ucWithdrawFunds_Load(object sender, EventArgs e)
        {
            List<string> cboItems = selD.PComboBox();

            foreach (string item in cboItems)
            {
                cboSelectAcc.Items.Add(item);
            }

        }

        private void txtAmount_Validating(object sender, CancelEventArgs e)
        {
            FormValidator fm = new FormValidator();
            fm.ValidatingDecimal(epWd, txtAmount, e);
        }

        private void txtAmount_Validated(object sender, EventArgs e)
        {
            epWd.Clear();
        }
    }
}
