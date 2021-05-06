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

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(tbTenKhachHang.Text == "" || tbDiaChi.Text == "")
                {
                    new frmThongBao("Bạn chưa điền đủ thông tin\nĐăng kí không thành công", 1).Show();
                } else
                {
                    string maKhachHang = HelperBUS.GenerateMaKhachHang(tbMaGianHang.Text, DateTime.Parse(dtpBatDau.Text));
                    DateTime time = DateTime.Parse(dtpBatDau.Text);
                    KhachHangDTO khachHang = new KhachHangDTO(maKhachHang, tbTenKhachHang.Text, tbDiaChi.Text, tbMaGianHang.Text, DateTime.Parse(dtpBatDau.Text), DateTime.Parse(dtpKetThuc.Text), Decimal.Parse(tbTienDatCoc.Text));
                    if(KhuTrungBayBUS.Instance.Thue(khachHang))
                    {
                        GianHangBUS.Instance.ThayDoiTinhTrangThue(khachHang.MaGianHang, true);
                        new frmThongBao("Thêm khách hàng thành công", 0).Show();
                        DialogResult = DialogResult.Yes;
                        this.Close();
                    }
                    else
                    {
                        new frmThongBao("Thêm khách hàng thất bại", 1).Show();
                    }    
                }    

            } catch(Exception error)
            {
                new frmThongBao(error.Message, 1).Show();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if(new frmTinNhan("Bạn có muổn thoát?").ShowDialog() == DialogResult.Yes)
            {
                DialogResult = DialogResult.No;
                this.Close();
            }    
        }
    }
}
