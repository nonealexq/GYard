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
using System.IO;

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

        // private string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Kristina\\source\\repos\\GY_V0\\ADB\\GY_V0.mdf;Integrated Security=True;Connect Timeout=30";


        private void button1_Click(object sender, EventArgs e)
        {
        }

        string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Kristina\\source\\repos\\GY_V0\\ADB\\GY_V0.mdf;Integrated Security=True;Connect Timeout=30";
        string q = "INSERT INTO Client(client_id, last_name, first_name, patronymic, date_birth, date_death, yard, coor_1, coor_2) " +
            "VALUES(@client_id, @last_name, @first_name, @patronymic, @date_birth, @date_death, @yard, @coor_1,@coor_2);";


        private void button1_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conString))
            using (SqlCommand cmd = new SqlCommand(q, con))
            {
                cmd.Parameters.Add(new SqlParameter("@client_id", client_id.Text));
                cmd.Parameters.Add(new SqlParameter("@last_name", last_name.Text));
                cmd.Parameters.Add(new SqlParameter("@first_name", first_name.Text));
                cmd.Parameters.Add(new SqlParameter("@patronymic", patronymic.Text));
                cmd.Parameters.Add(new SqlParameter("@date_birth", date_birth.Value.Date));
                cmd.Parameters.Add(new SqlParameter("@date_death", date_death.Value.Date));
                cmd.Parameters.Add(new SqlParameter("@yard", yard.Text));
                cmd.Parameters.Add(new SqlParameter("@coor_1", coor_1.Text));
                cmd.Parameters.Add(new SqlParameter("@coor_2", coor_2.Text));

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Данные добавлены");
                con.Close();


                //SqlConnection con = new SqlConnection(conString);
                //con.Open();

                //if (con.State == System.Data.ConnectionState.Open)
                // {
                //    string q = "insert into Client(client_id, last_name, first_name, patronymic, date_birth, date_death, yard, coor_1, coor_2)" +
                //         " values('" + client_id.Text.ToString() + "','" + last_name.Text.ToString() + "','" + first_name.Text.ToString() + "','" + patronymic.Text.ToString() + "','" + date_birth.Value.Date + "','" + date_death.Value.Date + "','" + yard.Text.ToString() + "','" + coor_1.Text.ToString() + "','" + coor_2.Text.ToString() + "') ";
                //    SqlCommand cmd = new SqlCommand(q, con);
                //    cmd.ExecuteNonQuery();
                //     MessageBox.Show("Данные добавлены");
                //  }

                //  con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainPage mainform = new MainPage();
            mainform.Show();
            this.Close();
        }
    }
}
