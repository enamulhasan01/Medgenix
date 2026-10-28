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
    public partial class DeleteData : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-I1741CE\\SQLEXPRESS;Initial Catalog=Medgenix;Integrated Security=True;Encrypt=False");
        public DeleteData()
        {
            InitializeComponent();
        }

        private void DeleteData_Load(object sender, EventArgs e)
        {

        }

        private void Show_Click(object sender, EventArgs e)
        {

            string Select_query = "Select * from Disease_1";
            SqlDataAdapter SQdad = new SqlDataAdapter(Select_query, conn);

            DataTable dtt = new DataTable();
            SQdad.Fill(dtt);
            DLTdataGridView.DataSource = dtt;
        }



        private void Delete_Click(object sender, EventArgs e)
        {
           
            if (DLTdataGridView.SelectedRows.Count == 0 || DLTdataGridView.SelectedRows[0].IsNewRow)
            {
                MessageBox.Show("Please select a valid data row to delete.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this disease?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            try
            {
              
                int diseaseId = Convert.ToInt32(DLTdataGridView.SelectedRows[0].Cells["Disease_ID"].Value);
                string diseaseName = DLTdataGridView.SelectedRows[0].Cells["Disease_Name"].Value.ToString();

                using (SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Disease_1 WHERE Disease_ID = @id AND Disease_Name = @name",
                    conn))
                {
                    cmd.Parameters.AddWithValue("@id", diseaseId);
                    cmd.Parameters.AddWithValue("@name", diseaseName);

                    if (conn.State == ConnectionState.Closed) conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (rows > 0)
                    {
                        MessageBox.Show("Item deleted successfully.",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                     
                        Show_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Delete failed. The record might have already been removed.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchForDLTDss_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                string searchQuery = "SELECT * FROM Disease_1 WHERE Disease_Name LIKE @search";

      
                SqlDataAdapter adapter = new SqlDataAdapter(searchQuery, conn);

              
                adapter.SelectCommand.Parameters.AddWithValue("@search", SearchForDLTDss.Text + "%");

                DataTable dt = new DataTable();
                adapter.Fill(dt);

               
                DLTdataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                if (conn.State == ConnectionState.Open) conn.Close();
                MessageBox.Show("Search Error: " + ex.Message);
            }
        }
    }
}
