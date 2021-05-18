// LE TON NANG - 20194339
using System;
using System.Drawing;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtPass.UseSystemPasswordChar = false;
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUserName_Click(object sender, EventArgs e)
        {
            txtUserName.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            txtPass.BackColor = SystemColors.Control;
        }

        private void txtPass_Click(object sender, EventArgs e)
        {
            txtPass.BackColor = Color.White;
            panel4.BackColor = Color.White;
            txtUserName.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            txtPass.BackColor = Color.White;
            panel4.BackColor = Color.White;
            txtUserName.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
            if(txtPass.Text == "Password")
            {
                txtPass.Text = "";
                txtPass.UseSystemPasswordChar = true;
            }    
        }
        public void Alert(string msg, frmThongBao.alertTypeEnum type)
        {
            frmThongBao f = new frmThongBao();
            f.setAlert(msg, type);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TaiKhoanBUS taiKhoanBUS = TaiKhoanBUS.Instance();
            if(taiKhoanBUS.Check(txtUserName.Text, txtPass.Text))
            {
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();

            }
            else
            {
                this.Alert("Thông tin đăng nhập chưa chính xác", frmThongBao.alertTypeEnum.Error);
                this.Show();
            }


        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if(txtUserName.Text == "User name")
            {
                txtUserName.Text = "";

            }    
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if(txtUserName.Text == "")
            {
                txtUserName.Text = "User name";
            }    
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if(txtPass.Text == "")
            {
                txtPass.Text = "Password";
                txtPass.UseSystemPasswordChar = false;
            }    
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }    
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }    
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtUserName;
        }
    }
}
