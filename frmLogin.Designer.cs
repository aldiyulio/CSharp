namespace T_UAS
{
    partial class frmLogin
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
            this.mtbCardNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.lblPIN = new System.Windows.Forms.Label();
            this.mtbPIN = new System.Windows.Forms.MaskedTextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mtbCardNumber
            // 
            this.mtbCardNumber.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCardNumber.Location = new System.Drawing.Point(134, 15);
            this.mtbCardNumber.Margin = new System.Windows.Forms.Padding(4);
            this.mtbCardNumber.Mask = "LLLL00000000";
            this.mtbCardNumber.Name = "mtbCardNumber";
            this.mtbCardNumber.PromptChar = '-';
            this.mtbCardNumber.Size = new System.Drawing.Size(121, 25);
            this.mtbCardNumber.TabIndex = 0;
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Location = new System.Drawing.Point(12, 18);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(120, 18);
            this.lblCardNumber.TabIndex = 1;
            this.lblCardNumber.Text = "Card Number  :";
            // 
            // lblPIN
            // 
            this.lblPIN.AutoSize = true;
            this.lblPIN.Location = new System.Drawing.Point(12, 50);
            this.lblPIN.Name = "lblPIN";
            this.lblPIN.Size = new System.Drawing.Size(120, 18);
            this.lblPIN.TabIndex = 2;
            this.lblPIN.Text = "PIN          :";
            // 
            // mtbPIN
            // 
            this.mtbPIN.Location = new System.Drawing.Point(134, 47);
            this.mtbPIN.Mask = "000000";
            this.mtbPIN.Name = "mtbPIN";
            this.mtbPIN.PromptChar = '-';
            this.mtbPIN.Size = new System.Drawing.Size(73, 25);
            this.mtbPIN.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(15, 86);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(117, 35);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(138, 86);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 35);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 129);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.mtbPIN);
            this.Controls.Add(this.lblPIN);
            this.Controls.Add(this.lblCardNumber);
            this.Controls.Add(this.mtbCardNumber);
            this.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbCardNumber;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.Label lblPIN;
        private System.Windows.Forms.MaskedTextBox mtbPIN;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
    }
}