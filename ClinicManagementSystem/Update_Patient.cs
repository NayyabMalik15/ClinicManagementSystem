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
    public partial class Update_Patient : Form
    {
        public Update_Patient()
        {
            InitializeComponent();
        }

        private void Update_Patient_Load(object sender, EventArgs e)
        {

            Connection c1 = new Connection();
            SqlConnection con;
            con = c1.OpenConnection();
            string query = @"select * from Patient order by Patient_ID";
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                Patientid.DataSource = dt;
                Patientid.ValueMember = "Patient_ID";
                Patientid.SelectedIndex = 0;

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

        private void Patientid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Patientid.Text == "")
                return;

            int patientId;

            if (!int.TryParse(Patientid.Text, out patientId))
                return;

            Connection c1 = new Connection();
            SqlConnection con = c1.OpenConnection();

            string query = @"SELECT First_Name, Last_Name, Gender,
                            Date_of_Birth, Phone_Number, Address
                     FROM Patient
                     WHERE Patient_ID = @Patient_ID";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.Add("@Patient_ID", SqlDbType.Int).Value = patientId;

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                textBox1.Text = reader["First_Name"].ToString();
                textBox2.Text = reader["Last_Name"].ToString();
                textBox3.Text = reader["Gender"].ToString();
                textBox4.Text = Convert.ToDateTime(reader["Date_of_Birth"])
                                      .ToString("yyyy-MM-dd");
                textBox5.Text = reader["Phone_Number"].ToString();
                textBox6.Text = reader["Address"].ToString();
            }

            reader.Close();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection c1 = new Connection();
            SqlConnection con = c1.OpenConnection();

            string query = @"UPDATE Patient
                 SET First_Name = @First_Name,
                     Last_Name = @Last_Name,
                     Gender = @Gender,
                     Date_of_Birth = @Date_of_Birth,
                     Phone_Number = @Phone_Number,
                     Address = @Address
                 WHERE Patient_ID = @Patient_ID";

            try
            {
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.Add("@First_Name", SqlDbType.VarChar).Value = textBox1.Text;
                cmd.Parameters.Add("@Last_Name", SqlDbType.VarChar).Value = textBox2.Text;

                
                cmd.Parameters.Add("@Gender", SqlDbType.VarChar).Value = textBox3.Text;

                cmd.Parameters.Add("@Date_of_Birth", SqlDbType.VarChar).Value = textBox4.Text;
                cmd.Parameters.Add("@Phone_Number", SqlDbType.VarChar).Value = textBox5.Text;
                cmd.Parameters.Add("@Address", SqlDbType.VarChar).Value = textBox6.Text;

                int id = Convert.ToInt32(Patientid.Text);

                cmd.Parameters.Add("@Patient_ID", SqlDbType.Int).Value = id;



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

            
         
    
