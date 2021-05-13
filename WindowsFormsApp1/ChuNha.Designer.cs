namespace WindowsFormsApp1
{
    partial class ChuNha
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thôngTinCaNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chinhSưaThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đôiMâtKhâuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuâtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.câpNhâtNhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhaThuêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhaBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.TrChap = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCaNhânToolStripMenuItem,
            this.câpNhâtNhaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1006, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thôngTinCaNhânToolStripMenuItem
            // 
            this.thôngTinCaNhânToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chinhSưaThôngTinToolStripMenuItem,
            this.đôiMâtKhâuToolStripMenuItem,
            this.đăngXuâtToolStripMenuItem});
            this.thôngTinCaNhânToolStripMenuItem.Name = "thôngTinCaNhânToolStripMenuItem";
            this.thôngTinCaNhânToolStripMenuItem.Size = new System.Drawing.Size(52, 26);
            this.thôngTinCaNhânToolStripMenuItem.Text = "User";
            // 
            // chinhSưaThôngTinToolStripMenuItem
            // 
            this.chinhSưaThôngTinToolStripMenuItem.Name = "chinhSưaThôngTinToolStripMenuItem";
            this.chinhSưaThôngTinToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.chinhSưaThôngTinToolStripMenuItem.Text = "&Chỉnh sửa thông tin";
            // 
            // đôiMâtKhâuToolStripMenuItem
            // 
            this.đôiMâtKhâuToolStripMenuItem.Name = "đôiMâtKhâuToolStripMenuItem";
            this.đôiMâtKhâuToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.đôiMâtKhâuToolStripMenuItem.Text = "&Đổi mật khẩu";
            // 
            // đăngXuâtToolStripMenuItem
            // 
            this.đăngXuâtToolStripMenuItem.Name = "đăngXuâtToolStripMenuItem";
            this.đăngXuâtToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.đăngXuâtToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.đăngXuâtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuâtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuâtToolStripMenuItem_Click);
            // 
            // câpNhâtNhaToolStripMenuItem
            // 
            this.câpNhâtNhaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhaThuêToolStripMenuItem,
            this.nhaBanToolStripMenuItem});
            this.câpNhâtNhaToolStripMenuItem.Name = "câpNhâtNhaToolStripMenuItem";
            this.câpNhâtNhaToolStripMenuItem.Size = new System.Drawing.Size(110, 26);
            this.câpNhâtNhaToolStripMenuItem.Text = "Cập nhật nhà";
            // 
            // nhaThuêToolStripMenuItem
            // 
            this.nhaThuêToolStripMenuItem.Name = "nhaThuêToolStripMenuItem";
            this.nhaThuêToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.nhaThuêToolStripMenuItem.Text = "Nhà &Thuê";
            this.nhaThuêToolStripMenuItem.Click += new System.EventHandler(this.nhaThuêToolStripMenuItem_Click);
            // 
            // nhaBanToolStripMenuItem
            // 
            this.nhaBanToolStripMenuItem.Name = "nhaBanToolStripMenuItem";
            this.nhaBanToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.nhaBanToolStripMenuItem.Text = "Nhà &Bán";
            this.nhaBanToolStripMenuItem.Click += new System.EventHandler(this.nhaBanToolStripMenuItem_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 58);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(778, 441);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(836, 372);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 82);
            this.button1.TabIndex = 2;
            this.button1.Text = "Xem Nhận Xét";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TrChap
            // 
            this.TrChap.AutoSize = true;
            this.TrChap.Location = new System.Drawing.Point(846, 330);
            this.TrChap.Name = "TrChap";
            this.TrChap.Size = new System.Drawing.Size(105, 21);
            this.TrChap.TabIndex = 3;
            this.TrChap.Text = "Tranh Chấp";
            this.TrChap.UseVisualStyleBackColor = true;
            // 
            // ChuNha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1006, 509);
            this.Controls.Add(this.TrChap);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ChuNha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chủ nhà";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCaNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chinhSưaThôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đôiMâtKhâuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem câpNhâtNhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuâtToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem nhaThuêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhaBanToolStripMenuItem;
        private System.Windows.Forms.CheckBox TrChap;
    }
}

