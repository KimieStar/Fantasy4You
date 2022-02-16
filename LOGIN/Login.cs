using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using LOGIC;
using MAIN_INTERFACE;
using WELCOME;
using REGISTER;
using LOGINSETTINGS;

namespace Fantasy4You
{
    public partial class Login : Form


    {
        Logic log1 = new Logic();
        UserInfo uinfo = new UserInfo();
        UserInfo1 uinfo1 = new UserInfo1();
        WelcomeScreen welc = new WelcomeScreen();
        MainInterface mainInterface = new MainInterface();
        Register register = new Register();
        LoginSettings LoginSettings = new LoginSettings();

        Thread WelcomeScreen;
        Thread Register;
        Thread loginsettings;
        string getusername;
        string getpassword;
        bool checkCredentialsExist;



        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


            //string list = string.Join("\n", log1.RetrieveList().Select(l => string.Join(",", l)));
            string firstName = log1.firstName();

            label1.Text = firstName;
            //label1.Text = "hi";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkCredentialsExist = log1.CredentialsExist();
            if (checkCredentialsExist == true)
            {
                string getuid = log1.ReadUsername(getusername);
                UsernameTextbox.Text = getuid;

                string getpwd = log1.ReadPassword(getpassword);
                PasswordTextbox.Text = getpwd;
            }
            else
            {
                UsernameTextbox.Text = null;
                PasswordTextbox.Text = null;
            }
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
            bool chk = false;

            if (UsernameTextbox.Text == "" || PasswordTextbox.Text == "")
            {
                MessageBox.Show("Please fill in your credentials");

            }

            else if (UsernameTextbox.Text != "" || PasswordTextbox.Text != "")
            {
                LoggingInLabel.Visible = true;
                if (log1.CheckName(usr, pwd, chk) == true)
                {

                    if (checkBox1.Checked == true)
                    {
                        log1.SaveCredentials(usr, pwd);
                    }
                    else
                    {
                        string no;
                    }

                    MessageBox.Show("Login successful");
                    log1.SaveUsername(usr);
                    log1.CloseConnection();
                    WelcomeScreen = new Thread(OpenWelcomeScreen);
                    WelcomeScreen.SetApartmentState(ApartmentState.STA);
                    WelcomeScreen.Start();
                    this.Close();
                }

                else
                {
                    log1.CloseConnection();
                    LoggingInLabel.Visible = false;
                    MessageBox.Show("Invalid Credentials");

                }
            }
        }

        private void OpenWelcomeScreen(object? obj)
        {
            Application.Run(new WelcomeScreen());
        }

        private void label5_Click(object sender, EventArgs e)
        {

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

        //private void OpenLoginSettings(object? obj)
        //{
        //    Application.Run(new LoginSettings());
        //}
    }
       
}