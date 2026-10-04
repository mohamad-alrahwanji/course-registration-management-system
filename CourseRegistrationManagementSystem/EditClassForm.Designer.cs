namespace CourseRegistrationManagementSystem
{
    partial class EditClassForm
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
            saveChangesButton = new Button();
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
            cancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)capacityNumeric).BeginInit();
            SuspendLayout();
            // 
            // friCheckBox
            // 
            friCheckBox.AutoSize = true;
            friCheckBox.Location = new Point(770, 485);
            friCheckBox.Margin = new Padding(4);
            friCheckBox.Name = "friCheckBox";
            friCheckBox.Size = new Size(57, 29);
            friCheckBox.TabIndex = 56;
            friCheckBox.Text = "Fri";
            friCheckBox.UseVisualStyleBackColor = true;
            // 
            // thuCheckBox
            // 
            thuCheckBox.AutoSize = true;
            thuCheckBox.Location = new Point(670, 485);
            thuCheckBox.Margin = new Padding(4);
            thuCheckBox.Name = "thuCheckBox";
            thuCheckBox.Size = new Size(67, 29);
            thuCheckBox.TabIndex = 55;
            thuCheckBox.Text = "Thu";
            thuCheckBox.UseVisualStyleBackColor = true;
            // 
            // wedCheckBox
            // 
            wedCheckBox.AutoSize = true;
            wedCheckBox.Location = new Point(570, 485);
            wedCheckBox.Margin = new Padding(4);
            wedCheckBox.Name = "wedCheckBox";
            wedCheckBox.Size = new Size(74, 29);
            wedCheckBox.TabIndex = 54;
            wedCheckBox.Text = "Wed";
            wedCheckBox.UseVisualStyleBackColor = true;
            // 
            // tueCheckBox
            // 
            tueCheckBox.AutoSize = true;
            tueCheckBox.Location = new Point(470, 485);
            tueCheckBox.Margin = new Padding(4);
            tueCheckBox.Name = "tueCheckBox";
            tueCheckBox.Size = new Size(66, 29);
            tueCheckBox.TabIndex = 53;
            tueCheckBox.Text = "Tue";
            tueCheckBox.UseVisualStyleBackColor = true;
            // 
            // monCheckBox
            // 
            monCheckBox.AutoSize = true;
            monCheckBox.Location = new Point(370, 485);
            monCheckBox.Margin = new Padding(4);
            monCheckBox.Name = "monCheckBox";
            monCheckBox.Size = new Size(75, 29);
            monCheckBox.TabIndex = 52;
            monCheckBox.Text = "Mon";
            monCheckBox.UseVisualStyleBackColor = true;
            // 
            // sunCheckBox
            // 
            sunCheckBox.AutoSize = true;
            sunCheckBox.Location = new Point(270, 485);
            sunCheckBox.Margin = new Padding(4);
            sunCheckBox.Name = "sunCheckBox";
            sunCheckBox.Size = new Size(68, 29);
            sunCheckBox.TabIndex = 51;
            sunCheckBox.Text = "Sun";
            sunCheckBox.UseVisualStyleBackColor = true;
            // 
            // satCheckBox
            // 
            satCheckBox.AutoSize = true;
            satCheckBox.Location = new Point(170, 485);
            satCheckBox.Margin = new Padding(4);
            satCheckBox.Name = "satCheckBox";
            satCheckBox.Size = new Size(63, 29);
            satCheckBox.TabIndex = 50;
            satCheckBox.Text = "Sat";
            satCheckBox.UseVisualStyleBackColor = true;
            // 
            // endTimePicker
            // 
            endTimePicker.CustomFormat = "   h:mm tt";
            endTimePicker.Format = DateTimePickerFormat.Custom;
            endTimePicker.Location = new Point(634, 568);
            endTimePicker.Margin = new Padding(4);
            endTimePicker.Name = "endTimePicker";
            endTimePicker.ShowUpDown = true;
            endTimePicker.Size = new Size(124, 31);
            endTimePicker.TabIndex = 49;
            endTimePicker.Value = new DateTime(2026, 9, 15, 10, 0, 0, 0);
            // 
            // startTimePicker
            // 
            startTimePicker.CustomFormat = "   h:mm tt";
            startTimePicker.Format = DateTimePickerFormat.Custom;
            startTimePicker.Location = new Point(162, 568);
            startTimePicker.Margin = new Padding(4);
            startTimePicker.Name = "startTimePicker";
            startTimePicker.ShowUpDown = true;
            startTimePicker.Size = new Size(124, 31);
            startTimePicker.TabIndex = 48;
            startTimePicker.Value = new DateTime(2026, 9, 15, 9, 0, 0, 0);
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(525, 574);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(85, 25);
            label10.TabIndex = 47;
            label10.Text = "End Time";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(38, 574);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(91, 25);
            label9.TabIndex = 46;
            label9.Text = "Start Time";
            // 
            // saveChangesButton
            // 
            saveChangesButton.Location = new Point(814, 681);
            saveChangesButton.Margin = new Padding(4);
            saveChangesButton.Name = "saveChangesButton";
            saveChangesButton.Size = new Size(152, 36);
            saveChangesButton.TabIndex = 45;
            saveChangesButton.Text = "Save Changes";
            saveChangesButton.UseVisualStyleBackColor = true;
            saveChangesButton.Click += saveChangesButton_Click;
            // 
            // isActiveCheckBox
            // 
            isActiveCheckBox.AutoSize = true;
            isActiveCheckBox.Checked = true;
            isActiveCheckBox.CheckState = CheckState.Checked;
            isActiveCheckBox.Location = new Point(170, 661);
            isActiveCheckBox.Margin = new Padding(4);
            isActiveCheckBox.Name = "isActiveCheckBox";
            isActiveCheckBox.Size = new Size(22, 21);
            isActiveCheckBox.TabIndex = 44;
            isActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // courseNameCombo
            // 
            courseNameCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            courseNameCombo.FormattingEnabled = true;
            courseNameCombo.Location = new Point(170, 136);
            courseNameCombo.Margin = new Padding(4);
            courseNameCombo.Name = "courseNameCombo";
            courseNameCombo.Size = new Size(335, 33);
            courseNameCombo.TabIndex = 43;
            // 
            // endDateTimePicker
            // 
            endDateTimePicker.Location = new Point(634, 395);
            endDateTimePicker.Margin = new Padding(4);
            endDateTimePicker.Name = "endDateTimePicker";
            endDateTimePicker.Size = new Size(304, 31);
            endDateTimePicker.TabIndex = 42;
            // 
            // startDateTimePicker
            // 
            startDateTimePicker.Location = new Point(170, 395);
            startDateTimePicker.Margin = new Padding(4);
            startDateTimePicker.Name = "startDateTimePicker";
            startDateTimePicker.Size = new Size(304, 31);
            startDateTimePicker.TabIndex = 41;
            // 
            // capacityNumeric
            // 
            capacityNumeric.Location = new Point(170, 308);
            capacityNumeric.Margin = new Padding(4);
            capacityNumeric.Name = "capacityNumeric";
            capacityNumeric.Size = new Size(188, 31);
            capacityNumeric.TabIndex = 40;
            // 
            // instructorTextBox
            // 
            instructorTextBox.Location = new Point(170, 221);
            instructorTextBox.Margin = new Padding(4);
            instructorTextBox.Name = "instructorTextBox";
            instructorTextBox.Size = new Size(335, 31);
            instructorTextBox.TabIndex = 39;
            // 
            // classNameTextBox
            // 
            classNameTextBox.Location = new Point(170, 48);
            classNameTextBox.Margin = new Padding(4);
            classNameTextBox.Name = "classNameTextBox";
            classNameTextBox.Size = new Size(335, 31);
            classNameTextBox.TabIndex = 38;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(525, 401);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(84, 25);
            label8.TabIndex = 37;
            label8.Text = "End Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 658);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(60, 25);
            label7.TabIndex = 36;
            label7.Text = "Active";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 486);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(51, 25);
            label6.TabIndex = 35;
            label6.Text = "Days";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 401);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(90, 25);
            label5.TabIndex = 34;
            label5.Text = "Start Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 310);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 33;
            label4.Text = "Capacity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 225);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 32;
            label3.Text = "Instructor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 140);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 31;
            label2.Text = "Course Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 51);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 30;
            label1.Text = "Class Name";
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(634, 681);
            cancelButton.Margin = new Padding(4);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(152, 36);
            cancelButton.TabIndex = 57;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // EditClassForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 752);
            Controls.Add(cancelButton);
            Controls.Add(friCheckBox);
            Controls.Add(thuCheckBox);
            Controls.Add(wedCheckBox);
            Controls.Add(tueCheckBox);
            Controls.Add(monCheckBox);
            Controls.Add(sunCheckBox);
            Controls.Add(satCheckBox);
            Controls.Add(endTimePicker);
            Controls.Add(startTimePicker);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(saveChangesButton);
            Controls.Add(isActiveCheckBox);
            Controls.Add(courseNameCombo);
            Controls.Add(endDateTimePicker);
            Controls.Add(startDateTimePicker);
            Controls.Add(capacityNumeric);
            Controls.Add(instructorTextBox);
            Controls.Add(classNameTextBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "EditClassForm";
            Text = "EditClassForm";
            ((System.ComponentModel.ISupportInitialize)capacityNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox friCheckBox;
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
        private Button saveChangesButton;
        private CheckBox isActiveCheckBox;
        private ComboBox courseNameCombo;
        private DateTimePicker endDateTimePicker;
        private DateTimePicker startDateTimePicker;
        private NumericUpDown capacityNumeric;
        private MaskedTextBox instructorTextBox;
        private MaskedTextBox classNameTextBox;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button cancelButton;
    }
}