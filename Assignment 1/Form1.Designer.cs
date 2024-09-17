namespace Assignment_1
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
            summarizeButton = new Button();
            firstName = new Label();
            lastName = new Label();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            hoursWorked = new Label();
            hoursWorkedTextBox = new TextBox();
            clearButton = new Button();
            summarizeLabel = new Label();
            SuspendLayout();
            // 
            // summarizeButton
            // 
            summarizeButton.Location = new Point(45, 188);
            summarizeButton.Name = "summarizeButton";
            summarizeButton.Size = new Size(115, 40);
            summarizeButton.TabIndex = 6;
            summarizeButton.Tag = "";
            summarizeButton.Text = "&Summarize";
            summarizeButton.UseVisualStyleBackColor = true;
            summarizeButton.Click += summarizebutton_Click;
            // 
            // firstName
            // 
            firstName.AutoSize = true;
            firstName.Location = new Point(45, 40);
            firstName.Name = "firstName";
            firstName.Size = new Size(77, 20);
            firstName.TabIndex = 0;
            firstName.Text = "&First name";
            firstName.Click += firstname_Click;
            // 
            // lastName
            // 
            lastName.AutoSize = true;
            lastName.Location = new Point(269, 40);
            lastName.Name = "lastName";
            lastName.Size = new Size(76, 20);
            lastName.TabIndex = 2;
            lastName.Text = "&Last name";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(45, 63);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(151, 27);
            firstNameTextBox.TabIndex = 1;
            firstNameTextBox.Tag = "";
            firstNameTextBox.TextChanged += firstnametextBox_TextChanged;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(269, 63);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(167, 27);
            lastNameTextBox.TabIndex = 3;
            lastNameTextBox.Tag = "";
            // 
            // hoursWorked
            // 
            hoursWorked.AutoSize = true;
            hoursWorked.Location = new Point(536, 40);
            hoursWorked.Name = "hoursWorked";
            hoursWorked.Size = new Size(103, 20);
            hoursWorked.TabIndex = 4;
            hoursWorked.Text = "&Hours Worked";
            // 
            // hoursWorkedTextBox
            // 
            hoursWorkedTextBox.Location = new Point(536, 63);
            hoursWorkedTextBox.Name = "hoursWorkedTextBox";
            hoursWorkedTextBox.Size = new Size(178, 27);
            hoursWorkedTextBox.TabIndex = 5;
            hoursWorkedTextBox.Tag = "";
            hoursWorkedTextBox.TextChanged += textBox3_TextChanged;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(166, 188);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(117, 40);
            clearButton.TabIndex = 7;
            clearButton.Tag = "";
            clearButton.Text = "&Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearbutton_Click;
            // 
            // summarizeLabel
            // 
            summarizeLabel.BorderStyle = BorderStyle.FixedSingle;
            summarizeLabel.Location = new Point(104, 303);
            summarizeLabel.Name = "summarizeLabel";
            summarizeLabel.Size = new Size(586, 138);
            summarizeLabel.TabIndex = 8;
            summarizeLabel.TextAlign = ContentAlignment.MiddleCenter;
            summarizeLabel.Click += resultlabel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(summarizeLabel);
            Controls.Add(clearButton);
            Controls.Add(hoursWorkedTextBox);
            Controls.Add(hoursWorked);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(lastName);
            Controls.Add(firstName);
            Controls.Add(summarizeButton);
            Name = "Form1";
            Text = "Assignment 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button summarizeButton;
        private Label firstName;
        private Label lastName;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private Label hoursWorked;
        private TextBox hoursWorkedTextBox;
        private Button clearButton;
        private Label summarizeLabel;
    }
}
