namespace ClinicManagementSystem
{
    partial class Update_Staff
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
            Staffid = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // Staffid
            // 
            Staffid.FormattingEnabled = true;
            Staffid.Location = new Point(270, 44);
            Staffid.Name = "Staffid";
            Staffid.Size = new Size(182, 33);
            Staffid.TabIndex = 0;
            Staffid.SelectedIndexChanged += Staffid_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 119);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 1;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(418, 119);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 2;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 232);
            label3.Name = "label3";
            label3.Size = new Size(46, 25);
            label3.TabIndex = 3;
            label3.Text = "Role";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(418, 232);
            label4.Name = "label4";
            label4.Size = new Size(132, 25);
            label4.TabIndex = 4;
            label4.Text = "Phone Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 344);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 5;
            label5.Text = "Email";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(55, 147);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(262, 31);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(418, 147);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(263, 31);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(55, 260);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(262, 31);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(418, 260);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(263, 31);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(55, 372);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(262, 31);
            textBox5.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(326, 460);
            button1.Name = "button1";
            button1.Size = new Size(112, 52);
            button1.TabIndex = 11;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Update_Staff
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 556);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Staffid);
            Name = "Update_Staff";
            Text = "Update_Staff";
            Load += Update_Staff_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Staffid;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
    }
}