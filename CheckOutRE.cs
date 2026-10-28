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
    public partial class CheckOutRE : Form
    {
        public int passedTXID;

        public CheckOutRE()

        {

            InitializeComponent();

        }



        private void ShowDetails_Click(object sender, EventArgs e)

        {

            string connString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Medgenix;Integrated Security=True;Encrypt=False";



            using (SqlConnection con = new SqlConnection(connString))

            {

                con.Open();



             

                string query = @"SELECT 
    TR.User_Name AS [Purchased By], 
    R.Institute AS [Institute], 
    TR.Total_Cost AS [Total Price (TK)],
    TR.TXID AS [Transaction ID],
    D.Disease_Name, 
    D.Disease_Symptoms, 
    D.Area, 
    D.Hospital_Name, 
    D.Doctots_Treatment, 
    D.Blood_Group, 
    D.Age_Group, 
    D.Cure_Status, 
    D.Date AS [Record Date], 
    D.Disease_Reason
 FROM [Tranaction_Re] TR
 INNER JOIN [Registration] R ON TR.User_Name = R.User_N
 INNER JOIN [Purchased_Items] PI ON TR.TXID = PI.TXID
 INNER JOIN Disease_1 D ON PI.Disease_ID = D.Disease_ID
 WHERE TR.TXID = @tid";


                using (SqlDataAdapter da = new SqlDataAdapter(query, con))

                {

               
                    da.SelectCommand.Parameters.AddWithValue("@tid", passedTXID);



                    DataTable dt = new DataTable();

                    da.Fill(dt);



                
                    CheckOutREGridView.DataSource = dt;

                }

            }

        }



        private void label2_Click(object sender, EventArgs e)

        {



        }



        private void CheckOutREGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {



        }

        private void CheckOutRE_Load(object sender, EventArgs e)
        {

        }
    }

}
