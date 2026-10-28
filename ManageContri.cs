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
    public partial class ManageContri : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Medgenix;Integrated Security=True;Encrypt=False");
        public ManageContri()
        {
            InitializeComponent();
        }

        private void MangeContriGoback_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void ManageContri_Load(object sender, EventArgs e)
        {

        }

        private void ShowContriStatus_Click(object sender, EventArgs e)
        {
            string Select_query = "Select Name, User_N, Status, Register_As FROM  Registration WHERE Register_As = 'Contributor'";
            SqlDataAdapter SQdad = new SqlDataAdapter(Select_query, conn);

            DataTable dt = new DataTable();
            SQdad.Fill(dt);
            ContriStatusDtaGrid.DataSource = dt;


        }

        private void ContriMakeAct_Click(object sender, EventArgs e)
        {
         
            if (ContriStatusDtaGrid.SelectedRows.Count > 0 && !ContriStatusDtaGrid.SelectedRows[0].IsNewRow)
            {
                try
                {
                   
                    var cellValue = ContriStatusDtaGrid.SelectedRows[0].Cells["User_N"].Value;
                    if (cellValue == null) return;

                    string contributorUserN = cellValue.ToString();

                    string updateQuery = "UPDATE Registration SET Status = 1 WHERE User_N = @username";

                    if (conn.State == ConnectionState.Closed) conn.Open();

                    SqlCommand cmd = new SqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@username", contributorUserN);

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("User " + contributorUserN + " is now Active.");
                    ShowContriStatus_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    if (conn.State == ConnectionState.Open) conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select a valid contributor row. The empty bottom row cannot be updated.");
            }
        }
        private void ContriMakeInAct_Click(object sender, EventArgs e)
        {
            
            if (ContriStatusDtaGrid.SelectedRows.Count > 0 && !ContriStatusDtaGrid.SelectedRows[0].IsNewRow)
            {
                try
                {
                    var cellValue = ContriStatusDtaGrid.SelectedRows[0].Cells["User_N"].Value;
                    if (cellValue == null) return;

                    string contributorUserN = cellValue.ToString();

                    string updateQuery = "UPDATE Registration SET Status = 0 WHERE User_N = @username";

                    if (conn.State == ConnectionState.Closed) conn.Open();

                    SqlCommand cmd = new SqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@username", contributorUserN);

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("User " + contributorUserN + " is now Inactive.");
                    ShowContriStatus_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    if (conn.State == ConnectionState.Open) conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select a valid contributor row.");
            }
        }

        private void TextSearchUser_TextChanged(object sender, EventArgs e)
        {
            try
            {
               
                string searchQuery = "SELECT Name, User_N, Status, Register_As FROM Registration " +
                                     "WHERE Register_As = 'Contributor' AND User_N LIKE @search";

                SqlDataAdapter adapter = new SqlDataAdapter(searchQuery, conn);

              
                adapter.SelectCommand.Parameters.AddWithValue("@search", TextSearchUser.Text + "%");

                DataTable dt = new DataTable();
                adapter.Fill(dt);

              
                ContriStatusDtaGrid.DataSource = dt;
            }
            catch (Exception ex)
            {
               
                if (conn.State == ConnectionState.Open) conn.Close();
                MessageBox.Show("Search Error: " + ex.Message);
            }
        }

        private void ContriStatusDtaGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
    

