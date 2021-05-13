namespace WindowsFormsApp1
{
	partial class NVBDS
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThongTinCaNhanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Doi_MatKhauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DangXuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Them_KhachHangToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.XoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Xoa_KhachHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CapNhatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CN_KhachHangToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.TinhTrangNhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChucNangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DatLichToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TimKiemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tim_KhachHangToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.Tim_NhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.XemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Xem_NhaBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Xem_NhaThueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trChap = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.trChap);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 405);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(865, 348);
            this.dataGridView1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.ChucNangToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(889, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThongTinCaNhanToolStripMenuItem,
            this.Doi_MatKhauToolStripMenuItem,
            this.DangXuatToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(52, 26);
            this.fileToolStripMenuItem.Text = "User";
            // 
            // ThongTinCaNhanToolStripMenuItem
            // 
            this.ThongTinCaNhanToolStripMenuItem.Name = "ThongTinCaNhanToolStripMenuItem";
            this.ThongTinCaNhanToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.ThongTinCaNhanToolStripMenuItem.Text = "Thông tin cá nhân";
            this.ThongTinCaNhanToolStripMenuItem.Click += new System.EventHandler(this.ThongTinCaNhanToolStripMenuItem_Click);
            // 
            // Doi_MatKhauToolStripMenuItem
            // 
            this.Doi_MatKhauToolStripMenuItem.Name = "Doi_MatKhauToolStripMenuItem";
            this.Doi_MatKhauToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.Doi_MatKhauToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // DangXuatToolStripMenuItem
            // 
            this.DangXuatToolStripMenuItem.Name = "DangXuatToolStripMenuItem";
            this.DangXuatToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.DangXuatToolStripMenuItem.Text = "Đăng xuất";
            this.DangXuatToolStripMenuItem.Click += new System.EventHandler(this.DangXuatToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThemToolStripMenuItem,
            this.XoaToolStripMenuItem,
            this.CapNhatToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(87, 26);
            this.editToolStripMenuItem.Text = "Chỉnh sửa";
            // 
            // ThemToolStripMenuItem
            // 
            this.ThemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Them_KhachHangToolStripMenuItem1});
            this.ThemToolStripMenuItem.Name = "ThemToolStripMenuItem";
            this.ThemToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.ThemToolStripMenuItem.Text = "Thêm";
            // 
            // Them_KhachHangToolStripMenuItem1
            // 
            this.Them_KhachHangToolStripMenuItem1.Name = "Them_KhachHangToolStripMenuItem1";
            this.Them_KhachHangToolStripMenuItem1.Size = new System.Drawing.Size(169, 26);
            this.Them_KhachHangToolStripMenuItem1.Text = "Khách hàng";
            // 
            // XoaToolStripMenuItem
            // 
            this.XoaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Xoa_KhachHangToolStripMenuItem});
            this.XoaToolStripMenuItem.Name = "XoaToolStripMenuItem";
            this.XoaToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.XoaToolStripMenuItem.Text = "Xóa";
            // 
            // Xoa_KhachHangToolStripMenuItem
            // 
            this.Xoa_KhachHangToolStripMenuItem.Name = "Xoa_KhachHangToolStripMenuItem";
            this.Xoa_KhachHangToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.Xoa_KhachHangToolStripMenuItem.Text = "Khách hàng";
            // 
            // CapNhatToolStripMenuItem
            // 
            this.CapNhatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CN_KhachHangToolStripMenuItem2,
            this.TinhTrangNhaToolStripMenuItem});
            this.CapNhatToolStripMenuItem.Name = "CapNhatToolStripMenuItem";
            this.CapNhatToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.CapNhatToolStripMenuItem.Text = "Cập nhật";
            // 
            // CN_KhachHangToolStripMenuItem2
            // 
            this.CN_KhachHangToolStripMenuItem2.Name = "CN_KhachHangToolStripMenuItem2";
            this.CN_KhachHangToolStripMenuItem2.Size = new System.Drawing.Size(187, 26);
            this.CN_KhachHangToolStripMenuItem2.Text = "Khách hàng";
            this.CN_KhachHangToolStripMenuItem2.Click += new System.EventHandler(this.CN_KhachHangToolStripMenuItem2_Click);
            // 
            // TinhTrangNhaToolStripMenuItem
            // 
            this.TinhTrangNhaToolStripMenuItem.Name = "TinhTrangNhaToolStripMenuItem";
            this.TinhTrangNhaToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.TinhTrangNhaToolStripMenuItem.Text = "Tình trạng nhà";
            this.TinhTrangNhaToolStripMenuItem.Click += new System.EventHandler(this.TinhTrangNhaToolStripMenuItem_Click);
            // 
            // ChucNangToolStripMenuItem
            // 
            this.ChucNangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DatLichToolStripMenuItem,
            this.TimKiemToolStripMenuItem,
            this.XemToolStripMenuItem});
            this.ChucNangToolStripMenuItem.Name = "ChucNangToolStripMenuItem";
            this.ChucNangToolStripMenuItem.Size = new System.Drawing.Size(93, 26);
            this.ChucNangToolStripMenuItem.Text = "Chức năng";
            // 
            // DatLichToolStripMenuItem
            // 
            this.DatLichToolStripMenuItem.Name = "DatLichToolStripMenuItem";
            this.DatLichToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.DatLichToolStripMenuItem.Text = "Đặt lịch";
            // 
            // TimKiemToolStripMenuItem
            // 
            this.TimKiemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tim_KhachHangToolStripMenuItem3,
            this.Tim_NhaToolStripMenuItem});
            this.TimKiemToolStripMenuItem.Name = "TimKiemToolStripMenuItem";
            this.TimKiemToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.TimKiemToolStripMenuItem.Text = "Tìm kiếm";
            // 
            // Tim_KhachHangToolStripMenuItem3
            // 
            this.Tim_KhachHangToolStripMenuItem3.Name = "Tim_KhachHangToolStripMenuItem3";
            this.Tim_KhachHangToolStripMenuItem3.Size = new System.Drawing.Size(169, 26);
            this.Tim_KhachHangToolStripMenuItem3.Text = "Khách hàng";
            this.Tim_KhachHangToolStripMenuItem3.Click += new System.EventHandler(this.Tim_KhachHangToolStripMenuItem3_Click);
            // 
            // Tim_NhaToolStripMenuItem
            // 
            this.Tim_NhaToolStripMenuItem.Name = "Tim_NhaToolStripMenuItem";
            this.Tim_NhaToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.Tim_NhaToolStripMenuItem.Text = "Nhà";
            this.Tim_NhaToolStripMenuItem.Click += new System.EventHandler(this.Tim_NhaToolStripMenuItem_Click);
            // 
            // XemToolStripMenuItem
            // 
            this.XemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Xem_NhaBanToolStripMenuItem,
            this.Xem_NhaThueToolStripMenuItem});
            this.XemToolStripMenuItem.Name = "XemToolStripMenuItem";
            this.XemToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.XemToolStripMenuItem.Text = "Xem";
            // 
            // Xem_NhaBanToolStripMenuItem
            // 
            this.Xem_NhaBanToolStripMenuItem.Name = "Xem_NhaBanToolStripMenuItem";
            this.Xem_NhaBanToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.Xem_NhaBanToolStripMenuItem.Text = "Thông tin nhà bán";
            this.Xem_NhaBanToolStripMenuItem.Click += new System.EventHandler(this.Xem_NhaBanToolStripMenuItem_Click);
            // 
            // Xem_NhaThueToolStripMenuItem
            // 
            this.Xem_NhaThueToolStripMenuItem.Name = "Xem_NhaThueToolStripMenuItem";
            this.Xem_NhaThueToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.Xem_NhaThueToolStripMenuItem.Text = "Thông tin nhà thuê";
            this.Xem_NhaThueToolStripMenuItem.Click += new System.EventHandler(this.Xem_NhaThueToolStripMenuItem_Click);
            // 
            // trChap
            // 
            this.trChap.AutoSize = true;
            this.trChap.Location = new System.Drawing.Point(728, 13);
            this.trChap.Name = "trChap";
            this.trChap.Size = new System.Drawing.Size(111, 21);
            this.trChap.TabIndex = 2;
            this.trChap.Text = "Tranh Chấp";
            this.trChap.UseVisualStyleBackColor = true;
            // 
            // NVBDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 405);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "NVBDS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLNHA";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Them_KhachHangToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem XoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Xoa_KhachHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChucNangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TimKiemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem XemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Xem_NhaBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Xem_NhaThueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThongTinCaNhanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Doi_MatKhauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CapNhatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CN_KhachHangToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem DangXuatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DatLichToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Tim_KhachHangToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem Tim_NhaToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem TinhTrangNhaToolStripMenuItem;
        private System.Windows.Forms.CheckBox trChap;
    }
}

