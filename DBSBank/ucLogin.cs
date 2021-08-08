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
    public partial class ucLogin : UserControl
    {
        public ucLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataToHash dt = new DataToHash();
            string user = txtUsername.Text;
            string pass = dt.DataHash(txtPassword.Text);

            NewStaff ns = new NewStaff(user, pass);

            if (!ns.CheckPassword() && !ns.CheckPassword())
            {
                SessionInfo.UsernameSession = user;

                MessageBox.Show($"Welcome {SessionInfo.UsernameSession}");
                txtPassword.Clear();
                txtUsername.Clear();

            }
            else
                MessageBox.Show("Username or Password incorrect!");
        }

        private void lblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormNewStaff fns = new FormNewStaff();
            fns.Show();
        }
    }
}
