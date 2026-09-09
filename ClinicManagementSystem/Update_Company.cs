using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClinicManagementSystem
{
    public partial class Update_Company : Form
    {
        public Update_Company()
        {
            InitializeComponent();
        }

        private void Update_Company_Load(object sender, EventArgs e)
        {
            Connection c1 = new Connection();
            SqlConnection con1 = c1.OpenConnection();

            string queryCompany = @"SELECT * FROM Company ORDER BY Company_ID";
            SqlCommand cmdCompany = new SqlCommand(queryCompany, con1);

            try
            {
                SqlDataAdapter daCompany = new SqlDataAdapter(cmdCompany);
                DataTable dtCompany = new DataTable();

                daCompany.Fill(dtCompany);

                Companyid.DataSource = dtCompany;
                Companyid.ValueMember = "Company_ID";
                Companyid.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con1.Close();
            }
        }

        private void Companyid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Companyid.SelectedIndex == -1)
                return;

            if (Companyid.SelectedValue is DataRowView)
                return;

            Connection c1 = new Connection();
            SqlConnection con = c1.OpenConnection();

            string query = @"SELECT * FROM Company
                     WHERE Company_ID = @Company_ID";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Company_ID", Convert.ToInt32(Companyid.SelectedValue));

            try
            {
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    textBox1.Text = dr["Company_Name"].ToString();
                    textBox2.Text = dr["Contact_Person"].ToString();
                    textBox3.Text = dr["Phone"].ToString();
                    textBox4.Text = dr["Email"].ToString();
                    textBox5.Text = dr["City"].ToString();
                    textBox6.Text = dr["Status"].ToString();
                    textBox7.Text = dr["Address"].ToString();
                }

                dr.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Connection c1 = new Connection();
            SqlConnection con = c1.OpenConnection();

            string query = @"UPDATE Company SET
                     Company_Name = @Company_Name,
                     Contact_Person = @Contact_Person,
                     Phone = @Phone,
                     Email = @Email,
                     City = @City,
                     Status = @Status,
                     Address = @Address
                     WHERE Company_ID = @Company_ID";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Company_ID", Companyid.SelectedValue);
            cmd.Parameters.AddWithValue("@Company_Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@Contact_Person", textBox2.Text);
            cmd.Parameters.AddWithValue("@Phone", textBox3.Text);
            cmd.Parameters.AddWithValue("@Email", textBox4.Text);
            cmd.Parameters.AddWithValue("@City", textBox5.Text);
            cmd.Parameters.AddWithValue("@Status", textBox6.Text);
            cmd.Parameters.AddWithValue("@Address", textBox7.Text);

            try
            {
                cmd.ExecuteNonQuery();

                MessageBox.Show("Company updated successfully!");
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
