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
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(selected == null)
            {
                new frmThongBao("Bạn chưa chon gian hàng", 2).Show() ;
            } else
            {
                if(selected.Name == "Không có gian hàng")
                {
                    new frmThongBao("Vị trí chưa có gian hàng", 2).Show();
                }    
                else
                {
                    if(color == Color.FromArgb(255, 210, 199))
                    {
                        new frmThongBao("Gian hàng đã được thuê", 2).Show();
                    }    
                    else
                    {
                        string maGianHang = selected.Name;
                        if(new frmThongTinKhachHang(maGianHang).ShowDialog() == DialogResult.Yes)
                        {
                            gianHangs = GianHangBUS.Instance.DanhSachGianHangTheoSoTang(1);
                            _XuLyGianHang(gianHangs);
                        }    
                    }    
                }    
            }    
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tang = guna2ComboBox1.SelectedItem.ToString();
            if(tang == "Tầng 1")
            {
                List<GianHangDTO> gianHangs = GianHangBUS.Instance.DanhSachGianHangTheoSoTang(1);
                _XuLyGianHang(gianHangs);
            } else if(tang == "Tầng 2")
            {
                List<GianHangDTO> gianHangs = GianHangBUS.Instance.DanhSachGianHangTheoSoTang(2);
                _XuLyGianHang(gianHangs);
            } else if(tang == "Tầng 3")
            {
                List<GianHangDTO> gianHangs = GianHangBUS.Instance.DanhSachGianHangTheoSoTang(3);
                _XuLyGianHang(gianHangs);
            } else if(tang == "Tầng 4")
            {
                List<GianHangDTO> gianHangs = GianHangBUS.Instance.DanhSachGianHangTheoSoTang(4);
                _XuLyGianHang(gianHangs);
            }    
        }
    }
}
