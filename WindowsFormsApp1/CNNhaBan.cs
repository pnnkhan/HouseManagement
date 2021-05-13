using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmCNNhaBan : Form
    {
        DangNhap f2;
        public FrmCNNhaBan(DangNhap frm2)
        {
            InitializeComponent();
            f2 = frm2;
        }

        private void FrmCNNhaBan_Load(object sender, EventArgs e)
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
            string TENDANGNHAP = "hihi";
            string query1 = "exec sp_XemNhaBan '" + TENDANGNHAP + "'";
            data = Functions.GetDataToTable(query1, f2); //lấy dữ liệu
            dgvNhaBan.DataSource = data;
        }

        private void dgvNhaBan_Click(object sender, EventArgs e)
        {
            if (Them1.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNha.Focus();
                return;
            }
            txtMaNha.Text = dgvNhaBan.CurrentRow.Cells["MaNha"].Value.ToString();
            txtMaCN.Text = dgvNhaBan.CurrentRow.Cells["MaCN"].Value.ToString();
            txtMaLoai.Text = dgvNhaBan.CurrentRow.Cells["MaLoaiNha"].Value.ToString();
            txtMaChuNha.Text = dgvNhaBan.CurrentRow.Cells["MaChuNha"].Value.ToString();
            txtMaNV.Text = dgvNhaBan.CurrentRow.Cells["MaNV"].Value.ToString();
            txtMaKH.Text = dgvNhaBan.CurrentRow.Cells["MaKH"].Value.ToString();
            txtDV.Text = dgvNhaBan.CurrentRow.Cells["DINHVI"].Value.ToString();
            txtPhong.Text = dgvNhaBan.CurrentRow.Cells["SOLUONGPHONG"].Value.ToString();
            txtTT.Text = dgvNhaBan.CurrentRow.Cells["TINHTRANGNHA"].Value.ToString();
            txtNgayDang.Text = Functions.ConvertDateTime(dgvNhaBan.CurrentRow.Cells["NGAYDANG"].Value.ToString());
            txtNgayHetHan.Text = Functions.ConvertDateTime(dgvNhaBan.CurrentRow.Cells["NGAYHETHAN"].Value.ToString());
            txtSLXem.Text = dgvNhaBan.CurrentRow.Cells["SOLUOTXEM"].Value.ToString();
            txtGia.Text = dgvNhaBan.CurrentRow.Cells["GIABAN"].Value.ToString();
            txtDK.Text = dgvNhaBan.CurrentRow.Cells["DIEUKIEN"].Value.ToString();
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
            txtDK.Text = "";
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
            if (txtDK.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập điều kiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDK.Focus();
                return;
            }
            string sql = "SELECT * FROM dbo.NHA WHERE MANHA = '" + txtMaNha.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã nhà này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNha.Focus();
                txtMaNha.Text = "";
                return;
            }
            string sql1, sql2;
            sql1 = "INSERT INTO dbo.NHA(MANHA,MACN,MALOAINHA,MACHUNHA,MANV,DINHVI,SOLUONGPHONG,TINHTRANGNHA,NGAYDANG,NGAYHETHAN,SOLUOTXEM)VALUES('"
                + txtMaNha.Text.Trim() + "','" + txtMaCN.Text.Trim() + "','" + txtMaLoai.Text.Trim() + "','" + txtMaChuNha.Text.Trim() + "','" + txtMaNV.Text.Trim() + "',N'"
                + txtDV.Text.Trim() + "'," + txtPhong.Text.Trim() + ",N'" + txtTT.Text.Trim() + "','" + txtNgayDang.Text.Trim() + "','"
                + txtNgayHetHan.Text.Trim() + "'," + txtSLXem.Text.Trim() + ")";
            sql2 = "INSERT dbo.NHABAN(MANHA,MAKH,GIABAN,DIEUKIEN)VALUES('" + txtMaNha.Text.Trim() + "','" + txtMaKH.Text.Trim() + "'," + txtGia.Text.Trim() + ","
                + txtDK.Text.Trim() + ")";
            Functions.RunSQL(sql1);

            Functions.RunSQL(sql2);
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
            if (txtDK.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập điều kiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDK.Focus();
                return;
            }
            string sql1 = "UPDATE dbo.NHA SET MACN='" + txtMaCN.Text.Trim() + "',MALOAINHA='" + txtMaLoai.Text.Trim() + "',MACHUNHA='"
                + txtMaChuNha.Text.Trim() + "',MANHANVIEN='" + txtMaNV.Text.Trim() + "',DINHVI=N'" + txtDV.Text.Trim() + "',SOLUONGPHONG='" + txtPhong.Text.Trim()
                + "',TINHTRANGNHA =N'" + txtTT.Text.Trim() + "',NGAYDANG ='" + txtNgayDang.Text.Trim() + "',NGAYHETHAN ='" + txtNgayHetHan.Text.Trim()
                + "',SOlUOTXEM='" + txtSLXem.Text.Trim() + "' WHERE MANHA='" + txtMaNha.Text.Trim() + "'";
            Functions.RunSQL(sql1);
            string sql2 = "UPDATE dbo.NHABAN SET GIABAN='" + txtGia.Text.Trim() + "',DIEUKIEN ='" + txtDK.Text.Trim() + "',MAKH='"+txtMaKH.Text.Trim()+"', WHERE MANHA='" + txtMaNha.Text.Trim() + "'";
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
                string sql = "DELETE tblNhanVien WHERE MaNhanVien=N'" + txtMaNha.Text + "'";
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
            txtMaKH.Enabled = false;
            txtSLXem.Enabled = false;
        }
    }
}
