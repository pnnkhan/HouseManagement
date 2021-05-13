using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ChinhSuaViTri : Form
    {
        SqlConnection cnn = null;
        public ChinhSuaViTri(DangNhap frm2)
        {
            InitializeComponent();
            string connString = @"Data Source=.;Initial Catalog=QLNha;User ID=";
            connString += frm2.textTenDangNhap.Text;
            connString += ";Password=";
            connString += frm2.textMatKhau.Text;
            cnn = new SqlConnection(connString);
        }
        string proce_dure = "";
        public void Screen()
        {
            cnn.Open();
            //EXEC USP_EDIT_POSITION_KH_NV N'KH004',N'0987898882', N'NV001' , 50000000
            string sql = " select KH.MAKH, KH.SDT, NV.MANV, NV.LUONG from KHACHHANG KH, NHANVIEN NV where KH.MANV = NV.MANV";  // lay het du lieu trong bang
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            dataGridView1.DataSource = dt; //đổ
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1)
            {
                DataGridViewRow selected = dataGridView1.Rows[index];
                textBox1.Text = selected.Cells[0].Value.ToString();
                textBox2.Text = selected.Cells[1].Value.ToString();
                textBox3.Text = selected.Cells[2].Value.ToString();
                textBox4.Text = selected.Cells[3].Value.ToString();
            }
        }

        private void ChinhSuaViTri_Load(object sender, EventArgs e)
        {
            Screen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            cnn.Open();
            if (checkBox1.Checked == true)
            {
                //EXEC USP_EDIT_POSITION_KH_NV N'KH004',N'0987898882', N'NV001' , 50000000
                //@MAKH CHAR(5), @SODIENTHOAI CHAR(13), @MANV_NEW CHAR(5) , @LUONG FLOAT
                proce_dure = "USP_EDIT_POSITION_KH_NV";
            }
            else if (checkBox2.Checked == true)
            {
                proce_dure = "USP_EDIT_POSITION_KH_NV_FIX";
            }    
            SqlCommand add_in = new SqlCommand(proce_dure, cnn);
            add_in.CommandType = CommandType.StoredProcedure;
            add_in.Parameters.AddWithValue("@MAKH", SqlDbType.Char).Value = textBox1.Text.Trim();
            add_in.Parameters.AddWithValue("@SODIENTHOAI", SqlDbType.Char).Value = textBox2.Text.Trim();
            add_in.Parameters.AddWithValue("@MANV_NEW", SqlDbType.Char).Value = textBox3.Text.Trim();
            add_in.Parameters.AddWithValue("@LUONG", SqlDbType.Float).Value = textBox4.Text;
            try
            {
                add_in.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DEADLOCK", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            cnn.Close();
            Screen();
        }
    }
}
