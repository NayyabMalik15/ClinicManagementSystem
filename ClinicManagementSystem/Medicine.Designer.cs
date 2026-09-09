namespace ClinicManagementSystem
{
    partial class Medicine
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
            Tokenid = new ComboBox();
            Patientid = new ComboBox();
            Doctorid = new ComboBox();
            MedicineDetail = new RichTextBox();
            ExpiryDate = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 37);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 0;
            label1.Text = "Token_ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(409, 37);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 1;
            label2.Text = "Expiry Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 129);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 2;
            label3.Text = "Patient_ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(409, 129);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 3;
            label4.Text = "Doctor_ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 223);
            label5.Name = "label5";
            label5.Size = new Size(133, 25);
            label5.TabIndex = 4;
            label5.Text = "Medicine Detail";
            // 
            // Tokenid
            // 
            Tokenid.FormattingEnabled = true;
            Tokenid.Location = new Point(42, 65);
            Tokenid.Name = "Tokenid";
            Tokenid.Size = new Size(322, 33);
            Tokenid.TabIndex = 5;
            // 
            // Patientid
            // 
            Patientid.FormattingEnabled = true;
            Patientid.Location = new Point(42, 157);
            Patientid.Name = "Patientid";
            Patientid.Size = new Size(322, 33);
            Patientid.TabIndex = 6;
            // 
            // Doctorid
            // 
            Doctorid.FormattingEnabled = true;
            Doctorid.Location = new Point(409, 157);
            Doctorid.Name = "Doctorid";
            Doctorid.Size = new Size(300, 33);
            Doctorid.TabIndex = 7;
            // 
            // MedicineDetail
            // 
            MedicineDetail.Location = new Point(42, 251);
            MedicineDetail.Name = "MedicineDetail";
            MedicineDetail.Size = new Size(666, 69);
            MedicineDetail.TabIndex = 9;
            MedicineDetail.Text = "";
            // 
            // ExpiryDate
            // 
            ExpiryDate.Location = new Point(409, 67);
            ExpiryDate.Name = "ExpiryDate";
            ExpiryDate.Size = new Size(300, 31);
            ExpiryDate.TabIndex = 10;
            ExpiryDate.Value = new DateTime(2027, 4, 30, 0, 0, 0, 0);
            // 
            // button1
            // 
            button1.Location = new Point(42, 356);
            button1.Name = "button1";
            button1.Size = new Size(112, 54);
            button1.TabIndex = 11;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(220, 356);
            button2.Name = "button2";
            button2.Size = new Size(112, 54);
            button2.TabIndex = 12;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(409, 356);
            button3.Name = "button3";
            button3.Size = new Size(112, 54);
            button3.TabIndex = 13;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(596, 356);
            button4.Name = "button4";
            button4.Size = new Size(112, 54);
            button4.TabIndex = 14;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Medicine
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(ExpiryDate);
            Controls.Add(MedicineDetail);
            Controls.Add(Doctorid);
            Controls.Add(Patientid);
            Controls.Add(Tokenid);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Medicine";
            Text = "Medicine";
            Load += Medicine_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox Tokenid;
        private ComboBox Patientid;
        private ComboBox Doctorid;
        private RichTextBox MedicineDetail;
        private DateTimePicker ExpiryDate;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}