namespace CourseRegistrationManagementSystem
{
    partial class CourseManagementForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CoursesTab = new TabControl();
            viewCoursesTab = new TabPage();
            editCourseButton = new Button();
            courseSearchTextBox = new TextBox();
            deleteCourseButton = new Button();
            coursesGrid = new DataGridView();
            addCourseTab = new TabPage();
            activeLabel = new Label();
            descriptionLabel = new Label();
            creditHoursLabel = new Label();
            courseNameLabel = new Label();
            courseCodeLabel = new Label();
            addCourseButton = new Button();
            isActiveCheckBox = new CheckBox();
            creditHoursNumeric = new NumericUpDown();
            descriptionTextBox = new TextBox();
            courseNameTextBox = new TextBox();
            courseCodeTextBox = new TextBox();
            CoursesTab.SuspendLayout();
            viewCoursesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)coursesGrid).BeginInit();
            addCourseTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)creditHoursNumeric).BeginInit();
            SuspendLayout();
            // 
            // CoursesTab
            // 
            CoursesTab.Controls.Add(viewCoursesTab);
            CoursesTab.Controls.Add(addCourseTab);
            CoursesTab.Location = new Point(0, -1);
            CoursesTab.Name = "CoursesTab";
            CoursesTab.SelectedIndex = 0;
            CoursesTab.Size = new Size(936, 661);
            CoursesTab.TabIndex = 16;
            // 
            // viewCoursesTab
            // 
            viewCoursesTab.Controls.Add(editCourseButton);
            viewCoursesTab.Controls.Add(courseSearchTextBox);
            viewCoursesTab.Controls.Add(deleteCourseButton);
            viewCoursesTab.Controls.Add(coursesGrid);
            viewCoursesTab.Location = new Point(4, 29);
            viewCoursesTab.Name = "viewCoursesTab";
            viewCoursesTab.Padding = new Padding(3);
            viewCoursesTab.Size = new Size(928, 628);
            viewCoursesTab.TabIndex = 1;
            viewCoursesTab.Text = "View Courses";
            viewCoursesTab.UseVisualStyleBackColor = true;
            // 
            // editCourseButton
            // 
            editCourseButton.Location = new Point(590, 550);
            editCourseButton.Name = "editCourseButton";
            editCourseButton.Size = new Size(129, 29);
            editCourseButton.TabIndex = 21;
            editCourseButton.Text = "Edit Course";
            editCourseButton.UseVisualStyleBackColor = true;
            editCourseButton.Click += editCourseButton_Click;
            // 
            // courseSearchTextBox
            // 
            courseSearchTextBox.Location = new Point(27, 550);
            courseSearchTextBox.Name = "courseSearchTextBox";
            courseSearchTextBox.PlaceholderText = "Search by course code or name...";
            courseSearchTextBox.Size = new Size(364, 27);
            courseSearchTextBox.TabIndex = 20;
            courseSearchTextBox.TextChanged += courseSearchTextBox_TextChanged;
            // 
            // deleteCourseButton
            // 
            deleteCourseButton.Location = new Point(742, 549);
            deleteCourseButton.Name = "deleteCourseButton";
            deleteCourseButton.Size = new Size(131, 29);
            deleteCourseButton.TabIndex = 17;
            deleteCourseButton.Text = "Delete Course";
            deleteCourseButton.UseVisualStyleBackColor = true;
            deleteCourseButton.Click += deleteCourseButton_Click;
            // 
            // coursesGrid
            // 
            coursesGrid.AllowUserToAddRows = false;
            coursesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            coursesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            coursesGrid.Location = new Point(27, 31);
            coursesGrid.Margin = new Padding(2);
            coursesGrid.MultiSelect = false;
            coursesGrid.Name = "coursesGrid";
            coursesGrid.ReadOnly = true;
            coursesGrid.RowHeadersWidth = 62;
            coursesGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            coursesGrid.Size = new Size(868, 492);
            coursesGrid.TabIndex = 16;
            // 
            // addCourseTab
            // 
            addCourseTab.Controls.Add(activeLabel);
            addCourseTab.Controls.Add(descriptionLabel);
            addCourseTab.Controls.Add(creditHoursLabel);
            addCourseTab.Controls.Add(courseNameLabel);
            addCourseTab.Controls.Add(courseCodeLabel);
            addCourseTab.Controls.Add(addCourseButton);
            addCourseTab.Controls.Add(isActiveCheckBox);
            addCourseTab.Controls.Add(creditHoursNumeric);
            addCourseTab.Controls.Add(descriptionTextBox);
            addCourseTab.Controls.Add(courseNameTextBox);
            addCourseTab.Controls.Add(courseCodeTextBox);
            addCourseTab.Location = new Point(4, 29);
            addCourseTab.Name = "addCourseTab";
            addCourseTab.Padding = new Padding(3);
            addCourseTab.Size = new Size(928, 628);
            addCourseTab.TabIndex = 0;
            addCourseTab.Text = "Add Course";
            addCourseTab.UseVisualStyleBackColor = true;
            // 
            // activeLabel
            // 
            activeLabel.AutoSize = true;
            activeLabel.Location = new Point(37, 486);
            activeLabel.Margin = new Padding(2, 0, 2, 0);
            activeLabel.Name = "activeLabel";
            activeLabel.Size = new Size(50, 20);
            activeLabel.TabIndex = 23;
            activeLabel.Text = "Active";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(37, 219);
            descriptionLabel.Margin = new Padding(2, 0, 2, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(85, 20);
            descriptionLabel.TabIndex = 22;
            descriptionLabel.Text = "Description";
            // 
            // creditHoursLabel
            // 
            creditHoursLabel.AutoSize = true;
            creditHoursLabel.Location = new Point(37, 160);
            creditHoursLabel.Margin = new Padding(2, 0, 2, 0);
            creditHoursLabel.Name = "creditHoursLabel";
            creditHoursLabel.Size = new Size(92, 20);
            creditHoursLabel.TabIndex = 21;
            creditHoursLabel.Text = "Credit Hours";
            // 
            // courseNameLabel
            // 
            courseNameLabel.AutoSize = true;
            courseNameLabel.Location = new Point(37, 100);
            courseNameLabel.Margin = new Padding(2, 0, 2, 0);
            courseNameLabel.Name = "courseNameLabel";
            courseNameLabel.Size = new Size(98, 20);
            courseNameLabel.TabIndex = 20;
            courseNameLabel.Text = "Course Name";
            // 
            // courseCodeLabel
            // 
            courseCodeLabel.AutoSize = true;
            courseCodeLabel.Location = new Point(37, 37);
            courseCodeLabel.Margin = new Padding(2, 0, 2, 0);
            courseCodeLabel.Name = "courseCodeLabel";
            courseCodeLabel.Size = new Size(93, 20);
            courseCodeLabel.TabIndex = 19;
            courseCodeLabel.Text = "Course Code";
            // 
            // addCourseButton
            // 
            addCourseButton.Location = new Point(742, 564);
            addCourseButton.Margin = new Padding(2);
            addCourseButton.Name = "addCourseButton";
            addCourseButton.Size = new Size(124, 27);
            addCourseButton.TabIndex = 18;
            addCourseButton.Text = "Add Course";
            addCourseButton.UseVisualStyleBackColor = true;
            addCourseButton.Click += addCourseButton_Click;
            // 
            // isActiveCheckBox
            // 
            isActiveCheckBox.AutoSize = true;
            isActiveCheckBox.Checked = true;
            isActiveCheckBox.CheckState = CheckState.Checked;
            isActiveCheckBox.Location = new Point(142, 489);
            isActiveCheckBox.Margin = new Padding(2);
            isActiveCheckBox.Name = "isActiveCheckBox";
            isActiveCheckBox.Size = new Size(18, 17);
            isActiveCheckBox.TabIndex = 17;
            isActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // creditHoursNumeric
            // 
            creditHoursNumeric.Location = new Point(142, 158);
            creditHoursNumeric.Margin = new Padding(2);
            creditHoursNumeric.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            creditHoursNumeric.Name = "creditHoursNumeric";
            creditHoursNumeric.Size = new Size(73, 27);
            creditHoursNumeric.TabIndex = 16;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(142, 217);
            descriptionTextBox.Margin = new Padding(2);
            descriptionTextBox.MaxLength = 255;
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.ScrollBars = ScrollBars.Vertical;
            descriptionTextBox.Size = new Size(430, 198);
            descriptionTextBox.TabIndex = 15;
            // 
            // courseNameTextBox
            // 
            courseNameTextBox.Location = new Point(142, 94);
            courseNameTextBox.Margin = new Padding(2);
            courseNameTextBox.MaxLength = 100;
            courseNameTextBox.Name = "courseNameTextBox";
            courseNameTextBox.Size = new Size(413, 27);
            courseNameTextBox.TabIndex = 14;
            // 
            // courseCodeTextBox
            // 
            courseCodeTextBox.Location = new Point(142, 33);
            courseCodeTextBox.Margin = new Padding(2);
            courseCodeTextBox.MaxLength = 5;
            courseCodeTextBox.Name = "courseCodeTextBox";
            courseCodeTextBox.Size = new Size(141, 27);
            courseCodeTextBox.TabIndex = 13;
            // 
            // CourseManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 658);
            Controls.Add(CoursesTab);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "CourseManagementForm";
            Text = "Course Management";
            Load += Form1_Load;
            CoursesTab.ResumeLayout(false);
            viewCoursesTab.ResumeLayout(false);
            viewCoursesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)coursesGrid).EndInit();
            addCourseTab.ResumeLayout(false);
            addCourseTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)creditHoursNumeric).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl CoursesTab;
        private TabPage addCourseTab;
        private TabPage viewCoursesTab;
        private TextBox courseSearchTextBox;
        private Button deleteCourseButton;
        private DataGridView coursesGrid;
        private Label activeLabel;
        private Label descriptionLabel;
        private Label creditHoursLabel;
        private Label courseNameLabel;
        private Label courseCodeLabel;
        private Button addCourseButton;
        private CheckBox isActiveCheckBox;
        private NumericUpDown creditHoursNumeric;
        private TextBox descriptionTextBox;
        private TextBox courseNameTextBox;
        private TextBox courseCodeTextBox;
        private Button editCourseButton;
    }
}
