using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using LOGIC;
namespace REGISTER
{
    public partial class Register : Form
    {

        Logic log = new Logic();
        bool chk;


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
            string dbusernamecheck = log.SelectUsername(usr);
            bool usernamecheck = log.CheckIfUsernameExists(usr, chk);





            if (usr == "" ||pwd == "")
            {
                MessageBox.Show("Please fill in your credentials");
            }
            else if (usr != "" || pwd != "")
            {
                if (usernamecheck == false)
                {
                    if (RememberMeCheckBox.Checked == true)
                    {
                        log.SaveCredentials(usr, pwd);
                    }
                    else
                    {
                        string no;
                    }

                    log.CloseConnection();
                    log.InsertUsernameAndPassword(usr, pwd, email);
                    MessageBox.Show("Registration Complete!");
                    this.Close();


                }
                else if (usernamecheck == true)
                {
                    MessageBox.Show("Username already exists!");
                    log.CloseConnection();
                }
                
                
            }
        }

        private void RememberMeCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}