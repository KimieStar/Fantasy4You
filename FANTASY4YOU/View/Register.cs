using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using FANTASY4YOU;
namespace FANTASY4YOU
{
    public partial class Register : Form
    {

        LogicController logic = new LogicController();
        bool check;


        public Register()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
    }
}