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
    public partial class TimNha : Form
    {
        string thanhPho = "";
        public TimNha()
        {
            InitializeComponent();
            comboBox1.Items.Add("Bà Rịa");
            comboBox1.Items.Add("Bạc Liêu");
            comboBox1.Items.Add("Bảo Lộc");
            comboBox1.Items.Add("Bắc Giang");
            comboBox1.Items.Add("Bắc Kạn");
            comboBox1.Items.Add("Bắc Ninh");
            comboBox1.Items.Add("Bến Tre");
            comboBox1.Items.Add("Biên Hòa");
            comboBox1.Items.Add("Buôn Ma Thuột");
            comboBox1.Items.Add("Cà Mau");
            comboBox1.Items.Add("Cam Ranh");
            comboBox1.Items.Add("Cao Bằng");
            comboBox1.Items.Add("Cao Lãnh");
            comboBox1.Items.Add("Cẩm Phả");
            comboBox1.Items.Add("Cần Thơ");
            comboBox1.Items.Add("Châu Đốc");
            comboBox1.Items.Add("Chí Linh");
            comboBox1.Items.Add("Dĩ An");
            comboBox1.Items.Add("Đà Lạt");
            comboBox1.Items.Add("Đà Nẵng");
            comboBox1.Items.Add("Điện Biên Phủ");
            comboBox1.Items.Add("Đông Hà");
            comboBox1.Items.Add("Đồng Hới");
            comboBox1.Items.Add("Đồng Xoài");
            comboBox1.Items.Add("Gia Nghĩa");
            comboBox1.Items.Add("Hải Dương");
            comboBox1.Items.Add("Hà Giang");
            comboBox1.Items.Add("Hà Tiên");
            comboBox1.Items.Add("Hà Tĩnh");
            comboBox1.Items.Add("Hạ Long");
            comboBox1.Items.Add("Hà Nội");
            comboBox1.Items.Add("Hải Phòng");
            comboBox1.Items.Add("Hòa Bình");
            comboBox1.Items.Add("Hội An");
            comboBox1.Items.Add("Hồ Chí Minh");
            comboBox1.Items.Add("Hồng Ngự");
            comboBox1.Items.Add("Huế");
            comboBox1.Items.Add("Hưng Yên");
            comboBox1.Items.Add("Kon Tum");
            comboBox1.Items.Add("Lai Châu");
            comboBox1.Items.Add("Lào Cai");
            comboBox1.Items.Add("Lạng Sơn");
            comboBox1.Items.Add("Long Khánh");
            comboBox1.Items.Add("Long Xuyên");
            comboBox1.Items.Add("Móng Cái");
            comboBox1.Items.Add("Mỹ Tho");
            comboBox1.Items.Add("Nam Định");
            comboBox1.Items.Add("Ngã Bảy");
            comboBox1.Items.Add("Nha Trang");
            comboBox1.Items.Add("Ninh Bình");
            comboBox1.Items.Add("Phan Rang");
            comboBox1.Items.Add("Phan Thiết");
            comboBox1.Items.Add("Phú Quốc");
            comboBox1.Items.Add("Phúc Yên");
            comboBox1.Items.Add("Phủ Lý");
            comboBox1.Items.Add("Pleiku");
            comboBox1.Items.Add("Quảng Ngãi");
            comboBox1.Items.Add("Quy Nhơn");
            comboBox1.Items.Add("Rạch Giá");
            comboBox1.Items.Add("Sa Đéc");
            comboBox1.Items.Add("Sầm Sơn");
            comboBox1.Items.Add("Sóc Trăng");
            comboBox1.Items.Add("Sông Công");
            comboBox1.Items.Add("Sơn La");
            comboBox1.Items.Add("Tam Điệp");
            comboBox1.Items.Add("Tam Kỳ");
            comboBox1.Items.Add("Tân An");
            comboBox1.Items.Add("Tây Ninh");
            comboBox1.Items.Add("Thanh Hóa");
            comboBox1.Items.Add("Thái Bình");
            comboBox1.Items.Add("Thái Nguyên");
            comboBox1.Items.Add("Thủ Dầu Một");
            comboBox1.Items.Add("Thuận An");
            comboBox1.Items.Add("Trà Vinh");
            comboBox1.Items.Add("Tuyên Quang");
            comboBox1.Items.Add("Tuy Hòa");
            comboBox1.Items.Add("Uông Bí");
            comboBox1.Items.Add("Việt Trì");
            comboBox1.Items.Add("Vinh");
            comboBox1.Items.Add("Vị Thanh");
            comboBox1.Items.Add("Vĩnh Long");
            comboBox1.Items.Add("Vĩnh Yên");
            comboBox1.Items.Add("Vũng Tàu");
            comboBox1.Items.Add("Yên Bái");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (thanhPho != comboBox1.Text)
            {
                thanhPho = comboBox1.Text;
                comboBox2.Text = "";
                comboBox2.Items.Clear();
                if (comboBox1.Text == "Hà Nội" || comboBox1.Text == "Hải Phòng" || comboBox1.Text == "Đà Nẵng" || comboBox1.Text == "Hồ Chí Minh" || comboBox1.Text == "Cần Thơ")
                {
                    if (comboBox1.Text == "Hà Nội")
                    {
                        comboBox2.Items.Add("Ba Đình");
                        comboBox2.Items.Add("Đống Đa");
                        comboBox2.Items.Add("Hoàn Kiếm");
                        comboBox2.Items.Add("Hai Bà Trưng");
                        comboBox2.Items.Add("Tây Hồ");
                        comboBox2.Items.Add("Long Biên");
                        comboBox2.Items.Add("Hoàng Mai");
                        comboBox2.Items.Add("Cầu Giấy");
                        comboBox2.Items.Add("Thanh Xuân");
                        comboBox2.Items.Add("Hà Long");
                        comboBox2.Items.Add("Bắc Từ Liêm");
                        comboBox2.Items.Add("Nam Từ Liêm");
                    }
                    else if (comboBox1.Text == "Hải Phòng")
                    {
                        comboBox2.Items.Add("Hồng Bàng");
                        comboBox2.Items.Add("Lê Chân");
                        comboBox2.Items.Add("Ngô Quyền");
                        comboBox2.Items.Add("Hải An");
                        comboBox2.Items.Add("Kiến An");
                        comboBox2.Items.Add("Dương Kinh");
                        comboBox2.Items.Add("Đồ Sơn");
                    }
                    else if (comboBox1.Text == "Đà Nẵng")
                    {
                        comboBox2.Items.Add("Hải Châu");
                        comboBox2.Items.Add("Thanh Khê");
                        comboBox2.Items.Add("Liên Chiểu");
                        comboBox2.Items.Add("Sơn Trà");
                        comboBox2.Items.Add("Ngũ Hành Sơn");
                        comboBox2.Items.Add("Cẩm Lệ");
                    }
                    else if (comboBox1.Text == "Hồ Chí Minh")
                    {
                        comboBox2.Items.Add("Quận 1");
                        comboBox2.Items.Add("Quận 3");
                        comboBox2.Items.Add("Quận 4");
                        comboBox2.Items.Add("Quận 5");
                        comboBox2.Items.Add("Quận 6");
                        comboBox2.Items.Add("Quận 7");
                        comboBox2.Items.Add("Quận 8");
                        comboBox2.Items.Add("Quận 10");
                        comboBox2.Items.Add("Quận 11");
                        comboBox2.Items.Add("Quận 12");
                        comboBox2.Items.Add("Gò Vấp");
                        comboBox2.Items.Add("Bình Thạnh");
                        comboBox2.Items.Add("Phú Nhuận");
                        comboBox2.Items.Add("Bình Tân");
                        comboBox2.Items.Add("Tân Bình");
                        comboBox2.Items.Add("Tân Phú");
                    }
                    else
                    {
                        comboBox2.Items.Add("Ninh Kiều");
                        comboBox2.Items.Add("Bình Thủy");
                        comboBox2.Items.Add("Cái Răng");
                        comboBox2.Items.Add("Ô Môn");
                        comboBox2.Items.Add("Thốt Nốt");
                    }
                } 
            }    
            
            comboBox2.Items.Add("");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                comboBox1.Text = "";
                comboBox2.Text = "";
                this.Close();
            }
            else if (comboBox1.Text.Length != 0)
                this.Close();
            else
                MessageBox.Show("Vui lòng chọn thành phố!");

        }

    }
}
