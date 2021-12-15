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
    public partial class Form5 : Form
    {
        SqlCommand cmd;
        SqlConnection conn;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        string H = @"Data Source=DESKTOP-OSVGS4N\SQLEXPRESS;Initial Catalog=AA,Integrated Security=true";
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(H);
            conn.Open();
            string m = "SELECT Users.Email, Users.Password, Role.RoleName FROM Users,Role";
            cmd = new SqlCommand(m, conn);
            reader = cmd.ExecuteReader();
            while(reader.Read())
            {

                string Email = reader.GetString(0);
                string Password = reader.GetString(1);
                string RoleName = reader.GetString(1);
                if(Email == textBox1.Text && Password == textBox2.Text)
                {
                    if(RoleName == "Бегун")
                    {
                        Form6 f6 = new Form6();
                        f6.Show();
                        this.Hide();
                    }
                    if(RoleName == "Координатор")
                    {
                        Form7 f7 = new Form7();
                        f7.Show();
                        this.Hide();
                    }
                    if(RoleName == "Администратор")
                    {
                        Form8 f8 = new Form8();
                        f8.Show();
                        this.Hide();
                    }
                    
                }
            }
            MessageBox.Show("Данные не введены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
