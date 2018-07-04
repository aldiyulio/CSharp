namespace T_UAS
{
    partial class frmTopup
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
            this.gboInformation = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCredit = new System.Windows.Forms.Label();
            this.lblTopup = new System.Windows.Forms.Label();
            this.lblPINVerification = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblCBPoint = new System.Windows.Forms.Label();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.lblAmount = new System.Windows.Forms.Label();
            this.mtbPIN = new System.Windows.Forms.MaskedTextBox();
            this.btnTopup = new System.Windows.Forms.Button();
            this.gboInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // gboInformation
            // 
            this.gboInformation.Controls.Add(this.label7);
            this.gboInformation.Controls.Add(this.label6);
            this.gboInformation.Controls.Add(this.label5);
            this.gboInformation.Controls.Add(this.label4);
            this.gboInformation.Controls.Add(this.label3);
            this.gboInformation.Controls.Add(this.label2);
            this.gboInformation.Controls.Add(this.label1);
            this.gboInformation.Location = new System.Drawing.Point(13, 13);
            this.gboInformation.Margin = new System.Windows.Forms.Padding(4);
            this.gboInformation.Name = "gboInformation";
            this.gboInformation.Padding = new System.Windows.Forms.Padding(4);
            this.gboInformation.Size = new System.Drawing.Size(439, 172);
            this.gboInformation.TabIndex = 0;
            this.gboInformation.TabStop = false;
            this.gboInformation.Text = "Topup Information";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "4. 1 Point = Rp. 1.000,-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(304, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Max. Rp. 10.000.000,-  : Cashback 10%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(296, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Max. Rp. 5.000.000,-   : Cashback 5%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(296, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Max. Rp. 2.500.000,-   : No Cashback";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "3. Maximum Topup Cashback :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "2. Maximum topup Rp. 10.000.000,-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Must be multiple of Rp. 10.000,-";
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.Location = new System.Drawing.Point(12, 198);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(120, 18);
            this.lblCredit.TabIndex = 1;
            this.lblCredit.Text = "Credit Balance";
            // 
            // lblTopup
            // 
            this.lblTopup.AutoSize = true;
            this.lblTopup.Location = new System.Drawing.Point(10, 237);
            this.lblTopup.Name = "lblTopup";
            this.lblTopup.Size = new System.Drawing.Size(104, 18);
            this.lblTopup.TabIndex = 2;
            this.lblTopup.Text = "Topup Amount";
            // 
            // lblPINVerification
            // 
            this.lblPINVerification.AutoSize = true;
            this.lblPINVerification.Location = new System.Drawing.Point(10, 274);
            this.lblPINVerification.Name = "lblPINVerification";
            this.lblPINVerification.Size = new System.Drawing.Size(136, 18);
            this.lblPINVerification.TabIndex = 3;
            this.lblPINVerification.Text = "PIN Verification";
            // 
            // lblBalance
            // 
            this.lblBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBalance.Location = new System.Drawing.Point(180, 191);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(166, 32);
            this.lblBalance.TabIndex = 4;
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCBPoint
            // 
            this.lblCBPoint.AutoSize = true;
            this.lblCBPoint.Location = new System.Drawing.Point(352, 198);
            this.lblCBPoint.Name = "lblCBPoint";
            this.lblCBPoint.Size = new System.Drawing.Size(48, 18);
            this.lblCBPoint.TabIndex = 5;
            this.lblCBPoint.Text = "Point";
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(180, 235);
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(131, 25);
            this.nudAmount.TabIndex = 6;
            this.nudAmount.ThousandsSeparator = true;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(321, 237);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(88, 18);
            this.lblAmount.TabIndex = 7;
            this.lblAmount.Text = "= 10 Point";
            // 
            // mtbPIN
            // 
            this.mtbPIN.Location = new System.Drawing.Point(180, 271);
            this.mtbPIN.Mask = "000000";
            this.mtbPIN.Name = "mtbPIN";
            this.mtbPIN.PromptChar = '-';
            this.mtbPIN.Size = new System.Drawing.Size(67, 25);
            this.mtbPIN.TabIndex = 8;
            // 
            // btnTopup
            // 
            this.btnTopup.Location = new System.Drawing.Point(270, 271);
            this.btnTopup.Name = "btnTopup";
            this.btnTopup.Size = new System.Drawing.Size(182, 25);
            this.btnTopup.TabIndex = 9;
            this.btnTopup.Text = "TOP-UP";
            this.btnTopup.UseVisualStyleBackColor = true;
            // 
            // frmTopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 312);
            this.Controls.Add(this.btnTopup);
            this.Controls.Add(this.mtbPIN);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(this.lblCBPoint);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblPINVerification);
            this.Controls.Add(this.lblTopup);
            this.Controls.Add(this.lblCredit);
            this.Controls.Add(this.gboInformation);
            this.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credit Topup";
            this.gboInformation.ResumeLayout(false);
            this.gboInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboInformation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.Label lblTopup;
        private System.Windows.Forms.Label lblPINVerification;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblCBPoint;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.MaskedTextBox mtbPIN;
        private System.Windows.Forms.Button btnTopup;
    }
}