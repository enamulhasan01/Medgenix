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
    public partial class DataSellResearcher : Form
    {
        public string loggedInUser = "";
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Medgenix;Integrated Security=True;Encrypt=False");
        public DataSellResearcher()
        {
            InitializeComponent();
        }

        private void SearchData()
        {
            try
            {
                string connString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Medgenix;Integrated Security=True;Encrypt=False";
                string researcherName = loggedInUser;
                using (SqlConnection con = new SqlConnection(connString))
                {
                   
                    string query = "SELECT * FROM Disease_1 WHERE Disease_Name LIKE @disease " +
                                   "AND Area LIKE @area " +
                                   "AND CAST(YEAR(Date) AS VARCHAR) LIKE @year";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                       
                        cmd.Parameters.AddWithValue("@disease", "%" + SearchDssRe.Text.Trim() + "%");
                        cmd.Parameters.AddWithValue("@area", "%" + SearchAreaRe.Text.Trim() + "%");
                        cmd.Parameters.AddWithValue("@year", "%" + SearchYrRe.Text.Trim() + "%");

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        AVdataGridViewRe.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DataSellResearcher_Load(object sender, EventArgs e)
        {
            this.Text = "Researcher: " + loggedInUser;

        }

        private void SearchDssRe_TextChanged(object sender, EventArgs e)
        {
            SearchData();
        }

        private void SearchYrRe_TextChanged(object sender, EventArgs e)
        {
            SearchData();
        }

        private void SearchAreaRe_TextChanged(object sender, EventArgs e)
        {
            SearchData();
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            SearchDssRe.Text = "";
            SearchYrRe.Text = "";
            SearchAreaRe.Text = "";
            SearchDssRe.Focus();
        }

        private void ProceedToPaymentRe_Click(object sender, EventArgs e)
        {
            if (RePayCombo.SelectedItem == null || AVdataGridViewRe.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a payment method and data rows.");
                return;
            }

            int rowCount = AVdataGridViewRe.SelectedRows.Count;
            int totalCost = rowCount * 10;
            string researcherName = loggedInUser;
            string paymentMethod = RePayCombo.SelectedItem.ToString();
            string connString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Medgenix;Integrated Security=True;Encrypt=False";

            try
            {
                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();

                   
                    string txQuery = @"INSERT INTO [Tranaction_Re] 
                               (User_Name, Total_Selected_Rows, Total_Cost, Purchase_Date, Payment_Method) 
                               OUTPUT INSERTED.TXID 
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

                  
                    foreach (DataGridViewRow row in AVdataGridViewRe.SelectedRows)
                    {
                        string bridgeQuery = "INSERT INTO Purchased_Items (TXID, Disease_ID) VALUES (@tid, @did)";
                        using (SqlCommand cmdBridge = new SqlCommand(bridgeQuery, con))
                        {
                            cmdBridge.Parameters.AddWithValue("@tid", newTXID);
                         
                            cmdBridge.Parameters.AddWithValue("@did", row.Cells["Disease_ID"].Value);
                            cmdBridge.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Transaction Successful!");

                   
                   CheckOutRE checkoutForm = new CheckOutRE();
                   checkoutForm.passedTXID = newTXID;
                    checkoutForm.Show();
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void RePayCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ViewAvaiDtaGOBACK_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mg = new MainPage();
            mg.Show();
        }
    }
}
