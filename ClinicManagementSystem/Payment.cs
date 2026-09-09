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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Billid.Text = string.Empty;
            AmountPaid.Text = string.Empty;
            PaymentMethod.Text = string.Empty;
            PaymentDate.Text = string.Empty;
            ReceivedBy.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection c1 = new Connection();
            SqlConnection con;
            con = c1.OpenConnection();
            string query = @"INSERT INTO Payment
                    ( Bill_ID, Amount_Paid, Payment_Method, Payment_Date, Recieved_By)
                    VALUES
                    (@Bill_ID, @Amount_Paid, @Payment_Method, @Payment_Date, @Recieved_By)";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Bill_ID", Billid.Text);
            cmd.Parameters.AddWithValue("@Amount_Paid", AmountPaid.Text);
            cmd.Parameters.AddWithValue("@Payment_Method", PaymentMethod.Text);
            cmd.Parameters.AddWithValue("@Payment_Date", PaymentDate.Value);
            cmd.Parameters.AddWithValue("Recieved_By", ReceivedBy.Text);

            try
            {

                cmd.ExecuteNonQuery();

                MessageBox.Show("Payment inserted successfully!");
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

        private void Payment_Load(object sender, EventArgs e)
        {
            Connection c1 = new Connection();
            SqlConnection con1 = c1.OpenConnection();
            string queryBill = @"select * from Bill order by Bill_ID";
            SqlCommand cmdBill = new SqlCommand(queryBill, con1);

            try
            {
                SqlDataAdapter daBill = new SqlDataAdapter(cmdBill);
                DataTable dtBill = new DataTable();
                daBill.Fill(dtBill);

                Billid.DataSource = dtBill;
                Billid.ValueMember = "Bill_ID";
                Billid.SelectedIndex = 0;

                cmdBill.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con1.Close();
            }
            Connection c2 = new Connection();
            SqlConnection con = c2.OpenConnection();

            string query = "SELECT First_Name, Last_Name FROM Staff";

            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                SqlDataReader dr = cmd.ExecuteReader();

                ReceivedBy.Items.Clear();

                while (dr.Read())
                {
                    string fullName = dr["First_Name"].ToString() + " " +
                              dr["Last_Name"].ToString();
                    ReceivedBy.Items.Add(fullName);
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

        private void button3_Click(object sender, EventArgs e)
        {
            Connection c1 = new Connection();
            SqlConnection con = c1.OpenConnection();

            string query = @"DELETE FROM Payment
                     WHERE Bill_ID = @Bill_ID";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Bill_ID", Billid.Text);

            try
            {
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Payment deleted successfully!");
                }
                else
                {
                    MessageBox.Show("Payment not found!");
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
            Form fr = new Update_Payment();
            fr.Show();
        }
    }
}
