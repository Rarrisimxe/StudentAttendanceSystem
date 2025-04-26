namespace StudentAttendanceSystemUI
{
    partial class AddStudentForm
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
            this.lblName = new MaterialSkin.Controls.MaterialLabel();
            this.lblEmail = new MaterialSkin.Controls.MaterialLabel();
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtName = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtCourse = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtRollNo = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblCourse = new MaterialSkin.Controls.MaterialLabel();
            this.lblRollNo = new MaterialSkin.Controls.MaterialLabel();
            this.btnAddStudent = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Depth = 0;
            this.lblName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblName.Location = new System.Drawing.Point(94, 67);
            this.lblName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(106, 19);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Student Name:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Depth = 0;
            this.lblEmail.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblEmail.Location = new System.Drawing.Point(94, 137);
            this.lblEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 19);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.HideSelection = true;
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.Location = new System.Drawing.Point(246, 124);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PrefixSuffixText = null;
            this.txtEmail.ReadOnly = false;
            this.txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(250, 48);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TabStop = false;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.TrailingIcon = null;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // txtName
            // 
            this.txtName.AnimateReadOnly = false;
            this.txtName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtName.Depth = 0;
            this.txtName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtName.HideSelection = true;
            this.txtName.LeadingIcon = null;
            this.txtName.Location = new System.Drawing.Point(246, 53);
            this.txtName.MaxLength = 32767;
            this.txtName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PrefixSuffixText = null;
            this.txtName.ReadOnly = false;
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(250, 48);
            this.txtName.TabIndex = 4;
            this.txtName.TabStop = false;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtName.TrailingIcon = null;
            this.txtName.UseSystemPasswordChar = false;
            // 
            // txtCourse
            // 
            this.txtCourse.AnimateReadOnly = false;
            this.txtCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCourse.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCourse.Depth = 0;
            this.txtCourse.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCourse.HideSelection = true;
            this.txtCourse.LeadingIcon = null;
            this.txtCourse.Location = new System.Drawing.Point(246, 196);
            this.txtCourse.MaxLength = 32767;
            this.txtCourse.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.PasswordChar = '\0';
            this.txtCourse.PrefixSuffixText = null;
            this.txtCourse.ReadOnly = false;
            this.txtCourse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCourse.SelectedText = "";
            this.txtCourse.SelectionLength = 0;
            this.txtCourse.SelectionStart = 0;
            this.txtCourse.ShortcutsEnabled = true;
            this.txtCourse.Size = new System.Drawing.Size(250, 48);
            this.txtCourse.TabIndex = 5;
            this.txtCourse.TabStop = false;
            this.txtCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCourse.TrailingIcon = null;
            this.txtCourse.UseSystemPasswordChar = false;
            // 
            // txtRollNo
            // 
            this.txtRollNo.AnimateReadOnly = false;
            this.txtRollNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtRollNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRollNo.Depth = 0;
            this.txtRollNo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRollNo.HideSelection = true;
            this.txtRollNo.LeadingIcon = null;
            this.txtRollNo.Location = new System.Drawing.Point(246, 267);
            this.txtRollNo.MaxLength = 32767;
            this.txtRollNo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRollNo.Name = "txtRollNo";
            this.txtRollNo.PasswordChar = '\0';
            this.txtRollNo.PrefixSuffixText = null;
            this.txtRollNo.ReadOnly = false;
            this.txtRollNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRollNo.SelectedText = "";
            this.txtRollNo.SelectionLength = 0;
            this.txtRollNo.SelectionStart = 0;
            this.txtRollNo.ShortcutsEnabled = true;
            this.txtRollNo.Size = new System.Drawing.Size(250, 48);
            this.txtRollNo.TabIndex = 6;
            this.txtRollNo.TabStop = false;
            this.txtRollNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRollNo.TrailingIcon = null;
            this.txtRollNo.UseSystemPasswordChar = false;
            this.txtRollNo.Click += new System.EventHandler(this.txtRollNo_Click);
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Depth = 0;
            this.lblCourse.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCourse.Location = new System.Drawing.Point(94, 213);
            this.lblCourse.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(54, 19);
            this.lblCourse.TabIndex = 7;
            this.lblCourse.Text = "Course:";
            // 
            // lblRollNo
            // 
            this.lblRollNo.AutoSize = true;
            this.lblRollNo.Depth = 0;
            this.lblRollNo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRollNo.Location = new System.Drawing.Point(94, 284);
            this.lblRollNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRollNo.Name = "lblRollNo";
            this.lblRollNo.Size = new System.Drawing.Size(56, 19);
            this.lblRollNo.TabIndex = 8;
            this.lblRollNo.Text = "Roll No:";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddStudent.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddStudent.Depth = 0;
            this.btnAddStudent.HighEmphasis = true;
            this.btnAddStudent.Icon = null;
            this.btnAddStudent.Location = new System.Drawing.Point(284, 360);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddStudent.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddStudent.Size = new System.Drawing.Size(158, 36);
            this.btnAddStudent.TabIndex = 9;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddStudent.UseAccentColor = false;
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.lblRollNo);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.txtRollNo);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Name = "AddStudentForm";
            this.Text = "AddStudentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblName;
        private MaterialSkin.Controls.MaterialLabel lblEmail;
        private MaterialSkin.Controls.MaterialTextBox2 txtEmail;
        private MaterialSkin.Controls.MaterialTextBox2 txtName;
        private MaterialSkin.Controls.MaterialTextBox2 txtCourse;
        private MaterialSkin.Controls.MaterialTextBox2 txtRollNo;
        private MaterialSkin.Controls.MaterialLabel lblCourse;
        private MaterialSkin.Controls.MaterialLabel lblRollNo;
        private MaterialSkin.Controls.MaterialButton btnAddStudent;
    }
}