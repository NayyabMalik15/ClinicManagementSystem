namespace ClinicManagementSystem
{
    partial class Staff
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            FirstName = new TextBox();
            LastName = new TextBox();
            Role = new TextBox();
            PhoneNumber = new TextBox();
            Email = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1 = new Panel();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 102);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 1;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(472, 102);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 2;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 205);
            label3.Name = "label3";
            label3.Size = new Size(46, 25);
            label3.TabIndex = 3;
            label3.Text = "Role";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(472, 205);
            label4.Name = "label4";
            label4.Size = new Size(132, 25);
            label4.TabIndex = 4;
            label4.Text = "Phone Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(59, 318);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 5;
            label5.Text = "Email";
            // 
            // FirstName
            // 
            FirstName.Location = new Point(59, 130);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(373, 31);
            FirstName.TabIndex = 6;
            // 
            // LastName
            // 
            LastName.Location = new Point(472, 130);
            LastName.Name = "LastName";
            LastName.Size = new Size(373, 31);
            LastName.TabIndex = 7;
            // 
            // Role
            // 
            Role.Location = new Point(59, 233);
            Role.Name = "Role";
            Role.Size = new Size(373, 31);
            Role.TabIndex = 8;
            // 
            // PhoneNumber
            // 
            PhoneNumber.Location = new Point(472, 233);
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Size = new Size(373, 31);
            PhoneNumber.TabIndex = 9;
            // 
            // Email
            // 
            Email.Location = new Point(59, 346);
            Email.Name = "Email";
            Email.Size = new Size(786, 31);
            Email.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(59, 451);
            button1.Name = "button1";
            button1.Size = new Size(112, 52);
            button1.TabIndex = 11;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(289, 451);
            button2.Name = "button2";
            button2.Size = new Size(112, 52);
            button2.TabIndex = 12;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(513, 451);
            button3.Name = "button3";
            button3.Size = new Size(112, 52);
            button3.TabIndex = 13;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(733, 451);
            button4.Name = "button4";
            button4.Size = new Size(112, 52);
            button4.TabIndex = 14;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumPurple;
            panel1.Controls.Add(label6);
            panel1.Location = new Point(-22, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1903, 57);
            panel1.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(34, 13);
            label6.Name = "label6";
            label6.Size = new Size(78, 28);
            label6.TabIndex = 0;
            label6.Text = "STAFF";
            // 
            // Staff
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1802, 663);
            Controls.Add(panel1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Email);
            Controls.Add(PhoneNumber);
            Controls.Add(Role);
            Controls.Add(LastName);
            Controls.Add(FirstName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Staff";
            StartPosition = FormStartPosition.Manual;
            Text = "Staff";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox FirstName;
        private TextBox LastName;
        private TextBox Role;
        private TextBox PhoneNumber;
        private TextBox Email;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panel1;
        private Label label6;
    }
}