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


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public LoginSettings()
        {
            InitializeComponent();
        }

        private void LoginSettings_Load(object sender, EventArgs e)
        {
            WindowTopBar.BackColor = Color.FromArgb(100, Color.Black);
            ClosePannelHelper.BackColor = Color.Transparent;
        }

        private void ClearCacheButton_Click(object sender, EventArgs e)
        {
            logic.DeleteSavedCredentialsFiles();
            Application.Restart();
            Environment.Exit(0);
        }

        private void WindowTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}