using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FANTASY4YOU
{
    public partial class ChangeUsername : Form
    {
        DatabaseController connection = new DatabaseController();
        Thread Login;

        public ChangeUsername()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var parms = base.CreateParams;
                parms.Style &= ~0x02000000;  // Turn off WS_CLIPCHILDREN
                return parms;
            }
        }
        private void ChangeUsername_Load(object sender, EventArgs e)
        {
            CurrentUsername.Text = User.Username;
        }

        private void ChangeUsernameButton_Click(object sender, EventArgs e)
        {
            if (newUsernameTextBox.Text == "")
            {
                MessageBox.Show("Please input your new username!");
            }
            else if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Please input your password!");
            }
            else if (!Regex.IsMatch(newUsernameTextBox.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Username can be only letters!");
            }
            else if (newUsernameTextBox.Text.Length > 20)
            {
                MessageBox.Show("Username can be only 20 letters long!");
            }
            else if (passwordTextBox.Text != User.Password)
            {
                MessageBox.Show("Incorrect password!");
            }
            else if (User.Username == newUsernameTextBox.Text)
            {
                MessageBox.Show("This is already your username");
            }
            else if (connection.CheckIfUsernameExists(newUsernameTextBox.Text) == true && User.Username != newUsernameTextBox.Text)
            {
                MessageBox.Show("This username is already taken!");
            }
            else
            {
                connection.ChangeUsername(newUsernameTextBox.Text);
                Login = new Thread(OpenLoginForm);
                Login.SetApartmentState(ApartmentState.STA);
                Login.Start();

                Application.Exit();
            }

           
        }

        private void OpenLoginForm(object? obj)
        {
            Application.Run(new Login());
        }
    }
}
