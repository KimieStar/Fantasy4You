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
    public partial class Characters : Form
    {
        LogicController logic = new LogicController();
        CharacterCustomizationChar customization = new CharacterCustomizationChar(); 
        CharacterDisplayer characterDisplayer;
        Thread registerCharacter;
        Thread mainInerface;
        DatabaseController connection = new DatabaseController();
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public Characters()
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

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowTopBar.BackColor = Color.FromArgb(165, Color.Black);
            HelperPanel.BackColor = Color.FromArgb(165, Color.Black);
            CharactersNumbers.Text = logic.NumberOfCharactersCreated().ToString();
            CharacterPannel1.BackColor = Color.FromArgb(165, Color.Black);
            CharacterPannel2.BackColor = Color.FromArgb(165, Color.Black);
            CharacterPannel3.BackColor = Color.FromArgb(165, Color.Black);
            CharacterPannel4.BackColor = Color.FromArgb(165, Color.Black);
            CharacterPannel5.BackColor = Color.FromArgb(165, Color.Black);
            NumberOfCharactersLabel.BackColor = Color.FromArgb(165, Color.Black);
            CharactersNumbers.BackColor = Color.FromArgb(165, Color.Black);

            //Character name labels
            for (int i = 0; i < logic.NumberOfCharactersCreated() + 1; i++)
            {
                Character character = logic.SelectCharInfo(i);

                switch (i)
                {
                    case 1:
                        CharacterNamePannelLabel1.Text = character.CharacterName;
                        break;
                    case 2:
                        CharacterNamePannelLabel2.Text = character.CharacterName;
                        break;
                    case 3:
                        CharacterNamePannelLabel3.Text = character.CharacterName;
                        break;
                    case 4:
                        CharacterNamePannelLabel4.Text = character.CharacterName;
                        break;
                    case 5:
                        CharacterNamePannelLabel5.Text = character.CharacterName;
                        break;
                }
            }


            //Character Level Label

            for (int i = 0; i < logic.NumberOfCharactersCreated() +1; i++)
            {
                Character character = logic.SelectCharInfo(i);

                switch (i)
                {
                    case 1:
                        CharacterLevelPannelLabel1.Text = character.CharacterLevel.ToString();
                        break;
                    case 2:
                        CharacterLevelPannelLabel2.Text = character.CharacterLevel.ToString();
                        break;
                    case 3:
                        CharacterLevelPannelLabel3.Text = character.CharacterLevel.ToString();
                        break;
                    case 4:
                        CharacterLevelPannelLabel4.Text = character.CharacterLevel.ToString();
                        break;
                    case 5:
                        CharacterLevelPannelLabel5.Text = character.CharacterLevel.ToString();
                        break;
                }
            }

            //Character Race Label
            for (int i = 0; i < logic.NumberOfCharactersCreated() + 1; i++)
            {
                Character character = logic.SelectCharInfo(i);

                switch (i)
                {
                    case 1:
                        CharacterRacePannelLabel1.Text = character.CharacterRace;
                        break;
                    case 2:
                        CharacterRacePannelLabel2.Text = character.CharacterRace;
                        break;
                    case 3:
                        CharacterRacePannelLabel3.Text = character.CharacterRace;
                        break;
                    case 4:
                        CharacterRacePannelLabel4.Text = character.CharacterRace;
                        break;
                    case 5:
                        CharacterRacePannelLabel5.Text = character.CharacterRace;
                        break;
                }
            }


            switch (logic.NumberOfCharactersCreated())
            {
                case 0:
                    CharacterPannel1.Visible = false;
                    CharacterPannel2.Visible = false;
                    CharacterPannel3.Visible = false;
                    CharacterPannel4.Visible = false;
                    CharacterPannel5.Visible = false;

                    CharacterNamePannelLabel1.Visible = false;
                    CharacterNamePannelLabel2.Visible = false;
                    CharacterNamePannelLabel3.Visible = false;
                    CharacterNamePannelLabel4.Visible = false;
                    CharacterNamePannelLabel5.Visible = false;
                    break;
                case 1:
                    CharacterPannel1.Visible = true;
                    CharacterPannel2.Visible = false;
                    CharacterPannel3.Visible = false;
                    CharacterPannel4.Visible = false;
                    CharacterPannel5.Visible = false;

                    CharacterNamePannelLabel1.Visible = true;
                    CharacterNamePannelLabel2.Visible = false;
                    CharacterNamePannelLabel3.Visible = false;
                    CharacterNamePannelLabel4.Visible = false;
                    CharacterNamePannelLabel5.Visible = false;
                    break;
                case 2:
                    CharacterPannel1.Visible = true;
                    CharacterPannel2.Visible = true;
                    CharacterPannel3.Visible = false;
                    CharacterPannel4.Visible = false;
                    CharacterPannel5.Visible = false;

                    CharacterNamePannelLabel1.Visible = true;
                    CharacterNamePannelLabel2.Visible = true;
                    CharacterNamePannelLabel3.Visible = false;
                    CharacterNamePannelLabel4.Visible = false;
                    CharacterNamePannelLabel5.Visible = false;
                    break;
                case 3:
                    CharacterPannel1.Visible = true;
                    CharacterPannel2.Visible = true;
                    CharacterPannel3.Visible = true;
                    CharacterPannel4.Visible = false;
                    CharacterPannel5.Visible = false;

                    CharacterNamePannelLabel1.Visible = true;
                    CharacterNamePannelLabel2.Visible = true;
                    CharacterNamePannelLabel3.Visible = true;
                    CharacterNamePannelLabel4.Visible = false;
                    CharacterNamePannelLabel5.Visible = false;
                    break ;
                case 4:
                    CharacterPannel1.Visible = true;
                    CharacterPannel2.Visible = true;
                    CharacterPannel3.Visible = true;
                    CharacterPannel4.Visible = true;
                    CharacterPannel5.Visible = false;

                    CharacterNamePannelLabel1.Visible = true;
                    CharacterNamePannelLabel2.Visible = true;
                    CharacterNamePannelLabel3.Visible = true;
                    CharacterNamePannelLabel4.Visible = true;
                    CharacterNamePannelLabel5.Visible = false;
                    break;
                case 5:
                    CharacterPannel1.Visible = true;
                    CharacterPannel2.Visible = true;
                    CharacterPannel3.Visible = true;
                    CharacterPannel4.Visible = true;
                    CharacterPannel5.Visible = true;

                    CharacterNamePannelLabel1.Visible = true;
                    CharacterNamePannelLabel2.Visible = true;
                    CharacterNamePannelLabel3.Visible = true;
                    CharacterNamePannelLabel4.Visible = true;
                    CharacterNamePannelLabel5.Visible = true;
                    break;

                    
            }
            
        }

        private void timer1_Tick(object? sender, EventArgs e)
        {
            Form1_Load(sender, EventArgs.Empty);
        }

        private void NumberOfCharactersLabel_Click(object sender, EventArgs e)
        {

        }

        private void CreateCharacterButton_Click(object sender, EventArgs e)
        {
            registerCharacter = new Thread(RegisterCharacters);
            registerCharacter.SetApartmentState(ApartmentState.STA);
            registerCharacter.Start();
            
        }

        private void RegisterCharacters(object? obj)
        {
            Application.Run(new CharacterRegistration());
        }

        private void CharactersNumbers_Click(object sender, EventArgs e)
        {

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshButton.Enabled = false;
            
            for (int i = 0; i < logic.NumberOfCharactersCreated() + 1; i++)
            {
                Character character = logic.SelectCharInfo(i);

                switch (i)
                {
                    case 1:
                        CharacterNamePannelLabel1.Text = character.CharacterName;
                        break;
                    case 2:
                        CharacterNamePannelLabel2.Text = character.CharacterName;
                        break;
                    case 3:
                        CharacterNamePannelLabel3.Text = character.CharacterName;
                        break;
                    case 4:
                        CharacterNamePannelLabel4.Text = character.CharacterName;
                        break;
                    case 5:
                        CharacterNamePannelLabel5.Text = character.CharacterName;
                        break;
                }
            }


            //Character Level Label

            for (int i = 0; i < logic.NumberOfCharactersCreated() + 1; i++)
            {
                Character character = logic.SelectCharInfo(i);

                switch (i)
                {
                    case 1:
                        CharacterLevelPannelLabel1.Text = character.CharacterLevel.ToString();
                        break;
                    case 2:
                        CharacterLevelPannelLabel2.Text = character.CharacterLevel.ToString();
                        break;
                    case 3:
                        CharacterLevelPannelLabel3.Text = character.CharacterLevel.ToString();
                        break;
                    case 4:
                        CharacterLevelPannelLabel4.Text = character.CharacterLevel.ToString();
                        break;
                    case 5:
                        CharacterLevelPannelLabel5.Text = character.CharacterLevel.ToString();
                        break;
                }
            }

            //Character Race Label
            for (int i = 0; i < logic.NumberOfCharactersCreated() + 1; i++)
            {
                Character character = logic.SelectCharInfo(i);

                switch (i)
                {
                    case 1:
                        CharacterRacePannelLabel1.Text = character.CharacterRace;
                        break;
                    case 2:
                        CharacterRacePannelLabel2.Text = character.CharacterRace;
                        break;
                    case 3:
                        CharacterRacePannelLabel3.Text = character.CharacterRace;
                        break;
                    case 4:
                        CharacterRacePannelLabel4.Text = character.CharacterRace;
                        break;
                    case 5:
                        CharacterRacePannelLabel5.Text = character.CharacterRace;
                        break;
                }
            }

            switch (logic.NumberOfCharactersCreated())
            {
                case 0:
                    CharacterPannel1.Visible = false;
                    CharacterPannel2.Visible = false;
                    CharacterPannel3.Visible = false;
                    CharacterPannel4.Visible = false;
                    CharacterPannel5.Visible = false;

                    CharacterNamePannelLabel1.Visible = false;
                    CharacterNamePannelLabel2.Visible = false;
                    CharacterNamePannelLabel3.Visible = false;
                    CharacterNamePannelLabel4.Visible = false;
                    CharacterNamePannelLabel5.Visible = false;
                    break;
                case 1:
                    CharacterPannel1.Visible = true;
                    CharacterPannel2.Visible = false;
                    CharacterPannel3.Visible = false;
                    CharacterPannel4.Visible = false;
                    CharacterPannel5.Visible = false;

                    CharacterNamePannelLabel1.Visible = true;
                    CharacterNamePannelLabel2.Visible = false;
                    CharacterNamePannelLabel3.Visible = false;
                    CharacterNamePannelLabel4.Visible = false;
                    CharacterNamePannelLabel5.Visible = false;
                    break;
                case 2:
                    CharacterPannel1.Visible = true;
                    CharacterPannel2.Visible = true;
                    CharacterPannel3.Visible = false;
                    CharacterPannel4.Visible = false;
                    CharacterPannel5.Visible = false;

                    CharacterNamePannelLabel1.Visible = true;
                    CharacterNamePannelLabel2.Visible = true;
                    CharacterNamePannelLabel3.Visible = false;
                    CharacterNamePannelLabel4.Visible = false;
                    CharacterNamePannelLabel5.Visible = false;
                    break;
                case 3:
                    CharacterPannel1.Visible = true;
                    CharacterPannel2.Visible = true;
                    CharacterPannel3.Visible = true;
                    CharacterPannel4.Visible = false;
                    CharacterPannel5.Visible = false;

                    CharacterNamePannelLabel1.Visible = true;
                    CharacterNamePannelLabel2.Visible = true;
                    CharacterNamePannelLabel3.Visible = true;
                    CharacterNamePannelLabel4.Visible = false;
                    CharacterNamePannelLabel5.Visible = false;
                    break;
                case 4:
                    CharacterPannel1.Visible = true;
                    CharacterPannel2.Visible = true;
                    CharacterPannel3.Visible = true;
                    CharacterPannel4.Visible = true;
                    CharacterPannel5.Visible = false;

                    CharacterNamePannelLabel1.Visible = true;
                    CharacterNamePannelLabel2.Visible = true;
                    CharacterNamePannelLabel3.Visible = true;
                    CharacterNamePannelLabel4.Visible = true;
                    CharacterNamePannelLabel5.Visible = false;
                    break;
                case 5:
                    CharacterPannel1.Visible = true;
                    CharacterPannel2.Visible = true;
                    CharacterPannel3.Visible = true;
                    CharacterPannel4.Visible = true;
                    CharacterPannel5.Visible = true;

                    CharacterNamePannelLabel1.Visible = true;
                    CharacterNamePannelLabel2.Visible = true;
                    CharacterNamePannelLabel3.Visible = true;
                    CharacterNamePannelLabel4.Visible = true;
                    CharacterNamePannelLabel5.Visible = true;
                    break;


            }
            CharactersNumbers.Text = logic.NumberOfCharactersCreated().ToString();

            RefreshButton.Enabled = true;
        }
        

        private void CharacterPannel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CharacterCustomizationButton1_Click(object sender, EventArgs e)
        {
            User.CharSelected = 1;
            customization.ShowDialog();
        }

        private void CharacterCustomizationButton2_Click(object sender, EventArgs e)
        {
            User.CharSelected = 2;
            customization.ShowDialog();
        }

        private void CharacterCustomizationButton3_Click(object sender, EventArgs e)
        {
            User.CharSelected = 3;
            customization.ShowDialog();
        }

        private void CharacterCustomizationButton4_Click(object sender, EventArgs e)
        {
            User.CharSelected = 4;
            customization.ShowDialog();
        }

        private void CharacterCustomizationButton5_Click(object sender, EventArgs e)
        {
            User.CharSelected = 5;
            customization.ShowDialog();
        }

        private void Characters_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainInerface = new Thread(OpenMainInterface);
            mainInerface.SetApartmentState(ApartmentState.STA);
            mainInerface.Start();
        }

        private void OpenMainInterface(object? obj)
        {
            Application.Run(new MainInterface());
        }

        private void OpenCharacterDisplay1_Click(object sender, EventArgs e)
        {
            User.CharSelected = 1;
            characterDisplayer = new CharacterDisplayer();
            characterDisplayer.ShowDialog();
        }

        private void OpenCharacterDisplay2_Click(object sender, EventArgs e)
        {
            User.CharSelected = 2;
            characterDisplayer = new CharacterDisplayer();
            characterDisplayer.ShowDialog();
        }

        private void OpenCharacterDisplay3_Click(object sender, EventArgs e)
        {
            User.CharSelected = 3;
            characterDisplayer = new CharacterDisplayer();
            characterDisplayer.ShowDialog();
        }

        private void OpenCharacterDisplay4_Click(object sender, EventArgs e)
        {
            User.CharSelected = 4;
            characterDisplayer = new CharacterDisplayer();
            characterDisplayer.ShowDialog();
        }

        private void OpenCharacterDisplay5_Click(object sender, EventArgs e)
        {
            User.CharSelected = 5;
            characterDisplayer = new CharacterDisplayer();
            characterDisplayer.ShowDialog();
        }

        private void CharacterNamePannelLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void WindowTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HelperPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}