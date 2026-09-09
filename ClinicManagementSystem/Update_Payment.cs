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
    public partial class Update_Payment : Form
    {
        public Update_Payment()
        {
            InitializeComponent();
        }

        private void Update_Payment_Load(object sender, EventArgs e)
        {
            Connection c1 = new Connection();
            SqlConnection con;
            con = c1.OpenConnection();
            string query = @"select * from Payment order by Payment_ID";
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                Paymentid.DataSource = dt;
                Paymentid.ValueMember = "Payment_ID";
                Paymentid.SelectedIndex = 0;

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

        private void Paymentid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Paymentid.Text == "")
                return;
            int paymentId;

            if (!int.TryParse(Paymentid.Text, out paymentId))
                return;


            Connection c1 = new Connection();
            SqlConnection con = c1.OpenConnection();

            string query = @"SELECT Bill_ID, Amount_Paid, Payment_Date, 
                                 Payment_Method, Recieved_By    
                     FROM Payment
                     WHERE Payment_ID = @Payment_ID";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Payment_ID", SqlDbType.Int).Value = paymentId;

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                textBox1.Text = dr["Bill_ID"].ToString();
                textBox2.Text = dr["Amount_Paid"].ToString();
                textBox3.Text = dr["Payment_Date"].ToString();
                textBox4.Text = dr["Payment_Method"].ToString();
                textBox5.Text = dr["Recieved_By"].ToString();

            }

            dr.Close();
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection c1 = new Connection();
            SqlConnection con = c1.OpenConnection();

            string query = @"UPDATE Payment
                 SET Bill_ID = @Bill_ID,
                     Amount_Paid = @Amount_Paid,
                     Payment_Date = @Payment_Date,
                     Payment_Method = @Payment_Method,
                     Recieved_By = @Recieved_By
                 WHERE Payment_ID = @Payment_ID";

            try
            {
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.Add("@Bill_ID", SqlDbType.Int).Value = Convert.ToInt32(textBox1.Text);
                cmd.Parameters.Add("@Amount_Paid", SqlDbType.Decimal).Value = Convert.ToDecimal(textBox2.Text);
                cmd.Parameters.Add("@Payment_Date", SqlDbType.Date).Value = Convert.ToDateTime(textBox3.Text);
                cmd.Parameters.Add("@Payment_Method", SqlDbType.VarChar).Value = textBox4.Text;
                cmd.Parameters.Add("@Recieved_By", SqlDbType.VarChar).Value = textBox5.Text;

                int paymentId = Convert.ToInt32(Paymentid.Text);
                cmd.Parameters.Add("@Payment_ID", SqlDbType.Int).Value = paymentId;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Payment Updated Successfully");
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
