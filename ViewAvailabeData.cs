using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Medgenix
{
    public partial class ViewAvailabeData : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Medgenix;Integrated Security=True;Encrypt=False");

        public ViewAvailabeData()
        {
            InitializeComponent();
        }

        private void AddData_Click(object sender, EventArgs e)
        {
            AddDiseaseData AddDssDta = new AddDiseaseData();
            this.Hide();
            AddDssDta.Show();
        }

        private void DeleteData_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteData DltData = new DeleteData();
            DltData.Show();
        }

        private void ViewAvailabeData_Load(object sender, EventArgs e)
        {

        }

        private void Show_Click(object sender, EventArgs e)
        {
            string Select_query = "Select * from Disease_1";
            SqlDataAdapter SQdad = new SqlDataAdapter(Select_query, conn);

            DataTable dt = new DataTable();
            SQdad.Fill(dt);
            AVdataGridView.DataSource = dt;
        }

        private void SearchForDss_TextChanged(object sender, EventArgs e)
        {
            try
            {
               
                string searchQuery = "SELECT * FROM Disease_1 WHERE Disease_Name LIKE @search";

                SqlDataAdapter adapter = new SqlDataAdapter(searchQuery, conn);

                
                adapter.SelectCommand.Parameters.AddWithValue("@search", SearchForDss.Text + "%");

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                AVdataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                if (conn.State == ConnectionState.Open) conn.Close();
                MessageBox.Show("Search Error: " + ex.Message);
            }
        }

        private void ViewAvaiDtaGOBACK_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin Admn = new Admin();
            Admn.Show();
        }
    }
}
