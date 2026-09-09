namespace ClinicManagementSystem
{
    partial class Token1
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
            Token = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox2 = new GroupBox();
            button8 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            groupBox3 = new GroupBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            groupBox4 = new GroupBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            TokenDate = new DateTimePicker();
            comboBox1 = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            button1 = new Button();
            groupBox5 = new GroupBox();
            dataGridView1 = new DataGridView();
            TokenNumber = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            PatientName = new DataGridViewTextBoxColumn();
            PhonrNumber = new DataGridViewTextBoxColumn();
            DoctorName = new DataGridViewTextBoxColumn();
            Fee = new DataGridViewTextBoxColumn();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            Token.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Token
            // 
            Token.BackColor = Color.MediumPurple;
            Token.Controls.Add(label1);
            Token.ForeColor = SystemColors.ButtonHighlight;
            Token.Location = new Point(-55, -2);
            Token.Name = "Token";
            Token.Size = new Size(1727, 45);
            Token.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(56, 11);
            label1.Name = "label1";
            label1.Size = new Size(89, 28);
            label1.TabIndex = 0;
            label1.Text = "TOKEN";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(25, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 113);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Patient Type";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(26, 65);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(130, 29);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "New Patient";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(26, 30);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(124, 29);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Old Patient";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button8);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(348, 59);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(889, 113);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Search Old Patient (By Phone Number)";
            // 
            // button8
            // 
            button8.Location = new Point(601, 27);
            button8.Name = "button8";
            button8.Size = new Size(112, 31);
            button8.TabIndex = 3;
            button8.Text = "Search";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(22, 65);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(691, 31);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(160, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(405, 31);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 30);
            label2.Name = "label2";
            label2.Size = new Size(132, 25);
            label2.TabIndex = 0;
            label2.Text = "Phone Number";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(25, 190);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1212, 94);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "New Patient Information";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(678, 42);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(362, 31);
            textBox4.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(149, 42);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(363, 31);
            textBox3.TabIndex = 2;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(540, 42);
            label4.Name = "label4";
            label4.Size = new Size(132, 25);
            label4.TabIndex = 1;
            label4.Text = "Phone Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 42);
            label3.Name = "label3";
            label3.Size = new Size(117, 25);
            label3.TabIndex = 0;
            label3.Text = "Patient Name";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBox7);
            groupBox4.Controls.Add(textBox6);
            groupBox4.Controls.Add(textBox5);
            groupBox4.Controls.Add(TokenDate);
            groupBox4.Controls.Add(comboBox1);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(label5);
            groupBox4.Location = new Point(25, 299);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1212, 260);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Token Details";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(164, 223);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(300, 31);
            textBox7.TabIndex = 9;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(164, 42);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(300, 31);
            textBox6.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(164, 131);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(390, 31);
            textBox5.TabIndex = 7;
            // 
            // TokenDate
            // 
            TokenDate.Enabled = false;
            TokenDate.Location = new Point(164, 86);
            TokenDate.Name = "TokenDate";
            TokenDate.Size = new Size(300, 31);
            TokenDate.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(164, 176);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(390, 33);
            comboBox1.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 220);
            label9.Name = "label9";
            label9.Size = new Size(39, 25);
            label9.TabIndex = 4;
            label9.Text = "Fee";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 176);
            label8.Name = "label8";
            label8.Size = new Size(119, 25);
            label8.TabIndex = 3;
            label8.Text = "Doctor Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 131);
            label7.Name = "label7";
            label7.Size = new Size(117, 25);
            label7.TabIndex = 2;
            label7.Text = "Patient Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 86);
            label6.Name = "label6";
            label6.Size = new Size(100, 25);
            label6.TabIndex = 1;
            label6.Text = "Token Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 42);
            label5.Name = "label5";
            label5.Size = new Size(128, 25);
            label5.TabIndex = 0;
            label5.Text = "Token Number";
            // 
            // button1
            // 
            button1.Location = new Point(540, 565);
            button1.Name = "button1";
            button1.Size = new Size(157, 40);
            button1.TabIndex = 5;
            button1.Text = "Issue Token";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dataGridView1);
            groupBox5.Location = new Point(25, 611);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(1212, 120);
            groupBox5.TabIndex = 6;
            groupBox5.TabStop = false;
            groupBox5.Text = "Today's Token";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { TokenNumber, Date, PatientName, PhonrNumber, DoctorName, Fee });
            dataGridView1.Location = new Point(42, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1124, 82);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // TokenNumber
            // 
            TokenNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            TokenNumber.HeaderText = "Token No";
            TokenNumber.MinimumWidth = 8;
            TokenNumber.Name = "TokenNumber";
            TokenNumber.Width = 150;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.MinimumWidth = 8;
            Date.Name = "Date";
            Date.Width = 170;
            // 
            // PatientName
            // 
            PatientName.HeaderText = "Patient Name";
            PatientName.MinimumWidth = 8;
            PatientName.Name = "PatientName";
            PatientName.Width = 200;
            // 
            // PhonrNumber
            // 
            PhonrNumber.HeaderText = "Phone Number";
            PhonrNumber.MinimumWidth = 8;
            PhonrNumber.Name = "PhonrNumber";
            PhonrNumber.Width = 190;
            // 
            // DoctorName
            // 
            DoctorName.HeaderText = "Doctor Name";
            DoctorName.MinimumWidth = 8;
            DoctorName.Name = "DoctorName";
            DoctorName.Width = 200;
            // 
            // Fee
            // 
            Fee.HeaderText = "Fee";
            Fee.MinimumWidth = 8;
            Fee.Name = "Fee";
            Fee.Width = 150;
            // 
            // button2
            // 
            button2.Location = new Point(114, 743);
            button2.Name = "button2";
            button2.Size = new Size(112, 46);
            button2.TabIndex = 7;
            button2.Text = "New";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(289, 743);
            button3.Name = "button3";
            button3.Size = new Size(112, 46);
            button3.TabIndex = 8;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(467, 743);
            button4.Name = "button4";
            button4.Size = new Size(112, 46);
            button4.TabIndex = 9;
            button4.Text = "Update";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(646, 743);
            button5.Name = "button5";
            button5.Size = new Size(112, 46);
            button5.TabIndex = 10;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(825, 743);
            button6.Name = "button6";
            button6.Size = new Size(112, 46);
            button6.TabIndex = 11;
            button6.Text = "Clear";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(1004, 743);
            button7.Name = "button7";
            button7.Size = new Size(112, 46);
            button7.TabIndex = 12;
            button7.Text = "Exit";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Token1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1286, 823);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(groupBox5);
            Controls.Add(button1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(Token);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Token1";
            StartPosition = FormStartPosition.Manual;
            Text = "Token1";
            Load += Token1_Load;
            Token.ResumeLayout(false);
            Token.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel Token;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button button1;
        private GroupBox groupBox5;
        private Button button2;
        private Button button3;
        private Label label1;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button8;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label4;
        private Label label3;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private DataGridView dataGridView1;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private DateTimePicker TokenDate;
        private ComboBox comboBox1;
        private DataGridViewTextBoxColumn TokenNumber;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn PatientName;
        private DataGridViewTextBoxColumn PhonrNumber;
        private DataGridViewTextBoxColumn DoctorName;
        private DataGridViewTextBoxColumn Fee;
    }
}