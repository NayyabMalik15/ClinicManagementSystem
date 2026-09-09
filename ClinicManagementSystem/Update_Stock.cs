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
    public partial class Update_Stock : Form
    {
        public Update_Stock()
        {
            InitializeComponent();
        }

        private void Update_Stock_Load(object sender, EventArgs e)
        {
            Connection c1 = new Connection();
            SqlConnection con1 = c1.OpenConnection();

            string queryStock = @"SELECT * FROM Stock ORDER BY Stock_ID";
            SqlCommand cmdStock = new SqlCommand(queryStock, con1);

            try
            {
                SqlDataAdapter daStock = new SqlDataAdapter(cmdStock);
                DataTable dtStock = new DataTable();

                daStock.Fill(dtStock);

                Stockid.DataSource = dtStock;
                Stockid.ValueMember = "Stock_ID";
                Stockid.SelectedIndex = 0;
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

        private void Stockid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Stockid.SelectedIndex == -1)
                return;

            if (Stockid.SelectedValue is DataRowView)
                return;

            Connection c1 = new Connection();
            SqlConnection con = c1.OpenConnection();

            string query = @"SELECT * FROM Stock
         WHERE Stock_ID = @Stock_ID";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Stock_ID",
                Convert.ToInt32(Stockid.SelectedValue));

            try
            {
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    textBox1.Text = dr["Product_Name"].ToString();
                    textBox2.Text = dr["Company_Name"].ToString();
                    textBox3.Text = dr["Batch_Number"].ToString();
                    textBox4.Text = dr["Quantity"].ToString();
                    textBox5.Text = dr["Stock_Type"].ToString();
                    textBox6.Text = dr["Purchase_Date"].ToString();
                    textBox7.Text = dr["Expiry_Date"].ToString();
                    textBox8.Text = dr["Price"].ToString();
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

            string query = @"UPDATE Stock SET
         Product_Name = @Product_Name,
         Company_Name = @Company_Name,
         Batch_Number = @Batch_Number,
         Quantity = @Quantity,
         Stock_Type = @Stock_Type,
         Purchase_Date = @Purchase_Date,
         Expiry_Date = @Expiry_Date,
         Price = @Price
         WHERE Stock_ID = @Stock_ID";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Stock_ID", Stockid.SelectedValue);
            cmd.Parameters.AddWithValue("@Product_Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@Company_Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Batch_Number", textBox3.Text);
            cmd.Parameters.AddWithValue("@Quantity", textBox4.Text);
            cmd.Parameters.AddWithValue("@Stock_Type", textBox5.Text);

            cmd.Parameters.Add("@Purchase_Date", SqlDbType.Date).Value =
                DateTime.Parse(textBox6.Text);

            cmd.Parameters.Add("@Expiry_Date", SqlDbType.Date).Value =
                DateTime.Parse(textBox7.Text);
            cmd.Parameters.AddWithValue("@Price", textBox8.Text);

            try
            {
                cmd.ExecuteNonQuery();

                MessageBox.Show("Stock updated successfully!");

                this.Close();
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
