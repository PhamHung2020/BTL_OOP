// LE TON NANG - 20194339
using System;
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
        public void Alert(string msg, frmThongBao.alertTypeEnum type)
        {
            frmThongBao f = new frmThongBao();
            f.setAlert(msg, type);
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
                if(rbGianHangCaoCap.Checked == true && txtSoBanGhe.Text != "" && txtSoQuatLamMat.Text != "" && tbDienTich.Text != "")
                {
                    string viTriGianHang = ((cbTang.SelectedIndex + 1) * 100 + (cbViTri.SelectedIndex + 1)).ToString();
                    string maGianHang = HelperBUS.GenerateMaGianHang<GianHangCaoCapDTO>(viTriGianHang);
                    gianHangCaoCap = new GianHangCaoCapDTO(maGianHang, Double.Parse(tbDienTich.Text), viTriGianHang, false, Int32.Parse(txtSoQuatLamMat.Text), Int32.Parse(txtSoBanGhe.Text));
                    if(GianHangBUS.Instance.ThemGianHang(gianHangCaoCap))
                    {
                        this.Alert("Thêm gian hàng thành công", frmThongBao.alertTypeEnum.Success);
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        this.Alert("Thêm thất bại", frmThongBao.alertTypeEnum.Error);
                    }


                }
                else if(rbGianHangTieuChuan.Checked == true && tbDienTich.Text != "" && txtChatLieuMaiChe.Text != "" && txtChatLieuVachNgan.Text != "")
                {
                    string viTriGianHang = ((cbTang.SelectedIndex + 1) * 100 + (cbViTri.SelectedIndex + 1)).ToString();
                    string maGianHang = HelperBUS.GenerateMaGianHang<GianHangTieuChuanDTO>(viTriGianHang);
                    gianHangTieuChuan = new GianHangTieuChuanDTO(maGianHang, Double.Parse(tbDienTich.Text), viTriGianHang, false, txtChatLieuVachNgan.Text, txtChatLieuMaiChe.Text);
                    if(GianHangBUS.Instance.ThemGianHang(gianHangTieuChuan))
                    {
                        this.Alert("Thêm gian hàng thành công", frmThongBao.alertTypeEnum.Success);
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        this.Alert("Thêm thất bại", frmThongBao.alertTypeEnum.Error);
                    }
                }
                else
                {
                    this.Alert("Chưa điền đủ thông tin", frmThongBao.alertTypeEnum.Warning);
                }    
            } catch(Exception erorr)
            {
                this.Alert(erorr.Message, frmThongBao.alertTypeEnum.Error);
            }
            
            
        }
    }
}
