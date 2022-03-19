using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FANTASY4YOU
{
    public partial class RecoveryPassword : Form
    {
        DatabaseController databaseController = new DatabaseController();
        Thread Login;
        public RecoveryPassword()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Function which disables WS_CLIPCHILDREN for minimizing the occurances of white bars on load of form
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                var parms = base.CreateParams;
                parms.Style &= ~0x02000000;  // Turn off WS_CLIPCHILDREN
                return parms;
            }
        }


        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            ///<summary>
            ///Some if-else statements which put condition for the way 
            ///the user to input their information
            /// </summary>
           if (newPasswordTextBox.Text == "")
           {
               MessageBox.Show("Please input your new password!");
           }
           else if (confirmPasswordTextBox.Text == "")
           {
               MessageBox.Show("Please input your current password!");
           }
           else if (newPasswordTextBox.Text == User.Password)
           {
                MessageBox.Show("This is already your password");
           }
           else if (newPasswordTextBox.Text.Length < 5)
           {
               MessageBox.Show("Your password is too short");
           }
           else if (confirmPasswordTextBox.Text != newPasswordTextBox.Text)
           {
               MessageBox.Show("Passwords do not match!");
           }
           else
           {
                databaseController.RecoverPassword(newPasswordTextBox.Text, User.RecoveryEmail);
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
