using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GY_V0
{
    public partial class YardAll : Form
    {
        public YardAll()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainScreen mainform = new MainScreen();
            mainform.Show();
            this.Visible = false;
        }

        private void YardAll_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gYardDataSetYardAddress.Yard". При необходимости она может быть перемещена или удалена.
            this.yardTableAdapter1.Fill(this.gYardDataSetYardAddress.Yard);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gYardDataSetYard.Yard". При необходимости она может быть перемещена или удалена.
            this.yardTableAdapter.Fill(this.gYardDataSetYard.Yard);

        }

        private void YardAll_FormClosing(object sender, FormClosingEventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            YardAdd yardaddform = new YardAdd();
            yardaddform.Show();
            this.Visible = false;
        }
    }
}
