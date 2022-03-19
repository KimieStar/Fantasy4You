using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using FANTASY4YOU;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace FANTASY4YOU
{
    public partial class Register : Form
    {

        LogicController logic = new LogicController();
        DatabaseController connection = new DatabaseController();


        public Register()
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

        
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string usr = UsernameTextBox.Text;
            string pwd = PasswordTextBox.Text;
            string email = EmailTextBox.Text;
            bool usernameCheck = connection.CheckIfUsernameExists(usr);





            if (usr == "" ||pwd == "")
            {
                MessageBox.Show("Please fill in your credentials");
            }
            else if (usr != "" || pwd != "")
            {
                if (!Regex.IsMatch(usr, @"^[a-zA-Z\s_]+$"))
                {
                    MessageBox.Show("Username can be only Letters");
                }
                else if (usr.Length > 15)
                {
                    MessageBox.Show("Username can be only 20 letters long!");
                }
                else if (pwd.Length < 5)
                {
                    MessageBox.Show("Your password is too short");
                }
                else if (email == "")
                {
                    var confirmResult = MessageBox.Show("Note that if you register without Email, if you forget your password you will not be able to recover it??",
                                        "Continue?!",
                                        MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
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


                            connection.InsertUsernameAndPasswordIntoDB(usr, pwd, email);
                            MessageBox.Show("Registration Complete!");
                            this.Close();


                        }
                    }
                }
                else if (usernameCheck == false)
                {
                    if (RememberMeCheckBox.Checked == true)
                    {
                        logic.SaveCredentialsToFile(usr, pwd);
                    }
                    else
                    {
                        string no;
                    }

                    
                    connection.InsertUsernameAndPasswordIntoDB(usr, pwd, email);
                    MessageBox.Show("Registration Complete!");
                    this.Close();


                }
                else if (usernameCheck == true)
                {
                    MessageBox.Show("Username already exists!");
                    
                }
                
                
            }
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