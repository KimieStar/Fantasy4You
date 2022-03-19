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
        CharacterCustomizationChar customization = new CharacterCustomizationChar(); 
        CharacterDisplayer characterDisplayer;
        Thread registerCharacter;
        Thread mainInerface;
        DatabaseController connection = new DatabaseController();
        
        public Characters()
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

        private void Characters_Load(object sender, EventArgs e)
        {
            CharactersNumbers.Text = connection.NumberOfCharactersCreated().ToString();
            NumberOfCharactersLabel.BackColor = Color.FromArgb(165, Color.Black);
            CharactersNumbers.BackColor = Color.FromArgb(165, Color.Black);

            //Character name labels
            for (int i = 0; i < connection.NumberOfCharactersCreated() + 1; i++)
            {
                Character character = connection.SelectCharInfo(i);

                switch (i)
                {
                    case 1:
                        CharacterNamePicBoxLabel1.Text = character.CharacterName;
                        break;
                    case 2:
                        CharacterNamePicBoxLabel2.Text = character.CharacterName;
                        break;
                    case 3:
                        CharacterNamePicBoxLabel3.Text = character.CharacterName;
                        break;
                    case 4:
                        CharacterNamePicBoxLabel4.Text = character.CharacterName;
                        break;
                    case 5:
                        CharacterNamePicBoxLabel5.Text = character.CharacterName;
                        break;
                }
            }


            //Character Level Label

            for (int i = 0; i < connection.NumberOfCharactersCreated() +1; i++)
            {
                Character character = connection.SelectCharInfo(i);

                switch (i)
                {
                    case 1:
                        CharacterLevelPicBoxLabel1.Text = character.CharacterLevel.ToString();
                        break;
                    case 2:
                        CharacterLevelPicBoxLabel2.Text = character.CharacterLevel.ToString();
                        break;
                    case 3:
                        CharacterLevelPicBoxLabel3.Text = character.CharacterLevel.ToString();
                        break;
                    case 4:
                        CharacterLevelPicBoxLabel4.Text = character.CharacterLevel.ToString();
                        break;
                    case 5:
                        CharacterLevelPicBoxLabel5.Text = character.CharacterLevel.ToString();
                        break;
                }
            }

            //Character Race Label
            for (int i = 0; i < connection.NumberOfCharactersCreated() + 1; i++)
            {
                Character character = connection.SelectCharInfo(i);

                switch (i)
                {
                    case 1:
                        CharacterRacePicBoxLabel1.Text = character.CharacterRace;
                        break;
                    case 2:
                        CharacterRacePicBoxLabel2.Text = character.CharacterRace;
                        break;
                    case 3:
                        CharacterRacePicBoxLabel3.Text = character.CharacterRace;
                        break;
                    case 4:
                        CharacterRacePicBoxLabel4.Text = character.CharacterRace;
                        break;
                    case 5:
                        CharacterRacePicBoxLabel5.Text = character.CharacterRace;
                        break;
                }
            }


            switch (connection.NumberOfCharactersCreated())
            {
                case 0:
                    this.BackgroundImage = new Bitmap(Properties.Resources.CharactersBackground0Panel);
                    CharacterNameNameLabel1.Visible = false;
                    CharacterLevelLevelLabel1.Visible = false;
                    CharacterRaceRaceLabel1.Visible = false;
                    CharacterRacePicBoxLabel1.Visible = false;
                    CharacterLevelPicBoxLabel1.Visible = false;
                    CharacterNamePicBoxLabel1.Visible = false;
                    OpenCharacterDisplay1.Visible = false;
                    CharacterCustomizationButton1.Visible = false;

                    CharacterNameNameLabel2.Visible = false;
                    CharacterLevelLevelLabel2.Visible = false;
                    CharacterRaceRaceLabel2.Visible = false;
                    CharacterRacePicBoxLabel2.Visible = false;
                    CharacterLevelPicBoxLabel2.Visible = false;
                    CharacterNamePicBoxLabel2.Visible = false;
                    OpenCharacterDisplay2.Visible = false;
                    CharacterCustomizationButton2.Visible = false;

                    CharacterNameNameLabel3.Visible = false;
                    CharacterLevelLevelLabel3.Visible = false;
                    CharacterRaceRaceLabel3.Visible = false;
                    CharacterRacePicBoxLabel3.Visible = false;
                    CharacterLevelPicBoxLabel3.Visible = false;
                    CharacterNamePicBoxLabel3.Visible = false;
                    OpenCharacterDisplay3.Visible = false;
                    CharacterCustomizationButton3.Visible = false;

                    CharacterNameNameLabel4.Visible = false;
                    CharacterLevelLevelLabel4.Visible = false;
                    CharacterRaceRaceLabel4.Visible = false;
                    CharacterRacePicBoxLabel4.Visible = false;
                    CharacterLevelPicBoxLabel4.Visible = false;
                    CharacterNamePicBoxLabel4.Visible = false;
                    OpenCharacterDisplay4.Visible = false;
                    CharacterCustomizationButton4.Visible = false;

                    CharacterNameNameLabel5.Visible = false;
                    CharacterLevelLevelLabel5.Visible = false;
                    CharacterRaceRaceLabel5.Visible = false;
                    CharacterRacePicBoxLabel5.Visible = false;
                    CharacterLevelPicBoxLabel5.Visible = false;
                    CharacterNamePicBoxLabel5.Visible = false;
                    OpenCharacterDisplay5.Visible = false;
                    CharacterCustomizationButton5.Visible = false;

                    CharacterNamePicBoxLabel1.Visible = false;
                    CharacterNamePicBoxLabel2.Visible = false;
                    CharacterNamePicBoxLabel3.Visible = false;
                    CharacterNamePicBoxLabel4.Visible = false;
                    CharacterNamePicBoxLabel5.Visible = false;
                    break;
                case 1:
                    this.BackgroundImage = new Bitmap(Properties.Resources.CharactersBackgroound1Panel);
                    CharacterNameNameLabel1.Visible = true;
                    CharacterLevelLevelLabel1.Visible = true;
                    CharacterRaceRaceLabel1.Visible = true;
                    CharacterRacePicBoxLabel1.Visible = true;
                    CharacterLevelPicBoxLabel1.Visible = true;
                    CharacterNamePicBoxLabel1.Visible = true;
                    OpenCharacterDisplay1.Visible = true;
                    CharacterCustomizationButton1.Visible = true;

                    CharacterNameNameLabel2.Visible = false;
                    CharacterLevelLevelLabel2.Visible = false;
                    CharacterRaceRaceLabel2.Visible = false;
                    CharacterRacePicBoxLabel2.Visible = false;
                    CharacterLevelPicBoxLabel2.Visible = false;
                    CharacterNamePicBoxLabel2.Visible = false;
                    OpenCharacterDisplay2.Visible = false;
                    CharacterCustomizationButton2.Visible = false;

                    CharacterNameNameLabel3.Visible = false;
                    CharacterLevelLevelLabel3.Visible = false;
                    CharacterRaceRaceLabel3.Visible = false;
                    CharacterRacePicBoxLabel3.Visible = false;
                    CharacterLevelPicBoxLabel3.Visible = false;
                    CharacterNamePicBoxLabel3.Visible = false;
                    OpenCharacterDisplay3.Visible = false;
                    CharacterCustomizationButton3.Visible = false;

                    CharacterNameNameLabel4.Visible = false;
                    CharacterLevelLevelLabel4.Visible = false;
                    CharacterRaceRaceLabel4.Visible = false;
                    CharacterRacePicBoxLabel4.Visible = false;
                    CharacterLevelPicBoxLabel4.Visible = false;
                    CharacterNamePicBoxLabel4.Visible = false;
                    OpenCharacterDisplay4.Visible = false;
                    CharacterCustomizationButton4.Visible = false;

                    CharacterNameNameLabel5.Visible = false;
                    CharacterLevelLevelLabel5.Visible = false;
                    CharacterRaceRaceLabel5.Visible = false;
                    CharacterRacePicBoxLabel5.Visible = false;
                    CharacterLevelPicBoxLabel5.Visible = false;
                    CharacterNamePicBoxLabel5.Visible = false;
                    OpenCharacterDisplay5.Visible = false;
                    CharacterCustomizationButton5.Visible = false;

                    CharacterNamePicBoxLabel1.Visible = true;
                    CharacterNamePicBoxLabel2.Visible = false;
                    CharacterNamePicBoxLabel3.Visible = false;
                    CharacterNamePicBoxLabel4.Visible = false;
                    CharacterNamePicBoxLabel5.Visible = false;
                    break;
                case 2:
                    this.BackgroundImage = new Bitmap(Properties.Resources.CharactersBackgroound2Panel);
                    CharacterNameNameLabel1.Visible = true;
                    CharacterLevelLevelLabel1.Visible = true;
                    CharacterRaceRaceLabel1.Visible = true;
                    CharacterRacePicBoxLabel1.Visible = true;
                    CharacterLevelPicBoxLabel1.Visible = true;
                    CharacterNamePicBoxLabel1.Visible = true;
                    OpenCharacterDisplay1.Visible = true;
                    CharacterCustomizationButton1.Visible = true;

                    CharacterNameNameLabel2.Visible = true;
                    CharacterLevelLevelLabel2.Visible = true;
                    CharacterRaceRaceLabel2.Visible = true;
                    CharacterRacePicBoxLabel2.Visible = true;
                    CharacterLevelPicBoxLabel2.Visible = true;
                    CharacterNamePicBoxLabel2.Visible = true;
                    OpenCharacterDisplay2.Visible = true;
                    CharacterCustomizationButton2.Visible = true;

                    CharacterNameNameLabel3.Visible = false;
                    CharacterLevelLevelLabel3.Visible = false;
                    CharacterRaceRaceLabel3.Visible = false;
                    CharacterRacePicBoxLabel3.Visible = false;
                    CharacterLevelPicBoxLabel3.Visible = false;
                    CharacterNamePicBoxLabel3.Visible = false;
                    OpenCharacterDisplay3.Visible = false;
                    CharacterCustomizationButton3.Visible = false;

                    CharacterNameNameLabel4.Visible = false;
                    CharacterLevelLevelLabel4.Visible = false;
                    CharacterRaceRaceLabel4.Visible = false;
                    CharacterRacePicBoxLabel4.Visible = false;
                    CharacterLevelPicBoxLabel4.Visible = false;
                    CharacterNamePicBoxLabel4.Visible = false;
                    OpenCharacterDisplay4.Visible = false;
                    CharacterCustomizationButton4.Visible = false;

                    CharacterNameNameLabel5.Visible = false;
                    CharacterLevelLevelLabel5.Visible = false;
                    CharacterRaceRaceLabel5.Visible = false;
                    CharacterRacePicBoxLabel5.Visible = false;
                    CharacterLevelPicBoxLabel5.Visible = false;
                    CharacterNamePicBoxLabel5.Visible = false;
                    OpenCharacterDisplay5.Visible = false;
                    CharacterCustomizationButton5.Visible = false;

                    CharacterNamePicBoxLabel1.Visible = true;
                    CharacterNamePicBoxLabel2.Visible = true;
                    CharacterNamePicBoxLabel3.Visible = false;
                    CharacterNamePicBoxLabel4.Visible = false;
                    CharacterNamePicBoxLabel5.Visible = false;
                    break;
                case 3:
                    this.BackgroundImage = new Bitmap(Properties.Resources.CharactersBackgroound3Panel);
                    CharacterNameNameLabel1.Visible = true;
                    CharacterLevelLevelLabel1.Visible = true;
                    CharacterRaceRaceLabel1.Visible = true;
                    CharacterRacePicBoxLabel1.Visible = true;
                    CharacterLevelPicBoxLabel1.Visible = true;
                    CharacterNamePicBoxLabel1.Visible = true;
                    OpenCharacterDisplay1.Visible = true;
                    CharacterCustomizationButton1.Visible = true;

                    CharacterNameNameLabel2.Visible = true;
                    CharacterLevelLevelLabel2.Visible = true;
                    CharacterRaceRaceLabel2.Visible = true;
                    CharacterRacePicBoxLabel2.Visible = true;
                    CharacterLevelPicBoxLabel2.Visible = true;
                    CharacterNamePicBoxLabel2.Visible = true;
                    OpenCharacterDisplay2.Visible = true;
                    CharacterCustomizationButton2.Visible = true;

                    CharacterNameNameLabel3.Visible = true;
                    CharacterLevelLevelLabel3.Visible = true;
                    CharacterRaceRaceLabel3.Visible = true;
                    CharacterRacePicBoxLabel3.Visible = true;
                    CharacterLevelPicBoxLabel3.Visible = true;
                    CharacterNamePicBoxLabel3.Visible = true;
                    OpenCharacterDisplay3.Visible = true;
                    CharacterCustomizationButton3.Visible = true;

                    CharacterNameNameLabel4.Visible = false;
                    CharacterLevelLevelLabel4.Visible = false;
                    CharacterRaceRaceLabel4.Visible = false;
                    CharacterRacePicBoxLabel4.Visible = false;
                    CharacterLevelPicBoxLabel4.Visible = false;
                    CharacterNamePicBoxLabel4.Visible = false;
                    OpenCharacterDisplay4.Visible = false;
                    CharacterCustomizationButton4.Visible = false;

                    CharacterNameNameLabel5.Visible = false;
                    CharacterLevelLevelLabel5.Visible = false;
                    CharacterRaceRaceLabel5.Visible = false;
                    CharacterRacePicBoxLabel5.Visible = false;
                    CharacterLevelPicBoxLabel5.Visible = false;
                    CharacterNamePicBoxLabel5.Visible = false;
                    OpenCharacterDisplay5.Visible = false;
                    CharacterCustomizationButton5.Visible = false;

                    CharacterNamePicBoxLabel1.Visible = true;
                    CharacterNamePicBoxLabel2.Visible = true;
                    CharacterNamePicBoxLabel3.Visible = true;
                    CharacterNamePicBoxLabel4.Visible = false;
                    CharacterNamePicBoxLabel5.Visible = false;
                    break;
                case 4:
                    this.BackgroundImage = new Bitmap(Properties.Resources.CharactersBackgroound4Panel);
                    CharacterNameNameLabel1.Visible = true;
                    CharacterLevelLevelLabel1.Visible = true;
                    CharacterRaceRaceLabel1.Visible = true;
                    CharacterRacePicBoxLabel1.Visible = true;
                    CharacterLevelPicBoxLabel1.Visible = true;
                    CharacterNamePicBoxLabel1.Visible = true;
                    OpenCharacterDisplay1.Visible = true;
                    CharacterCustomizationButton1.Visible = true;

                    CharacterNameNameLabel2.Visible = true;
                    CharacterLevelLevelLabel2.Visible = true;
                    CharacterRaceRaceLabel2.Visible = true;
                    CharacterRacePicBoxLabel2.Visible = true;
                    CharacterLevelPicBoxLabel2.Visible = true;
                    CharacterNamePicBoxLabel2.Visible = true;
                    OpenCharacterDisplay2.Visible = true;
                    CharacterCustomizationButton2.Visible = true;

                    CharacterNameNameLabel3.Visible = true;
                    CharacterLevelLevelLabel3.Visible = true;
                    CharacterRaceRaceLabel3.Visible = true;
                    CharacterRacePicBoxLabel3.Visible = true;
                    CharacterLevelPicBoxLabel3.Visible = true;
                    CharacterNamePicBoxLabel3.Visible = true;
                    OpenCharacterDisplay3.Visible = true;
                    CharacterCustomizationButton3.Visible = true;

                    CharacterNameNameLabel4.Visible = true;
                    CharacterLevelLevelLabel4.Visible = true;
                    CharacterRaceRaceLabel4.Visible = true;
                    CharacterRacePicBoxLabel4.Visible = true;
                    CharacterLevelPicBoxLabel4.Visible = true;
                    CharacterNamePicBoxLabel4.Visible = true;
                    OpenCharacterDisplay4.Visible = true;
                    CharacterCustomizationButton4.Visible = true;

                    CharacterNameNameLabel5.Visible = false;
                    CharacterLevelLevelLabel5.Visible = false;
                    CharacterRaceRaceLabel5.Visible = false;
                    CharacterRacePicBoxLabel5.Visible = false;
                    CharacterLevelPicBoxLabel5.Visible = false;
                    CharacterNamePicBoxLabel5.Visible = false;
                    OpenCharacterDisplay5.Visible = false;
                    CharacterCustomizationButton5.Visible = false;

                    CharacterNamePicBoxLabel1.Visible = true;
                    CharacterNamePicBoxLabel2.Visible = true;
                    CharacterNamePicBoxLabel3.Visible = true;
                    CharacterNamePicBoxLabel4.Visible = true;
                    CharacterNamePicBoxLabel5.Visible = false;
                    break;
                case 5:
                    this.BackgroundImage = new Bitmap(Properties.Resources.CharactersBackgroound5Panel);
                    CharacterNameNameLabel1.Visible = true;
                    CharacterLevelLevelLabel1.Visible = true;
                    CharacterRaceRaceLabel1.Visible = true;
                    CharacterRacePicBoxLabel1.Visible = true;
                    CharacterLevelPicBoxLabel1.Visible = true;
                    CharacterNamePicBoxLabel1.Visible = true;
                    OpenCharacterDisplay1.Visible = true;
                    CharacterCustomizationButton1.Visible = true;

                    CharacterNameNameLabel2.Visible = true;
                    CharacterLevelLevelLabel2.Visible = true;
                    CharacterRaceRaceLabel2.Visible = true;
                    CharacterRacePicBoxLabel2.Visible = true;
                    CharacterLevelPicBoxLabel2.Visible = true;
                    CharacterNamePicBoxLabel2.Visible = true;
                    OpenCharacterDisplay2.Visible = true;
                    CharacterCustomizationButton2.Visible = true;

                    CharacterNameNameLabel3.Visible = true;
                    CharacterLevelLevelLabel3.Visible = true;
                    CharacterRaceRaceLabel3.Visible = true;
                    CharacterRacePicBoxLabel3.Visible = true;
                    CharacterLevelPicBoxLabel3.Visible = true;
                    CharacterNamePicBoxLabel3.Visible = true;
                    OpenCharacterDisplay3.Visible = true;
                    CharacterCustomizationButton3.Visible = true;

                    CharacterNameNameLabel4.Visible = true;
                    CharacterLevelLevelLabel4.Visible = true;
                    CharacterRaceRaceLabel4.Visible = true;
                    CharacterRacePicBoxLabel4.Visible = true;
                    CharacterLevelPicBoxLabel4.Visible = true;
                    CharacterNamePicBoxLabel4.Visible = true;
                    OpenCharacterDisplay4.Visible = true;
                    CharacterCustomizationButton4.Visible = true;

                    CharacterNameNameLabel5.Visible = true;
                    CharacterLevelLevelLabel5.Visible = true;
                    CharacterRaceRaceLabel5.Visible = true;
                    CharacterRacePicBoxLabel5.Visible = true;
                    CharacterLevelPicBoxLabel5.Visible = true;
                    CharacterNamePicBoxLabel5.Visible = true;
                    OpenCharacterDisplay5.Visible = true;
                    CharacterCustomizationButton5.Visible = true;

                    CharacterNamePicBoxLabel1.Visible = true;
                    CharacterNamePicBoxLabel2.Visible = true;
                    CharacterNamePicBoxLabel3.Visible = true;
                    CharacterNamePicBoxLabel4.Visible = true;
                    CharacterNamePicBoxLabel5.Visible = true;
                    break;


            }

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

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshButton.Enabled = false;
            
            for (int i = 0; i < connection.NumberOfCharactersCreated() + 1; i++)
            {
                Character character = connection.SelectCharInfo(i);

                switch (i)
                {
                    case 1:
                        CharacterNamePicBoxLabel1.Text = character.CharacterName;
                        break;
                    case 2:
                        CharacterNamePicBoxLabel2.Text = character.CharacterName;
                        break;
                    case 3:
                        CharacterNamePicBoxLabel3.Text = character.CharacterName;
                        break;
                    case 4:
                        CharacterNamePicBoxLabel4.Text = character.CharacterName;
                        break;
                    case 5:
                        CharacterNamePicBoxLabel5.Text = character.CharacterName;
                        break;
                }
            }


            //Character Level Label

            for (int i = 0; i < connection.NumberOfCharactersCreated() + 1; i++)
            {
                Character character = connection.SelectCharInfo(i);

                switch (i)
                {
                    case 1:
                        CharacterLevelPicBoxLabel1.Text = character.CharacterLevel.ToString();
                        break;
                    case 2:
                        CharacterLevelPicBoxLabel2.Text = character.CharacterLevel.ToString();
                        break;
                    case 3:
                        CharacterLevelPicBoxLabel3.Text = character.CharacterLevel.ToString();
                        break;
                    case 4:
                        CharacterLevelPicBoxLabel4.Text = character.CharacterLevel.ToString();
                        break;
                    case 5:
                        CharacterLevelPicBoxLabel5.Text = character.CharacterLevel.ToString();
                        break;
                }
            }

            //Character Race Label
            for (int i = 0; i < connection.NumberOfCharactersCreated() + 1; i++)
            {
                Character character = connection.SelectCharInfo(i);

                switch (i)
                {
                    case 1:
                        CharacterRacePicBoxLabel1.Text = character.CharacterRace;
                        break;
                    case 2:
                        CharacterRacePicBoxLabel2.Text = character.CharacterRace;
                        break;
                    case 3:
                        CharacterRacePicBoxLabel3.Text = character.CharacterRace;
                        break;
                    case 4:
                        CharacterRacePicBoxLabel4.Text = character.CharacterRace;
                        break;
                    case 5:
                        CharacterRacePicBoxLabel5.Text = character.CharacterRace;
                        break;
                }
            }

            switch (connection.NumberOfCharactersCreated())
            {
                case 0:
                    this.BackgroundImage = new Bitmap(Properties.Resources.CharactersBackground0Panel);
                    CharacterNameNameLabel1.Visible = false;
                    CharacterLevelLevelLabel1.Visible = false;
                    CharacterRaceRaceLabel1.Visible = false;
                    CharacterRacePicBoxLabel1.Visible = false;
                    CharacterLevelPicBoxLabel1.Visible = false;
                    CharacterNamePicBoxLabel1.Visible = false;
                    OpenCharacterDisplay1.Visible = false;
                    CharacterCustomizationButton1.Visible = false;

                    CharacterNameNameLabel2.Visible = false;
                    CharacterLevelLevelLabel2.Visible = false;
                    CharacterRaceRaceLabel2.Visible = false;
                    CharacterRacePicBoxLabel2.Visible = false;
                    CharacterLevelPicBoxLabel2.Visible = false;
                    CharacterNamePicBoxLabel2.Visible = false;
                    OpenCharacterDisplay2.Visible = false;
                    CharacterCustomizationButton2.Visible = false;

                    CharacterNameNameLabel3.Visible = false;
                    CharacterLevelLevelLabel3.Visible = false;
                    CharacterRaceRaceLabel3.Visible = false;
                    CharacterRacePicBoxLabel3.Visible = false;
                    CharacterLevelPicBoxLabel3.Visible = false;
                    CharacterNamePicBoxLabel3.Visible = false;
                    OpenCharacterDisplay3.Visible = false;
                    CharacterCustomizationButton3.Visible = false;

                    CharacterNameNameLabel4.Visible = false;
                    CharacterLevelLevelLabel4.Visible = false;
                    CharacterRaceRaceLabel4.Visible = false;
                    CharacterRacePicBoxLabel4.Visible = false;
                    CharacterLevelPicBoxLabel4.Visible = false;
                    CharacterNamePicBoxLabel4.Visible = false;
                    OpenCharacterDisplay4.Visible = false;
                    CharacterCustomizationButton4.Visible = false;

                    CharacterNameNameLabel5.Visible = false;
                    CharacterLevelLevelLabel5.Visible = false;
                    CharacterRaceRaceLabel5.Visible = false;
                    CharacterRacePicBoxLabel5.Visible = false;
                    CharacterLevelPicBoxLabel5.Visible = false;
                    CharacterNamePicBoxLabel5.Visible = false;
                    OpenCharacterDisplay5.Visible = false;
                    CharacterCustomizationButton5.Visible = false;

                    CharacterNamePicBoxLabel1.Visible = false;
                    CharacterNamePicBoxLabel2.Visible = false;
                    CharacterNamePicBoxLabel3.Visible = false;
                    CharacterNamePicBoxLabel4.Visible = false;
                    CharacterNamePicBoxLabel5.Visible = false;
                    break;
                case 1:
                    this.BackgroundImage = new Bitmap(Properties.Resources.CharactersBackgroound1Panel);
                    CharacterNameNameLabel1.Visible = true;
                    CharacterLevelLevelLabel1.Visible = true;
                    CharacterRaceRaceLabel1.Visible = true;
                    CharacterRacePicBoxLabel1.Visible = true;
                    CharacterLevelPicBoxLabel1.Visible = true;
                    CharacterNamePicBoxLabel1.Visible = true;
                    OpenCharacterDisplay1.Visible = true;
                    CharacterCustomizationButton1.Visible = true;

                    CharacterNameNameLabel2.Visible = false;
                    CharacterLevelLevelLabel2.Visible = false;
                    CharacterRaceRaceLabel2.Visible = false;
                    CharacterRacePicBoxLabel2.Visible = false;
                    CharacterLevelPicBoxLabel2.Visible = false;
                    CharacterNamePicBoxLabel2.Visible = false;
                    OpenCharacterDisplay2.Visible = false;
                    CharacterCustomizationButton2.Visible = false;

                    CharacterNameNameLabel3.Visible = false;
                    CharacterLevelLevelLabel3.Visible = false;
                    CharacterRaceRaceLabel3.Visible = false;
                    CharacterRacePicBoxLabel3.Visible = false;
                    CharacterLevelPicBoxLabel3.Visible = false;
                    CharacterNamePicBoxLabel3.Visible = false;
                    OpenCharacterDisplay3.Visible = false;
                    CharacterCustomizationButton3.Visible = false;

                    CharacterNameNameLabel4.Visible = false;
                    CharacterLevelLevelLabel4.Visible = false;
                    CharacterRaceRaceLabel4.Visible = false;
                    CharacterRacePicBoxLabel4.Visible = false;
                    CharacterLevelPicBoxLabel4.Visible = false;
                    CharacterNamePicBoxLabel4.Visible = false;
                    OpenCharacterDisplay4.Visible = false;
                    CharacterCustomizationButton4.Visible = false;

                    CharacterNameNameLabel5.Visible = false;
                    CharacterLevelLevelLabel5.Visible = false;
                    CharacterRaceRaceLabel5.Visible = false;
                    CharacterRacePicBoxLabel5.Visible = false;
                    CharacterLevelPicBoxLabel5.Visible = false;
                    CharacterNamePicBoxLabel5.Visible = false;
                    OpenCharacterDisplay5.Visible = false;
                    CharacterCustomizationButton5.Visible = false;

                    CharacterNamePicBoxLabel1.Visible = true;
                    CharacterNamePicBoxLabel2.Visible = false;
                    CharacterNamePicBoxLabel3.Visible = false;
                    CharacterNamePicBoxLabel4.Visible = false;
                    CharacterNamePicBoxLabel5.Visible = false;
                    break;
                case 2:
                    this.BackgroundImage = new Bitmap(Properties.Resources.CharactersBackgroound2Panel);
                    CharacterNameNameLabel1.Visible = true;
                    CharacterLevelLevelLabel1.Visible = true;
                    CharacterRaceRaceLabel1.Visible = true;
                    CharacterRacePicBoxLabel1.Visible = true;
                    CharacterLevelPicBoxLabel1.Visible = true;
                    CharacterNamePicBoxLabel1.Visible = true;
                    OpenCharacterDisplay1.Visible = true;
                    CharacterCustomizationButton1.Visible = true;

                    CharacterNameNameLabel2.Visible = true;
                    CharacterLevelLevelLabel2.Visible = true;
                    CharacterRaceRaceLabel2.Visible = true;
                    CharacterRacePicBoxLabel2.Visible = true;
                    CharacterLevelPicBoxLabel2.Visible = true;
                    CharacterNamePicBoxLabel2.Visible = true;
                    OpenCharacterDisplay2.Visible = true;
                    CharacterCustomizationButton2.Visible = true;

                    CharacterNameNameLabel3.Visible = false;
                    CharacterLevelLevelLabel3.Visible = false;
                    CharacterRaceRaceLabel3.Visible = false;
                    CharacterRacePicBoxLabel3.Visible = false;
                    CharacterLevelPicBoxLabel3.Visible = false;
                    CharacterNamePicBoxLabel3.Visible = false;
                    OpenCharacterDisplay3.Visible = false;
                    CharacterCustomizationButton3.Visible = false;

                    CharacterNameNameLabel4.Visible = false;
                    CharacterLevelLevelLabel4.Visible = false;
                    CharacterRaceRaceLabel4.Visible = false;
                    CharacterRacePicBoxLabel4.Visible = false;
                    CharacterLevelPicBoxLabel4.Visible = false;
                    CharacterNamePicBoxLabel4.Visible = false;
                    OpenCharacterDisplay4.Visible = false;
                    CharacterCustomizationButton4.Visible = false;

                    CharacterNameNameLabel5.Visible = false;
                    CharacterLevelLevelLabel5.Visible = false;
                    CharacterRaceRaceLabel5.Visible = false;
                    CharacterRacePicBoxLabel5.Visible = false;
                    CharacterLevelPicBoxLabel5.Visible = false;
                    CharacterNamePicBoxLabel5.Visible = false;
                    OpenCharacterDisplay5.Visible = false;
                    CharacterCustomizationButton5.Visible = false;

                    CharacterNamePicBoxLabel1.Visible = true;
                    CharacterNamePicBoxLabel2.Visible = true;
                    CharacterNamePicBoxLabel3.Visible = false;
                    CharacterNamePicBoxLabel4.Visible = false;
                    CharacterNamePicBoxLabel5.Visible = false;
                    break;
                case 3:
                    this.BackgroundImage = new Bitmap(Properties.Resources.CharactersBackgroound3Panel);
                    CharacterNameNameLabel1.Visible = true;
                    CharacterLevelLevelLabel1.Visible = true;
                    CharacterRaceRaceLabel1.Visible = true;
                    CharacterRacePicBoxLabel1.Visible = true;
                    CharacterLevelPicBoxLabel1.Visible = true;
                    CharacterNamePicBoxLabel1.Visible = true;
                    OpenCharacterDisplay1.Visible = true;
                    CharacterCustomizationButton1.Visible = true;

                    CharacterNameNameLabel2.Visible = true;
                    CharacterLevelLevelLabel2.Visible = true;
                    CharacterRaceRaceLabel2.Visible = true;
                    CharacterRacePicBoxLabel2.Visible = true;
                    CharacterLevelPicBoxLabel2.Visible = true;
                    CharacterNamePicBoxLabel2.Visible = true;
                    OpenCharacterDisplay2.Visible = true;
                    CharacterCustomizationButton2.Visible = true;

                    CharacterNameNameLabel3.Visible = true;
                    CharacterLevelLevelLabel3.Visible = true;
                    CharacterRaceRaceLabel3.Visible = true;
                    CharacterRacePicBoxLabel3.Visible = true;
                    CharacterLevelPicBoxLabel3.Visible = true;
                    CharacterNamePicBoxLabel3.Visible = true;
                    OpenCharacterDisplay3.Visible = true;
                    CharacterCustomizationButton3.Visible = true;

                    CharacterNameNameLabel4.Visible = false;
                    CharacterLevelLevelLabel4.Visible = false;
                    CharacterRaceRaceLabel4.Visible = false;
                    CharacterRacePicBoxLabel4.Visible = false;
                    CharacterLevelPicBoxLabel4.Visible = false;
                    CharacterNamePicBoxLabel4.Visible = false;
                    OpenCharacterDisplay4.Visible = false;
                    CharacterCustomizationButton4.Visible = false;

                    CharacterNameNameLabel5.Visible = false;
                    CharacterLevelLevelLabel5.Visible = false;
                    CharacterRaceRaceLabel5.Visible = false;
                    CharacterRacePicBoxLabel5.Visible = false;
                    CharacterLevelPicBoxLabel5.Visible = false;
                    CharacterNamePicBoxLabel5.Visible = false;
                    OpenCharacterDisplay5.Visible = false;
                    CharacterCustomizationButton5.Visible = false;

                    CharacterNamePicBoxLabel1.Visible = true;
                    CharacterNamePicBoxLabel2.Visible = true;
                    CharacterNamePicBoxLabel3.Visible = true;
                    CharacterNamePicBoxLabel4.Visible = false;
                    CharacterNamePicBoxLabel5.Visible = false;
                    break;
                case 4:
                    this.BackgroundImage = new Bitmap(Properties.Resources.CharactersBackgroound4Panel);
                    CharacterNameNameLabel1.Visible = true;
                    CharacterLevelLevelLabel1.Visible = true;
                    CharacterRaceRaceLabel1.Visible = true;
                    CharacterRacePicBoxLabel1.Visible = true;
                    CharacterLevelPicBoxLabel1.Visible = true;
                    CharacterNamePicBoxLabel1.Visible = true;
                    OpenCharacterDisplay1.Visible = true;
                    CharacterCustomizationButton1.Visible = true;

                    CharacterNameNameLabel2.Visible = true;
                    CharacterLevelLevelLabel2.Visible = true;
                    CharacterRaceRaceLabel2.Visible = true;
                    CharacterRacePicBoxLabel2.Visible = true;
                    CharacterLevelPicBoxLabel2.Visible = true;
                    CharacterNamePicBoxLabel2.Visible = true;
                    OpenCharacterDisplay2.Visible = true;
                    CharacterCustomizationButton2.Visible = true;

                    CharacterNameNameLabel3.Visible = true;
                    CharacterLevelLevelLabel3.Visible = true;
                    CharacterRaceRaceLabel3.Visible = true;
                    CharacterRacePicBoxLabel3.Visible = true;
                    CharacterLevelPicBoxLabel3.Visible = true;
                    CharacterNamePicBoxLabel3.Visible = true;
                    OpenCharacterDisplay3.Visible = true;
                    CharacterCustomizationButton3.Visible = true;

                    CharacterNameNameLabel4.Visible = true;
                    CharacterLevelLevelLabel4.Visible = true;
                    CharacterRaceRaceLabel4.Visible = true;
                    CharacterRacePicBoxLabel4.Visible = true;
                    CharacterLevelPicBoxLabel4.Visible = true;
                    CharacterNamePicBoxLabel4.Visible = true;
                    OpenCharacterDisplay4.Visible = true;
                    CharacterCustomizationButton4.Visible = true;

                    CharacterNameNameLabel5.Visible = false;
                    CharacterLevelLevelLabel5.Visible = false;
                    CharacterRaceRaceLabel5.Visible = false;
                    CharacterRacePicBoxLabel5.Visible = false;
                    CharacterLevelPicBoxLabel5.Visible = false;
                    CharacterNamePicBoxLabel5.Visible = false;
                    OpenCharacterDisplay5.Visible = false;
                    CharacterCustomizationButton5.Visible = false;

                    CharacterNamePicBoxLabel1.Visible = true;
                    CharacterNamePicBoxLabel2.Visible = true;
                    CharacterNamePicBoxLabel3.Visible = true;
                    CharacterNamePicBoxLabel4.Visible = true;
                    CharacterNamePicBoxLabel5.Visible = false;
                    break;
                case 5:
                    this.BackgroundImage = new Bitmap(Properties.Resources.CharactersBackgroound5Panel);
                    CharacterNameNameLabel1.Visible = true;
                    CharacterLevelLevelLabel1.Visible = true;
                    CharacterRaceRaceLabel1.Visible = true;
                    CharacterRacePicBoxLabel1.Visible = true;
                    CharacterLevelPicBoxLabel1.Visible = true;
                    CharacterNamePicBoxLabel1.Visible = true;
                    OpenCharacterDisplay1.Visible = true;
                    CharacterCustomizationButton1.Visible = true;

                    CharacterNameNameLabel2.Visible = true;
                    CharacterLevelLevelLabel2.Visible = true;
                    CharacterRaceRaceLabel2.Visible = true;
                    CharacterRacePicBoxLabel2.Visible = true;
                    CharacterLevelPicBoxLabel2.Visible = true;
                    CharacterNamePicBoxLabel2.Visible = true;
                    OpenCharacterDisplay2.Visible = true;
                    CharacterCustomizationButton2.Visible = true;

                    CharacterNameNameLabel3.Visible = true;
                    CharacterLevelLevelLabel3.Visible = true;
                    CharacterRaceRaceLabel3.Visible = true;
                    CharacterRacePicBoxLabel3.Visible = true;
                    CharacterLevelPicBoxLabel3.Visible = true;
                    CharacterNamePicBoxLabel3.Visible = true;
                    OpenCharacterDisplay3.Visible = true;
                    CharacterCustomizationButton3.Visible = true;

                    CharacterNameNameLabel4.Visible = true;
                    CharacterLevelLevelLabel4.Visible = true;
                    CharacterRaceRaceLabel4.Visible = true;
                    CharacterRacePicBoxLabel4.Visible = true;
                    CharacterLevelPicBoxLabel4.Visible = true;
                    CharacterNamePicBoxLabel4.Visible = true;
                    OpenCharacterDisplay4.Visible = true;
                    CharacterCustomizationButton4.Visible = true;

                    CharacterNameNameLabel5.Visible = true;
                    CharacterLevelLevelLabel5.Visible = true;
                    CharacterRaceRaceLabel5.Visible = true;
                    CharacterRacePicBoxLabel5.Visible = true;
                    CharacterLevelPicBoxLabel5.Visible = true;
                    CharacterNamePicBoxLabel5.Visible = true;
                    OpenCharacterDisplay5.Visible = true;
                    CharacterCustomizationButton5.Visible = true;

                    CharacterNamePicBoxLabel1.Visible = true;
                    CharacterNamePicBoxLabel2.Visible = true;
                    CharacterNamePicBoxLabel3.Visible = true;
                    CharacterNamePicBoxLabel4.Visible = true;
                    CharacterNamePicBoxLabel5.Visible = true;
                    break;


            }
            CharactersNumbers.Text = connection.NumberOfCharactersCreated().ToString();

            RefreshButton.Enabled = true;
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
        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}