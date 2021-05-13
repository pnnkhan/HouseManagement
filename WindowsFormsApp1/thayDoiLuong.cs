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
    public partial class thayDoiLuong : Form
    {
        SqlConnection conn = null;
        public thayDoiLuong(DangNhap frm2)
        {
            InitializeComponent();
            string connString = @"Data Source=.;Initial Catalog=QLNha;User ID=";
            connString += frm2.textTenDangNhap.Text;
            connString += ";Password=";
            connString += frm2.textMatKhau.Text;
            conn = new SqlConnection(connString);
            conn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0 || textBox2.TextLength == 0)
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            else
            {
                SqlCommand com = null;
                if (checkBox1.Checked == true)
                    com = new SqlCommand("sp_ThayDoiLuong", conn);
                else
                    com = new SqlCommand("sp_ThayDoiLuong_fix", conn); 
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@MaNV", SqlDbType.VarChar).Value = textBox1.Text.Trim();
                com.Parameters.AddWithValue("@SoTien", SqlDbType.Float).Value = int.Parse(textBox2.Text.Trim());
                com.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
                com.Dispose();
                this.Close();
            }    
        }
    }
}
