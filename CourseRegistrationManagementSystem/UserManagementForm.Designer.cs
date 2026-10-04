namespace CourseRegistrationManagementSystem
{
    partial class UserManagementForm
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
            tabControl1 = new TabControl();
            viewUsersTab = new TabPage();
            userSearchTextBox = new TextBox();
            editUserButton = new Button();
            deleteUserButton = new Button();
            usersGrid = new DataGridView();
            addAdminTab = new TabPage();
            adminConfirmPasswordTextBox = new TextBox();
            confirmPasswordLabel = new Label();
            adminPasswordTextBox = new TextBox();
            activeLabel = new Label();
            passwordLabel = new Label();
            fullNameLabel = new Label();
            userNameLabel = new Label();
            adminAddUserButton = new Button();
            adminIsActiveCheckBox = new CheckBox();
            adminFullNameTextBox = new TextBox();
            adminUsernameTextBox = new TextBox();
            addStudentTab = new TabPage();
            addStudentButton = new Button();
            label8 = new Label();
            phoneTextBox = new TextBox();
            label7 = new Label();
            emailTextBox = new TextBox();
            label6 = new Label();
            studentNumberTextBox = new TextBox();
            stdConfirmPasswordTextBox = new TextBox();
            label1 = new Label();
            stdPasswordTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            stdIsActiveCheckBox = new CheckBox();
            stdFullNameTextBox = new TextBox();
            stdUsernameTextBox = new TextBox();
            tabControl1.SuspendLayout();
            viewUsersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usersGrid).BeginInit();
            addAdminTab.SuspendLayout();
            addStudentTab.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(viewUsersTab);
            tabControl1.Controls.Add(addAdminTab);
            tabControl1.Controls.Add(addStudentTab);
            tabControl1.Location = new Point(-1, -1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(788, 585);
            tabControl1.TabIndex = 0;
            // 
            // viewUsersTab
            // 
            viewUsersTab.Controls.Add(userSearchTextBox);
            viewUsersTab.Controls.Add(editUserButton);
            viewUsersTab.Controls.Add(deleteUserButton);
            viewUsersTab.Controls.Add(usersGrid);
            viewUsersTab.Location = new Point(4, 29);
            viewUsersTab.Name = "viewUsersTab";
            viewUsersTab.Padding = new Padding(3, 3, 3, 3);
            viewUsersTab.Size = new Size(780, 552);
            viewUsersTab.TabIndex = 0;
            viewUsersTab.Text = "View Users";
            viewUsersTab.UseVisualStyleBackColor = true;
            viewUsersTab.Click += tabPage1_Click;
            // 
            // userSearchTextBox
            // 
            userSearchTextBox.Location = new Point(26, 494);
            userSearchTextBox.Name = "userSearchTextBox";
            userSearchTextBox.PlaceholderText = "Search by username or full name here...";
            userSearchTextBox.Size = new Size(324, 27);
            userSearchTextBox.TabIndex = 3;
            userSearchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // editUserButton
            // 
            editUserButton.Location = new Point(484, 494);
            editUserButton.Name = "editUserButton";
            editUserButton.Size = new Size(116, 29);
            editUserButton.TabIndex = 2;
            editUserButton.Text = "Edit User";
            editUserButton.UseVisualStyleBackColor = true;
            editUserButton.Click += editUserButton_Click;
            // 
            // deleteUserButton
            // 
            deleteUserButton.Location = new Point(626, 494);
            deleteUserButton.Name = "deleteUserButton";
            deleteUserButton.Size = new Size(113, 29);
            deleteUserButton.TabIndex = 1;
            deleteUserButton.Text = "Delete User";
            deleteUserButton.UseVisualStyleBackColor = true;
            deleteUserButton.Click += deleteUserButton_Click;
            // 
            // usersGrid
            // 
            usersGrid.AllowUserToDeleteRows = false;
            usersGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            usersGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usersGrid.Location = new Point(26, 19);
            usersGrid.MultiSelect = false;
            usersGrid.Name = "usersGrid";
            usersGrid.ReadOnly = true;
            usersGrid.RowHeadersWidth = 51;
            usersGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            usersGrid.Size = new Size(713, 426);
            usersGrid.TabIndex = 0;
            // 
            // addAdminTab
            // 
            addAdminTab.Controls.Add(adminConfirmPasswordTextBox);
            addAdminTab.Controls.Add(confirmPasswordLabel);
            addAdminTab.Controls.Add(adminPasswordTextBox);
            addAdminTab.Controls.Add(activeLabel);
            addAdminTab.Controls.Add(passwordLabel);
            addAdminTab.Controls.Add(fullNameLabel);
            addAdminTab.Controls.Add(userNameLabel);
            addAdminTab.Controls.Add(adminAddUserButton);
            addAdminTab.Controls.Add(adminIsActiveCheckBox);
            addAdminTab.Controls.Add(adminFullNameTextBox);
            addAdminTab.Controls.Add(adminUsernameTextBox);
            addAdminTab.Location = new Point(4, 29);
            addAdminTab.Name = "addAdminTab";
            addAdminTab.Padding = new Padding(3, 3, 3, 3);
            addAdminTab.Size = new Size(780, 552);
            addAdminTab.TabIndex = 1;
            addAdminTab.Text = "Add Admin";
            addAdminTab.UseVisualStyleBackColor = true;
            // 
            // adminConfirmPasswordTextBox
            // 
            adminConfirmPasswordTextBox.Location = new Point(191, 234);
            adminConfirmPasswordTextBox.Margin = new Padding(2);
            adminConfirmPasswordTextBox.MaxLength = 100;
            adminConfirmPasswordTextBox.Name = "adminConfirmPasswordTextBox";
            adminConfirmPasswordTextBox.Size = new Size(390, 27);
            adminConfirmPasswordTextBox.TabIndex = 47;
            adminConfirmPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // confirmPasswordLabel
            // 
            confirmPasswordLabel.AutoSize = true;
            confirmPasswordLabel.Location = new Point(43, 237);
            confirmPasswordLabel.Margin = new Padding(2, 0, 2, 0);
            confirmPasswordLabel.Name = "confirmPasswordLabel";
            confirmPasswordLabel.Size = new Size(127, 20);
            confirmPasswordLabel.TabIndex = 46;
            confirmPasswordLabel.Text = "Confirm Password";
            // 
            // adminPasswordTextBox
            // 
            adminPasswordTextBox.Location = new Point(191, 172);
            adminPasswordTextBox.Margin = new Padding(2);
            adminPasswordTextBox.MaxLength = 100;
            adminPasswordTextBox.Name = "adminPasswordTextBox";
            adminPasswordTextBox.Size = new Size(390, 27);
            adminPasswordTextBox.TabIndex = 44;
            adminPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // activeLabel
            // 
            activeLabel.AutoSize = true;
            activeLabel.Location = new Point(43, 303);
            activeLabel.Margin = new Padding(2, 0, 2, 0);
            activeLabel.Name = "activeLabel";
            activeLabel.Size = new Size(50, 20);
            activeLabel.TabIndex = 43;
            activeLabel.Text = "Active";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(43, 174);
            passwordLabel.Margin = new Padding(2, 0, 2, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(70, 20);
            passwordLabel.TabIndex = 41;
            passwordLabel.Text = "Password";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new Point(43, 114);
            fullNameLabel.Margin = new Padding(2, 0, 2, 0);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(76, 20);
            fullNameLabel.TabIndex = 40;
            fullNameLabel.Text = "Full Name";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new Point(43, 54);
            userNameLabel.Margin = new Padding(2, 0, 2, 0);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(75, 20);
            userNameLabel.TabIndex = 39;
            userNameLabel.Text = "Username";
            // 
            // adminAddUserButton
            // 
            adminAddUserButton.Location = new Point(628, 489);
            adminAddUserButton.Margin = new Padding(2);
            adminAddUserButton.Name = "adminAddUserButton";
            adminAddUserButton.Size = new Size(101, 27);
            adminAddUserButton.TabIndex = 38;
            adminAddUserButton.Text = "Add Admin";
            adminAddUserButton.UseVisualStyleBackColor = true;
            adminAddUserButton.Click += AddAdminButton_Click;
            // 
            // adminIsActiveCheckBox
            // 
            adminIsActiveCheckBox.AutoSize = true;
            adminIsActiveCheckBox.Checked = true;
            adminIsActiveCheckBox.CheckState = CheckState.Checked;
            adminIsActiveCheckBox.Location = new Point(191, 306);
            adminIsActiveCheckBox.Margin = new Padding(2);
            adminIsActiveCheckBox.Name = "adminIsActiveCheckBox";
            adminIsActiveCheckBox.Size = new Size(18, 17);
            adminIsActiveCheckBox.TabIndex = 37;
            adminIsActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // adminFullNameTextBox
            // 
            adminFullNameTextBox.Location = new Point(191, 111);
            adminFullNameTextBox.Margin = new Padding(2);
            adminFullNameTextBox.MaxLength = 100;
            adminFullNameTextBox.Name = "adminFullNameTextBox";
            adminFullNameTextBox.Size = new Size(390, 27);
            adminFullNameTextBox.TabIndex = 36;
            // 
            // adminUsernameTextBox
            // 
            adminUsernameTextBox.Location = new Point(191, 52);
            adminUsernameTextBox.Margin = new Padding(2);
            adminUsernameTextBox.MaxLength = 50;
            adminUsernameTextBox.Name = "adminUsernameTextBox";
            adminUsernameTextBox.Size = new Size(390, 27);
            adminUsernameTextBox.TabIndex = 35;
            // 
            // addStudentTab
            // 
            addStudentTab.Controls.Add(addStudentButton);
            addStudentTab.Controls.Add(label8);
            addStudentTab.Controls.Add(phoneTextBox);
            addStudentTab.Controls.Add(label7);
            addStudentTab.Controls.Add(emailTextBox);
            addStudentTab.Controls.Add(label6);
            addStudentTab.Controls.Add(studentNumberTextBox);
            addStudentTab.Controls.Add(stdConfirmPasswordTextBox);
            addStudentTab.Controls.Add(label1);
            addStudentTab.Controls.Add(stdPasswordTextBox);
            addStudentTab.Controls.Add(label2);
            addStudentTab.Controls.Add(label3);
            addStudentTab.Controls.Add(label4);
            addStudentTab.Controls.Add(label5);
            addStudentTab.Controls.Add(stdIsActiveCheckBox);
            addStudentTab.Controls.Add(stdFullNameTextBox);
            addStudentTab.Controls.Add(stdUsernameTextBox);
            addStudentTab.Location = new Point(4, 29);
            addStudentTab.Name = "addStudentTab";
            addStudentTab.Size = new Size(780, 552);
            addStudentTab.TabIndex = 2;
            addStudentTab.Text = "Add Student";
            addStudentTab.UseVisualStyleBackColor = true;
            // 
            // addStudentButton
            // 
            addStudentButton.Location = new Point(628, 487);
            addStudentButton.Margin = new Padding(2);
            addStudentButton.Name = "addStudentButton";
            addStudentButton.Size = new Size(101, 27);
            addStudentButton.TabIndex = 64;
            addStudentButton.Text = "Add Student";
            addStudentButton.UseVisualStyleBackColor = true;
            addStudentButton.Click += AddStudentButton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(44, 401);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 63;
            label8.Text = "Phone";
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(192, 399);
            phoneTextBox.Margin = new Padding(2);
            phoneTextBox.MaxLength = 50;
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(390, 27);
            phoneTextBox.TabIndex = 62;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 340);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 61;
            label7.Text = "Email";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(192, 338);
            emailTextBox.Margin = new Padding(2);
            emailTextBox.MaxLength = 50;
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(390, 27);
            emailTextBox.TabIndex = 60;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 281);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(118, 20);
            label6.TabIndex = 59;
            label6.Text = "Student Number";
            // 
            // studentNumberTextBox
            // 
            studentNumberTextBox.Location = new Point(192, 279);
            studentNumberTextBox.Margin = new Padding(2);
            studentNumberTextBox.MaxLength = 50;
            studentNumberTextBox.Name = "studentNumberTextBox";
            studentNumberTextBox.Size = new Size(390, 27);
            studentNumberTextBox.TabIndex = 58;
            // 
            // stdConfirmPasswordTextBox
            // 
            stdConfirmPasswordTextBox.Location = new Point(192, 216);
            stdConfirmPasswordTextBox.Margin = new Padding(2);
            stdConfirmPasswordTextBox.MaxLength = 100;
            stdConfirmPasswordTextBox.Name = "stdConfirmPasswordTextBox";
            stdConfirmPasswordTextBox.Size = new Size(390, 27);
            stdConfirmPasswordTextBox.TabIndex = 57;
            stdConfirmPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 219);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 56;
            label1.Text = "Confirm Password";
            // 
            // stdPasswordTextBox
            // 
            stdPasswordTextBox.Location = new Point(192, 154);
            stdPasswordTextBox.Margin = new Padding(2);
            stdPasswordTextBox.MaxLength = 100;
            stdPasswordTextBox.Name = "stdPasswordTextBox";
            stdPasswordTextBox.Size = new Size(390, 27);
            stdPasswordTextBox.TabIndex = 55;
            stdPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 463);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 54;
            label2.Text = "Active";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 156);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 53;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 96);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 52;
            label4.Text = "Full Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 36);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 51;
            label5.Text = "Username";
            // 
            // stdIsActiveCheckBox
            // 
            stdIsActiveCheckBox.AutoSize = true;
            stdIsActiveCheckBox.Checked = true;
            stdIsActiveCheckBox.CheckState = CheckState.Checked;
            stdIsActiveCheckBox.Location = new Point(192, 466);
            stdIsActiveCheckBox.Margin = new Padding(2);
            stdIsActiveCheckBox.Name = "stdIsActiveCheckBox";
            stdIsActiveCheckBox.Size = new Size(18, 17);
            stdIsActiveCheckBox.TabIndex = 50;
            stdIsActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // stdFullNameTextBox
            // 
            stdFullNameTextBox.Location = new Point(192, 93);
            stdFullNameTextBox.Margin = new Padding(2);
            stdFullNameTextBox.MaxLength = 100;
            stdFullNameTextBox.Name = "stdFullNameTextBox";
            stdFullNameTextBox.Size = new Size(390, 27);
            stdFullNameTextBox.TabIndex = 49;
            // 
            // stdUsernameTextBox
            // 
            stdUsernameTextBox.Location = new Point(192, 34);
            stdUsernameTextBox.Margin = new Padding(2);
            stdUsernameTextBox.MaxLength = 50;
            stdUsernameTextBox.Name = "stdUsernameTextBox";
            stdUsernameTextBox.Size = new Size(390, 27);
            stdUsernameTextBox.TabIndex = 48;
            // 
            // UserManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 582);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "UserManagementForm";
            Text = "User Management";
            tabControl1.ResumeLayout(false);
            viewUsersTab.ResumeLayout(false);
            viewUsersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)usersGrid).EndInit();
            addAdminTab.ResumeLayout(false);
            addAdminTab.PerformLayout();
            addStudentTab.ResumeLayout(false);
            addStudentTab.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage viewUsersTab;
        private TabPage addAdminTab;
        private TextBox adminPasswordTextBox;
        private Label activeLabel;
        private Label passwordLabel;
        private Label fullNameLabel;
        private Label userNameLabel;
        private Button adminAddUserButton;
        private CheckBox adminIsActiveCheckBox;
        private TextBox adminFullNameTextBox;
        private TextBox adminUsernameTextBox;
        private DataGridView usersGrid;
        private TextBox userSearchTextBox;
        private Button editUserButton;
        private Button deleteUserButton;
        private TextBox adminConfirmPasswordTextBox;
        private Label confirmPasswordLabel;
        private TabPage addStudentTab;
        private TextBox stdConfirmPasswordTextBox;
        private Label label1;
        private TextBox stdPasswordTextBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private CheckBox stdIsActiveCheckBox;
        private TextBox stdFullNameTextBox;
        private TextBox stdUsernameTextBox;
        private Button addStudentButton;
        private Label label8;
        private TextBox phoneTextBox;
        private Label label7;
        private TextBox emailTextBox;
        private Label label6;
        private TextBox studentNumberTextBox;
    }
}