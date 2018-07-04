namespace T_UAS
{
    partial class frmStatusBalance
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
            this.lblCard = new System.Windows.Forms.Label();
            this.gboCustomerPin = new System.Windows.Forms.GroupBox();
            this.btnPIN = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.mtbReNewPin = new System.Windows.Forms.MaskedTextBox();
            this.mtbNewPin = new System.Windows.Forms.MaskedTextBox();
            this.mtbOldPin = new System.Windows.Forms.MaskedTextBox();
            this.lblReNewPin = new System.Windows.Forms.Label();
            this.lblNewPin = new System.Windows.Forms.Label();
            this.lblOldPin = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.gboCredit = new System.Windows.Forms.GroupBox();
            this.lblTotalPoint = new System.Windows.Forms.Label();
            this.lblCBPoint = new System.Windows.Forms.Label();
            this.lblBPoint = new System.Windows.Forms.Label();
            this.lblTotalAngka = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCashbackAngka = new System.Windows.Forms.Label();
            this.lblCashback = new System.Windows.Forms.Label();
            this.lblBalanceAngka = new System.Windows.Forms.Label();
            this.lblBal = new System.Windows.Forms.Label();
            this.gboClass = new System.Windows.Forms.GroupBox();
            this.lblNextPoint = new System.Windows.Forms.Label();
            this.lblNextClass = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblNextAngka = new System.Windows.Forms.Label();
            this.gboClassInformation = new System.Windows.Forms.GroupBox();
            this.lblMin100K = new System.Windows.Forms.Label();
            this.lblExecutive = new System.Windows.Forms.Label();
            this.lblMin50K = new System.Windows.Forms.Label();
            this.lblPremium = new System.Windows.Forms.Label();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.gboCustomerPin.SuspendLayout();
            this.gboCredit.SuspendLayout();
            this.gboClass.SuspendLayout();
            this.gboClassInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCard
            // 
            this.lblCard.AutoSize = true;
            this.lblCard.Location = new System.Drawing.Point(19, 16);
            this.lblCard.Name = "lblCard";
            this.lblCard.Size = new System.Drawing.Size(136, 18);
            this.lblCard.TabIndex = 0;
            this.lblCard.Text = "Card Number    :";
            // 
            // gboCustomerPin
            // 
            this.gboCustomerPin.Controls.Add(this.btnPIN);
            this.gboCustomerPin.Controls.Add(this.btnChange);
            this.gboCustomerPin.Controls.Add(this.mtbReNewPin);
            this.gboCustomerPin.Controls.Add(this.mtbNewPin);
            this.gboCustomerPin.Controls.Add(this.mtbOldPin);
            this.gboCustomerPin.Controls.Add(this.lblReNewPin);
            this.gboCustomerPin.Controls.Add(this.lblNewPin);
            this.gboCustomerPin.Controls.Add(this.lblOldPin);
            this.gboCustomerPin.Controls.Add(this.txtName);
            this.gboCustomerPin.Controls.Add(this.lblName);
            this.gboCustomerPin.Location = new System.Drawing.Point(22, 44);
            this.gboCustomerPin.Name = "gboCustomerPin";
            this.gboCustomerPin.Size = new System.Drawing.Size(409, 182);
            this.gboCustomerPin.TabIndex = 1;
            this.gboCustomerPin.TabStop = false;
            this.gboCustomerPin.Text = "Customer Name && PIN";
            // 
            // btnPIN
            // 
            this.btnPIN.Location = new System.Drawing.Point(250, 144);
            this.btnPIN.Name = "btnPIN";
            this.btnPIN.Size = new System.Drawing.Size(140, 25);
            this.btnPIN.TabIndex = 6;
            this.btnPIN.Text = "Change PIN";
            this.btnPIN.UseVisualStyleBackColor = true;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(250, 82);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(140, 25);
            this.btnChange.TabIndex = 6;
            this.btnChange.Text = "Change Name";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // mtbReNewPin
            // 
            this.mtbReNewPin.Location = new System.Drawing.Point(184, 144);
            this.mtbReNewPin.Mask = "000000";
            this.mtbReNewPin.Name = "mtbReNewPin";
            this.mtbReNewPin.PromptChar = '-';
            this.mtbReNewPin.Size = new System.Drawing.Size(60, 25);
            this.mtbReNewPin.TabIndex = 5;
            // 
            // mtbNewPin
            // 
            this.mtbNewPin.Location = new System.Drawing.Point(184, 113);
            this.mtbNewPin.Mask = "000000";
            this.mtbNewPin.Name = "mtbNewPin";
            this.mtbNewPin.PromptChar = '-';
            this.mtbNewPin.Size = new System.Drawing.Size(60, 25);
            this.mtbNewPin.TabIndex = 5;
            // 
            // mtbOldPin
            // 
            this.mtbOldPin.Location = new System.Drawing.Point(184, 82);
            this.mtbOldPin.Mask = "000000";
            this.mtbOldPin.Name = "mtbOldPin";
            this.mtbOldPin.PromptChar = '-';
            this.mtbOldPin.Size = new System.Drawing.Size(60, 25);
            this.mtbOldPin.TabIndex = 5;
            // 
            // lblReNewPin
            // 
            this.lblReNewPin.AutoSize = true;
            this.lblReNewPin.Location = new System.Drawing.Point(10, 147);
            this.lblReNewPin.Name = "lblReNewPin";
            this.lblReNewPin.Size = new System.Drawing.Size(168, 18);
            this.lblReNewPin.TabIndex = 4;
            this.lblReNewPin.Text = "Re-Confirm New PIN :";
            // 
            // lblNewPin
            // 
            this.lblNewPin.AutoSize = true;
            this.lblNewPin.Location = new System.Drawing.Point(10, 116);
            this.lblNewPin.Name = "lblNewPin";
            this.lblNewPin.Size = new System.Drawing.Size(168, 18);
            this.lblNewPin.TabIndex = 3;
            this.lblNewPin.Text = "New PIN (6-Digit)  :";
            // 
            // lblOldPin
            // 
            this.lblOldPin.AutoSize = true;
            this.lblOldPin.Location = new System.Drawing.Point(10, 85);
            this.lblOldPin.Name = "lblOldPin";
            this.lblOldPin.Size = new System.Drawing.Size(168, 18);
            this.lblOldPin.TabIndex = 2;
            this.lblOldPin.Text = "Old PIN            :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(13, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(377, 25);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(10, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 18);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name :";
            // 
            // gboCredit
            // 
            this.gboCredit.Controls.Add(this.lblTotalPoint);
            this.gboCredit.Controls.Add(this.lblCBPoint);
            this.gboCredit.Controls.Add(this.lblBPoint);
            this.gboCredit.Controls.Add(this.lblTotalAngka);
            this.gboCredit.Controls.Add(this.lblTotal);
            this.gboCredit.Controls.Add(this.lblCashbackAngka);
            this.gboCredit.Controls.Add(this.lblCashback);
            this.gboCredit.Controls.Add(this.lblBalanceAngka);
            this.gboCredit.Controls.Add(this.lblBal);
            this.gboCredit.Location = new System.Drawing.Point(22, 232);
            this.gboCredit.Name = "gboCredit";
            this.gboCredit.Size = new System.Drawing.Size(200, 175);
            this.gboCredit.TabIndex = 2;
            this.gboCredit.TabStop = false;
            this.gboCredit.Text = "Credit";
            // 
            // lblTotalPoint
            // 
            this.lblTotalPoint.AutoSize = true;
            this.lblTotalPoint.Location = new System.Drawing.Point(145, 143);
            this.lblTotalPoint.Name = "lblTotalPoint";
            this.lblTotalPoint.Size = new System.Drawing.Size(48, 18);
            this.lblTotalPoint.TabIndex = 2;
            this.lblTotalPoint.Text = "Point";
            // 
            // lblCBPoint
            // 
            this.lblCBPoint.AutoSize = true;
            this.lblCBPoint.Location = new System.Drawing.Point(145, 93);
            this.lblCBPoint.Name = "lblCBPoint";
            this.lblCBPoint.Size = new System.Drawing.Size(48, 18);
            this.lblCBPoint.TabIndex = 2;
            this.lblCBPoint.Text = "Point";
            // 
            // lblBPoint
            // 
            this.lblBPoint.AutoSize = true;
            this.lblBPoint.Location = new System.Drawing.Point(145, 45);
            this.lblBPoint.Name = "lblBPoint";
            this.lblBPoint.Size = new System.Drawing.Size(48, 18);
            this.lblBPoint.TabIndex = 2;
            this.lblBPoint.Text = "Point";
            // 
            // lblTotalAngka
            // 
            this.lblTotalAngka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalAngka.Location = new System.Drawing.Point(16, 139);
            this.lblTotalAngka.Name = "lblTotalAngka";
            this.lblTotalAngka.Size = new System.Drawing.Size(123, 27);
            this.lblTotalAngka.TabIndex = 1;
            this.lblTotalAngka.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(13, 121);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(144, 18);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total Purchased :";
            // 
            // lblCashbackAngka
            // 
            this.lblCashbackAngka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCashbackAngka.Location = new System.Drawing.Point(16, 89);
            this.lblCashbackAngka.Name = "lblCashbackAngka";
            this.lblCashbackAngka.Size = new System.Drawing.Size(123, 27);
            this.lblCashbackAngka.TabIndex = 1;
            this.lblCashbackAngka.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCashback
            // 
            this.lblCashback.AutoSize = true;
            this.lblCashback.Location = new System.Drawing.Point(13, 71);
            this.lblCashback.Name = "lblCashback";
            this.lblCashback.Size = new System.Drawing.Size(88, 18);
            this.lblCashback.TabIndex = 0;
            this.lblCashback.Text = "Cashback :";
            // 
            // lblBalanceAngka
            // 
            this.lblBalanceAngka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBalanceAngka.Location = new System.Drawing.Point(16, 41);
            this.lblBalanceAngka.Name = "lblBalanceAngka";
            this.lblBalanceAngka.Size = new System.Drawing.Size(123, 27);
            this.lblBalanceAngka.TabIndex = 1;
            this.lblBalanceAngka.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBal
            // 
            this.lblBal.AutoSize = true;
            this.lblBal.Location = new System.Drawing.Point(13, 23);
            this.lblBal.Name = "lblBal";
            this.lblBal.Size = new System.Drawing.Size(80, 18);
            this.lblBal.TabIndex = 0;
            this.lblBal.Text = "Balance :";
            // 
            // gboClass
            // 
            this.gboClass.Controls.Add(this.lblNextPoint);
            this.gboClass.Controls.Add(this.lblNextClass);
            this.gboClass.Controls.Add(this.lblClass);
            this.gboClass.Controls.Add(this.lblNextAngka);
            this.gboClass.Location = new System.Drawing.Point(231, 277);
            this.gboClass.Name = "gboClass";
            this.gboClass.Size = new System.Drawing.Size(200, 130);
            this.gboClass.TabIndex = 3;
            this.gboClass.TabStop = false;
            this.gboClass.Text = "Class";
            // 
            // lblNextPoint
            // 
            this.lblNextPoint.AutoSize = true;
            this.lblNextPoint.Location = new System.Drawing.Point(146, 98);
            this.lblNextPoint.Name = "lblNextPoint";
            this.lblNextPoint.Size = new System.Drawing.Size(48, 18);
            this.lblNextPoint.TabIndex = 2;
            this.lblNextPoint.Text = "Point";
            // 
            // lblNextClass
            // 
            this.lblNextClass.AutoSize = true;
            this.lblNextClass.Location = new System.Drawing.Point(6, 75);
            this.lblNextClass.Name = "lblNextClass";
            this.lblNextClass.Size = new System.Drawing.Size(184, 18);
            this.lblNextClass.TabIndex = 1;
            this.lblNextClass.Text = "Remain to Next Class :";
            // 
            // lblClass
            // 
            this.lblClass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClass.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(6, 21);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(188, 50);
            this.lblClass.TabIndex = 0;
            this.lblClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNextAngka
            // 
            this.lblNextAngka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNextAngka.Location = new System.Drawing.Point(6, 94);
            this.lblNextAngka.Name = "lblNextAngka";
            this.lblNextAngka.Size = new System.Drawing.Size(134, 27);
            this.lblNextAngka.TabIndex = 1;
            this.lblNextAngka.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gboClassInformation
            // 
            this.gboClassInformation.Controls.Add(this.lblMin100K);
            this.gboClassInformation.Controls.Add(this.lblExecutive);
            this.gboClassInformation.Controls.Add(this.lblMin50K);
            this.gboClassInformation.Controls.Add(this.lblPremium);
            this.gboClassInformation.Location = new System.Drawing.Point(22, 413);
            this.gboClassInformation.Name = "gboClassInformation";
            this.gboClassInformation.Size = new System.Drawing.Size(409, 109);
            this.gboClassInformation.TabIndex = 4;
            this.gboClassInformation.TabStop = false;
            this.gboClassInformation.Text = "Card Class Level Up Information";
            // 
            // lblMin100K
            // 
            this.lblMin100K.AutoSize = true;
            this.lblMin100K.Location = new System.Drawing.Point(53, 80);
            this.lblMin100K.Name = "lblMin100K";
            this.lblMin100K.Size = new System.Drawing.Size(304, 18);
            this.lblMin100K.TabIndex = 1;
            this.lblMin100K.Text = "Total Purchased minimum 100.000 point";
            // 
            // lblExecutive
            // 
            this.lblExecutive.AutoSize = true;
            this.lblExecutive.Location = new System.Drawing.Point(28, 62);
            this.lblExecutive.Name = "lblExecutive";
            this.lblExecutive.Size = new System.Drawing.Size(136, 18);
            this.lblExecutive.TabIndex = 0;
            this.lblExecutive.Text = "To \"EXECUTIVE\" :";
            // 
            // lblMin50K
            // 
            this.lblMin50K.AutoSize = true;
            this.lblMin50K.Location = new System.Drawing.Point(53, 39);
            this.lblMin50K.Name = "lblMin50K";
            this.lblMin50K.Size = new System.Drawing.Size(296, 18);
            this.lblMin50K.TabIndex = 1;
            this.lblMin50K.Text = "Total Purchased minimum 50.000 point";
            // 
            // lblPremium
            // 
            this.lblPremium.AutoSize = true;
            this.lblPremium.Location = new System.Drawing.Point(28, 21);
            this.lblPremium.Name = "lblPremium";
            this.lblPremium.Size = new System.Drawing.Size(120, 18);
            this.lblPremium.TabIndex = 0;
            this.lblPremium.Text = "To \"PREMIUM\" :";
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCardNumber.Location = new System.Drawing.Point(161, 9);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(170, 32);
            this.lblCardNumber.TabIndex = 5;
            this.lblCardNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmStatusBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 535);
            this.Controls.Add(this.lblCardNumber);
            this.Controls.Add(this.gboClassInformation);
            this.Controls.Add(this.gboClass);
            this.Controls.Add(this.gboCredit);
            this.Controls.Add(this.gboCustomerPin);
            this.Controls.Add(this.lblCard);
            this.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStatusBalance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Status/Balance";
            this.gboCustomerPin.ResumeLayout(false);
            this.gboCustomerPin.PerformLayout();
            this.gboCredit.ResumeLayout(false);
            this.gboCredit.PerformLayout();
            this.gboClass.ResumeLayout(false);
            this.gboClass.PerformLayout();
            this.gboClassInformation.ResumeLayout(false);
            this.gboClassInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCard;
        private System.Windows.Forms.GroupBox gboCustomerPin;
        private System.Windows.Forms.Button btnPIN;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.MaskedTextBox mtbReNewPin;
        private System.Windows.Forms.MaskedTextBox mtbNewPin;
        private System.Windows.Forms.MaskedTextBox mtbOldPin;
        private System.Windows.Forms.Label lblReNewPin;
        private System.Windows.Forms.Label lblNewPin;
        private System.Windows.Forms.Label lblOldPin;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gboCredit;
        private System.Windows.Forms.Label lblBalanceAngka;
        private System.Windows.Forms.Label lblBal;
        private System.Windows.Forms.Label lblTotalPoint;
        private System.Windows.Forms.Label lblCBPoint;
        private System.Windows.Forms.Label lblBPoint;
        private System.Windows.Forms.Label lblTotalAngka;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCashbackAngka;
        private System.Windows.Forms.Label lblCashback;
        private System.Windows.Forms.GroupBox gboClass;
        private System.Windows.Forms.Label lblNextPoint;
        private System.Windows.Forms.Label lblNextClass;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblNextAngka;
        private System.Windows.Forms.GroupBox gboClassInformation;
        private System.Windows.Forms.Label lblMin100K;
        private System.Windows.Forms.Label lblExecutive;
        private System.Windows.Forms.Label lblMin50K;
        private System.Windows.Forms.Label lblPremium;
        private System.Windows.Forms.Label lblCardNumber;
    }
}