
namespace DBSBank
{
    partial class ucWithdrawFunds
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cboSelectAcc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.epWd = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblAccDetails = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.epWd)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnWithdraw.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnWithdraw.Location = new System.Drawing.Point(522, 356);
            this.btnWithdraw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(134, 46);
            this.btnWithdraw.TabIndex = 2;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(191, 246);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(149, 23);
            this.txtAmount.TabIndex = 1;
            this.txtAmount.Validating += new System.ComponentModel.CancelEventHandler(this.txtAmount_Validating);
            this.txtAmount.Validated += new System.EventHandler(this.txtAmount_Validated);
            // 
            // cboSelectAcc
            // 
            this.cboSelectAcc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSelectAcc.FormattingEnabled = true;
            this.cboSelectAcc.Location = new System.Drawing.Point(191, 80);
            this.cboSelectAcc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboSelectAcc.Name = "cboSelectAcc";
            this.cboSelectAcc.Size = new System.Drawing.Size(166, 25);
            this.cboSelectAcc.TabIndex = 9;
            this.cboSelectAcc.Text = "Select an Account";
            this.cboSelectAcc.SelectedIndexChanged += new System.EventHandler(this.cboSelectAcc_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Account Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Account Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Amount";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(28, 49);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(628, 10);
            this.panel2.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label5.Location = new System.Drawing.Point(24, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 23);
            this.label5.TabIndex = 28;
            this.label5.Text = "Withdrawal";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(40, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(596, 52);
            this.label1.TabIndex = 30;
            this.label1.Text = "*Overdraft Limit of €100 for Current Accounts. Terms and Conditions apply.\r\n** Sa" +
    "ving Account does not support Overdraft. ";
            // 
            // epWd
            // 
            this.epWd.ContainerControl = this;
            // 
            // lblAccDetails
            // 
            this.lblAccDetails.BackColor = System.Drawing.Color.PowderBlue;
            this.lblAccDetails.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccDetails.Location = new System.Drawing.Point(192, 124);
            this.lblAccDetails.Name = "lblAccDetails";
            this.lblAccDetails.Size = new System.Drawing.Size(414, 105);
            this.lblAccDetails.TabIndex = 37;
            // 
            // ucWithdrawFunds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            this.Controls.Add(this.lblAccDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.cboSelectAcc);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucWithdrawFunds";
            this.Size = new System.Drawing.Size(684, 437);
            this.Load += new System.EventHandler(this.ucWithdrawFunds_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epWd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cboSelectAcc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider epWd;
        private System.Windows.Forms.Label lblAccDetails;
    }
}
