namespace ClinicManagementSystem
{
    partial class Update_Stock
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
            Stockid = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            button1 = new Button();
            label9 = new Label();
            textBox8 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(300, 9);
            label1.Name = "label1";
            label1.Size = new Size(80, 25);
            label1.TabIndex = 0;
            label1.Text = "Stock_ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(441, 96);
            label2.Name = "label2";
            label2.Size = new Size(141, 25);
            label2.TabIndex = 1;
            label2.Text = "Company Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 182);
            label3.Name = "label3";
            label3.Size = new Size(125, 25);
            label3.TabIndex = 2;
            label3.Text = "Batch Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(441, 182);
            label4.Name = "label4";
            label4.Size = new Size(80, 25);
            label4.TabIndex = 3;
            label4.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(97, 264);
            label5.Name = "label5";
            label5.Size = new Size(97, 25);
            label5.TabIndex = 4;
            label5.Text = "Stock Type";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(441, 264);
            label6.Name = "label6";
            label6.Size = new Size(124, 25);
            label6.TabIndex = 5;
            label6.Text = "Purchase Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(97, 355);
            label7.Name = "label7";
            label7.Size = new Size(101, 25);
            label7.TabIndex = 6;
            label7.Text = "Expiry Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(97, 96);
            label8.Name = "label8";
            label8.Size = new Size(126, 25);
            label8.TabIndex = 7;
            label8.Text = "Product Name";
            // 
            // Stockid
            // 
            Stockid.FormattingEnabled = true;
            Stockid.Location = new Point(300, 37);
            Stockid.Name = "Stockid";
            Stockid.Size = new Size(234, 33);
            Stockid.TabIndex = 8;
            Stockid.SelectedIndexChanged += Stockid_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(97, 124);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(293, 31);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(441, 124);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(293, 31);
            textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(97, 210);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(293, 31);
            textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(441, 210);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(293, 31);
            textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(97, 292);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(293, 31);
            textBox5.TabIndex = 13;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(441, 292);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(293, 31);
            textBox6.TabIndex = 14;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(97, 383);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(293, 31);
            textBox7.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(300, 452);
            button1.Name = "button1";
            button1.Size = new Size(112, 50);
            button1.TabIndex = 16;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(441, 355);
            label9.Name = "label9";
            label9.Size = new Size(49, 25);
            label9.TabIndex = 17;
            label9.Text = "Price";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(441, 383);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(293, 31);
            textBox8.TabIndex = 18;
            // 
            // Update_Stock
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 543);
            Controls.Add(textBox8);
            Controls.Add(label9);
            Controls.Add(button1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Stockid);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Update_Stock";
            Text = "Update_Stock";
            Load += Update_Stock_Load;
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
        private ComboBox Stockid;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button button1;
        private Label label9;
        private TextBox textBox8;
    }
}