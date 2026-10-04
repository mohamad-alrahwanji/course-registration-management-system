namespace CourseRegistrationManagementSystem
{
    partial class EditStudentForm
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
            saveChangesButton = new Button();
            label8 = new Label();
            phoneTextBox = new TextBox();
            label7 = new Label();
            emailTextBox = new TextBox();
            label6 = new Label();
            studentNumberTextBox = new TextBox();
            stdConfirmPasswordTextBox = new TextBox();
            label1 = new Label();
            stdNewPasswordTextBox = new TextBox();
            label2 = new Label();
            newPasswordLabel = new Label();
            label4 = new Label();
            label5 = new Label();
            stdIsActiveCheckBox = new CheckBox();
            stdFullNameTextBox = new TextBox();
            stdUsernameTextBox = new TextBox();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // saveChangesButton
            // 
            saveChangesButton.Location = new Point(759, 618);
            saveChangesButton.Margin = new Padding(2);
            saveChangesButton.Name = "saveChangesButton";
            saveChangesButton.Size = new Size(160, 34);
            saveChangesButton.TabIndex = 81;
            saveChangesButton.Text = "Save Changes";
            saveChangesButton.UseVisualStyleBackColor = true;
            saveChangesButton.Click += saveChangesButton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(62, 510);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(62, 25);
            label8.TabIndex = 80;
            label8.Text = "Phone";
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(248, 508);
            phoneTextBox.Margin = new Padding(2);
            phoneTextBox.MaxLength = 50;
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(486, 31);
            phoneTextBox.TabIndex = 79;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(62, 434);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(54, 25);
            label7.TabIndex = 78;
            label7.Text = "Email";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(248, 431);
            emailTextBox.Margin = new Padding(2);
            emailTextBox.MaxLength = 50;
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(486, 31);
            emailTextBox.TabIndex = 77;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(62, 360);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(143, 25);
            label6.TabIndex = 76;
            label6.Text = "Student Number";
            // 
            // studentNumberTextBox
            // 
            studentNumberTextBox.Location = new Point(248, 358);
            studentNumberTextBox.Margin = new Padding(2);
            studentNumberTextBox.MaxLength = 50;
            studentNumberTextBox.Name = "studentNumberTextBox";
            studentNumberTextBox.Size = new Size(486, 31);
            studentNumberTextBox.TabIndex = 75;
            // 
            // stdConfirmPasswordTextBox
            // 
            stdConfirmPasswordTextBox.Location = new Point(248, 279);
            stdConfirmPasswordTextBox.Margin = new Padding(2);
            stdConfirmPasswordTextBox.MaxLength = 100;
            stdConfirmPasswordTextBox.Name = "stdConfirmPasswordTextBox";
            stdConfirmPasswordTextBox.Size = new Size(486, 31);
            stdConfirmPasswordTextBox.TabIndex = 74;
            stdConfirmPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 282);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(156, 25);
            label1.TabIndex = 73;
            label1.Text = "Confirm Password";
            // 
            // stdNewPasswordTextBox
            // 
            stdNewPasswordTextBox.Location = new Point(248, 201);
            stdNewPasswordTextBox.Margin = new Padding(2);
            stdNewPasswordTextBox.MaxLength = 100;
            stdNewPasswordTextBox.Name = "stdNewPasswordTextBox";
            stdNewPasswordTextBox.Size = new Size(486, 31);
            stdNewPasswordTextBox.TabIndex = 72;
            stdNewPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 588);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 71;
            label2.Text = "Active";
            // 
            // newPasswordLabel
            // 
            newPasswordLabel.AutoSize = true;
            newPasswordLabel.Location = new Point(62, 204);
            newPasswordLabel.Margin = new Padding(2, 0, 2, 0);
            newPasswordLabel.Name = "newPasswordLabel";
            newPasswordLabel.Size = new Size(127, 25);
            newPasswordLabel.TabIndex = 70;
            newPasswordLabel.Text = "New Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 129);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 69;
            label4.Text = "Full Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(62, 54);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(91, 25);
            label5.TabIndex = 68;
            label5.Text = "Username";
            // 
            // stdIsActiveCheckBox
            // 
            stdIsActiveCheckBox.AutoSize = true;
            stdIsActiveCheckBox.Checked = true;
            stdIsActiveCheckBox.CheckState = CheckState.Checked;
            stdIsActiveCheckBox.Location = new Point(248, 591);
            stdIsActiveCheckBox.Margin = new Padding(2);
            stdIsActiveCheckBox.Name = "stdIsActiveCheckBox";
            stdIsActiveCheckBox.Size = new Size(22, 21);
            stdIsActiveCheckBox.TabIndex = 67;
            stdIsActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // stdFullNameTextBox
            // 
            stdFullNameTextBox.Location = new Point(248, 125);
            stdFullNameTextBox.Margin = new Padding(2);
            stdFullNameTextBox.MaxLength = 100;
            stdFullNameTextBox.Name = "stdFullNameTextBox";
            stdFullNameTextBox.Size = new Size(486, 31);
            stdFullNameTextBox.TabIndex = 66;
            // 
            // stdUsernameTextBox
            // 
            stdUsernameTextBox.Location = new Point(248, 51);
            stdUsernameTextBox.Margin = new Padding(2);
            stdUsernameTextBox.MaxLength = 50;
            stdUsernameTextBox.Name = "stdUsernameTextBox";
            stdUsernameTextBox.Size = new Size(486, 31);
            stdUsernameTextBox.TabIndex = 65;
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(575, 618);
            cancelButton.Margin = new Padding(2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(160, 34);
            cancelButton.TabIndex = 82;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // EditStudentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 675);
            Controls.Add(cancelButton);
            Controls.Add(saveChangesButton);
            Controls.Add(label8);
            Controls.Add(phoneTextBox);
            Controls.Add(label7);
            Controls.Add(emailTextBox);
            Controls.Add(label6);
            Controls.Add(studentNumberTextBox);
            Controls.Add(stdConfirmPasswordTextBox);
            Controls.Add(label1);
            Controls.Add(stdNewPasswordTextBox);
            Controls.Add(label2);
            Controls.Add(newPasswordLabel);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(stdIsActiveCheckBox);
            Controls.Add(stdFullNameTextBox);
            Controls.Add(stdUsernameTextBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            Name = "EditStudentForm";
            Text = "EditStudentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveChangesButton;
        private Label label8;
        private TextBox phoneTextBox;
        private Label label7;
        private TextBox emailTextBox;
        private Label label6;
        private TextBox studentNumberTextBox;
        private TextBox stdConfirmPasswordTextBox;
        private Label label1;
        private TextBox stdNewPasswordTextBox;
        private Label label2;
        private Label newPasswordLabel;
        private Label label4;
        private Label label5;
        private CheckBox stdIsActiveCheckBox;
        private TextBox stdFullNameTextBox;
        private TextBox stdUsernameTextBox;
        private Button cancelButton;
    }
}