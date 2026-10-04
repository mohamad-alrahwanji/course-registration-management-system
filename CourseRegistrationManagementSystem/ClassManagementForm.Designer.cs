namespace CourseRegistrationManagementSystem
{
    partial class ClassManagementForm
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
            deleteClassButton = new Button();
            editClassButton = new Button();
            classSearchTextBox = new TextBox();
            classGridView = new DataGridView();
            addClassTab = new TabPage();
            friCheckBox = new CheckBox();
            thuCheckBox = new CheckBox();
            wedCheckBox = new CheckBox();
            tueCheckBox = new CheckBox();
            monCheckBox = new CheckBox();
            sunCheckBox = new CheckBox();
            satCheckBox = new CheckBox();
            endTimePicker = new DateTimePicker();
            startTimePicker = new DateTimePicker();
            label10 = new Label();
            label9 = new Label();
            addClassButton = new Button();
            isActiveCheckBox = new CheckBox();
            courseNameCombo = new ComboBox();
            endDateTimePicker = new DateTimePicker();
            startDateTimePicker = new DateTimePicker();
            capacityNumeric = new NumericUpDown();
            instructorTextBox = new MaskedTextBox();
            classNameTextBox = new MaskedTextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabControl1.SuspendLayout();
            viewClassesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)classGridView).BeginInit();
            addClassTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)capacityNumeric).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(viewClassesTab);
            tabControl1.Controls.Add(addClassTab);
            tabControl1.Location = new Point(0, -2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(831, 635);
            tabControl1.TabIndex = 0;
            // 
            // viewClassesTab
            // 
            viewClassesTab.Controls.Add(deleteClassButton);
            viewClassesTab.Controls.Add(editClassButton);
            viewClassesTab.Controls.Add(classSearchTextBox);
            viewClassesTab.Controls.Add(classGridView);
            viewClassesTab.Location = new Point(4, 29);
            viewClassesTab.Name = "viewClassesTab";
            viewClassesTab.Padding = new Padding(3, 3, 3, 3);
            viewClassesTab.Size = new Size(823, 602);
            viewClassesTab.TabIndex = 0;
            viewClassesTab.Text = "View Classes";
            viewClassesTab.UseVisualStyleBackColor = true;
            // 
            // deleteClassButton
            // 
            deleteClassButton.Location = new Point(658, 546);
            deleteClassButton.Name = "deleteClassButton";
            deleteClassButton.Size = new Size(125, 29);
            deleteClassButton.TabIndex = 3;
            deleteClassButton.Text = "Delete Class";
            deleteClassButton.UseVisualStyleBackColor = true;
            deleteClassButton.Click += DeleteClassButton_Click;
            // 
            // editClassButton
            // 
            editClassButton.Location = new Point(509, 546);
            editClassButton.Name = "editClassButton";
            editClassButton.Size = new Size(125, 29);
            editClassButton.TabIndex = 2;
            editClassButton.Text = "Edit Class";
            editClassButton.UseVisualStyleBackColor = true;
            editClassButton.Click += editClassButton_Click;
            // 
            // classSearchTextBox
            // 
            classSearchTextBox.Location = new Point(35, 547);
            classSearchTextBox.Name = "classSearchTextBox";
            classSearchTextBox.PlaceholderText = "Search by Class Name or Course Name...";
            classSearchTextBox.Size = new Size(295, 27);
            classSearchTextBox.TabIndex = 1;
            classSearchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // classGridView
            // 
            classGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            classGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            classGridView.Location = new Point(35, 16);
            classGridView.Name = "classGridView";
            classGridView.RowHeadersWidth = 51;
            classGridView.Size = new Size(748, 505);
            classGridView.TabIndex = 0;
            // 
            // addClassTab
            // 
            addClassTab.Controls.Add(friCheckBox);
            addClassTab.Controls.Add(thuCheckBox);
            addClassTab.Controls.Add(wedCheckBox);
            addClassTab.Controls.Add(tueCheckBox);
            addClassTab.Controls.Add(monCheckBox);
            addClassTab.Controls.Add(sunCheckBox);
            addClassTab.Controls.Add(satCheckBox);
            addClassTab.Controls.Add(endTimePicker);
            addClassTab.Controls.Add(startTimePicker);
            addClassTab.Controls.Add(label10);
            addClassTab.Controls.Add(label9);
            addClassTab.Controls.Add(addClassButton);
            addClassTab.Controls.Add(isActiveCheckBox);
            addClassTab.Controls.Add(courseNameCombo);
            addClassTab.Controls.Add(endDateTimePicker);
            addClassTab.Controls.Add(startDateTimePicker);
            addClassTab.Controls.Add(capacityNumeric);
            addClassTab.Controls.Add(instructorTextBox);
            addClassTab.Controls.Add(classNameTextBox);
            addClassTab.Controls.Add(label8);
            addClassTab.Controls.Add(label7);
            addClassTab.Controls.Add(label6);
            addClassTab.Controls.Add(label5);
            addClassTab.Controls.Add(label4);
            addClassTab.Controls.Add(label3);
            addClassTab.Controls.Add(label2);
            addClassTab.Controls.Add(label1);
            addClassTab.Location = new Point(4, 29);
            addClassTab.Name = "addClassTab";
            addClassTab.Padding = new Padding(3, 3, 3, 3);
            addClassTab.Size = new Size(823, 602);
            addClassTab.TabIndex = 1;
            addClassTab.Text = "Add Class";
            addClassTab.UseVisualStyleBackColor = true;
            // 
            // friCheckBox
            // 
            friCheckBox.AutoSize = true;
            friCheckBox.Location = new Point(622, 383);
            friCheckBox.Name = "friCheckBox";
            friCheckBox.Size = new Size(47, 24);
            friCheckBox.TabIndex = 29;
            friCheckBox.Text = "Fri";
            friCheckBox.UseVisualStyleBackColor = true;
            // 
            // thuCheckBox
            // 
            thuCheckBox.AutoSize = true;
            thuCheckBox.Location = new Point(542, 383);
            thuCheckBox.Name = "thuCheckBox";
            thuCheckBox.Size = new Size(55, 24);
            thuCheckBox.TabIndex = 28;
            thuCheckBox.Text = "Thu";
            thuCheckBox.UseVisualStyleBackColor = true;
            // 
            // wedCheckBox
            // 
            wedCheckBox.AutoSize = true;
            wedCheckBox.Location = new Point(462, 383);
            wedCheckBox.Name = "wedCheckBox";
            wedCheckBox.Size = new Size(61, 24);
            wedCheckBox.TabIndex = 27;
            wedCheckBox.Text = "Wed";
            wedCheckBox.UseVisualStyleBackColor = true;
            // 
            // tueCheckBox
            // 
            tueCheckBox.AutoSize = true;
            tueCheckBox.Location = new Point(382, 383);
            tueCheckBox.Name = "tueCheckBox";
            tueCheckBox.Size = new Size(55, 24);
            tueCheckBox.TabIndex = 25;
            tueCheckBox.Text = "Tue";
            tueCheckBox.UseVisualStyleBackColor = true;
            // 
            // monCheckBox
            // 
            monCheckBox.AutoSize = true;
            monCheckBox.Location = new Point(302, 383);
            monCheckBox.Name = "monCheckBox";
            monCheckBox.Size = new Size(61, 24);
            monCheckBox.TabIndex = 24;
            monCheckBox.Text = "Mon";
            monCheckBox.UseVisualStyleBackColor = true;
            // 
            // sunCheckBox
            // 
            sunCheckBox.AutoSize = true;
            sunCheckBox.Location = new Point(222, 383);
            sunCheckBox.Name = "sunCheckBox";
            sunCheckBox.Size = new Size(55, 24);
            sunCheckBox.TabIndex = 23;
            sunCheckBox.Text = "Sun";
            sunCheckBox.UseVisualStyleBackColor = true;
            // 
            // satCheckBox
            // 
            satCheckBox.AutoSize = true;
            satCheckBox.Location = new Point(142, 383);
            satCheckBox.Name = "satCheckBox";
            satCheckBox.Size = new Size(52, 24);
            satCheckBox.TabIndex = 22;
            satCheckBox.Text = "Sat";
            satCheckBox.UseVisualStyleBackColor = true;
            // 
            // endTimePicker
            // 
            endTimePicker.CustomFormat = "   h:mm tt";
            endTimePicker.Format = DateTimePickerFormat.Custom;
            endTimePicker.Location = new Point(513, 449);
            endTimePicker.Name = "endTimePicker";
            endTimePicker.ShowUpDown = true;
            endTimePicker.Size = new Size(100, 27);
            endTimePicker.TabIndex = 21;
            endTimePicker.Value = new DateTime(2026, 9, 15, 10, 0, 0, 0);
            // 
            // startTimePicker
            // 
            startTimePicker.CustomFormat = "   h:mm tt";
            startTimePicker.Format = DateTimePickerFormat.Custom;
            startTimePicker.Location = new Point(136, 449);
            startTimePicker.Name = "startTimePicker";
            startTimePicker.ShowUpDown = true;
            startTimePicker.Size = new Size(100, 27);
            startTimePicker.TabIndex = 20;
            startTimePicker.Value = new DateTime(2026, 9, 15, 9, 0, 0, 0);
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(426, 454);
            label10.Name = "label10";
            label10.Size = new Size(71, 20);
            label10.TabIndex = 19;
            label10.Text = "End Time";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(36, 454);
            label9.Name = "label9";
            label9.Size = new Size(77, 20);
            label9.TabIndex = 18;
            label9.Text = "Start Time";
            // 
            // addClassButton
            // 
            addClassButton.Location = new Point(683, 532);
            addClassButton.Name = "addClassButton";
            addClassButton.Size = new Size(94, 29);
            addClassButton.TabIndex = 17;
            addClassButton.Text = "Add Class";
            addClassButton.UseVisualStyleBackColor = true;
            addClassButton.Click += AddClassButton_Click;
            // 
            // isActiveCheckBox
            // 
            isActiveCheckBox.AutoSize = true;
            isActiveCheckBox.Checked = true;
            isActiveCheckBox.CheckState = CheckState.Checked;
            isActiveCheckBox.Location = new Point(142, 524);
            isActiveCheckBox.Name = "isActiveCheckBox";
            isActiveCheckBox.Size = new Size(18, 17);
            isActiveCheckBox.TabIndex = 16;
            isActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // courseNameCombo
            // 
            courseNameCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            courseNameCombo.FormattingEnabled = true;
            courseNameCombo.Location = new Point(142, 104);
            courseNameCombo.Name = "courseNameCombo";
            courseNameCombo.Size = new Size(269, 28);
            courseNameCombo.TabIndex = 15;
            // 
            // endDateTimePicker
            // 
            endDateTimePicker.Location = new Point(513, 311);
            endDateTimePicker.Name = "endDateTimePicker";
            endDateTimePicker.Size = new Size(244, 27);
            endDateTimePicker.TabIndex = 13;
            // 
            // startDateTimePicker
            // 
            startDateTimePicker.Location = new Point(142, 311);
            startDateTimePicker.Name = "startDateTimePicker";
            startDateTimePicker.Size = new Size(244, 27);
            startDateTimePicker.TabIndex = 12;
            // 
            // capacityNumeric
            // 
            capacityNumeric.Location = new Point(142, 241);
            capacityNumeric.Name = "capacityNumeric";
            capacityNumeric.Size = new Size(150, 27);
            capacityNumeric.TabIndex = 11;
            // 
            // instructorTextBox
            // 
            instructorTextBox.Location = new Point(142, 172);
            instructorTextBox.Name = "instructorTextBox";
            instructorTextBox.Size = new Size(269, 27);
            instructorTextBox.TabIndex = 10;
            // 
            // classNameTextBox
            // 
            classNameTextBox.Location = new Point(142, 33);
            classNameTextBox.Name = "classNameTextBox";
            classNameTextBox.Size = new Size(269, 27);
            classNameTextBox.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(426, 316);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 7;
            label8.Text = "End Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 521);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 6;
            label7.Text = "Active";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 384);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 5;
            label6.Text = "Days";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 316);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 4;
            label5.Text = "Start Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 243);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 3;
            label4.Text = "Capacity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 175);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 2;
            label3.Text = "Instructor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 107);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 1;
            label2.Text = "Course Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 36);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 0;
            label1.Text = "Class Name";
            // 
            // ClassManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 634);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ClassManagementForm";
            Text = "ClassManagementForm";
            tabControl1.ResumeLayout(false);
            viewClassesTab.ResumeLayout(false);
            viewClassesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)classGridView).EndInit();
            addClassTab.ResumeLayout(false);
            addClassTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)capacityNumeric).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage viewClassesTab;
        private TabPage addClassTab;
        private Button deleteClassButton;
        private Button editClassButton;
        private TextBox classSearchTextBox;
        private DataGridView classGridView;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker endDateTimePicker;
        private DateTimePicker startDateTimePicker;
        private NumericUpDown capacityNumeric;
        private MaskedTextBox instructorTextBox;
        private MaskedTextBox classNameTextBox;
        private Label label8;
        private Button addClassButton;
        private CheckBox isActiveCheckBox;
        private ComboBox courseNameCombo;
        private CheckBox thuCheckBox;
        private CheckBox wedCheckBox;
        private CheckBox tueCheckBox;
        private CheckBox monCheckBox;
        private CheckBox sunCheckBox;
        private CheckBox satCheckBox;
        private DateTimePicker endTimePicker;
        private DateTimePicker startTimePicker;
        private Label label10;
        private Label label9;
        private CheckBox friCheckBox;
    }
}