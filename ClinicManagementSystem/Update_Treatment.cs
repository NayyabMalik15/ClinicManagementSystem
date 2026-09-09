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
    public partial class Update_Treatment : Form
    {
        public Update_Treatment()
        {
            InitializeComponent();
        }

        private void Update_Treatment_Load(object sender, EventArgs e)
        {
            Connection c1 = new Connection();
            SqlConnection con;
            con = c1.OpenConnection();
            string query = @"select * from Treatment order by Treatment_ID";
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                Treatmentid.DataSource = dt;
                Treatmentid.ValueMember = "Treatment_ID";
                Treatmentid.SelectedIndex = 0;

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

        private void Treatmentid_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connection c1 = new Connection();
            SqlConnection con = c1.OpenConnection();

            DataRowView row = Treatmentid.SelectedItem as DataRowView;
            if (row == null)
                return;

            int treatmentId = Convert.ToInt32(row["Treatment_ID"]);


            string query = @"SELECT Treatment_Name, Standard_Cost, Description
                     FROM Treatment
                     WHERE Treatment_ID = @Treatment_ID";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add("@Treatment_ID", SqlDbType.Int).Value = treatmentId;

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                textBox1.Text = reader["Treatment_Name"].ToString();
                textBox2.Text = reader["Standard_Cost"].ToString();
                textBox3.Text = reader["Description"].ToString();
            }

            reader.Close();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection c1 = new Connection();
            SqlConnection con = c1.OpenConnection();

            string query = @"UPDATE Treatment
                 SET Treatment_Name = @Treatment_Name,
                     Standard_Cost = @Standard_Cost,
                     Description = @Description
                 WHERE Treatment_ID = @Treatment_ID";

            try
            {
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.Add("@Treatment_Name", SqlDbType.VarChar).Value = textBox1.Text;

                cmd.Parameters.Add("@Standard_Cost", SqlDbType.Decimal).Value =
                    Convert.ToDecimal(textBox2.Text);

                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value =
                    textBox3.Text;

                int id = Convert.ToInt32(Treatmentid.Text);
                cmd.Parameters.Add("@Treatment_ID", SqlDbType.Int).Value = id;

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
