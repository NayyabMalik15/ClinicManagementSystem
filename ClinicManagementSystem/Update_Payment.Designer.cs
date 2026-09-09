namespace ClinicManagementSystem
{
    partial class Update_Payment
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
            Paymentid = new ComboBox();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // Paymentid
            // 
            Paymentid.FormattingEnabled = true;
            Paymentid.Location = new Point(253, 67);
            Paymentid.Name = "Paymentid";
            Paymentid.Size = new Size(247, 33);
            Paymentid.TabIndex = 0;
            Paymentid.SelectedIndexChanged += Paymentid_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(242, 39);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 1;
            label1.Text = "Payment_ID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(74, 169);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(247, 31);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(433, 169);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(247, 31);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(74, 271);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(247, 31);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(433, 271);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(247, 31);
            textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(253, 403);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(247, 31);
            textBox5.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 141);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 7;
            label2.Text = "Bill_ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(433, 141);
            label3.Name = "label3";
            label3.Size = new Size(115, 25);
            label3.TabIndex = 8;
            label3.Text = "Amount Paid";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 243);
            label4.Name = "label4";
            label4.Size = new Size(122, 25);
            label4.TabIndex = 9;
            label4.Text = "Payment Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(433, 243);
            label5.Name = "label5";
            label5.Size = new Size(153, 25);
            label5.TabIndex = 10;
            label5.Text = "Payment Method ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(253, 375);
            label6.Name = "label6";
            label6.Size = new Size(105, 25);
            label6.TabIndex = 11;
            label6.Text = "Recieved By";
            // 
            // button1
            // 
            button1.Location = new Point(312, 498);
            button1.Name = "button1";
            button1.Size = new Size(112, 50);
            button1.TabIndex = 12;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Update_Payment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 609);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(Paymentid);
            Name = "Update_Payment";
            Text = "Update_Payment";
            Load += Update_Payment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Paymentid;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
    }
}