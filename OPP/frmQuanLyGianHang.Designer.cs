
namespace OPP
{
    partial class frmQuanLyGianHang
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
            if (disposing && (components != null))
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbLoaiGianHang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.dataGianHang = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.maGianHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienTich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viTriGianhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTranThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soBanGhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soQuatLamMat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chatLieuVachNgan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chatLieuMaiChe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThemGianHang = new Guna.UI2.WinForms.Guna2Button();
            this.btnSuaGianHang = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaGianHang = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGianHang)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2Button4);
            this.guna2Panel1.Controls.Add(this.txtTimKiem);
            this.guna2Panel1.Controls.Add(this.cbLoaiGianHang);
            this.guna2Panel1.Controls.Add(this.materialLabel1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(917, 43);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2Button4
            // 
            this.guna2Button4.CheckedState.Parent = this.guna2Button4;
            this.guna2Button4.CustomImages.Parent = this.guna2Button4;
            this.guna2Button4.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.Parent = this.guna2Button4;
            this.guna2Button4.Location = new System.Drawing.Point(818, 0);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Size = new System.Drawing.Size(99, 43);
            this.guna2Button4.TabIndex = 3;
            this.guna2Button4.Text = "Tìm kiếm";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.Parent = this.txtTimKiem;
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.FocusedState.Parent = this.txtTimKiem;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.HoverState.Parent = this.txtTimKiem;
            this.txtTimKiem.Location = new System.Drawing.Point(535, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderText = "Nhập vào mã gian hàng";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.ShadowDecoration.Parent = this.txtTimKiem;
            this.txtTimKiem.Size = new System.Drawing.Size(277, 36);
            this.txtTimKiem.TabIndex = 2;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // cbLoaiGianHang
            // 
            this.cbLoaiGianHang.BackColor = System.Drawing.Color.Transparent;
            this.cbLoaiGianHang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLoaiGianHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiGianHang.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLoaiGianHang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLoaiGianHang.FocusedState.Parent = this.cbLoaiGianHang;
            this.cbLoaiGianHang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbLoaiGianHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbLoaiGianHang.HoverState.Parent = this.cbLoaiGianHang;
            this.cbLoaiGianHang.ItemHeight = 30;
            this.cbLoaiGianHang.Items.AddRange(new object[] {
            "Tất cả gian hàng",
            "Gian hàng cao cấp",
            "Gian hàng tiêu chuẩn"});
            this.cbLoaiGianHang.ItemsAppearance.Parent = this.cbLoaiGianHang;
            this.cbLoaiGianHang.Location = new System.Drawing.Point(129, 3);
            this.cbLoaiGianHang.Name = "cbLoaiGianHang";
            this.cbLoaiGianHang.ShadowDecoration.Parent = this.cbLoaiGianHang;
            this.cbLoaiGianHang.Size = new System.Drawing.Size(267, 36);
            this.cbLoaiGianHang.StartIndex = 0;
            this.cbLoaiGianHang.TabIndex = 1;
            this.cbLoaiGianHang.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(12, 12);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(111, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Loại gian hàng:";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.dataGianHang);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 43);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(917, 562);
            this.guna2Panel2.TabIndex = 1;
            // 
            // dataGianHang
            // 
            this.dataGianHang.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGianHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGianHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGianHang.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGianHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGianHang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGianHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGianHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGianHang.ColumnHeadersHeight = 40;
            this.dataGianHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maGianHang,
            this.dienTich,
            this.viTriGianhang,
            this.TinhTranThue,
            this.soBanGhe,
            this.soQuatLamMat,
            this.chatLieuVachNgan,
            this.chatLieuMaiChe});
            this.dataGianHang.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataGianHang.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGianHang.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGianHang.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGianHang.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGianHang.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataGianHang.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGianHang.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataGianHang.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataGianHang.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGianHang.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dataGianHang.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGianHang.CurrentTheme.Name = null;
            this.dataGianHang.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGianHang.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGianHang.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGianHang.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGianHang.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGianHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGianHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGianHang.EnableHeadersVisualStyles = false;
            this.dataGianHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGianHang.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGianHang.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGianHang.HeaderForeColor = System.Drawing.Color.White;
            this.dataGianHang.Location = new System.Drawing.Point(0, 0);
            this.dataGianHang.Name = "dataGianHang";
            this.dataGianHang.ReadOnly = true;
            this.dataGianHang.RowHeadersVisible = false;
            this.dataGianHang.RowTemplate.Height = 40;
            this.dataGianHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGianHang.Size = new System.Drawing.Size(917, 562);
            this.dataGianHang.TabIndex = 0;
            this.dataGianHang.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dataGianHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGianHang_CellContentClick_1);
            // 
            // maGianHang
            // 
            this.maGianHang.HeaderText = "Mã gian hàng";
            this.maGianHang.Name = "maGianHang";
            this.maGianHang.ReadOnly = true;
            // 
            // dienTich
            // 
            this.dienTich.HeaderText = "Diện tích";
            this.dienTich.Name = "dienTich";
            this.dienTich.ReadOnly = true;
            // 
            // viTriGianhang
            // 
            this.viTriGianhang.HeaderText = "Vị trí gian hàng";
            this.viTriGianhang.Name = "viTriGianhang";
            this.viTriGianhang.ReadOnly = true;
            // 
            // TinhTranThue
            // 
            this.TinhTranThue.HeaderText = "Tình trạng thuê";
            this.TinhTranThue.Name = "TinhTranThue";
            this.TinhTranThue.ReadOnly = true;
            // 
            // soBanGhe
            // 
            this.soBanGhe.HeaderText = "Số bàn ghế";
            this.soBanGhe.Name = "soBanGhe";
            this.soBanGhe.ReadOnly = true;
            // 
            // soQuatLamMat
            // 
            this.soQuatLamMat.HeaderText = "Số quạt làm mát";
            this.soQuatLamMat.Name = "soQuatLamMat";
            this.soQuatLamMat.ReadOnly = true;
            // 
            // chatLieuVachNgan
            // 
            this.chatLieuVachNgan.HeaderText = "Chất liệu vách ngăn";
            this.chatLieuVachNgan.Name = "chatLieuVachNgan";
            this.chatLieuVachNgan.ReadOnly = true;
            // 
            // chatLieuMaiChe
            // 
            this.chatLieuMaiChe.HeaderText = "Chất liệu mái che";
            this.chatLieuMaiChe.Name = "chatLieuMaiChe";
            this.chatLieuMaiChe.ReadOnly = true;
            // 
            // btnThemGianHang
            // 
            this.btnThemGianHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemGianHang.CheckedState.Parent = this.btnThemGianHang;
            this.btnThemGianHang.CustomImages.Parent = this.btnThemGianHang;
            this.btnThemGianHang.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemGianHang.ForeColor = System.Drawing.Color.White;
            this.btnThemGianHang.HoverState.Parent = this.btnThemGianHang;
            this.btnThemGianHang.Location = new System.Drawing.Point(296, 10);
            this.btnThemGianHang.Name = "btnThemGianHang";
            this.btnThemGianHang.ShadowDecoration.Parent = this.btnThemGianHang;
            this.btnThemGianHang.Size = new System.Drawing.Size(197, 45);
            this.btnThemGianHang.TabIndex = 0;
            this.btnThemGianHang.Text = "Thêm gian hàng";
            this.btnThemGianHang.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnSuaGianHang
            // 
            this.btnSuaGianHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuaGianHang.CheckedState.Parent = this.btnSuaGianHang;
            this.btnSuaGianHang.CustomImages.Parent = this.btnSuaGianHang;
            this.btnSuaGianHang.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaGianHang.ForeColor = System.Drawing.Color.White;
            this.btnSuaGianHang.HoverState.Parent = this.btnSuaGianHang;
            this.btnSuaGianHang.Location = new System.Drawing.Point(518, 10);
            this.btnSuaGianHang.Name = "btnSuaGianHang";
            this.btnSuaGianHang.ShadowDecoration.Parent = this.btnSuaGianHang;
            this.btnSuaGianHang.Size = new System.Drawing.Size(180, 45);
            this.btnSuaGianHang.TabIndex = 1;
            this.btnSuaGianHang.Text = "Sửa gian hàng";
            this.btnSuaGianHang.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // btnXoaGianHang
            // 
            this.btnXoaGianHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaGianHang.CheckedState.Parent = this.btnXoaGianHang;
            this.btnXoaGianHang.CustomImages.Parent = this.btnXoaGianHang;
            this.btnXoaGianHang.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaGianHang.ForeColor = System.Drawing.Color.White;
            this.btnXoaGianHang.HoverState.Parent = this.btnXoaGianHang;
            this.btnXoaGianHang.Location = new System.Drawing.Point(725, 10);
            this.btnXoaGianHang.Name = "btnXoaGianHang";
            this.btnXoaGianHang.ShadowDecoration.Parent = this.btnXoaGianHang;
            this.btnXoaGianHang.Size = new System.Drawing.Size(180, 45);
            this.btnXoaGianHang.TabIndex = 2;
            this.btnXoaGianHang.Text = "Xóa gian hàng";
            this.btnXoaGianHang.Click += new System.EventHandler(this.btnXoaGianHang_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.btnXoaGianHang);
            this.guna2Panel3.Controls.Add(this.btnSuaGianHang);
            this.guna2Panel3.Controls.Add(this.btnThemGianHang);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 547);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(917, 58);
            this.guna2Panel3.TabIndex = 2;
            // 
            // frmStatistical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 605);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStatistical";
            this.Text = "frmStatistical";
            this.Load += new System.EventHandler(this.frmStatistical_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGianHang)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2ComboBox cbLoaiGianHang;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnThemGianHang;
        private Guna.UI2.WinForms.Guna2Button btnSuaGianHang;
        private Guna.UI2.WinForms.Guna2Button btnXoaGianHang;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        public Bunifu.UI.WinForms.BunifuDataGridView dataGianHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn maGianHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienTich;
        private System.Windows.Forms.DataGridViewTextBoxColumn viTriGianhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTranThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn soBanGhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn soQuatLamMat;
        private System.Windows.Forms.DataGridViewTextBoxColumn chatLieuVachNgan;
        private System.Windows.Forms.DataGridViewTextBoxColumn chatLieuMaiChe;
    }
}