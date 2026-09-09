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
    public partial class Update_Staff : Form
    {
        public Update_Staff()
        {
            InitializeComponent();
        }

        private void Update_Staff_Load(object sender, EventArgs e)
        {
            Connection c1 = new Connection();
            SqlConnection con;
            con = c1.OpenConnection();
            string query = @"select * from Staff order by Staff_ID";
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                Staffid.DataSource = dt;
                Staffid.ValueMember = "Staff_ID";
                Staffid.SelectedIndex = 0;

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

        private void Staffid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Staffid.Text == "")
                return;

            int staffId;

            if (!int.TryParse(Staffid.Text, out staffId))
                return;

            Connection c1 = new Connection();
            SqlConnection con = c1.OpenConnection();

            string query = @"SELECT First_Name, Last_Name, Role, 
                            Phone_Number, Email
                     FROM Staff
                     WHERE Staff_ID = @Staff_ID";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.Add("@Staff_ID", SqlDbType.Int).Value = staffId;

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                textBox1.Text = reader["First_Name"].ToString();
                textBox2.Text = reader["Last_Name"].ToString();
                textBox3.Text = reader["Role"].ToString();
                textBox4.Text = reader["Phone_Number"].ToString();
                textBox5.Text = reader["Email"].ToString();
            }

            reader.Close();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection c1 = new Connection();
            SqlConnection con = c1.OpenConnection();

            string query = @"UPDATE Staff
                 SET First_Name = @First_Name,
                     Last_Name = @Last_Name,
                     Role = @Role,
                     Phone_Number = @Phone_Number,
                     Email = @Email
                 WHERE Staff_ID = @Staff_ID";

            try
            {
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.Add("@First_Name", SqlDbType.VarChar).Value = textBox1.Text;
                cmd.Parameters.Add("@Last_Name", SqlDbType.VarChar).Value = textBox2.Text;
                cmd.Parameters.Add("@Role", SqlDbType.VarChar).Value = textBox3.Text;
                cmd.Parameters.Add("@Phone_Number", SqlDbType.VarChar).Value = textBox4.Text;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = textBox5.Text;

                int id = Convert.ToInt32(Staffid.Text);
                cmd.Parameters.Add("@Staff_ID", SqlDbType.Int).Value = id;

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
