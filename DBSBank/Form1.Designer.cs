namespace DBSBank
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuLogged = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositFundsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withdrawFundsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferFundsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl = new System.Windows.Forms.Panel();
            this.menuLogged.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuLogged
            // 
            this.menuLogged.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.accountToolStripMenuItem});
            this.menuLogged.Location = new System.Drawing.Point(0, 0);
            this.menuLogged.Name = "menuLogged";
            this.menuLogged.Size = new System.Drawing.Size(668, 24);
            this.menuLogged.TabIndex = 0;
            this.menuLogged.Text = "menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LogInToolStripMenuItem,
            this.accountsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // LogInToolStripMenuItem
            // 
            this.LogInToolStripMenuItem.Name = "LogInToolStripMenuItem";
            this.LogInToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.LogInToolStripMenuItem.Text = "Log out";
            this.LogInToolStripMenuItem.Click += new System.EventHandler(this.LogInToolStripMenuItem_Click);
            // 
            // accountsToolStripMenuItem
            // 
            this.accountsToolStripMenuItem.Name = "accountsToolStripMenuItem";
            this.accountsToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.accountsToolStripMenuItem.Text = "Exit";
            this.accountsToolStripMenuItem.Click += new System.EventHandler(this.accountsToolStripMenuItem_Click);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAccountToolStripMenuItem,
            this.editAccountToolStripMenuItem,
            this.viewAccountsToolStripMenuItem,
            this.depositFundsToolStripMenuItem,
            this.withdrawFundsToolStripMenuItem,
            this.transferFundsToolStripMenuItem,
            this.viewTransactionsToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountToolStripMenuItem.Text = "Account";
            this.accountToolStripMenuItem.Visible = false;
            // 
            // newAccountToolStripMenuItem
            // 
            this.newAccountToolStripMenuItem.Name = "newAccountToolStripMenuItem";
            this.newAccountToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.newAccountToolStripMenuItem.Text = "New Account";
            this.newAccountToolStripMenuItem.Click += new System.EventHandler(this.newAccountToolStripMenuItem_Click);
            // 
            // editAccountToolStripMenuItem
            // 
            this.editAccountToolStripMenuItem.Name = "editAccountToolStripMenuItem";
            this.editAccountToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.editAccountToolStripMenuItem.Text = "Edit Account";
            this.editAccountToolStripMenuItem.Click += new System.EventHandler(this.editAccountToolStripMenuItem_Click);
            // 
            // viewAccountsToolStripMenuItem
            // 
            this.viewAccountsToolStripMenuItem.Name = "viewAccountsToolStripMenuItem";
            this.viewAccountsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.viewAccountsToolStripMenuItem.Text = "View Accounts";
            this.viewAccountsToolStripMenuItem.Click += new System.EventHandler(this.viewAccountsToolStripMenuItem_Click);
            // 
            // depositFundsToolStripMenuItem
            // 
            this.depositFundsToolStripMenuItem.Name = "depositFundsToolStripMenuItem";
            this.depositFundsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.depositFundsToolStripMenuItem.Text = "Deposit Funds";
            this.depositFundsToolStripMenuItem.Click += new System.EventHandler(this.depositFundsToolStripMenuItem_Click);
            // 
            // withdrawFundsToolStripMenuItem
            // 
            this.withdrawFundsToolStripMenuItem.Name = "withdrawFundsToolStripMenuItem";
            this.withdrawFundsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.withdrawFundsToolStripMenuItem.Text = "Withdraw Funds";
            this.withdrawFundsToolStripMenuItem.Click += new System.EventHandler(this.withdrawFundsToolStripMenuItem_Click);
            // 
            // transferFundsToolStripMenuItem
            // 
            this.transferFundsToolStripMenuItem.Name = "transferFundsToolStripMenuItem";
            this.transferFundsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.transferFundsToolStripMenuItem.Text = "Transfer Funds";
            this.transferFundsToolStripMenuItem.Click += new System.EventHandler(this.transferFundsToolStripMenuItem_Click);
            // 
            // viewTransactionsToolStripMenuItem
            // 
            this.viewTransactionsToolStripMenuItem.Name = "viewTransactionsToolStripMenuItem";
            this.viewTransactionsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.viewTransactionsToolStripMenuItem.Text = "View Transactions";
            this.viewTransactionsToolStripMenuItem.Click += new System.EventHandler(this.viewTransactionsToolStripMenuItem_Click);
            // 
            // pnl
            // 
            this.pnl.Location = new System.Drawing.Point(-7, 22);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(679, 546);
            this.pnl.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(668, 461);
            this.Controls.Add(this.menuLogged);
            this.Controls.Add(this.pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuLogged;
            this.Name = "Form1";
            this.Text = "DBS Bank";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuLogged.ResumeLayout(false);
            this.menuLogged.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuLogged;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LogInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositFundsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withdrawFundsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferFundsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAccountsToolStripMenuItem;
        private System.Windows.Forms.Panel pnl;
    }
}

