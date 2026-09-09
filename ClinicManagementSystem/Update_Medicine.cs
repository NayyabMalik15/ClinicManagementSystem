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
    public partial class Update_Medicine : Form
    {
        public Update_Medicine()
        {
            InitializeComponent();
        }

        private void Update_Medicine_Load(object sender, EventArgs e)
        {
            Connection c1 = new Connection();
            SqlConnection con;
            con = c1.OpenConnection();
            string query = @"select * from Medicine order by Prescription_ID";
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                Prescriptionid.DataSource = dt;
                Prescriptionid.ValueMember = "Prescription_ID";
                Prescriptionid.SelectedIndex = 0;

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

        private void Prescriptionid_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Prescriptionid.Text == "")
                return;
            int prescriptionId;

            if (!int.TryParse(Prescriptionid.Text, out prescriptionId))
                return;


            Connection c1 = new Connection();
            SqlConnection con = c1.OpenConnection();

            string query = @"SELECT Token_ID, Expiry_Date, Patient_ID, Doctor_ID, Medicine_Detail
                     FROM Medicine
                     WHERE Prescription_ID = @Prescription_ID";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Prescription_ID", SqlDbType.Int).Value = prescriptionId;

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                textBox1.Text = dr["Token_ID"].ToString();
                textBox2.Text = dr["Expiry_Date"].ToString();
                textBox3.Text = dr["Patient_ID"].ToString();
                textBox4.Text = dr["Doctor_ID"].ToString();
                textBox5.Text = dr["Medicine_Detail"].ToString();
            }

            dr.Close();
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection c1 = new Connection();
            SqlConnection con = c1.OpenConnection();

            string query = @"UPDATE Medicine
                 SET Token_ID = @Token_ID,
                     Expiry_Date = @Expiry_Date,
                     Patient_ID = @Patient_ID,
                     Doctor_ID = @Doctor_ID,
                     Medicine_Detail = @Medicine_Detail
                 WHERE Prescription_ID = @Prescription_ID";

            try
            {
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.Add("@Token_ID", SqlDbType.VarChar).Value = textBox1.Text;
                cmd.Parameters.Add("@Expiry_Date", SqlDbType.Date).Value = Convert.ToDateTime(textBox2.Text);
                cmd.Parameters.Add("@Patient_ID", SqlDbType.Int).Value = Convert.ToInt32(textBox3.Text);
                cmd.Parameters.Add("@Doctor_ID", SqlDbType.Int).Value = Convert.ToInt32(textBox4.Text);
                cmd.Parameters.Add("@Medicine_Detail", SqlDbType.VarChar).Value = textBox5.Text;

                int Id = Convert.ToInt32(Prescriptionid.SelectedValue);
                cmd.Parameters.Add("@Prescription_ID", SqlDbType.Int).Value = Id;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Medicine Updated Successfully");
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
