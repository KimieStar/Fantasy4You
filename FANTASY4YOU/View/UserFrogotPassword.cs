using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FANTASY4YOU;

namespace FANTASY4YOU
{
    public partial class UserFrogotPassword : Form
    {
        DatabaseController connection = new DatabaseController();
        LogicController logic = new LogicController();
        Random rnd = new Random();
        public int code;
        RecoveryPassword recovery = new RecoveryPassword();

        public UserFrogotPassword()
        {
            InitializeComponent();
        }

        private void SendCodeButton_Click(object sender, EventArgs e)
        {
            code = rnd.Next(123123, 9999999);
            DataTable dt = connection.SelectUserEmail();
            string email = "email";
            bool contains = dt.AsEnumerable().Any(row => enterEmailTextBox.Text == row.Field<String>(email));

            if (enterEmailTextBox.Text == "")
            {
                MessageBox.Show("You have to enter your email first!");
            }
            else if (contains == true)
            {
                logic.SendEmail(enterEmailTextBox.Text, code);
                MessageBox.Show("Email Sent!");
                RecoveryCodeTextBox.Enabled = true;
                VerifyCodeButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Email Sent!");
                RecoveryCodeTextBox.Enabled = true;
                VerifyCodeButton.Enabled = true;
            }
           
        }

        private void VerifyCodeButton_Click(object sender, EventArgs e)
        {
            int Attempts = 0;
            if (RecoveryCodeTextBox.Text == code.ToString())
            {
                User.RecoveryEmail = enterEmailTextBox.Text;
                recovery.ShowDialog();
            }
            

            
        }
    }
}
