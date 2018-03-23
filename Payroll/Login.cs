using System;
using System.Windows.Forms;

namespace Payroll
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(UsernameText.Text == "iTecCrawley" && PasswordText.Text == "admin")
            {
                Form1 form = new Payroll.Form1();
                form.Show();
                this.Hide();
            }
            else
            {
                ErrorLabel.Show();
            }
        }

        private void PasswordText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginButton.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void UsernameText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginButton.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            UsernameText.Select();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void PasswordText_Click(object sender, EventArgs e)
        {
            ErrorLabel.Hide();
        }

        private void UsernameText_Click(object sender, EventArgs e)
        {
            ErrorLabel.Hide();
        }

        private void UsernameText_TextChanged(object sender, EventArgs e)
        {
            ErrorLabel.Hide();
        }

        private void PasswordText_TextChanged(object sender, EventArgs e)
        {
            ErrorLabel.Hide();
        }
    }
}
