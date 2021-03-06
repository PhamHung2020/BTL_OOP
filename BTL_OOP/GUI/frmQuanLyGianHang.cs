// LE TON NANG - 20194339
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    
    public partial class frmQuanLyGianHang : Form
    {
        int count;
        GianHangBUS qlGianHang = GianHangBUS.Instance;
        static List<GianHangCaoCapDTO> gianHangCaoCaps = new List<GianHangCaoCapDTO>();
        static List<GianHangTieuChuanDTO> gianHangTieuChuans = new List<GianHangTieuChuanDTO>();
        public frmQuanLyGianHang()
        {
            InitializeComponent();
        }

        private void frmStatistical_Load(object sender, EventArgs e)
        { 
            CapNhap();
            dataGianHang.Visible = true;
            dataGianHangCC.Visible = false;
            dataGianHangTC.Visible = false;


        }
        public void Alert(string msg, frmThongBao.alertTypeEnum type)
        {
            frmThongBao f = new frmThongBao();
            f.setAlert(msg, type);
        }
        private void CapNhap()
        {
            gianHangCaoCaps = qlGianHang.LayDanhSachGianHang<GianHangCaoCapDTO>();
            gianHangTieuChuans = qlGianHang.LayDanhSachGianHang<GianHangTieuChuanDTO>();
            dataGianHang.Rows.Clear();
            dataGianHangTC.Rows.Clear();
            dataGianHangCC.Rows.Clear();
            _AddListGianHangCaoCap(gianHangCaoCaps);
            _AddListGianHangTieuChuan(gianHangTieuChuans);
            _AddTableGianHangCC(gianHangCaoCaps);
            _AddTableGianHangTC(gianHangTieuChuans);
            _ChangeColorTableCC();
            _ChangeColorTableTC();
            _ChangeColor();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmThemGianHang frmThemGianHang = new frmThemGianHang();
            if(frmThemGianHang.ShowDialog() == DialogResult.OK)
            {
                CapNhap();
            }    
        }
        /// <summary>
        /// Sự kiện xảy ra khi ấn nút sửa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if(cbLoaiGianHang.SelectedIndex == 0)
            {
                _suaGianHang();
            }
            else if(cbLoaiGianHang.SelectedIndex == 1)
            {
                _suaGianHangCC();
            }
            else
                _suaGianHangTC();
        }

        private void _suaGianHang()
        {
            if(dataGianHang.SelectedRows[0].Cells[4].Value == null)
            {
                this.Alert("Bạn chưa chọn gian hàng", frmThongBao.alertTypeEnum.Error);
                return;
            }    
            if(dataGianHang.SelectedRows[0].Cells[4].Value.ToString() == "Đã thuê")
            {
                this.Alert("Gian hàng đã được thuê không được sửa", frmThongBao.alertTypeEnum.Warning);
            }
            else
            {
                bool LoaiGianHang = dataGianHang.SelectedRows[0].Cells[3].Value.ToString() == "Gian hàng tiêu chuẩn";
                if(LoaiGianHang == false)
                {
                    GianHangCaoCapDTO gianHangCaoCap = qlGianHang.TimKiemTheoMaGianHang<GianHangCaoCapDTO>(dataGianHang.SelectedRows[0].Cells[0].Value.ToString())[0];
                    frmSuaGianHang frmSuaGianHang = new frmSuaGianHang(LoaiGianHang, gianHangCaoCap, null);
                    if(frmSuaGianHang.ShowDialog() == DialogResult.Yes)
                    {
                        CapNhap();
                    }
                }
                else
                {
                    GianHangTieuChuanDTO gianHangTieuChuan = qlGianHang.TimKiemTheoMaGianHang<GianHangTieuChuanDTO>(dataGianHang.SelectedRows[0].Cells[0].Value.ToString())[0];
                    frmSuaGianHang frmSuaGianHang = new frmSuaGianHang(LoaiGianHang, null, gianHangTieuChuan);
                    if(frmSuaGianHang.ShowDialog() == DialogResult.Yes)
                    {
                        
                        CapNhap();
                    }
                }
            }
        }
        private void _suaGianHangCC()
        {
            if(dataGianHangCC.SelectedRows[0].Cells[3].Value == null)
            {
                this.Alert("Bạn chưa chọn gian hàng", frmThongBao.alertTypeEnum.Error);
                return;
            }    
            if(dataGianHangCC.SelectedRows[0].Cells[3].Value.ToString() == "Đã thuê")
            {
                this.Alert("Gian hàng đã được thuê không được sửa", frmThongBao.alertTypeEnum.Warning);
            }
            else
            {
                GianHangCaoCapDTO gianHangCaoCap = qlGianHang.TimKiemTheoMaGianHang<GianHangCaoCapDTO>(dataGianHangCC.SelectedRows[0].Cells[0].Value.ToString())[0];
                frmSuaGianHang frmSuaGianHang = new frmSuaGianHang(false, gianHangCaoCap, null);
                if(frmSuaGianHang.ShowDialog() == DialogResult.Yes)
                {
                    CapNhap();
                }
            }
        }
        private void _suaGianHangTC()
        {
            if(dataGianHangTC.SelectedRows[0].Cells[3].Value == null)
            {
                this.Alert("Bạn chưa chọn gian hàng", frmThongBao.alertTypeEnum.Error);
                return;
            }    
            if(dataGianHangTC.SelectedRows[0].Cells[3].Value.ToString() == "Đã thuê")
            {
                this.Alert("Gian hàng đã được thuê không được sửa", frmThongBao.alertTypeEnum.Warning);
            }
            else
            {
                GianHangTieuChuanDTO gianHangTieuChuan = qlGianHang.TimKiemTheoMaGianHang<GianHangTieuChuanDTO>(dataGianHangTC.SelectedRows[0].Cells[0].Value.ToString())[0];
                frmSuaGianHang frmSuaGianHang = new frmSuaGianHang(true, null, gianHangTieuChuan);
                if(frmSuaGianHang.ShowDialog() == DialogResult.Yes)
                {
                    CapNhap();
                }
            }
        }
        private void dataGianHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void _AddGianHangTieuChuan(GianHangTieuChuanDTO gianHang)
        {
            DataGridViewRow row = (DataGridViewRow)dataGianHang.Rows[0].Clone();
            row.Cells[0].Value = gianHang.MaGianHang;
            row.Cells[1].Value = gianHang.DienTich;
            row.Cells[2].Value = gianHang.ViTriGianHang;
            row.Cells[3].Value = "Gian hàng tiêu chuẩn";
            row.Cells[4].Value = TinhTrangThue(gianHang);
            dataGianHang.Rows.Add(row);

        }
        private void _AddGianHangCaoCap(GianHangCaoCapDTO gianHang)
        {

            DataGridViewRow row = (DataGridViewRow)dataGianHang.Rows[0].Clone();
            row.Cells[0].Value = gianHang.MaGianHang;
            row.Cells[1].Value = gianHang.DienTich;
            row.Cells[2].Value = gianHang.ViTriGianHang;
            row.Cells[3].Value = "Gian hàng cao cấp";
            row.Cells[4].Value = TinhTrangThue(gianHang);
            dataGianHang.Rows.Add(row);

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
        
        private void _AddListGianHangCaoCap(List<GianHangCaoCapDTO> gianHangCaos)
        {
            for(int i = 0; i < gianHangCaoCaps.Count; i++)
            {
                _AddGianHangCaoCap(gianHangCaoCaps[i]);
            }
        }
        /// <summary>
        /// Thêm gian hàng tiêu chuẩn ở vị trí start
        /// </summary>
        /// <param name="gianTieuChuans">List danh sách gian hàng tiêu chuẩn</param>
        /// <param name="start">Vị trí bắt đầu thêm</param>
        private void _AddListGianHangTieuChuan(List<GianHangTieuChuanDTO> gianTieuChuans)
        {
            for(int i = 0; i < gianTieuChuans.Count; i++)
            {
                _AddGianHangTieuChuan(gianTieuChuans[i]);
            }
        }
        /// <summary>
        /// Điều chỉnh màu sắc của bảng tất cả gian hàng
        /// </summary>
        private void _ChangeColor()
        {
            foreach(DataGridViewRow row in dataGianHang.Rows)
            {
                
                if(Convert.ToString(row.Cells[4].Value) == "Đã thuê")
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(251, 161, 71);
                } else
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(59, 142, 202);
                }    
            }    
        }
        /// <summary>
        /// Điều chỉnh màu sắc của gian hàng tiêu chuẩn
        /// </summary>
        private void _ChangeColorTableTC()
        {
            foreach(DataGridViewRow row in dataGianHangTC.Rows)
            {
                if(Convert.ToString(row.Cells[3].Value) == "Đã thuê")
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(251, 161, 71);
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(59, 142, 202);
                }
            }    
        }
        /// <summary>
        /// Điều chỉnh màu sắc của bảng gian hàng cao cấp
        /// </summary>
        private void _ChangeColorTableCC()
        {
            foreach(DataGridViewRow row in dataGianHangCC.Rows)
            {
                if(Convert.ToString(row.Cells[3].Value) == "Đã thuê")
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(251, 161, 71);
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(59, 142, 202);
                }
            }
        }
        /// <summary>
        /// Điều chỉnh nút tìm kiếm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if(txtTimKiem.Text == "")
            {
                this.Alert("Chưa nhập vào mã gian hàng", frmThongBao.alertTypeEnum.Warning);
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
                            this.Alert("Không có mã gian hàng bạn tìm kiếm", frmThongBao.alertTypeEnum.Info);
                        } else
                        {
                            dataGianHang.Rows.Clear();
                    
                            
                            for(int i = 0; i < gianHangs.Count; i++)
                            {
                                if(gianHangs[i].MaGianHang.Substring(0,2) == "TC")
                                {
                                    string ma = gianHangs[i].MaGianHang;
                                    List<GianHangTieuChuanDTO> gianHangs1 = qlGianHang.TimKiemTheoMaGianHang<GianHangTieuChuanDTO>(ma);
                                    GianHangTieuChuanDTO gianHang = qlGianHang.TimKiemTheoMaGianHang<GianHangTieuChuanDTO>(ma)[0];
                                    _AddGianHangTieuChuan(gianHang);
                                } else if(gianHangs[i].MaGianHang.Substring(0,2) == "CC")
                                {
                                    string ma = gianHangs[i].MaGianHang;
                                    GianHangCaoCapDTO gianHang = qlGianHang.TimKiemTheoMaGianHang<GianHangCaoCapDTO>(ma)[0];
                                    _AddGianHangCaoCap(gianHang);
                                }
                                _ChangeColor();
                            }    
                        }    
                    } else
                    {
                        cbLoaiGianHang.SelectedIndex = 0;
                        List<GianHangDTO> gianHangs = qlGianHang.TimKiemTheoMaGianHang(maGianHang);
                        if(gianHangs.Count == 0)
                        {
                            this.Alert("Không có mã gian hàng bạn tìm kiếm", frmThongBao.alertTypeEnum.Info);
                        }
                        else
                        {
                            dataGianHang.Rows.Clear();
                            for(int i = 0; i < gianHangs.Count; i++)
                            {
                                if(gianHangs[i].MaGianHang.Substring(0, 2) == "TC")
                                {
                                    string ma = gianHangs[i].MaGianHang;
                                    List<GianHangTieuChuanDTO> gianHangs1 = qlGianHang.TimKiemTheoMaGianHang<GianHangTieuChuanDTO>(ma);
                                    GianHangTieuChuanDTO gianHang = qlGianHang.TimKiemTheoMaGianHang<GianHangTieuChuanDTO>(ma)[0];
                                    _AddGianHangTieuChuan(gianHang);
                                }
                                else if(gianHangs[i].MaGianHang.Substring(0, 2) == "CC")
                                {
                                    string ma = gianHangs[i].MaGianHang;
                                    GianHangCaoCapDTO gianHang = qlGianHang.TimKiemTheoMaGianHang<GianHangCaoCapDTO>(ma)[0];
                                    _AddGianHangCaoCap(gianHang);
                                }
                                _ChangeColor();
                            }
                        }
                        }    
                }    
            }    
        }

        private void dataGianHang_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void _AddTableGianHangTC(List<GianHangTieuChuanDTO> gianHangTieuChuans)
        {
            
            for(int i = 0; i < gianHangTieuChuans.Count; i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGianHangTC.Rows[0].Clone();
                row.Cells[0].Value = gianHangTieuChuans[i].MaGianHang;
                row.Cells[1].Value = gianHangTieuChuans[i].DienTich;
                row.Cells[2].Value = gianHangTieuChuans[i].ViTriGianHang;
                row.Cells[3].Value = TinhTrangThue(gianHangTieuChuans[i]);
                row.Cells[4].Value = gianHangTieuChuans[i].ChatLieuVachNgan;
                row.Cells[5].Value = gianHangTieuChuans[i].ChatLieuMaiChe;
                dataGianHangTC.Rows.Add(row);
            }    
        }
        private void _AddTableGianHangCC(List<GianHangCaoCapDTO> gianHangCaoCaps)
        {
           
            for(int i = 0; i < gianHangCaoCaps.Count; i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGianHangCC.Rows[0].Clone();
                row.Cells[0].Value = gianHangCaoCaps[i].MaGianHang;
                row.Cells[1].Value = gianHangCaoCaps[i].DienTich;
                row.Cells[2].Value = gianHangCaoCaps[i].ViTriGianHang;
                row.Cells[3].Value = TinhTrangThue(gianHangCaoCaps[i]);
                row.Cells[4].Value = gianHangCaoCaps[i].SoQuatLamMat;
                row.Cells[5].Value = gianHangCaoCaps[i].SoBanGhe;
                dataGianHangCC.Rows.Add(row);
            }
        }
        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string LoaiGianHang = cbLoaiGianHang.SelectedItem.ToString();
            if(LoaiGianHang == "Gian hàng cao cấp")
            {
                dataGianHang.Visible = false;
                dataGianHangTC.Visible = false;
                dataGianHangCC.Visible = true;
                CapNhap();
               
            }
            else if(LoaiGianHang == "Gian hàng tiêu chuẩn")
            {
                dataGianHang.Visible = false;
                dataGianHangTC.Visible = true;
                dataGianHangCC.Visible = false;
                CapNhap();
               
            } else
            {
                dataGianHang.Visible = true;
                dataGianHangCC.Visible = false;
                dataGianHangTC.Visible = false;
                CapNhap();
            }    
                

        }

        private void btnXoaGianHang_Click(object sender, EventArgs e)
        {
            try
            {
                string maGianHang;
                if(cbLoaiGianHang.SelectedIndex == 0)
                {
                    if(dataGianHang.SelectedRows[0].Cells[0].Value == null)
                    {
                        this.Alert("Bạn chưa chọn gian hàng", frmThongBao.alertTypeEnum.Error);
                        return;
                    }
                    else
                    {
                        maGianHang = dataGianHang.SelectedRows[0].Cells[0].Value.ToString();
                    }
                }
                else if(cbLoaiGianHang.SelectedIndex == 1)
                {
                    if(dataGianHangCC.SelectedRows[0].Cells[0].Value == null)
                    {
                        this.Alert("Bạn chưa chọn gian hàng", frmThongBao.alertTypeEnum.Error);
                        return;
                    }
                    else
                    {
                        maGianHang = dataGianHangCC.SelectedRows[0].Cells[0].Value.ToString();
                    }
                }
                else
                {
                    if(dataGianHangTC.SelectedRows[0].Cells[0].Value == null)
                    {
                        this.Alert("Bạn chưa chọn gian hàng", frmThongBao.alertTypeEnum.Error);
                        return;
                    }
                    else
                    {
                        maGianHang = dataGianHangTC.SelectedRows[0].Cells[0].Value.ToString();
                    }
                }

                GianHangDTO gianHang = qlGianHang.TimKiemTheoMaGianHang<GianHangDTO>(maGianHang)[0];
                if(gianHang.TinhTrangThue == true)
                {
                    this.Alert("Gian hàng đang được thuê. Xóa không thành công", frmThongBao.alertTypeEnum.Error);
                }
                else
                {
                    if(new frmTinNhan("Bạn có chắc muốn xóa gian hàng có mã: " + maGianHang + "?").ShowDialog() == DialogResult.Yes)
                    {
                        if(qlGianHang.XoaGianHang(maGianHang))
                        {
                            this.Alert("Xóa gian hàng thành công!", frmThongBao.alertTypeEnum.Success);
                            CapNhap();
                        }
                        else
                        {
                            this.Alert("Xóa thất bại!", frmThongBao.alertTypeEnum.Error);
                        }
                    }
                }    
                
            } catch(Exception erorr)
            {
                this.Alert(erorr.Message, frmThongBao.alertTypeEnum.Error);
            }

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if(txtTimKiem.Text == "")
            {
                CapNhap();
            }    
        }

        private void dataGianHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bool LoaiGianHang = dataGianHang.Rows[e.RowIndex].Cells[3].Value.ToString() == "Gian hàng tiêu chuẩn";
            if(LoaiGianHang == false)
            {
                GianHangCaoCapDTO gianHangCaoCap = qlGianHang.TimKiemTheoMaGianHang<GianHangCaoCapDTO>(dataGianHang.SelectedRows[0].Cells[0].Value.ToString())[0];
                frmThongTinChiTietGianHang frmThongTinChiTiet = new frmThongTinChiTietGianHang(LoaiGianHang, gianHangCaoCap, null);
                frmThongTinChiTiet.Show();
                
            }
            else
            {
                GianHangTieuChuanDTO gianHangTieuChuan = qlGianHang.TimKiemTheoMaGianHang<GianHangTieuChuanDTO>(dataGianHang.SelectedRows[0].Cells[0].Value.ToString())[0];
                frmThongTinChiTietGianHang frmThongTinChiTiet = new frmThongTinChiTietGianHang(LoaiGianHang, null, gianHangTieuChuan);
                frmThongTinChiTiet.Show();

            }
        }

        private void dataGianHang_KeyUp(object sender, KeyEventArgs e)
        {
            int index = dataGianHang.SelectedRows[0].Index;
            
        }

        private void dataGianHang_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == -1)
                return;
            if(dataGianHang.Rows[e.RowIndex].Cells[3].Value == null)
                return;
            bool LoaiGianHang = dataGianHang.Rows[e.RowIndex].Cells[3].Value.ToString() == "Gian hàng tiêu chuẩn";
            if(LoaiGianHang == false)
            {
                GianHangCaoCapDTO gianHangCaoCap = qlGianHang.TimKiemTheoMaGianHang<GianHangCaoCapDTO>(dataGianHang.SelectedRows[0].Cells[0].Value.ToString())[0];
                frmThongTinChiTietGianHang frmThongTinChiTiet = new frmThongTinChiTietGianHang(LoaiGianHang, gianHangCaoCap, null);
                frmThongTinChiTiet.Show();

            }
            else
            {
                GianHangTieuChuanDTO gianHangTieuChuan = qlGianHang.TimKiemTheoMaGianHang<GianHangTieuChuanDTO>(dataGianHang.SelectedRows[0].Cells[0].Value.ToString())[0];
                frmThongTinChiTietGianHang frmThongTinChiTiet = new frmThongTinChiTietGianHang(LoaiGianHang, null, gianHangTieuChuan);
                frmThongTinChiTiet.Show();

            }
        }

        private void dataGianHangTC_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dataGianHangCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                guna2Button4.PerformClick();
            }    
        }
    }
}
