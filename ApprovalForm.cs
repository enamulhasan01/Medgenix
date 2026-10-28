using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medgenix
{
    public partial class ApprovalForm : Form
    {
       
        private ContributorData data;


        public ApprovalForm()
        {
            InitializeComponent();
            
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = true;
        }
   
        private void ApprovalForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) 
        {
           
            List<ContributorData> list = UseDatabase.GetPendingData("Contributor");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           


        }

        private void button2_Click(object sender, EventArgs e) 
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row first!");
                return;
            }

            try
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    
                    ContributorData d = (ContributorData)row.DataBoundItem;

                   
                    UseDatabase.InsertIntoDisease1(d);

                   
                    UseDatabase.AssignRewardPoint(d.ContributorId);

                   
                    UseDatabase.DeleteFromTemp(d.Id);
                }

                MessageBox.Show("✅ Approved! Contributor got 5 reward points.");
                button1_Click(null, null); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void button3_Click_1(object sender, EventArgs e) 
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                ContributorData d = (ContributorData)row.DataBoundItem;
                UseDatabase.DeleteFromTemp(d.Id);
            }
            MessageBox.Show("❌ Data Rejected and Deleted");
            button1_Click(null, null);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            MainPage mg = new MainPage();
            mg.Show();
            this.Hide();
        }
    }
}

