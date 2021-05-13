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
    public partial class EditTenKH_NV : Form
    {
        SqlConnection cnn = null;
        public EditTenKH_NV(DangNhap frm2)
        {
            InitializeComponent();
            string connString = @"Data Source=.;Initial Catalog=QLNha;User ID=";
            connString += frm2.textTenDangNhap.Text;
            connString += ";Password=";
            connString += frm2.textMatKhau.Text;
            cnn = new SqlConnection(connString);
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
                textBox5.Text = selected.Cells[4].Value.ToString();
            }
        }
        string proce_dure = "";
        public void Screen()
        {
            cnn.Open();
            string sql = " select NV.MANV, NV.TEN, KH.MAKH, KH.TEN, KH.SDT from KHACHHANG KH, NHANVIEN NV where KH.MANV = NV.MANV";  // lay het du lieu trong bang
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            dataGridView1.DataSource = dt; //đổ
        }
        private void EditTenKH_NV_Load(object sender, EventArgs e)
        {
            Screen();
           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            cnn.Open();
            if (checkBox1.Checked == true)
            {
                //EXEC USP_EIDT_TENKH_TENNV N'NV001', N'Hồ Minh',N'KH004',N'0987898882', N'Anh Duy'
                proce_dure = "USP_EIDT_TENKH_TENNV";
            }
            else if (checkBox2.Checked == true)
            {
                proce_dure = "USP_EIDT_TENKH_TENNV_FIX";
            }    
            SqlCommand add_in = new SqlCommand(proce_dure, cnn);
            add_in.CommandType = CommandType.StoredProcedure;
            add_in.Parameters.AddWithValue("@MANV", SqlDbType.Char).Value = textBox1.Text.Trim();
            add_in.Parameters.AddWithValue("@TENNV", SqlDbType.NVarChar).Value = textBox2.Text.Trim();
            add_in.Parameters.AddWithValue("@MAKH", SqlDbType.Char).Value = textBox3.Text.Trim();
            add_in.Parameters.AddWithValue("@SODIENTHOAI", SqlDbType.VarChar).Value = textBox5.Text.Trim();
            add_in.Parameters.AddWithValue("@TENKH", SqlDbType.NVarChar).Value = textBox4.Text.Trim();
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
