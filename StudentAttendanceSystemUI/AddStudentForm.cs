using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAttendanceSystemUI
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            //    string name = txtName.Text.Trim();
            //    string email = txtEmail.Text.Trim();
            //    string course = txtCourse.Text.Trim();
            //    string rollNo = txtRollNo.Text.Trim();

            //    if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) ||
            //        string.IsNullOrEmpty(course) || string.IsNullOrEmpty(rollNo))
            //    {
            //        MessageBox.Show("Please fill in all fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }

            //    // Save to DB using your helper
            //     private void btnAddStudent_Click(object sender, EventArgs e)
            //{
            string StudentName = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string course = txtCourse.Text.Trim();
            string rollNo = txtRollNo.Text.Trim();

            if (string.IsNullOrEmpty(StudentName) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(course) || string.IsNullOrEmpty(rollNo))
            {
                MessageBox.Show("Please fill in all fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            // Save to DB using your helper
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO StudentsRec (StudentName, Email, Course, RollNo) VALUES (@Name, @Email, @Course, @RollNo)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Name", StudentName);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Course", course);
                    cmd.Parameters.AddWithValue("@RollNo", rollNo);

                    try
                    {
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Insert failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                //    if (success)
                //{
                //    MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    ClearFields();
                //}

                //if (success)
                //{
                //    MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    ClearFields();
                //}
                //else
                //{
                //    MessageBox.Show("Failed to add student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
        }
        private void ClearFields()
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtCourse.Text = "";
            txtRollNo.Text = "";
        }

        private void txtRollNo_Click(object sender, EventArgs e)
        {

        }
    }
    }

