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
    public partial class ucTransferFunds : UserControl
    {
        public ucTransferFunds()
        {
            InitializeComponent();
        }
        SelectData selD = new SelectData();
        string accNo;
        CheckTransaction ct = new CheckTransaction();
        FormValidator fm;
        private void cboSelectAcc_SelectedIndexChanged(object sender, EventArgs e)
        {
            accNo = cboSelectAcc.SelectedItem.ToString();
            txtAccHolderName.Text = $"{selD.PopulateFields(accNo, "FirstName")} {selD.PopulateFields(accNo, "Surname")}";
            txtAccBalance.Text = selD.PopulateFields(accNo, "Balance");
           
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            TransactionsToDB tDB = new TransactionsToDB();

            int accountNumber = int.Parse(cboSelectAcc.SelectedItem.ToString());
            decimal balance = decimal.Parse(txtAccBalance.Text);

            string accHolderName = txtAccHolderName.Text;
            string description = txtDescription.Text;
            string ttype = "Transfer";
            int dSortCode = int.Parse(txtSortCode.Text);

            string dName = txtDestName.Text;
            int dAccNo = int.Parse(txtDestAccNo.Text);
            decimal tAmount = decimal.Parse(txtAmount.Text);
            DateTime tDate = DateTime.Now;

            decimal overdraft = decimal.Parse(selD.PopulateFields(accNo, "Overdraft"));
            decimal newbalance = balance - tAmount;
            string accType = selD.PopulateFields(accNo, "AccountType");

            if (ct.CheckOverDraft(overdraft, balance, tAmount))
            {
                if (ct.CheckInternalAccount(dSortCode))
                {
                    //Transaction  OK
                    tDB.TransferToAcc(accountNumber, accHolderName, description, ttype, dSortCode, dName, dAccNo, tAmount, tDate.ToString(), newbalance);

                    if(!tDB.CheckTransferAcc(dAccNo))
                        {
                        //Update Account table
                        decimal destBalance = decimal.Parse(selD.PopulateFields(txtDestAccNo.Text, "Balance"));

                        decimal destNewBalance = destBalance + tAmount;
                        tDB.UpdateAccountBalance(dAccNo, destNewBalance);

                        //Update BankTransaction table
                        tDB.AddToTransaction(dAccNo, "Transfer Received", tAmount, tDate.ToString(), destNewBalance);
                    }
                    MessageBox.Show($"Amount Transferred Successfully to Account {dAccNo}");
                }
                else
                {
                    if (ct.CheckAccType(accType))
                    {
                        tDB.TransferToAcc(accountNumber, accHolderName, description, ttype, dSortCode, dName, dAccNo, tAmount, tDate.ToString(), newbalance);
                        MessageBox.Show($"Amount Transferred Successfully to Account {dAccNo}");
                    }
                    else
                    {
                        MessageBox.Show("Transaction not Authorised. Savings Account cannot transfer to an external account.");
                    }

                }
            }
            else
                MessageBox.Show("Transaction not Authorised. Not enough funds!");



        }

        private void ucTransferFunds_Load(object sender, EventArgs e)
        {
            List<string> cboItems = selD.PComboBox();

            foreach (string item in cboItems)
            {
                cboSelectAcc.Items.Add(item);
            }
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            fm = new FormValidator();
            fm.ValidatingFields(epTf, txtDescription, e);
        }

        private void txtDescription_Validated(object sender, EventArgs e)
        {
            epTf.Clear();
        }

        private void txtDestAccNo_Validating(object sender, CancelEventArgs e)
        {
            fm = new FormValidator();
            fm.ValidatingInt(epTf, txtDestAccNo, e);

        }

        private void txtDestAccNo_Validated(object sender, EventArgs e)
        {
            epTf.Clear();
        }

        private void txtSortCode_Validating(object sender, CancelEventArgs e)
        {
            fm = new FormValidator();
            fm.ValidatingInt(epTf, txtSortCode, e);
        }

        private void txtSortCode_Validated(object sender, EventArgs e)
        {
            epTf.Clear();
        }

        private void txtAmount_Validating(object sender, CancelEventArgs e)
        {
            fm = new FormValidator();
            fm.ValidatingDecimal(epTf, txtAmount, e);
        }

        private void txtAmount_Validated(object sender, EventArgs e)
        {
            epTf.Clear();
        }

        private void txtDestName_Validating(object sender, CancelEventArgs e)
        {
            fm = new FormValidator();
            fm.ValidatingFields(epTf, txtDestName, e);
        }

        private void txtDestName_Validated(object sender, EventArgs e)
        {
            epTf.Clear();
        }


    }
}
