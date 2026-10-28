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
    public partial class CheckOutClint : Form
    {
        public int passedTXIDc;

   
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Medgenix;Integrated Security=True;Encrypt=False");
        public CheckOutClint()
        {
            InitializeComponent();
        }

        private void CheckOutClint_Load(object sender, EventArgs e)
        {

        }

        private void ShowDetails_Click(object sender, EventArgs e)
        {
            string connString =  @"Data Source = DESKTOP - I1741CE\SQLEXPRESS; Initial Catalog = Medgenix; Integrated Security = True; Encrypt = False";

            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    con.Open();

                    string query = @"SELECT 
   
    TC.Total_Cost AS [Total Price],
    PI.TXIDc AS [Transaction ID],
    D.Disease_Name AS [Disease], 
    D.Disease_Reason AS [Reason],
    D.Area,
    D.Age_Group AS [Age]
 FROM [Purchased_ItemsClint] PI
 LEFT JOIN [Transaction_Clint] TC ON PI.TXIDc = TC.TXIDc
 LEFT JOIN [Disease_1] D ON PI.Disease_ID = D.Disease_ID
 WHERE PI.TXIDc = @tid";

                    using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@tid", passedTXIDc);

                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            CheckOutClintGridView.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("Still no records found for ID: " + passedTXIDc);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mg = new MainPage();
            mg.Show();
        }
    }
}