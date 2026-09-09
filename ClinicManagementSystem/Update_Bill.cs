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
    public partial class Update_Bill : Form
    {
        public Update_Bill()
        {
            InitializeComponent();
        }

        private void Update_Bill_Load(object sender, EventArgs e)
        {
            Connection c1 = new Connection();
            SqlConnection con;
            con = c1.OpenConnection();
            string query = @"select * from Bill order by Bill_ID";
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                Billid.DataSource = dt;
                Billid.ValueMember = "Bill_ID";
                Billid.SelectedIndex = 0;

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

        private void Billid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Billid.Text == "")
                return;
            int billId;

            if (!int.TryParse(Billid.Text, out billId))
                return;


            Connection c1 = new Connection();
            SqlConnection con = c1.OpenConnection();

            string query = @"SELECT Token_ID, Patient_ID, Product, Price, Quantity, Doctor_Fee, Treatment_Cost, Total_Amount,
                                 Bill_Date, Bill_Status    
                     FROM Bill
                     WHERE Bill_ID = @Bill_ID";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Bill_ID", SqlDbType.Int).Value = billId;

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                textBox1.Text = dr["Token_ID"].ToString();
                textBox2.Text = dr["Patient_ID"].ToString();
                textBox8.Text = dr["Product"].ToString();
                textBox9.Text = dr["Price"].ToString();
                textBox10.Text = dr["Quantity"].ToString();
                textBox3.Text = dr["Doctor_Fee"].ToString();
                textBox4.Text = dr["Treatment_Cost"].ToString();
                textBox5.Text = dr["Total_Amount"].ToString();
                textBox6.Text = dr["Bill_Date"].ToString();
                textBox7.Text = dr["Bill_Status"].ToString();
            }

            dr.Close();
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Connection c1 = new Connection();
                SqlConnection con = c1.OpenConnection();

                string query = @"UPDATE Bill SET
                         Token_ID = @Token_ID,
                         Patient_ID = @Patient_ID,
                         Product = @Product,
                         Price = @Price,
                         Quantity = @Quantity,
                         Doctor_Fee = @Doctor_Fee,
                         Treatment_Cost = @Treatment_Cost,
                         Total_Amount = @Total_Amount,
                         Bill_Date = @Bill_Date,
                         Bill_Status = @Bill_Status
                         WHERE Bill_ID = @Bill_ID";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Bill_ID", Billid.Text);
                cmd.Parameters.AddWithValue("@Token_ID", textBox1.Text);
                cmd.Parameters.AddWithValue("@Patient_ID", textBox2.Text);
                cmd.Parameters.AddWithValue("@Product", textBox8.Text);
                cmd.Parameters.AddWithValue("@Price", textBox9.Text);
                cmd.Parameters.AddWithValue("@Quantity", textBox10.Text);
                cmd.Parameters.AddWithValue("@Doctor_Fee", textBox3.Text);
                cmd.Parameters.AddWithValue("@Treatment_Cost", textBox4.Text);
                cmd.Parameters.AddWithValue("@Total_Amount", textBox5.Text);
                cmd.Parameters.AddWithValue("@Bill_Date", textBox6.Text);
                cmd.Parameters.AddWithValue("@Bill_Status", textBox7.Text);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Bill Updated Successfully");
                }
                else
                {
                    MessageBox.Show("Bill not found");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
