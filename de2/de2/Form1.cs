using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace de2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=GIANGNGUYEN\MSSQLSERVER01;Initial Catalog=Bang1;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from thongTinSV",con);
            SqlDataAdapter adaper = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adaper.Fill(dt);
            dataGridView1.DataSource= dt;
            con.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            comboBox1.Text = null;
            numericUpDown1.Value = 0;
            textBox3 = null;
            textBox4 = null;
        }
    }
}
