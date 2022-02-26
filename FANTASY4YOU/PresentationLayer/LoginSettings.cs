using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using LOGIC;
using FANTASY4YOU;

namespace FANTASY4YOU
{
    
    public partial class LoginSettings : Form
    {
        Logic logic = new Logic();
        public LoginSettings()
        {
            InitializeComponent();
        }

        private void LoginSettings_Load(object sender, EventArgs e)
        {

        }

        private void ClearCacheButton_Click(object sender, EventArgs e)
        {
            logic.DeleteSavedCredentialsFiles();
            Application.Restart();
            Environment.Exit(0);
        }
    }
}