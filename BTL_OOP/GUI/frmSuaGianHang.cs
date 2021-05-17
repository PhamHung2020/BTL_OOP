// LE TON NANG - 20194339
using System;
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
        public void Alert(string msg, frmThongBao.alertTypeEnum type)
        {
            frmThongBao f = new frmThongBao();
            f.setAlert(msg, type);
        }
        private void frmSuaGianHang_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if(new frmTinNhan("Bạn thực sự muốn thoát?").ShowDialog() == DialogResult.Yes)
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
                    if(rbGianHangCaoCap.Checked == true && txtSoBanGhe.Text != "" && txtSoQuatLamMat.Text != "" && txtDienTich.Text != "")
                    {
                        string viTriGianHang = ((cbTang.SelectedIndex + 1) * 100 + (cbViTri.SelectedIndex + 1)).ToString();
                        string maGianHang = HelperBUS.GenerateMaGianHang<GianHangCaoCapDTO>(viTriGianHang);
                        GianHangCaoCapDTO gianHangCaoCap = new GianHangCaoCapDTO(maGianHang, Double.Parse(txtDienTich.Text), viTriGianHang, false, Int32.Parse(txtSoQuatLamMat.Text), Int32.Parse(txtSoBanGhe.Text));
                        if(GianHangBUS.Instance.CapNhatGianHang(gianHangCaoCap))
                        {
                            this.Alert("Cập nhật gian hàng " + maGianHang +  " thành công", frmThongBao.alertTypeEnum.Success);
                            DialogResult = DialogResult.Yes;
                            this.Close();
                        }
                        else
                        {
                            this.Alert("Cập nhật thất bại", frmThongBao.alertTypeEnum.Error);
                        }

                    } else if(rbGianHangTieuChuan.Checked == true && txtChatLieuVachNgan.Text != "" && txtChatLieuMaiChe.Text != "" && txtDienTich.Text != "")
                    {
                        string viTriGianHang = ((cbTang.SelectedIndex + 1) * 100 + (cbViTri.SelectedIndex + 1)).ToString();
                        string maGianHang = HelperBUS.GenerateMaGianHang<GianHangTieuChuanDTO>(viTriGianHang);
                        GianHangTieuChuanDTO gianHangTieuChuan = new GianHangTieuChuanDTO(maGianHang, Double.Parse(txtDienTich.Text), viTriGianHang, false, txtChatLieuVachNgan.Text, txtChatLieuMaiChe.Text);
                        if(GianHangBUS.Instance.CapNhatGianHang(gianHangTieuChuan))
                        {
                            this.Alert("Cập nhật gian hàng thành công", frmThongBao.alertTypeEnum.Success);
                            DialogResult = DialogResult.Yes;
                            this.Close();
                        }
                        else
                        {
                            this.Alert("Cập nhật thất bại", frmThongBao.alertTypeEnum.Error);
                        }
                    }
                    else
                    {
                        this.Alert("Chưa điền đủ thông tin", frmThongBao.alertTypeEnum.Warning);
                    }
                }
            } catch(Exception error)
            {
                this.Alert(error.Message, frmThongBao.alertTypeEnum.Error);
            }
            
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
