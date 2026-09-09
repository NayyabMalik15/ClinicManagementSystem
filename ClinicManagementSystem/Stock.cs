using ClosedXML.Excel;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using ExcelDataReader;



namespace ClinicManagementSystem
{
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Connection c1 = new Connection();
            SqlConnection con = c1.OpenConnection();

            string query = @"INSERT INTO Stock
            (Product_Name, Company_Name, Batch_Number, Quantity, Stock_Type, Purchase_Date, Expiry_Date, Price)
            VALUES
            (@Product_Name, @Company_Name, @Batch_Number, @Quantity, @Stock_Type, @Purchase_Date, @Expiry_Date, @Price)";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Product_Name", ProductName.Text);
            cmd.Parameters.AddWithValue("@Company_Name", CompanyName.Text);
            cmd.Parameters.AddWithValue("@Batch_Number", BatchNumber.Text);
            cmd.Parameters.AddWithValue("@Quantity", Quantity.Value);
            cmd.Parameters.AddWithValue("@Stock_Type", StockType.Text);
            cmd.Parameters.AddWithValue("@Purchase_Date", PurchaseDate.Value);
            cmd.Parameters.AddWithValue("@Expiry_Date", ExpiryDate.Value);
            cmd.Parameters.AddWithValue("@Price", Price.Text);

            try
            {
                cmd.ExecuteNonQuery();

                MessageBox.Show("Stock inserted successfully!");
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

            string query = @"DELETE FROM Stock
                     WHERE Product_Name = @Product_Name
                     AND Batch_Number = @Batch_Number";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Product_Name", ProductName.Text);
            cmd.Parameters.AddWithValue("@Batch_Number", BatchNumber.Text);

            try
            {
                cmd.ExecuteNonQuery();

                MessageBox.Show("Stock deleted successfully!");
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
            CompanyName.Text = string.Empty;
            BatchNumber.Text = string.Empty;
            Quantity.Text = string.Empty;
            StockType.Text = string.Empty;
            PurchaseDate.Text = string.Empty;
            ExpiryDate.Text = string.Empty;
            Price.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form fr = new Update_Stock();
            fr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Title = "Select Excel File";
                    openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
                    openFileDialog.Multiselect = false;

                    if (openFileDialog.ShowDialog() != DialogResult.OK)
                        return;

                    Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

                    using (FileStream stream = File.Open(
                        openFileDialog.FileName,
                        FileMode.Open,
                        FileAccess.Read))
                    {
                        using (IExcelDataReader reader =
                            ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet dataSet = reader.AsDataSet(
                                new ExcelDataSetConfiguration
                                {
                                    ConfigureDataTable = (_) =>
                                        new ExcelDataTableConfiguration
                                        {
                                            UseHeaderRow = true
                                        }
                                });

                            if (dataSet.Tables.Count == 0)
                            {
                                MessageBox.Show("No Dataa in Excel File.");
                                return;
                            }

                            DataTable dt = dataSet.Tables[0];

                            if (dt.Rows.Count == 0)
                            {
                                MessageBox.Show("No record in excel file.");
                                return;
                            }

                            string productColumn = GetColumnName(dt,
                                "Product Name",
                                "Product_Name",
                                "ProductName");

                            string companyColumn = GetColumnName(dt,
                                "Company Name",
                                "Company_Name",
                                "CompanyName");

                            string batchColumn = GetColumnName(dt,
                                "Batch Number",
                                "Batch_Number",
                                "BatchNumber");

                            string quantityColumn = GetColumnName(dt,
                                "Quantity",
                                "Qty");

                            string stockTypeColumn = GetColumnName(dt,
                                "Stock Type",
                                "Stock_Type",
                                "StockType");

                            string purchaseDateColumn = GetColumnName(dt,
                                "Purchase Date",
                                "Purchase_Date",
                                "PurchaseDate");

                            string expiryDateColumn = GetColumnName(dt,
                                "Expiry Date",
                                "Expiry_Date",
                                "ExpiryDate");

                            string priceColumn = GetColumnName(dt,
                                "Price");

                            if (productColumn == null ||
                                companyColumn == null ||
                                batchColumn == null ||
                                quantityColumn == null ||
                                stockTypeColumn == null ||
                                purchaseDateColumn == null ||
                                expiryDateColumn == null ||
                                priceColumn == null)
                            {
                                MessageBox.Show(
                                    "Excel columns match nahi kar rahe.\n\n" +
                                    "Required columns:\n" +
                                    "Product Name\n" +
                                    "Company Name\n" +
                                    "Batch Number\n" +
                                    "Quantity\n" +
                                    "Stock Type\n" +
                                    "Purchase Date\n" +
                                    "Expiry Date\n" +
                                    "Price");

                                return;
                            }

                            Connection c1 = new Connection();
                            SqlConnection con = c1.OpenConnection();

                            using (SqlTransaction transaction = con.BeginTransaction())
                            {
                                try
                                {
                                    string query = @"
                        INSERT INTO Stock
                        (
                            Product_Name,
                            Company_Name,
                            Batch_Number,
                            Quantity,
                            Stock_Type,
                            Purchase_Date,
                            Expiry_Date,
                            Price
                        )
                        VALUES
                        (
                            @Product_Name,
                            @Company_Name,
                            @Batch_Number,
                            @Quantity,
                            @Stock_Type,
                            @Purchase_Date,
                            @Expiry_Date,
                            @Price
                        )";

                                    int insertedRows = 0;

                                    foreach (DataRow row in dt.Rows)
                                    {
                                        string productName =
                                            row[productColumn]?.ToString().Trim();

                                        string companyName =
                                            row[companyColumn]?.ToString().Trim();

                                        string batchNumber =
                                            row[batchColumn]?.ToString().Trim();

                                        string stockType =
                                            row[stockTypeColumn]?.ToString().Trim();

                                        int quantity;

                                        if (!TryGetQuantity(
                                            row[quantityColumn],
                                            out quantity))
                                        {
                                            continue;
                                        }

                                        DateTime purchaseDate;

                                        if (!DateTime.TryParse(
                                            row[purchaseDateColumn]?.ToString(),
                                            out purchaseDate))
                                        {
                                            continue;
                                        }

                                        DateTime expiryDate;

                                        if (!DateTime.TryParse(
                                            row[expiryDateColumn]?.ToString(),
                                            out expiryDate))
                                        {
                                            continue;
                                        }

                                        decimal price;

                                        if (!TryGetPrice(
                                            row[priceColumn],
                                            out price))
                                        {
                                            continue;
                                        }

                                        using (SqlCommand cmd =
                                            new SqlCommand(query, con, transaction))
                                        {
                                            cmd.Parameters.Add(
                                                "@Product_Name",
                                                SqlDbType.NVarChar).Value =
                                                productName;

                                            cmd.Parameters.Add(
                                                "@Company_Name",
                                                SqlDbType.NVarChar).Value =
                                                companyName;

                                            cmd.Parameters.Add(
                                                "@Batch_Number",
                                                SqlDbType.NVarChar).Value =
                                                batchNumber;

                                            cmd.Parameters.Add(
                                                "@Quantity",
                                                SqlDbType.Int).Value =
                                                quantity;

                                            cmd.Parameters.Add(
                                                "@Stock_Type",
                                                SqlDbType.NVarChar).Value =
                                                stockType;

                                            cmd.Parameters.Add(
                                                "@Purchase_Date",
                                                SqlDbType.Date).Value =
                                                purchaseDate.Date;

                                            cmd.Parameters.Add(
                                                "@Expiry_Date",
                                                SqlDbType.Date).Value =
                                                expiryDate.Date;

                                            cmd.Parameters.Add(
                                                "@Price",
                                                SqlDbType.Decimal).Value =
                                                price;

                                            cmd.ExecuteNonQuery();

                                            insertedRows++;
                                        }
                                    }

                                    transaction.Commit();

                                    MessageBox.Show(
                                        insertedRows +
                                        " Records successfully saved in Database.",
                                        "Import Successful",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                                }
                                catch
                                {
                                    transaction.Rollback();
                                    throw;
                                }
                            }

                            con.Close();
                        }
                    }
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

private string GetColumnName(DataTable dt, params string[] names)
        {
            foreach (string name in names)
            {
                foreach (DataColumn column in dt.Columns)
                {
                    if (column.ColumnName.Trim()
                        .Equals(
                            name.Trim(),
                            StringComparison.OrdinalIgnoreCase))
                    {
                        return column.ColumnName;
                    }
                }
            }

            return null;
        }

        private bool TryGetQuantity(object value, out int quantity)
        {
            quantity = 0;

            if (value == null || value == DBNull.Value)
                return false;

            decimal number;

            if (decimal.TryParse(
                value.ToString(),
                out number))
            {
                if (number < 0 || number != Math.Truncate(number))
                    return false;

                quantity = Convert.ToInt32(number);
                return true;
            }

            return false;
        }

        private bool TryGetPrice(object value, out decimal price)
        {
            price = 0;

            if (value == null || value == DBNull.Value)
                return false;

            decimal number;

            if (decimal.TryParse(
                value.ToString(),
                out number))
            {
                if (number < 0)
                    return false;

                price = number;
                return true;
            }

            return false;
        }

    }
    
    
}
     