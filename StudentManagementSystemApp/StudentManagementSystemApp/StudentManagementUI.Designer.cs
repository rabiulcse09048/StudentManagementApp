namespace StudentManagementSystemApp
{
    partial class StudentManagementUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.departmentSaveButton = new System.Windows.Forms.Button();
            this.departmentNameTextBox = new System.Windows.Forms.TextBox();
            this.departmentCodeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.studentSaveButton = new System.Windows.Forms.Button();
            this.departmentSaveComboBox = new System.Windows.Forms.ComboBox();
            this.studentEmailTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.studentRegNoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.studentShowButton = new System.Windows.Forms.Button();
            this.departmentShowComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.departmentSaveButton);
            this.groupBox1.Controls.Add(this.departmentNameTextBox);
            this.groupBox1.Controls.Add(this.departmentCodeTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Department Info";
            // 
            // departmentSaveButton
            // 
            this.departmentSaveButton.Location = new System.Drawing.Point(301, 74);
            this.departmentSaveButton.Name = "departmentSaveButton";
            this.departmentSaveButton.Size = new System.Drawing.Size(74, 23);
            this.departmentSaveButton.TabIndex = 3;
            this.departmentSaveButton.Text = "Save";
            this.departmentSaveButton.UseVisualStyleBackColor = true;
            this.departmentSaveButton.Click += new System.EventHandler(this.departmentSaveButton_Click);
            // 
            // departmentNameTextBox
            // 
            this.departmentNameTextBox.Location = new System.Drawing.Point(78, 45);
            this.departmentNameTextBox.Name = "departmentNameTextBox";
            this.departmentNameTextBox.Size = new System.Drawing.Size(299, 20);
            this.departmentNameTextBox.TabIndex = 2;
            // 
            // departmentCodeTextBox
            // 
            this.departmentCodeTextBox.Location = new System.Drawing.Point(78, 21);
            this.departmentCodeTextBox.Name = "departmentCodeTextBox";
            this.departmentCodeTextBox.Size = new System.Drawing.Size(193, 20);
            this.departmentCodeTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.studentSaveButton);
            this.groupBox2.Controls.Add(this.departmentSaveComboBox);
            this.groupBox2.Controls.Add(this.studentEmailTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.studentNameTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.studentRegNoTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 135);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student Info";
            // 
            // studentSaveButton
            // 
            this.studentSaveButton.Location = new System.Drawing.Point(292, 101);
            this.studentSaveButton.Name = "studentSaveButton";
            this.studentSaveButton.Size = new System.Drawing.Size(75, 23);
            this.studentSaveButton.TabIndex = 5;
            this.studentSaveButton.Text = "Save";
            this.studentSaveButton.UseVisualStyleBackColor = true;
            this.studentSaveButton.Click += new System.EventHandler(this.studentSaveButton_Click);
            // 
            // departmentSaveComboBox
            // 
            this.departmentSaveComboBox.FormattingEnabled = true;
            this.departmentSaveComboBox.Location = new System.Drawing.Point(78, 101);
            this.departmentSaveComboBox.Name = "departmentSaveComboBox";
            this.departmentSaveComboBox.Size = new System.Drawing.Size(190, 21);
            this.departmentSaveComboBox.TabIndex = 4;
            // 
            // studentEmailTextBox
            // 
            this.studentEmailTextBox.Location = new System.Drawing.Point(78, 71);
            this.studentEmailTextBox.Name = "studentEmailTextBox";
            this.studentEmailTextBox.Size = new System.Drawing.Size(301, 20);
            this.studentEmailTextBox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Department";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email";
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.Location = new System.Drawing.Point(78, 45);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(301, 20);
            this.studentNameTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name";
            // 
            // studentRegNoTextBox
            // 
            this.studentRegNoTextBox.Location = new System.Drawing.Point(78, 19);
            this.studentRegNoTextBox.Name = "studentRegNoTextBox";
            this.studentRegNoTextBox.Size = new System.Drawing.Size(190, 20);
            this.studentRegNoTextBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Reg No";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.studentShowButton);
            this.groupBox3.Controls.Add(this.departmentShowComboBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(12, 249);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(402, 59);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Student List";
            // 
            // studentShowButton
            // 
            this.studentShowButton.Location = new System.Drawing.Point(288, 23);
            this.studentShowButton.Name = "studentShowButton";
            this.studentShowButton.Size = new System.Drawing.Size(75, 23);
            this.studentShowButton.TabIndex = 1;
            this.studentShowButton.Text = "Show";
            this.studentShowButton.UseVisualStyleBackColor = true;
            this.studentShowButton.Click += new System.EventHandler(this.studentShowButton_Click);
            // 
            // departmentShowComboBox
            // 
            this.departmentShowComboBox.FormattingEnabled = true;
            this.departmentShowComboBox.Location = new System.Drawing.Point(78, 22);
            this.departmentShowComboBox.Name = "departmentShowComboBox";
            this.departmentShowComboBox.Size = new System.Drawing.Size(190, 21);
            this.departmentShowComboBox.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Department";
            // 
            // StudentManagementUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 316);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "StudentManagementUI";
            this.Text = "StudentManagementUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button departmentSaveButton;
        private System.Windows.Forms.TextBox departmentNameTextBox;
        private System.Windows.Forms.TextBox departmentCodeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button studentSaveButton;
        private System.Windows.Forms.ComboBox departmentSaveComboBox;
        private System.Windows.Forms.TextBox studentEmailTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox studentRegNoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button studentShowButton;
        private System.Windows.Forms.ComboBox departmentShowComboBox;
        private System.Windows.Forms.Label label7;
    }
}

