﻿using System;
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
    public partial class Search_Client : Form
    {
        public Search_Client()
        {
            InitializeComponent();
        }
 
        string conString = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Kristina\\source\\repos\\GY_V0\\ADB\\GYard.mdf;Integrated Security = True; Connect Timeout = 30;";

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Search_Client_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                //SqlCommand cmd;
                SqlDataAdapter adapt;
                // TODO: данная строка кода позволяет загрузить данные в таблицу "gYardDataSetClient.Client". При необходимости она может быть перемещена или удалена.
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
            this.Close();
        }
    }
}
