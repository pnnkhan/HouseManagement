using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ChuNha : Form
    {
        DangNhap f2;
        SqlConnection conn = null;
        public ChuNha(DangNhap frm2)
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

        DataTable xemNhanXet()
        {
            DataTable data = new DataTable();
            if (TrChap.Checked == true)
            {
                
                string sql = "exec sp_XemNhanXet '" + f2.textTenDangNhap.Text.Trim() + "'";
                data = Functions.GetDataToTable(sql, f2); //lấy dữ liệu
            }
            else
            {
                string sql = "exec sp_XemNhanXet_fix '" + f2.textTenDangNhap.Text.Trim() + "'";
                data = Functions.GetDataToTable(sql, f2); //lấy dữ liệu
            }
            return data;
        }
       
        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = xemNhanXet();
        }


        private void nhaThuêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCNNhaThue frm = new frmCNNhaThue(f2);
            frm.ShowDialog();
            this.Show();
        }

        private void nhaBanToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmCNNhaBan frm = new FrmCNNhaBan(f2);
            frm.ShowDialog();
            this.Show();
        }

        private void đăngXuâtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            conn.Close();
            DangNhap f1 = new DangNhap();
            f1.ShowDialog();
            conn.Dispose();
            this.Close();
        }
    }
}
