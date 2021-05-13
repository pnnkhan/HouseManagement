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
    public partial class frmChiNhanh : Form
    {
        SqlConnection conn = null;  //Khai báo đối tượng kết nối        
        DangNhap f2;
        public frmChiNhanh(DangNhap frm2)
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

        private void thêmNhânViênMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void choThuêToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

            private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox_SoDT_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dgvChiNhanh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox_MaCN_TextChanged(object sender, EventArgs e)
        {

        }

        private void sửaThôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saThảiNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thayĐổiLương_Click(object sender, EventArgs e)
        {
            thayDoiLuong f1 = new thayDoiLuong(f2);
            f1.ShowDialog();
            SqlCommand com = new SqlCommand("sp_XemNhanVien", conn);
            com.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(com.ExecuteReader());
            dgvChiNhanh.DataSource = dt;
            com.Dispose();
        }

        private void thayĐổiGiáNhàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThayDoiGiaNhaBan f1 = new ThayDoiGiaNhaBan(f2);
            f1.ShowDialog();
            SqlCommand com = new SqlCommand("Xem_AllNhaBan", conn);
            com.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(com.ExecuteReader());
            dgvChiNhanh.DataSource = dt;
            com.Dispose();
        }
        private void btnDSNhanVien_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("sp_XemNhanVien", conn);
            com.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(com.ExecuteReader());
            dgvChiNhanh.DataSource = dt;
            com.Dispose();
        }

        private void btnDSKH_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("sp_XemKhachHang", conn);
            com.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(com.ExecuteReader());
            dgvChiNhanh.DataSource = dt;
            com.Dispose();
        }

        private void btnDSNha_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("sp_XemAllNha", conn);
            com.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(com.ExecuteReader());
            dgvChiNhanh.DataSource = dt;
            com.Dispose();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            conn.Close();
            DangNhap f1 = new DangNhap();
            f1.ShowDialog();
            conn.Dispose();
            this.Close();
        }

        private void nhàBánToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("Xem_AllNhaBan", conn);
            com.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(com.ExecuteReader());
            dgvChiNhanh.DataSource = dt;
            com.Dispose();
        }
    }
}
