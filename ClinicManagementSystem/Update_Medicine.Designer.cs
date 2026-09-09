namespace ClinicManagementSystem
{
    partial class Update_Medicine
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
            Prescriptionid = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // Prescriptionid
            // 
            Prescriptionid.FormattingEnabled = true;
            Prescriptionid.Location = new Point(271, 58);
            Prescriptionid.Name = "Prescriptionid";
            Prescriptionid.Size = new Size(182, 33);
            Prescriptionid.TabIndex = 0;
            Prescriptionid.SelectedIndexChanged += Prescriptionid_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(271, 30);
            label1.Name = "label1";
            label1.Size = new Size(130, 25);
            label1.TabIndex = 1;
            label1.Text = "Prescription_ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 128);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 2;
            label2.Text = "Token_ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(418, 128);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 3;
            label3.Text = "Expiry Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 237);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 4;
            label4.Text = "Patient_ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(418, 237);
            label5.Name = "label5";
            label5.Size = new Size(92, 25);
            label5.TabIndex = 5;
            label5.Text = "Doctor_ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(88, 342);
            label6.Name = "label6";
            label6.Size = new Size(133, 25);
            label6.TabIndex = 6;
            label6.Text = "Medicine Detail";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(88, 156);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(278, 31);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(418, 156);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(274, 31);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(88, 265);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(278, 31);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(418, 265);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(274, 31);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(88, 370);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(278, 31);
            textBox5.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(309, 450);
            button1.Name = "button1";
            button1.Size = new Size(112, 49);
            button1.TabIndex = 12;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Update_Medicine
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 511);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Prescriptionid);
            Name = "Update_Medicine";
            Text = "Update_Medicine";
            Load += Update_Medicine_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Prescriptionid;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
    }
}