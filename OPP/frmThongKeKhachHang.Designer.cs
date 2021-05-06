
namespace OPP
{
    partial class frmThongKeKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataKhachHang = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.maKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maGianhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienDatCoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dataKhachHang
            // 
            this.dataKhachHang.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataKhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataKhachHang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataKhachHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataKhachHang.ColumnHeadersHeight = 40;
            this.dataKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKhachHang,
            this.tenKhachHang,
            this.diaChi,
            this.maGianhang,
            this.thoiGianBatDau,
            this.thoiGianKetThuc,
            this.tienDatCoc});
            this.dataKhachHang.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataKhachHang.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataKhachHang.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataKhachHang.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataKhachHang.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataKhachHang.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataKhachHang.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataKhachHang.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataKhachHang.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataKhachHang.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataKhachHang.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dataKhachHang.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataKhachHang.CurrentTheme.Name = null;
            this.dataKhachHang.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataKhachHang.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataKhachHang.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataKhachHang.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataKhachHang.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataKhachHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataKhachHang.EnableHeadersVisualStyles = false;
            this.dataKhachHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataKhachHang.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataKhachHang.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataKhachHang.HeaderForeColor = System.Drawing.Color.White;
            this.dataKhachHang.Location = new System.Drawing.Point(0, 0);
            this.dataKhachHang.Name = "dataKhachHang";
            this.dataKhachHang.RowHeadersVisible = false;
            this.dataKhachHang.RowTemplate.Height = 40;
            this.dataKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataKhachHang.Size = new System.Drawing.Size(917, 605);
            this.dataKhachHang.TabIndex = 0;
            this.dataKhachHang.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dataKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuDataGridView1_CellContentClick);
            // 
            // maKhachHang
            // 
            this.maKhachHang.HeaderText = "Mã khách hàng";
            this.maKhachHang.Name = "maKhachHang";
            // 
            // tenKhachHang
            // 
            this.tenKhachHang.HeaderText = "Tên khách hàng";
            this.tenKhachHang.Name = "tenKhachHang";
            // 
            // diaChi
            // 
            this.diaChi.HeaderText = "Địa chỉ";
            this.diaChi.Name = "diaChi";
            // 
            // maGianhang
            // 
            this.maGianhang.HeaderText = "Mã gian hàng";
            this.maGianhang.Name = "maGianhang";
            // 
            // thoiGianBatDau
            // 
            this.thoiGianBatDau.HeaderText = "Thời gian bắt đầu thuê";
            this.thoiGianBatDau.Name = "thoiGianBatDau";
            // 
            // thoiGianKetThuc
            // 
            this.thoiGianKetThuc.HeaderText = "Thời gian kết thúc thuê";
            this.thoiGianKetThuc.Name = "thoiGianKetThuc";
            // 
            // tienDatCoc
            // 
            this.tienDatCoc.HeaderText = "Tiền đặt cọc";
            this.tienDatCoc.Name = "tienDatCoc";
            // 
            // frmThongKeKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 605);
            this.Controls.Add(this.dataKhachHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThongKeKhachHang";
            this.Text = "frmThongKeKhachHang";
            this.Load += new System.EventHandler(this.frmThongKeKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView dataKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn maGianhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiGianBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiGianKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienDatCoc;
    }
}