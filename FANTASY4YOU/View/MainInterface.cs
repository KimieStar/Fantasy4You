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
        LogicController logic = new LogicController();
        Thread characters;
        DatabaseController connection = new DatabaseController();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public MainInterface()
        {
            InitializeComponent();
        }

        int originalExStyle = -1;
        bool enableFormLevelDoubleBuffering = true;

        protected override CreateParams CreateParams
        {
            get
            {
                if (originalExStyle == -1)
                    originalExStyle = base.CreateParams.ExStyle;

                CreateParams cp = base.CreateParams;
                if (enableFormLevelDoubleBuffering)
                    cp.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED
                else
                    cp.ExStyle = originalExStyle;

                return cp;
            }
        }
        private void MainInterface_Load(object sender, EventArgs e)
        {
            WindowTopBar.BackColor = Color.FromArgb(165, Color.Black);
            MainPanel.BackColor = Color.FromArgb(125, Color.Black);
            YourCharactersLabel.BackColor = Color.Transparent;
            comingsoonLabel1.BackColor = Color.Transparent;
            comingsoonLabel2.BackColor = Color.Transparent;
            UsernameLabel.BackColor = Color.Transparent;
            IdLabel.BackColor = Color.Transparent;
            usernameL.BackColor = Color.Transparent;
            PanelHelper.BackColor = Color.Transparent;
            IdL.BackColor = Color.Transparent;
            comingSoonButton1.BackColor = Color.Transparent;
            comingSoonButton2.BackColor = Color.Transparent;
            string uname = User.Username;
            usernameL.Text = uname;

            int id = logic.SelectUserId();


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

        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void WindowTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PanelHelper_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
