namespace T_UAS
{
    partial class frmRegister
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
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblPIN = new System.Windows.Forms.Label();
            this.lblRePIN = new System.Windows.Forms.Label();
            this.mtbCard = new System.Windows.Forms.MaskedTextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.mtbPIN = new System.Windows.Forms.MaskedTextBox();
            this.mtbRePIN = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Location = new System.Drawing.Point(12, 14);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(184, 18);
            this.lblCardNumber.TabIndex = 0;
            this.lblCardNumber.Text = "Card Number          :";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(12, 45);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(184, 18);
            this.lblCustomer.TabIndex = 1;
            this.lblCustomer.Text = "Customer Name        :";
            // 
            // lblPIN
            // 
            this.lblPIN.AutoSize = true;
            this.lblPIN.Location = new System.Drawing.Point(12, 76);
            this.lblPIN.Name = "lblPIN";
            this.lblPIN.Size = new System.Drawing.Size(184, 18);
            this.lblPIN.TabIndex = 2;
            this.lblPIN.Text = "PIN Number (6-Digit) :";
            // 
            // lblRePIN
            // 
            this.lblRePIN.AutoSize = true;
            this.lblRePIN.Location = new System.Drawing.Point(12, 107);
            this.lblRePIN.Name = "lblRePIN";
            this.lblRePIN.Size = new System.Drawing.Size(184, 18);
            this.lblRePIN.TabIndex = 3;
            this.lblRePIN.Text = "Re-Confirm a PIN     :";
            // 
            // mtbCard
            // 
            this.mtbCard.Location = new System.Drawing.Point(202, 11);
            this.mtbCard.Mask = "LLLL00000000";
            this.mtbCard.Name = "mtbCard";
            this.mtbCard.PromptChar = '-';
            this.mtbCard.Size = new System.Drawing.Size(112, 25);
            this.mtbCard.TabIndex = 4;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(202, 42);
            this.txtCustomerName.MaxLength = 255;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(306, 25);
            this.txtCustomerName.TabIndex = 5;
            // 
            // mtbPIN
            // 
            this.mtbPIN.Location = new System.Drawing.Point(202, 73);
            this.mtbPIN.Mask = "000000";
            this.mtbPIN.Name = "mtbPIN";
            this.mtbPIN.PasswordChar = '*';
            this.mtbPIN.PromptChar = '-';
            this.mtbPIN.Size = new System.Drawing.Size(112, 25);
            this.mtbPIN.TabIndex = 6;
            // 
            // mtbRePIN
            // 
            this.mtbRePIN.Location = new System.Drawing.Point(202, 104);
            this.mtbRePIN.Mask = "000000";
            this.mtbRePIN.Name = "mtbRePIN";
            this.mtbRePIN.PasswordChar = '*';
            this.mtbRePIN.PromptChar = '-';
            this.mtbRePIN.Size = new System.Drawing.Size(112, 25);
            this.mtbRePIN.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 56);
            this.button1.TabIndex = 8;
            this.button1.Text = "REGISTER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(420, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 56);
            this.button2.TabIndex = 9;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 143);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mtbRePIN);
            this.Controls.Add(this.mtbPIN);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.mtbCard);
            this.Controls.Add(this.lblRePIN);
            this.Controls.Add(this.lblPIN);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lblCardNumber);
            this.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegister";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblPIN;
        private System.Windows.Forms.Label lblRePIN;
        private System.Windows.Forms.MaskedTextBox mtbCard;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.MaskedTextBox mtbPIN;
        private System.Windows.Forms.MaskedTextBox mtbRePIN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}