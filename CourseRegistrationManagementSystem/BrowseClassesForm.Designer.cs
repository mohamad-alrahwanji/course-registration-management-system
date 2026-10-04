namespace CourseRegistrationManagementSystem
{
    partial class BrowseClassesForm
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
            viewClassesTab = new TabPage();
            registerClassButton = new Button();
            searchClassTextBox = new TextBox();
            availableClassesGrid = new DataGridView();
            myRegistrationsTab = new TabPage();
            cancelRegistrationButton = new Button();
            myRegistrationsGrid = new DataGridView();
            tabControl1.SuspendLayout();
            viewClassesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)availableClassesGrid).BeginInit();
            myRegistrationsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)myRegistrationsGrid).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(viewClassesTab);
            tabControl1.Controls.Add(myRegistrationsTab);
            tabControl1.Location = new Point(0, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(849, 699);
            tabControl1.TabIndex = 3;
            // 
            // viewClassesTab
            // 
            viewClassesTab.Controls.Add(registerClassButton);
            viewClassesTab.Controls.Add(searchClassTextBox);
            viewClassesTab.Controls.Add(availableClassesGrid);
            viewClassesTab.Location = new Point(4, 29);
            viewClassesTab.Name = "viewClassesTab";
            viewClassesTab.Padding = new Padding(3);
            viewClassesTab.Size = new Size(841, 666);
            viewClassesTab.TabIndex = 0;
            viewClassesTab.Text = "View Classes";
            viewClassesTab.UseVisualStyleBackColor = true;
            // 
            // registerClassButton
            // 
            registerClassButton.Location = new Point(669, 621);
            registerClassButton.Name = "registerClassButton";
            registerClassButton.Size = new Size(130, 29);
            registerClassButton.TabIndex = 5;
            registerClassButton.Text = "Register Class";
            registerClassButton.UseVisualStyleBackColor = true;
            registerClassButton.Click += registerClassButton_Click;
            // 
            // searchClassTextBox
            // 
            searchClassTextBox.Location = new Point(37, 621);
            searchClassTextBox.Name = "searchClassTextBox";
            searchClassTextBox.PlaceholderText = "Search by course name or code...";
            searchClassTextBox.Size = new Size(319, 27);
            searchClassTextBox.TabIndex = 4;
            searchClassTextBox.TextChanged += searchClassTextBox_TextChanged;
            // 
            // availableClassesGrid
            // 
            availableClassesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            availableClassesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            availableClassesGrid.Location = new Point(37, 9);
            availableClassesGrid.Name = "availableClassesGrid";
            availableClassesGrid.RowHeadersWidth = 51;
            availableClassesGrid.Size = new Size(762, 592);
            availableClassesGrid.TabIndex = 3;
            // 
            // myRegistrationsTab
            // 
            myRegistrationsTab.Controls.Add(cancelRegistrationButton);
            myRegistrationsTab.Controls.Add(myRegistrationsGrid);
            myRegistrationsTab.Location = new Point(4, 29);
            myRegistrationsTab.Name = "myRegistrationsTab";
            myRegistrationsTab.Padding = new Padding(3);
            myRegistrationsTab.Size = new Size(841, 666);
            myRegistrationsTab.TabIndex = 1;
            myRegistrationsTab.Text = "My Registrations";
            myRegistrationsTab.UseVisualStyleBackColor = true;
            // 
            // cancelRegistrationButton
            // 
            cancelRegistrationButton.Location = new Point(630, 621);
            cancelRegistrationButton.Name = "cancelRegistrationButton";
            cancelRegistrationButton.Size = new Size(169, 29);
            cancelRegistrationButton.TabIndex = 6;
            cancelRegistrationButton.Text = "Cancel Registration";
            cancelRegistrationButton.UseVisualStyleBackColor = true;
            cancelRegistrationButton.Click += CancelRegistrationButton_Click;
            // 
            // myRegistrationsGrid
            // 
            myRegistrationsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            myRegistrationsGrid.Location = new Point(37, 9);
            myRegistrationsGrid.Name = "myRegistrationsGrid";
            myRegistrationsGrid.RowHeadersWidth = 51;
            myRegistrationsGrid.Size = new Size(762, 592);
            myRegistrationsGrid.TabIndex = 4;
            // 
            // BrowseClassesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 698);
            Controls.Add(tabControl1);
            Name = "BrowseClassesForm";
            Text = "Browse Classes";
            tabControl1.ResumeLayout(false);
            viewClassesTab.ResumeLayout(false);
            viewClassesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)availableClassesGrid).EndInit();
            myRegistrationsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)myRegistrationsGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage viewClassesTab;
        private Button registerClassButton;
        private TextBox searchClassTextBox;
        private DataGridView availableClassesGrid;
        private TabPage myRegistrationsTab;
        private Button cancelRegistrationButton;
        private DataGridView myRegistrationsGrid;
    }
}