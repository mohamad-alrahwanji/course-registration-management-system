namespace CourseRegistrationManagementSystem
{
    partial class RegistrationReportForm
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
            ReportsGridView = new DataGridView();
            classCombo = new ComboBox();
            courseCombo = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            viewRegisteredStudentsButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ReportsGridView).BeginInit();
            SuspendLayout();
            // 
            // ReportsGridView
            // 
            ReportsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ReportsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReportsGridView.Location = new Point(34, 23);
            ReportsGridView.Margin = new Padding(2, 2, 2, 2);
            ReportsGridView.Name = "ReportsGridView";
            ReportsGridView.RowHeadersWidth = 62;
            ReportsGridView.Size = new Size(702, 563);
            ReportsGridView.TabIndex = 0;
            // 
            // classCombo
            // 
            classCombo.FormattingEnabled = true;
            classCombo.Location = new Point(113, 649);
            classCombo.Margin = new Padding(2, 2, 2, 2);
            classCombo.Name = "classCombo";
            classCombo.Size = new Size(298, 28);
            classCombo.TabIndex = 1;
            classCombo.SelectedIndexChanged += classCombo_SelectedIndexChanged;
            // 
            // courseCombo
            // 
            courseCombo.FormattingEnabled = true;
            courseCombo.Location = new Point(113, 610);
            courseCombo.Margin = new Padding(2, 2, 2, 2);
            courseCombo.Name = "courseCombo";
            courseCombo.Size = new Size(298, 28);
            courseCombo.TabIndex = 2;
            courseCombo.SelectedIndexChanged += CourseCombo_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 651);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 3;
            label1.Text = "Class";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 612);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 4;
            label2.Text = "Course";
            // 
            // viewRegisteredStudentsButton
            // 
            viewRegisteredStudentsButton.Location = new Point(539, 638);
            viewRegisteredStudentsButton.Margin = new Padding(2, 2, 2, 2);
            viewRegisteredStudentsButton.Name = "viewRegisteredStudentsButton";
            viewRegisteredStudentsButton.Size = new Size(208, 37);
            viewRegisteredStudentsButton.TabIndex = 5;
            viewRegisteredStudentsButton.Text = "View Registered Students";
            viewRegisteredStudentsButton.UseVisualStyleBackColor = true;
            viewRegisteredStudentsButton.Click += viewRegisteredStudentsButton_Click;
            // 
            // RegistrationReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 691);
            Controls.Add(viewRegisteredStudentsButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(courseCombo);
            Controls.Add(classCombo);
            Controls.Add(ReportsGridView);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            Name = "RegistrationReportForm";
            Text = "RegistrationReportForm";
            ((System.ComponentModel.ISupportInitialize)ReportsGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ReportsGridView;
        private ComboBox classCombo;
        private ComboBox courseCombo;
        private Label label1;
        private Label label2;
        private Button viewRegisteredStudentsButton;
    }
}