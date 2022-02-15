using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LOGIC;

namespace Fantasy4You
{
    public partial class Form1 : Form


    {
        Logic log1 = new Logic();



        public Form1()
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

            LoggingInLabel.Visible = true;
            if (UsernameTextbox.Text == "" || PasswordTextbox.Text == "")
            {
                MessageBox.Show("Please fill in your credentials");
            }

            if (log1.CheckName(usr, pwd, chk) == true)
            {
                //Reminder to add a function to save the credentials of the user
                MessageBox.Show("Login successful");
                Application.Exit();
                
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}