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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }
        private void MainScreen_Load(object sender, EventArgs e)
        {

        }
        private void OpenYardAllForm_Click(object sender, EventArgs e)
        {
            YardAll newYard = new YardAll();
            newYard.Show();
            this.Visible = false;
        }
        private void OpenClientForm_Click(object sender, EventArgs e)
        {
            Client newClient = new Client();
            newClient.Show();
            this.Visible = false;
        }
        private void ExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void OpenSearchClientForm_Click(object sender, EventArgs e)
        {
            SearchClient SClient = new SearchClient();
            SClient.Show();
            this.Visible = false;
        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
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
