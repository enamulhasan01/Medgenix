using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medgenix
{
    public partial class AddDiseaseData : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Medgenix;Integrated Security=True;Encrypt=False");
        public AddDiseaseData()
        {
            InitializeComponent();
        }

        private void AddDssData_Click(object sender, EventArgs e)
        {
         
            DateTime tempDate;
            bool isValid = DateTime.TryParseExact(DateTextBox.Text, "dd-MM-yyyy",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None, out tempDate);

            if (isValid)
            {
                
                string sqlFormattedDate = tempDate.ToString("yyyy-MM-dd");

                
                string Insert_query = "insert into Disease_1 values ('" + DssNamecomboBox.Text + "','" + DssSymptComboBox.Text + "','" + AreacomboBox.Text + "','" + HospitalNmcomboBox.Text + "','" + DctsTrmtComboBox.Text + "','" + BlodGrpComboBox.Text + "', '" + AgeGrpComboBox.Text + "','" + CureStatusComboBox.Text + "','" + sqlFormattedDate + "','" + DssRsnComboBox.Text + "')";

                try
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    SqlCommand SqlCmd = new SqlCommand(Insert_query, conn);
                    int rows = SqlCmd.ExecuteNonQuery();
                    conn.Close();

                    if (rows > 0)
                    {
                        MessageBox.Show("Data is Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                    if (conn.State == ConnectionState.Open) conn.Close();
                }
            }
            else
            {
                
                MessageBox.Show("Please enter date as dd-mm-yyyy (e.g. 17-01-2026)");
            }
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            this.Close();
            ViewAvailabeData AvaiData = new ViewAvailabeData();
            AvaiData.Show();

        }

        private void DateTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddDiseaseData_Load(object sender, EventArgs e)
        {

        }

        private void ClearAllAddDss_Click(object sender, EventArgs e)
        {
          
            DateTextBox.Text = "";

            DssNamecomboBox.SelectedIndex = -1;
            DssSymptComboBox.SelectedIndex = -1;
            AreacomboBox.SelectedIndex = -1;
            HospitalNmcomboBox.SelectedIndex = -1;
            DctsTrmtComboBox.SelectedIndex = -1;
            BlodGrpComboBox.SelectedIndex = -1;
            AgeGrpComboBox.SelectedIndex = -1;
            CureStatusComboBox.SelectedIndex = -1;
            DssRsnComboBox.SelectedIndex = -1;

            DssNamecomboBox.Focus();
        }
    }
}
