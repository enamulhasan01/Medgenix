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


namespace Medgenix
{
    public partial class Patient : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-I1741CE\\SQLEXPRESS;Initial Catalog=Medgenix;Integrated Security=True;Encrypt=False");
        void GetRecommendation(String symptom , string reason, string blood, string age,string city)
        {
            try
            {
                string query = @"select Disease_Name,Hospital_Name 
                               from Disease_1 
where Disease_symptoms=@symptom
and Disease_Reason=@reason
and Blood_Group=@blood
and Age_Group=@age
and Area=@city";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@symptom", symptom);
                cmd.Parameters.AddWithValue("@reason", reason);
                cmd.Parameters.AddWithValue("@blood", blood);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@city", city);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    textBox1.Text =
    "Your Disease is Identified !" + Environment.NewLine  +
    "Identified Disease Name : " + reader["Disease_Name"].ToString() + Environment.NewLine +
    "Recommended Hospital : " + reader["Hospital_Name"].ToString();

                }
                else
                {
                    textBox1.Text = "No Disease Found";
                    textBox1.Text = "No Hospital Found";
                }

                con.Close();




            }

            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Database Error:\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                con.Close();
            }
        }

        public Patient()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.DssRsnComboBox.Text) ||
                    string.IsNullOrEmpty(this.DssRsnComboBox.Text) ||
                    string.IsNullOrEmpty(this.BlodGrpComboBox.Text) ||
                    string.IsNullOrEmpty(this.AgeGrpComboBox.Text) ||
                    string.IsNullOrEmpty(this.AreacomboBox.Text))
                {

                    MessageBox.Show(
               "Please fill all ComboBoxes before submitting.",
               "Input Required",
               MessageBoxButtons.OK,
               MessageBoxIcon.Warning
                  );
                    return;

                }
                string symptom = DssSymptComboBox.Text;
                string reason = DssRsnComboBox.Text;
                string blood = BlodGrpComboBox.Text;
                string age = AgeGrpComboBox.Text;
                string city = AreacomboBox.Text;

                GetRecommendation(symptom, reason, blood, age, city );

            }
            catch (Exception ex){
                MessageBox.Show(
            "Something went wrong!\n" + ex.Message,
            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        );
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                if (string.IsNullOrEmpty(textBox2.Text))
                {
                    MessageBox.Show(
           "Please fill all ComboBoxes before submitting.",
           "Input Required",
           MessageBoxButtons.OK,
           MessageBoxIcon.Warning
              );
                    return;
                }

            try { 
                string query = "insert into User_Review" + "(Review)" + "values (@R)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@R", textBox2.Text.Trim());

                    con.Open();
                    int row = cmd.ExecuteNonQuery();
                    con.Close();

                    if (row > 0)
                    {
                        MessageBox.Show("Thank You For Review !", "Success",
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

      

      

        private void button1_Click_1(object sender, EventArgs e)
        {
           

            this.Hide();
            MainPage mg = new MainPage();
            mg.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Patient_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
