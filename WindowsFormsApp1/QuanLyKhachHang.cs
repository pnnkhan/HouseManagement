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
    public partial class QuanLyKhachHang : Form
    {
        SqlConnection cnn = null;
        public QuanLyKhachHang(DangNhap frm2)
        {
            InitializeComponent();
            string connString = @"Data Source=.;Initial Catalog=QLNha;User ID=";
            connString += frm2.textTenDangNhap.Text;
            connString += ";Password=";
            connString += frm2.textMatKhau.Text;
            cnn = new SqlConnection(connString);
        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            Screen();
        }
        public void Screen()
        {
            cnn.Open();
            string sql = "select MAKH, MANV, TEN, SDT from KHACHHANG";  
            string query = "select * from NHABAN";
            SqlCommand com = new SqlCommand(sql, cnn); 
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); 
            DataTable dt = new DataTable(); 
            da.Fill(dt);  
            cnn.Close();  
            dataGridView1.DataSource = dt; 
        }

        private void Them_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            cnn.Open();
            string com = @"insert into KHACHHANG(MAKH,MANV,TEN,SDT ) values (N'" + textBox1.Text + @"', N'" + textBox2.Text + @"',N'" + textBox3.Text + @"',N'" + textBox4.Text + @"')";
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

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            cnn.Open();
            string com = @"update KHACHHANG SET 
            MAKH = N'" + textBox1.Text + @"', MANV = N'" + textBox2.Text + @"',
            TEN =  N'" + textBox3.Text + @"', SDT = N'" + textBox4.Text + @"'
            WHERE (MAKH = N'" + textBox1.Text + @"')";
            SqlCommand add_in = new SqlCommand(com, cnn);
            try
            {
                add_in.ExecuteNonQuery(); //Thực hiện câu lệnh SQL
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            cnn.Open();
            string com = @"DELETE FROM KHACHHANG
            WHERE (MAKH = N'" + textBox1.Text + @"')";
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

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("sp_XemKhachHang", cnn);
            com.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(com.ExecuteReader());
            dataGridView1.DataSource = dt;
            com.Dispose();
        }
    }
}
