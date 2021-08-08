
namespace DBSBank
{
    partial class ucDepositFunds
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
            this.btnDeposit = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cboSelectAcc = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.epDepFunds = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblAccDetails = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.epDepFunds)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDeposit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeposit.Location = new System.Drawing.Point(545, 342);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(102, 34);
            this.btnDeposit.TabIndex = 4;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtAmount.Location = new System.Drawing.Point(192, 259);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(140, 24);
            this.txtAmount.TabIndex = 3;
            this.txtAmount.Validating += new System.ComponentModel.CancelEventHandler(this.txtAmount_Validating);
            this.txtAmount.Validated += new System.EventHandler(this.txtAmount_Validated);
            // 
            // cboSelectAcc
            // 
            this.cboSelectAcc.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cboSelectAcc.FormattingEnabled = true;
            this.cboSelectAcc.Location = new System.Drawing.Point(191, 86);
            this.cboSelectAcc.Name = "cboSelectAcc";
            this.cboSelectAcc.Size = new System.Drawing.Size(140, 25);
            this.cboSelectAcc.TabIndex = 1;
            this.cboSelectAcc.Text = "Select an Account";
            this.cboSelectAcc.SelectedIndexChanged += new System.EventHandler(this.cboSelectAcc_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(28, 42);
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
            this.label5.Location = new System.Drawing.Point(24, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 23);
            this.label5.TabIndex = 34;
            this.label5.Text = "Deposit Funds";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Account Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Account Number";
            // 
            // epDepFunds
            // 
            this.epDepFunds.ContainerControl = this;
            // 
            // lblAccDetails
            // 
            this.lblAccDetails.BackColor = System.Drawing.Color.PowderBlue;
            this.lblAccDetails.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccDetails.Location = new System.Drawing.Point(191, 131);
            this.lblAccDetails.Name = "lblAccDetails";
            this.lblAccDetails.Size = new System.Drawing.Size(414, 105);
            this.lblAccDetails.TabIndex = 36;
            // 
            // ucDepositFunds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            this.Controls.Add(this.lblAccDetails);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.cboSelectAcc);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucDepositFunds";
            this.Size = new System.Drawing.Size(684, 437);
            this.Load += new System.EventHandler(this.ucDepositFunds_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epDepFunds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cboSelectAcc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider epDepFunds;
        private System.Windows.Forms.Label lblAccDetails;
    }
}
