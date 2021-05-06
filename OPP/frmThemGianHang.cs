using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace OPP
{
    public partial class frmThemGianHang : Form
    {
        public GianHangCaoCapDTO gianHangCaoCap;
        public GianHangTieuChuanDTO gianHangTieuChuan;
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if(rbGianHangCaoCap.Checked == true)
                {
                    string viTriGianHang = ((cbTang.SelectedIndex + 1) * 100 + (cbViTri.SelectedIndex + 1)).ToString();
                    string maGianHang = HelperBUS.GenerateMaGianHang<GianHangCaoCapDTO>(viTriGianHang);
                    gianHangCaoCap = new GianHangCaoCapDTO(maGianHang, Double.Parse(tbDienTich.Text), viTriGianHang, false, Int32.Parse(txtSoQuatLamMat.Text), Int32.Parse(txtSoBanGhe.Text));
                    if(GianHangBUS.Instance.ThemGianHang(gianHangCaoCap))
                    {
                        new frmThongBao("Thêm gian hàng thành công", 0).Show();
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        new frmThongBao("Thêm thất bại", 1).Show();
                    }


                }
                else if(rbGianHangTieuChuan.Checked == true)
                {
                    string viTriGianHang = ((cbTang.SelectedIndex + 1) * 100 + (cbViTri.SelectedIndex + 1)).ToString();
                    string maGianHang = HelperBUS.GenerateMaGianHang<GianHangTieuChuanDTO>(viTriGianHang);
                    gianHangTieuChuan = new GianHangTieuChuanDTO(maGianHang, Double.Parse(tbDienTich.Text), viTriGianHang, false, txtChatLieuVachNgan.Text, txtChatLieuMaiChe.Text);
                    if(GianHangBUS.Instance.ThemGianHang(gianHangTieuChuan))
                    {
                        new frmThongBao("Thêm gian hàng thành công", 0).Show();
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        new frmThongBao("Thêm thất bại", 1).Show();
                    }
                }
                else
                {
                    new frmThongBao("Chưa điền đủ thông tin", 1).Show();
                }    
            } catch(Exception erorr)
            {
                new frmThongBao(erorr.Message, 1).Show();
            }
            
            
        }
    }
}
