using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace OPP
{
    public partial class Form1 : Form
    {
        private Panel left;
        private Button currentBtn;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private Form form1;
        private bool kt = true;
        public Form1()
        {
            InitializeComponent();
            left = new Panel();
            left.Size = new Size(11, 40);
            pnMenuVertical.Controls.Add(left);

        }
        private void ActiveButton(object senderBTN)
        {
            DisableButton();
            if(senderBTN != null)
            {
                currentBtn = (Button)senderBTN;
                currentBtn.BackColor = Color.FromArgb(45, 45, 48);
                currentBtn.ForeColor = Color.White;
                left.BackColor = Color.FromArgb(0, 0, 0);
                left.Location = new Point(0, currentBtn.Location.Y);
                left.Visible = true;
                
            }    
        }
        private void DisableButton()
        {
            if(currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(0, 122, 204);

            }    
        }
        // Resize nav
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnMenuVertical.Width == 250)
            {
                pnMenuVertical.Width = 70;
            }
            else
                pnMenuVertical.Width = 250;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(new frmTinNhan("Bạn có muốn thoát khỏi chương trình?").ShowDialog() == DialogResult.Yes)
            {
                Application.Exit();
            }    
        }

        

        private void btnMin_Click(object sender, EventArgs e)
        {
            form1 = pnContent.Controls[0] as Form;
            pnContent.Controls.Clear();
            this.WindowState = FormWindowState.Minimized;
            kt = false;
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMax.Visible = true;
            btnResize.Visible = false;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnResize.Visible = true;
            btnMax.Visible = false;
        }
        private void addFrm(object frmInfo)
        {
            if (this.pnContent.Controls.Count > 0)
                this.pnContent.Controls.RemoveAt(0);
            Form form = frmInfo as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.pnContent.Controls.Clear();
            this.pnContent.Controls.Add(form);
           
            form.Show();
        }
        private void btnStatistical_Click(object sender, EventArgs e)
        {
            addFrm(new frmQuanLyGianHang());
            ActiveButton(sender);
        }

        // Nắm vào vùng title di chuyển app
        private void pnTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            addFrm(new frmThueGianHang());
            ActiveButton(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addFrm(new frmThongKeDoanhThu());
            ActiveButton(sender);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            addFrm(new frmThongKeKhachHang());
            ActiveButton(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addFrm(new frmThongTinLienHe());
            ActiveButton(sender);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            addFrm(new frmNguoiQuanLy());
            DisableButton();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addFrm(new frmNguoiQuanLy());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            addFrm(new frmNguoiQuanLy());
            DisableButton();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            addFrm(new frmNguoiQuanLy());
            DisableButton();
        }

        private void btnMin_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void pnContent_SizeChanged(object sender, EventArgs e)
        {
            if(pnContent.Controls.Count == 0 && kt == false)
            {
                addFrm(form1);
                kt = true;
            }    
        }
    }
}
