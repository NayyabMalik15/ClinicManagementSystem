using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Printing;

namespace ClinicManagementSystem
{
    public partial class Bill : Form
    {

        public Bill()
        {
            InitializeComponent();
        }
        private void CalculateGrandTotal()
        {
            decimal grandTotal = 0;

            foreach (DataGridViewRow row in BillDataGridView.Rows)
            {
                if (row.IsNewRow)
                    continue;

                decimal total = 0;

                if (row.Cells[4].Value != null)
                {
                    decimal.TryParse(
                        row.Cells[4].Value.ToString(),
                        out total
                    );
                }

                grandTotal += total;
            }

            TotalAmount.Text = grandTotal.ToString("0.00");
        }
        private void CalculateTotal()
        {
            decimal price = 0;
            decimal quantity = Quantity.Value;
            decimal doctorFee = 0;
            decimal treatmentCost = 0;

            decimal.TryParse(Price.Text, out price);
            decimal.TryParse(DoctorFee.Text, out doctorFee);
            decimal.TryParse(TreatmentCost.Text, out treatmentCost);

            decimal total = (price * quantity) + doctorFee + treatmentCost;

            TotalAmount.Text = total.ToString("0.00");
        }
        private void LoadProducts()
        {
            try
            {
                Connection c1 = new Connection();
                SqlConnection con = c1.OpenConnection();

                string query = "SELECT Product_Name FROM Product ORDER BY Product_Name";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        ProductComboBox.Items.Clear();

                        while (dr.Read())
                        {
                            ProductComboBox.Items.Add(dr["Product_Name"].ToString());
                        }
                    }
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
       
        

        private void button4_Click(object sender, EventArgs e)
        {
            Tokenid.Text = string.Empty;
            Patientid.Text = string.Empty;
            Product.Text = string.Empty;
            Price.Text = string.Empty;
            Quantity.Text = string.Empty;
            DoctorFee.Text = string.Empty;
            TreatmentCost.Text = string.Empty;
            TotalAmount.Text = string.Empty;
            BillDate.Text = string.Empty;
            BillStatus.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Connection c2 = new Connection();

                using (SqlConnection con1 = c2.OpenConnection())
                {
                    string stockQuery = @"
            UPDATE Stock
            SET Quantity = Quantity - @Quantity
            WHERE Product_Name = @ProductName
            AND Stock_Type = 'IN'
            AND Quantity >= @Quantity";

                    using (SqlCommand stockCmd = new SqlCommand(stockQuery, con1))
                    {
                        stockCmd.Parameters.Add("@Quantity", SqlDbType.Int).Value =
                            Convert.ToInt32(Quantity.Text);

                        stockCmd.Parameters.Add("@ProductName", SqlDbType.NVarChar).Value =
                            ProductComboBox.Text.Trim();

                        int result = stockCmd.ExecuteNonQuery();

                        if (result == 0)
                        {
                            MessageBox.Show("Stock unavailable.");
                            return;
                        }


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            Connection c1 = new Connection();
            SqlConnection con;
            con = c1.OpenConnection();
            string query = @"INSERT INTO Bill
                    ( Token_ID, Patient_ID, Product, Price, Quantity, Doctor_Fee, Treatment_Cost, Total_Amount, Bill_Date, Bill_Status)
                    VALUES
                    (@Token_ID, @Patient_ID, @Product, @Price, @Quantity, @Doctor_Fee, @Treatment_Cost, @Total_Amount, @Bill_Date, @Bill_Status)";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Token_ID", Tokenid.Text);
            cmd.Parameters.AddWithValue("@Patient_ID", Patientid.SelectedValue);
            cmd.Parameters.AddWithValue("@Product", ProductComboBox.Text.Trim());
            cmd.Parameters.AddWithValue("@Price", Price.Text);
            cmd.Parameters.AddWithValue("@Quantity", Quantity.Text);
            cmd.Parameters.AddWithValue("@Doctor_Fee", DoctorFee.Text);
            cmd.Parameters.AddWithValue("@Treatment_Cost", TreatmentCost.Text);
            cmd.Parameters.AddWithValue("@Total_Amount", TotalAmount.Text);
            cmd.Parameters.AddWithValue("@Bill_Date", BillDate.Value);
            cmd.Parameters.AddWithValue("@Bill_Status", BillStatus.Text);

            try
            {
                cmd.ExecuteNonQuery();
            }

            finally
            {
                con.Close();
            }

            if (ProductComboBox.SelectedIndex == -1 ||
      string.IsNullOrWhiteSpace(ProductComboBox.Text))
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            decimal price = 0;
            decimal quantity = 0;
            decimal doctorFee = 0;
            decimal treatmentCost = 0;

            decimal.TryParse(Price.Text, out price);
            decimal.TryParse(Quantity.Text, out quantity);
            decimal.TryParse(DoctorFee.Text, out doctorFee);
            decimal.TryParse(TreatmentCost.Text, out treatmentCost);

            if (quantity <= 0)
            {
                MessageBox.Show("Quantity must be greater than 0.");
                return;
            }

            decimal productTotal = price * quantity;

            decimal total = productTotal + doctorFee + treatmentCost;

            BillDataGridView.Rows.Add(
                ProductComboBox.Text,
               
                price.ToString("0.00"),
                quantity,
                total.ToString("0.00")
            );

            CalculateGrandTotal();

            BillDataGridView.Rows.Add(
    Tokenid.Text,
    Patientid.Text,
    ProductComboBox.Text,
    Price.Text,
    Quantity.Value,
    DoctorFee.Text,
    TreatmentCost.Text,
    TotalAmount.Text,
    BillDate.Value.ToShortDateString(),
    BillStatus.Text
);
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            Connection c1 = new Connection();
            SqlConnection con1 = c1.OpenConnection();
            string queryPatient = @"select * from Patient order by Patient_ID";
            SqlCommand cmdPatient = new SqlCommand(queryPatient, con1);

            try
            {
                SqlDataAdapter daPatient = new SqlDataAdapter(cmdPatient);
                DataTable dtPatient = new DataTable();
                daPatient.Fill(dtPatient);

                Patientid.DataSource = dtPatient;
                Patientid.ValueMember = "Patient_ID";
                Patientid.SelectedIndex = 0;

                cmdPatient.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con1.Close();
            }
            SqlConnection con2 = c1.OpenConnection();
            string queryToken = @"select * from Token order by Token_ID";
            SqlCommand cmdToken = new SqlCommand(queryToken, con2);

            try
            {
                SqlDataAdapter daToken = new SqlDataAdapter(cmdToken);
                DataTable dtToken = new DataTable();
                daToken.Fill(dtToken);

                Tokenid.DataSource = dtToken;
                Tokenid.ValueMember = "Token_ID";
                Tokenid.SelectedIndex = 0;

                cmdToken.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con2.Close();
            }
            try
            {
                Connection c3 = new Connection();
                SqlConnection con = c3.OpenConnection();

                string query = @"SELECT Product_Name
                         FROM Product
                         WHERE Status = 'Active'
                         ORDER BY Product_Name";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        ProductComboBox.Items.Clear();

                        while (dr.Read())
                        {
                            ProductComboBox.Items.Add(dr["Product_Name"].ToString());
                        }
                    }
                }

                ProductComboBox.DropDownStyle = ComboBoxStyle.DropDown;
                ProductComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                ProductComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadProducts();

            DoctorFee.Text = "0";
            TreatmentCost.Text = "0";
            Quantity.Value = 1;
            Price.Text = "0";
            TotalAmount.Text = "0";

            try
            {
                Connection c4 = new Connection();
                SqlConnection con = c4.OpenConnection();

                string query = @"SELECT Patient_ID, First_Name, Last_Name 
                 FROM Patient 
                 ORDER BY Patient_ID";

                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataAdapter daPatient = new SqlDataAdapter(cmd);
                DataTable dtPatient = new DataTable();

                daPatient.Fill(dtPatient);

                dtPatient.Columns.Add("FullName", typeof(string));

                foreach (DataRow row in dtPatient.Rows)
                {
                    row["FullName"] = row["First_Name"].ToString() + " " +
                                      row["Last_Name"].ToString();
                }

                Patientid.DataSource = dtPatient;
                Patientid.DisplayMember = "FullName";
                Patientid.ValueMember = "Patient_ID";

                Patientid.SelectedIndex = -1;


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            BillDataGridView.ReadOnly = false;
            BillDataGridView.AllowUserToAddRows = false;
            BillDataGridView.AllowUserToDeleteRows = false;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Connection c1 = new Connection();
            SqlConnection con = c1.OpenConnection();

            string query = @"DELETE FROM Bill
                     WHERE Token_ID = @Token_ID";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Token_ID", Tokenid.Text);

            try
            {
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Bill deleted successfully!");
                }
                else
                {
                    MessageBox.Show("Bill not found!");
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
            Form fr = new Update_Bill();
            fr.Show();
        }

       

        private void Price_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void DoctorFee_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void Quantity_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void TreatmentCost_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void Product_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ProductComboBox.SelectedIndex == -1)
                    return;

                Connection c1 = new Connection();
                SqlConnection con = c1.OpenConnection();

                string query = @"SELECT Sale_Price
                         FROM Product
                         WHERE Product_Name = @Product_Name";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Product_Name",
                        ProductComboBox.Text.Trim());

                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        Price.Text = Convert.ToDecimal(result).ToString("0.00");
                    }
                    else
                    {
                        Price.Text = "0.00";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Tokenid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Tokenid.SelectedIndex == -1)
                return;

