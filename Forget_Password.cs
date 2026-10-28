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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Medgenix
{

    
    public partial class Forget_Password : Form
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-I1741CE\\SQLEXPRESS;Initial Catalog=Medgenix;Integrated Security=True;Encrypt=False");
        public Forget_Password()
        {
            InitializeComponent();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(textBoxUN.Text) ||
                string.IsNullOrWhiteSpace(textBoxEM.Text) ||
                string.IsNullOrWhiteSpace(textBoxPASS.Text))
            {
                MessageBox.Show("Username, Email and New Password are required!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
               
                string query =
                "UPDATE Registration SET Password = @pass " +
                "WHERE User_N = @un AND Email = @em";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                   
                    cmd.Parameters.AddWithValue("@pass", textBoxPASS.Text);
                    cmd.Parameters.AddWithValue("@un", textBoxUN.Text.Trim());
                    cmd.Parameters.AddWithValue("@em", textBoxEM.Text.Trim());

                    
                    con.Open();
                    int row = cmd.ExecuteNonQuery();
                    con.Close();

                   
                    if (row > 0)
                    {
                        MessageBox.Show("Password Updated Successfully!",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Username or Email not matched!",
                            "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database Error:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }




        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            textBoxUN.Clear();
            textBoxEM.Clear();
            textBoxPASS.Clear();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want exit the application?", "Closing Window", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                Application.Exit();

            }
        }

        private void Forget_Password_Load(object sender, EventArgs e)
        {

        }
    }
}
