using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using LOGIC;

namespace LOGINSETTINGS
{
    
    public partial class LoginSettings : Form
    {
        Logic log = new Logic();
        public LoginSettings()
        {
            InitializeComponent();
        }

        private void LoginSettings_Load(object sender, EventArgs e)
        {

        }

        private void ClearCacheButton_Click(object sender, EventArgs e)
        {
            log.DeleteSavedCredentials();
            Application.Restart();
            Environment.Exit(0);
        }
    }
}