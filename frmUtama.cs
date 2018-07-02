using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_UAS
{
    public partial class frmUtama : Form
    {
        string user;
        public static string test;
        frmRegister freg;
        private void frmRegister()
        {
            freg = new frmRegister();
            freg.Show();
        }
        public void setTitle(string user)
        {
            tslStatus.Text = user;

        }
        private void frmLogin()
        {
            frmLogin flog = new frmLogin(this);
            flog.Show();
        }
        public frmUtama()
        {
            InitializeComponent();
            tsmStatusBalance.Enabled = false;
            tsmReport.Enabled = false;
            tsmLogout.Enabled = false;
            tsmTransaction.Enabled = false;
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmRegister_Click(object sender, EventArgs e)
        {
            frmRegister();
        }

        private void tsmLogin_Click(object sender, EventArgs e)
        {
            frmLogin();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmUtama_Load(object sender, EventArgs e)
        {

        }
    }
}
