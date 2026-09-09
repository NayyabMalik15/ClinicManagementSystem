using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    public partial class Dashboard : Form
    {
        private void OpenChildForm(Form childForm)
        {
            PanelContent.Controls.Clear();

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            PanelContent.Controls.Add(childForm);
            PanelContent.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }
        public Dashboard()
        {
            InitializeComponent();
        }
        private void OpenForm(Form frm)
        {
            PanelContent.Controls.Clear();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            PanelContent.Controls.Add(frm);
            frm.Show();
        }
        private void OpenFormInPanel(Form childForm)
        {
            PanelContent.Controls.Clear();

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(0, 0);
            childForm.Size = PanelContent.ClientSize;

            PanelContent.Controls.Add(childForm);
            childForm.Show();
            childForm.BringToFront();
        }




        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Token1());
            Token1 tokenForm = new Token1();

            tokenForm.TopLevel = false;
            tokenForm.FormBorderStyle = FormBorderStyle.None;

            PanelContent.Controls.Clear();
            PanelContent.Controls.Add(tokenForm);

            tokenForm.Location = new Point(0, 0);
            tokenForm.Size = PanelContent.ClientSize;

            tokenForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Patient());

            Patient patientForm = new Patient();

            patientForm.TopLevel = false;
            patientForm.FormBorderStyle = FormBorderStyle.None;

            PanelContent.Controls.Clear();
            PanelContent.Controls.Add(patientForm);

            patientForm.Location = new Point(0, 0);
            patientForm.Size = PanelContent.ClientSize;

            patientForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Doctor());

            Doctor doctorForm = new Doctor();

            doctorForm.TopLevel = false;
            doctorForm.FormBorderStyle = FormBorderStyle.None;

            PanelContent.Controls.Clear();
            PanelContent.Controls.Add(doctorForm);

            doctorForm.Location = new Point(0, 0);
            doctorForm.Size = PanelContent.ClientSize;

            doctorForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Staff());
            Staff staffForm = new Staff();

            staffForm.TopLevel = false;
            staffForm.FormBorderStyle = FormBorderStyle.None;
            staffForm.Dock = DockStyle.Fill;

            PanelContent.Controls.Clear();
            PanelContent.Controls.Add(staffForm);

            staffForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Treatment());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Medicine());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Bill());
            Bill billForm = new Bill();

            billForm.TopLevel = false;
            billForm.FormBorderStyle = FormBorderStyle.None;
            billForm.Dock = DockStyle.Fill;

            PanelContent.Controls.Clear();
            PanelContent.Controls.Add(billForm);

            billForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Payment());

            Payment paymentForm = new Payment();

            paymentForm.TopLevel = false;
            paymentForm.FormBorderStyle = FormBorderStyle.None;
            paymentForm.Dock = DockStyle.Fill;

            PanelContent.Controls.Clear();
            PanelContent.Controls.Add(paymentForm);

            paymentForm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Company());

            Company companyForm = new Company();

            companyForm.TopLevel = false;
            companyForm.FormBorderStyle = FormBorderStyle.None;
            companyForm.Dock = DockStyle.Fill;

            PanelContent.Controls.Clear();
            PanelContent.Controls.Add(companyForm);

            companyForm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Product());

            Product productForm = new Product();

            productForm.TopLevel = false;
            productForm.FormBorderStyle = FormBorderStyle.None;
            productForm.Dock = DockStyle.Fill;

            PanelContent.Controls.Clear();
            PanelContent.Controls.Add(productForm);

            productForm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Stock());

            Stock stockForm = new Stock();

            stockForm.TopLevel = false;
            stockForm.FormBorderStyle = FormBorderStyle.None;
            stockForm.Dock = DockStyle.Fill;

            PanelContent.Controls.Clear();
            PanelContent.Controls.Add(stockForm);

            stockForm.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToString("dd MMMM yyyy");
        }
    }
}
