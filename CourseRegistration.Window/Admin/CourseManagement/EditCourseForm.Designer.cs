namespace CourseRegistration.Window
{
    partial class EditCourseForm
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
            activeLabel = new Label();
            descriptionLabel = new Label();
            creditHoursLabel = new Label();
            courseNameLabel = new Label();
            courseCodeLabel = new Label();
            saveChangesButton = new Button();
            isActiveCheckBox = new CheckBox();
            creditHoursNumeric = new NumericUpDown();
            descriptionTextBox = new TextBox();
            courseNameTextBox = new TextBox();
            courseCodeTextBox = new TextBox();
            cancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)creditHoursNumeric).BeginInit();
            SuspendLayout();
            // 
            // activeLabel
            // 
            activeLabel.AutoSize = true;
            activeLabel.Location = new Point(55, 606);
            activeLabel.Margin = new Padding(2, 0, 2, 0);
            activeLabel.Name = "activeLabel";
            activeLabel.Size = new Size(60, 25);
            activeLabel.TabIndex = 34;
            activeLabel.Text = "Active";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(55, 272);
            descriptionLabel.Margin = new Padding(2, 0, 2, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(102, 25);
            descriptionLabel.TabIndex = 33;
            descriptionLabel.Text = "Description";
            // 
            // creditHoursLabel
            // 
            creditHoursLabel.AutoSize = true;
            creditHoursLabel.Location = new Point(55, 199);
            creditHoursLabel.Margin = new Padding(2, 0, 2, 0);
            creditHoursLabel.Name = "creditHoursLabel";
            creditHoursLabel.Size = new Size(112, 25);
            creditHoursLabel.TabIndex = 32;
            creditHoursLabel.Text = "Credit Hours";
            // 
            // courseNameLabel
            // 
            courseNameLabel.AutoSize = true;
            courseNameLabel.Location = new Point(55, 124);
            courseNameLabel.Margin = new Padding(2, 0, 2, 0);
            courseNameLabel.Name = "courseNameLabel";
            courseNameLabel.Size = new Size(119, 25);
            courseNameLabel.TabIndex = 31;
            courseNameLabel.Text = "Course Name";
            // 
            // courseCodeLabel
            // 
            courseCodeLabel.AutoSize = true;
            courseCodeLabel.Location = new Point(55, 45);
            courseCodeLabel.Margin = new Padding(2, 0, 2, 0);
            courseCodeLabel.Name = "courseCodeLabel";
            courseCodeLabel.Size = new Size(114, 25);
            courseCodeLabel.TabIndex = 30;
            courseCodeLabel.Text = "Course Code";
            // 
            // saveChangesButton
            // 
            saveChangesButton.Location = new Point(760, 656);
            saveChangesButton.Margin = new Padding(2);
            saveChangesButton.Name = "saveChangesButton";
            saveChangesButton.Size = new Size(155, 34);
            saveChangesButton.TabIndex = 29;
            saveChangesButton.Text = "Save Changes";
            saveChangesButton.UseVisualStyleBackColor = true;
            saveChangesButton.Click += saveChangesButton_Click;
            // 
            // isActiveCheckBox
            // 
            isActiveCheckBox.AutoSize = true;
            isActiveCheckBox.Checked = true;
            isActiveCheckBox.CheckState = CheckState.Checked;
            isActiveCheckBox.Location = new Point(186, 610);
            isActiveCheckBox.Margin = new Padding(2);
            isActiveCheckBox.Name = "isActiveCheckBox";
            isActiveCheckBox.Size = new Size(22, 21);
            isActiveCheckBox.TabIndex = 28;
            isActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // creditHoursNumeric
            // 
            creditHoursNumeric.Location = new Point(186, 196);
            creditHoursNumeric.Margin = new Padding(2);
            creditHoursNumeric.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            creditHoursNumeric.Name = "creditHoursNumeric";
            creditHoursNumeric.Size = new Size(91, 31);
            creditHoursNumeric.TabIndex = 27;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(186, 270);
            descriptionTextBox.Margin = new Padding(2);
            descriptionTextBox.MaxLength = 255;
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.ScrollBars = ScrollBars.Vertical;
            descriptionTextBox.Size = new Size(536, 246);
            descriptionTextBox.TabIndex = 26;
            // 
            // courseNameTextBox
            // 
            courseNameTextBox.Location = new Point(186, 116);
            courseNameTextBox.Margin = new Padding(2);
            courseNameTextBox.MaxLength = 100;
            courseNameTextBox.Name = "courseNameTextBox";
            courseNameTextBox.Size = new Size(515, 31);
            courseNameTextBox.TabIndex = 25;
            // 
            // courseCodeTextBox
            // 
            courseCodeTextBox.Location = new Point(186, 40);
            courseCodeTextBox.Margin = new Padding(2);
            courseCodeTextBox.MaxLength = 5;
            courseCodeTextBox.Name = "courseCodeTextBox";
            courseCodeTextBox.Size = new Size(175, 31);
            courseCodeTextBox.TabIndex = 24;
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(569, 656);
            cancelButton.Margin = new Padding(2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(155, 34);
            cancelButton.TabIndex = 35;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // EditCourseForm
            // 
            AcceptButton = saveChangesButton;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelButton;
            ClientSize = new Size(975, 754);
            Controls.Add(cancelButton);
            Controls.Add(activeLabel);
            Controls.Add(descriptionLabel);
            Controls.Add(creditHoursLabel);
            Controls.Add(courseNameLabel);
            Controls.Add(courseCodeLabel);
            Controls.Add(saveChangesButton);
            Controls.Add(isActiveCheckBox);
            Controls.Add(creditHoursNumeric);
            Controls.Add(descriptionTextBox);
            Controls.Add(courseNameTextBox);
            Controls.Add(courseCodeTextBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditCourseForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit Course";
            ((System.ComponentModel.ISupportInitialize)creditHoursNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label activeLabel;
        private Label descriptionLabel;
        private Label creditHoursLabel;
        private Label courseNameLabel;
        private Label courseCodeLabel;
        private Button saveChangesButton;
        private CheckBox isActiveCheckBox;
        private NumericUpDown creditHoursNumeric;
        private TextBox descriptionTextBox;
        private TextBox courseNameTextBox;
        private TextBox courseCodeTextBox;
        private Button cancelButton;
    }
}