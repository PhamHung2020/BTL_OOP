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
    public partial class frmThongKeKhachHang : Form
    {
        public frmThongKeKhachHang()
        {
            InitializeComponent();
            
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmThongKeKhachHang_Load(object sender, EventArgs e)
        {
            List<KhachHangDTO> khachHangs = new List<KhachHangDTO>();
            khachHangs = KhachHangBUS.Instance.LayDanhSachKhachHang();
            dataKhachHang.Rows.Add(khachHangs.Count - 1);
            for(int i = 0; i < khachHangs.Count; i++)
            {
                dataKhachHang.Rows[i].Cells[0].Value = khachHangs[i].MaKhachHang;
                dataKhachHang.Rows[i].Cells[1].Value = khachHangs[i].Ten;
                dataKhachHang.Rows[i].Cells[2].Value = khachHangs[i].DiaChi;
                dataKhachHang.Rows[i].Cells[3].Value = khachHangs[i].MaGianHang;
                dataKhachHang.Rows[i].Cells[4].Value = khachHangs[i].ThoiGianBatDauThue;
                dataKhachHang.Rows[i].Cells[5].Value = khachHangs[i].ThoiGianKetThucThue;
                dataKhachHang.Rows[i].Cells[6].Value = khachHangs[i].TienDatCoc;
            }    
        }
    }
}
