namespace CourseRegistrationManagementSystem
{
    partial class StudentDashboardForm
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
            logoutButton = new Button();
            myProfileButton = new Button();
            registrationHistoryButton = new Button();
            browseClassesButton = new Button();
            welcomeLabel = new Label();
            SuspendLayout();
            // 
            // logoutButton
            // 
            logoutButton.DialogResult = DialogResult.Cancel;
            logoutButton.Location = new Point(652, 393);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(90, 31);
            logoutButton.TabIndex = 7;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = true;
            // 
            // myProfileButton
            // 
            myProfileButton.Location = new Point(551, 171);
            myProfileButton.Name = "myProfileButton";
            myProfileButton.Size = new Size(172, 84);
            myProfileButton.TabIndex = 6;
            myProfileButton.Text = "My Profile";
            myProfileButton.UseVisualStyleBackColor = true;
            myProfileButton.Click += myProfileButton_Click;
            // 
            // registrationHistoryButton
            // 
            registrationHistoryButton.Location = new Point(306, 171);
            registrationHistoryButton.Name = "registrationHistoryButton";
            registrationHistoryButton.Size = new Size(177, 84);
            registrationHistoryButton.TabIndex = 5;
            registrationHistoryButton.Text = "Registration History";
            registrationHistoryButton.UseVisualStyleBackColor = true;
            registrationHistoryButton.Click += registrationHistoryButton_Click;
            // 
            // browseClassesButton
            // 
            browseClassesButton.Location = new Point(52, 171);
            browseClassesButton.Name = "browseClassesButton";
            browseClassesButton.Size = new Size(183, 84);
            browseClassesButton.TabIndex = 4;
            browseClassesButton.Text = "Browse Classes";
            browseClassesButton.UseVisualStyleBackColor = true;
            browseClassesButton.Click += BrowsesClassesButton_Click;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Location = new Point(31, 38);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(110, 20);
            welcomeLabel.TabIndex = 8;
            welcomeLabel.Text = "Welcome, User.";
            // 
            // StudentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(welcomeLabel);
            Controls.Add(logoutButton);
            Controls.Add(myProfileButton);
            Controls.Add(registrationHistoryButton);
            Controls.Add(browseClassesButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "StudentDashboardForm";
            Text = "Student Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button logoutButton;
        private Button myProfileButton;
        private Button registrationHistoryButton;
        private Button browseClassesButton;
        private Label welcomeLabel;
    }
}