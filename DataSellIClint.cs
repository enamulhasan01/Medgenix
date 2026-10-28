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
    public partial class DataSELLClint : Form
    {

        public string loggedInUserClint = "";
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Medgenix;Integrated Security=True;Encrypt=False");
        public DataSELLClint()
        {
            InitializeComponent();
        }
        private void SearchData()
        {
            try
            {
                string connString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Medgenix;Integrated Security=True;Encrypt=False";

                using (SqlConnection con = new SqlConnection(connString))
                {
                 
                    string query = @"SELECT 
                                Disease_ID,
                                Disease_Name AS [Disease], 
                                Disease_Reason AS [Reason], 
                                Area, 
                                Age_Group AS [Age], 
                                Date 
                             FROM Disease_1 
                             WHERE Disease_Name LIKE @disease 
                             AND Area LIKE @area 
                             AND CAST(YEAR(Date) AS VARCHAR) LIKE @year";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@disease", "%" + SearchDssIC.Text.Trim() + "%");
                        cmd.Parameters.AddWithValue("@area", "%" + SearchAreaIC.Text.Trim() + "%");
                        cmd.Parameters.AddWithValue("@year", "%" + SearchYrIC.Text.Trim() + "%");

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        AVdataGridViewIC.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void DataSELLClint_Load(object sender, EventArgs e)
        {
            this.Text = "Clint: " + loggedInUserClint;
        }

        private void SearchYrIC_TextChanged(object sender, EventArgs e)
        {
            SearchData();
        }

        private void SearchDssIC_TextChanged(object sender, EventArgs e)
        {
            SearchData();
        }

        private void SearchAreaIC_TextChanged(object sender, EventArgs e)
        {
            SearchData();
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            SearchDssIC.Text = "";
            SearchYrIC.Text = "";
            SearchAreaIC.Text = "";
            SearchDssIC.Focus();
        }

        private void ProceedToPaymentIC_Click(object sender, EventArgs e)
        {
           
            this.Hide();

            if (ICPayCombo.SelectedItem == null || AVdataGridViewIC.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a payment method and data rows.");
                return;
            }

            int rowCount = AVdataGridViewIC.SelectedRows.Count;
            int totalCost = rowCount * 4;
            string researcherName = loggedInUserClint;
            string paymentMethod = ICPayCombo.SelectedItem.ToString();
            string connString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Medgenix;Integrated Security=True;Encrypt=False";

            try
            {
                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();

                   
                    string txQuery = @"INSERT INTO [Transaction_Clint]
                               (User_Name, Total_Selected_Rows, Total_Cost, Purchase_Date, Payment_Method) 
                               OUTPUT INSERTED.TXIDc 
                               VALUES (@un, @rows, @cost, GETDATE(), @pay)";

                    int newTXID;
                    using (SqlCommand cmd = new SqlCommand(txQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@un", researcherName);
                        cmd.Parameters.AddWithValue("@rows", rowCount);
                        cmd.Parameters.AddWithValue("@cost", totalCost);
                        cmd.Parameters.AddWithValue("@pay", paymentMethod);
                        newTXID = (int)cmd.ExecuteScalar(); 
                    }

                  
                    foreach (DataGridViewRow row in AVdataGridViewIC.SelectedRows)
                    {
                        if (row.Cells["Disease_ID"].Value != null)
                        {
                            string bridgeQuery = "INSERT INTO Purchased_ItemsClint (TXIDc, Disease_ID) VALUES (@tid, @did)";
                            using (SqlCommand cmdBridge = new SqlCommand(bridgeQuery, con))
                            {
                                cmdBridge.Parameters.AddWithValue("@tid", newTXID);
                                cmdBridge.Parameters.AddWithValue("@did", row.Cells["Disease_ID"].Value);
                                cmdBridge.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                           
                            MessageBox.Show("Error: Could not find Disease_ID in the selected row.");
                        }
                    }

                    MessageBox.Show("Transaction Successful!");

                   
                    CheckOutClint checkoutForm = new CheckOutClint();
                    checkoutForm.passedTXIDc = newTXID;
                    checkoutForm.Show();
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }
    }
}
