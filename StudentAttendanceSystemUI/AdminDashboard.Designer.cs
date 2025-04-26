namespace StudentAttendanceSystemUI
{
    partial class AdminDashboard
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
            this.btnAddStudent = new MaterialSkin.Controls.MaterialButton();
            this.btnViewStudents = new MaterialSkin.Controls.MaterialButton();
            this.btnManageStaff = new MaterialSkin.Controls.MaterialButton();
            this.btnAttendanceReport = new MaterialSkin.Controls.MaterialButton();
            this.btnLogout = new MaterialSkin.Controls.MaterialButton();
            this.lblStatus = new MaterialSkin.Controls.MaterialLabel();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnDashboard = new MaterialSkin.Controls.MaterialButton();
            this.panelMainContent = new System.Windows.Forms.Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.panelSidebar.SuspendLayout();
            this.panelMainContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddStudent.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddStudent.Depth = 0;
            this.btnAddStudent.HighEmphasis = true;
            this.btnAddStudent.Icon = null;
            this.btnAddStudent.Location = new System.Drawing.Point(35, 153);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddStudent.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddStudent.Size = new System.Drawing.Size(119, 36);
            this.btnAddStudent.TabIndex = 0;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddStudent.UseAccentColor = false;
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnViewStudents
            // 
            this.btnViewStudents.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnViewStudents.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnViewStudents.Depth = 0;
            this.btnViewStudents.HighEmphasis = true;
            this.btnViewStudents.Icon = null;
            this.btnViewStudents.Location = new System.Drawing.Point(35, 351);
            this.btnViewStudents.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnViewStudents.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnViewStudents.Name = "btnViewStudents";
            this.btnViewStudents.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnViewStudents.Size = new System.Drawing.Size(134, 36);
            this.btnViewStudents.TabIndex = 1;
            this.btnViewStudents.Text = "View Students";
            this.btnViewStudents.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnViewStudents.UseAccentColor = false;
            this.btnViewStudents.UseVisualStyleBackColor = true;
            this.btnViewStudents.Click += new System.EventHandler(this.btnViewStudents_Click);
            // 
            // btnManageStaff
            // 
            this.btnManageStaff.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnManageStaff.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnManageStaff.Depth = 0;
            this.btnManageStaff.HighEmphasis = true;
            this.btnManageStaff.Icon = null;
            this.btnManageStaff.Location = new System.Drawing.Point(31, 251);
            this.btnManageStaff.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnManageStaff.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnManageStaff.Name = "btnManageStaff";
            this.btnManageStaff.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnManageStaff.Size = new System.Drawing.Size(130, 36);
            this.btnManageStaff.TabIndex = 2;
            this.btnManageStaff.Text = "Manage Staff";
            this.btnManageStaff.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnManageStaff.UseAccentColor = false;
            this.btnManageStaff.UseVisualStyleBackColor = true;
            this.btnManageStaff.Click += new System.EventHandler(this.btnManageStaff_Click);
            // 
            // btnAttendanceReport
            // 
            this.btnAttendanceReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAttendanceReport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAttendanceReport.Depth = 0;
            this.btnAttendanceReport.HighEmphasis = true;
            this.btnAttendanceReport.Icon = null;
            this.btnAttendanceReport.Location = new System.Drawing.Point(18, 445);
            this.btnAttendanceReport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAttendanceReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAttendanceReport.Name = "btnAttendanceReport";
            this.btnAttendanceReport.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAttendanceReport.Size = new System.Drawing.Size(175, 36);
            this.btnAttendanceReport.TabIndex = 3;
            this.btnAttendanceReport.Text = "Attendance Report";
            this.btnAttendanceReport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAttendanceReport.UseAccentColor = false;
            this.btnAttendanceReport.UseVisualStyleBackColor = true;
            this.btnAttendanceReport.Click += new System.EventHandler(this.btnAttendanceReport_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogout.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogout.Depth = 0;
            this.btnLogout.HighEmphasis = true;
            this.btnLogout.Icon = null;
            this.btnLogout.Location = new System.Drawing.Point(55, 529);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogout.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogout.Size = new System.Drawing.Size(78, 36);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogout.UseAccentColor = false;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Depth = 0;
            this.lblStatus.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblStatus.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblStatus.Location = new System.Drawing.Point(297, 81);
            this.lblStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(181, 24);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Logged in as: Admin";
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelSidebar.Controls.Add(this.btnDashboard);
            this.panelSidebar.Controls.Add(this.btnAddStudent);
            this.panelSidebar.Controls.Add(this.btnManageStaff);
            this.panelSidebar.Controls.Add(this.btnLogout);
            this.panelSidebar.Controls.Add(this.btnViewStudents);
            this.panelSidebar.Controls.Add(this.btnAttendanceReport);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(3, 64);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(200, 647);
            this.panelSidebar.TabIndex = 6;
            this.panelSidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSidebar_Paint);
            // 
            // btnDashboard
            // 
            this.btnDashboard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDashboard.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDashboard.Depth = 0;
            this.btnDashboard.HighEmphasis = true;
            this.btnDashboard.Icon = null;
            this.btnDashboard.Location = new System.Drawing.Point(35, 60);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDashboard.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDashboard.Size = new System.Drawing.Size(108, 36);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDashboard.UseAccentColor = false;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panelMainContent
            // 
            this.panelMainContent.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelMainContent.Controls.Add(this.materialLabel1);
            this.panelMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContent.Location = new System.Drawing.Point(203, 64);
            this.panelMainContent.Name = "panelMainContent";
            this.panelMainContent.Size = new System.Drawing.Size(720, 647);
            this.panelMainContent.TabIndex = 7;
            this.panelMainContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMainContent_Paint);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(260, 251);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(150, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Welcome Back :)";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 714);
            this.Controls.Add(this.panelMainContent);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.lblStatus);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panelMainContent.ResumeLayout(false);
            this.panelMainContent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnAddStudent;
        private MaterialSkin.Controls.MaterialButton btnViewStudents;
        private MaterialSkin.Controls.MaterialButton btnManageStaff;
        private MaterialSkin.Controls.MaterialButton btnAttendanceReport;
        private MaterialSkin.Controls.MaterialButton btnLogout;
        private MaterialSkin.Controls.MaterialLabel lblStatus;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelMainContent;
        private MaterialSkin.Controls.MaterialButton btnDashboard;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}