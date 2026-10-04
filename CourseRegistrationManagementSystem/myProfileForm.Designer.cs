namespace CourseRegistrationManagementSystem
{
    partial class MyProfileForm
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
            label8 = new Label();
            phoneTextBox = new TextBox();
            label7 = new Label();
            emailTextBox = new TextBox();
            label6 = new Label();
            studentNumberTextBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            fullNameTextBox = new TextBox();
            usernameTextBox = new TextBox();
            label1 = new Label();
            newPasswordTextBox = new TextBox();
            label2 = new Label();
            confirmPasswordTextBox = new TextBox();
            saveChangesButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(50, 382);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(62, 25);
            label8.TabIndex = 94;
            label8.Text = "Phone";
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(235, 380);
            phoneTextBox.Margin = new Padding(2);
            phoneTextBox.MaxLength = 20;
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(486, 31);
            phoneTextBox.TabIndex = 93;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(50, 306);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(54, 25);
            label7.TabIndex = 92;
            label7.Text = "Email";
            // 
            // emailTextBox
            // 
            emailTextBox.BackColor = SystemColors.ControlLight;
            emailTextBox.Location = new Point(235, 304);
            emailTextBox.Margin = new Padding(2);
            emailTextBox.MaxLength = 50;
            emailTextBox.Name = "emailTextBox";
            emailTextBox.ReadOnly = true;
            emailTextBox.Size = new Size(486, 31);
            emailTextBox.TabIndex = 91;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(50, 232);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(143, 25);
            label6.TabIndex = 90;
            label6.Text = "Student Number";
            // 
            // studentNumberTextBox
            // 
            studentNumberTextBox.BackColor = SystemColors.ControlLight;
            studentNumberTextBox.ForeColor = Color.FromArgb(64, 64, 64);
            studentNumberTextBox.Location = new Point(235, 230);
            studentNumberTextBox.Margin = new Padding(2);
            studentNumberTextBox.MaxLength = 50;
            studentNumberTextBox.Name = "studentNumberTextBox";
            studentNumberTextBox.ReadOnly = true;
            studentNumberTextBox.Size = new Size(486, 31);
            studentNumberTextBox.TabIndex = 89;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 161);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 84;
            label4.Text = "Full Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 86);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(91, 25);
            label5.TabIndex = 83;
            label5.Text = "Username";
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.Location = new Point(235, 158);
            fullNameTextBox.Margin = new Padding(2);
            fullNameTextBox.MaxLength = 100;
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(486, 31);
            fullNameTextBox.TabIndex = 82;
            // 
            // usernameTextBox
            // 
            usernameTextBox.BackColor = SystemColors.ControlLightLight;
            usernameTextBox.ForeColor = Color.FromArgb(64, 64, 64);
            usernameTextBox.Location = new Point(235, 84);
            usernameTextBox.Margin = new Padding(2);
            usernameTextBox.MaxLength = 50;
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(486, 31);
            usernameTextBox.TabIndex = 81;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 455);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(127, 25);
            label1.TabIndex = 96;
            label1.Text = "New Password";
            // 
            // newPasswordTextBox
            // 
            newPasswordTextBox.Location = new Point(235, 452);
            newPasswordTextBox.Margin = new Padding(2);
            newPasswordTextBox.MaxLength = 50;
            newPasswordTextBox.Name = "newPasswordTextBox";
            newPasswordTextBox.Size = new Size(486, 31);
            newPasswordTextBox.TabIndex = 95;
            newPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 525);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(156, 25);
            label2.TabIndex = 98;
            label2.Text = "Confirm Password";
            // 
            // confirmPasswordTextBox
            // 
            confirmPasswordTextBox.Location = new Point(235, 522);
            confirmPasswordTextBox.Margin = new Padding(2);
            confirmPasswordTextBox.MaxLength = 50;
            confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            confirmPasswordTextBox.Size = new Size(486, 31);
            confirmPasswordTextBox.TabIndex = 97;
            confirmPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // saveChangesButton
            // 
            saveChangesButton.Location = new Point(760, 656);
            saveChangesButton.Margin = new Padding(4);
            saveChangesButton.Name = "saveChangesButton";
            saveChangesButton.Size = new Size(151, 42);
            saveChangesButton.TabIndex = 99;
            saveChangesButton.Text = "Save Changes";
            saveChangesButton.UseVisualStyleBackColor = true;
            saveChangesButton.Click += saveChangesButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(594, 656);
            cancelButton.Margin = new Padding(4);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(148, 42);
            cancelButton.TabIndex = 100;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // MyProfileForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 730);
            Controls.Add(cancelButton);
            Controls.Add(saveChangesButton);
            Controls.Add(label2);
            Controls.Add(confirmPasswordTextBox);
            Controls.Add(label1);
            Controls.Add(newPasswordTextBox);
            Controls.Add(label8);
            Controls.Add(phoneTextBox);
            Controls.Add(label7);
            Controls.Add(emailTextBox);
            Controls.Add(label6);
            Controls.Add(studentNumberTextBox);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(fullNameTextBox);
            Controls.Add(usernameTextBox);
            Margin = new Padding(4);
            Name = "MyProfileForm";
            Text = "myProfileForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private TextBox phoneTextBox;
        private Label label7;
        private TextBox emailTextBox;
        private Label label6;
        private TextBox studentNumberTextBox;
        private Label label4;
        private Label label5;
        private TextBox fullNameTextBox;
        private TextBox usernameTextBox;
        private Label label1;
        private TextBox newPasswordTextBox;
        private Label label2;
        private TextBox confirmPasswordTextBox;
        private Button saveChangesButton;
        private Button cancelButton;
    }
}