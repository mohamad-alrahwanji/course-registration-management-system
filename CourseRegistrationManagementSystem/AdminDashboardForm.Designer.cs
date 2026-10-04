namespace CourseRegistrationManagementSystem
{
    partial class AdminDashboardForm
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
            manageUsersButton = new Button();
            manageCoursesButton = new Button();
            manageClassesButton = new Button();
            logoutButton = new Button();
            welcomeLabel = new Label();
            manageStudentsButton = new Button();
            registrationReportButton = new Button();
            SuspendLayout();
            // 
            // manageUsersButton
            // 
            manageUsersButton.Location = new Point(195, 119);
            manageUsersButton.Margin = new Padding(4);
            manageUsersButton.Name = "manageUsersButton";
            manageUsersButton.Size = new Size(229, 112);
            manageUsersButton.TabIndex = 0;
            manageUsersButton.Text = "Manage Users";
            manageUsersButton.UseVisualStyleBackColor = true;
            manageUsersButton.Click += ManageUsersButton_Click;
            // 
            // manageCoursesButton
            // 
            manageCoursesButton.Location = new Point(513, 119);
            manageCoursesButton.Margin = new Padding(4);
            manageCoursesButton.Name = "manageCoursesButton";
            manageCoursesButton.Size = new Size(224, 112);
            manageCoursesButton.TabIndex = 1;
            manageCoursesButton.Text = "Manage Courses";
            manageCoursesButton.UseVisualStyleBackColor = true;
            manageCoursesButton.Click += ManageCoursesButton_Click;
            // 
            // manageClassesButton
            // 
            manageClassesButton.Location = new Point(363, 318);
            manageClassesButton.Margin = new Padding(4);
            manageClassesButton.Name = "manageClassesButton";
            manageClassesButton.Size = new Size(215, 112);
            manageClassesButton.TabIndex = 2;
            manageClassesButton.Text = "Manage Classes";
            manageClassesButton.UseVisualStyleBackColor = true;
            manageClassesButton.Click += manageClassesButton_Click;
            // 
            // logoutButton
            // 
            logoutButton.DialogResult = DialogResult.Cancel;
            logoutButton.Location = new Point(820, 488);
            logoutButton.Margin = new Padding(4);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(112, 41);
            logoutButton.TabIndex = 3;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = true;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Location = new Point(44, 40);
            welcomeLabel.Margin = new Padding(4, 0, 4, 0);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(133, 25);
            welcomeLabel.TabIndex = 4;
            welcomeLabel.Text = "Welcome, User.";
            // 
            // manageStudentsButton
            // 
            manageStudentsButton.Location = new Point(68, 318);
            manageStudentsButton.Margin = new Padding(4);
            manageStudentsButton.Name = "manageStudentsButton";
            manageStudentsButton.Size = new Size(229, 112);
            manageStudentsButton.TabIndex = 5;
            manageStudentsButton.Text = "Manage Students";
            manageStudentsButton.UseVisualStyleBackColor = true;
            manageStudentsButton.Click += manageStudentsButton_Click;
            // 
            // registrationReportButton
            // 
            registrationReportButton.Location = new Point(642, 318);
            registrationReportButton.Margin = new Padding(4);
            registrationReportButton.Name = "registrationReportButton";
            registrationReportButton.Size = new Size(215, 112);
            registrationReportButton.TabIndex = 6;
            registrationReportButton.Text = "Registration Reports";
            registrationReportButton.UseVisualStyleBackColor = true;
            registrationReportButton.Click += registrationReportButton_Click;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(registrationReportButton);
            Controls.Add(manageStudentsButton);
            Controls.Add(welcomeLabel);
            Controls.Add(logoutButton);
            Controls.Add(manageClassesButton);
            Controls.Add(manageCoursesButton);
            Controls.Add(manageUsersButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "AdminDashboardForm";
            Text = "Admin Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button manageUsersButton;
        private Button manageCoursesButton;
        private Button manageClassesButton;
        private Button logoutButton;
        private Label welcomeLabel;
        private Button manageStudentsButton;
        private Button registrationReportButton;
    }
}