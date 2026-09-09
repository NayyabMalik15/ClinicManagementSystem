namespace ClinicManagementSystem
{
    partial class Payment
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
            Billid = new ComboBox();
            ReceivedBy = new ComboBox();
            AmountPaid = new TextBox();
            PaymentMethod = new ComboBox();
            PaymentDate = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1 = new Panel();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 103);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "Bill_ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(455, 103);
            label2.Name = "label2";
            label2.Size = new Size(115, 25);
            label2.TabIndex = 1;
            label2.Text = "Amount Paid";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 207);
            label3.Name = "label3";
            label3.Size = new Size(148, 25);
            label3.TabIndex = 2;
            label3.Text = "Payment Method";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(455, 209);
            label4.Name = "label4";
            label4.Size = new Size(122, 25);
            label4.TabIndex = 3;
            label4.Text = "Payment Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 312);
            label5.Name = "label5";
            label5.Size = new Size(105, 25);
            label5.TabIndex = 4;
            label5.Text = "Received By";
            // 
            // Billid
            // 
            Billid.FormattingEnabled = true;
            Billid.Location = new Point(65, 131);
            Billid.Name = "Billid";
            Billid.Size = new Size(347, 33);
            Billid.TabIndex = 5;
            // 
            // ReceivedBy
            // 
            ReceivedBy.FormattingEnabled = true;
            ReceivedBy.Location = new Point(65, 340);
            ReceivedBy.Name = "ReceivedBy";
            ReceivedBy.Size = new Size(347, 33);
            ReceivedBy.TabIndex = 6;
            // 
            // AmountPaid
            // 
            AmountPaid.Location = new Point(455, 133);
            AmountPaid.Name = "AmountPaid";
            AmountPaid.Size = new Size(347, 31);
            AmountPaid.TabIndex = 7;
            // 
            // PaymentMethod
            // 
            PaymentMethod.FormattingEnabled = true;
            PaymentMethod.Items.AddRange(new object[] { "Cash", "Card", "Cheque", "Easypaisa", "JazzCash" });
            PaymentMethod.Location = new Point(65, 235);
            PaymentMethod.Name = "PaymentMethod";
            PaymentMethod.Size = new Size(347, 33);
            PaymentMethod.TabIndex = 8;
            // 
            // PaymentDate
            // 
            PaymentDate.Location = new Point(455, 237);
            PaymentDate.Name = "PaymentDate";
            PaymentDate.Size = new Size(347, 31);
            PaymentDate.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(65, 434);
            button1.Name = "button1";
            button1.Size = new Size(112, 58);
            button1.TabIndex = 10;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(274, 434);
            button2.Name = "button2";
            button2.Size = new Size(112, 58);
            button2.TabIndex = 11;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(477, 434);
            button3.Name = "button3";
            button3.Size = new Size(112, 58);
            button3.TabIndex = 12;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(690, 434);
            button4.Name = "button4";
            button4.Size = new Size(112, 58);
            button4.TabIndex = 13;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Purple;
            panel1.Controls.Add(label6);
            panel1.Location = new Point(-6, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1782, 56);
            panel1.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(18, 19);
            label6.Name = "label6";
            label6.Size = new Size(119, 28);
            label6.TabIndex = 0;
            label6.Text = "PAYMENT";
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1662, 707);
            Controls.Add(panel1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(PaymentDate);
            Controls.Add(PaymentMethod);
            Controls.Add(AmountPaid);
            Controls.Add(ReceivedBy);
            Controls.Add(Billid);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Payment";
            StartPosition = FormStartPosition.Manual;
            Text = "Payment";
            Load += Payment_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox Billid;
        private ComboBox ReceivedBy;
        private TextBox AmountPaid;
        private ComboBox PaymentMethod;
        private DateTimePicker PaymentDate;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panel1;
        private Label label6;
    }
}