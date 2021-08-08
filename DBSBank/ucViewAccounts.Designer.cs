
namespace DBSBank
{
    partial class ucViewAccounts
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
            this.btnSerialise = new System.Windows.Forms.Button();
            this.dgvAccounts = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSerialise
            // 
            this.btnSerialise.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSerialise.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerialise.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSerialise.Location = new System.Drawing.Point(549, 370);
            this.btnSerialise.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSerialise.Name = "btnSerialise";
            this.btnSerialise.Size = new System.Drawing.Size(109, 39);
            this.btnSerialise.TabIndex = 3;
            this.btnSerialise.Text = "Export";
            this.btnSerialise.UseVisualStyleBackColor = false;
            this.btnSerialise.Click += new System.EventHandler(this.btnSerialise_Click);
            // 
            // dgvAccounts
            // 
            this.dgvAccounts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            this.dgvAccounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccounts.Location = new System.Drawing.Point(30, 103);
            this.dgvAccounts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.Size = new System.Drawing.Size(628, 240);
            this.dgvAccounts.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(30, 43);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(628, 10);
            this.panel2.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label5.Location = new System.Drawing.Point(26, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 23);
            this.label5.TabIndex = 30;
            this.label5.Text = "Accounts";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(185, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 28);
            this.label1.TabIndex = 32;
            this.label1.Text = "Select a row to Export an Account Details to XML.";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(38, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 28);
            this.label2.TabIndex = 33;
            this.label2.Text = "Detailed view of all registered DBS Accounts.";
            // 
            // ucViewAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSerialise);
            this.Controls.Add(this.dgvAccounts);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucViewAccounts";
            this.Size = new System.Drawing.Size(684, 437);
            this.Load += new System.EventHandler(this.ucViewAccounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSerialise;
        private System.Windows.Forms.DataGridView dgvAccounts;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
