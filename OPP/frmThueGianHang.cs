using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPP
{
    public partial class frmThueGianHang : Form
    {
        public frmThueGianHang()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmThueGianHang_Load(object sender, EventArgs e)
        {
            _XuLyGianHang();
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void _XuLyGianHang()
        {
            pnViTriGianHang.Controls.Clear();
            int count = 1;
            for(int i = 0; i < pnViTriGianHang.RowCount; i++)
            {
                for(int j = 0; j < pnViTriGianHang.ColumnCount; j++)
                {
                    Label lbGianHang = new Label();
                    
                    lbGianHang.Dock = DockStyle.Fill;
                    lbGianHang.TextAlign = ContentAlignment.MiddleCenter;
                    lbGianHang.Font = new Font("Century Gothic", 12);
                    if((i + j) % 3 == 0)
                    {
                        lbGianHang.BackColor = Color.FromArgb(255, 210, 199);
                        lbGianHang.Text = "Gian Hàng: " + count + "\n(Đã thuê)";
                    } else if((i + j) % 3 == 1)
                    {
                        lbGianHang.BackColor = Color.FromArgb(151, 163, 226);
                        lbGianHang.Text = "Gian Hàng: " + count + "\n(Chưa thuê)";
                    } else
                    {
                        lbGianHang.BackColor = Color.White;
                        lbGianHang.Text = "Gian Hàng: " + count + "\n(Chưa có gian hàng)";
                    }    
                    pnViTriGianHang.Controls.Add(lbGianHang, j, i);
                    count++;
                }    
            }    
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmThongTinKhachHang frm = new frmThongTinKhachHang();
            frm.Show();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
