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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        private void button1_Click(object sender, EventArgs e)
        {
            string connString = @"Data Source=.;Initial Catalog=QLNha;User ID=";
            int check = 1;
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            connString += textTenDangNhap.Text;
            connString += ";Password=";
            connString += textMatKhau.Text;
            conn = new SqlConnection(connString);
            if (conn.State == ConnectionState.Closed)
            {
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    conn.Close();
                    conn.Dispose();
                    check = 0;
                    SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=QLNha;Integrated Security=True");
                    con.Open();
                    SqlCommand com = new SqlCommand("Loai_Dang_Nhap", con);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@ten_Dang_Nhap", SqlDbType.VarChar).Value = textTenDangNhap.Text.Trim();
                    com.Parameters.Add("@result", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                    com.ExecuteNonQuery();
                    int result = int.Parse(com.Parameters["@result"].Value.ToString());
                    con.Close();
                    con.Dispose();
                    com.Dispose();
                    if (result != 0 && result != 1 && result != 2 && result != 3 && result != 4)
                        MessageBox.Show("Tài khoản không tồn tại!");
                    else
                        MessageBox.Show("Mật khẩu không chính xác!");
                }
            }
            if (check == 1)
            {
                conn.Close();
                conn.Dispose();
                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=QLNha;Integrated Security=True");
                con.Open();
                SqlCommand com = new SqlCommand("Loai_Dang_Nhap", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ten_Dang_Nhap", SqlDbType.VarChar).Value = textTenDangNhap.Text.Trim();
                com.Parameters.Add("@result", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                com.ExecuteNonQuery();
                int result = int.Parse(com.Parameters["@result"].Value.ToString());
                con.Close();
                con.Dispose();
                com.Dispose();
                this.Hide();
                // Khách hàng
                if (result == 0)
                {
                    KhachHang f1 = new KhachHang(this);
                    f1.ShowDialog();
                    this.Close();
                }    
                // Nhân viên bất động sản
                if (result == 1)
                {
                    NVBDS f1 = new NVBDS(this);
                    f1.ShowDialog();
                    this.Close();
                }
                // Chủ nhà
                if (result == 2)
                {
                    ChuNha f1 = new ChuNha(this);
                    f1.ShowDialog();
                    this.Close();
                }
                // Nhân viên DEV
                if (result == 3)
                {
                    NVDev f1 = new NVDev(this);
                    f1.ShowDialog();
                    this.Close();
                }
                // Nhân viên chi nhánh
                if (result == 4)
                {
                    frmChiNhanh f1 = new frmChiNhanh(this);
                    f1.ShowDialog();
                    this.Close();
                }
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TaoTaiKhoan f3 = new TaoTaiKhoan();
            f3.ShowDialog();
        }
    }
}
