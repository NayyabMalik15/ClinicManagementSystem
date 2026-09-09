namespace ClinicManagementSystem
{
    partial class Update_Treatment
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
            Treatmentid = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // Treatmentid
            // 
            Treatmentid.FormattingEnabled = true;
            Treatmentid.Location = new Point(270, 51);
            Treatmentid.Name = "Treatmentid";
            Treatmentid.Size = new Size(230, 33);
            Treatmentid.TabIndex = 0;
            Treatmentid.SelectedIndexChanged += Treatmentid_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(270, 23);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 1;
            label1.Text = "Treatment_ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 145);
            label2.Name = "label2";
            label2.Size = new Size(142, 25);
            label2.TabIndex = 2;
            label2.Text = "Treatment Nmae";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(419, 145);
            label3.Name = "label3";
            label3.Size = new Size(133, 25);
            label3.TabIndex = 3;
            label3.Text = "Stanadard Cost";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 265);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 4;
            label4.Text = "Description";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(86, 173);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(272, 31);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(419, 173);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(259, 31);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(86, 293);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(272, 31);
            textBox3.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(293, 399);
            button1.Name = "button1";
            button1.Size = new Size(112, 50);
            button1.TabIndex = 8;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Update_Treatment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 510);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Treatmentid);
            Name = "Update_Treatment";
            Text = "Update_Treatment";
            Load += Update_Treatment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Treatmentid;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
    }
}