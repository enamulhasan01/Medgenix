using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medgenix
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            LogIn lg = new LogIn();
           
            this.Hide();

            lg.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration rg = new Registration();
            this.Hide(); rg.Visible = true;
        }
    }
}
