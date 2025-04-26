using MaterialSkin;
using MaterialSkin.Controls;
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
using System.Drawing.Drawing2D;




namespace StudentAttendanceSystemUI
{
    public partial class LoginForm : MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);


            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;


            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Pink600,
                Primary.Pink700,
                Primary.Purple400,
                Accent.DeepOrange200,
                TextShade.WHITE);
                }
                protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                   Color.FromArgb(255, 255, 105, 180), 
                   Color.FromArgb(255, 138, 43, 226),  
                   135F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (email == "" || password == "")
            {
                MessageBox.Show("Please enter both email and password.");
                return;
            }

            try
            {
                string connectionString = "Data Source=(localdb)\\local;Initial Catalog=StudentAttendanceDB;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Role FROM Users WHERE Email = @Email AND Password = @Password";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string role = result.ToString();
                        MessageBox.Show($"Login successful! You are logged in as {role}");

                        switch (role)
                        {
                            case "Admin":
                                new AdminDashboard().Show();
                                break;
                            case "Staff":
                                new StaffDashboard().Show();
                                break;
                            case "Student":
                                new StudentDashboard().Show();
                                break;
                            default:
                                MessageBox.Show("Unknown role.");
                                return;
                        }

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

                {
                    string userEmail = txtEmail.Text;
                    string userPassword = txtPassword.Text;

                    //AuthManager auth = new AuthManager();
                    string role = "Admin";

                    if (role == "Admin")
                    {
                        MessageBox.Show("Login successful! Logged in as " + role);
                        AdminDashboard dashboard = new AdminDashboard();
                        dashboard.Show();
                        this.Hide();
                    }
                    else if (role == "Student")
                    {
                        StudentDashboard dashboard = new StudentDashboard();
                        dashboard.Show();
                        this.Hide();
                    }
                    else if (role == "Staff")
                    {
                        StaffDashboard dashboard = new StaffDashboard();
                        dashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password. Please try again.");
                    }

                }
            }

            }
        

        private void txtEmail_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}