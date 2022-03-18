using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FANTASY4YOU
{
    public partial class MainInterface : Form
    {
        Thread characters;
        DatabaseController connection = new DatabaseController();
        Thread login;
        UserAccount userAccount = new UserAccount();

        public MainInterface()
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


        private void MainInterface_Load(object sender, EventArgs e)
        {
            YourCharactersLabel.BackColor = Color.Transparent;
            comingsoonLabel1.BackColor = Color.Transparent;
            comingsoonLabel2.BackColor = Color.Transparent;
            UsernameLabel.BackColor = Color.Transparent;
            IdLabel.BackColor = Color.Transparent;
            usernameL.BackColor = Color.Transparent;
            IdL.BackColor = Color.Transparent;
            comingSoonButton1.BackColor = Color.Transparent;
            comingSoonButton2.BackColor = Color.Transparent;
            string uname = User.Username;
            usernameL.Text = uname;

            int id = connection.SelectUserIdFromDB();


            IdL.Text = id.ToString();
        }

        private void YourCharactersButton_Click(object sender, EventArgs e)
        {
            characters = new Thread(OpenCharacters);
            characters.SetApartmentState(ApartmentState.STA);
            characters.Start();
            this.Close();
        }

        private void OpenCharacters(object? obj)
        {
            Application.Run(new Characters());
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            login = new Thread(OpenLogin);
            login.SetApartmentState(ApartmentState.STA);
            login.Start();
            this.Close();
        }

        private void OpenLogin(object? obj)
        {
            Application.Run(new Login());
        }

        private void AccountView_Click(object sender, EventArgs e)
        {
            userAccount.ShowDialog();
            if (User.DeleteUser == 1)
            {
                User.DeleteUser = 0;
                login = new Thread(OpenLogin);
                login.SetApartmentState(ApartmentState.STA);
                login.Start();
                this.Close();
            }

        }
    }
}
