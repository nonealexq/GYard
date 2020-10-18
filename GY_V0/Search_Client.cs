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
using System.Net;

namespace GY_V0
{
    public partial class Search_Client : Form
    {
        public Search_Client()
        {
            InitializeComponent();
        }

        string conString = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\GYard\\GYard.mdf;Integrated Security = True; Connect Timeout = 30;";
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Search_Client_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                SqlDataAdapter adapt;
                this.clientTableAdapter.Fill(this.gYardDataSetClient.Client);
                con.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("select last_name, first_name, patronymic, date_birth, date_death, yard, coor_1, coor_2 from Client", con);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MainPage mainform = new MainPage();
            mainform.Show();
            this.Visible = false;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                string txt = "";

                if (textBox7.Text != "")
                    txt = "last_name LIKE '%" + textBox7.Text + "%'";
                if (textBox8.Text != "")
                {
                    if (txt != "") txt = txt + " AND ";
                    txt = txt + "first_name LIKE '%" + textBox8.Text + "%'";
                }
                if (textBox9.Text != "")
                {
                    if (txt != "") txt = txt + " AND ";
                    txt = txt + "patronymic LIKE '%" + textBox9.Text + "%'";
                }

                string sql = "Select * from Client WHERE " + txt;
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Client");

                dataGridView1.DataSource = ds.Tables["Client"].DefaultView;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                SqlDataAdapter adapt;
                this.clientTableAdapter.Fill(this.gYardDataSetClient.Client);
                con.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("select last_name, first_name, patronymic, date_birth, date_death, yard, coor_1, coor_2 from Client", con);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
        }

        private void Search_Client_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}