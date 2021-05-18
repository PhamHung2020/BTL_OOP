// LE TON NANG - 20194339
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class frmThueGianHang : Form
    {
        List<GianHangDTO> gianHangs;
        Label selected;
        Color color;
        public frmThueGianHang()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmThueGianHang_Load(object sender, EventArgs e)
        {
            gianHangs = GianHangBUS.Instance.DanhSachGianHangTheoSoTang(1);
            _XuLyGianHang(gianHangs);
            txTongSoGianHangThue.Text = GianHangBUS.Instance.DanhSachGianHangTheoTinhTrangThue(true).Count().ToString();
            txtTongSoGianHang.Text = GianHangBUS.Instance.LayDanhSachGianHang<GianHangDTO>().Count().ToString();
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void _XuLyGianHang(List<GianHangDTO> gianHangs)
        {
            pnViTriGianHang.Controls.Clear();
            int count = 1;
            int viTri;
            for(int i = 0; i < pnViTriGianHang.RowCount; i++)
            {
                for(int j = 0; j < pnViTriGianHang.ColumnCount; j++)
                {
                    Label lbGianHang = new Label();
                    lbGianHang.Dock = DockStyle.Fill;
                    lbGianHang.TextAlign = ContentAlignment.MiddleCenter;
                    lbGianHang.Font = new Font("Century Gothic", 12);
                    lbGianHang.BackColor = Color.White;
                    lbGianHang.Text = "Vị trí: " + count + "\n(Chưa có gian hàng)";
                    lbGianHang.Click += LbGianHang_Click;
                    lbGianHang.DoubleClick += LbGianHang_DoubleClick;
                    lbGianHang.Cursor = Cursors.Hand;
                    lbGianHang.Name = "Không có gian hàng";
                    pnViTriGianHang.Controls.Add(lbGianHang, j, i);
                    count++;
                }    
            }
            foreach(var i in gianHangs)
            {
                viTri = Int32.Parse(i.MaGianHang.Substring(3, 2));
                if(i.TinhTrangThue == true)
                {
                    pnViTriGianHang.Controls[viTri - 1].Text = "Vị trí: " + viTri + "\n(Đã được thuê)";
                    pnViTriGianHang.Controls[viTri - 1].BackColor = Color.FromArgb(255, 210, 199);
                    pnViTriGianHang.Controls[viTri - 1].Name = i.MaGianHang;
                } else if(i.TinhTrangThue == false)
                {
                    pnViTriGianHang.Controls[viTri - 1].Text = "Vị trí: " + viTri + "\n(Chưa được thuê)";
                    pnViTriGianHang.Controls[viTri - 1].BackColor = Color.FromArgb(151, 163, 226);
                    pnViTriGianHang.Controls[viTri - 1].Name = i.MaGianHang;
                }    
                
            }    
        }

        private void LbGianHang_DoubleClick(object sender, EventArgs e)
        {
            Label label = sender as Label;
            string maGianHang = label.Name;
            if(maGianHang.Substring(0,2) == "TC")
            {
                GianHangTieuChuanDTO gianHangTieuChuan = GianHangBUS.Instance.TimKiemTheoMaGianHang<GianHangTieuChuanDTO>(maGianHang)[0];
                new frmThongTinChiTietGianHang(true, null, gianHangTieuChuan).Show();
            } else if(maGianHang.Substring(0,2) == "CC")
            {
                GianHangCaoCapDTO gianHangCaoCap = GianHangBUS.Instance.TimKiemTheoMaGianHang<GianHangCaoCapDTO>(maGianHang)[0];
                new frmThongTinChiTietGianHang(false, gianHangCaoCap, null).Show();
            }    
        }

        private void LbGianHang_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;
            if(selected == null)
            {
                color = label.BackColor;
                label.BackColor = Color.DodgerBlue;
                selected = label;
            } else
            {
                selected.BackColor = color;
                color = label.BackColor;
                label.BackColor = Color.DodgerBlue;
                selected = label;
            }    
        }
        private void Check()
        {
            
        }
        public void Alert(string msg, frmThongBao.alertTypeEnum type)
        {
            frmThongBao f = new frmThongBao();
            f.setAlert(msg, type);
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(selected == null)
            {
                this.Alert("Bạn chưa chọn gian hàng", frmThongBao.alertTypeEnum.Warning);
            } else
            {
                if(selected.Name == "Không có gian hàng")
                {
                    this.Alert("Vị trí chưa có gian hàng", frmThongBao.alertTypeEnum.Warning);
                }    
                else
                {
                    if(color == Color.FromArgb(255, 210, 199))
                    {
                        this.Alert("Gian hàng đã được thuê", frmThongBao.alertTypeEnum.Warning);
                    }    
                    else
                    {
                        string maGianHang = selected.Name;
                        if(new frmThongTinKhachHang(maGianHang).ShowDialog() == DialogResult.Yes)
                        {
                            int tang = guna2ComboBox1.SelectedIndex + 1;
                            gianHangs = GianHangBUS.Instance.DanhSachGianHangTheoSoTang(tang);
                            _XuLyGianHang(gianHangs);
                        }    
                    }    
                }    
            }
            txTongSoGianHangThue.Text = GianHangBUS.Instance.DanhSachGianHangTheoTinhTrangThue(true).Count().ToString();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tang = guna2ComboBox1.SelectedItem.ToString();
            if(tang == "Tầng 1")
            {
                List<GianHangDTO> gianHangs = GianHangBUS.Instance.DanhSachGianHangTheoSoTang(1);
                _XuLyGianHang(gianHangs);
                selected = null;
            } else if(tang == "Tầng 2")
            {
                List<GianHangDTO> gianHangs = GianHangBUS.Instance.DanhSachGianHangTheoSoTang(2);
                _XuLyGianHang(gianHangs);
                selected = null;
            } else if(tang == "Tầng 3")
            {
                List<GianHangDTO> gianHangs = GianHangBUS.Instance.DanhSachGianHangTheoSoTang(3);
                _XuLyGianHang(gianHangs);
                selected = null;
            } else if(tang == "Tầng 4")
            {
                List<GianHangDTO> gianHangs = GianHangBUS.Instance.DanhSachGianHangTheoSoTang(4);
                _XuLyGianHang(gianHangs);
                selected = null;
            }    
        }
    }
}
