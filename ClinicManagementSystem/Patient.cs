using Microsoft.Data.SqlClient;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClinicManagementSystem
{
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FirstName.Text = string.Empty;
            LastName.Text = string.Empty;
            Gender.Text = string.Empty;
            DOB.Text = DateTime.Today.ToString();
            PhoneNumber.Text = string.Empty;
            Address.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection c1 = new Connection();
            SqlConnection con;
            con = c1.OpenConnection();
            string query = @"INSERT INTO Patient
                    ( First_Name, Last_Name, Gender, Date_of_Birth, Phone_Number, Address)
                    VALUES
                    (@First_Name, @Last_Name, @Gender, @Date_of_Birth, @Phone_Number, @Address)";
            SqlCommand cmd = new SqlCommand(query, con);
            //cmd.Parameters.AddWithValue("@Patient_ID", txtPatientID.Text);
            cmd.Parameters.AddWithValue("@First_Name", FirstName.Text);
            cmd.Parameters.AddWithValue("@Last_Name", LastName.Text);
            cmd.Parameters.AddWithValue("@Gender", Gender.Text);
            cmd.Parameters.AddWithValue("@Date_of_Birth", DOB.Value);
            cmd.Parameters.AddWithValue("@Phone_Number", PhoneNumber.Text);
            cmd.Parameters.AddWithValue("@Address", Address.Text);

            try
            {

                cmd.ExecuteNonQuery();

                MessageBox.Show("Patient inserted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Connection c1 = new Connection();
            SqlConnection con = c1.OpenConnection();

            string query = @"DELETE FROM Patient
                     WHERE First_Name = @First_Name
                     AND Last_Name = @Last_Name";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@First_Name", FirstName.Text);
            cmd.Parameters.AddWithValue("@Last_Name", LastName.Text);

            try
            {
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Patient deleted successfully!");
                }
                else
                {
                    MessageBox.Show("Patient not found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form fr = new Update_Patient();
            fr.Show();
        }

    }
}


