namespace ClinicManagementSystem
{
    partial class Bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Tokenid = new ComboBox();
            Patientid = new ComboBox();
            DoctorFee = new TextBox();
            TreatmentCost = new TextBox();
            TotalAmount = new TextBox();
            BillStatus = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label7 = new Label();
            BillDate = new DateTimePicker();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            Price = new TextBox();
            Quantity = new NumericUpDown();
            BillDataGridView = new DataGridView();
            Token_ID = new DataGridViewTextBoxColumn();
            Patien_Name = new DataGridViewTextBoxColumn();
            Prdct = new DataGridViewTextBoxColumn();
            Pp = new DataGridViewTextBoxColumn();
            Qty = new DataGridViewTextBoxColumn();
            DF = new DataGridViewTextBoxColumn();
            TC = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            BillD = new DataGridViewTextBoxColumn();
            BS = new DataGridViewTextBoxColumn();
            Product = new TextBox();
            ProductComboBox = new ComboBox();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            button5 = new Button();
            panel1 = new Panel();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)Quantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BillDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 55);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 0;
            label1.Text = "Token_ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(382, 55);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 1;
            label2.Text = "Patient_Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(382, 223);
            label3.Name = "label3";
            label3.Size = new Size(99, 25);
            label3.TabIndex = 2;
            label3.Text = "Doctor Fee";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 312);
            label4.Name = "label4";
            label4.Size = new Size(131, 25);
            label4.TabIndex = 3;
            label4.Text = "Treatment Cost";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(382, 312);
            label5.Name = "label5";
            label5.Size = new Size(119, 25);
            label5.TabIndex = 4;
            label5.Text = "Total Amount";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(382, 398);
            label6.Name = "label6";
            label6.Size = new Size(87, 25);
            label6.TabIndex = 5;
            label6.Text = "Bill Status";
            // 
            // Tokenid
            // 
            Tokenid.FormattingEnabled = true;
            Tokenid.Location = new Point(36, 83);
            Tokenid.Name = "Tokenid";
            Tokenid.Size = new Size(308, 33);
            Tokenid.TabIndex = 6;
            Tokenid.SelectedIndexChanged += Tokenid_SelectedIndexChanged;
            // 
            // Patientid
            // 
            Patientid.FormattingEnabled = true;
            Patientid.Location = new Point(382, 83);
            Patientid.Name = "Patientid";
            Patientid.Size = new Size(308, 33);
            Patientid.TabIndex = 7;
            // 
            // DoctorFee
            // 
            DoctorFee.Location = new Point(382, 251);
            DoctorFee.Name = "DoctorFee";
            DoctorFee.Size = new Size(308, 31);
            DoctorFee.TabIndex = 8;
            DoctorFee.TextChanged += DoctorFee_TextChanged;
            // 
            // TreatmentCost
            // 
            TreatmentCost.Location = new Point(36, 340);
            TreatmentCost.Name = "TreatmentCost";
            TreatmentCost.Size = new Size(308, 31);
            TreatmentCost.TabIndex = 9;
            TreatmentCost.TextChanged += TreatmentCost_TextChanged;
            // 
            // TotalAmount
            // 
            TotalAmount.Location = new Point(382, 340);
            TotalAmount.Name = "TotalAmount";
            TotalAmount.Size = new Size(308, 31);
            TotalAmount.TabIndex = 10;
            // 
            // BillStatus
            // 
            BillStatus.Location = new Point(382, 426);
            BillStatus.Name = "BillStatus";
            BillStatus.Size = new Size(308, 31);
            BillStatus.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(755, 103);
            button1.Name = "button1";
            button1.Size = new Size(112, 54);
            button1.TabIndex = 12;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(755, 194);
            button2.Name = "button2";
            button2.Size = new Size(112, 54);
            button2.TabIndex = 13;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(755, 283);
            button3.Name = "button3";
            button3.Size = new Size(112, 54);
            button3.TabIndex = 14;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(755, 383);
            button4.Name = "button4";
            button4.Size = new Size(112, 54);
            button4.TabIndex = 15;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 398);
            label7.Name = "label7";
            label7.Size = new Size(76, 25);
            label7.TabIndex = 16;
            label7.Text = "Bill Date";
            // 
            // BillDate
            // 
            BillDate.Enabled = false;
            BillDate.Location = new Point(36, 426);
            BillDate.Name = "BillDate";
            BillDate.Size = new Size(308, 31);
            BillDate.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(36, 132);
            label8.Name = "label8";
            label8.Size = new Size(74, 25);
            label8.TabIndex = 18;
            label8.Text = "Product";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(382, 132);
            label9.Name = "label9";
            label9.Size = new Size(49, 25);
            label9.TabIndex = 19;
            label9.Text = "Price";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(36, 223);
            label10.Name = "label10";
            label10.Size = new Size(80, 25);
            label10.TabIndex = 20;
            label10.Text = "Quantity";
            // 
            // Price
            // 
            Price.Location = new Point(382, 160);
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Size = new Size(308, 31);
            Price.TabIndex = 22;
            Price.TextChanged += Price_TextChanged;
            // 
            // Quantity
            // 
            Quantity.Location = new Point(36, 251);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(308, 31);
            Quantity.TabIndex = 23;
            Quantity.ValueChanged += Quantity_ValueChanged;
            // 
            // BillDataGridView
            // 
            BillDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BillDataGridView.Columns.AddRange(new DataGridViewColumn[] { Token_ID, Patien_Name, Prdct, Pp, Qty, DF, TC, Total, BillD, BS });
            BillDataGridView.Location = new Point(4, 500);
            BillDataGridView.Name = "BillDataGridView";
            BillDataGridView.RowHeadersWidth = 62;
            BillDataGridView.Size = new Size(1002, 185);
            BillDataGridView.TabIndex = 24;
            BillDataGridView.CellContentClick += BillDataGridView_CellContentClick;
            // 
            // Token_ID
            // 
            Token_ID.HeaderText = "Token_ID";
            Token_ID.MinimumWidth = 8;
            Token_ID.Name = "Token_ID";
            Token_ID.Width = 80;
            // 
            // Patien_Name
            // 
            Patien_Name.HeaderText = "Patient_Name";
            Patien_Name.MinimumWidth = 8;
            Patien_Name.Name = "Patien_Name";
            Patien_Name.Width = 120;
            // 
            // Prdct
            // 
            Prdct.HeaderText = "Product";
            Prdct.MinimumWidth = 8;
            Prdct.Name = "Prdct";
            Prdct.Width = 80;
            // 
            // Pp
            // 
            Pp.HeaderText = "Price";
            Pp.MinimumWidth = 8;
            Pp.Name = "Pp";
            Pp.Width = 60;
            // 
            // Qty
            // 
            Qty.HeaderText = "Quantity";
            Qty.MinimumWidth = 8;
            Qty.Name = "Qty";
            Qty.Width = 80;
            // 
            // DF
            // 
            DF.HeaderText = "Doctor_Fee";
            DF.MinimumWidth = 8;
            DF.Name = "DF";
            DF.Width = 110;
            // 
            // TC
            // 
            TC.HeaderText = "TreatmentCost";
            TC.MinimumWidth = 8;
            TC.Name = "TC";
            TC.Width = 125;
            // 
            // Total
            // 
            Total.HeaderText = "TotalAmount";
            Total.MinimumWidth = 8;
            Total.Name = "Total";
            Total.Width = 115;
            // 
            // BillD
            // 
            BillD.HeaderText = "Bill_Date";
            BillD.MinimumWidth = 8;
            BillD.Name = "BillD";
            BillD.Width = 80;
            // 
            // BS
            // 
            BS.HeaderText = "Bill_Status";
            BS.MinimumWidth = 8;
            BS.Name = "BS";
            BS.Width = 90;
            // 
            // Product
            // 
            Product.Location = new Point(36, 160);
            Product.Name = "Product";
            Product.Size = new Size(308, 31);
            Product.TabIndex = 25;
            Product.Visible = false;
            Product.TextChanged += Product_TextChanged;
            // 
            // ProductComboBox
            // 
            ProductComboBox.FormattingEnabled = true;
            ProductComboBox.Location = new Point(36, 158);
            ProductComboBox.Name = "ProductComboBox";
            ProductComboBox.Size = new Size(308, 33);
            ProductComboBox.TabIndex = 26;
            ProductComboBox.SelectedIndexChanged += ProductComboBox_SelectedIndexChanged;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // button5
            // 
            button5.Location = new Point(894, 460);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 27;
            button5.Text = "Print";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumPurple;
            panel1.Controls.Add(label11);
            panel1.Location = new Point(-9, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1795, 52);
            panel1.TabIndex = 28;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.MediumPurple;
            label11.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(21, 7);
            label11.Name = "label11";
            label11.Size = new Size(62, 28);
            label11.TabIndex = 0;
            label11.Text = "BILL";
            // 
            // Bill
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1698, 720);
            Controls.Add(panel1);
            Controls.Add(button5);
            Controls.Add(ProductComboBox);
            Controls.Add(Product);
            Controls.Add(BillDataGridView);
            Controls.Add(Quantity);
            Controls.Add(Price);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(TotalAmount);
            Controls.Add(BillDate);
            Controls.Add(label7);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(BillStatus);
            Controls.Add(TreatmentCost);
            Controls.Add(DoctorFee);
            Controls.Add(Patientid);
            Controls.Add(Tokenid);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Bill";
            StartPosition = FormStartPosition.Manual;
            Text = "    ";
            Load += Bill_Load;
            ((System.ComponentModel.ISupportInitialize)Quantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)BillDataGridView).EndInit();
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
        private ComboBox Tokenid;
        private ComboBox Patientid;
        private TextBox DoctorFee;
        private TextBox TreatmentCost;
        private TextBox TotalAmount;
        private TextBox BillStatus;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label7;
        private DateTimePicker BillDate;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox Price;
        private NumericUpDown Quantity;
        private DataGridView BillDataGridView;
        private TextBox Product;
        private ComboBox ProductComboBox;
        private DataGridViewTextBoxColumn Token_ID;
        private DataGridViewTextBoxColumn Patien_Name;
        private DataGridViewTextBoxColumn Prdct;
        private DataGridViewTextBoxColumn Pp;
        private DataGridViewTextBoxColumn Qty;
        private DataGridViewTextBoxColumn DF;
        private DataGridViewTextBoxColumn TC;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn BillD;
        private DataGridViewTextBoxColumn BS;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Button button5;
        private Panel panel1;
        private Label label11;
    }
}