using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Medgenix
{
   

    public partial class Data_Input : Form
    {
       
        private ContributorData tempData = new ContributorData();
        public void ApplyRole()
        {
            if (UserSession.Role == "Moderator")
            {
                label8.Visible = false;
                Show_RE_D.Visible = false;
                Claim.Visible = false;
            }
        }

       

        
        
        
        public Data_Input()
        {
            InitializeComponent();
            this.Load += (s, e) => ApplyRole();
            ApplyRole2();
        }




        public void ApplyRole2()
        {
            if (UserSession.Role == "Contributor")
            {
                Show_RE_D.Visible = true;
                Claim.Visible = true;

                int reward = UseDatabase.GetRewardForContributor(UserSession.UserId);

                if (reward > 0)
                    Show_RE_D.Text = $"Data approved. You have got {reward} reward point";
                else
                    Show_RE_D.Text = "No reward Point. Wair for  Data Approval";
            }
        }







        private void button1_Click(object sender, EventArgs e)
        {
            tempData.SubmittedByRole = UserSession.Role;

            UseDatabase.InsertTempData(tempData);

            MessageBox.Show("✅ Data submitted for supervisor review");

            tempData = new ContributorData();
            ClearForm();
        }

        private void ClearForm()
        {
            DssNamecomboBox.SelectedIndex = -1;
            DssRsnComboBox.SelectedIndex = -1;
            DssSymptComboBox.SelectedIndex = -1;
            DctsTrmtComboBox.SelectedIndex = -1;
            HospitalNmcomboBox.SelectedIndex = -1;
            BlodGrpComboBox.SelectedIndex = -1;
            AgeGrpComboBox.SelectedIndex = -1;
            CureStatusComboBox.SelectedIndex = -1;
            AreacomboBox.SelectedIndex = -1;
            DateTextBox.Clear();
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            
        }

        private void Claim_Click(object sender, EventArgs e)
        {
            MessageBox.Show("💰 Payment Successful", "Success");

            UseDatabase.ResetRewardAfterClaim(UserSession.UserId);

            Show_RE_D.Text = "Reward claimed successfully.";
        }

        private void Show_RE_D_TextChanged(object sender, EventArgs e)
        {
        }

        private void Log_Out_Click(object sender, EventArgs e)
        {
           this.Hide();
            MainPage mg = new MainPage();
            mg.Show();
        }

        private void Data_Input_Load(object sender, EventArgs e)
        {

        }

        private void DssNamecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            tempData.DiseaseName = DssNamecomboBox.Text;
        }

        private void DssSymptComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            tempData.Symptom = DssSymptComboBox.Text;
        }

        private void DssRsnComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            tempData.Reason = DssRsnComboBox.Text;
        }

        private void DctsTrmtComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            tempData.Treatment = DctsTrmtComboBox.Text;
        }

        private void HospitalNmcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            tempData.Hospital = HospitalNmcomboBox.Text;
        }

        private void AreacomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            tempData.Area = AreacomboBox.Text;
        }

        private void BlodGrpComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            tempData.BloodGroup = BlodGrpComboBox.Text;
        }

        private void AgeGrpComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            tempData.AgeGroup = AgeGrpComboBox.Text;
        }

        private void CureStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            tempData.CureStatus = CureStatusComboBox.Text;
        }

        private void DateTextBox_TextChanged(object sender, EventArgs e)
        {
            tempData.DateTime = DateTextBox.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tempData.Drive= textBox1.Text;
        }
    }

}
