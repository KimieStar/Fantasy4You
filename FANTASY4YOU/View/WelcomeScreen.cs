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
        DatabaseController databaseController = new DatabaseController();
        Thread MainInterface;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public WelcomeScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WelcomePannel.BackColor = Color.FromArgb(109, Color.Black);
            WindowTopBar.BackColor = Color.FromArgb(135, Color.Black);
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

        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void WindowTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void MinimizeForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}