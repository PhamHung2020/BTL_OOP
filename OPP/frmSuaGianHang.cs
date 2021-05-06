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
    public partial class frmSuaGianHang : Form
    {
        public frmSuaGianHang(bool LoaiGianHang, GianHangCaoCapDTO gianHangCaoCap, GianHangTieuChuanDTO gianHangTieuChuan)
        {
            InitializeComponent();
            if(LoaiGianHang == false) // Gian hàng cao cấp
            {
                lbChatLieuMaiChe.Visible = false;
                lbChatLieuVachNgan.Visible = false;
                txtChatLieuMaiChe.Visible = false;
                txtChatLieuVachNgan.Visible = false;
                txtDienTich.Text = gianHangCaoCap.DienTich.ToString();
                int tang = Int32.Parse(gianHangCaoCap.MaGianHang.Substring(2, 1));
                int vitri = Int32.Parse(gianHangCaoCap.MaGianHang.Substring(3, 2));
                cbTang.SelectedIndex = tang - 1;
                cbViTri.SelectedIndex = vitri - 1;
                rbGianHangCaoCap.Checked = true;
                rbGianHangTieuChuan.Checked = false;
                txtSoBanGhe.Text = gianHangCaoCap.SoBanGhe.ToString();
                txtSoQuatLamMat.Text = gianHangCaoCap.SoQuatLamMat.ToString();

            } else // Gian hàng tiêu chuẩn
            {
                lbSoBanGhe.Visible = false;
                lbSoQuatLamMat.Visible = false;
                txtSoBanGhe.Visible = false;
                txtSoQuatLamMat.Visible = false;
                txtDienTich.Text = gianHangTieuChuan.DienTich.ToString();
                int tang = Int32.Parse(gianHangTieuChuan.MaGianHang.Substring(2, 1));
                int vitri = Int32.Parse(gianHangTieuChuan.MaGianHang.Substring(3, 2));
                cbTang.SelectedIndex = tang - 1;
                cbViTri.SelectedIndex = vitri - 1;
                rbGianHangCaoCap.Checked = false;
                rbGianHangTieuChuan.Checked = true;
                txtChatLieuMaiChe.Text = gianHangTieuChuan.ChatLieuMaiChe;
                txtChatLieuVachNgan.Text = gianHangTieuChuan.ChatLieuVachNgan;
            }    
        }

        private void frmSuaGianHang_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if(new frmTinNhan("Bạn thực sự muốn thoát").ShowDialog() == DialogResult.Yes)
            {
                this.Close();
            }    
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(new frmTinNhan("Bạn muốn lưu lại thông tin gian hàng?").ShowDialog() == DialogResult.Yes)
                {
                    if(rbGianHangCaoCap.Checked == true)
                    {
                        string viTriGianHang = ((cbTang.SelectedIndex + 1) * 100 + (cbViTri.SelectedIndex + 1)).ToString();
                        string maGianHang = HelperBUS.GenerateMaGianHang<GianHangCaoCapDTO>(viTriGianHang);
                        GianHangCaoCapDTO gianHangCaoCap = new GianHangCaoCapDTO(maGianHang, Double.Parse(txtDienTich.Text), viTriGianHang, false, Int32.Parse(txtSoQuatLamMat.Text), Int32.Parse(txtSoBanGhe.Text));
                        if(GianHangBUS.Instance.CapNhatGianHang(gianHangCaoCap))
                        {
                            new frmThongBao("Cập nhật gian hàng thành công", 0).Show();
                            DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            new frmThongBao("Cập nhật thất bại", 1).Show();
                        }

                    } else if(rbGianHangTieuChuan.Checked == true)
                    {
                        string viTriGianHang = ((cbTang.SelectedIndex + 1) * 100 + (cbViTri.SelectedIndex + 1)).ToString();
                        string maGianHang = HelperBUS.GenerateMaGianHang<GianHangCaoCapDTO>(viTriGianHang);
                        GianHangTieuChuanDTO gianHangTieuChuan = new GianHangTieuChuanDTO(maGianHang, Double.Parse(txtDienTich.Text), viTriGianHang, false, txtChatLieuVachNgan.Text, txtChatLieuMaiChe.Text);
                        if(GianHangBUS.Instance.CapNhatGianHang(gianHangTieuChuan))
                        {
                            new frmThongBao("Cập nhật gian hàng thành công", 0).Show();
                            DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            new frmThongBao("Cập nhật thất bại", 1).Show();
                        }
                    }
                    else
                    {
                        new frmThongBao("Chưa điền đủ thông tin", 1).Show();
                    }
                }
            } catch(Exception error)
            {
                new frmThongBao(error.Message, 1).Show();
            }
            
        }
    }
}
