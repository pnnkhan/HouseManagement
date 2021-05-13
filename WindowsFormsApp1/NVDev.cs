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
    public partial class NVDev : Form
    {
        DangNhap f2;
        public NVDev(DangNhap frm2)
        {
            InitializeComponent();
            f2 = frm2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void helloToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtALTF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien f = new QuanLyNhanVien(f2);
            f.ShowDialog();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
           QuanLyKhachHang f = new QuanLyKhachHang(f2);
           f.ShowDialog();
        }

        private void mởRộngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void chỉnhSửaTênKHVàNVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditTenKH_NV f = new EditTenKH_NV(f2);
            f.ShowDialog();
        }

        private void chỉnhSửaVịTríLàmViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChinhSuaViTri f = new ChinhSuaViTri(f2);
            f.ShowDialog();
        }
    }
}
