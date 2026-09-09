namespace ClinicManagementSystem
{
    partial class Update_Doctor
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
            Doctorid = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // Doctorid
            // 
            Doctorid.FormattingEnabled = true;
            Doctorid.Location = new Point(256, 40);
            Doctorid.Name = "Doctorid";
            Doctorid.Size = new Size(202, 33);
            Doctorid.TabIndex = 0;
            Doctorid.SelectedIndexChanged += Doctorid_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(50, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 31);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(439, 104);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(260, 31);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(50, 204);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(260, 31);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(439, 204);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(260, 31);
            textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(50, 307);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(260, 31);
            textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(439, 307);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(260, 31);
            textBox6.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 76);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 7;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(439, 76);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 8;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 176);
            label3.Name = "label3";
            label3.Size = new Size(110, 25);
            label3.TabIndex = 9;
            label3.Text = "Specializtion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(439, 176);
            label4.Name = "label4";
            label4.Size = new Size(132, 25);
            label4.TabIndex = 10;
            label4.Text = "Phone Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 279);
            label5.Name = "label5";
            label5.Size = new Size(144, 25);
            label5.TabIndex = 11;
            label5.Text = "Consultation Fee";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(439, 279);
            label6.Name = "label6";
            label6.Size = new Size(142, 25);
            label6.TabIndex = 12;
            label6.Text = "Available Timing";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(256, 9);
            label7.Name = "label7";
            label7.Size = new Size(92, 25);
            label7.TabIndex = 13;
            label7.Text = "Doctor_ID";
            // 
            // button1
            // 
            button1.Location = new Point(311, 406);
            button1.Name = "button1";
            button1.Size = new Size(117, 53);
            button1.TabIndex = 14;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Update_Doctor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 505);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Doctorid);
            Name = "Update_Doctor";
            Text = "Update_Doctor";
            Load += Update_Doctor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Doctorid;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
    }
}