﻿namespace Payroll
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.EmployeeNameText = new System.Windows.Forms.TextBox();
            this.DepartmentText = new System.Windows.Forms.ComboBox();
            this.WeekChooser = new System.Windows.Forms.NumericUpDown();
            this.PayDateLabel = new System.Windows.Forms.Label();
            this.WeekLabel = new System.Windows.Forms.Label();
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.DepartmentLabel = new System.Windows.Forms.Label();
            this.HoursLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.GrossPayText = new System.Windows.Forms.TextBox();
            this.GrossPayLabel = new System.Windows.Forms.Label();
            this.DeductionsText = new System.Windows.Forms.TextBox();
            this.DeductionsLabel = new System.Windows.Forms.Label();
            this.NetPayLabel = new System.Windows.Forms.Label();
            this.NetPayText = new System.Windows.Forms.TextBox();
            this.CalcButton = new System.Windows.Forms.Button();
            this.ChooseDirectory = new System.Windows.Forms.Button();
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.DirectoryText = new System.Windows.Forms.TextBox();
            this.GenInvoice = new System.Windows.Forms.Button();
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            this.HoursWorked = new System.Windows.Forms.NumericUpDown();
            this.FormTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.EmptyError = new System.Windows.Forms.Label();
            this.InvoicesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WeekChooser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoursWorked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(69, 167);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(135, 20);
            this.DatePicker.TabIndex = 0;
            // 
            // EmployeeNameText
            // 
            this.EmployeeNameText.Location = new System.Drawing.Point(94, 58);
            this.EmployeeNameText.Name = "EmployeeNameText";
            this.EmployeeNameText.Size = new System.Drawing.Size(100, 20);
            this.EmployeeNameText.TabIndex = 2;
            this.EmployeeNameText.Text = "Enter name";
            this.EmployeeNameText.Click += new System.EventHandler(this.EmployeeNameText_Click);
            // 
            // DepartmentText
            // 
            this.DepartmentText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DepartmentText.FormattingEnabled = true;
            this.DepartmentText.Items.AddRange(new object[] {
            "Store Manager",
            "Sales Assistant",
            "Customer Service"});
            this.DepartmentText.Location = new System.Drawing.Point(83, 93);
            this.DepartmentText.Name = "DepartmentText";
            this.DepartmentText.Size = new System.Drawing.Size(121, 21);
            this.DepartmentText.TabIndex = 3;
            this.DepartmentText.Click += new System.EventHandler(this.DepartmentText_Click);
            // 
            // WeekChooser
            // 
            this.WeekChooser.Location = new System.Drawing.Point(63, 239);
            this.WeekChooser.Maximum = new decimal(new int[] {
            52,
            0,
            0,
            0});
            this.WeekChooser.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WeekChooser.Name = "WeekChooser";
            this.WeekChooser.Size = new System.Drawing.Size(120, 20);
            this.WeekChooser.TabIndex = 5;
            this.WeekChooser.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WeekChooser.Click += new System.EventHandler(this.WeekChooser_Click);
            // 
            // PayDateLabel
            // 
            this.PayDateLabel.AutoSize = true;
            this.PayDateLabel.Location = new System.Drawing.Point(12, 167);
            this.PayDateLabel.Name = "PayDateLabel";
            this.PayDateLabel.Size = new System.Drawing.Size(51, 13);
            this.PayDateLabel.TabIndex = 6;
            this.PayDateLabel.Text = "Pay Date";
            // 
            // WeekLabel
            // 
            this.WeekLabel.AutoSize = true;
            this.WeekLabel.Location = new System.Drawing.Point(21, 241);
            this.WeekLabel.Name = "WeekLabel";
            this.WeekLabel.Size = new System.Drawing.Size(36, 13);
            this.WeekLabel.TabIndex = 7;
            this.WeekLabel.Text = "Week";
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Location = new System.Drawing.Point(4, 61);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(84, 13);
            this.EmployeeNameLabel.TabIndex = 8;
            this.EmployeeNameLabel.Text = "Employee Name";
            // 
            // DepartmentLabel
            // 
            this.DepartmentLabel.AutoSize = true;
            this.DepartmentLabel.Location = new System.Drawing.Point(15, 96);
            this.DepartmentLabel.Name = "DepartmentLabel";
            this.DepartmentLabel.Size = new System.Drawing.Size(62, 13);
            this.DepartmentLabel.TabIndex = 9;
            this.DepartmentLabel.Text = "Department";
            // 
            // HoursLabel
            // 
            this.HoursLabel.AutoSize = true;
            this.HoursLabel.Location = new System.Drawing.Point(13, 205);
            this.HoursLabel.Name = "HoursLabel";
            this.HoursLabel.Size = new System.Drawing.Size(76, 13);
            this.HoursLabel.TabIndex = 10;
            this.HoursLabel.Text = "Hours Worked";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(560, 409);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 12;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(479, 409);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 13;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // GrossPayText
            // 
            this.GrossPayText.Location = new System.Drawing.Point(74, 309);
            this.GrossPayText.Name = "GrossPayText";
            this.GrossPayText.ReadOnly = true;
            this.GrossPayText.Size = new System.Drawing.Size(100, 20);
            this.GrossPayText.TabIndex = 15;
            // 
            // GrossPayLabel
            // 
            this.GrossPayLabel.AutoSize = true;
            this.GrossPayLabel.Location = new System.Drawing.Point(13, 312);
            this.GrossPayLabel.Name = "GrossPayLabel";
            this.GrossPayLabel.Size = new System.Drawing.Size(55, 13);
            this.GrossPayLabel.TabIndex = 14;
            this.GrossPayLabel.Text = "Gross Pay";
            // 
            // DeductionsText
            // 
            this.DeductionsText.Location = new System.Drawing.Point(74, 345);
            this.DeductionsText.Name = "DeductionsText";
            this.DeductionsText.ReadOnly = true;
            this.DeductionsText.Size = new System.Drawing.Size(100, 20);
            this.DeductionsText.TabIndex = 17;
            // 
            // DeductionsLabel
            // 
            this.DeductionsLabel.AutoSize = true;
            this.DeductionsLabel.Location = new System.Drawing.Point(7, 348);
            this.DeductionsLabel.Name = "DeductionsLabel";
            this.DeductionsLabel.Size = new System.Drawing.Size(61, 13);
            this.DeductionsLabel.TabIndex = 16;
            this.DeductionsLabel.Text = "Deductions";
            // 
            // NetPayLabel
            // 
            this.NetPayLabel.AutoSize = true;
            this.NetPayLabel.Location = new System.Drawing.Point(23, 382);
            this.NetPayLabel.Name = "NetPayLabel";
            this.NetPayLabel.Size = new System.Drawing.Size(45, 13);
            this.NetPayLabel.TabIndex = 18;
            this.NetPayLabel.Text = "Net Pay";
            // 
            // NetPayText
            // 
            this.NetPayText.Location = new System.Drawing.Point(74, 379);
            this.NetPayText.Name = "NetPayText";
            this.NetPayText.ReadOnly = true;
            this.NetPayText.Size = new System.Drawing.Size(100, 20);
            this.NetPayText.TabIndex = 19;
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(69, 275);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(75, 23);
            this.CalcButton.TabIndex = 20;
            this.CalcButton.Text = "Calculate";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // ChooseDirectory
            // 
            this.ChooseDirectory.Location = new System.Drawing.Point(441, 411);
            this.ChooseDirectory.Name = "ChooseDirectory";
            this.ChooseDirectory.Size = new System.Drawing.Size(22, 23);
            this.ChooseDirectory.TabIndex = 21;
            this.ChooseDirectory.Text = ":";
            this.ChooseDirectory.UseVisualStyleBackColor = true;
            this.ChooseDirectory.Click += new System.EventHandler(this.ChooseDirectory_Click);
            // 
            // DirectoryText
            // 
            this.DirectoryText.Location = new System.Drawing.Point(263, 411);
            this.DirectoryText.Name = "DirectoryText";
            this.DirectoryText.Size = new System.Drawing.Size(172, 20);
            this.DirectoryText.TabIndex = 22;
            this.DirectoryText.Text = "E:\\College Work\\Term 2\\Unit 14 - Event Driven Programming\\Assignment 1\\Upload\\Pro" +
    "grams\\C#\\Payroll\\Invoices";
            // 
            // GenInvoice
            // 
            this.GenInvoice.Location = new System.Drawing.Point(21, 411);
            this.GenInvoice.Name = "GenInvoice";
            this.GenInvoice.Size = new System.Drawing.Size(104, 23);
            this.GenInvoice.TabIndex = 23;
            this.GenInvoice.Text = "Generate Invoice";
            this.GenInvoice.UseVisualStyleBackColor = true;
            this.GenInvoice.Click += new System.EventHandler(this.GenInvoice_Click);
            // 
            // HoursWorked
            // 
            this.HoursWorked.Location = new System.Drawing.Point(94, 203);
            this.HoursWorked.Maximum = new decimal(new int[] {
            8760,
            0,
            0,
            0});
            this.HoursWorked.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HoursWorked.Name = "HoursWorked";
            this.HoursWorked.Size = new System.Drawing.Size(120, 20);
            this.HoursWorked.TabIndex = 24;
            this.HoursWorked.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HoursWorked.Click += new System.EventHandler(this.HoursWorked_Click);
            // 
            // FormTitle
            // 
            this.FormTitle.AutoSize = true;
            this.FormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTitle.Location = new System.Drawing.Point(233, 9);
            this.FormTitle.Name = "FormTitle";
            this.FormTitle.Size = new System.Drawing.Size(220, 39);
            this.FormTitle.TabIndex = 25;
            this.FormTitle.Text = "iTecCrawley";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Employee Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Finance Details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(263, 167);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 114);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(560, 9);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 23);
            this.LogoutButton.TabIndex = 29;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // EmptyError
            // 
            this.EmptyError.AutoSize = true;
            this.EmptyError.BackColor = System.Drawing.SystemColors.Control;
            this.EmptyError.ForeColor = System.Drawing.Color.Red;
            this.EmptyError.Location = new System.Drawing.Point(131, 414);
            this.EmptyError.Name = "EmptyError";
            this.EmptyError.Size = new System.Drawing.Size(111, 13);
            this.EmptyError.TabIndex = 30;
            this.EmptyError.Text = "There are empty fields";
            this.EmptyError.Visible = false;
            // 
            // InvoicesButton
            // 
            this.InvoicesButton.Location = new System.Drawing.Point(470, 9);
            this.InvoicesButton.Name = "InvoicesButton";
            this.InvoicesButton.Size = new System.Drawing.Size(75, 23);
            this.InvoicesButton.TabIndex = 31;
            this.InvoicesButton.Text = "Invoices";
            this.InvoicesButton.UseVisualStyleBackColor = true;
            this.InvoicesButton.Click += new System.EventHandler(this.InvoicesButton_Click);
            // 
            // Form1
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(647, 444);
            this.Controls.Add(this.InvoicesButton);
            this.Controls.Add(this.EmptyError);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FormTitle);
            this.Controls.Add(this.HoursWorked);
            this.Controls.Add(this.GenInvoice);
            this.Controls.Add(this.DirectoryText);
            this.Controls.Add(this.ChooseDirectory);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.NetPayText);
            this.Controls.Add(this.NetPayLabel);
            this.Controls.Add(this.DeductionsText);
            this.Controls.Add(this.DeductionsLabel);
            this.Controls.Add(this.GrossPayText);
            this.Controls.Add(this.GrossPayLabel);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.HoursLabel);
            this.Controls.Add(this.DepartmentLabel);
            this.Controls.Add(this.EmployeeNameLabel);
            this.Controls.Add(this.WeekLabel);
            this.Controls.Add(this.PayDateLabel);
            this.Controls.Add(this.WeekChooser);
            this.Controls.Add(this.DepartmentText);
            this.Controls.Add(this.EmployeeNameText);
            this.Controls.Add(this.DatePicker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "iTecCrawley Invoice";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WeekChooser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoursWorked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmployeeNameText;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.ComboBox DepartmentText;
        private System.Windows.Forms.NumericUpDown WeekChooser;
        private System.Windows.Forms.Label PayDateLabel;
        private System.Windows.Forms.Label WeekLabel;
        private System.Windows.Forms.Label EmployeeNameLabel;
        private System.Windows.Forms.Label DepartmentLabel;
        private System.Windows.Forms.Label HoursLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.TextBox GrossPayText;
        private System.Windows.Forms.Label GrossPayLabel;
        private System.Windows.Forms.TextBox DeductionsText;
        private System.Windows.Forms.Label DeductionsLabel;
        private System.Windows.Forms.Label NetPayLabel;
        private System.Windows.Forms.TextBox NetPayText;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.Button ChooseDirectory;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
        private System.Windows.Forms.TextBox DirectoryText;
        private System.Windows.Forms.Button GenInvoice;
        private System.Windows.Forms.SaveFileDialog SaveFile;
        private System.Windows.Forms.NumericUpDown HoursWorked;
        private System.Windows.Forms.Label FormTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Label EmptyError;
        private System.Windows.Forms.Button InvoicesButton;
    }
}

