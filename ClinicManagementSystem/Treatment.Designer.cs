namespace ClinicManagementSystem
{
    partial class Treatment
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            TreatmentName = new TextBox();
            StandardCost = new TextBox();
            Description = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 35);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 0;
            label1.Text = "Treatment Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(380, 35);
            label2.Name = "label2";
            label2.Size = new Size(124, 25);
            label2.TabIndex = 1;
            label2.Text = "Standard Cost";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 123);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 2;
            label3.Text = "Description";
            // 
            // button1
            // 
            button1.Location = new Point(37, 269);
            button1.Name = "button1";
            button1.Size = new Size(112, 53);
            button1.TabIndex = 3;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(220, 269);
            button2.Name = "button2";
            button2.Size = new Size(112, 53);
            button2.TabIndex = 4;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(403, 269);
            button3.Name = "button3";
            button3.Size = new Size(112, 53);
            button3.TabIndex = 5;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(579, 269);
            button4.Name = "button4";
            button4.Size = new Size(112, 53);
            button4.TabIndex = 6;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // TreatmentName
            // 
            TreatmentName.Location = new Point(37, 63);
            TreatmentName.Name = "TreatmentName";
            TreatmentName.Size = new Size(307, 31);
            TreatmentName.TabIndex = 7;
            // 
            // StandardCost
            // 
            StandardCost.Location = new Point(380, 63);
            StandardCost.Name = "StandardCost";
            StandardCost.Size = new Size(311, 31);
            StandardCost.TabIndex = 8;
            // 
            // Description
            // 
            Description.Location = new Point(37, 151);
            Description.Name = "Description";
            Description.Size = new Size(654, 85);
            Description.TabIndex = 9;
            Description.Text = "";
            // 
            // Treatment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 363);
            Controls.Add(Description);
            Controls.Add(StandardCost);
            Controls.Add(TreatmentName);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Treatment";
            Text = "Treatment";
            Load += Treatment_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox TreatmentName;
        private TextBox StandardCost;
        private RichTextBox Description;
    }
}