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
        // LoginSettings LoginSettings = new LoginSettings();
        LoginSettings LoginSettings = new LoginSettings();
        DatabaseController connection = new DatabaseController();
        Thread Register;
        Thread MainInterface;
        Thread Welcome;
        WelcomeScreen welcomeScreen = new WelcomeScreen();
        bool checkCredentialsExist;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public Login()
        {
            InitializeComponent();
            //connection.OpenCon();
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

           
            LoginPanel.BackColor = Color.FromArgb(125, Color.Black);
            WindowTopBar.BackColor = Color.FromArgb(165, Color.Black);
            CloseHelperPannel2.BackColor = Color.Transparent;
            CloseHelperPannel1.BackColor = Color.Transparent;


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
                if (logic.CheckUserCredentials(usr, pwd) == true)
                {

                    if (checkBox1.Checked == true)
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
           //RefreshButton1.Enabled = false;
           //RefreshButton1.Text = "Wait";
           //RefreshButton1.Enabled = true;
           //RefreshButton1.Text = "Refresh";
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
        private void WindowTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
       
}