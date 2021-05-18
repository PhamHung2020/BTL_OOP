
namespace GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKeKhachHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.dataKhachHang = new Guna.UI2.WinForms.Guna2DataGridView();
            this.maKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maGianhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.dataKhachHang);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(917, 605);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // dataKhachHang
            // 
            this.dataKhachHang.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dataKhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataKhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dataKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataKhachHang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataKhachHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataKhachHang.ColumnHeadersHeight = 55;
            this.dataKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKhachHang,
            this.tenKhachHang,
            this.diaChi,
            this.maGianhang,
            this.tgBD,
            this.tgKT,
            this.tien});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataKhachHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataKhachHang.EnableHeadersVisualStyles = false;
            this.dataKhachHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dataKhachHang.Location = new System.Drawing.Point(0, 0);
            this.dataKhachHang.Name = "dataKhachHang";
            this.dataKhachHang.ReadOnly = true;
            this.dataKhachHang.RowHeadersVisible = false;
            this.dataKhachHang.RowTemplate.Height = 40;
            this.dataKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataKhachHang.Size = new System.Drawing.Size(917, 605);
            this.dataKhachHang.TabIndex = 0;
            this.dataKhachHang.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.dataKhachHang.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dataKhachHang.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataKhachHang.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataKhachHang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataKhachHang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataKhachHang.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataKhachHang.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dataKhachHang.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.dataKhachHang.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataKhachHang.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataKhachHang.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataKhachHang.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataKhachHang.ThemeStyle.HeaderStyle.Height = 55;
            this.dataKhachHang.ThemeStyle.ReadOnly = true;
            this.dataKhachHang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.dataKhachHang.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataKhachHang.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataKhachHang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataKhachHang.ThemeStyle.RowsStyle.Height = 40;
            this.dataKhachHang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.dataKhachHang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // maKhachHang
            // 
            this.maKhachHang.HeaderText = "Mã khách hàng";
            this.maKhachHang.Name = "maKhachHang";
            this.maKhachHang.ReadOnly = true;
            // 
            // tenKhachHang
            // 
            this.tenKhachHang.HeaderText = "Tên khách hàng";
            this.tenKhachHang.Name = "tenKhachHang";
            this.tenKhachHang.ReadOnly = true;
            // 
            // diaChi
            // 
            this.diaChi.HeaderText = "Địa chỉ";
            this.diaChi.Name = "diaChi";
            this.diaChi.ReadOnly = true;
            // 
            // maGianhang
            // 
            this.maGianhang.HeaderText = "Mã gian hàng";
            this.maGianhang.Name = "maGianhang";
            this.maGianhang.ReadOnly = true;
            // 
            // tgBD
            // 
            this.tgBD.HeaderText = "Thời gian bắt đầu thuê";
            this.tgBD.Name = "tgBD";
            this.tgBD.ReadOnly = true;
            // 
            // tgKT
            // 
            this.tgKT.HeaderText = "Thời gian kết thúc thuê";
            this.tgKT.Name = "tgKT";
            this.tgKT.ReadOnly = true;
            // 
            // tien
            // 
            this.tien.HeaderText = "Tiền đặt cọc";
            this.tien.Name = "tien";
            this.tien.ReadOnly = true;
            // 
            // frmThongKeKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 605);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThongKeKhachHang";
            this.Text = "frmThongKeKhachHang";
            this.Load += new System.EventHandler(this.frmThongKeKhachHang_Load);
            this.bunifuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Guna.UI2.WinForms.Guna2DataGridView dataKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn maGianhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn tien;
    }
}