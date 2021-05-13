using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Functions
    {
        public static SqlConnection Con;  //Khai báo đối tượng kết nối
        public static DangNhap f2;

        public static void Connect(DangNhap frm2)
        {
            Con = new SqlConnection();   //Khởi tạo đối tượng
            string connString = @"Data Source=.;Initial Catalog=QLNha;User ID=";
            connString += frm2.textTenDangNhap.Text;
            connString += ";Password=";
            connString += frm2.textMatKhau.Text;
            f2 = frm2;
            Con.ConnectionString = connString;
            Con.Open();                  //Mở kết nối
            //Kiểm tra kết nối
            /*if (Con.State == ConnectionState.Open)
                MessageBox.Show("Kết nối thành công");
            else MessageBox.Show("Không thể kết nối với dữ liệu");*/

        }
        public static void Disconnect()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();   	//Đóng kết nối
                Con.Dispose(); 	//Giải phóng tài nguyên
                Con = null;
            }
        }
        public static DataTable GetDataToTable(string sql, DangNhap f2)
        {
            Connect(f2);
            SqlDataAdapter dap = new SqlDataAdapter(sql, Con); //Định nghĩa đối tượng thuộc lớp SqlDataAdapter
            //Khai báo đối tượng table thuộc lớp DataTable
            DataTable table = new DataTable();
            dap.Fill(table); //Đổ kết quả từ câu lệnh sql vào table
            Disconnect();
            return table;
        }
        public static void RunSQL(string sql)
        {
            Connect(f2);
            SqlCommand cmd; //Đối tượng thuộc lớp SqlCommand
            cmd = new SqlCommand();
            cmd.Connection = Con; //Gán kết nối
            cmd.CommandText = sql; //Gán lệnh SQL
            try
            {
                cmd.ExecuteNonQuery(); //Thực hiện câu lệnh SQL
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();//Giải phóng bộ nhớ
            cmd = null;
            Disconnect();
        }
        public static void RunSqlDel(string sql)
        {
            Connect(f2);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Functions.Con;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Dữ liệu đang được dùng, không thể xoá...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
            Disconnect();
        }
        public static bool CheckKey(string sql)
        {
            Connect(f2);
            SqlDataAdapter dap = new SqlDataAdapter(sql, Con);
            DataTable table = new DataTable();
            dap.Fill(table);
            Disconnect();
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }
        public static string ConvertDateTime(string date)
        {
            date = date.Remove(date.Length - 12);
            string[] elements = date.Split('/');
            string dt = string.Format("{2}-{0}-{1}", elements[0], elements[1], elements[2]);
            return dt;
        }
    }
}
