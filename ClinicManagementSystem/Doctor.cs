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
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FirstName.Text = string.Empty;
            LastName.Text = string.Empty;
            Specialization.Text = string.Empty;
            PhoneNumber.Text = string.Empty;
            ConsultationFee.Text = string.Empty;
            AvailableTiming.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection c1 = new Connection();
            SqlConnection con;
            con = c1.OpenConnection();
            string query = @"INSERT INTO Doctor
                    ( First_Name, Last_Name, Specialization, Phone_Number, Consultation_Fee, Available_Timing)
                    VALUES
                    (@First_Name, @Last_Name, @Specialization, @Phone_Number, @Consultation_Fee, @Available_Timing )";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@First_Name", FirstName.Text);
            cmd.Parameters.AddWithValue("@Last_Name", LastName.Text);
            cmd.Parameters.AddWithValue("@Specialization", Specialization.Text);
            cmd.Parameters.AddWithValue("@Phone_Number", PhoneNumber.Text);
            cmd.Parameters.AddWithValue("@Consultation_Fee", ConsultationFee.Text);
            cmd.Parameters.AddWithValue("@Available_Timing", AvailableTiming.Value);
            try
            {

                cmd.ExecuteNonQuery();

                MessageBox.Show("Doctor inserted successfully!");
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

            string query = @"DELETE FROM Doctor
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
                    MessageBox.Show("Doctor deleted successfully!");
                }
                else
                {
                    MessageBox.Show("Doctor not found!");
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
            Form fr = new Update_Doctor();
            fr.Show();
        }
    }
}


        
    
