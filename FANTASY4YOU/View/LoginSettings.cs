using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using FANTASY4YOU;
using System.Runtime.InteropServices;

namespace FANTASY4YOU
{
    
    public partial class LoginSettings : Form
    {
        LogicController logic = new LogicController();

        public LoginSettings()
        {
            InitializeComponent();
        }

        int originalExStyle = -1;
        bool enableFormLevelDoubleBuffering = true;

         protected override CreateParams CreateParams
        {
            get
            {
                var parms = base.CreateParams;
                parms.Style &= ~0x02000000;  // Turn off WS_CLIPCHILDREN
                return parms;
            }
        }

        private void LoginSettings_Load(object sender, EventArgs e)
        {
        }

        private void ClearCacheButton_Click(object sender, EventArgs e)
        {
            logic.DeleteSavedCredentialsFile();
            Application.Restart();
            Environment.Exit(0);
        }
    }
}