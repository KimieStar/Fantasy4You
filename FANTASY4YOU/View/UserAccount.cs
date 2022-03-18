using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FANTASY4YOU { 
    public partial class UserAccount : Form
    {
        ChangeUsername changeUsername = new ChangeUsername();
        ChangePassword changePassword = new ChangePassword();
        DeleteCharacter deleteCharacter = new DeleteCharacter();
        DatabaseController connection = new DatabaseController();
        public UserAccount()
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
        private void UserAccount_Load(object sender, EventArgs e)
        {
            UsernameLabel.Text = User.Username;
            NumberOfcharacters.Text = connection.NumberOfCharactersCreated().ToString() + "/5 characters";
        }

        public void ReloadNumOfCharacters()
        {
            NumberOfcharacters.Text = connection.NumberOfCharactersCreated().ToString() + "/5 characters";
        }

        private void ChangeUsernameButton_Click(object sender, EventArgs e)
        {
            changeUsername.ShowDialog();
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            changePassword.ShowDialog();
        }

        private void DeleteCharacters_Click(object sender, EventArgs e)
        {
            deleteCharacter.ShowDialog();
            ReloadNumOfCharacters();
        }

        private void DeleteUserAccount_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete your account ??",
                                     "Delete Account?!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                User.DeleteUser = 1;
                connection.DeleteUserAccount();
                this.Close();
            }
            
        }
    }
}
