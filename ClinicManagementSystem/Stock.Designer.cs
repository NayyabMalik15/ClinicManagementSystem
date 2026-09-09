namespace ClinicManagementSystem
{
    partial class Stock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            StockType = new ComboBox();
            PurchaseDate = new DateTimePicker();
            ExpiryDate = new DateTimePicker();
            BatchNumber = new TextBox();
            Quantity = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ProductName = new TextBox();
            CompanyName = new TextBox();
            label8 = new Label();
            Price = new TextBox();
            panel1 = new Panel();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)Quantity).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 91);
            label1.Name = "label1";
            label1.Size = new Size(126, 25);
            label1.TabIndex = 0;
            label1.Text = "Product Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(514, 91);
            label2.Name = "label2";
            label2.Size = new Size(141, 25);
            label2.TabIndex = 1;
            label2.Text = "Company Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 198);
            label3.Name = "label3";
            label3.Size = new Size(125, 25);
            label3.TabIndex = 2;
            label3.Text = "Batch Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(514, 198);
            label4.Name = "label4";
            label4.Size = new Size(80, 25);
            label4.TabIndex = 3;
            label4.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(79, 300);
            label5.Name = "label5";
            label5.Size = new Size(97, 25);
            label5.TabIndex = 4;
            label5.Text = "Stock Type";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(514, 300);
            label6.Name = "label6";
            label6.Size = new Size(124, 25);
            label6.TabIndex = 5;
            label6.Text = "Purchase Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(79, 412);
            label7.Name = "label7";
            label7.Size = new Size(101, 25);
            label7.TabIndex = 6;
            label7.Text = "Expiry Date";
            // 
            // StockType
            // 
            StockType.FormattingEnabled = true;
            StockType.Items.AddRange(new object[] { "IN", "OUT" });
            StockType.Location = new Point(79, 330);
            StockType.Name = "StockType";
            StockType.Size = new Size(369, 33);
            StockType.TabIndex = 9;
            // 
            // PurchaseDate
            // 
            PurchaseDate.Location = new Point(514, 328);
            PurchaseDate.Name = "PurchaseDate";
            PurchaseDate.Size = new Size(369, 31);
            PurchaseDate.TabIndex = 10;
            // 
            // ExpiryDate
            // 
            ExpiryDate.Location = new Point(79, 440);
            ExpiryDate.Name = "ExpiryDate";
            ExpiryDate.Size = new Size(369, 31);
            ExpiryDate.TabIndex = 11;
            // 
            // BatchNumber
            // 
            BatchNumber.Location = new Point(79, 226);
            BatchNumber.Name = "BatchNumber";
            BatchNumber.Size = new Size(369, 31);
            BatchNumber.TabIndex = 12;
            // 
            // Quantity
            // 
            Quantity.Location = new Point(514, 226);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(369, 31);
            Quantity.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(79, 518);
            button1.Name = "button1";
            button1.Size = new Size(112, 51);
            button1.TabIndex = 14;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(305, 518);
            button2.Name = "button2";
            button2.Size = new Size(112, 51);
            button2.TabIndex = 15;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(535, 518);
            button3.Name = "button3";
            button3.Size = new Size(112, 51);
            button3.TabIndex = 16;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(771, 518);
            button4.Name = "button4";
            button4.Size = new Size(112, 51);
            button4.TabIndex = 17;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(376, 613);
            button5.Name = "button5";
            button5.Size = new Size(162, 41);
            button5.TabIndex = 18;
            button5.Text = "Import Excel File";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // ProductName
            // 
            ProductName.Location = new Point(79, 119);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(369, 31);
            ProductName.TabIndex = 19;
            // 
            // CompanyName
            // 
            CompanyName.Location = new Point(514, 119);
            CompanyName.Name = "CompanyName";
            CompanyName.Size = new Size(369, 31);
            CompanyName.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(514, 412);
            label8.Name = "label8";
            label8.Size = new Size(49, 25);
            label8.TabIndex = 21;
            label8.Text = "Price";
            // 
            // Price
            // 
            Price.Location = new Point(514, 440);
            Price.Name = "Price";
            Price.Size = new Size(369, 31);
            Price.TabIndex = 22;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateBlue;
            panel1.Controls.Add(label9);
            panel1.Location = new Point(-10, -9);
            panel1.Name = "panel1";
            panel1.Size = new Size(1829, 61);
            panel1.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(22, 27);
            label9.Name = "label9";
            label9.Size = new Size(85, 28);
            label9.TabIndex = 0;
            label9.Text = "STOCK";
            // 
            // Stock
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1816, 692);
            Controls.Add(panel1);
            Controls.Add(Price);
            Controls.Add(label8);
            Controls.Add(CompanyName);
            Controls.Add(ProductName);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Quantity);
            Controls.Add(BatchNumber);
            Controls.Add(ExpiryDate);
            Controls.Add(PurchaseDate);
            Controls.Add(StockType);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Stock";
            StartPosition = FormStartPosition.Manual;
            Text = "Stock";
            ((System.ComponentModel.ISupportInitialize)Quantity).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox StockType;
        private DateTimePicker PurchaseDate;
        private DateTimePicker ExpiryDate;
        private TextBox BatchNumber;
        private NumericUpDown Quantity;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox ProductName;
        private TextBox CompanyName;
        private Label label8;
        private TextBox Price;
        private Panel panel1;
        private Label label9;
    }
}