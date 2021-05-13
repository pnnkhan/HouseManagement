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
    public partial class ChinhSuaTinhTrangNha : Form
    {
        SqlConnection conn = null;
        DangNhap f2;
        public ChinhSuaTinhTrangNha(DangNhap frm2)
        {
            InitializeComponent();
            f2 = frm2;
            label4.Hide();
            label5.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0 || textBox2.TextLength == 0)
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            else
            {
                string connString = @"Data Source=.;Initial Catalog=QLNha;User ID=";
                connString += f2.textTenDangNhap.Text;
                connString += ";Password=";
                connString += f2.textMatKhau.Text;
                conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand com = new SqlCommand("Chinh_Sua_Tinh_Trang_Nha", conn);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@MaKH", SqlDbType.Char).Value = textBox1.Text.Trim();
                com.Parameters.AddWithValue("@MaNha", SqlDbType.Char).Value = textBox2.Text.Trim();
                com.Parameters.Add("@check", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                com.ExecuteNonQuery();
                int checkSuccess = int.Parse(com.Parameters["@check"].Value.ToString());
                if (checkSuccess == 1)
                { 
                    MessageBox.Show("Thực hiện xong!");
                    this.Close();
                }
                else if (checkSuccess == 0)
                    MessageBox.Show("Mã khách hàng không tồn tại!");
                else
                    MessageBox.Show("Mã nhà không tồn tại hoặc nhà đã bán!");
            }                
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (textBox1.TextLength == 0)
                label4.Show();
        }

        private void textBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (textBox2.TextLength == 0)
                label5.Show();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox1.TextLength != 0)
                label4.Hide();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox1.TextLength != 0)
                label4.Hide();
            else
                label4.Show();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox2.TextLength != 0)
                label5.Hide();
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox2.TextLength != 0)
                label5.Hide();
            else
                label5.Show();
        }
    }
}
