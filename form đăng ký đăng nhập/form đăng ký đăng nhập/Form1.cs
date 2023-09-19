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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string b = "@#$%^&*()";
            int dem = 0;
            if (textBox1.Text.Length == 0 && textBox2.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập usename và mật khẩu");
            }
            else
            if (textBox1.Text.Length == 0 && textBox2.Text.Length!=0)
            {
                MessageBox.Show("Bạn chưa nhập usename");
            }
            else
            if (textBox1.Text.Length != 0 && textBox2.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu");
            }
            else
            {
                foreach (char c in b)
            {
                if(textBox2.Text.Contains(c))
                {
                    dem = 1;
                }
                
            }
            if(dem==1)
            {
                MessageBox.Show("mật khẩu chứa ký tự đặc biệt");

            }
                else
                {
                    DialogResult = MessageBox.Show("bạn có muốn đăng nhập không?", "đăng nhập", MessageBoxButtons.YesNo);
                    if(DialogResult == DialogResult.Yes)
                    {
                        MessageBox.Show("Bạn đăng nhập thành công");
                        Form3 form3 = new Form3();
                        form3.Show();
                    }
                    
                  
                }

            }
            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
                textBox2.UseSystemPasswordChar = true;
        }
    }
           
        }
    


