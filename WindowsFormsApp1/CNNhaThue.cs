using System;
using System.CodeDom.Compiler;
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
    
    public partial class frmCNNhaThue : Form
    {
        DangNhap f2;
        public frmCNNhaThue(DangNhap frm2)
        {
            InitializeComponent();
            f2 = frm2;
        }


        private void frmCNNhaThue_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            txtMaNha.Enabled = false;
            txtMaNV.Enabled = false;
            txtMaCN.Enabled = false;
            txtSLXem.Enabled = false;
            txtMaChuNha.Enabled = false;
            txtMaLoai.Enabled = false;
            Luu1.Enabled = false;
            Bo1.Enabled = false;
        }
        void LoadDataGridView()
        {
            DataTable data = new DataTable();
            string query1= "exec sp_XemNhaThue '"+ f2.textTenDangNhap.Text.Trim() +"'";
            data = Functions.GetDataToTable(query1,f2); //lấy dữ liệu
            dgvNhaThue.DataSource = data;
        }

        private void dgvNhaThue_Click(object sender, EventArgs e)
        {
            if (Them1.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNha.Focus();
                return;
            }
            txtMaNha.Text = dgvNhaThue.CurrentRow.Cells["MaNha"].Value.ToString();
            txtMaCN.Text = dgvNhaThue.CurrentRow.Cells["MaCN"].Value.ToString();
            txtMaLoai.Text = dgvNhaThue.CurrentRow.Cells["MaLoaiNha"].Value.ToString();
            txtMaChuNha.Text = dgvNhaThue.CurrentRow.Cells["MaChuNha"].Value.ToString();
            txtMaNV.Text = dgvNhaThue.CurrentRow.Cells["MaNV"].Value.ToString();
            txtDV.Text = dgvNhaThue.CurrentRow.Cells["DINHVI"].Value.ToString();
            txtPhong.Text = dgvNhaThue.CurrentRow.Cells["SOLUONGPHONG"].Value.ToString();
            txtTT.Text = dgvNhaThue.CurrentRow.Cells["TINHTRANGNHA"].Value.ToString();
            txtNgayDang.Text = Functions.ConvertDateTime(dgvNhaThue.CurrentRow.Cells["NGAYDANG"].Value.ToString());
            txtNgayHetHan.Text = Functions.ConvertDateTime(dgvNhaThue.CurrentRow.Cells["NGAYHETHAN"].Value.ToString());
            txtSLXem.Text = dgvNhaThue.CurrentRow.Cells["SOLUOTXEM"].Value.ToString();
            txtGia.Text = dgvNhaThue.CurrentRow.Cells["GIATHUE"].Value.ToString();
            txtPhongCon.Text = dgvNhaThue.CurrentRow.Cells["SOPHONGCON"].Value.ToString();
            Sua1.Enabled = true;
            Xoa1.Enabled = true;
        }

        private void Them1_Click(object sender, EventArgs e)
        {
            Sua1.Enabled = false;
            Xoa1.Enabled = false;
            Bo1.Enabled = true;
            Luu1.Enabled = true;
            Them1.Enabled = false;
            ResetValues();
            txtMaNha.Enabled = true;
            txtMaCN.Enabled = true;
            txtMaLoai.Enabled = true;
            txtMaChuNha.Enabled = true;
            txtMaNV.Enabled = true;
            txtSLXem.Enabled = false;
            txtMaNha.Focus();
        }
        private void ResetValues()
        {
            txtMaNha.Text = "";
            txtMaCN.Text = "";
            txtMaLoai.Text = "";
            txtMaChuNha.Text = "";
            txtMaNV.Text = "";
            txtDV.Text = "";
            txtPhong.Text = "";
            txtTT.Text = "";
            txtNgayDang.Text = "";
            txtNgayHetHan.Text = "";
            txtSLXem.Text = "0";
            txtGia.Text = "";
            txtPhongCon.Text = "";
        }

        private void Luu1_Click(object sender, EventArgs e)
        {
            if (txtMaNha.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhà", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNha.Focus();
                return;
            }
            if (txtMaCN.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã chi nhánh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaCN.Focus();
                return;
            }
            if (txtMaLoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã loại nhà", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLoai.Focus();
                return;
            }
            if (txtMaChuNha.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã chủ nhà", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaChuNha.Focus();
                return;
            }
            if (txtMaNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                return;
            }
            if (txtDV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Định vị nhà", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDV.Focus();
                return;
            }
            if (txtPhong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhong.Focus();
                return;
            }
            if (txtTT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tình trạng nhà", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTT.Focus();
                return;
            }
            if (txtNgayDang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ngày đăng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNgayDang.Focus();
                return;
            }
            if (txtNgayHetHan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ngày hết hạn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNgayHetHan.Focus();
                return;
            }
            if (txtGia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Giá thuê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGia.Focus();
                return;
            }
            if (txtPhongCon.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số phòng còn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhongCon.Focus();
                return;
            }
            string sql= "SELECT * FROM dbo.NHA WHERE MANHA = '"+txtMaNha.Text.Trim()+"'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã nhà này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNha.Focus();
                txtMaNha.Text = "";
                return;
            }
            /*string sql1, sql2;
            sql1 = "INSERT INTO dbo.NHA VALUES('" 
                +txtMaNha.Text.Trim() + "','" + txtMaCN.Text.Trim() + "','"+txtMaLoai.Text.Trim()+"','" + txtMaChuNha.Text.Trim() + "','" + txtMaNV.Text.Trim() + "',N'" 
                +txtDV.Text.Trim() + "'," + txtPhong.Text.Trim() + ",N'" + txtTT.Text.Trim() + "','" + txtNgayDang.Text.Trim() + "','" 
                + txtNgayHetHan.Text.Trim() + "'," + txtSLXem.Text.Trim() + ")";
            sql2 =   "INSERT dbo.NHATHUE(MANHA,GIATHUE,SOPHONGCON)VALUES('"+txtMaNha.Text.Trim()+"',"+txtGia.Text.Trim()+","
                +txtPhongCon.Text.Trim()+")";
            Functions.RunSQL(sql1);
            
            Functions.RunSQL(sql2);*/
            string sql1;
            sql1 = "EXEC sp_ThemNhaThue '"+txtMaNha.Text.Trim()+"','"+txtMaCN.Text.Trim()+"','"+txtMaLoai.Text.Trim()
                +"','"+txtMaChuNha.Text.Trim()+"','"+txtMaNV.Text.Trim()+"',N'"+txtDV.Text.Trim()+"',"+txtPhong.Text.Trim()+",N'"+txtTT.Text.Trim()+"','"+txtNgayDang.Text.Trim()
                +"','"+txtNgayHetHan.Text.Trim()+"',"+txtPhongCon.Text.Trim()+","+txtSLXem.Text.Trim()+","+txtGia.Text.Trim();
            Functions.RunSQL(sql1);
            LoadDataGridView();
            ResetValues();
            Xoa1.Enabled = true;
            Them1.Enabled = true;
            Sua1.Enabled = true;
            Bo1.Enabled = false;
            Luu1.Enabled = false;
            txtMaNha.Enabled = false;
            txtSLXem.Enabled = false;
        }
        private void Sua1_Click(object sender, EventArgs e)
        {
            txtSLXem.Enabled = false;
            if (txtMaNha.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNha.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhà", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNha.Focus();
                return;
            }
            if (txtMaCN.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã chi nhánh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaCN.Focus();
                return;
            }
            if (txtMaLoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã loại nhà", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLoai.Focus();
                return;
            }
            if (txtMaChuNha.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã chủ nhà", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaChuNha.Focus();
                return;
            }
            if (txtMaNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                return;
            }
            if (txtDV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Định vị nhà", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDV.Focus();
                return;
            }
            if (txtPhong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhong.Focus();
                return;
            }
            if (txtTT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tình trạng nhà", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTT.Focus();
                return;
            }
            if (txtNgayDang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ngày đăng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNgayDang.Focus();
                return;
            }
            if (txtNgayHetHan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ngày hết hạn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNgayHetHan.Focus();
                return;
            }
            if (txtGia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Giá thuê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGia.Focus();
                return;
            }
            if (txtPhongCon.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số phòng còn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhongCon.Focus();
                return;
            }
            string sql1 = "UPDATE dbo.NHA SET MACN='" + txtMaCN.Text.Trim() + "',MALOAINHA='" + txtMaLoai.Text.Trim() + "',MACHUNHA='"
                + txtMaChuNha.Text.Trim() + "',MANV='" + txtMaNV.Text.Trim() + "',DINHVI=N'" + txtDV.Text.Trim() + "',SOLUONGPHONG='" + txtPhong.Text.Trim()
                + "',TINHTRANGNHA =N'" + txtTT.Text.Trim() + "',NGAYDANG ='" + txtNgayDang.Text.Trim() + "',NGAYHETHAN ='" + txtNgayHetHan.Text.Trim()
                + "',SOlUOTXEM='" + txtSLXem.Text.Trim() + "' WHERE MANHA='" + txtMaNha.Text.Trim() + "'";
            Functions.RunSQL(sql1);
            string sql2 = "UPDATE dbo.NHATHUE SET GIATHUE='" + txtGia.Text.Trim() + "',SOPHONGCON ='" + txtPhongCon.Text.Trim() + "' WHERE MANHA='" + txtMaNha.Text.Trim() + "'";
            Functions.RunSQL(sql2);
            LoadDataGridView();
            ResetValues();
            Bo1.Enabled = false;
        }

        private void Xoa1_Click(object sender, EventArgs e)
        {
            if (txtMaNha.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string sql = "DELETE from NHA WHERE MANhA = '" + txtMaNha.Text + "'";
                Functions.RunSqlDel(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void Bo1_Click(object sender, EventArgs e)
        {
            ResetValues();
            Bo1.Enabled = false;
            Them1.Enabled = true;
            Xoa1.Enabled = true;
            Sua1.Enabled = true;
            Luu1.Enabled = false;
            txtMaNha.Enabled = false;
            txtMaCN.Enabled = false;
            txtMaLoai.Enabled = false;
            txtMaChuNha.Enabled = false;
            txtMaNV.Enabled = false;
            txtSLXem.Enabled = false;
        }
    }
}
