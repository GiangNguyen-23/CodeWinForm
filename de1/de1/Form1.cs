using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace de1
{
    public partial class Form1 : Form
    {
        private bool Check = false;
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {
            DialogResult chon = MessageBox.Show("bạn muốn thanh toán?", "Thanh toán", MessageBoxButtons.YesNo);
            if(chon== DialogResult.Yes)
            {
                foreach(Button i in tableLayoutPanel1.Controls)
                {
                    if (i.BackColor == Color.Green)
                    {
                        i.BackColor = Color.Red;
                        i.Enabled = false;
                        tong = 0;
                        label5.Text=tong.ToString();

                    }

                }
            }
            
        }
        int tong = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            Button a = (Button)sender;
            if(a.BackColor == Color.Green )
            {
                if(a.Text.Contains("A")==true)
                {
                    tong -= 25000;
                    a.BackColor = Color.LightBlue;
                }
                if(a.Text.Contains("B")==true)
                {
                    tong -= 30000;
                    a.BackColor = Color.LightGreen;
                }
                if(a.Text.Contains("C") == true)
                {
                    tong -= 35000;
                    a.BackColor = Color.LightYellow;

                }
                if( a.Text.Contains("D")== true)
                {
                    tong -= 40000;
                    a.BackColor = Color.LightSalmon;
                }
                if (a.Text.Contains("E") == true)
                {
                    tong -= 50000;
                    a.BackColor = Color.Violet;

                }
                if (a.Text.Contains("F") == true)
                {
                    tong -= 45000;
                    a.BackColor = Color.Pink;
                }

            }
            else
            {
                a.BackColor = Color.Green;
                if (a.Text.Contains("A") == true)
                {
                    tong += 25000;

                }
                if (a.Text.Contains("B") == true)
                {
                    tong += 30000;
           
                }
                if (a.Text.Contains("C") == true)
                {
                    tong += 35000;
                  

                }
                if (a.Text.Contains("D") == true)
                {
                    tong += 40000;
                    
                }
                if (a.Text.Contains("E") == true)
                {
                    tong += 50000;
                   

                }
                if (a.Text.Contains("F") == true)
                {
                    tong += 45000;
                
                }
            }
            label5.Text=tong.ToString();

}

        
    }
}
