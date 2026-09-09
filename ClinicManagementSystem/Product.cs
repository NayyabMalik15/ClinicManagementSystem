using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Text;
using System.Globalization;
using System.Windows.Forms;
using ClosedXML.Excel;
using ExcelDataReader;
using System.IO;

namespace ClinicManagementSystem
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void Product_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Connection c1 = new Connection();
            SqlConnection con = c1.OpenConnection();

            string query = @"INSERT INTO Product
            (Product_Name, Company_ID, Category, Unit, Purchase_Price, Sale_Price, Status, Description)
            VALUES
            (@Product_Name, @Company_ID, @Category, @Unit, @Purchase_Price, @Sale_Price, @Status, @Description)";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Product_Name", ProductName.Text);
            cmd.Parameters.AddWithValue("@Company_ID", Companyid.SelectedValue);
            cmd.Parameters.AddWithValue("@Category", Category.Text);
            cmd.Parameters.AddWithValue("@Unit", Unit.Text);
            cmd.Parameters.AddWithValue("@Purchase_Price", PurchasePrice.Text);
            cmd.Parameters.AddWithValue("@Sale_Price", SalePrice.Text);
            cmd.Parameters.AddWithValue("@Status", Status.Text);
            cmd.Parameters.AddWithValue("@Description", Description.Text);

            try
            {
                cmd.ExecuteNonQuery();

                MessageBox.Show("Product inserted successfully!");
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

            string query = @"DELETE FROM Product
                     WHERE Product_Name = @Product_Name";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Product_Name", ProductName.Text);

            try
            {
                cmd.ExecuteNonQuery();

                MessageBox.Show("Product deleted successfully!");
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

        private void button4_Click(object sender, EventArgs e)
        {
            ProductName.Text = string.Empty;
            Companyid.Text = string.Empty;
            Unit.Text = string.Empty;
            PurchasePrice.Text = string.Empty;
            SalePrice.Text = string.Empty;
            Status.Text = string.Empty;
            Description.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form fr = new Update_Product();
            fr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();

                openFile.Title = "Select Excel File";
                openFile.Filter = "Excel Files|*.xlsx;*.xls";
                openFile.Multiselect = false;

                if (openFile.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                string filePath = openFile.FileName;

                using (XLWorkbook workbook = new XLWorkbook(filePath))
                {
                    IXLWorksheet worksheet = workbook.Worksheet(1);

                    int lastRow = worksheet.LastRowUsed().RowNumber();

                    Connection c1 = new Connection();
                    SqlConnection con = c1.OpenConnection();

                    for (int row = 2; row <= lastRow; row++)
                    {
                        string productName = worksheet.Cell(row, 1).GetString().Trim();
                        string companyIDText = worksheet.Cell(row, 2).GetString().Trim();
                        string category = worksheet.Cell(row, 3).GetString().Trim();
                        string unit = worksheet.Cell(row, 4).GetString().Trim();
                        string purchasePriceText = worksheet.Cell(row, 5).GetString().Trim();
                        string salePriceText = worksheet.Cell(row, 6).GetString().Trim();
                        string status = worksheet.Cell(row, 7).GetString().Trim();
                        string description = worksheet.Cell(row, 8).GetString().Trim();

                        if (string.IsNullOrWhiteSpace(productName))
                        {
                            continue;
                        }

                        int companyID = 0;
                        decimal purchasePrice = 0;
                        decimal salePrice = 0;

                        int.TryParse(companyIDText, out companyID);
                        decimal.TryParse(purchasePriceText, out purchasePrice);
                        decimal.TryParse(salePriceText, out salePrice);

                        string query = @"
                    INSERT INTO Product
                    (
                        Product_Name,
                        Company_ID,
                        Category,
                        Unit,
                        Purchase_Price,
                        Sale_Price,
                        Status,
                        Description
                    )
                    VALUES
                    (
                        @Product_Name,
                        @Company_ID,
                        @Category,
                        @Unit,
                        @Purchase_Price,
                        @Sale_Price,
                        @Status,
                        @Description
                    )";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@Product_Name", productName);
                            cmd.Parameters.AddWithValue("@Company_ID", companyID);
                            cmd.Parameters.AddWithValue("@Category", category);
                            cmd.Parameters.AddWithValue("@Unit", unit);
                            cmd.Parameters.AddWithValue("@Purchase_Price", purchasePrice);
                            cmd.Parameters.AddWithValue("@Sale_Price", salePrice);
                            cmd.Parameters.AddWithValue("@Status", status);
                            cmd.Parameters.AddWithValue("@Description", description);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    con.Close();
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error: " + ex.Message,
                    "Import Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
