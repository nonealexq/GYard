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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Yard1 newYard1 = new Yard1();
            newYard1.Show();
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Yard2 newYard2 = new Yard2();
            newYard2.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPage mainform = new MainPage();
            mainform.Show();
            this.Close();
        }
    }
}
