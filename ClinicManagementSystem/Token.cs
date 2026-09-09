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
    public partial class Token : Form
    {
        public Token()
        {
            InitializeComponent();
           
        }

        private void Token_Load(object sender, EventArgs e)
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

                comboBox1.DataSource = dt;
                comboBox1.ValueMember = "Doctor_ID";
                comboBox1.SelectedIndex = 0;

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

                Patient.DataSource = dtPatient;
                Patient.ValueMember = "Patient_ID";
                Patient.SelectedIndex = 0;

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
            string queryTreatment = @"select * from Treatment order by Treatment_ID";
            SqlCommand cmdTreatment = new SqlCommand(queryTreatment, con2);

            try
            {
                SqlDataAdapter daTreatment = new SqlDataAdapter(cmdTreatment);
                DataTable dtTreatment = new DataTable();
                daTreatment.Fill(dtTreatment);

                Treatmentid.DataSource = dtTreatment;
                Treatmentid.ValueMember = "Treatment_ID";
                Treatmentid.SelectedIndex = 0;

                cmdTreatment.ExecuteNonQuery();


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
        private void button1_Click(object sender, EventArgs e)
        {
            Connection c1 = new Connection();
            SqlConnection con;
            con = c1.OpenConnection();
          

            DateTime tokenDate = DateTime.Today;

            string idQuery = @"
    SELECT ISNULL(MAX(Token_ID), 0) + 1
    FROM Token
    WHERE Token_Date = @Token_Date";

            int tokenID;

            using (SqlCommand idCmd = new SqlCommand(idQuery, con))
            {
                idCmd.Parameters.AddWithValue("@Token_Date", tokenDate);
                tokenID = Convert.ToInt32(idCmd.ExecuteScalar());
            }

            string query = @"INSERT INTO Token
                    ( Token_Number, Token_Date, Patient_ID, Doctor_ID, Treatment_ID, Status)
                    VALUES
                    (@Token_Number, @Token_Date, @Patient_ID, @Doctor_ID, @Treatment_ID, @Status)";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Token_Number", TokenNumber.Text);
            cmd.Parameters.AddWithValue("@Token_Date", TokenDate.Value);
            cmd.Parameters.AddWithValue("@Patient_ID", Patient.Text);
            cmd.Parameters.AddWithValue("@Doctor_ID", comboBox1.Text);
            cmd.Parameters.AddWithValue("Treatment_ID", Treatmentid.Text);
            cmd.Parameters.AddWithValue("Status", Status.Text);

            try
            {

                cmd.ExecuteNonQuery();

                MessageBox.Show("Token inserted successfully!");
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
            TokenNumber.Text = string.Empty;
            TokenDate.Text = string.Empty;
            Patient.Text = string.Empty;
            comboBox1.Text = string.Empty;
            Treatmentid.Text = string.Empty;
            Status.Text = string.Empty;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Connection c1 = new Connection();
            SqlConnection con = c1.OpenConnection();

            string query = @"DELETE FROM Token
                     WHERE Token_Number = @Token_Number";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Token_Number", TokenNumber.Text);

            try
            {
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Token deleted successfully!");
                }
                else
                {
                    MessageBox.Show("Token not found!");
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
            Form fr = new Update_Token();
            fr.Show();
        }
    }
}