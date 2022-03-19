using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using FANTASY4YOU;
using System.Runtime.InteropServices;

namespace FANTASY4YOU
{
    public partial class Login : Form


    {

        LogicController logic = new LogicController();
        LoginSettings LoginSettings = new LoginSettings();
        DatabaseController connection = new DatabaseController();
        UserFrogotPassword forgotPassword = new UserFrogotPassword();
        Thread Register;
        Thread MainInterface;
        Thread Welcome;
        bool checkCredentialsExist;
        protected override CreateParams CreateParams
        {
            get
            {
                var parms = base.CreateParams;
                parms.Style &= ~0x02000000;  // Turn off WS_CLIPCHILDREN
                return parms;
            }
        }

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
            checkCredentialsExist = logic.CheckIfCredentialsFileExist();
            if (checkCredentialsExist == true)
            {
                string getUsername = logic.ReadUsernameFromCredentialsFile();
                UsernameTextbox.Text = getUsername;

                string getPassword = logic.ReadPasswordFromCredentialsFile();
                PasswordTextbox.Text = getPassword;
            }
            else
            {
                UsernameTextbox.Text = null;
                PasswordTextbox.Text = null;
            }


        }

        private void ShowPassword_Click(object sender, EventArgs e)
        {
            PasswordTextbox.UseSystemPasswordChar = false;
            ShowPassword.Visible = false;
            HidePassword.Visible = true;


        }

        private void HidePassword_Click(object sender, EventArgs e)
        {
            PasswordTextbox.UseSystemPasswordChar = true;
            ShowPassword.Visible = true;
            HidePassword.Visible = false;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            


            string usr = UsernameTextbox.Text;
            string pwd = PasswordTextbox.Text;
            
            

            if (UsernameTextbox.Text == "" || PasswordTextbox.Text == "")
            {
                MessageBox.Show("Please fill in your credentials");

            }
            
            else if (UsernameTextbox.Text != "" || PasswordTextbox.Text != "")
            {
                
                PleaseWaitLabel.Visible = true;
                if (connection.CheckUserCredentials(usr, pwd) == true)
                {

                    if (RememberMeLabel.Checked == true)
                    {
                        logic.SaveCredentialsToFile(usr, pwd);
                    }
                    User.Username = usr;
                    User.Password = pwd;
                    MessageBox.Show("Login successful");

                    if (connection.SelectIsUserNew() == true)
                    {
                        connection.UpdateIsUserNew();
                        Welcome = new Thread(OpenWelcomeScreen);
                        Welcome.SetApartmentState(ApartmentState.STA);
                        Welcome.Start();
                    }
                    else if (connection.SelectIsUserNew() == false)
                    {
                       MainInterface = new Thread(OpenMainInterface);
                       MainInterface.SetApartmentState(ApartmentState.STA);
                       MainInterface.Start();
                    }
                    
                    
                    
                    this.Close();
                }

                else
                {
                    
                    PleaseWaitLabel.Visible = false;
                    MessageBox.Show("Invalid Credentials");

                }
            }
        }

        private void OpenMainInterface(object? obj)
        {
            Application.Run(new MainInterface());
        }
        private void OpenWelcomeScreen(object? obj)
        {
            Application.Run(new WelcomeScreen());
        }

        private void DontHaveAnAccountLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register = new Thread(OpenRegisterForm);
            Register.SetApartmentState(ApartmentState.STA);
            Register.Start();
            
        }

        private void OpenRegisterForm(object? obj)
        {
            Application.Run(new Register());
        }

        private void RefreshFormButton_Click(object sender, EventArgs e)
        {
            checkCredentialsExist = logic.CheckIfCredentialsFileExist();
            if (checkCredentialsExist == true)
            {
                string getUsername = logic.ReadUsernameFromCredentialsFile();
                UsernameTextbox.Text = getUsername;

                string getPassword = logic.ReadPasswordFromCredentialsFile();
                PasswordTextbox.Text = getPassword;
            }
            else
            {
                UsernameTextbox.Text = null;
                PasswordTextbox.Text = null;
            }
        }

        private void LoginSettingsButton_Click(object sender, EventArgs e)
        {
            LoginSettings.ShowDialog();
        }

        private void forgotPasswordButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgotPassword.ShowDialog();
        }
    }

    
}