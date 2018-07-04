namespace T_UAS
{
    partial class frmUtama
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmStatusBalance = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmReport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTransaction = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTopup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTransfer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmShopping = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmCashback = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConvert = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmWithdraw = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 234);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 18, 0);
            this.statusStrip1.Size = new System.Drawing.Size(556, 23);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslStatus
            // 
            this.tslStatus.Name = "tslStatus";
            this.tslStatus.Size = new System.Drawing.Size(136, 18);
            this.tslStatus.Text = "Login as : Guest";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAccount,
            this.tsmTransaction,
            this.tsmExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(556, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmAccount
            // 
            this.tsmAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLogin,
            this.toolStripSeparator1,
            this.tsmRegister,
            this.toolStripMenuItem1,
            this.tsmStatusBalance,
            this.toolStripMenuItem2,
            this.tsmReport,
            this.toolStripMenuItem3,
            this.tsmLogout});
            this.tsmAccount.Name = "tsmAccount";
            this.tsmAccount.Size = new System.Drawing.Size(76, 22);
            this.tsmAccount.Text = "Account";
            // 
            // tsmLogin
            // 
            this.tsmLogin.Name = "tsmLogin";
            this.tsmLogin.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.tsmLogin.Size = new System.Drawing.Size(276, 22);
            this.tsmLogin.Text = "Login";
            this.tsmLogin.Click += new System.EventHandler(this.tsmLogin_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(273, 6);
            // 
            // tsmRegister
            // 
            this.tsmRegister.Name = "tsmRegister";
            this.tsmRegister.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.tsmRegister.Size = new System.Drawing.Size(276, 22);
            this.tsmRegister.Text = "Register";
            this.tsmRegister.Click += new System.EventHandler(this.tsmRegister_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(273, 6);
            // 
            // tsmStatusBalance
            // 
            this.tsmStatusBalance.Name = "tsmStatusBalance";
            this.tsmStatusBalance.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.tsmStatusBalance.Size = new System.Drawing.Size(276, 22);
            this.tsmStatusBalance.Text = "Status/Balance";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(273, 6);
            // 
            // tsmReport
            // 
            this.tsmReport.Name = "tsmReport";
            this.tsmReport.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.tsmReport.Size = new System.Drawing.Size(276, 22);
            this.tsmReport.Text = "Report (Admin Only)";
            this.tsmReport.Click += new System.EventHandler(this.tsmReport_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(273, 6);
            // 
            // tsmLogout
            // 
            this.tsmLogout.Name = "tsmLogout";
            this.tsmLogout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tsmLogout.Size = new System.Drawing.Size(276, 22);
            this.tsmLogout.Text = "Logout";
            // 
            // tsmTransaction
            // 
            this.tsmTransaction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmTopup,
            this.tsmTransfer,
            this.toolStripMenuItem4,
            this.tsmShopping,
            this.toolStripMenuItem5,
            this.tsmCashback});
            this.tsmTransaction.Name = "tsmTransaction";
            this.tsmTransaction.Size = new System.Drawing.Size(108, 22);
            this.tsmTransaction.Text = "Transaction";
            // 
            // tsmTopup
            // 
            this.tsmTopup.Name = "tsmTopup";
            this.tsmTopup.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.tsmTopup.Size = new System.Drawing.Size(196, 22);
            this.tsmTopup.Text = "Topup";
            // 
            // tsmTransfer
            // 
            this.tsmTransfer.Name = "tsmTransfer";
            this.tsmTransfer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.tsmTransfer.Size = new System.Drawing.Size(196, 22);
            this.tsmTransfer.Text = "Transfer";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(193, 6);
            // 
            // tsmShopping
            // 
            this.tsmShopping.Name = "tsmShopping";
            this.tsmShopping.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmShopping.Size = new System.Drawing.Size(196, 22);
            this.tsmShopping.Text = "Shopping";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(193, 6);
            // 
            // tsmCashback
            // 
            this.tsmCashback.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmConvert,
            this.tsmWithdraw});
            this.tsmCashback.Name = "tsmCashback";
            this.tsmCashback.Size = new System.Drawing.Size(196, 22);
            this.tsmCashback.Text = "Cashback";
            // 
            // tsmConvert
            // 
            this.tsmConvert.Name = "tsmConvert";
            this.tsmConvert.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsmConvert.Size = new System.Drawing.Size(196, 22);
            this.tsmConvert.Text = "Convert";
            // 
            // tsmWithdraw
            // 
            this.tsmWithdraw.Name = "tsmWithdraw";
            this.tsmWithdraw.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.tsmWithdraw.Size = new System.Drawing.Size(196, 22);
            this.tsmWithdraw.Text = "Withdraw";
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Size = new System.Drawing.Size(52, 22);
            this.tsmExit.Text = "Exit";
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // frmUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(556, 257);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmUtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NIM Genap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmAccount;
        private System.Windows.Forms.ToolStripMenuItem tsmLogin;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmRegister;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmStatusBalance;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmReport;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem tsmLogout;
        private System.Windows.Forms.ToolStripMenuItem tsmTransaction;
        private System.Windows.Forms.ToolStripMenuItem tsmTopup;
        private System.Windows.Forms.ToolStripMenuItem tsmTransfer;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem tsmShopping;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem tsmCashback;
        private System.Windows.Forms.ToolStripMenuItem tsmConvert;
        private System.Windows.Forms.ToolStripMenuItem tsmWithdraw;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
    }
}

