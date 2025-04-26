using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;



namespace StudentAttendanceSystemUI
{
    public partial class ViewStudentsForm : Form

    {
        private DatabaseHelper dbHelper;

        public ViewStudentsForm()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            LoadStudentData();
            this.dataGridViewStudents.Dock = DockStyle.Fill;

        }

        private void dataGridViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadStudentData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "SELECT StudentName, Email, Course, RollNo FROM StudentsRec";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    try
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt != null && dt.Rows.Count > 0)
                        {
                            dataGridViewStudents.AutoGenerateColumns = false;

                            dataGridViewStudents.Columns["Name"].DataPropertyName = "StudentName";
                            dataGridViewStudents.Columns["Email"].DataPropertyName = "Email";
                            dataGridViewStudents.Columns["Course"].DataPropertyName = "Course";
                            dataGridViewStudents.Columns["RollNo"].DataPropertyName = "RollNo";

                            dataGridViewStudents.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("No student records found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //private void LoadStudentData()
        //{
        //    string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        //    string query = "SELECT StudentName, Email, Course, RollNo FROM StudentsRec";

        //    using (SqlConnection con = new SqlConnection(connectionString))
        //    {
        //        using (SqlCommand cmd = new SqlCommand(query, con))
        //        {
        //            try
        //            {
        //                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //                DataTable dt = new DataTable();
        //                adapter.Fill(dt);

        //                if (dt != null && dt.Rows.Count > 0)
        //                {
        //                    dataGridViewStudents.AutoGenerateColumns = false;

        //                    dataGridViewStudents.Columns["Name"].DataPropertyName = "StudentName";
        //                    dataGridViewStudents.Columns["Email"].DataPropertyName = "Email";
        //                    dataGridViewStudents.Columns["Course"].DataPropertyName = "Course";
        //                    dataGridViewStudents.Columns["RollNo"].DataPropertyName = "RollNo";

        //                    dataGridViewStudents.DataSource = dt;
        //                }
        //                else
        //                {
        //                    MessageBox.Show("No student records found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //    }
        //}
    }





}
    


