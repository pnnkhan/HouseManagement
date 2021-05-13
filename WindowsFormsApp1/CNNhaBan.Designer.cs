namespace WindowsFormsApp1
{
    partial class FrmCNNhaBan
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
            this.dgvNhaBan = new System.Windows.Forms.DataGridView();
            this.Them1 = new System.Windows.Forms.Button();
            this.Sua1 = new System.Windows.Forms.Button();
            this.Xoa1 = new System.Windows.Forms.Button();
            this.Luu1 = new System.Windows.Forms.Button();
            this.Bo1 = new System.Windows.Forms.Button();
            this.MaNha = new System.Windows.Forms.Label();
            this.MaCN = new System.Windows.Forms.Label();
            this.txtMaLoai = new System.Windows.Forms.Label();
            this.MaChuNha = new System.Windows.Forms.Label();
            this.MaNV = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMaNha = new System.Windows.Forms.TextBox();
            this.txtMaChuNha = new System.Windows.Forms.TextBox();
            this.txtLoaiNha = new System.Windows.Forms.TextBox();
            this.txtMaCN = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtDV = new System.Windows.Forms.TextBox();
            this.txtTT = new System.Windows.Forms.TextBox();
            this.txtNgayDang = new System.Windows.Forms.TextBox();
            this.txtNgayHetHan = new System.Windows.Forms.TextBox();
            this.txtSLXem = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.txtDK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaBan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNhaBan
            // 
            this.dgvNhaBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhaBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhaBan.Location = new System.Drawing.Point(19, 191);
            this.dgvNhaBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvNhaBan.Name = "dgvNhaBan";
            this.dgvNhaBan.RowHeadersWidth = 62;
            this.dgvNhaBan.RowTemplate.Height = 28;
            this.dgvNhaBan.Size = new System.Drawing.Size(1006, 348);
            this.dgvNhaBan.TabIndex = 0;
            this.dgvNhaBan.Click += new System.EventHandler(this.dgvNhaBan_Click);
            // 
            // Them1
            // 
            this.Them1.Location = new System.Drawing.Point(56, 552);
            this.Them1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Them1.Name = "Them1";
            this.Them1.Size = new System.Drawing.Size(67, 30);
            this.Them1.TabIndex = 1;
            this.Them1.Text = "Thêm";
            this.Them1.UseVisualStyleBackColor = true;
            this.Them1.Click += new System.EventHandler(this.Them1_Click);
            // 
            // Sua1
            // 
            this.Sua1.Location = new System.Drawing.Point(245, 552);
            this.Sua1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sua1.Name = "Sua1";
            this.Sua1.Size = new System.Drawing.Size(67, 30);
            this.Sua1.TabIndex = 2;
            this.Sua1.Text = "Sửa";
            this.Sua1.UseVisualStyleBackColor = true;
            this.Sua1.Click += new System.EventHandler(this.Sua1_Click);
            // 
            // Xoa1
            // 
            this.Xoa1.Location = new System.Drawing.Point(467, 552);
            this.Xoa1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Xoa1.Name = "Xoa1";
            this.Xoa1.Size = new System.Drawing.Size(67, 30);
            this.Xoa1.TabIndex = 3;
            this.Xoa1.Text = "Xóa";
            this.Xoa1.UseVisualStyleBackColor = true;
            this.Xoa1.Click += new System.EventHandler(this.Xoa1_Click);
            // 
            // Luu1
            // 
            this.Luu1.Location = new System.Drawing.Point(700, 552);
            this.Luu1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Luu1.Name = "Luu1";
            this.Luu1.Size = new System.Drawing.Size(67, 30);
            this.Luu1.TabIndex = 4;
            this.Luu1.Text = "Lưu";
            this.Luu1.UseVisualStyleBackColor = true;
            this.Luu1.Click += new System.EventHandler(this.Luu1_Click);
            // 
            // Bo1
            // 
            this.Bo1.Location = new System.Drawing.Point(892, 552);
            this.Bo1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bo1.Name = "Bo1";
            this.Bo1.Size = new System.Drawing.Size(67, 30);
            this.Bo1.TabIndex = 5;
            this.Bo1.Text = "Bỏ Qua";
            this.Bo1.UseVisualStyleBackColor = true;
            this.Bo1.Click += new System.EventHandler(this.Bo1_Click);
            // 
            // MaNha
            // 
            this.MaNha.AutoSize = true;
            this.MaNha.Location = new System.Drawing.Point(52, 22);
            this.MaNha.Name = "MaNha";
            this.MaNha.Size = new System.Drawing.Size(53, 17);
            this.MaNha.TabIndex = 6;
            this.MaNha.Text = "MaNha";
            // 
            // MaCN
            // 
            this.MaCN.AutoSize = true;
            this.MaCN.Location = new System.Drawing.Point(221, 22);
            this.MaCN.Name = "MaCN";
            this.MaCN.Size = new System.Drawing.Size(46, 17);
            this.MaCN.TabIndex = 7;
            this.MaCN.Text = "MaCN";
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.AutoSize = true;
            this.txtMaLoai.Location = new System.Drawing.Point(370, 22);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(61, 17);
            this.txtMaLoai.TabIndex = 8;
            this.txtMaLoai.Text = "LoaiNha";
            // 
            // MaChuNha
            // 
            this.MaChuNha.AutoSize = true;
            this.MaChuNha.Location = new System.Drawing.Point(540, 22);
            this.MaChuNha.Name = "MaChuNha";
            this.MaChuNha.Size = new System.Drawing.Size(78, 17);
            this.MaChuNha.TabIndex = 9;
            this.MaChuNha.Text = "MaChuNha";
            // 
            // MaNV
            // 
            this.MaNV.AutoSize = true;
            this.MaNV.Location = new System.Drawing.Point(721, 22);
            this.MaNV.Name = "MaNV";
            this.MaNV.Size = new System.Drawing.Size(46, 17);
            this.MaNV.TabIndex = 10;
            this.MaNV.Text = "MaNV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Định Vị";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tình Trạng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(287, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Ngày Đăng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(523, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Ngày Hết Hạn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Giá Bán";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(221, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "Số Phòng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(771, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 17);
            this.label12.TabIndex = 17;
            this.label12.Text = "Lượt Xem";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(380, 151);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 17);
            this.label13.TabIndex = 18;
            this.label13.Text = "Điều kiện";
            // 
            // txtMaNha
            // 
            this.txtMaNha.Location = new System.Drawing.Point(111, 18);
            this.txtMaNha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNha.Name = "txtMaNha";
            this.txtMaNha.Size = new System.Drawing.Size(89, 22);
            this.txtMaNha.TabIndex = 19;
            // 
            // txtMaChuNha
            // 
            this.txtMaChuNha.Location = new System.Drawing.Point(625, 18);
            this.txtMaChuNha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaChuNha.Name = "txtMaChuNha";
            this.txtMaChuNha.Size = new System.Drawing.Size(89, 22);
            this.txtMaChuNha.TabIndex = 20;
            // 
            // txtLoaiNha
            // 
            this.txtLoaiNha.Location = new System.Drawing.Point(436, 18);
            this.txtLoaiNha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLoaiNha.Name = "txtLoaiNha";
            this.txtLoaiNha.Size = new System.Drawing.Size(89, 22);
            this.txtLoaiNha.TabIndex = 21;
            // 
            // txtMaCN
            // 
            this.txtMaCN.Location = new System.Drawing.Point(274, 18);
            this.txtMaCN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaCN.Name = "txtMaCN";
            this.txtMaCN.Size = new System.Drawing.Size(89, 22);
            this.txtMaCN.TabIndex = 22;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(774, 18);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(89, 22);
            this.txtMaNV.TabIndex = 23;
            // 
            // txtDV
            // 
            this.txtDV.Location = new System.Drawing.Point(122, 62);
            this.txtDV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDV.Name = "txtDV";
            this.txtDV.Size = new System.Drawing.Size(813, 22);
            this.txtDV.TabIndex = 24;
            // 
            // txtTT
            // 
            this.txtTT.Location = new System.Drawing.Point(132, 106);
            this.txtTT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTT.Name = "txtTT";
            this.txtTT.Size = new System.Drawing.Size(150, 22);
            this.txtTT.TabIndex = 25;
            // 
            // txtNgayDang
            // 
            this.txtNgayDang.Location = new System.Drawing.Point(371, 106);
            this.txtNgayDang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNgayDang.Name = "txtNgayDang";
            this.txtNgayDang.Size = new System.Drawing.Size(114, 22);
            this.txtNgayDang.TabIndex = 26;
            // 
            // txtNgayHetHan
            // 
            this.txtNgayHetHan.Location = new System.Drawing.Point(625, 106);
            this.txtNgayHetHan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNgayHetHan.Name = "txtNgayHetHan";
            this.txtNgayHetHan.Size = new System.Drawing.Size(116, 22);
            this.txtNgayHetHan.TabIndex = 27;
            // 
            // txtSLXem
            // 
            this.txtSLXem.Location = new System.Drawing.Point(845, 106);
            this.txtSLXem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSLXem.Name = "txtSLXem";
            this.txtSLXem.Size = new System.Drawing.Size(89, 22);
            this.txtSLXem.TabIndex = 28;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(122, 146);
            this.txtGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(102, 22);
            this.txtGia.TabIndex = 29;
            // 
            // txtPhong
            // 
            this.txtPhong.Location = new System.Drawing.Point(291, 146);
            this.txtPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(89, 22);
            this.txtPhong.TabIndex = 30;
            // 
            // txtDK
            // 
            this.txtDK.Location = new System.Drawing.Point(452, 146);
            this.txtDK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDK.Name = "txtDK";
            this.txtDK.Size = new System.Drawing.Size(483, 22);
            this.txtDK.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(868, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "MaKH";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(921, 18);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(89, 22);
            this.txtMaKH.TabIndex = 33;
            // 
            // FrmCNNhaBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1067, 591);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDK);
            this.Controls.Add(this.txtPhong);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtSLXem);
            this.Controls.Add(this.txtNgayHetHan);
            this.Controls.Add(this.txtNgayDang);
            this.Controls.Add(this.txtTT);
            this.Controls.Add(this.txtDV);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.txtMaCN);
            this.Controls.Add(this.txtLoaiNha);
            this.Controls.Add(this.txtMaChuNha);
            this.Controls.Add(this.txtMaNha);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MaNV);
            this.Controls.Add(this.MaChuNha);
            this.Controls.Add(this.txtMaLoai);
            this.Controls.Add(this.MaCN);
            this.Controls.Add(this.MaNha);
            this.Controls.Add(this.Bo1);
            this.Controls.Add(this.Luu1);
            this.Controls.Add(this.Xoa1);
            this.Controls.Add(this.Sua1);
            this.Controls.Add(this.Them1);
            this.Controls.Add(this.dgvNhaBan);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmCNNhaBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật nhà bán";
            this.Load += new System.EventHandler(this.FrmCNNhaBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNhaBan;
        private System.Windows.Forms.Button Them1;
        private System.Windows.Forms.Button Sua1;
        private System.Windows.Forms.Button Xoa1;
        private System.Windows.Forms.Button Luu1;
        private System.Windows.Forms.Button Bo1;
        private System.Windows.Forms.Label MaNha;
        private System.Windows.Forms.Label MaCN;
        private System.Windows.Forms.Label txtMaLoai;
        private System.Windows.Forms.Label MaChuNha;
        private System.Windows.Forms.Label MaNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMaNha;
        private System.Windows.Forms.TextBox txtMaChuNha;
        private System.Windows.Forms.TextBox txtLoaiNha;
        private System.Windows.Forms.TextBox txtMaCN;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtDV;
        private System.Windows.Forms.TextBox txtTT;
        private System.Windows.Forms.TextBox txtNgayDang;
        private System.Windows.Forms.TextBox txtNgayHetHan;
        private System.Windows.Forms.TextBox txtSLXem;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.TextBox txtDK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaKH;
    }
}