
namespace DBSBank
{
    partial class ucNewAccount
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
            this.tabNewAcc = new System.Windows.Forms.TabControl();
            this.tbAcc = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNextAccInfo = new System.Windows.Forms.Button();
            this.rdoCurrent = new System.Windows.Forms.RadioButton();
            this.rdoSavings = new System.Windows.Forms.RadioButton();
            this.txtInitialBal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPersonal = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSurn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.btnPrevPersonal = new System.Windows.Forms.Button();
            this.btnNextPersonal = new System.Windows.Forms.Button();
            this.tbResAdd = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cboCounty = new System.Windows.Forms.ComboBox();
            this.btnPrevRes = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnNextRes = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.tbReview = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.btnPrevRev = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.epInitialDep = new System.Windows.Forms.ErrorProvider(this.components);
            this.epFn = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabNewAcc.SuspendLayout();
            this.tbAcc.SuspendLayout();
            this.tbPersonal.SuspendLayout();
            this.tbResAdd.SuspendLayout();
            this.tbReview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epInitialDep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFn)).BeginInit();
            this.SuspendLayout();
            // 
            // tabNewAcc
            // 
            this.tabNewAcc.Controls.Add(this.tbAcc);
            this.tabNewAcc.Controls.Add(this.tbPersonal);
            this.tabNewAcc.Controls.Add(this.tbResAdd);
            this.tabNewAcc.Controls.Add(this.tbReview);
            this.tabNewAcc.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.tabNewAcc.Location = new System.Drawing.Point(57, 58);
            this.tabNewAcc.Name = "tabNewAcc";
            this.tabNewAcc.SelectedIndex = 0;
            this.tabNewAcc.Size = new System.Drawing.Size(571, 325);
            this.tabNewAcc.TabIndex = 1;
            // 
            // tbAcc
            // 
            this.tbAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            this.tbAcc.Controls.Add(this.label5);
            this.tbAcc.Controls.Add(this.label4);
            this.tbAcc.Controls.Add(this.label3);
            this.tbAcc.Controls.Add(this.label2);
            this.tbAcc.Controls.Add(this.panel1);
            this.tbAcc.Controls.Add(this.btnNextAccInfo);
            this.tbAcc.Controls.Add(this.rdoCurrent);
            this.tbAcc.Controls.Add(this.rdoSavings);
            this.tbAcc.Controls.Add(this.txtInitialBal);
            this.tbAcc.Controls.Add(this.label1);
            this.tbAcc.Location = new System.Drawing.Point(4, 25);
            this.tbAcc.Name = "tbAcc";
            this.tbAcc.Padding = new System.Windows.Forms.Padding(3);
            this.tbAcc.Size = new System.Drawing.Size(563, 296);
            this.tbAcc.TabIndex = 0;
            this.tbAcc.Text = "Account Information";
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(230, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 42);
            this.label5.TabIndex = 14;
            this.label5.Text = "Current Account Overdraft: €100. \r\nTransfer between DBS and external bank account" +
    "s.  ";
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(230, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 42);
            this.label4.TabIndex = 13;
            this.label4.Text = "Savings Account does not support Overdraft. Transfer only to another DBS account." +
    "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Initial Deposit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Account Type";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(17, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 10);
            this.panel1.TabIndex = 10;
            // 
            // btnNextAccInfo
            // 
            this.btnNextAccInfo.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnNextAccInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextAccInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextAccInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNextAccInfo.Location = new System.Drawing.Point(460, 241);
            this.btnNextAccInfo.Name = "btnNextAccInfo";
            this.btnNextAccInfo.Size = new System.Drawing.Size(86, 34);
            this.btnNextAccInfo.TabIndex = 9;
            this.btnNextAccInfo.Text = ">";
            this.btnNextAccInfo.UseVisualStyleBackColor = false;
            this.btnNextAccInfo.Click += new System.EventHandler(this.btnNextAccInfo_Click);
            // 
            // rdoCurrent
            // 
            this.rdoCurrent.AutoSize = true;
            this.rdoCurrent.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCurrent.Location = new System.Drawing.Point(150, 124);
            this.rdoCurrent.Name = "rdoCurrent";
            this.rdoCurrent.Size = new System.Drawing.Size(74, 21);
            this.rdoCurrent.TabIndex = 2;
            this.rdoCurrent.Text = "Current";
            this.rdoCurrent.UseVisualStyleBackColor = true;
            // 
            // rdoSavings
            // 
            this.rdoSavings.AutoSize = true;
            this.rdoSavings.Checked = true;
            this.rdoSavings.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSavings.Location = new System.Drawing.Point(150, 71);
            this.rdoSavings.Name = "rdoSavings";
            this.rdoSavings.Size = new System.Drawing.Size(74, 21);
            this.rdoSavings.TabIndex = 1;
            this.rdoSavings.TabStop = true;
            this.rdoSavings.Text = "Savings";
            this.rdoSavings.UseVisualStyleBackColor = true;
            // 
            // txtInitialBal
            // 
            this.txtInitialBal.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtInitialBal.Location = new System.Drawing.Point(132, 183);
            this.txtInitialBal.Name = "txtInitialBal";
            this.txtInitialBal.Size = new System.Drawing.Size(126, 24);
            this.txtInitialBal.TabIndex = 3;
            this.txtInitialBal.Validating += new System.ComponentModel.CancelEventHandler(this.txtInitialBal_Validating);
            this.txtInitialBal.Validated += new System.EventHandler(this.txtInitialBal_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account Information";
            // 
            // tbPersonal
            // 
            this.tbPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            this.tbPersonal.Controls.Add(this.label10);
            this.tbPersonal.Controls.Add(this.label9);
            this.tbPersonal.Controls.Add(this.label6);
            this.tbPersonal.Controls.Add(this.txtEmail);
            this.tbPersonal.Controls.Add(this.label7);
            this.tbPersonal.Controls.Add(this.txtPhone);
            this.tbPersonal.Controls.Add(this.panel2);
            this.tbPersonal.Controls.Add(this.txtSurn);
            this.tbPersonal.Controls.Add(this.label8);
            this.tbPersonal.Controls.Add(this.txtFName);
            this.tbPersonal.Controls.Add(this.btnPrevPersonal);
            this.tbPersonal.Controls.Add(this.btnNextPersonal);
            this.tbPersonal.Location = new System.Drawing.Point(4, 25);
            this.tbPersonal.Name = "tbPersonal";
            this.tbPersonal.Padding = new System.Windows.Forms.Padding(3);
            this.tbPersonal.Size = new System.Drawing.Size(563, 296);
            this.tbPersonal.TabIndex = 1;
            this.tbPersonal.Text = "Personal Details";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(42, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Email Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(42, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Surname";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Phone Number";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtEmail.Location = new System.Drawing.Point(180, 184);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(212, 24);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            this.txtEmail.Validated += new System.EventHandler(this.txtEmail_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "First Name";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtPhone.Location = new System.Drawing.Point(180, 149);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(212, 24);
            this.txtPhone.TabIndex = 3;
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhone_Validating);
            this.txtPhone.Validated += new System.EventHandler(this.txtPhone_Validated);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(17, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(528, 10);
            this.panel2.TabIndex = 14;
            // 
            // txtSurn
            // 
            this.txtSurn.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtSurn.Location = new System.Drawing.Point(150, 106);
            this.txtSurn.Name = "txtSurn";
            this.txtSurn.Size = new System.Drawing.Size(242, 24);
            this.txtSurn.TabIndex = 2;
            this.txtSurn.Validating += new System.ComponentModel.CancelEventHandler(this.txtSurn_Validating);
            this.txtSurn.Validated += new System.EventHandler(this.txtSurn_Validated);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label8.Location = new System.Drawing.Point(13, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "Personal Details";
            // 
            // txtFName
            // 
            this.txtFName.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtFName.Location = new System.Drawing.Point(150, 73);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(242, 24);
            this.txtFName.TabIndex = 1;
            this.txtFName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFName_Validating);
            this.txtFName.Validated += new System.EventHandler(this.txtFName_Validated);
            // 
            // btnPrevPersonal
            // 
            this.btnPrevPersonal.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPrevPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevPersonal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevPersonal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrevPersonal.Location = new System.Drawing.Point(358, 241);
            this.btnPrevPersonal.Name = "btnPrevPersonal";
            this.btnPrevPersonal.Size = new System.Drawing.Size(86, 34);
            this.btnPrevPersonal.TabIndex = 13;
            this.btnPrevPersonal.Text = "<";
            this.btnPrevPersonal.UseVisualStyleBackColor = false;
            this.btnPrevPersonal.Click += new System.EventHandler(this.btnPrevPersonal_Click);
            // 
            // btnNextPersonal
            // 
            this.btnNextPersonal.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnNextPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPersonal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextPersonal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNextPersonal.Location = new System.Drawing.Point(460, 241);
            this.btnNextPersonal.Name = "btnNextPersonal";
            this.btnNextPersonal.Size = new System.Drawing.Size(86, 34);
            this.btnNextPersonal.TabIndex = 12;
            this.btnNextPersonal.Text = ">";
            this.btnNextPersonal.UseVisualStyleBackColor = false;
            this.btnNextPersonal.Click += new System.EventHandler(this.btnNextPersonal_Click);
            // 
            // tbResAdd
            // 
            this.tbResAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            this.tbResAdd.Controls.Add(this.label16);
            this.tbResAdd.Controls.Add(this.label11);
            this.tbResAdd.Controls.Add(this.cboCounty);
            this.tbResAdd.Controls.Add(this.btnPrevRes);
            this.tbResAdd.Controls.Add(this.label13);
            this.tbResAdd.Controls.Add(this.txtCity);
            this.tbResAdd.Controls.Add(this.label14);
            this.tbResAdd.Controls.Add(this.btnNextRes);
            this.tbResAdd.Controls.Add(this.panel3);
            this.tbResAdd.Controls.Add(this.txtAddress2);
            this.tbResAdd.Controls.Add(this.label15);
            this.tbResAdd.Controls.Add(this.txtAddress1);
            this.tbResAdd.Location = new System.Drawing.Point(4, 25);
            this.tbResAdd.Name = "tbResAdd";
            this.tbResAdd.Size = new System.Drawing.Size(563, 296);
            this.tbResAdd.TabIndex = 2;
            this.tbResAdd.Text = "Residential Address";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(41, 110);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(116, 20);
            this.label16.TabIndex = 25;
            this.label16.Text = "Address Line 2 ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(41, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "County";
            // 
            // cboCounty
            // 
            this.cboCounty.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cboCounty.FormattingEnabled = true;
            this.cboCounty.Location = new System.Drawing.Point(159, 184);
            this.cboCounty.Name = "cboCounty";
            this.cboCounty.Size = new System.Drawing.Size(246, 25);
            this.cboCounty.TabIndex = 4;
            // 
            // btnPrevRes
            // 
            this.btnPrevRes.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPrevRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevRes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrevRes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrevRes.Location = new System.Drawing.Point(358, 241);
            this.btnPrevRes.Name = "btnPrevRes";
            this.btnPrevRes.Size = new System.Drawing.Size(86, 34);
            this.btnPrevRes.TabIndex = 15;
            this.btnPrevRes.Text = "<";
            this.btnPrevRes.UseVisualStyleBackColor = false;
            this.btnPrevRes.Click += new System.EventHandler(this.btnPrevRes_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(41, 149);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 20);
            this.label13.TabIndex = 22;
            this.label13.Text = "City / Town";
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtCity.Location = new System.Drawing.Point(159, 149);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(246, 24);
            this.txtCity.TabIndex = 3;
            this.txtCity.Validating += new System.ComponentModel.CancelEventHandler(this.txtCity_Validating);
            this.txtCity.Validated += new System.EventHandler(this.txtCity_Validated);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(41, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 20);
            this.label14.TabIndex = 21;
            this.label14.Text = "Address Line 1";
            // 
            // btnNextRes
            // 
            this.btnNextRes.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnNextRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextRes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnNextRes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNextRes.Location = new System.Drawing.Point(460, 241);
            this.btnNextRes.Name = "btnNextRes";
            this.btnNextRes.Size = new System.Drawing.Size(86, 34);
            this.btnNextRes.TabIndex = 14;
            this.btnNextRes.Text = ">";
            this.btnNextRes.UseVisualStyleBackColor = false;
            this.btnNextRes.Click += new System.EventHandler(this.btnNextRes_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Location = new System.Drawing.Point(16, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(528, 10);
            this.panel3.TabIndex = 20;
            // 
            // txtAddress2
            // 
            this.txtAddress2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtAddress2.Location = new System.Drawing.Point(159, 110);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(246, 24);
            this.txtAddress2.TabIndex = 2;
            this.txtAddress2.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddress2_Validating);
            this.txtAddress2.Validated += new System.EventHandler(this.txtAddress2_Validated);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label15.Location = new System.Drawing.Point(12, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(190, 23);
            this.label15.TabIndex = 19;
            this.label15.Text = "Residential Address";
            // 
            // txtAddress1
            // 
            this.txtAddress1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtAddress1.Location = new System.Drawing.Point(159, 73);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(246, 24);
            this.txtAddress1.TabIndex = 1;
            this.txtAddress1.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddress1_Validating);
            this.txtAddress1.Validated += new System.EventHandler(this.txtAddress1_Validated);
            // 
            // tbReview
            // 
            this.tbReview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            this.tbReview.Controls.Add(this.label18);
            this.tbReview.Controls.Add(this.lblInfo);
            this.tbReview.Controls.Add(this.panel4);
            this.tbReview.Controls.Add(this.label12);
            this.tbReview.Controls.Add(this.btnPrevRev);
            this.tbReview.Controls.Add(this.btnSubmit);
            this.tbReview.Location = new System.Drawing.Point(4, 25);
            this.tbReview.Name = "tbReview";
            this.tbReview.Size = new System.Drawing.Size(563, 296);
            this.tbReview.TabIndex = 3;
            this.tbReview.Text = "Review";
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(13, 184);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(528, 34);
            this.label18.TabIndex = 21;
            this.label18.Text = "By submitting this form, I acknowledge that the information I have given in this " +
    "form is accurate and I agree all the terms and conditions.";
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.PowderBlue;
            this.lblInfo.Location = new System.Drawing.Point(13, 62);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(531, 120);
            this.lblInfo.TabIndex = 20;
            this.lblInfo.Text = "Account Information: ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Location = new System.Drawing.Point(16, 41);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(528, 10);
            this.panel4.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label12.Location = new System.Drawing.Point(12, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(283, 23);
            this.label12.TabIndex = 15;
            this.label12.Text = "Review and Accept the Terms";
            // 
            // btnPrevRev
            // 
            this.btnPrevRev.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPrevRev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevRev.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevRev.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrevRev.Location = new System.Drawing.Point(358, 241);
            this.btnPrevRev.Name = "btnPrevRev";
            this.btnPrevRev.Size = new System.Drawing.Size(86, 34);
            this.btnPrevRev.TabIndex = 17;
            this.btnPrevRev.Text = "<";
            this.btnPrevRev.UseVisualStyleBackColor = false;
            this.btnPrevRev.Click += new System.EventHandler(this.btnPrevRev_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.Location = new System.Drawing.Point(460, 241);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(86, 34);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // epInitialDep
            // 
            this.epInitialDep.ContainerControl = this;
            // 
            // epFn
            // 
            this.epFn.ContainerControl = this;
            // 
            // ucNewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Controls.Add(this.tabNewAcc);
            this.Name = "ucNewAccount";
            this.Size = new System.Drawing.Size(684, 437);
            this.Load += new System.EventHandler(this.UCNewAccount_Load);
            this.tabNewAcc.ResumeLayout(false);
            this.tbAcc.ResumeLayout(false);
            this.tbAcc.PerformLayout();
            this.tbPersonal.ResumeLayout(false);
            this.tbPersonal.PerformLayout();
            this.tbResAdd.ResumeLayout(false);
            this.tbResAdd.PerformLayout();
            this.tbReview.ResumeLayout(false);
            this.tbReview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epInitialDep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabNewAcc;
        private System.Windows.Forms.TabPage tbAcc;
        private System.Windows.Forms.Button btnNextAccInfo;
        private System.Windows.Forms.RadioButton rdoCurrent;
        private System.Windows.Forms.RadioButton rdoSavings;
        private System.Windows.Forms.TextBox txtInitialBal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbPersonal;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtSurn;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Button btnPrevPersonal;
        private System.Windows.Forms.Button btnNextPersonal;
        private System.Windows.Forms.TabPage tbResAdd;
        private System.Windows.Forms.ComboBox cboCounty;
        private System.Windows.Forms.Button btnPrevRes;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Button btnNextRes;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.TabPage tbReview;
        private System.Windows.Forms.Button btnPrevRev;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ErrorProvider epInitialDep;
        private System.Windows.Forms.ErrorProvider epFn;
    }
}
