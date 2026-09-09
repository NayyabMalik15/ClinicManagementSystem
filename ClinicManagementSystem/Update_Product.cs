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
    public partial class Update_Product : Form
    {
        public Update_Product()
        {
            InitializeComponent();
        }

        private void Update_Product_Load(object sender, EventArgs e)
        {
            Connection c1 = new Connection();
            SqlConnection con1 = c1.OpenConnection();

            string queryProduct = @"SELECT * FROM Product ORDER BY Product_ID";
            SqlCommand cmdProduct = new SqlCommand(queryProduct, con1);

            try
            {
                SqlDataAdapter daProduct = new SqlDataAdapter(cmdProduct);
                DataTable dtProduct = new DataTable();

                daProduct.Fill(dtProduct);

                Productid.DataSource = dtProduct;
                Productid.ValueMember = "Product_ID";
                Productid.SelectedIndex = 0;
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

        private void Productid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Productid.SelectedIndex == -1)
                return;

            if (Productid.SelectedValue is DataRowView)
                return;

            Connection c1 = new Connection();
            SqlConnection con = c1.OpenConnection();

            string query = @"SELECT * FROM Product
                     WHERE Product_ID = @Product_ID";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Product_ID",
                Convert.ToInt32(Productid.SelectedValue));

            try
            {
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    textBox1.Text = dr["Product_Name"].ToString();
                    textBox2.Text = dr["Company_ID"].ToString();
                    textBox3.Text = dr["Category"].ToString();
                    textBox4.Text = dr["Unit"].ToString();
                    textBox5.Text = dr["Purchase_Price"].ToString();
                    textBox6.Text = dr["Sale_Price"].ToString();
                    textBox7.Text = dr["Status"].ToString();
                    textBox8.Text = dr["Description"].ToString();
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

            string query = @"UPDATE Product SET
                     Product_Name = @Product_Name,
                     Company_ID = @Company_ID,
                     Category = @Category,
                     Unit = @Unit,
                     Purchase_Price = @Purchase_Price,
                     Sale_Price = @Sale_Price,
                     Status = @Status,
                     Description = @Description
                     WHERE Product_ID = @Product_ID";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Product_ID", Productid.SelectedValue);
            cmd.Parameters.AddWithValue("@Product_Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@Company_ID", textBox2.Text);
            cmd.Parameters.AddWithValue("@Category", textBox3.Text);
            cmd.Parameters.AddWithValue("@Unit", textBox4.Text);
            cmd.Parameters.AddWithValue("@Purchase_Price", textBox5.Text);
            cmd.Parameters.AddWithValue("@Sale_Price", textBox6.Text);
            cmd.Parameters.AddWithValue("@Status", textBox7.Text);
            cmd.Parameters.AddWithValue("@Description", textBox8.Text);

            try
            {
                cmd.ExecuteNonQuery();

                MessageBox.Show("Product updated successfully!");

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
