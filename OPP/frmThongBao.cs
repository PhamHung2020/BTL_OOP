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
    public partial class frmThongBao : Form
    {
        public frmThongBao(string message, int type)
        {
            InitializeComponent();
            switch (type){
                case 0: this.BackColor = Color.SeaGreen;
                    pictureBox1.Image = imageList1.Images[1];
                    bunifuLabel1.Text = message;
                    break;
                case 1: this.BackColor = Color.Crimson;
                    pictureBox1.Image = imageList1.Images[0];
                    bunifuLabel1.Text = message;
                    break;
                case 2: this.BackColor = Color.FromArgb(255,128,0);
                    pictureBox1.Image = imageList1.Images[2];
                    bunifuLabel1.Text = message;
                    break;
            }
        }

        private void frmThongBaoThanhCong_Load(object sender, EventArgs e)
        {
            this.Top = -1 * (this.Height);
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 60;
            show.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            close.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            close.Start();
        }
        int interval = 0;
        private void show_Tick(object sender, EventArgs e)
        {
            if(this.Top < 60)
            {
                this.Top += interval;
                interval += 2;
            }
            else
            {
                show.Stop();
            }
        }

        private void close_Tick(object sender, EventArgs e)
        {
            if(this.Opacity > 0)
            {
                this.Opacity -= 0.1;
            } else
            {
                this.Close();
            }    
        }
       
    }
}
