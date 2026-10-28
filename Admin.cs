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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void MngDssData_Click(object sender, EventArgs e)
        {
            MngDssDtaPanel.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            ViewAvailabeData ViewAvaiData = new ViewAvailabeData();
            ViewAvaiData.Show();
           
        }

        private void ReviewData_Click(object sender, EventArgs e)
        {
            Disease Dss = new Disease();
            Dss.Show();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            MngDssDtaPanel.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManageMod MngMod = new ManageMod();
            MngMod.Show();
            
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void ManagePatient_Click(object sender, EventArgs e)
        {
            ManagePatient MngPai = new ManagePatient();
            MngPai.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MngModSup.Visible = true;
        }

        private void ManageStatus_Click(object sender, EventArgs e)
        {
            ManageUserStatusPan.Visible = true;
        }

        private void ManageContributor_Click(object sender, EventArgs e)
        {
            ManageContri MngContri = new ManageContri();
            MngContri.Show();
        }

        private void MngModSupClose_Click(object sender, EventArgs e)
        {
            MngModSup.Visible=false;
        }

        private void Notifications_Click(object sender, EventArgs e)
        {
            this.Hide();
            Supervisor a = new Supervisor();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManageSup MngSup = new ManageSup();
            MngSup.Show();
        }

        private void ManageResearcher_Click(object sender, EventArgs e)
        {
            ManageResearcher MngRes = new ManageResearcher();
            MngRes.Show();
        }

        private void ManageIC_Click(object sender, EventArgs e)
        {
            ManageIClint MngIC = new ManageIClint();
            MngIC.Show();
        }

        private void HomePage_Click(object sender, EventArgs e)
        {
            MainPage mg = new MainPage();
            this.Hide();
            mg.Show();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
