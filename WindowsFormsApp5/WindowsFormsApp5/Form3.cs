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

namespace WindowsFormsApp5
{
    public partial class Form3 : Form
    {
        int price = 0;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        string G = @"Data Sorce=DESKTOP-OSVGS4N\SQLEXPRESS;Initial Catalog=AA;Integrated Security=true;";
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void F()
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            price += 10;
            label10.Text = "$" + Convert.ToString(price); ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (price > 10)
            {
                price -= 10;
                label10.Text = "$" + Convert.ToString(price); ;
            }
        }
    }
}
