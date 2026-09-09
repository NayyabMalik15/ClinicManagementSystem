using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClinicManagementSystem
{
    public partial class Medicine : Form
    {
        public Medicine()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tokenid.Text = string.Empty;
            ExpiryDate.Text = string.Empty;
            Patientid.Text = string.Empty;
            Doctorid.Text = string.Empty;
            MedicineDetail.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection c1 = new Connection();
            SqlConnection con;
            con = c1.OpenConnection();
            string query = @"INSERT INTO Medicine
                    ( Token_ID, Expiry_Date, Patient_ID, Doctor_ID, Medicine_Detail)
                    VALUES
                    (@Token_ID, @Expiry_Date, @Patient_ID, @Doctor_ID, @Medicine_Detail)";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Token_ID", Tokenid.Text);
            cmd.Parameters.AddWithValue("@Expiry_Date", ExpiryDate.Value);
            cmd.Parameters.AddWithValue("@Patient_ID", Patientid.Text);
            cmd.Parameters.AddWithValue("@Doctor_ID", Doctorid.Text);
            cmd.Parameters.AddWithValue("@Medicine_Detail", MedicineDetail.Text);

            try
            {

                cmd.ExecuteNonQuery();

                MessageBox.Show("Medicine inserted successfully!");
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

        private void Medicine_Load(object sender, EventArgs e)
        {
            Connection c1 = new Connection();
            SqlConnection con;
            con = c1.OpenConnection();
            string query = @"select * from Doctor order by Doctor_ID";
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                Doctorid.DataSource = dt;
                Doctorid.ValueMember = "Doctor_ID";
                Doctorid.SelectedIndex = 0;

                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            SqlConnection con1 = c1.OpenConnection();
            string queryPatient = @"select * from Patient order by Patient_ID";
            SqlCommand cmdPatient = new SqlCommand(queryPatient, con1);

            try
            {
                SqlDataAdapter daPatient = new SqlDataAdapter(cmdPatient);
                DataTable dtPatient = new DataTable();
                daPatient.Fill(dtPatient);

                Patientid.DataSource = dtPatient;
                Patientid.ValueMember = "Patient_ID";
                Patientid.SelectedIndex = 0;

                cmdPatient.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con1.Close();
            }
            SqlConnection con2 = c1.OpenConnection();
            string queryToken = @"select * from Token order by Token_ID";
            SqlCommand cmdToken = new SqlCommand(queryToken, con2);

            try
            {
                SqlDataAdapter daToken = new SqlDataAdapter(cmdToken);
                DataTable dtToken = new DataTable();
                daToken.Fill(dtToken);

                Tokenid.DataSource = dtToken;
                Tokenid.ValueMember = "Token_ID";
                Tokenid.SelectedIndex = -1;

                cmdToken.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con2.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Connection c1 = new Connection();
            SqlConnection con = c1.OpenConnection();

            string query = @"DELETE FROM Medicine
                     WHERE Token_ID = @Token_ID";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Token_ID", Tokenid.Text);

            try
            {
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Medicine deleted successfully!");
                }
                else
                {
                    MessageBox.Show("Medicine not found!");
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
            Form fr = new Update_Medicine();
            fr.Show();
        }
    }
}
