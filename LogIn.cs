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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Medgenix;



namespace Medgenix
{
    public partial class LogIn : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Medgenix;Integrated Security=True;Encrypt=False");
        

        public LogIn()
        {
            InitializeComponent();
        }




        private void LogInButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Username and Password are required!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                
                string query =
                "SELECT Status FROM Registration " +
                "WHERE User_N = @un AND Password = @pass";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@un", textBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", textBox2.Text);
                    

                    con.Open();
                    object result = cmd.ExecuteScalar();
                    con.Close();


                   
                    if (result == null)
                    {
                        MessageBox.Show("Invalid Username or Password!",
                            "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int status = Convert.ToInt32(result);

                    if (status == 0)
                    {
                        MessageBox.Show("Your account is not confirmed yet.\nPlease wait for confirmation.",
                            "Pending Approval", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                    UserSession.Username = textBox1.Text.Trim();
                  


                    MessageBox.Show("Login Successful!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                  
                    string roleQuery =
                    "SELECT Register_As FROM Registration WHERE User_N = @un";

                    using (SqlCommand roleCmd = new SqlCommand(roleQuery, con))
                    {
                        roleCmd.Parameters.AddWithValue("@un", textBox1.Text.Trim());

                        con.Open();
                        string role = roleCmd.ExecuteScalar().ToString();
                        con.Close();

                        UserSession.Role = role;

                        if (role == "Contributor")
                        {
                            Data_Input di = new Data_Input();
                            di.Show();

                        }else if(role == "Moderator") {
                            Data_Input di = new Data_Input();
                            di.Show();
                        }

                        else if (role == "Admin")
                        {
                            Admin ad = new Admin();
                            ad.Show();
                        }
                        else if (role == "Patient")
                        {
                            Patient pt = new Patient();
                            pt.Show();
                        }
                        else if (role == "Researcher")
                        {
                           
                           DataSellResearcher DSR = new DataSellResearcher();
                            DSR.loggedInUser = UserSession.Username;
                            DSR.Show();
                        }
                        else if (role == "Clint")
                        {
                            DataSELLClint DCLint = new DataSELLClint();
                            DCLint.Show();

                        }else if(role == "Supervisor")
                        {
                          Supervisor sp = new Supervisor();
                            sp.Show();
                        }
                       
                        
                        else
                        {
                            MessageBox.Show("Unknown Role!");
                            return;
                        }

                        this.Hide(); 
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
            textBox1.Clear();
            textBox2.Clear();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want exit the application?", "Closing Window", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                Application.Exit();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forget_Password fp = new Forget_Password();
            fp.Show();
            this.Close();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
