namespace ClinicManagementSystem
{
    partial class Update_Token
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
            Tokenid = new ComboBox();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox6 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // Tokenid
            // 
            Tokenid.FormattingEnabled = true;
            Tokenid.Location = new Point(257, 53);
            Tokenid.Name = "Tokenid";
            Tokenid.Size = new Size(182, 33);
            Tokenid.TabIndex = 0;
            Tokenid.SelectedIndexChanged += Tokenid_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(257, 25);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 1;
            label1.Text = "Token_ID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(66, 133);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(274, 31);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(440, 133);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(274, 31);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(66, 231);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(274, 31);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(440, 231);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(274, 31);
            textBox4.TabIndex = 5;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(278, 339);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(274, 31);
            textBox6.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 105);
            label2.Name = "label2";
            label2.Size = new Size(123, 25);
            label2.TabIndex = 8;
            label2.Text = "TokenNumber";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(440, 105);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 9;
            label3.Text = "TokenDate";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 203);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 10;
            label4.Text = "Patient_ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(440, 203);
            label5.Name = "label5";
            label5.Size = new Size(92, 25);
            label5.TabIndex = 11;
            label5.Text = "Doctor_ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(280, 311);
            label7.Name = "label7";
            label7.Size = new Size(39, 25);
            label7.TabIndex = 13;
            label7.Text = "Fee";
            // 
            // button1
            // 
            button1.Location = new Point(327, 437);
            button1.Name = "button1";
            button1.Size = new Size(112, 47);
            button1.TabIndex = 14;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Update_Token
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 516);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox6);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(Tokenid);
            Name = "Update_Token";
            Text = "Update_Token";
            Load += Update_Token_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Tokenid;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox6;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Button button1;
    }
}