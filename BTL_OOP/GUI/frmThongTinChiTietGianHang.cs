// LE TON NANG - 20194339
using System;
using System.Windows.Forms;
using DTO;

namespace GUI
{
    public partial class frmThongTinChiTietGianHang : Form
    {
        public frmThongTinChiTietGianHang(bool LoaiGianHang, GianHangCaoCapDTO gianHangCaoCap, GianHangTieuChuanDTO gianHangTieuChuan)
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

            }
            else // Gian hàng tiêu chuẩn
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

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
