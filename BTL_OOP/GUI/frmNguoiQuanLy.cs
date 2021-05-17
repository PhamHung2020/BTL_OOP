// LE TON NANG - 20194339
using System;
using System.Windows.Forms;

namespace OPP
{
    public partial class frmNguoiQuanLy : Form
    {
        public frmNguoiQuanLy()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToLongTimeString();
            label8.Text = DateTime.Now.ToLongDateString();
        }
    }
}
