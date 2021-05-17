// LE TON NANG - 20194339
using System;
using System.Windows.Forms;
using BUS;

namespace OPP
{
    public partial class frmThongKeDoanhThu : Form
    {
        public frmThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void frmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            Bunifu.Dataviz.WinForms.BunifuDatavizBasic.Canvas canvas = new Bunifu.Dataviz.WinForms.BunifuDatavizBasic.Canvas();
            Bunifu.Dataviz.WinForms.BunifuDatavizBasic.DataPoint dataPoint = new Bunifu.Dataviz.WinForms.BunifuDatavizBasic.DataPoint(Bunifu.Dataviz.WinForms.BunifuDatavizBasic._type.Bunifu_splineArea);
            for(int i = 1; i <= 12; i++)
            {
                decimal doanhThu = KhuTrungBayBUS.Instance.DoanhThu(i, 2021);
                dataPoint.addxy(i, doanhThu);
            }    
            canvas.addData(dataPoint);
            bunifuDatavizBasic1.Render(canvas);
            tbTongDoanhThu.Text = KhuTrungBayBUS.Instance.DoanhThu(new DateTime(2020,1,1,0,0,0), DateTime.Now).ToString();
            
        }
        public void Alert(string msg, frmThongBao.alertTypeEnum type)
        {
            frmThongBao f = new frmThongBao();
            f.setAlert(msg, type);
        }
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if(dtpBatDau.Text == dtpKetThuc.Text || dtpBatDau.Value < dtpKetThuc.Value)
                tbDoanhThu.Text = KhuTrungBayBUS.Instance.DoanhThu(DateTime.Parse(dtpBatDau.Text), DateTime.Parse(dtpKetThuc.Text)).ToString();
            else
            {
                this.Alert("Thời gian không hợp lệ", frmThongBao.alertTypeEnum.Warning);
                tbDoanhThu.Text = "0";
            }    
        }

        private void frmThongKeDoanhThu_Resize(object sender, EventArgs e)
        {
            
        }
    }
}
