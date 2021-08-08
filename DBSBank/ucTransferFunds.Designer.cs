
namespace DBSBank
{
    partial class ucTransferFunds
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
            this.btnTransfer = new System.Windows.Forms.Button();
            this.txtAccBalance = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtDestAccNo = new System.Windows.Forms.TextBox();
            this.txtDestName = new System.Windows.Forms.TextBox();
            this.txtSortCode = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtAccHolderName = new System.Windows.Forms.TextBox();
            this.cboSelectAcc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.epTf = new System.Windows.Forms.ErrorProvider(this.components);
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.epTf)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnTransfer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTransfer.Location = new System.Drawing.Point(559, 373);
            this.btnTransfer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(99, 40);
            this.btnTransfer.TabIndex = 6;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // txtAccBalance
            // 
            this.txtAccBalance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccBalance.Location = new System.Drawing.Point(425, 84);
            this.txtAccBalance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAccBalance.Name = "txtAccBalance";
            this.txtAccBalance.ReadOnly = true;
            this.txtAccBalance.Size = new System.Drawing.Size(156, 23);
            this.txtAccBalance.TabIndex = 16;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(188, 265);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(116, 23);
            this.txtAmount.TabIndex = 5;
            this.txtAmount.Validating += new System.ComponentModel.CancelEventHandler(this.txtAmount_Validating);
            this.txtAmount.Validated += new System.EventHandler(this.txtAmount_Validated);
            // 
            // txtDestAccNo
            // 
            this.txtDestAccNo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestAccNo.Location = new System.Drawing.Point(215, 203);
            this.txtDestAccNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDestAccNo.Name = "txtDestAccNo";
            this.txtDestAccNo.Size = new System.Drawing.Size(152, 23);
            this.txtDestAccNo.TabIndex = 2;
            this.txtDestAccNo.Validating += new System.ComponentModel.CancelEventHandler(this.txtDestAccNo_Validating);
            this.txtDestAccNo.Validated += new System.EventHandler(this.txtDestAccNo_Validated);
            // 
            // txtDestName
            // 
            this.txtDestName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestName.Location = new System.Drawing.Point(215, 234);
            this.txtDestName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDestName.Name = "txtDestName";
            this.txtDestName.Size = new System.Drawing.Size(366, 23);
            this.txtDestName.TabIndex = 4;
            this.txtDestName.Validating += new System.ComponentModel.CancelEventHandler(this.txtDestName_Validating);
            this.txtDestName.Validated += new System.EventHandler(this.txtDestName_Validated);
            // 
            // txtSortCode
            // 
            this.txtSortCode.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSortCode.Location = new System.Drawing.Point(477, 203);
            this.txtSortCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSortCode.Name = "txtSortCode";
            this.txtSortCode.Size = new System.Drawing.Size(104, 23);
            this.txtSortCode.TabIndex = 3;
            this.txtSortCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtSortCode_Validating);
            this.txtSortCode.Validated += new System.EventHandler(this.txtSortCode_Validated);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(155, 146);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(426, 23);
            this.txtDescription.TabIndex = 1;
            this.txtDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescription_Validating);
            this.txtDescription.Validated += new System.EventHandler(this.txtDescription_Validated);
            // 
            // txtAccHolderName
            // 
            this.txtAccHolderName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccHolderName.Location = new System.Drawing.Point(234, 115);
            this.txtAccHolderName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAccHolderName.Name = "txtAccHolderName";
            this.txtAccHolderName.ReadOnly = true;
            this.txtAccHolderName.Size = new System.Drawing.Size(347, 23);
            this.txtAccHolderName.TabIndex = 10;
            // 
            // cboSelectAcc
            // 
            this.cboSelectAcc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSelectAcc.FormattingEnabled = true;
            this.cboSelectAcc.Location = new System.Drawing.Point(173, 82);
            this.cboSelectAcc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboSelectAcc.Name = "cboSelectAcc";
            this.cboSelectAcc.Size = new System.Drawing.Size(153, 25);
            this.cboSelectAcc.TabIndex = 9;
            this.cboSelectAcc.Text = "Select an Account";
            this.cboSelectAcc.SelectedIndexChanged += new System.EventHandler(this.cboSelectAcc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(55, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(596, 52);
            this.label1.TabIndex = 36;
            this.label1.Text = "*Overdraft Limit of €100 ONLY for Current Accounts. Terms and Conditions apply.\r\n" +
    "** Savings Account does not support transfer to external accounts";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(32, 49);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(628, 10);
            this.panel2.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label5.Location = new System.Drawing.Point(28, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(301, 23);
            this.label5.TabIndex = 34;
            this.label5.Text = "Transfer to another Irish Account";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "To Account Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "From Account";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "Account Holder Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(349, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "Balance";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label8.Location = new System.Drawing.Point(56, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(529, 20);
            this.label8.TabIndex = 39;
            this.label8.Text = "_________________________________________________________________";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(389, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 40;
            this.label9.Text = "Sort Code";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(57, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 20);
            this.label10.TabIndex = 41;
            this.label10.Text = "Transfer Amount";
            // 
            // epTf
            // 
            this.epTf.ContainerControl = this;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label11.Location = new System.Drawing.Point(52, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 20);
            this.label11.TabIndex = 42;
            this.label11.Text = "Dest. Account Name";
            // 
            // ucTransferFunds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.txtAccBalance);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtDestAccNo);
            this.Controls.Add(this.txtDestName);
            this.Controls.Add(this.txtSortCode);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtAccHolderName);
            this.Controls.Add(this.cboSelectAcc);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucTransferFunds";
            this.Size = new System.Drawing.Size(684, 437);
            this.Load += new System.EventHandler(this.ucTransferFunds_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epTf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.TextBox txtAccBalance;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtDestAccNo;
        private System.Windows.Forms.TextBox txtDestName;
        private System.Windows.Forms.TextBox txtSortCode;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtAccHolderName;
        private System.Windows.Forms.ComboBox cboSelectAcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider epTf;
        private System.Windows.Forms.Label label11;
    }
}
