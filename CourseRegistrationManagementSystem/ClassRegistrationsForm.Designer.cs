namespace CourseRegistrationManagementSystem
{
    partial class ClassRegistrationsForm
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
            registrationsGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)registrationsGrid).BeginInit();
            SuspendLayout();
            // 
            // registrationsGrid
            // 
            registrationsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            registrationsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            registrationsGrid.Location = new Point(30, 21);
            registrationsGrid.Margin = new Padding(2, 2, 2, 2);
            registrationsGrid.Name = "registrationsGrid";
            registrationsGrid.RowHeadersWidth = 62;
            registrationsGrid.Size = new Size(697, 575);
            registrationsGrid.TabIndex = 0;
            // 
            // ClassRegistrationsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 648);
            Controls.Add(registrationsGrid);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            Name = "ClassRegistrationsForm";
            Text = "ClassRegistrationForm";
            ((System.ComponentModel.ISupportInitialize)registrationsGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView registrationsGrid;
    }
}