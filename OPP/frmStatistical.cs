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

namespace OPP
{
    public partial class frmStatistical : Form
    {
        
        public frmStatistical()
        {
            InitializeComponent();
        }

        private void frmStatistical_Load(object sender, EventArgs e)
        {
            List<GianHangCaoCapDTO> caoCapDTOs = new List<GianHangCaoCapDTO>();
            caoCapDTOs.Add(new GianHangCaoCapDTO("TC101", 5.0, "Tầng 1-101", true, 10, 12));
            caoCapDTOs.Add(new GianHangCaoCapDTO("TC102", 5.0, "Tầng 1-102", true, 10, 12));
            List<GianHangTieuChuanDTO> tieuChuanDTOs = new List<GianHangTieuChuanDTO>();
            tieuChuanDTOs.Add(new GianHangTieuChuanDTO("TC203", 10, "Tầng 2-203", false, "Bê tông", "Nhựa"));
            dataGianHang.Rows.Add(tieuChuanDTOs.Count + caoCapDTOs.Count);
            int count;
            for(count = 0; count < tieuChuanDTOs.Count; count++)
            {
                _AddGianHangTieuChuan(tieuChuanDTOs[count], count);
                
            }
            for(count = tieuChuanDTOs.Count; count < tieuChuanDTOs.Count + caoCapDTOs.Count; count++)
            {
                _AddGianHangCaoCap(caoCapDTOs[count - tieuChuanDTOs.Count], count);
                
            }
            _ChangeColor();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmThemGianHang frmThemGianHang = new frmThemGianHang();
            frmThemGianHang.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            frmSuaGianHang frmSuaGianHang = new frmSuaGianHang();
            frmSuaGianHang.Show();
        }

        private void dataGianHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void _AddGianHangTieuChuan(GianHangTieuChuanDTO gianHang, int count)
        {
            dataGianHang.Rows[count].Cells[0].Value = gianHang.MaGianHang;
            dataGianHang.Rows[count].Cells[1].Value = gianHang.DienTich;
            dataGianHang.Rows[count].Cells[2].Value = gianHang.ViTriGianHang;
            dataGianHang.Rows[count].Cells[3].Value = gianHang.TinhTrangThue;
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
            dataGianHang.Rows[count].Cells[3].Value = gianHang.TinhTrangThue;
            dataGianHang.Rows[count].Cells[4].Value = gianHang.SoBanGhe;
            dataGianHang.Rows[count].Cells[5].Value = gianHang.SoQuatLamMat;
            dataGianHang.Rows[count].Cells[6].Value = "NULL";
            dataGianHang.Rows[count].Cells[7].Value = "NULL";
        }
        private void _ChangeColor()
        {
            foreach(DataGridViewRow row in dataGianHang.Rows)
            {
                
                if(Convert.ToBoolean(row.Cells[3].Value) == true)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(251, 161, 71);
                } else
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(59, 142, 202);
                }    
            }    
        }
    }
}
