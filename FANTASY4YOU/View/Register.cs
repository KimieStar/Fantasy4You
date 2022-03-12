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
    public partial class Register : Form
    {

        LogicController logic = new LogicController();
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        bool check;


        public Register()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RegisterPanel.BackColor = Color.FromArgb(125, Color.Black);
            WindowTopBar.BackColor = Color.FromArgb(165, Color.Black);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string usr = UsernameTextBox.Text;
            string pwd = PasswordTextBox.Text;
            string email = EmailTextBox.Text;
            //TO BE REMOVED//string dbusernamecheck = log.SelectUsername(usr);
            bool usernameCheck = logic.CheckIfUsernameExists(usr);





            if (usr == "" ||pwd == "")
            {
                MessageBox.Show("Please fill in your credentials");
            }
            else if (usr != "" || pwd != "")
            {
                if (usernameCheck == false)
                {
                    if (RememberMeCheckBox.Checked == true)
                    {
                        logic.SaveCredentialsToFile(usr, pwd);
                    }
                    else
                    {
                        string no;
                    }

                    
                    logic.InsertUsernameAndPasswordIntoDB(usr, pwd, email);
                    MessageBox.Show("Registration Complete!");
                    this.Close();


                }
                else if (usernameCheck == true)
                {
                    MessageBox.Show("Username already exists!");
                    
                }
                
                
            }
        }

        private void RememberMeCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ShowPasswordButton_Click(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = false;
            ShowPasswordButton.Visible = false;
            HidePasswordButton.Visible = true;
        }

        private void HidePasswordButton_Click(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = true;
            ShowPasswordButton.Visible = true;
            HidePasswordButton.Visible = false;
        }

        private void WindowTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}