using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FirstName.Text = string.Empty;
            LastName.Text = string.Empty;
            Role.Text = string.Empty;
            PhoneNumber.Text = string.Empty;
            Email.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection c1 = new Connection();
            SqlConnection con;
            con = c1.OpenConnection();
            string query = @"INSERT INTO Staff
                    ( First_Name, Last_Name, Role, Phone_Number, Email)
                    VALUES
                    (@First_Name, @Last_Name, @Role, @Phone_Number, @Email)";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@First_Name", FirstName.Text);
            cmd.Parameters.AddWithValue("@Last_Name", LastName.Text);
            cmd.Parameters.AddWithValue("@Role", Role.Text);
            cmd.Parameters.AddWithValue("@Phone_Number", PhoneNumber.Text);
            cmd.Parameters.AddWithValue("Email", Email.Text);

            try
            {

                cmd.ExecuteNonQuery();

                MessageBox.Show("Staff inserted successfully!");
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

        private void Staff_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Connection c1 = new Connection();
            SqlConnection con = c1.OpenConnection();

            string query = @"DELETE FROM Staff
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
                    MessageBox.Show("Staff deleted successfully!");
                }
                else
                {
                    MessageBox.Show("Staff not found!");
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
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Connection c1 = new Connection();
                SqlConnection con = c1.OpenConnection();

                string query = @"UPDATE Staff
                         SET First_Name = @First_Name,
                             Last_Name = @Last_Name,
                             Role = @Role,
                             Email = @Email
                         WHERE Phone_Number = @Phone_Number";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@First_Name", FirstName.Text);
                cmd.Parameters.AddWithValue("@Last_Name", LastName.Text);
                cmd.Parameters.AddWithValue("@Role", Role.Text);
                cmd.Parameters.AddWithValue("@Email", Email.Text);
                cmd.Parameters.AddWithValue("@Phone_Number", PhoneNumber.Text);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Staff record updated successfully!");
                }
                else
                {
                    MessageBox.Show("Staff record not found.");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form fr = new Update_Staff();
            fr.Show();
        }
    }
}  

