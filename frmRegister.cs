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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (mtbPIN.Text != mtbRePIN.Text)
            {
                MessageBox.Show("PIN not Matched", "PIN ERROR");
            }
            else
                MessageBox.Show(string.Format("New Card Successfully Registered as \"{0}\"", txtCustomerName.Text), "Registration Succeed");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
