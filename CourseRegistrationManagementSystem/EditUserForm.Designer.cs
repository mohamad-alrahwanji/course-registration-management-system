namespace CourseRegistrationManagementSystem
{
    partial class EditUserForm
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
            roleCombo = new ComboBox();
            activeLabel = new Label();
            RoleLabel = new Label();
            fullNameLabel = new Label();
            userNameLabel = new Label();
            saveChangesButton = new Button();
            isActiveCheckBox = new CheckBox();
            fullNameTextBox = new TextBox();
            usernameTextBox = new TextBox();
            cancelButton = new Button();
            newPasswordLabel = new Label();
            newPasswordTextBox = new TextBox();
            label1 = new Label();
            confirmPasswordTextBox = new TextBox();
            SuspendLayout();
            // 
            // roleCombo
            // 
            roleCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            roleCombo.FormattingEnabled = true;
            roleCombo.Items.AddRange(new object[] { "Administrator", "Student" });
            roleCombo.Location = new Point(209, 340);
            roleCombo.Margin = new Padding(4, 4, 4, 4);
            roleCombo.Name = "roleCombo";
            roleCombo.Size = new Size(188, 33);
            roleCombo.TabIndex = 56;
            // 
            // activeLabel
            // 
            activeLabel.AutoSize = true;
            activeLabel.Location = new Point(52, 412);
            activeLabel.Margin = new Padding(2, 0, 2, 0);
            activeLabel.Name = "activeLabel";
            activeLabel.Size = new Size(60, 25);
            activeLabel.TabIndex = 54;
            activeLabel.Text = "Active";
            // 
            // RoleLabel
            // 
            RoleLabel.AutoSize = true;
            RoleLabel.Location = new Point(52, 342);
            RoleLabel.Margin = new Padding(2, 0, 2, 0);
            RoleLabel.Name = "RoleLabel";
            RoleLabel.Size = new Size(46, 25);
            RoleLabel.TabIndex = 53;
            RoleLabel.Text = "Role";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new Point(49, 135);
            fullNameLabel.Margin = new Padding(2, 0, 2, 0);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(91, 25);
            fullNameLabel.TabIndex = 51;
            fullNameLabel.Text = "Full Name";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new Point(49, 61);
            userNameLabel.Margin = new Padding(2, 0, 2, 0);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(91, 25);
            userNameLabel.TabIndex = 50;
            userNameLabel.Text = "Username";
            // 
            // saveChangesButton
            // 
            saveChangesButton.Location = new Point(570, 468);
            saveChangesButton.Margin = new Padding(2);
            saveChangesButton.Name = "saveChangesButton";
            saveChangesButton.Size = new Size(150, 34);
            saveChangesButton.TabIndex = 49;
            saveChangesButton.Text = "Save Changes";
            saveChangesButton.UseVisualStyleBackColor = true;
            saveChangesButton.Click += saveChangesButton_Click;
            // 
            // isActiveCheckBox
            // 
            isActiveCheckBox.AutoSize = true;
            isActiveCheckBox.Checked = true;
            isActiveCheckBox.CheckState = CheckState.Checked;
            isActiveCheckBox.Location = new Point(209, 418);
            isActiveCheckBox.Margin = new Padding(2);
            isActiveCheckBox.Name = "isActiveCheckBox";
            isActiveCheckBox.Size = new Size(22, 21);
            isActiveCheckBox.TabIndex = 48;
            isActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.Location = new Point(209, 132);
            fullNameTextBox.Margin = new Padding(2);
            fullNameTextBox.MaxLength = 100;
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(486, 31);
            fullNameTextBox.TabIndex = 47;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(209, 58);
            usernameTextBox.Margin = new Padding(2);
            usernameTextBox.MaxLength = 50;
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(486, 31);
            usernameTextBox.TabIndex = 46;
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(382, 468);
            cancelButton.Margin = new Padding(2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(150, 34);
            cancelButton.TabIndex = 57;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // newPasswordLabel
            // 
            newPasswordLabel.AutoSize = true;
            newPasswordLabel.Location = new Point(49, 206);
            newPasswordLabel.Margin = new Padding(2, 0, 2, 0);
            newPasswordLabel.Name = "newPasswordLabel";
            newPasswordLabel.Size = new Size(127, 25);
            newPasswordLabel.TabIndex = 59;
            newPasswordLabel.Text = "New Password";
            // 
            // newPasswordTextBox
            // 
            newPasswordTextBox.Location = new Point(209, 202);
            newPasswordTextBox.Margin = new Padding(2);
            newPasswordTextBox.MaxLength = 100;
            newPasswordTextBox.Name = "newPasswordTextBox";
            newPasswordTextBox.Size = new Size(486, 31);
            newPasswordTextBox.TabIndex = 58;
            newPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 274);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(156, 25);
            label1.TabIndex = 61;
            label1.Text = "Confirm Password";
            // 
            // confirmPasswordTextBox
            // 
            confirmPasswordTextBox.Location = new Point(209, 271);
            confirmPasswordTextBox.Margin = new Padding(2);
            confirmPasswordTextBox.MaxLength = 100;
            confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            confirmPasswordTextBox.Size = new Size(486, 31);
            confirmPasswordTextBox.TabIndex = 60;
            confirmPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // EditUserForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 532);
            Controls.Add(label1);
            Controls.Add(confirmPasswordTextBox);
            Controls.Add(newPasswordLabel);
            Controls.Add(newPasswordTextBox);
            Controls.Add(cancelButton);
            Controls.Add(roleCombo);
            Controls.Add(activeLabel);
            Controls.Add(RoleLabel);
            Controls.Add(fullNameLabel);
            Controls.Add(userNameLabel);
            Controls.Add(saveChangesButton);
            Controls.Add(isActiveCheckBox);
            Controls.Add(fullNameTextBox);
            Controls.Add(usernameTextBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "EditUserForm";
            Text = "EditUserForm";
            Load += EditUserForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox roleCombo;
        private Label activeLabel;
        private Label RoleLabel;
        private Label fullNameLabel;
        private Label userNameLabel;
        private Button saveChangesButton;
        private CheckBox isActiveCheckBox;
        private TextBox fullNameTextBox;
        private TextBox usernameTextBox;
        private Button cancelButton;
        private Label newPasswordLabel;
        private TextBox newPasswordTextBox;
        private Label label1;
        private TextBox confirmPasswordTextBox;
    }
}