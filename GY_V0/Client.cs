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

namespace GY_V0
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Client_Load(object sender, EventArgs e)
        {

        }

        private string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Kristina\\Documents\\GY_V0.mdf;Integrated Security=True;Connect Timeout=30";

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            {
                SqlConnection con = new SqlConnection(conString);

                con.Open();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    string q = "insert into Client(client_id, last_name, first_name)" +
                        " values('" + client_id.Text.ToString() + "','" + last_name.Text.ToString() + "','" + first_name.Text.ToString() + "') ";
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Данные добавлены!");
                }

                con.Close();
            }
        }

    }
}
