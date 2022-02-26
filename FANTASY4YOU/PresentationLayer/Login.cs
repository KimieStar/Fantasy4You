using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using FANTASY4YOU;

namespace FANTASY4YOU
{
    public partial class Login : Form


    {
        Logic logic = new Logic();
        // LoginSettings LoginSettings = new LoginSettings();
        LoginSettings LoginSettings = new LoginSettings();
        Thread WelcomeScreen;
        Thread Register;
        bool checkCredentialsExist;



        public Login()
        {
            InitializeComponent();
            
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
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

            label1.BackColor = Color.FromArgb(125, Color.Black);
            label2.BackColor = Color.FromArgb(125, Color.Black);
            label3.BackColor = Color.FromArgb(125, Color.Black);
            checkBox1.BackColor = Color.FromArgb(125, Color.Black);
            DontHaveAnAccountLabel.BackColor = Color.FromArgb(125, Color.Black);
            pictureBox1.BackColor = Color.FromArgb(125, Color.Black);
            label4.BackColor = Color.FromArgb(125, Color.Black);
            LoggingInLabel.BackColor = Color.FromArgb(125, Color.Black);
            LoginButton.BackColor = Color.FromArgb(125, Color.Black);
            LoginButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(125, Color.Black);
            

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PasswordTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsernameTextbox_TextChanged(object sender, EventArgs e)
        {

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
                LoggingInLabel.Visible = true;
                if (logic.CheckUserCredentials(usr, pwd) == true)
                {

                    if (checkBox1.Checked == true)
                    {
                        logic.SaveCredentialsToFile(usr, pwd);
                    }

                    MessageBox.Show("Login successful");
                    logic.SaveUsernameToFile(usr);
                    WelcomeScreen = new Thread(OpenWelcomeScreen);
                    WelcomeScreen.SetApartmentState(ApartmentState.STA);
                    WelcomeScreen.Start();
                    this.Close();
                }

                else
                {
                    
                    LoggingInLabel.Visible = false;
                    MessageBox.Show("Invalid Credentials");

                }
            }
        }

        private void OpenWelcomeScreen(object? obj)
        {
            Application.Run(new WelcomeScreen());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
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
            Form1_Load(sender, EventArgs.Empty);
        }

        private void LoginSettingsButton_Click(object sender, EventArgs e)
        {
            //loginsettings = new Thread(OpenLoginSettings);
            //loginsettings.SetApartmentState(ApartmentState.STA);
            //loginsettings.Start();
            
            LoginSettings.ShowDialog();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        //private void OpenLoginSettings(object? obj)
        //{
        //    Application.Run(new LoginSettings());
        //}
    }
       
}