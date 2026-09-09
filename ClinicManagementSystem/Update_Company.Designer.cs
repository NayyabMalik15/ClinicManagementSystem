namespace ClinicManagementSystem
{
    partial class Update_Company
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
            Companyid = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            SuspendLayout();
            // 
            // Companyid
            // 
            Companyid.FormattingEnabled = true;
            Companyid.Location = new Point(252, 61);
            Companyid.Name = "Companyid";
            Companyid.Size = new Size(203, 33);
            Companyid.TabIndex = 0;
            Companyid.SelectedIndexChanged += Companyid_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(252, 33);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 1;
            label1.Text = "Company_ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 130);
            label2.Name = "label2";
            label2.Size = new Size(141, 25);
            label2.TabIndex = 2;
            label2.Text = "Company Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(418, 130);
            label3.Name = "label3";
            label3.Size = new Size(131, 25);
            label3.TabIndex = 3;
            label3.Text = "Contact Person";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(76, 213);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 4;
            label4.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(418, 213);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 5;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(76, 303);
            label6.Name = "label6";
            label6.Size = new Size(42, 25);
            label6.TabIndex = 6;
            label6.Text = "City";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(418, 303);
            label7.Name = "label7";
            label7.Size = new Size(60, 25);
            label7.TabIndex = 7;
            label7.Text = "Status";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(76, 389);
            label8.Name = "label8";
            label8.Size = new Size(77, 25);
            label8.TabIndex = 8;
            label8.Text = "Address";
            // 
            // button1
            // 
            button1.Location = new Point(307, 475);
            button1.Name = "button1";
            button1.Size = new Size(112, 50);
            button1.TabIndex = 9;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(76, 158);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(261, 31);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(418, 158);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(253, 31);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(76, 241);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(261, 31);
            textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(418, 241);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(253, 31);
            textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(76, 331);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(261, 31);
            textBox5.TabIndex = 14;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(418, 331);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(253, 31);
            textBox6.TabIndex = 15;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(76, 417);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(261, 31);
            textBox7.TabIndex = 16;
            // 
            // Update_Company
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 606);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Companyid);
            Name = "Update_Company";
            Text = "Update_Company";
            Load += Update_Company_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Companyid;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
    }
}