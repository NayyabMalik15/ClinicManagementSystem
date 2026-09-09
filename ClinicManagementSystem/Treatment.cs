using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    public partial class Treatment : Form
    {
        public Treatment()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TreatmentName.Text = string.Empty;
            StandardCost.Text = string.Empty;
            Description.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection c1 = new Connection();
            SqlConnection con;
            con = c1.OpenConnection();
            string query = @"INSERT INTO Treatment
                    ( Treatment_Name, Standard_Cost, Description)
                    VALUES
                    (@Treatment_Name, @Standard_Cost, @Description)";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Treatment_Name", TreatmentName.Text);
            cmd.Parameters.AddWithValue("@Standard_Cost", StandardCost.Text);
            cmd.Parameters.AddWithValue("Description", Description.Text);

            try
            {

                cmd.ExecuteNonQuery();

                MessageBox.Show("Treatment inserted successfully!");
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

        private void Treatment_Load(object sender, EventArgs e)
        {

        }

        private void Treatment_Load_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Connection c1 = new Connection();
            SqlConnection con = c1.OpenConnection();

            string query = @"DELETE FROM Treatment
                     WHERE Treatment_Name = @Treatment_Name";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Treatment_Name", TreatmentName.Text);

            try
            {
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Treatment deleted successfully!");
                }
                else
                {
                    MessageBox.Show("Treatment not found!");
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
            Form fr = new Update_Treatment();
            fr.Show();
        }
    }
}

