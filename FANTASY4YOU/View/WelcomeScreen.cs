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
    public partial class WelcomeScreen : Form
    {
        Thread MainInterface;
        public WelcomeScreen()
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

        private void WelcomeScreen_Load(object sender, EventArgs e)
        {
            welcomeLabel.BackColor = Color.Transparent;
            nameLabel.BackColor = Color.Transparent;
            GladLabel.BackColor = Color.Transparent;

            string uname = User.Username;
            nameLabel.Text = uname;


        }

        private void OpenMainInterface(object? obj)
        {
            Application.Run(new MainInterface());
        }

        private void WelcomeScreen_FormClosing(object sender, FormClosingEventArgs e)
        {

            MainInterface = new Thread(OpenMainInterface);
            MainInterface.SetApartmentState(ApartmentState.STA);
            MainInterface.Start();
        }
    }
}