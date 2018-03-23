using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Payroll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string directory;
        int grosspay;
        double finalpay;
        int hours;
        string date;
        int weeks;
        string employeename;
        string department;

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            EmptyError.Hide();
            hours = (int)HoursWorked.Value;
            grosspay = hours * 12;
            GrossPayText.Text = "£" + grosspay.ToString();
            finalpay = grosspay * 0.72;
            DeductionsText.Text = "£" + (grosspay - finalpay).ToString();
            NetPayText.Text = "£" + finalpay.ToString();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            HoursWorked.Value = 1;
            DepartmentText.SelectedIndex = -1;
            EmployeeNameText.Text = "Enter name";
            WeekChooser.Value = 1;
            DatePicker.ResetText();
            GrossPayText.Clear();
            DeductionsText.Clear();
            NetPayText.Clear();
        }

        private void ChooseDirectory_Click(object sender, EventArgs e)
        {
            if (FolderBrowser.ShowDialog() == DialogResult.OK)
            {
                DirectoryText.Text = FolderBrowser.SelectedPath;
                directory = DirectoryText.Text;
            }
        }

        private void GenInvoice_Click(object sender, EventArgs e)
        {
            if (EmployeeNameText.Text != "" && DepartmentText.Text != "" && GrossPayText.Text != "" && DeductionsText.Text != "" && NetPayText.Text != "")
            {
                EmptyError.Hide();
                employeename = EmployeeNameText.Text;
                date = DatePicker.Text;
                weeks = (int)WeekChooser.Value;
                department = DepartmentText.Text;
                hours = (int)HoursWorked.Value;
                directory = DirectoryText.Text;
                if(System.IO.Directory.Exists(directory))
                {
                    string path = directory + @"\" + employeename + @" Invoice.txt";
                    if (!System.IO.File.Exists(path))
                    {
                        string[] createText = {"iTecCrawley Invoice",
                                           "--------------------",
                                           "Name: " + employeename,
                                           "Department: " + department,
                                           "--------------------",
                                           "Date of Pay: " + date.ToString(),
                                           "Week Number: " + weeks.ToString(),
                                           "Hours Worked: " + hours.ToString(),
                                           "--------------------",
                                           "Gross Pay: " + GrossPayText.Text,
                                           "Deductions: " + DeductionsText.Text,
                                           "Net Pay: " + NetPayText.Text,
                                           "--------------------"};
                        System.IO.File.WriteAllLines(path, createText);
                        MessageBox.Show("An invoice has been created for " + employeename);
                    }
                    else
                    {
                        MessageBox.Show("An invoice for " + employeename + " already exists");
                    }
                }
                else
                {
                    MessageBox.Show("That directory does not exist!");
                }
            }
            else
            {
                EmptyError.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            EmployeeNameText.Select();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void InvoicesButton_Click(object sender, EventArgs e)
        {
            directory = DirectoryText.Text;
            if (System.IO.Directory.Exists(directory))
            {
                Process.Start(directory);
            }
            else
            {
                MessageBox.Show("That directory does not exist!");
            }
        }

        private void EmployeeNameText_Click(object sender, EventArgs e)
        {
            EmployeeNameText.Text = "";
            EmptyError.Hide();
        }

        private void DepartmentText_Click(object sender, EventArgs e)
        {
            EmptyError.Hide();
        }

        private void HoursWorked_Click(object sender, EventArgs e)
        {
            EmptyError.Hide();
        }

        private void WeekChooser_Click(object sender, EventArgs e)
        {
            EmptyError.Hide();
        }
    }
}
