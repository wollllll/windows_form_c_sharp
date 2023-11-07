namespace WinFormsApp1
{
    partial class Form1
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
            addButton = new Button();
            editButton = new Button();
            button2 = new Button();
            dueDateTimePicker = new DateTimePicker();
            descriptionTextBox = new TextBox();
            tasksListBox = new ListBox();
            taskContentTextBox = new TextBox();
            inputDateTextBox = new TextBox();
            dueDateTextBox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Location = new Point(40, 88);
            addButton.Name = "addButton";
            addButton.Size = new Size(150, 46);
            addButton.TabIndex = 0;
            addButton.Text = "Create";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(196, 88);
            editButton.Name = "editButton";
            editButton.Size = new Size(150, 46);
            editButton.TabIndex = 1;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(352, 88);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 2;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += deleteButton_Click;
            // 
            // dueDateTimePicker
            // 
            dueDateTimePicker.Location = new Point(150, 382);
            dueDateTimePicker.Name = "dueDateTimePicker";
            dueDateTimePicker.Size = new Size(352, 39);
            dueDateTimePicker.TabIndex = 3;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(40, 157);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(462, 39);
            descriptionTextBox.TabIndex = 4;
            // 
            // tasksListBox
            // 
            tasksListBox.FormattingEnabled = true;
            tasksListBox.ItemHeight = 32;
            tasksListBox.Location = new Point(667, 108);
            tasksListBox.Name = "tasksListBox";
            tasksListBox.Size = new Size(575, 644);
            tasksListBox.TabIndex = 5;
            tasksListBox.SelectedIndexChanged += tasksListBox_SelectedIndexChanged;
            // 
            // taskContentTextBox
            // 
            taskContentTextBox.Location = new Point(40, 514);
            taskContentTextBox.Name = "taskContentTextBox";
            taskContentTextBox.Size = new Size(462, 39);
            taskContentTextBox.TabIndex = 6;
            // 
            // inputDateTextBox
            // 
            inputDateTextBox.Location = new Point(305, 569);
            inputDateTextBox.Name = "inputDateTextBox";
            inputDateTextBox.Size = new Size(197, 39);
            inputDateTextBox.TabIndex = 7;
            // 
            // dueDateTextBox
            // 
            dueDateTextBox.Location = new Point(305, 629);
            dueDateTextBox.Name = "dueDateTextBox";
            dueDateTextBox.Size = new Size(197, 39);
            dueDateTextBox.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(1092, 45);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 9;
            button1.Text = "Open";
            button1.UseVisualStyleBackColor = true;
            button1.Click += openSaveFolderButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1285, 805);
            Controls.Add(button1);
            Controls.Add(dueDateTextBox);
            Controls.Add(inputDateTextBox);
            Controls.Add(taskContentTextBox);
            Controls.Add(tasksListBox);
            Controls.Add(descriptionTextBox);
            Controls.Add(dueDateTimePicker);
            Controls.Add(button2);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addButton;
        private Button editButton;
        private Button button2;
        private DateTimePicker dueDateTimePicker;
        private TextBox descriptionTextBox;
        private ListBox tasksListBox;
        private TextBox taskContentTextBox;
        private TextBox inputDateTextBox;
        private TextBox dueDateTextBox;
        private Button button1;
    }
}