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
    public partial class KhachHang : Form
    {
        SqlConnection Con;
        DangNhap f2;
        string MaNguoiDung = "";
        void Connect(DangNhap frm2)
        {
            Con = new SqlConnection();
            string connString = @"Data Source=.;Initial Catalog=QLNha;User ID=";
            connString += frm2.textTenDangNhap.Text;
            connString += ";Password=";
            connString += frm2.textMatKhau.Text;
            Con.ConnectionString = connString;
            Con.Open();
        }

        void Disconnect()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();   	
                Con.Dispose(); 	
                Con = null;
            }
        }
        DataTable GetDataToTable(string sql)
        {
            Connect(f2);
            SqlDataAdapter dap = new SqlDataAdapter(sql, Con);
            DataTable table = new DataTable();
            dap.Fill(table); 
            Disconnect();
            return table;
        }

        public KhachHang(DangNhap frm2)
        {
            InitializeComponent();
            Connect(frm2);
            f2 = frm2;
            SqlCommand com = new SqlCommand("Lay_MaNguoiDung", Con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@ten_Dang_Nhap", SqlDbType.VarChar).Value = f2.textTenDangNhap.Text.Trim();
            com.Parameters.AddWithValue("@LoaiTaiKhoan", SqlDbType.Int).Value = 0;
            com.Parameters.Add("@MaNguoiDung", SqlDbType.VarChar).Direction = ParameterDirection.ReturnValue;
            com.ExecuteNonQuery();
            MaNguoiDung = com.Parameters["@MaNguoiDung"].Value.ToString();
            Disconnect();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {
            
            if (checkBox1.Checked == true)
            {
                Connect(f2);
           
                SqlCommand cmd1 = Con.CreateCommand();
                SqlTransaction transaction = Con.BeginTransaction(IsolationLevel.RepeatableRead);
                
                cmd1.Connection = Con;
                cmd1.Transaction = transaction;
                cmd1.CommandType = CommandType.StoredProcedure;
                //string command1 = "";

                try
                {
                    cmd1.CommandText = cmd1.CommandText + "exec sp_XemNhaThueKhach N'" + comboBox1.Text + "',"
                    + int.Parse(textBox1.Text) + ",'"
                    + textBox2.Text + "'";
                    cmd1.ExecuteNonQuery();
                    
                    transaction.Commit();
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                    Console.WriteLine("  Message: {0}", ex.Message);

                    
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        
                        Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                        Console.WriteLine("  Message: {0}", ex2.Message);
                    }
                }
                DataTable data1 = new DataTable();
                data1 = GetDataToTable(cmd1.CommandText);
                dataGridView1.DataSource = data1;
            }
            
                if(checkBox2.Checked == true)
                {
                Connect(f2);

                SqlCommand cmd1 = Con.CreateCommand();
                SqlTransaction transaction = Con.BeginTransaction(IsolationLevel.RepeatableRead);

                cmd1.Connection = Con;
                cmd1.Transaction = transaction;
                cmd1.CommandType = CommandType.StoredProcedure;
                //string command1 = "";

                try
                {
                    if(TrChap.Checked == true)
                    {
                        cmd1.CommandText = cmd1.CommandText + "exec sp_XemNhaBanKhach N'" + comboBox1.Text + "','"
                    + int.Parse(textBox1.Text) + "','"
                    + textBox2.Text + "'";
                        cmd1.ExecuteNonQuery();

                        transaction.Commit();
                    }
                    else
                    {
                        cmd1.CommandText = cmd1.CommandText + "exec sp_XemNhaBanKhach_fix N'" + comboBox1.Text + "','"
                    + int.Parse(textBox1.Text) + "','"
                    + textBox2.Text + "'";
                        cmd1.ExecuteNonQuery();

                        transaction.Commit();
                    }
                    

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                    Console.WriteLine("  Message: {0}", ex.Message);


                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {

                        Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                        Console.WriteLine("  Message: {0}", ex2.Message);
                    }
                }
                DataTable data2 = new DataTable();
                    data2 = GetDataToTable(cmd1.CommandText);
                    dataGridView1.DataSource = data2;
                }
                
                    if(checkBox1.Checked == true & checkBox2.Checked == true)
                    {
                Connect(f2);

                SqlCommand cmd1 = Con.CreateCommand();
                SqlTransaction transaction = Con.BeginTransaction(IsolationLevel.RepeatableRead);

                cmd1.Connection = Con;
                cmd1.Transaction = transaction;
                cmd1.CommandType = CommandType.StoredProcedure;
                //string command1 = "";

                try
                {
                    cmd1.CommandText = cmd1.CommandText + "exec sp_XemNhaBanvaThue N'" + comboBox1.Text + "','"
                    + textBox1.Text + "','"
                    + textBox2.Text + "'";
                    cmd1.ExecuteNonQuery();

                    transaction.Commit();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                    Console.WriteLine("  Message: {0}", ex.Message);


                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {

                        Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                        Console.WriteLine("  Message: {0}", ex2.Message);
                    }
                }
                DataTable data3 = new DataTable();
                data3 = GetDataToTable(cmd1.CommandText);
                dataGridView1.DataSource = data3;
                    }
            if(checkBox1.Checked == false & checkBox2.Checked == false)
            {
                Connect(f2);

                SqlCommand cmd1 = Con.CreateCommand();
                SqlTransaction transaction = Con.BeginTransaction(IsolationLevel.RepeatableRead);

                cmd1.Connection = Con;
                cmd1.Transaction = transaction;
                cmd1.CommandType = CommandType.StoredProcedure;
                //string command1 = "";

                try
                {
                    cmd1.CommandText = cmd1.CommandText + "exec sp_XemNhaBanvaThue N'" + comboBox1.Text + "','"
                    + textBox1.Text + "','"
                    + textBox2.Text + "'";
                    cmd1.ExecuteNonQuery();

                    transaction.Commit();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                    Console.WriteLine("  Message: {0}", ex.Message);


                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {

                        Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                        Console.WriteLine("  Message: {0}", ex2.Message);
                    }
                }
                DataTable data3 = new DataTable();
                data3 = GetDataToTable(cmd1.CommandText);
                dataGridView1.DataSource = data3;
            }
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void tb_timkiem_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Connect(f2);

            SqlCommand cmd1 = Con.CreateCommand();
            SqlTransaction transaction = Con.BeginTransaction(IsolationLevel.Serializable);

            cmd1.Connection = Con;
            cmd1.Transaction = transaction;
            
            try
            {
                cmd1.CommandText = cmd1.CommandText + "exec sp_DKXemNha_KH "
                    + MaNguoiDung + ",'"
                    + textBox5.Text
                    + "'";
                cmd1.ExecuteNonQuery();

                transaction.Commit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                Console.WriteLine("  Message: {0}", ex.Message);


                try
                {
                    transaction.Rollback();
                }
                catch (Exception ex2)
                {

                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                    Console.WriteLine("  Message: {0}", ex2.Message);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Connect(f2);

            SqlCommand cmd1 = Con.CreateCommand();
            SqlTransaction transaction = Con.BeginTransaction(IsolationLevel.Serializable);

            cmd1.Connection = Con;
            cmd1.Transaction = transaction;

            try
            {
                if (TrChap2.Checked == true)
                {
                    cmd1.CommandText = cmd1.CommandText + "exec sp_ThemNhanXet "
                    + MaNguoiDung + ",'"
                    + textBox3.Text
                    + "',N'"
                    + textBox4.Text
                    + "'";
                    cmd1.ExecuteNonQuery();
                    transaction.Commit();
                }
                else
                {
                    cmd1.CommandText = cmd1.CommandText + "exec sp_ThemNhanXet_fix "
                   + MaNguoiDung + ",'"
                   + textBox3.Text
                   + "',N'"
                   + textBox4.Text
                   + "'";
                    cmd1.ExecuteNonQuery();
                    transaction.Commit();
                }
               
            }
            catch (Exception ex)
            {
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                Console.WriteLine("  Message: {0}", ex.Message);


                try
                {
                    transaction.Rollback();
                }
                catch (Exception ex2)
                {

                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                    Console.WriteLine("  Message: {0}", ex2.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Connect(f2);

            SqlCommand cmd1 = Con.CreateCommand();
            SqlTransaction transaction = Con.BeginTransaction(IsolationLevel.Serializable);

            cmd1.Connection = Con;
            cmd1.Transaction = transaction;

            try
            {
                cmd1.CommandText = cmd1.CommandText + "exec sp_XemNhanXetKhach";
                cmd1.ExecuteNonQuery();
                transaction.Commit();
                DataTable data = new DataTable();
                data = GetDataToTable(cmd1.CommandText);
                dataGridView1.DataSource = data;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                Console.WriteLine("  Message: {0}", ex.Message);


                try
                {
                    transaction.Rollback();
                }
                catch (Exception ex2)
                {

                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                    Console.WriteLine("  Message: {0}", ex2.Message);
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}


