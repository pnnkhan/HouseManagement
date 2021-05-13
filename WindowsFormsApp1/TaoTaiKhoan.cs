using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class TaoTaiKhoan : Form
    {
        string matKhau = "";
        string tenDangNhap = "";
        string soDienThoai = "";
        int checkPass = 0;
        public TaoTaiKhoan()
        {
            InitializeComponent();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label11.Hide();
            label12.Hide();
            label13.Hide();
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            int security = 0;
            if (textBox2.TextLength >= 13 && e.KeyCode != Keys.Delete && e.KeyCode != Keys.Back)
                textBox2.Text = matKhau;
            if (textBox2.Text.Any(char.IsDigit))
                security += 1;
            if (textBox2.Text.Any(char.IsUpper))
                security += 1;
            if (textBox2.Text.Any(char.IsLower))
                security += 1;
            if (security == 1)
                textBox6.Text = "Tệ";
            else if (security == 2)
            { 
                textBox6.Text = "Trung bình";
                if (textBox2.TextLength >= 8)
                    checkPass = 1;
            }
            else if (security == 3)
            {
                textBox6.Text = "Tốt";
                if (textBox2.TextLength >= 8)
                    checkPass = 1;
            }
            else
                textBox6.Text = "";
            if (textBox2.TextLength == 0)
                label8.Show();
            else
                label8.Hide();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox2.TextLength < 13 || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
                matKhau = textBox2.Text;
            else
                textBox2.Text = matKhau;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox1.TextLength < 13 || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
                tenDangNhap = textBox1.Text;
            else
                textBox1.Text = tenDangNhap;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox1.TextLength >= 13 && e.KeyCode != Keys.Delete && e.KeyCode != Keys.Back)
                textBox1.Text = tenDangNhap;
            if (textBox1.TextLength == 0)
                label7.Show();
            else
                label7.Hide();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox4.Text.Any(char.IsLetter) || textBox4.TextLength > 10)
                textBox4.Text = soDienThoai;
            else
                soDienThoai = textBox4.Text;
        }

        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox4.Text.Any(char.IsLetter) || textBox4.TextLength > 10)
                textBox4.Text = soDienThoai;
            if (textBox4.TextLength == 0)
                label10.Show();
            else
                label10.Hide();
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (textBox1.TextLength == 0)
                label7.Show();
        }

        private void textBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (textBox2.TextLength == 0)
                label8.Show();
        }

        private void textBox3_MouseDown(object sender, MouseEventArgs e)
        {
            if (textBox3.TextLength == 0)
                label9.Show();
        }

        private void textBox4_MouseDown(object sender, MouseEventArgs e)
        {
            if (textBox4.TextLength == 0)
                label10.Show();
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox3.TextLength == 0)
                label9.Show();
            else
                label9.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.TextLength == 0 || textBox2.TextLength == 0 || textBox3.TextLength == 0 || textBox4.TextLength == 0)
            {
                label13.Hide();
                label12.Show();
                label11.Hide();
            }
            else {
                if (checkPass == 0)
                {
                    label11.Hide();
                    label12.Hide();
                    label13.Show();
                }
                else if (textBox4.TextLength < 10)
                {
                    label11.Show();
                    label12.Hide();
                    label13.Hide();
                }
                else
                {
                    label12.Hide();
                    label13.Hide();
                    SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=QLNha;Integrated Security=True");
                    con.Open();
                    SqlCommand com = new SqlCommand("Tao_TK", con);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@ten_Dang_Nhap", SqlDbType.VarChar).Value = textBox1.Text.Trim();
                    com.Parameters.AddWithValue("@mat_Khau", SqlDbType.VarChar).Value = textBox2.Text.Trim();
                    com.Parameters.AddWithValue("@ten", SqlDbType.NVarChar).Value = textBox3.Text.Trim();
                    com.Parameters.AddWithValue("@sdt", SqlDbType.Char).Value = textBox4.Text.Trim();
                    com.Parameters.AddWithValue("@diaChi", SqlDbType.NVarChar).Value = textBox5.Text.Trim();
                    com.Parameters.Add("@check", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                    com.ExecuteNonQuery();
                    int checkSuccess = int.Parse(com.Parameters["@check"].Value.ToString());
                    if (checkSuccess == 1)
                        MessageBox.Show("Đăng ký thành công!");
                    else if (checkSuccess == 2)
                        MessageBox.Show("Tài khoản đã tồn tại!");
                    else
                        MessageBox.Show("Đăng ký thất bại!");
                    con.Close();
                    con.Dispose();
                    com.Dispose();
                }    
            }
        }

    }


}
