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
    public partial class Yard1 : Form
    {
        public Yard1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            YardAll yardform = new YardAll();
            yardform.Show();
            this.Visible = false;
        }

        private void Yard1_Load(object sender, EventArgs e)
        {

        }

        private void Yard1_FormClosing(object sender, FormClosingEventArgs e)
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
