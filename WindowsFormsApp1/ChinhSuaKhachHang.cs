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
    public partial class ChinhSuaKhachHang : Form
    {
        SqlConnection conn = null;
        DangNhap f2;
        string sdt = "";
        public ChinhSuaKhachHang(DangNhap frm2)
        {
            InitializeComponent();
            f2 = frm2;
            label6.Hide();
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (textBox1.TextLength == 0)
                label6.Show();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox1.TextLength != 0)
                label6.Hide();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox1.TextLength == 0)
                label6.Show();
            else
                label6.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0)
                MessageBox.Show("Vui lòng nhập mã khách hàng!");
            else if (textBox2.TextLength == 0 && textBox3.TextLength == 0 && textBox4.TextLength == 0)
                MessageBox.Show("Vui lòng nhập thông tin cần chỉnh sửa!");
            else
            {
                string connString = @"Data Source=.;Initial Catalog=QLNha;User ID=";
                connString += f2.textTenDangNhap.Text;
                connString += ";Password=";
                connString += f2.textMatKhau.Text;
                conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand com = new SqlCommand("Chinh_Sua_Khach_Hang", conn);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@MaKH", SqlDbType.Char).Value = textBox1.Text.Trim();
                com.Parameters.AddWithValue("@ten", SqlDbType.NVarChar).Value = textBox2.Text.Trim();
                com.Parameters.AddWithValue("@diaChi", SqlDbType.NVarChar).Value = textBox3.Text.Trim();
                com.Parameters.AddWithValue("@sdt", SqlDbType.Char).Value = textBox4.Text.Trim();
                com.Parameters.Add("@check", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                com.ExecuteNonQuery();
                int checkSuccess = int.Parse(com.Parameters["@check"].Value.ToString());
                if (checkSuccess == 1)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    this.Close();
                }
                else
                    MessageBox.Show("Tài khoản không tồn tại!");
                
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox4.TextLength > 10 || textBox4.Text.Any(char.IsLetter))
                textBox4.Text = sdt;
            else sdt = textBox4.Text;

        }

        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox4.TextLength > 10 || textBox4.Text.Any(char.IsLetter))
                textBox4.Text = sdt;
            else sdt = textBox4.Text;
        }
    }
}
