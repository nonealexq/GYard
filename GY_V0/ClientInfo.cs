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
    public partial class ClientInfo : Form
    {
        public ClientInfo()
        {
            InitializeComponent();
        }

        private void BackToSearchClient_Click(object sender, EventArgs e)
        {
            SearchClient searchform = new SearchClient();
            searchform.Show();
            this.Visible = false;
        }

        private void ClientInfo_Load(object sender, EventArgs e)
        {
            ClientInfoTextBox.Text = ClassClientInfo.text;
        }

        private void ClientInfo_FormClosing(object sender, FormClosingEventArgs e)
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
