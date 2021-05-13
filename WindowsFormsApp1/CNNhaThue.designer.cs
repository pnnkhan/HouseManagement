namespace WindowsFormsApp1
{
    partial class frmCNNhaThue
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
            this.dgvNhaThue = new System.Windows.Forms.DataGridView();
            this.Them1 = new System.Windows.Forms.Button();
            this.Sua1 = new System.Windows.Forms.Button();
            this.Xoa1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMaNha = new System.Windows.Forms.TextBox();
            this.txtMaCN = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtTT = new System.Windows.Forms.TextBox();
            this.txtDV = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.txtSLXem = new System.Windows.Forms.TextBox();
            this.txtPhongCon = new System.Windows.Forms.TextBox();
            this.Luu1 = new System.Windows.Forms.Button();
            this.Bo1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMaChuNha = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            this.txtNgayHetHan = new System.Windows.Forms.TextBox();
            this.txtNgayDang = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaThue)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNhaThue
            // 
            this.dgvNhaThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhaThue.Location = new System.Drawing.Point(24, 250);
            this.dgvNhaThue.Name = "dgvNhaThue";
            this.dgvNhaThue.RowHeadersWidth = 62;
            this.dgvNhaThue.RowTemplate.Height = 28;
            this.dgvNhaThue.Size = new System.Drawing.Size(1170, 424);
            this.dgvNhaThue.TabIndex = 0;
            this.dgvNhaThue.Click += new System.EventHandler(this.dgvNhaThue_Click);
            // 
            // Them1
            // 
            this.Them1.Location = new System.Drawing.Point(49, 702);
            this.Them1.Name = "Them1";
            this.Them1.Size = new System.Drawing.Size(175, 42);
            this.Them1.TabIndex = 1;
            this.Them1.Text = "Thêm";
            this.Them1.UseVisualStyleBackColor = true;
            this.Them1.Click += new System.EventHandler(this.Them1_Click);
            // 
            // Sua1
            // 
            this.Sua1.Location = new System.Drawing.Point(257, 702);
            this.Sua1.Name = "Sua1";
            this.Sua1.Size = new System.Drawing.Size(193, 42);
            this.Sua1.TabIndex = 2;
            this.Sua1.Text = "Sửa";
            this.Sua1.UseVisualStyleBackColor = true;
            this.Sua1.Click += new System.EventHandler(this.Sua1_Click);
            // 
            // Xoa1
            // 
            this.Xoa1.Location = new System.Drawing.Point(496, 702);
            this.Xoa1.Name = "Xoa1";
            this.Xoa1.Size = new System.Drawing.Size(181, 42);
            this.Xoa1.TabIndex = 3;
            this.Xoa1.Text = "Xóa";
            this.Xoa1.UseVisualStyleBackColor = true;
            this.Xoa1.Click += new System.EventHandler(this.Xoa1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "MaNha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "MaCN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(933, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "MaNV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Định vị";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "SL Phòng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tình Trạng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(353, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ngày Đăng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(658, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Ngày Hết Hạn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(69, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Giá Thuê";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(793, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Số lượt xem";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(560, 194);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Số phòng còn";
            // 
            // txtMaNha
            // 
            this.txtMaNha.Location = new System.Drawing.Point(162, 40);
            this.txtMaNha.Name = "txtMaNha";
            this.txtMaNha.Size = new System.Drawing.Size(100, 26);
            this.txtMaNha.TabIndex = 15;
            // 
            // txtMaCN
            // 
            this.txtMaCN.Location = new System.Drawing.Point(357, 40);
            this.txtMaCN.Name = "txtMaCN";
            this.txtMaCN.Size = new System.Drawing.Size(100, 26);
            this.txtMaCN.TabIndex = 16;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(1017, 37);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 26);
            this.txtMaNV.TabIndex = 17;
            // 
            // txtTT
            // 
            this.txtTT.Location = new System.Drawing.Point(162, 138);
            this.txtTT.Name = "txtTT";
            this.txtTT.Size = new System.Drawing.Size(158, 26);
            this.txtTT.TabIndex = 18;
            // 
            // txtDV
            // 
            this.txtDV.Location = new System.Drawing.Point(162, 90);
            this.txtDV.Name = "txtDV";
            this.txtDV.Size = new System.Drawing.Size(824, 26);
            this.txtDV.TabIndex = 19;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(162, 188);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(158, 26);
            this.txtGia.TabIndex = 22;
            // 
            // txtPhong
            // 
            this.txtPhong.Location = new System.Drawing.Point(447, 188);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(100, 26);
            this.txtPhong.TabIndex = 23;
            // 
            // txtSLXem
            // 
            this.txtSLXem.Location = new System.Drawing.Point(914, 188);
            this.txtSLXem.Name = "txtSLXem";
            this.txtSLXem.Size = new System.Drawing.Size(100, 26);
            this.txtSLXem.TabIndex = 24;
            // 
            // txtPhongCon
            // 
            this.txtPhongCon.Location = new System.Drawing.Point(674, 188);
            this.txtPhongCon.Name = "txtPhongCon";
            this.txtPhongCon.Size = new System.Drawing.Size(100, 26);
            this.txtPhongCon.TabIndex = 25;
            // 
            // Luu1
            // 
            this.Luu1.Location = new System.Drawing.Point(721, 702);
            this.Luu1.Name = "Luu1";
            this.Luu1.Size = new System.Drawing.Size(164, 42);
            this.Luu1.TabIndex = 26;
            this.Luu1.Text = "Lưu";
            this.Luu1.UseVisualStyleBackColor = true;
            this.Luu1.Click += new System.EventHandler(this.Luu1_Click);
            // 
            // Bo1
            // 
            this.Bo1.Location = new System.Drawing.Point(958, 702);
            this.Bo1.Name = "Bo1";
            this.Bo1.Size = new System.Drawing.Size(159, 42);
            this.Bo1.TabIndex = 27;
            this.Bo1.Text = "Bỏ qua";
            this.Bo1.UseVisualStyleBackColor = true;
            this.Bo1.Click += new System.EventHandler(this.Bo1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(685, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "MaChuNha";
            // 
            // txtMaChuNha
            // 
            this.txtMaChuNha.Location = new System.Drawing.Point(785, 40);
            this.txtMaChuNha.Name = "txtMaChuNha";
            this.txtMaChuNha.Size = new System.Drawing.Size(100, 26);
            this.txtMaChuNha.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(479, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 20);
            this.label13.TabIndex = 30;
            this.label13.Text = "LoaiNha";
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Location = new System.Drawing.Point(564, 40);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(100, 26);
            this.txtMaLoai.TabIndex = 31;
            // 
            // txtNgayHetHan
            // 
            this.txtNgayHetHan.Location = new System.Drawing.Point(773, 138);
            this.txtNgayHetHan.Name = "txtNgayHetHan";
            this.txtNgayHetHan.Size = new System.Drawing.Size(213, 26);
            this.txtNgayHetHan.TabIndex = 21;
            // 
            // txtNgayDang
            // 
            this.txtNgayDang.Location = new System.Drawing.Point(447, 138);
            this.txtNgayDang.Name = "txtNgayDang";
            this.txtNgayDang.Size = new System.Drawing.Size(154, 26);
            this.txtNgayDang.TabIndex = 20;
            // 
            // frmCNNhaThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1226, 762);
            this.Controls.Add(this.txtMaLoai);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtMaChuNha);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Bo1);
            this.Controls.Add(this.Luu1);
            this.Controls.Add(this.txtPhongCon);
            this.Controls.Add(this.txtSLXem);
            this.Controls.Add(this.txtPhong);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtNgayHetHan);
            this.Controls.Add(this.txtNgayDang);
            this.Controls.Add(this.txtDV);
            this.Controls.Add(this.txtTT);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.txtMaCN);
            this.Controls.Add(this.txtMaNha);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Xoa1);
            this.Controls.Add(this.Sua1);
            this.Controls.Add(this.Them1);
            this.Controls.Add(this.dgvNhaThue);
            this.Name = "frmCNNhaThue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật nhà thuê";
            this.Load += new System.EventHandler(this.frmCNNhaThue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaThue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNhaThue;
        private System.Windows.Forms.Button Them1;
        private System.Windows.Forms.Button Sua1;
        private System.Windows.Forms.Button Xoa1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMaNha;
        private System.Windows.Forms.TextBox txtMaCN;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtTT;
        private System.Windows.Forms.TextBox txtDV;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.TextBox txtSLXem;
        private System.Windows.Forms.TextBox txtPhongCon;
        private System.Windows.Forms.Button Luu1;
        private System.Windows.Forms.Button Bo1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMaChuNha;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.TextBox txtNgayHetHan;
        private System.Windows.Forms.TextBox txtNgayDang;
    }
}