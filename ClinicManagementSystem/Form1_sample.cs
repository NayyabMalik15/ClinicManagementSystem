using DocumentFormat.OpenXml.Office.CustomUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    public partial class Form1_sample : Form
    {
        public Form1_sample()
        {
            InitializeComponent();
        }

        private void Form1_sample_Load(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;
            label1.Text = currentDateTime.ToString();

            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox1.Visible = true;
            button2.Visible = false;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox1.Visible = false;

            }
            else if (radioButton2.Checked)
            {
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox1.Visible = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox1.Visible = false;
                button2.Visible = true;


            }
            else if (radioButton2.Checked)
            {
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox1.Visible = true;
                button2.Visible = false;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
