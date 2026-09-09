namespace ClinicManagementSystem
{
    partial class Company
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
            CompanyName = new TextBox();
            ContactPerson = new TextBox();
            Phone = new TextBox();
            Email = new TextBox();
            City = new TextBox();
            Status = new ComboBox();
            Address = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1 = new Panel();
            label8 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 74);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 0;
            label1.Text = "Company Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(471, 74);
            label2.Name = "label2";
            label2.Size = new Size(131, 25);
            label2.TabIndex = 1;
            label2.Text = "Contact Person";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 159);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 2;
            label3.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(471, 159);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(93, 254);
            label5.Name = "label5";
            label5.Size = new Size(42, 25);
            label5.TabIndex = 4;
            label5.Text = "City";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(471, 254);
            label6.Name = "label6";
            label6.Size = new Size(60, 25);
            label6.TabIndex = 5;
            label6.Text = "Status";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(93, 348);
            label7.Name = "label7";
            label7.Size = new Size(77, 25);
            label7.TabIndex = 6;
            label7.Text = "Address";
            // 
            // CompanyName
            // 
            CompanyName.Location = new Point(93, 102);
            CompanyName.Name = "CompanyName";
            CompanyName.Size = new Size(318, 31);
            CompanyName.TabIndex = 7;
            // 
            // ContactPerson
            // 
            ContactPerson.Location = new Point(471, 102);
            ContactPerson.Name = "ContactPerson";
            ContactPerson.Size = new Size(318, 31);
            ContactPerson.TabIndex = 8;
            // 
            // Phone
            // 
            Phone.Location = new Point(93, 187);
            Phone.Name = "Phone";
            Phone.Size = new Size(318, 31);
            Phone.TabIndex = 9;
            // 
            // Email
            // 
            Email.Location = new Point(471, 187);
            Email.Name = "Email";
            Email.Size = new Size(318, 31);
            Email.TabIndex = 10;
            // 
            // City
            // 
            City.Location = new Point(93, 282);
            City.Name = "City";
            City.Size = new Size(318, 31);
            City.TabIndex = 11;
            // 
            // Status
            // 
            Status.FormattingEnabled = true;
            Status.Items.AddRange(new object[] { "Active", "Inactive" });
            Status.Location = new Point(471, 282);
            Status.Name = "Status";
            Status.Size = new Size(318, 33);
            Status.TabIndex = 12;
            // 
            // Address
            // 
            Address.Location = new Point(93, 376);
            Address.Name = "Address";
            Address.Size = new Size(696, 79);
            Address.TabIndex = 13;
            Address.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(93, 509);
            button1.Name = "button1";
            button1.Size = new Size(112, 57);
            button1.TabIndex = 14;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(289, 509);
            button2.Name = "button2";
            button2.Size = new Size(112, 57);
            button2.TabIndex = 15;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(480, 509);
            button3.Name = "button3";
            button3.Size = new Size(112, 57);
            button3.TabIndex = 16;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(677, 509);
            button4.Name = "button4";
            button4.Size = new Size(112, 57);
            button4.TabIndex = 17;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orchid;
            panel1.Controls.Add(label8);
            panel1.Location = new Point(0, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1829, 53);
            panel1.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(12, 13);
            label8.Name = "label8";
            label8.Size = new Size(123, 28);
            label8.TabIndex = 0;
            label8.Text = "COMPANY";
            // 
            // Company
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1627, 695);
            Controls.Add(panel1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Address);
            Controls.Add(Status);
            Controls.Add(City);
            Controls.Add(Email);
            Controls.Add(Phone);
            Controls.Add(ContactPerson);
            Controls.Add(CompanyName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Company";
            StartPosition = FormStartPosition.Manual;
            Text = "Company";
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
        private TextBox CompanyName;
        private TextBox ContactPerson;
        private TextBox Phone;
        private TextBox Email;
        private TextBox City;
        private ComboBox Status;
        private RichTextBox Address;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panel1;
        private Label label8;
    }
}