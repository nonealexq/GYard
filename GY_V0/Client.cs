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

        private void Client_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gYardDataSetYard.Yard". При необходимости она может быть перемещена или удалена.
            this.yardTableAdapter.Fill(this.gYardDataSetYard.Yard);
            YardName.SelectedIndex = -1;
        }

        private void SaveClient_Click(object sender, EventArgs e)
        {
            //проверка на заполненность фамилии
            if (LastName.Text == "")
            {
                DialogResult = MessageBox.Show("Поле Фамилия не заполнено!",
                    "Ошибка!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            //проверка на заполненность имени
            if (FirstName.Text == "")
            {
                DialogResult = MessageBox.Show("Поле Имя не заполнено!",
                    "Ошибка!",
                   MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            //проверка на заполненность отчества
            if (Patronymic.Text == "")
            {
                DialogResult = MessageBox.Show("Поле Отчетсво не заполнено!",
                    "Ошибка!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            //проверка на заполненность кладбища
            if (YardName.Text == "")
            {
                DialogResult = MessageBox.Show("Поле Кладбище не заполнено!",
                    "Ошибка!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            //проверка на заполненность координат
            if (GPS1.Text == "")
            {
                DialogResult dialog = MessageBox.Show(
                    "Вы не заполнили поле Координата 1. Продолжить?",
                    "Внимание!",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    InfoToDataBase();
                    return;
                }
                else
                {
                    return;
                }
            }
            else if (GPS2.Text == "")
            {
                DialogResult dialog = MessageBox.Show(
                    "Вы не заполнили поле Координата 2. Продолжить?",
                    "Внимание!",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    InfoToDataBase();
                    return;
                }
                else
                {
                    return;
                }
            };
            //вызов метода, который кладет данные в базу
            InfoToDataBase();
        }
        private void BackToMain_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainScreen mainform = new MainScreen();
            mainform.Show();
        }
        private void DateBirth_ValueChanged(object sender, EventArgs e)
        {
            if (DateBirth.Checked == true)
            {
                DateBirth.Enabled = true;
                DateBirth.Format = DateTimePickerFormat.Long;
            }
            else
            {
                DateBirth.Enabled = false;
                DateBirth.Format = DateTimePickerFormat.Custom;
                DateBirth.CustomFormat = " ";
            }
        }
        private void DateDeath_ValueChanged(object sender, EventArgs e)
        {
            if (DateBirth.Checked == true)
            {
                DateBirth.Enabled = true;
                DateBirth.Format = DateTimePickerFormat.Long;
            }
            else
            {
                DateBirth.Enabled = false;
                DateBirth.Format = DateTimePickerFormat.Custom;
                DateBirth.CustomFormat = " ";
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
        
        //метод, который кладет данные в базу
        private void InfoToDataBase()
        {
            string conString = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\GYard\\GYard.mdf;Integrated Security = True; Connect Timeout = 30;";
            string q = "INSERT INTO Client(last_name, first_name, patronymic, date_birth, date_death, yard, coor_1, coor_2)" +
                "VALUES(@last_name, @first_name, @patronymic, @date_birth, @date_death, @yard, @coor_1, @coor_2);";

            using (SqlConnection con = new SqlConnection(conString))
            using (SqlCommand cmd = new SqlCommand(q, con))
            {
                cmd.Parameters.Add(new SqlParameter("@last_name", LastName.Text));
                cmd.Parameters.Add(new SqlParameter("@first_name", FirstName.Text));
                cmd.Parameters.Add(new SqlParameter("@patronymic", Patronymic.Text));
                cmd.Parameters.Add(new SqlParameter("@date_birth", DateBirth.Value.Date));
                cmd.Parameters.Add(new SqlParameter("@date_death", DateDeath.Value.Date));
                cmd.Parameters.Add(new SqlParameter("@yard", YardName.Text));
                cmd.Parameters.Add(new SqlParameter("@coor_1", GPS1.Text));
                cmd.Parameters.Add(new SqlParameter("@coor_2", GPS2.Text));

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Данные добавлены");
                con.Close();
            }
        }
    }
}