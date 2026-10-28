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
    public partial class ManagePatient : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Medgenix;Integrated Security=True;Encrypt=False");
        public ManagePatient()
        {
            InitializeComponent();
        }

        private void TextSearchPatient_TextChanged(object sender, EventArgs e)
        {
            try
            {
               
                string searchQuery = "SELECT Name, User_N, Status, Register_As FROM Registration " +
                                     "WHERE Register_As = 'Patient' AND User_N LIKE @search";

                SqlDataAdapter adapter = new SqlDataAdapter(searchQuery, conn);

                
                adapter.SelectCommand.Parameters.AddWithValue("@search", TextSearchPatient.Text + "%");

                DataTable dt = new DataTable();
                adapter.Fill(dt);

               
                PatientStatusDtaGrid.DataSource = dt;
            }
            catch (Exception ex)
            {
               
                if (conn.State == ConnectionState.Open) conn.Close();
                MessageBox.Show("Search Error: " + ex.Message);
            }
        }

        private void ManagePatient_Load(object sender, EventArgs e)
        {

        }

        private void ShowPatientStatus_Click(object sender, EventArgs e)
        {

            string Select_query = "Select Name, User_N, Status, Register_As FROM  Registration WHERE Register_As = 'Patient'";
            SqlDataAdapter SQdad = new SqlDataAdapter(Select_query, conn);

            DataTable dt = new DataTable();
            SQdad.Fill(dt);
            PatientStatusDtaGrid.DataSource = dt;

        }

        private void PatientMakeAct_Click(object sender, EventArgs e)
        {


            if (PatientStatusDtaGrid.SelectedRows.Count > 0 && !PatientStatusDtaGrid.SelectedRows[0].IsNewRow)
            {
                try
                {

                    var cellValue = PatientStatusDtaGrid.SelectedRows[0].Cells["User_N"].Value;
                    if (cellValue == null) return;

                    string contributorUserN = cellValue.ToString();

                    string updateQuery = "UPDATE Registration SET Status = 1 WHERE User_N = @username";

                    if (conn.State == ConnectionState.Closed) conn.Open();

                    SqlCommand cmd = new SqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@username", contributorUserN);

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("User " + contributorUserN + " is now Active.");
                    ShowPatientStatus_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    if (conn.State == ConnectionState.Open) conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select a valid row. The empty bottom row cannot be updated.");
            }
        }

        private void PatientMakeInAct_Click(object sender, EventArgs e)
        {

            if (PatientStatusDtaGrid.SelectedRows.Count > 0 && !PatientStatusDtaGrid.SelectedRows[0].IsNewRow)
            {
                try
                {
                    var cellValue = PatientStatusDtaGrid.SelectedRows[0].Cells["User_N"].Value;
                    if (cellValue == null) return;

                    string contributorUserN = cellValue.ToString();

                    string updateQuery = "UPDATE Registration SET Status = 0 WHERE User_N = @username";

                    if (conn.State == ConnectionState.Closed) conn.Open();

                    SqlCommand cmd = new SqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@username", contributorUserN);

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("User " + contributorUserN + " is now Inactive.");
                    ShowPatientStatus_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    if (conn.State == ConnectionState.Open) conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select a valid  row.");
            }
        }

        private void MangePatientGoback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
