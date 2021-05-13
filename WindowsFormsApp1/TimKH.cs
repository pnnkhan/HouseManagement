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
    public partial class TimKH : Form
    {
        public TimKH()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox1.Text = "";
                this.Close();
            }
            else if (textBox1.TextLength != 0)
            {
                this.Close();
            }    
            else
                MessageBox.Show("Vui lòng nhập dữ liệu!");
        }
    }
}
