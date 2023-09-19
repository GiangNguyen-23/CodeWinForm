using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace de4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text=="1")
            {
                textBox2.Text = "Nguyễn Văn Một";
            }
            if(comboBox1.Text=="2")
            {
                textBox2.Text = "Nguyễn Văn Hai";
            }
            if (comboBox1.Text == "3")
            {
                textBox2.Text = "Nguyễn Văn Ba";
            }
            if (comboBox1.Text == "4")
            {
                textBox2.Text = "Nguyễn Văn Bốn";
            }
            if (comboBox1.Text == "5")
            {
                textBox2.Text = "Nguyễn Văn Năm";
            }
            if(comboBox1.Text =="null")
            {
                textBox2.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int diem1 = 0;
            if(int.TryParse(textBox1.Text, out diem1) && (diem1>=0 && diem1<=10)) 
            { 

            }
            else
            {
                MessageBox.Show("nhập sai dữ liệu", "nhập điểm Toán");
            }
    }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int diem2 = 0;
            if (int.TryParse(textBox3.Text, out diem2) && (diem2 >= 0 && diem2 <= 10))
            {

            }
            else
            {
                MessageBox.Show("nhập sai dữ liệu", "Nhập điểm Văn");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            int diem3 = 0;
            if (int.TryParse(textBox4.Text, out diem3) && (diem3 >= 0 && diem3 <= 10))
            {

            }
            else
            {
                MessageBox.Show("nhập sai dữ liệu", "Nhập điểm Ngoại ngữ");
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            
    }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
