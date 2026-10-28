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
    public partial class ManageResearcher : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Medgenix;Integrated Security=True;Encrypt=False");
        public ManageResearcher()
        {
            InitializeComponent();
        }

        private void TextSearchPatient_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                string searchQuery = "SELECT Name, User_N, Status, Register_As FROM Registration " +
                                     "WHERE Register_As = 'Researcher' AND User_N LIKE @search";

                SqlDataAdapter adapter = new SqlDataAdapter(searchQuery, conn);

               
                adapter.SelectCommand.Parameters.AddWithValue("@search", TextSearchRese.Text + "%");

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                
                ReseStatusDtaGrid.DataSource = dt;
            }
            catch (Exception ex)
            {
               
                if (conn.State == ConnectionState.Open) conn.Close();
                MessageBox.Show("Search Error: " + ex.Message);
            }
        }

        private void ManageResearcher_Load(object sender, EventArgs e)
        {

        }

        private void ShowReseStatus_Click(object sender, EventArgs e)
        {
            string Select_query = "Select Name, User_N, Status, Register_As FROM  Registration WHERE Register_As = 'Researcher'";
            SqlDataAdapter SQdad = new SqlDataAdapter(Select_query, conn);

            DataTable dt = new DataTable();
            SQdad.Fill(dt);
            ReseStatusDtaGrid.DataSource = dt;

        }

        private void ReseMakeAct_Click(object sender, EventArgs e)
        {

            if (ReseStatusDtaGrid.SelectedRows.Count > 0 && !ReseStatusDtaGrid.SelectedRows[0].IsNewRow)
            {
                try
                {

                    var cellValue = ReseStatusDtaGrid.SelectedRows[0].Cells["User_N"].Value;
                    if (cellValue == null) return;

                    string contributorUserN = cellValue.ToString();

                    string updateQuery = "UPDATE Registration SET Status = 1 WHERE User_N = @username";

                    if (conn.State == ConnectionState.Closed) conn.Open();

                    SqlCommand cmd = new SqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@username", contributorUserN);

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("User " + contributorUserN + " is now Active.");
                    ShowReseStatus_Click(sender, e);
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

        private void ReseMakeInAct_Click(object sender, EventArgs e)
        {


            if (ReseStatusDtaGrid.SelectedRows.Count > 0 && !ReseStatusDtaGrid.SelectedRows[0].IsNewRow)
            {
                try
                {
                    var cellValue = ReseStatusDtaGrid.SelectedRows[0].Cells["User_N"].Value;
                    if (cellValue == null) return;

                    string contributorUserN = cellValue.ToString();

                    string updateQuery = "UPDATE Registration SET Status = 0 WHERE User_N = @username";

                    if (conn.State == ConnectionState.Closed) conn.Open();

                    SqlCommand cmd = new SqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@username", contributorUserN);

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("User " + contributorUserN + " is now Inactive.");
                    ShowReseStatus_Click(sender, e);
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

        private void MangeReseGoback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
