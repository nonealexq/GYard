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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gYardDataSetYard.Yard". При необходимости она может быть перемещена или удалена.
            this.yardTableAdapter.Fill(this.gYardDataSetYard.Yard);
            yard.SelectedIndex = -1;
        }

        string conString = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\GYard\\GYard.mdf;Integrated Security = True; Connect Timeout = 30;";
        string q = "INSERT INTO Client(last_name, first_name, patronymic, date_birth, date_death, yard, coor_1, coor_2)" +
            "VALUES(@last_name, @first_name, @patronymic, @date_birth, @date_death, @yard, @coor_1, @coor_2);";
        private void button1_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conString))
            using (SqlCommand cmd = new SqlCommand(q, con))
            {
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
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainPage mainform = new MainPage();
            mainform.Show();
        }
        private void date_birth_ValueChanged(object sender, EventArgs e)
        {
            if (date_birth.Checked == true)
            {
                date_birth.Enabled = true;
                date_birth.Format = DateTimePickerFormat.Long;
            }
            else
            {
                date_birth.Enabled = false;
                date_birth.Format = DateTimePickerFormat.Custom;
                date_birth.CustomFormat = " ";
            }
        }
        private void date_death_ValueChanged(object sender, EventArgs e)
        {
            if (date_birth.Checked == true)
            {
                date_birth.Enabled = true;
                date_birth.Format = DateTimePickerFormat.Long;
            }
            else
            {
                date_birth.Enabled = false;
                date_birth.Format = DateTimePickerFormat.Custom;
                date_birth.CustomFormat = " ";
            }
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
            "Вы действительно хотите выйти из программы?",
            "Завершение программы",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
                {
                Application.ExitThread();
                }
            else
                {
                e.Cancel = true;
                }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void yard_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}