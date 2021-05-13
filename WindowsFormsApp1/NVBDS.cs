using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
	public partial class NVBDS : Form
	{
		DangNhap f2;
		SqlConnection conn = null;
		public NVBDS(DangNhap frm2)
		{
			InitializeComponent();
			this.f2 = frm2;
			string connString = @"Data Source=.;Initial Catalog=QLNha;User ID=";
			connString += frm2.textTenDangNhap.Text;
			connString += ";Password=";
			connString += frm2.textMatKhau.Text;
			conn = new SqlConnection(connString);
			conn.Open();
		}

        private void DangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
			this.Hide();
			conn.Close();
			DangNhap f1 = new DangNhap();
			f1.ShowDialog();
			conn.Dispose();
			this.Close();
        }

        private void ThongTinCaNhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
			SqlCommand com = new SqlCommand("Xem_TTCaNhan", conn);
			com.CommandType = CommandType.StoredProcedure;
			com.Parameters.AddWithValue("@ten_Dang_Nhap", SqlDbType.VarChar).Value = f2.textTenDangNhap.Text.Trim();
			com.Parameters.AddWithValue("@LoaiTaiKhoan", SqlDbType.Int).Value = 1;
			DataTable dt = new DataTable();
			dt.Load(com.ExecuteReader());
			dataGridView1.DataSource = dt;
			com.Dispose();
		}

        private void Tim_KhachHangToolStripMenuItem3_Click(object sender, EventArgs e)
        {
			SqlCommand com = new SqlCommand("Tim_KH", conn);
			com.CommandType = CommandType.StoredProcedure;
			TimKH f1 = new TimKH();
			f1.ShowDialog();
			com.Parameters.AddWithValue("@ten", SqlDbType.NVarChar).Value = f1.textBox1.Text.Trim();
			DataTable dt = new DataTable();
			dt.Load(com.ExecuteReader());
			dataGridView1.DataSource = dt;
			com.Dispose();
			f1.Dispose();
        }

        private void Tim_NhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
			SqlCommand com = null;
			if(trChap.Checked == true)
            {
				 com = new SqlCommand("Tim_Nha", conn);
            }
            else
            {
				 com = new SqlCommand("Tim_Nha_fix", conn);
			}
			com.CommandType = CommandType.StoredProcedure;
			TimNha f1 = new TimNha();
			f1.ShowDialog();
			com.Parameters.AddWithValue("@thanhPho", SqlDbType.NVarChar).Value = f1.comboBox1.Text.Trim();
			com.Parameters.AddWithValue("@quan", SqlDbType.NVarChar).Value = f1.comboBox2.Text.Trim();
			DataTable dt = new DataTable();
			dt.Load(com.ExecuteReader());
			dataGridView1.DataSource = dt;
			com.Dispose();
			f1.Dispose();
		}

        private void Xem_NhaBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
			SqlCommand com = new SqlCommand("Xem_AllNhaBan", conn);
			com.CommandType = CommandType.StoredProcedure;
			DataTable dt = new DataTable();
			dt.Load(com.ExecuteReader());
			dataGridView1.DataSource = dt;
			com.Dispose();
		}

        private void Xem_NhaThueToolStripMenuItem_Click(object sender, EventArgs e)
        {
			SqlCommand com = new SqlCommand("Xem_AllNhaThue", conn);
			com.CommandType = CommandType.StoredProcedure;
			DataTable dt = new DataTable();
			dt.Load(com.ExecuteReader());
			dataGridView1.DataSource = dt;
			com.Dispose();
		}

        private void CN_KhachHangToolStripMenuItem2_Click(object sender, EventArgs e)
        {
			ChinhSuaKhachHang f1 = new ChinhSuaKhachHang(this.f2);
			f1.ShowDialog();
			f1.Dispose();
		}

        private void TinhTrangNhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
			ChinhSuaTinhTrangNha f1 = new ChinhSuaTinhTrangNha(this.f2);
			f1.ShowDialog();
			f1.Dispose();
		}
    }
}
