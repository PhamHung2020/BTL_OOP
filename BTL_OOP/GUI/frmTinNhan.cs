// LE TON NANG - 20194339
using System;
using System.Windows.Forms;

namespace OPP
{
    public partial class frmTinNhan : Form
    {
        public frmTinNhan(string message)
        {
            InitializeComponent();
            bunifuLabel1.Text = message;
        }

        private void frmTinNhan_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
