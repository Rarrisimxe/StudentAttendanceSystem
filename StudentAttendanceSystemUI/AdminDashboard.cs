using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace StudentAttendanceSystemUI
{
    public partial class AdminDashboard : MaterialForm
    {
        public AdminDashboard()
        {
            InitializeComponent();

            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(
                Primary.Blue600, Primary.Blue700,
                Primary.Blue200, Accent.LightBlue200,
                TextShade.WHITE
            );

            // Sidebar setup
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Width = 200;
            panelSidebar.BackColor = Color.FromArgb(33, 150, 243);

            // Main content panel setup
            panelMainContent.Dock = DockStyle.Fill;
            panelMainContent.BackColor = Color.White;
        }

        private void LoadFormInPanel(Form form)
        {
            panelMainContent.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelMainContent.Controls.Add(form);
            form.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new AttendanceForm());
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new AddStudentForm());
        }

        private void btnViewStudents_Click(object sender, EventArgs e)
        {
            ViewStudentsForm viewStudentsForm = new ViewStudentsForm();
            viewStudentsForm.Show();  // or ShowDialog() if you want it modal

        }

        private void btnManageStaff_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new ManageStaffForm());
        }

        private void btnAttendanceReport_Click(object sender, EventArgs e)
        {
           
            AttendanceReportForm reportForm = new AttendanceReportForm();
            LoadFormInPanel(reportForm);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                new LoginForm().Show();
            }
        }

        private void AdminDashboard_Load(object sender, EventArgs e) { }

        private void panelSidebar_Paint(object sender, PaintEventArgs e) { }

        private void panelMainContent_Paint(object sender, PaintEventArgs e) { }
    }
}
