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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        UserCManager mng = new UserCManager();
        
        SelectData sd = new SelectData();

        private void Form1_Load(object sender, EventArgs e)
        {
            ucLogin uclogin = new ucLogin();
            mng.DisplayControl(uclogin, pnl);
            

            if (SessionInfo.UsernameSession == null || SessionInfo.UsernameSession == "")
            {
                accountToolStripMenuItem.Visible = false;
                LogInToolStripMenuItem.Text = "Log In";

            }
            else
            {
                accountToolStripMenuItem.Visible = true;
                LogInToolStripMenuItem.Text = "Log Out";

            }
        }

        private void LogInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if(LogInToolStripMenuItem.Text == "Log Out")
            {
                ucLogin uclogin = new ucLogin();
                accountToolStripMenuItem.Visible = false;
                LogInToolStripMenuItem.Text = "Log In";
                mng.DisplayControl(uclogin, pnl);
                SessionInfo.UsernameSession = null;
            }
            else 
            {
                ucLogin uclogin = new ucLogin();
                accountToolStripMenuItem.Visible = true;
                LogInToolStripMenuItem.Text = "Log Out";
                
                mng.DisplayControl(uclogin, pnl);
            }

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (SessionInfo.UsernameSession == null || SessionInfo.UsernameSession == "")
            {
                ucLogin uclogin = new ucLogin();
                accountToolStripMenuItem.Visible = false;
                LogInToolStripMenuItem.Text = "Log In";
                mng.DisplayControl(uclogin, pnl);

            }
            else
            {
                accountToolStripMenuItem.Visible = true;
                LogInToolStripMenuItem.Text = "Log Out";
                ucViewAccounts ucva = new ucViewAccounts();
                mng.DisplayControl(ucva, pnl);
            }
        }

        private void newAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            ucNewAccount ucna = new ucNewAccount();
            mng.DisplayControl(ucna, pnl);
           
        }

        private void accountsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Are you sure you want to exit the Application?", "DBS Bank", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                Application.Exit();

        }

        private void editAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ucEditAccount ucea = new ucEditAccount();
            mng.DisplayControl(ucea, pnl);
            


        }

        private void depositFundsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ucDepositFunds ucdf = new ucDepositFunds();
            mng.DisplayControl(ucdf, pnl);
            
        }

        private void withdrawFundsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucWithdrawFunds ucwf = new ucWithdrawFunds();
            mng.DisplayControl(ucwf, pnl);


        }

        private void transferFundsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucTransferFunds uctf = new ucTransferFunds();
            mng.DisplayControl(uctf, pnl);


        }

        private void viewTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucViewTransactions ucvt = new ucViewTransactions();
            mng.DisplayControl(ucvt, pnl);


        }

        private void viewAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucViewAccounts ucva = new ucViewAccounts();
            mng.DisplayControl(ucva, pnl);

        }
        

    

    }
}
