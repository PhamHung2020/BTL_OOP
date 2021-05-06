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
    
    public partial class frmQuanLyGianHang : Form
    {
        int count;
        GianHangBUS qlGianHang = GianHangBUS.Instance;
        List<GianHangCaoCapDTO> gianHangCaoCaps = new List<GianHangCaoCapDTO>();
        List<GianHangTieuChuanDTO> gianHangTieuChuans = new List<GianHangTieuChuanDTO>();
        public frmQuanLyGianHang()
        {
            InitializeComponent();
        }

        private void frmStatistical_Load(object sender, EventArgs e)
        {
            //List<GianHangCaoCapDTO> caoCapDTOs = new List<GianHangCaoCapDTO>();
            //caoCapDTOs.Add(new GianHangCaoCapDTO("TC101", 5.0, "Tầng 1-101", true, 10, 12));
            //caoCapDTOs.Add(new GianHangCaoCapDTO("TC102", 5.0, "Tầng 1-102", true, 10, 12));
            //List<GianHangTieuChuanDTO> tieuChuanDTOs = new List<GianHangTieuChuanDTO>();
            //tieuChuanDTOs.Add(new GianHangTieuChuanDTO("TC203", 10, "Tầng 2-203", false, "Bê tông", "Nhựa"));
            //dataGianHang.Rows.Add(tieuChuanDTOs.Count + caoCapDTOs.Count);
            //int count;
            //for(count = 0; count < tieuChuanDTOs.Count; count++)
            //{
            //    _AddGianHangTieuChuan(tieuChuanDTOs[count], count);

            //}
            //for(count = tieuChuanDTOs.Count; count < tieuChuanDTOs.Count + caoCapDTOs.Count; count++)
            //{
            //    _AddGianHangCaoCap(caoCapDTOs[count - tieuChuanDTOs.Count], count);

            //}
            //_ChangeColor();
            
            gianHangCaoCaps = qlGianHang.LayDanhSachGianHang<GianHangCaoCapDTO>();
            gianHangTieuChuans = qlGianHang.LayDanhSachGianHang<GianHangTieuChuanDTO>();
            dataGianHang.Rows.Add(gianHangCaoCaps.Count + gianHangTieuChuans.Count - 1);
            _AddListGianHangCaoCap(gianHangCaoCaps, 0);
            _AddListGianHangTieuChuan(gianHangTieuChuans, gianHangCaoCaps.Count);
            count = gianHangCaoCaps.Count + gianHangTieuChuans.Count;
            _ChangeColor();


        }
        private void CapNhap()
        {
            dataGianHang.Rows.Clear();
            gianHangCaoCaps = qlGianHang.LayDanhSachGianHang<GianHangCaoCapDTO>();
            gianHangTieuChuans = qlGianHang.LayDanhSachGianHang<GianHangTieuChuanDTO>();
            dataGianHang.Rows.Add(gianHangCaoCaps.Count + gianHangTieuChuans.Count - 1);
            _AddListGianHangCaoCap(gianHangCaoCaps, 0);
            _AddListGianHangTieuChuan(gianHangTieuChuans, gianHangCaoCaps.Count);
            count = gianHangCaoCaps.Count + gianHangTieuChuans.Count;
            _ChangeColor();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmThemGianHang frmThemGianHang = new frmThemGianHang();
            if(frmThemGianHang.ShowDialog() == DialogResult.OK)
            {
                dataGianHang.Rows.Clear();
                CapNhap();
            }    
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            
            bool LoaiGianHang = dataGianHang.SelectedRows[0].Cells[5].Value.ToString() == "NULL";
            GianHangCaoCapDTO gianHangCaoCap = qlGianHang.TimKiemTheoMaGianHang<GianHangCaoCapDTO>(dataGianHang.SelectedRows[0].Cells[0].Value.ToString())[0];
            GianHangTieuChuanDTO gianHangTieuChuan = qlGianHang.TimKiemTheoMaGianHang<GianHangTieuChuanDTO>(dataGianHang.SelectedRows[0].Cells[0].Value.ToString())[0];
            frmSuaGianHang frmSuaGianHang = new frmSuaGianHang(LoaiGianHang, gianHangCaoCap, gianHangTieuChuan);
            if(frmSuaGianHang.ShowDialog() == DialogResult.Yes)
            {
                dataGianHang.Rows.Clear();
                CapNhap();
            }    
        }

        private void dataGianHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void _AddGianHangTieuChuan(GianHangTieuChuanDTO gianHang, int count)
        {
            dataGianHang.Rows[count].Cells[0].Value = gianHang.MaGianHang;
            dataGianHang.Rows[count].Cells[1].Value = gianHang.DienTich;
            dataGianHang.Rows[count].Cells[2].Value = gianHang.ViTriGianHang;
            dataGianHang.Rows[count].Cells[3].Value = TinhTrangThue(gianHang);
            dataGianHang.Rows[count].Cells[4].Value = "NULL";
            dataGianHang.Rows[count].Cells[5].Value = "NULL";
            dataGianHang.Rows[count].Cells[6].Value = gianHang.ChatLieuVachNgan;
            dataGianHang.Rows[count].Cells[7].Value = gianHang.ChatLieuMaiChe;

        }
        private void _AddGianHangCaoCap(GianHangCaoCapDTO gianHang, int count)
        {
            
            dataGianHang.Rows[count].Cells[0].Value = gianHang.MaGianHang;
            dataGianHang.Rows[count].Cells[1].Value = gianHang.DienTich;
            dataGianHang.Rows[count].Cells[2].Value = gianHang.ViTriGianHang;
            dataGianHang.Rows[count].Cells[3].Value = TinhTrangThue(gianHang);
            dataGianHang.Rows[count].Cells[4].Value = gianHang.SoBanGhe;
            dataGianHang.Rows[count].Cells[5].Value = gianHang.SoQuatLamMat;
            dataGianHang.Rows[count].Cells[6].Value = "NULL";
            dataGianHang.Rows[count].Cells[7].Value = "NULL";
        }
        private string TinhTrangThue(GianHangDTO gianHang)
        {
            if(gianHang.TinhTrangThue == true)
            {
                return "Đã thuê";
            } else
            {
                return "Chưa thuê";
            }    
        }
        private void _AddListGianHangCaoCap(List<GianHangCaoCapDTO> gianHangCaos, int start)
        {
            for(int i = start; i < gianHangCaoCaps.Count + start; i++)
            {
                _AddGianHangCaoCap(gianHangCaoCaps[i - start], i);
            }
        }
        private void _AddListGianHangTieuChuan(List<GianHangTieuChuanDTO> gianTieuChuans, int start)
        {
            for(int i = start; i < gianTieuChuans.Count + start; i++)
            {
                _AddGianHangTieuChuan(gianTieuChuans[i - start], i);
            }
        }
        private void _ChangeColor()
        {
            foreach(DataGridViewRow row in dataGianHang.Rows)
            {
                
                if(Convert.ToString(row.Cells[3].Value) == "Đã thuê")
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(251, 161, 71);
                } else
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(59, 142, 202);
                }    
            }    
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if(txtTimKiem.Text == "")
            {
                new frmThongBao("Chưa nhập vào mã gian hàng", 2).Show();
            } else
            {
                string maGianHang = txtTimKiem.Text;
                if(maGianHang != "")
                {
                    if(cbLoaiGianHang.SelectedItem.ToString() == "Tất cả gian hàng")
                    {
                        List<GianHangDTO> gianHangs = qlGianHang.TimKiemTheoMaGianHang(maGianHang);
                        if(gianHangs.Count == 0)
                        {
                            new frmThongBao("Không có mã gian hàng bạn tìm kiếm", 2).Show();
                        } else
                        {
                            dataGianHang.Rows.Clear();
                            dataGianHang.Rows.Add(gianHangs.Count);
                            for(int i = 0; i < gianHangs.Count; i++)
                            {
                                if(gianHangs[i].MaGianHang.Substring(0,2) == "TC")
                                {
                                    string ma = gianHangs[i].MaGianHang;
                                    List<GianHangTieuChuanDTO> gianHangs1 = qlGianHang.TimKiemTheoMaGianHang<GianHangTieuChuanDTO>(ma);
                                    GianHangTieuChuanDTO gianHang = qlGianHang.TimKiemTheoMaGianHang<GianHangTieuChuanDTO>(ma)[0];
                                    _AddGianHangTieuChuan(gianHang, i);
                                } else if(gianHangs[i].MaGianHang.Substring(0,2) == "CC")
                                {
                                    string ma = gianHangs[i].MaGianHang;
                                    GianHangCaoCapDTO gianHang = qlGianHang.TimKiemTheoMaGianHang<GianHangCaoCapDTO>(ma)[0];
                                    _AddGianHangCaoCap(gianHang, i);
                                }    
                            }    
                        }    
                    }    
                }    
            }    
        }

        private void dataGianHang_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string LoaiGianHang = cbLoaiGianHang.SelectedItem.ToString();
            dataGianHang.Rows.Clear();
            if(LoaiGianHang == "Gian hàng cao cấp")
            {
                dataGianHang.Rows.Add(gianHangCaoCaps.Count);
                _AddListGianHangCaoCap(gianHangCaoCaps, 0);
                _ChangeColor();
            }
            else if(LoaiGianHang == "Gian hàng tiêu chuẩn")
            {
                dataGianHang.Rows.Add(gianHangTieuChuans.Count);
                _AddListGianHangTieuChuan(gianHangTieuChuans, 0);
                _ChangeColor();
            } else
            {
                CapNhap();
            }    
                

        }

        private void btnXoaGianHang_Click(object sender, EventArgs e)
        {
            try
            {
                string maGianHang = dataGianHang.SelectedRows[0].Cells[0].Value.ToString();
                
                if(new frmTinNhan("Bạn có chắc muốn xóa gian hàng có mã: " + maGianHang).ShowDialog() == DialogResult.Yes)
                {
                    if(qlGianHang.XoaGianHang(maGianHang))
                    {
                        new frmThongBao("Đã xóa thành công", 0).Show();
                        CapNhap();
                    } else
                    {
                        new frmThongBao("Xóa thất bại", 1).Show();
                    }    
                }    
            } catch(Exception erorr)
            {
                new frmThongBao(erorr.Message, 1).Show();
            }

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
