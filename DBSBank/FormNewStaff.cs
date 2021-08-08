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
    public partial class FormNewStaff : Form
    {
        string authcode = "1671251952214617430116691122092081712415886228187150108";
        public FormNewStaff()
        {
            InitializeComponent();
        }

        private void NewStaff_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            DataToHash dt = new DataToHash();
            string user = txtUsername.Text.ToLower();
            string pass = dt.DataHash(txtPassword.Text);
            string code = dt.DataHash(txtAutCode.Text);

            NewStaff ns = new NewStaff(user, pass);

            if (ns.CheckUsername() && code == authcode)
            {
                ns.AddnewStaffToDB();
                MessageBox.Show("User added successfully!");
                this.Dispose();
                

            }
            else if(code != authcode)
            { 
                MessageBox.Show("Operation Not Authorized!", "DBS Bank",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtUsername.Clear();
            txtPassword.Clear();
            txtAutCode.Clear();
            }
            else
            {
                MessageBox.Show("Error! Username taken.", "DBS Bank",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Clear();
                txtPassword.Clear();
                txtAutCode.Clear();
            }
            

        }
    }
}
