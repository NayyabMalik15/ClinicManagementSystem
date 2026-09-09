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
    public partial class Update_Token : Form
    {
        public Update_Token()
        {
            InitializeComponent();
        }

        private void Update_Token_Load(object sender, EventArgs e)
        {
            Connection c1 = new Connection();
            SqlConnection con;
            con = c1.OpenConnection();
            string query = @"select * from Token order by Token_ID";
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                Tokenid.DataSource = dt;
                Tokenid.ValueMember = "Token_ID";
                Tokenid.SelectedIndex = 0;

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

        private void Tokenid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Tokenid.Text == "")
                return;

            int tokenId;

            if (!int.TryParse(Tokenid.Text, out tokenId))
                return;

            Connection c1 = new Connection();
            SqlConnection con = c1.OpenConnection();

            string query = @"SELECT Token_Number, Token_Date, Patient_ID,
                            Doctor_ID, Fee
                     FROM Token
                     WHERE Token_ID = @Token_ID";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.Add("@Token_ID", SqlDbType.Int).Value = tokenId;

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                textBox1.Text = reader["Token_Number"].ToString();
                textBox2.Text = reader["Token_Date"].ToString();
                textBox3.Text = reader["Patient_ID"].ToString();
                textBox4.Text = reader["Doctor_ID"].ToString();
                textBox6.Text = reader["Fee"].ToString();
               
            }

            reader.Close();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection c1 = new Connection();
            SqlConnection con = c1.OpenConnection();

            string query = @"UPDATE Token
                 SET Token_Number = @Token_Number,
                     Token_Date = @Token_Date,
                     Patient_ID = @Patient_ID,
                     Doctor_ID = @Doctor_ID,
                     Fee = @Fee

                 WHERE Token_ID = @Token_ID";

            try
            {
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.Add("@Token_Number", SqlDbType.VarChar).Value = textBox1.Text;
                cmd.Parameters.Add("@Token_Date", SqlDbType.DateTime).Value =
    DateTime.Parse(textBox2.Text);
                cmd.Parameters.Add("@Patient_ID", SqlDbType.VarChar).Value = textBox3.Text;
                cmd.Parameters.Add("@Doctor_ID", SqlDbType.VarChar).Value = textBox4.Text;
                cmd.Parameters.Add("@Fee", SqlDbType.VarChar).Value = textBox6.Text;
                

                int id = Convert.ToInt32(Tokenid.Text);
                cmd.Parameters.Add("@Token_ID", SqlDbType.Int).Value = id;

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
