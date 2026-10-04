namespace CourseRegistrationManagementSystem
{
    partial class RegistrationHistoryForm
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
            myRegistrationsGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)myRegistrationsGrid).BeginInit();
            SuspendLayout();
            // 
            // myRegistrationsGrid
            // 
            myRegistrationsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            myRegistrationsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            myRegistrationsGrid.Location = new Point(27, 26);
            myRegistrationsGrid.Name = "myRegistrationsGrid";
            myRegistrationsGrid.RowHeadersWidth = 51;
            myRegistrationsGrid.Size = new Size(762, 542);
            myRegistrationsGrid.TabIndex = 1;
            // 
            // RegistrationHistoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 611);
            Controls.Add(myRegistrationsGrid);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RegistrationHistoryForm";
            Text = "My Registrations";
            ((System.ComponentModel.ISupportInitialize)myRegistrationsGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView myRegistrationsGrid;
    }
}