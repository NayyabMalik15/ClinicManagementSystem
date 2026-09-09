using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ClinicManagementSystem
{
    public partial class Company : Form
    {
        public Company()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection c1 = new Connection();
            SqlConnection con;
            con = c1.OpenConnection();

            string query = @"INSERT INTO Company
            (Company_Name, Contact_Person, Phone, Email, City, Status, Address)
            VALUES
            (@Company_Name, @Contact_Person, @Phone, @Email, @City, @Status, @Address)";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Company_Name", CompanyName.Text);
            cmd.Parameters.AddWithValue("@Contact_Person", ContactPerson.Text);
            cmd.Parameters.AddWithValue("@Phone", Phone.Text);
            cmd.Parameters.AddWithValue("@Email", Email.Text);
            cmd.Parameters.AddWithValue("@City", City.Text);
            cmd.Parameters.AddWithValue("@Status", Status.Text);
            cmd.Parameters.AddWithValue("@Address", Address.Text);

            try
            {
                cmd.ExecuteNonQuery();

                MessageBox.Show("Company inserted successfully!");
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
            SqlConnection con;
            con = c1.OpenConnection();

            string query = @"DELETE FROM Company
                     WHERE Company_Name = @Company_Name";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Company_Name", CompanyName.Text);

            try
            {
                cmd.ExecuteNonQuery();

                MessageBox.Show("Company deleted successfully!");
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

        private void button4_Click(object sender, EventArgs e)
        {
            CompanyName.Text = string.Empty;
            ContactPerson.Text = string.Empty;
            Phone.Text = string.Empty;
            Email.Text = string.Empty;
            City.Text = string.Empty;
            Status.Text = string.Empty;
            Address.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form fr = new Update_Company();
            fr.Show();
        }
    }
}
