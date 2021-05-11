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
    public partial class frmThongTinKhachHang : Form
    {
        public frmThongTinKhachHang(string maGianHang)
        {
            InitializeComponent();
            tbMaGianHang.Text = maGianHang;
        }

        private void frmThongTinKhachHang_Load(object sender, EventArgs e)
        {
            dtpBatDau.Value = DateTime.Now;
            dtpKetThuc.Value = DateTime.Now;
        }
        public void Alert(string msg, frmThongBao.alertTypeEnum type)
        {
            frmThongBao f = new frmThongBao();
            f.setAlert(msg, type);
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(tbTenKhachHang.Text == "" || tbDiaChi.Text == "" || tbTienDatCoc.Text == "")
                {
                    if(dtpBatDau.Value > dtpKetThuc.Value)
                    {
                        this.Alert("Thông tin không hợp lệ!", frmThongBao.alertTypeEnum.Warning);
                    }
                    else
                    {

                        this.Alert("Bạn chưa điền đủ thông tin\nĐăng kí không thành công", frmThongBao.alertTypeEnum.Warning);
                    }
                }
                else
                {
                    if(dtpBatDau.Value > dtpKetThuc.Value)
                    {
                        this.Alert("Thông tin không hợp lệ!", frmThongBao.alertTypeEnum.Warning);
                    } else
                    {
                        string maKhachHang = HelperBUS.GenerateMaKhachHang(tbMaGianHang.Text, DateTime.Parse(dtpBatDau.Text));
                        DateTime time = DateTime.Parse(dtpBatDau.Text);
                        KhachHangDTO khachHang = new KhachHangDTO(maKhachHang, tbTenKhachHang.Text, tbDiaChi.Text, tbMaGianHang.Text, DateTime.Parse(dtpBatDau.Text), DateTime.Parse(dtpKetThuc.Text), Decimal.Parse(tbTienDatCoc.Text));
                        if(KhuTrungBayBUS.Instance.Thue(khachHang))
                        {

                            this.Alert("Thêm khách hàng thành công", frmThongBao.alertTypeEnum.Success);
                            DialogResult = DialogResult.Yes;
                            this.Close();
                        }
                        else
                        {
                            this.Alert("Thêm khách hàng thất bại", frmThongBao.alertTypeEnum.Error);
                        }
                    }    
                    
                }    

            } catch(Exception error)
            {
                this.Alert(error.Message, frmThongBao.alertTypeEnum.Error);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if(new frmTinNhan("Bạn có muốn thoát không?").ShowDialog() == DialogResult.Yes)
            {
                DialogResult = DialogResult.No;
                this.Close();
            }    
        }
    }
}
