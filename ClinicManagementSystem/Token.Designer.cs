namespace ClinicManagementSystem
{
    partial class Token
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            TokenNumber = new TextBox();
            TokenDate = new DateTimePicker();
            Patient = new ComboBox();
            Treatmentid = new ComboBox();
            Status = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1 = new Panel();
            label7 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(479, 235);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(342, 33);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 104);
            label1.Name = "label1";
            label1.Size = new Size(128, 25);
            label1.TabIndex = 1;
            label1.Text = "Token Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(479, 104);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 2;
            label2.Text = "Token Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 207);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 3;
            label3.Text = "Patient_ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(479, 207);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 4;
            label4.Text = "Doctor_ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(93, 319);
            label5.Name = "label5";
            label5.Size = new Size(115, 25);
            label5.TabIndex = 5;
            label5.Text = "Treatment_ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(479, 319);
            label6.Name = "label6";
            label6.Size = new Size(60, 25);
            label6.TabIndex = 6;
            label6.Text = "Status";
            // 
            // TokenNumber
            // 
            TokenNumber.Location = new Point(93, 132);
            TokenNumber.Name = "TokenNumber";
            TokenNumber.Size = new Size(342, 31);
            TokenNumber.TabIndex = 7;
            // 
            // TokenDate
            // 
            TokenDate.Enabled = false;
            TokenDate.Location = new Point(479, 132);
            TokenDate.Name = "TokenDate";
            TokenDate.Size = new Size(342, 31);
            TokenDate.TabIndex = 8;
            // 
            // Patient
            // 
            Patient.FormattingEnabled = true;
            Patient.Location = new Point(93, 235);
            Patient.Name = "Patient";
            Patient.Size = new Size(342, 33);
            Patient.TabIndex = 9;
            // 
            // Treatmentid
            // 
            Treatmentid.FormattingEnabled = true;
            Treatmentid.Location = new Point(93, 347);
            Treatmentid.Name = "Treatmentid";
            Treatmentid.Size = new Size(342, 33);
            Treatmentid.TabIndex = 10;
            // 
            // Status
            // 
            Status.Location = new Point(479, 347);
            Status.Name = "Status";
            Status.Size = new Size(342, 31);
            Status.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(128, 455);
            button1.Name = "button1";
            button1.Size = new Size(112, 52);
            button1.TabIndex = 12;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Location = new Point(314, 455);
            button2.Name = "button2";
            button2.Size = new Size(112, 52);
            button2.TabIndex = 13;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Location = new Point(509, 455);
            button3.Name = "button3";
            button3.Size = new Size(112, 52);
            button3.TabIndex = 14;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Location = new Point(698, 455);
            button4.Name = "button4";
            button4.Size = new Size(112, 52);
            button4.TabIndex = 15;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumOrchid;
            panel1.Controls.Add(label7);
            panel1.Location = new Point(-2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1045, 47);
            panel1.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(8, 7);
            label7.Name = "label7";
            label7.Size = new Size(89, 28);
            label7.TabIndex = 0;
            label7.Text = "TOKEN";
            // 
            // Token
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1030, 617);
            Controls.Add(panel1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Status);
            Controls.Add(Treatmentid);
            Controls.Add(Patient);
            Controls.Add(TokenDate);
            Controls.Add(TokenNumber);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "Token";
            Text = "Token";
            Load += Token_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox TokenNumber;
        private DateTimePicker TokenDate;
        private ComboBox Patient;
        private ComboBox Treatmentid;
        private TextBox Status;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panel1;
        private Label label7;
    }
}