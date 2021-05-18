// LE TON NANG - 20194339
using System;
using System.Drawing;
using System.Windows.Forms;
using GUI.Properties;

namespace GUI
{
    public partial class frmThongBao : Form
    {
        public frmThongBao()
        {
            InitializeComponent();
        }
        public enum alertTypeEnum
        {
            Success,
            Warning,
            Error,
            Info
        }
        private int x, y;
        
        public void setAlert(string msg, frmThongBao.alertTypeEnum type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for(int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                frmThongBao f = (frmThongBao)Application.OpenForms[fname];

                if(f == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }

            }

            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;
            switch(type)
            {
                case frmThongBao.alertTypeEnum.Success:
                    pictureBox1.Image = Resources.Checkmark_28px;
                    this.BackColor = Color.FromArgb(42, 171, 160);
                    break;
                case frmThongBao.alertTypeEnum.Warning:
                    pictureBox1.Image = Resources.Warning_28px;
                    this.BackColor = Color.FromArgb(255, 179, 2);
                    break;
                case frmThongBao.alertTypeEnum.Error:
                    pictureBox1.Image = Resources.Error_28px;
                    this.BackColor = Color.FromArgb(255, 121, 70);
                    break;
                case frmThongBao.alertTypeEnum.Info:
                    pictureBox1.Image = Resources.Info_28px;
                    this.BackColor = Color.FromArgb(71, 169, 248);
                    break;
            }
            this.bunifuLabel1.Text = msg;

            //this.TopMost = false;
            //this.ShowIcon = false;
            //this.ShowInTaskbar = false;

            this.Show();
            this.action = actionEnum.start;
            this.Timer1.Interval = 1;
            this.Timer1.Start();


        }
        private frmThongBao.actionEnum action;
        public enum actionEnum
        {
            wait,
            start,
            close
        }
        private void frmThongBaoThanhCong_Load(object sender, EventArgs e)
        {
           
            
        }

        

        
        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            switch(this.action)
            {
                case frmThongBao.actionEnum.wait:
                    this.Timer1.Interval = 5000;
                    this.action = frmThongBao.actionEnum.close;
                    break;
                case frmThongBao.actionEnum.start:
                    this.Timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if(this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if(this.Opacity == 1.0)
                        {
                            this.action = frmThongBao.actionEnum.wait;
                        }
                    }
                    break;
                case frmThongBao.actionEnum.close:
                    this.Timer1.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if(base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            this.Timer1.Interval = 1;
            this.action = frmThongBao.actionEnum.close;
        }
    }
}
