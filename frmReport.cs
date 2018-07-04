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
    public partial class frmReport : Form
    {
        public void lstView()
        {
            listView1.View = View.Details;
            listView1.Columns.Add("Card No.");
            listView1.Columns.Add("Name");
            listView1.Columns.Add("Class");
            listView1.Columns.Add("Credit Bal.(pt)");
            listView1.Columns.Add("Cashback Bal.(pt)");
            listView1.Columns.Add("Total Trans.(pt)");
            listView1.Columns[0].Width = 160;
            listView1.Columns[1].Width = 130;
            listView1.Columns[2].Width = 100;
            listView1.Columns[3].Width = 150;
            listView1.Columns[4].Width = 170;
            listView1.Columns[5].Width = 170;
        }
        public frmReport()
        {
            InitializeComponent();
            lstView();
        }
    }
}
