using Medgenix;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medgenix
{
    public partial class Supervisor : Form
    {

        private List<ContributorData> contributorList;
        private List<ContributorData> moderatorList;

        private int contributorIndex = 0;
        private int moderatorIndex = 0;

        public Supervisor()
        {
            InitializeComponent();

            int count = UseDatabase.GetPendingCount(UserSession.Role);
            if (count > 0)
            {
                MessageBox.Show($"🔔 You have {count} pending requests");
            }

        }

        private void button8_Click(object sender, EventArgs e) 
        {
            contributorList = UseDatabase.GetPendingData("Contributor");
            contributorIndex = 0;

            if (contributorList.Count == 0)
            {
                MessageBox.Show("No contributor data");
                return;
            }

            OpenApprovalForm(contributorList[contributorIndex]);
        }



       

        private void button9_Click(object sender, EventArgs e)
        {
            moderatorList = UseDatabase.GetPendingData("Moderator");
            moderatorIndex = 0;

            if (moderatorList.Count == 0)
            {
                MessageBox.Show("No moderator data");
                return;
            }

            OpenApprovalForm(moderatorList[moderatorIndex]);
        }


     



        private void OpenApprovalForm(ContributorData data)
        {
            ApprovalForm frm = new ApprovalForm();
            frm.ShowDialog();
        }

        private void Supervisor_Load(object sender, EventArgs e)
        {
                 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mg = new MainPage();
            mg.ShowDialog();
        }
    }

}
 