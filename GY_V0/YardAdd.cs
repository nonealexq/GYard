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
    public partial class YardAdd : Form
    {
        public YardAdd()
        {
            InitializeComponent();
        }

        private void YardAdd_FormClosing(object sender, FormClosingEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            YardAll yardallform = new YardAll();
            yardallform.Show();
            this.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        string conString = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\GYard\\GYard.mdf;Integrated Security = True; Connect Timeout = 30;";
        string q = "INSERT INTO Yard(yard_name, yard_address, y_creation)" +
            "VALUES(@yard_name, @yard_address, GetDate());";

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conString))
            using (SqlCommand cmd = new SqlCommand(q, con))
            {
                cmd.Parameters.Add(new SqlParameter("@yard_name", yard_name.Text));
                cmd.Parameters.Add(new SqlParameter("@yard_address", yard_address.Text));

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Данные добавлены");
                con.Close();
            }
        }
    }
}
