namespace ClinicManagementSystem
{
    partial class Patient
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            FirstName = new TextBox();
            LastName = new TextBox();
            PhoneNumber = new TextBox();
            Gender = new ComboBox();
            Address = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            DOB = new DateTimePicker();
            label1 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 69);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 1;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(515, 69);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 2;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(94, 249);
            label4.Name = "label4";
            label4.Size = new Size(132, 25);
            label4.TabIndex = 3;
            label4.Text = "Phone Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(94, 160);
            label5.Name = "label5";
            label5.Size = new Size(69, 25);
            label5.TabIndex = 4;
            label5.Text = "Gender";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(94, 326);
            label6.Name = "label6";
            label6.Size = new Size(77, 25);
            label6.TabIndex = 5;
            label6.Text = "Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(515, 160);
            label7.Name = "label7";
            label7.Size = new Size(112, 25);
            label7.TabIndex = 6;
            label7.Text = "Date of Birth";
            // 
            // FirstName
            // 
            FirstName.Location = new Point(94, 100);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(343, 31);
            FirstName.TabIndex = 8;
            // 
            // LastName
            // 
            LastName.Location = new Point(515, 100);
            LastName.Name = "LastName";
            LastName.Size = new Size(343, 31);
            LastName.TabIndex = 9;
            // 
            // PhoneNumber
            // 
            PhoneNumber.Location = new Point(94, 277);
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.PlaceholderText = "Enter Numeric value only ";
            PhoneNumber.Size = new Size(343, 31);
            PhoneNumber.TabIndex = 11;
            // 
            // Gender
            // 
            Gender.FormattingEnabled = true;
            Gender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            Gender.Location = new Point(94, 188);
            Gender.Name = "Gender";
            Gender.Size = new Size(343, 33);
            Gender.TabIndex = 12;
            // 
            // Address
            // 
            Address.Location = new Point(94, 354);
            Address.Name = "Address";
            Address.Size = new Size(764, 64);
            Address.TabIndex = 13;
            Address.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(143, 457);
            button1.Name = "button1";
            button1.Size = new Size(112, 59);
            button1.TabIndex = 14;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(342, 457);
            button2.Name = "button2";
            button2.Size = new Size(112, 59);
            button2.TabIndex = 15;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(530, 457);
            button3.Name = "button3";
            button3.Size = new Size(112, 59);
            button3.TabIndex = 16;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(724, 457);
            button4.Name = "button4";
            button4.Size = new Size(112, 59);
            button4.TabIndex = 17;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // DOB
            // 
            DOB.Location = new Point(515, 186);
            DOB.Name = "DOB";
            DOB.Size = new Size(343, 31);
            DOB.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(14, 11);
            label1.Name = "label1";
            label1.Size = new Size(107, 28);
            label1.TabIndex = 19;
            label1.Text = "PATIENT";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1797, 52);
            panel1.TabIndex = 20;
            // 
            // Patient
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1616, 747);
            Controls.Add(panel1);
            Controls.Add(DOB);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Address);
            Controls.Add(Gender);
            Controls.Add(PhoneNumber);
            Controls.Add(LastName);
            Controls.Add(FirstName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Patient";
            StartPosition = FormStartPosition.Manual;
            Text = " Patient";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox FirstName;
        private TextBox LastName;
        private TextBox PhoneNumber;
        private ComboBox Gender;
        private RichTextBox Address;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DateTimePicker DOB;
        private Label label1;
        private Panel panel1;
    }
}
