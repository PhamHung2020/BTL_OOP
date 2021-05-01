using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPP
{
    public partial class frmThemGianHang : Form
    {
        public frmThemGianHang()
        {
            InitializeComponent();
        }

        private void frmThemGianHang_Load(object sender, EventArgs e)
        {
            lbChatLieuMaiChe.Hide();
            lbChatLieuVachNgan.Hide();
            txtChatLieuMaiChe.Hide();
            txtChatLieuVachNgan.Hide();
            lbSoBanGhe.Hide();
            lbSoQuatLamMat.Hide();
            txtSoBanGhe.Hide();
            txtSoQuatLamMat.Hide();
        }

        private void rbGianHangTieuChuan_CheckedChanged(object sender, EventArgs e)
        {
            if(rbGianHangTieuChuan.Checked == true)
            {
                rbGianHangCaoCap.Checked = false;
                lbChatLieuMaiChe.Visible = true;
                lbChatLieuVachNgan.Visible = true;
                txtChatLieuMaiChe.Visible = true;
                txtChatLieuVachNgan.Visible = true;
                lbSoBanGhe.Hide();
                lbSoQuatLamMat.Hide();
                txtSoBanGhe.Hide();
                txtSoQuatLamMat.Hide();
            }    
        }

        private void rbGianHangCaoCap_CheckedChanged(object sender, EventArgs e)
        {
            if(rbGianHangCaoCap.Checked == true)
            {
                rbGianHangTieuChuan.Checked = false;
                lbSoBanGhe.Visible = true;
                lbSoQuatLamMat.Visible = true;
                txtSoBanGhe.Visible = true;
                txtSoQuatLamMat.Visible = true;
                lbChatLieuMaiChe.Hide();
                lbChatLieuVachNgan.Hide();
                txtChatLieuMaiChe.Hide();
                txtChatLieuVachNgan.Hide();

            }    
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
