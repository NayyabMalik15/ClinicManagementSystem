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
    public partial class Update_Doctor : Form
    {
        public Update_Doctor()
        {
            InitializeComponent();
        }

        private void Update_Doctor_Load(object sender, EventArgs e)
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
        }

        private void Doctorid_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connection c1 = new Connection();
            SqlConnection con = c1.OpenConnection();

            DataRowView row = Doctorid.SelectedItem as DataRowView;

            if (row != null)
            {
                int Doctor_ID = Convert.ToInt32(row["Doctor_ID"]);

                string query = @"SELECT First_Name, Last_Name, Specialization,
                            Phone_Number, Consultation_Fee, Available_Timing
                     FROM Doctor
                     WHERE Doctor_ID = @Doctor_ID";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.Add("@Doctor_ID", SqlDbType.Int).Value = Doctor_ID;

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    textBox1.Text = reader["First_Name"].ToString();
                    textBox2.Text = reader["Last_Name"].ToString();
                    textBox3.Text = reader["Specialization"].ToString();
                    textBox4.Text = reader["Phone_Number"].ToString();
                    textBox5.Text = reader["Consultation_Fee"].ToString();
                    textBox6.Text = reader["Available_Timing"].ToString();
                }

                reader.Close();
            }

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            Connection c1 = new Connection();
            SqlConnection con = c1.OpenConnection();

            string query = @"UPDATE Doctor
                         SET First_Name = @First_Name,
                             Last_Name = @Last_Name,
                             Specialization = @Specialization,
                             Phone_Number = @Phone_Number,
                             Consultation_Fee = @Consultation_Fee,
                             Available_Timing = @Available_Timing
                         WHERE Doctor_ID = @Doctor_ID";
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.Add("@First_Name", SqlDbType.VarChar).Value = textBox1.Text;
            cmd.Parameters.Add("@Last_Name", SqlDbType.VarChar).Value = textBox2.Text;
            cmd.Parameters.Add("@Specialization", SqlDbType.VarChar).Value = textBox3.Text;
            cmd.Parameters.Add("@Phone_Number", SqlDbType.VarChar).Value = textBox4.Text;
            cmd.Parameters.Add("@Consultation_Fee", SqlDbType.Decimal).Value =
                Convert.ToDecimal(textBox5.Text);
            cmd.Parameters.Add("@Available_Timing", SqlDbType.VarChar).Value = textBox6.Text;

                int id = Convert.ToInt32(Doctorid.Text);
                cmd.Parameters.Add("@Doctor_ID", SqlDbType.Int).Value = id;

             cmd.ExecuteNonQuery();

            MessageBox.Show("Updated Successfully");
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
    }
    
}
