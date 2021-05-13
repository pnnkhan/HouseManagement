using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class QuanLyNhanVien : Form
    {
        SqlConnection cnn = null;
        public QuanLyNhanVien(DangNhap frm2)
        {
            InitializeComponent();
            string connString = @"Data Source=.;Initial Catalog=QLNha;User ID=";
            connString += frm2.textTenDangNhap.Text;
            connString += ";Password=";
            connString += frm2.textMatKhau.Text;
            cnn = new SqlConnection(connString);
        }
        string proce_dure = "";
        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            Screen();
        }
        public void Screen()
        {
            cnn.Open();
            string sql = "select MANV, MACN, TEN , GIOITINH, LUONG from NHANVIEN";  // lay het du lieu trong bang
            string query = "select * from NHABAN";
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            dataGridView1.DataSource = dt; //đổ
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            cnn.Open();
            string com = @"insert into NHANVIEN(MANV,MACN,TEN,GIOITINH,LUONG ) values (N'"+textBox1.Text+@"', N'"+textBox2.Text + @"',N'"+textBox3.Text+ @"',N'"+Gioitinh.Text+ @"',N'" + textBox4.Text + @"')";
            SqlCommand add_in = new SqlCommand(com, cnn);
            try
            {
                add_in.ExecuteNonQuery(); //Thực hiện câu lệnh SQL
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng kiểm tra lại Primary or Constraint", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            cnn.Close();
            Screen();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            cnn.Open();
            if (checkBox1.Checked == true)
            {
                if (checkBox3.Checked == true)
                {
                    proce_dure = "USP_TRULUONG";
                }
                else if (checkBox4.Checked == true)
                {
                    proce_dure = "USP_TANGLUONG";
                }
            }
            else if (checkBox2.Checked == true)
            {
                if (checkBox3.Checked == true)
                {
                    proce_dure = "USP_TRULUONG_FIX";
                }
                else if (checkBox4.Checked == true)
                {
                    proce_dure = "USP_TANGLUONG_FIX";
                }
            }
            SqlCommand add_in = new SqlCommand(proce_dure, cnn);
            add_in.CommandType = CommandType.StoredProcedure;
            add_in.Parameters.AddWithValue("@MANV", SqlDbType.Char).Value = textBox1.Text.Trim();
            add_in.Parameters.AddWithValue("@SOTIEN", SqlDbType.Float).Value = textBox4.Text;
            try
            {
                add_in.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                MessageBox.Show("DEADLOCK", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            cnn.Close();
            Screen();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Are you sure to exit?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (f == DialogResult.Yes)
            {
                this.Close();
                //Application.Exit();
            }    
        }
     

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1)
            {
                DataGridViewRow selected = dataGridView1.Rows[index];
                textBox1.Text = selected.Cells[0].Value.ToString();
                textBox2.Text = selected.Cells[1].Value.ToString();
                textBox3.Text = selected.Cells[2].Value.ToString();
                Gioitinh.Text = selected.Cells[3].Value.ToString();
                textBox4.Text = selected.Cells[4].Value.ToString();
            }

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            cnn.Open();
            string com = @"DELETE FROM NHANVIEN
            WHERE (MANV = N'" + textBox1.Text + @"')";
            SqlCommand add_in = new SqlCommand(com, cnn);
            try
            {
                add_in.ExecuteNonQuery(); //Thực hiện câu lệnh SQL
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng kiểm tra lại Primary or Constraint", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            cnn.Close();
            Screen();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
 
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void đăngXuấtALTF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            cnn.Open();
            SqlCommand com = new SqlCommand("sp_XemNhanVien", cnn);
            com.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(com.ExecuteReader());
            dataGridView1.DataSource = dt;
            com.Dispose();
        }
    }
}
