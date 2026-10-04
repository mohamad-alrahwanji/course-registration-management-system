namespace CourseRegistrationManagementSystem
{
    partial class StudentManagementForm
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
            studentsGrid = new DataGridView();
            studentsSearchTextBox = new TextBox();
            editStudentButton = new Button();
            deleteStudentButton = new Button();
            ((System.ComponentModel.ISupportInitialize)studentsGrid).BeginInit();
            SuspendLayout();
            // 
            // studentsGrid
            // 
            studentsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            studentsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentsGrid.Location = new Point(40, 23);
            studentsGrid.Name = "studentsGrid";
            studentsGrid.RowHeadersWidth = 51;
            studentsGrid.Size = new Size(715, 459);
            studentsGrid.TabIndex = 0;
            // 
            // studentsSearchTextBox
            // 
            studentsSearchTextBox.Location = new Point(39, 519);
            studentsSearchTextBox.Name = "studentsSearchTextBox";
            studentsSearchTextBox.PlaceholderText = "Search for student here...";
            studentsSearchTextBox.Size = new Size(323, 27);
            studentsSearchTextBox.TabIndex = 1;
            studentsSearchTextBox.TextChanged += searchStudentsTextBox_TextChanged;
            // 
            // editStudentButton
            // 
            editStudentButton.Location = new Point(501, 517);
            editStudentButton.Name = "editStudentButton";
            editStudentButton.Size = new Size(117, 29);
            editStudentButton.TabIndex = 2;
            editStudentButton.Text = "Edit Student";
            editStudentButton.UseVisualStyleBackColor = true;
            editStudentButton.Click += editStudentButton_Click;
            // 
            // deleteStudentButton
            // 
            deleteStudentButton.Location = new Point(634, 517);
            deleteStudentButton.Name = "deleteStudentButton";
            deleteStudentButton.Size = new Size(122, 29);
            deleteStudentButton.TabIndex = 3;
            deleteStudentButton.Text = "Delete Student";
            deleteStudentButton.UseVisualStyleBackColor = true;
            deleteStudentButton.Click += deleteStudentButton_Click;
            // 
            // StudentManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 583);
            Controls.Add(deleteStudentButton);
            Controls.Add(editStudentButton);
            Controls.Add(studentsSearchTextBox);
            Controls.Add(studentsGrid);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "StudentManagementForm";
            Text = "StudentManagementForm";
            ((System.ComponentModel.ISupportInitialize)studentsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView studentsGrid;
        private TextBox studentsSearchTextBox;
        private Button editStudentButton;
        private Button deleteStudentButton;
    }
}