            try
            {
                DataRowView row = Tokenid.SelectedItem as DataRowView;

                if (row == null)
                    return;

                int tokenId = Convert.ToInt32(row["Token_ID"]);

                Connection c1 = new Connection();

                using (SqlConnection con = c1.OpenConnection())
                {
                    string query = @"
                SELECT Patient_ID
                FROM Token
                WHERE Token_ID = @Token_ID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add("@Token_ID", SqlDbType.Int).Value = tokenId;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Patientid.Text = reader["Patient_ID"].ToString();
                                
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BillDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Receipt", 315, 600);
            printDocument1.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(5, 5, 5, 5);
            printDocument1.PrintPage -= printDocument1_PrintPage;
            printDocument1.PrintPage += printDocument1_PrintPage;
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            Font titleFont = new Font("Arial", 13, FontStyle.Bold);
            Font subTitleFont = new Font("Arial", 9, FontStyle.Bold);
            Font normalFont = new Font("Arial", 8);
            Font boldFont = new Font("Arial", 8, FontStyle.Bold);
            Font totalFont = new Font("Arial", 10, FontStyle.Bold);

            float y = 10;
            float left = 8;
            float pageWidth = e.PageBounds.Width;
            float right = pageWidth - 20;
            float width = right - left;

            StringFormat center = new StringFormat();
            center.Alignment = StringAlignment.Center;

            StringFormat rightAlign = new StringFormat();
            rightAlign.Alignment = StringAlignment.Far;
            rightAlign.FormatFlags = StringFormatFlags.NoWrap;

            g.DrawString(
                "ALEESHA CLINIC",
                titleFont,
                Brushes.Black,
                new RectangleF(left, y, width, 25),
                center);

            y += 25;

            g.DrawString(
                "Patient Billing Receipt",
                subTitleFont,
                Brushes.Black,
                new RectangleF(left, y, width, 20),
                center);

            y += 28;

            g.DrawLine(
                Pens.Black,
                left,
                y,
                right,
                y);

            y += 8;

            g.DrawString(
                "Token ID",
                normalFont,
                Brushes.Black,
                left,
                y);

            g.DrawString(
                Tokenid.Text,
                normalFont,
                Brushes.Black,
                left + 75,
                y);

            y += 18;

            g.DrawString(
                "Patient Name",
                normalFont,
                Brushes.Black,
                left,
                y);

            g.DrawString(
                Patientid.Text,
                normalFont,
                Brushes.Black,
                left + 75,
                y);

            y += 23;

            g.DrawLine(
                Pens.Black,
                left,
                y,
                right,
                y);

            y += 8;

            float productX = 8;
            float priceX = 115;
            float qtyX = 165;
            float amountX = 205;

            g.DrawString(
                "PRODUCT",
                boldFont,
                Brushes.Black,
                productX,
                y);

            g.DrawString(
                "PRICE",
                boldFont,
                Brushes.Black,
                priceX,
                y);

            g.DrawString(
                "QTY",
                boldFont,
                Brushes.Black,
                qtyX,
                y);

            g.DrawString(
                "AMOUNT",
                boldFont,
                Brushes.Black,
                amountX,
                y);

            y += 18;

            g.DrawLine(
                Pens.Black,
                left,
                y,
                right,
                y);

            y += 7;

            decimal productTotal = 0;

            foreach (DataGridViewRow row in BillDataGridView.Rows)
            {
                if (row.IsNewRow)
                    continue;

                string product =
                    row.Cells["Prdct"].Value?.ToString() ?? "";

                decimal price = 0;
                int quantity = 0;

                decimal.TryParse(
                    row.Cells["Pp"].Value?.ToString(),
                    out price);

                int.TryParse(
                    row.Cells["Qty"].Value?.ToString(),
                    out quantity);

                if (quantity <= 0)
                    continue;

                decimal amount = price * quantity;

                productTotal += amount;

                g.DrawString(
                    product,
                    normalFont,
                    Brushes.Black,
                    new RectangleF(
                        productX,
                        y,
                        120,
                        20));

                g.DrawString(
                    price.ToString("0.00"),
                    normalFont,
                    Brushes.Black,
                    priceX,
                    y);

                g.DrawString(
                    quantity.ToString(),
                    normalFont,
                    Brushes.Black,
                    qtyX,
                    y);

                g.DrawString(
                    amount.ToString("0.00"),
                    normalFont,
                    Brushes.Black,
                    amountX,
                    y);

                y += 20;
            }

            y += 5;

            g.DrawLine(
                Pens.Black,
                left,
                y,
                right,
                y);

            y += 10;

            decimal doctorFee = 0;

            decimal.TryParse(
                DoctorFee.Text,
                out doctorFee);

            g.DrawString(
                "Doctor Fee",
                normalFont,
                Brushes.Black,
                left,
                y);

            g.DrawString(
    "Rs. " + doctorFee.ToString("0.00"),
    normalFont,
    Brushes.Black,
    205,
    y);

            y += 19;

            decimal treatmentCost = 0;

            decimal.TryParse(
                TreatmentCost.Text,
                out treatmentCost);

            g.DrawString(
                "Treatment Cost",
                normalFont,
                Brushes.Black,
                left,
                y);

            g.DrawString(
     "Rs. " + treatmentCost.ToString("0.00"),
     normalFont,
     Brushes.Black,
     205,
     y);
            y += 22;

            g.DrawLine(
                Pens.Black,
                left,
                y,
                right,
                y);

            y += 10;

            decimal grandTotal =
                productTotal +
                doctorFee +
                treatmentCost;

            g.DrawString(
                "TOTAL",
                totalFont,
                Brushes.Black,
                left,
                y);

            g.DrawString(
    "Rs. " + grandTotal.ToString("0.00"),
    totalFont,
    Brushes.Black,
    195,
    y);

            y += 28;

            g.DrawLine(
                Pens.Black,
                left,
                y,
                right,
                y);

            y += 10;

            g.DrawString(
                "Bill Date",
                normalFont,
                Brushes.Black,
                left,
                y);

            g.DrawString(
                BillDate.Value.ToString("dd/MM/yyyy"),
                normalFont,
                Brushes.Black,
                left + 75,
                y);

            y += 18;

            g.DrawString(
                "Bill Status",
                normalFont,
                Brushes.Black,
                left,
                y);

            g.DrawString(
                BillStatus.Text,
                normalFont,
                Brushes.Black,
                left + 75,
                y);

            y += 28;

            g.DrawString(
                "Developed by WtexAi Tech",
                subTitleFont,
                Brushes.Black,
                new RectangleF(
                    left,
                    y,
                    width,
                    20),
                center);

            y += 25;

            g.DrawString(
                "ALEESHA CLINIC",
                normalFont,
                Brushes.Black,
                new RectangleF(
                    left,
                    y,
                    width,
                    20),
                center);

            e.HasMorePages = false;
        }
    }
}
