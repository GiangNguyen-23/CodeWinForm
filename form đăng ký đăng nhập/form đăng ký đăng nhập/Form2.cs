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

namespace form_đăng_ký_đăng_nhập
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string b = "!,./+-@#$%^&*()";
            int dem = 0;
            if (textBox1.Text.Length==0 || textBox2.Text.Length==0 || textBox3.Text.Length == 0 || textBox4.Text.Length == 0 || textBox5.Text.Length == 0)
            {
                MessageBox.Show("Yêu cầu nhập đủ thông tin");
               
            }
            else
            if(1==1)
            {
                foreach (char c in b)
                {


                    if (textBox4.Text.Contains(c) || textBox5.Text.Contains(c))
                    {
                        dem = 1;
                    }
                }
                if (dem == 1)
                {
                    MessageBox.Show("mật khẩu chứa ký tự đặc biệt");
                }
                else
                if (textBox4.Text != textBox5.Text)
                {
                    MessageBox.Show("Nhập mật khẩu chưa trùng khớp nhau");
                }
                else
                {
                    DialogResult = MessageBox.Show("bạn có muốn đăng ký không?", "đăng ký", MessageBoxButtons.YesNo);
                    if (DialogResult == DialogResult.Yes)
                    {
                        MessageBox.Show("Bạn đăng ký thành công");
                        Form f3 = new Form3();
                        f3.Show();


                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                textBox4.UseSystemPasswordChar = false;
                
            }
            else
                textBox4.UseSystemPasswordChar= true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked) 
            {
                textBox5.UseSystemPasswordChar = false;
            }else
                textBox5.UseSystemPasswordChar= true;
        }
    }
}
