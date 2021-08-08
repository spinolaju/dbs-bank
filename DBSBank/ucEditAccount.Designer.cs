
namespace DBSBank
{
    partial class ucEditAccount
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddr2 = new System.Windows.Forms.TextBox();
            this.txtSortCode = new System.Windows.Forms.TextBox();
            this.txtAddr1 = new System.Windows.Forms.TextBox();
            this.txtAccType = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtSn = new System.Windows.Forms.TextBox();
            this.txtFn = new System.Windows.Forms.TextBox();
            this.cboSelectAcc = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.epEA = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epEA)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Location = new System.Drawing.Point(516, 387);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(131, 30);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Update Details";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtBalance
            // 
            this.txtBalance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.Location = new System.Drawing.Point(466, 110);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(4);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(118, 23);
            this.txtBalance.TabIndex = 24;
            // 
            // txtCounty
            // 
            this.txtCounty.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCounty.Location = new System.Drawing.Point(427, 330);
            this.txtCounty.Margin = new System.Windows.Forms.Padding(4);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(157, 23);
            this.txtCounty.TabIndex = 6;
            this.txtCounty.Validating += new System.ComponentModel.CancelEventHandler(this.txtCounty_Validating);
            this.txtCounty.Validated += new System.EventHandler(this.txtCounty_Validated);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(398, 195);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(186, 23);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            this.txtEmail.Validated += new System.EventHandler(this.txtEmail_Validated);
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(189, 196);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(140, 23);
            this.txtPhone.TabIndex = 1;
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhone_Validating);
            this.txtPhone.Validated += new System.EventHandler(this.txtPhone_Validated);
            // 
            // txtAddr2
            // 
            this.txtAddr2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddr2.Location = new System.Drawing.Point(189, 286);
            this.txtAddr2.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddr2.Name = "txtAddr2";
            this.txtAddr2.Size = new System.Drawing.Size(395, 23);
            this.txtAddr2.TabIndex = 4;
            this.txtAddr2.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddr2_Validating);
            this.txtAddr2.Validated += new System.EventHandler(this.txtAddr2_Validated);
            // 
            // txtSortCode
            // 
            this.txtSortCode.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSortCode.Location = new System.Drawing.Point(466, 77);
            this.txtSortCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtSortCode.Name = "txtSortCode";
            this.txtSortCode.ReadOnly = true;
            this.txtSortCode.Size = new System.Drawing.Size(118, 23);
            this.txtSortCode.TabIndex = 19;
            // 
            // txtAddr1
            // 
            this.txtAddr1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddr1.Location = new System.Drawing.Point(189, 243);
            this.txtAddr1.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddr1.Name = "txtAddr1";
            this.txtAddr1.Size = new System.Drawing.Size(395, 23);
            this.txtAddr1.TabIndex = 3;
            this.txtAddr1.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddr1_Validating);
            this.txtAddr1.Validated += new System.EventHandler(this.txtAddr1_Validated);
            // 
            // txtAccType
            // 
            this.txtAccType.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccType.Location = new System.Drawing.Point(204, 110);
            this.txtAccType.Margin = new System.Windows.Forms.Padding(4);
            this.txtAccType.Name = "txtAccType";
            this.txtAccType.ReadOnly = true;
            this.txtAccType.Size = new System.Drawing.Size(161, 23);
            this.txtAccType.TabIndex = 17;
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(189, 329);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(152, 23);
            this.txtCity.TabIndex = 5;
            this.txtCity.Validating += new System.ComponentModel.CancelEventHandler(this.txtCity_Validating);
            this.txtCity.Validated += new System.EventHandler(this.txtCity_Validated);
            // 
            // txtSn
            // 
            this.txtSn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSn.Location = new System.Drawing.Point(373, 154);
            this.txtSn.Margin = new System.Windows.Forms.Padding(4);
            this.txtSn.Name = "txtSn";
            this.txtSn.ReadOnly = true;
            this.txtSn.Size = new System.Drawing.Size(211, 23);
            this.txtSn.TabIndex = 15;
            // 
            // txtFn
            // 
            this.txtFn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFn.Location = new System.Drawing.Point(159, 154);
            this.txtFn.Margin = new System.Windows.Forms.Padding(4);
            this.txtFn.Name = "txtFn";
            this.txtFn.ReadOnly = true;
            this.txtFn.Size = new System.Drawing.Size(206, 23);
            this.txtFn.TabIndex = 14;
            // 
            // cboSelectAcc
            // 
            this.cboSelectAcc.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSelectAcc.FormattingEnabled = true;
            this.cboSelectAcc.Location = new System.Drawing.Point(204, 77);
            this.cboSelectAcc.Margin = new System.Windows.Forms.Padding(4);
            this.cboSelectAcc.Name = "cboSelectAcc";
            this.cboSelectAcc.Size = new System.Drawing.Size(161, 25);
            this.cboSelectAcc.TabIndex = 13;
            this.cboSelectAcc.Text = "Select an Account";
            this.cboSelectAcc.SelectedIndexChanged += new System.EventHandler(this.cboSelectAcc_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(32, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 10);
            this.panel1.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "Edit Account Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(70, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Account Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.Location = new System.Drawing.Point(382, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "Sort Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.Location = new System.Drawing.Point(70, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 30;
            this.label4.Text = "Account Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label5.Location = new System.Drawing.Point(382, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 31;
            this.label5.Text = "Balance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label6.Location = new System.Drawing.Point(70, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 19);
            this.label6.TabIndex = 32;
            this.label6.Text = "Full Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label7.Location = new System.Drawing.Point(70, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 19);
            this.label7.TabIndex = 33;
            this.label7.Text = "Phone Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label8.Location = new System.Drawing.Point(345, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 19);
            this.label8.TabIndex = 34;
            this.label8.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label9.Location = new System.Drawing.Point(70, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 19);
            this.label9.TabIndex = 35;
            this.label9.Text = "Address Line 1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label10.Location = new System.Drawing.Point(70, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 19);
            this.label10.TabIndex = 36;
            this.label10.Text = "Address Line 2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label11.Location = new System.Drawing.Point(70, 333);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 19);
            this.label11.TabIndex = 37;
            this.label11.Text = "City / Town";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label12.Location = new System.Drawing.Point(360, 333);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 19);
            this.label12.TabIndex = 38;
            this.label12.Text = "County";
            // 
            // epEA
            // 
            this.epEA.ContainerControl = this;
            // 
            // ucEditAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtCounty);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddr2);
            this.Controls.Add(this.txtSortCode);
            this.Controls.Add(this.txtAddr1);
            this.Controls.Add(this.txtAccType);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtSn);
            this.Controls.Add(this.txtFn);
            this.Controls.Add(this.cboSelectAcc);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucEditAccount";
            this.Size = new System.Drawing.Size(684, 437);
            this.Load += new System.EventHandler(this.ucEditAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epEA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddr2;
        private System.Windows.Forms.TextBox txtSortCode;
        private System.Windows.Forms.TextBox txtAddr1;
        private System.Windows.Forms.TextBox txtAccType;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtSn;
        private System.Windows.Forms.TextBox txtFn;
        private System.Windows.Forms.ComboBox cboSelectAcc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ErrorProvider epEA;
    }
}
