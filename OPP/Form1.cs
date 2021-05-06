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
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public Form1()
        {
            InitializeComponent();
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
            Application.Exit();
        }

        

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
            this.pnContent.Controls.Add(form);
            form.Show();
        }
        private void btnStatistical_Click(object sender, EventArgs e)
        {
            addFrm(new frmQuanLyGianHang());
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addFrm(new frmThongKeDoanhThu());
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            addFrm(new frmThongKeKhachHang());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addFrm(new frmThongTinLienHe());
        }
    }
}
