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
    public partial class Registration : Form
    {
        TextBox tbinstute;

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Medgenix;Integrated Security=True;Encrypt=False");

        public Registration()
        {
            InitializeComponent();
        }

       
        // for buttons action 
        private void butt_Registraton_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(textBoxUN.Text) ||
                string.IsNullOrWhiteSpace(onlyName.Text) ||
                string.IsNullOrWhiteSpace(textBoxPH.Text) ||
                string.IsNullOrWhiteSpace(textBoxEM.Text) ||
                string.IsNullOrWhiteSpace(textBoxPASS.Text) ||
                string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("All fields are required!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (tbinstute != null && string.IsNullOrWhiteSpace(tbinstute.Text))
            {
                MessageBox.Show("Institute Name is required!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            try
            {
                string instituteName = tbinstute != null ? tbinstute.Text : "";

                string query =
                "INSERT INTO Registration " +
                "(Name, User_N, Phone, Email, Password, Institute, Register_As) " +
                "VALUES (@na, @un, @ph, @em, @pass, @inst, @reg)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    
                    cmd.Parameters.AddWithValue("@na", textBoxUN.Text.Trim());
                    cmd.Parameters.AddWithValue("@un", onlyName.Text.Trim());
                    cmd.Parameters.AddWithValue("@ph", textBoxPH.Text.Trim());
                    cmd.Parameters.AddWithValue("@em", textBoxEM.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", textBoxPASS.Text);
                    cmd.Parameters.AddWithValue("@inst", instituteName.Trim());
                    cmd.Parameters.AddWithValue("@reg", comboBox1.Text);

                    con.Open();
                    int row = cmd.ExecuteNonQuery();
                    con.Close();

                    if (row > 0)
                    {
                        MessageBox.Show("Registration Successful!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                      
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
            textBoxPH.Clear();
            textBoxEM.Clear();
            textBoxPASS.Clear();
            onlyName.Clear();

           

           
            onlyName.Focus();
        }


        private void ExitButton_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Do you really want exit the application?", "Closing Window", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                Application.Exit();

            }


        }
        // for comboBox
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string registration_as = comboBox1.SelectedItem.ToString();

            if (registration_as == "Researcher" || registration_as == "Clint")
            {
              
                Label lb = new Label();
                lb.Name = "InstuteName_Label";
                lb.Text = "Institute Name :";
                lb.AutoSize = true;
                lb.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Bold);
                lb.ForeColor = Color.White;
                lb.Location = new Point(label3.Location.X, label3.Location.Y + label3.Height + 20);

               
                tbinstute = new TextBox();  
                tbinstute.Name = "Institute_Textbox";
                tbinstute.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
                tbinstute.Size = new Size(265, 34);
                tbinstute.Location = new Point(
                    textBoxPASS.Location.X + 35,
                    textBoxPASS.Location.Y + textBoxPASS.Height + 20
                );

                this.Controls.Add(lb);
                this.Controls.Add(tbinstute);
            }
            else
            {
                this.Controls.RemoveByKey("InstuteName_Label");
                this.Controls.RemoveByKey("Institute_Textbox");
                tbinstute = null;
            }
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mg = new MainPage();
            mg.Show();
        }
    }
}
