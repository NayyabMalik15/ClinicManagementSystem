namespace ClinicManagementSystem
{
    partial class Product
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
            label8 = new Label();
            ProductName = new TextBox();
            Companyid = new ComboBox();
            Category = new ComboBox();
            Unit = new ComboBox();
            PurchasePrice = new TextBox();
            SalePrice = new TextBox();
            Status = new ComboBox();
            Description = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel1 = new Panel();
            label9 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 78);
            label1.Name = "label1";
            label1.Size = new Size(126, 25);
            label1.TabIndex = 0;
            label1.Text = "Product Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(478, 78);
            label2.Name = "label2";
            label2.Size = new Size(114, 25);
            label2.TabIndex = 1;
            label2.Text = "Company_ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 175);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 2;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(480, 175);
            label4.Name = "label4";
            label4.Size = new Size(44, 25);
            label4.TabIndex = 3;
            label4.Text = "Unit";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(77, 273);
            label5.Name = "label5";
            label5.Size = new Size(124, 25);
            label5.TabIndex = 4;
            label5.Text = "Purchase Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(480, 273);
            label6.Name = "label6";
            label6.Size = new Size(86, 25);
            label6.TabIndex = 5;
            label6.Text = "Sale Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(77, 371);
            label7.Name = "label7";
            label7.Size = new Size(60, 25);
            label7.TabIndex = 6;
            label7.Text = "Status";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(77, 470);
            label8.Name = "label8";
            label8.Size = new Size(102, 25);
            label8.TabIndex = 7;
            label8.Text = "Description";
            // 
            // ProductName
            // 
            ProductName.Location = new Point(77, 106);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(325, 31);
            ProductName.TabIndex = 8;
            // 
            // Companyid
            // 
            Companyid.FormattingEnabled = true;
            Companyid.Location = new Point(480, 106);
            Companyid.Name = "Companyid";
            Companyid.Size = new Size(325, 33);
            Companyid.TabIndex = 9;
            // 
            // Category
            // 
            Category.FormattingEnabled = true;
            Category.Items.AddRange(new object[] { "Tablet", "Syrup", "Injection", "Capsule" });
            Category.Location = new Point(77, 203);
            Category.Name = "Category";
            Category.Size = new Size(325, 33);
            Category.TabIndex = 10;
            // 
            // Unit
            // 
            Unit.FormattingEnabled = true;
            Unit.Items.AddRange(new object[] { "Box", "Strip", "Bottle" });
            Unit.Location = new Point(480, 203);
            Unit.Name = "Unit";
            Unit.Size = new Size(325, 33);
            Unit.TabIndex = 11;
            // 
            // PurchasePrice
            // 
            PurchasePrice.Location = new Point(77, 301);
            PurchasePrice.Name = "PurchasePrice";
            PurchasePrice.Size = new Size(325, 31);
            PurchasePrice.TabIndex = 12;
            // 
            // SalePrice
            // 
            SalePrice.Location = new Point(480, 301);
            SalePrice.Name = "SalePrice";
            SalePrice.Size = new Size(325, 31);
            SalePrice.TabIndex = 13;
            // 
            // Status
            // 
            Status.FormattingEnabled = true;
            Status.Items.AddRange(new object[] { "Active", "Inactive" });
            Status.Location = new Point(77, 399);
            Status.Name = "Status";
            Status.Size = new Size(325, 33);
            Status.TabIndex = 14;
            // 
            // Description
            // 
            Description.Location = new Point(77, 498);
            Description.Name = "Description";
            Description.Size = new Size(725, 64);
            Description.TabIndex = 15;
            Description.Text = "Optional";
            // 
            // button1
            // 
            button1.Location = new Point(77, 644);
            button1.Name = "button1";
            button1.Size = new Size(112, 50);
            button1.TabIndex = 16;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(279, 644);
            button2.Name = "button2";
            button2.Size = new Size(112, 50);
            button2.TabIndex = 17;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(480, 644);
            button3.Name = "button3";
            button3.Size = new Size(112, 50);
            button3.TabIndex = 18;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(690, 644);
            button4.Name = "button4";
            button4.Size = new Size(112, 50);
            button4.TabIndex = 19;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(584, 399);
            button5.Name = "button5";
            button5.Size = new Size(218, 44);
            button5.TabIndex = 20;
            button5.Text = "Import File";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 0, 192);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(-6, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1777, 54);
            panel1.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(18, 17);
            label9.Name = "label9";
            label9.Size = new Size(121, 28);
            label9.TabIndex = 0;
            label9.Text = "PRODUCT";
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1707, 767);
            Controls.Add(panel1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Description);
            Controls.Add(Status);
            Controls.Add(SalePrice);
            Controls.Add(PurchasePrice);
            Controls.Add(Unit);
            Controls.Add(Category);
            Controls.Add(Companyid);
            Controls.Add(ProductName);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Product";
            StartPosition = FormStartPosition.Manual;
            Text = "Product";
            Load += Product_Load;
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
        private Label label8;
        private TextBox ProductName;
        private ComboBox Companyid;
        private ComboBox Category;
        private ComboBox Unit;
        private TextBox PurchasePrice;
        private TextBox SalePrice;
        private ComboBox Status;
        private RichTextBox Description;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Panel panel1;
        private Label label9;
    }
}