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
    public partial class frmLogin : Form
    {
        frmUtama frmUtm;
        public frmLogin(frmUtama frmUtm)
        {
            InitializeComponent();
            
            
            // frmUtm.Controls["tslStatus"].Text = 
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
             frmUtm = new frmUtama();
            frmUtm.setTitle(mtbCardNumber.Text);
            
        }
    }
}
