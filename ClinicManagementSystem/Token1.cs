using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    public partial class Token1 : Form
    {
        public Token1()
        {
            InitializeComponent();

            LoadDoctors();
            LoadTodayTokens();
        }
        private void LoadDoctors()
        {
            try
            {
                Connection c1 = new Connection();

                using (SqlConnection con = c1.OpenConnection())
                {
                    string query = @"SELECT Doctor_ID,
                                    First_Name + ' ' + Last_Name AS Doctor_Name
                             FROM Doctor
                             ORDER BY First_Name";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataAdapter daDoctor = new SqlDataAdapter(cmd);
                        DataTable dtDoctor = new DataTable();

                        daDoctor.Fill(dtDoctor);

                        comboBox1.DisplayMember = "Doctor_Name";
                        comboBox1.ValueMember = "Doctor_ID";
                        comboBox1.DataSource = dtDoctor;

                        comboBox1.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadTodayTokens()
        {
            try
            {
                Connection c1 = new Connection();

                using (SqlConnection con = c1.OpenConnection())
                {
                    string query = @"SELECT *
                                 FROM Token
                                 WHERE CAST(Token_Date AS DATE) = CAST(GETDATE() AS DATE)
                                 ORDER BY Token_Number";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        da.Fill(dt);

                        dataGridView1.AutoGenerateColumns = false;
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ClearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();

            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;

            TokenDate.Value = DateTime.Now;
        }



        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox5.Text = textBox3.Text;
            }
            if (radioButton2.Checked)
            {
               
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox1.Enabled = false;
                textBox2.Enabled = false;

                textBox3.Clear();
                textBox4.Clear();
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox5.Text = textBox3.Text;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox3.Clear();
                textBox5.Clear();
                if (radioButton1.Checked)
                {
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox1.Clear();
                    textBox2.Clear();

                    textBox1.Enabled = true;
                    textBox2.Enabled = true;
                    textBox3.Enabled = false;
                    textBox4.Enabled = false;
                }

            }
        }

        private void Token1_Load(object sender, EventArgs e)
        {
            
            LoadDoctors();
             LoadTodayTokens();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Connection c1 = new Connection();

                using (SqlConnection con = c1.OpenConnection())
                {
                    string query = @"SELECT ISNULL(MAX(Token_Number), 0) + 1
                             FROM Token
                             WHERE CAST(Token_Date AS DATE) = CAST(GETDATE() AS DATE)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        object result = cmd.ExecuteScalar();

                        textBox5.Text = result.ToString();
                        TokenDate.Value = DateTime.Now;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox5.Text.Trim() == "")
                {
                    MessageBox.Show("Please select patient.");
                    return;
                }

                if (comboBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select doctor.");
                    return;
                }

                Connection c1 = new Connection();

                using (SqlConnection con = c1.OpenConnection())
                {
                    string query = @"INSERT INTO Token
            (Token_Number, Token_Date, Patient_ID, Doctor_ID, Fee)
            VALUES
            (@Token_Number, @Token_Date, @Patient_ID, @Doctor_ID, @Fee)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Token_Number", textBox6.Text);

                        cmd.Parameters.AddWithValue("@Token_Date", TokenDate.Value);

                       
                        cmd.Parameters.AddWithValue("@Patient_ID", textBox5.Text);

                        
                        cmd.Parameters.AddWithValue("@Doctor_ID", comboBox1.Text);

                        cmd.Parameters.AddWithValue("@Fee", textBox7.Text);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Token Saved Successfully.");

                LoadTodayTokens();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            textBox5.Text = row.Cells["Token_Number"].Value?.ToString();
            TokenDate.Value = Convert.ToDateTime(row.Cells["Token_Date"].Value);
            textBox6.Text = row.Cells["Patient_Name"].Value?.ToString();
            comboBox1.Text = row.Cells["Doctor_Name"].Value?.ToString();
            textBox7.Text = row.Cells["Fee"].Value?.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form fr = new Update_Token();
            fr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this token?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result != DialogResult.Yes)
                    return;

                Connection c1 = new Connection();

                using (SqlConnection con = c1.OpenConnection())
                {
                    string query = @"DELETE FROM Token
                             WHERE Token_Number = @Token_Number";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Token_Number", textBox5.Text);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Token Deleted Successfully.");

                ClearFields();
                LoadTodayTokens();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearFields();

            TokenDate.Value = DateTime.Now;

            radioButton1.Checked = false;
            radioButton2.Checked = true;

            textBox3.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter phone number.");
                    return;
                }

                Connection c1 = new Connection();

                using (SqlConnection con = c1.OpenConnection())
                {
                    string query = @"SELECT Patient_ID, First_Name, Last_Name
                             FROM Patient
                             WHERE Phone_Number = @PhoneNumber";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@PhoneNumber", textBox1.Text.Trim());

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                
                                textBox5.Text = dr["First_Name"].ToString() + " " +
                                                dr["Last_Name"].ToString();
                                textBox2.Text = dr["First_Name"].ToString() + " " +
                                               dr["Last_Name"].ToString();

                                textBox5.Tag = dr["Patient_ID"].ToString();
                            }
                            else
                            {
                                textBox2.Clear();
                                textBox2.Tag = null;
                                textBox5.Clear();
                                textBox5.Tag = null;

                                MessageBox.Show("Patient not found.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
