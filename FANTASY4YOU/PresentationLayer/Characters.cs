using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using FANTASY4YOU;

namespace FANTASY4YOU
{
    public partial class Characters : Form
    {
        Logic logic = new Logic();
        CharacterRegistration chr = new CharacterRegistration();
        Thread registerCharacter;
        public Characters()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {


            
            string numberOfCharacters = logic.NumberOfCharactersCreated().ToString();
            int numberOfCharecters1 = logic.NumberOfCharactersCreated();
            CharactersNumbers.Text = numberOfCharacters;
            CharacterPannel1.BackColor = Color.FromArgb(125, Color.Black);
            CharacterPannel2.BackColor = Color.FromArgb(125, Color.Black);
            CharacterPannel3.BackColor = Color.FromArgb(125, Color.Black);
            CharacterPannel4.BackColor = Color.FromArgb(125, Color.Black);
            CharacterPannel5.BackColor = Color.FromArgb(125, Color.Black);
            
            //Character Name Label
            List<string>[] list = logic.SelectCharacterInformation(1);
            CharacterPannelLabel1.Text = string.Join("", list[0].ToArray());
            List<string>[] list2 = logic.SelectCharacterInformation(2);
            CharacterPannelLabel2.Text = string.Join("", list2[0].ToArray());
            List<string>[] list3 = logic.SelectCharacterInformation(3);
            CharacterPannelLabel3.Text = string.Join("", list3[0].ToArray());
            List<string>[] list4 = logic.SelectCharacterInformation(4);
            CharacterPannelLabel4.Text = string.Join("", list4[0].ToArray());
            List<string>[] list5 = logic.SelectCharacterInformation(5);
            CharacterPannelLabel5.Text = string.Join("", list5[0].ToArray());


            //Character Level Label
            List<string>[] list6 = logic.SelectCharacterInformation(1);
            CharacterLevelPannelLabel1.Text = String.Join("", list6[2].ToArray());
            List<string>[] list7 = logic.SelectCharacterInformation(2);
            CharacterLevelPannelLabel2.Text = String.Join("", list7[2].ToArray());
            List<string>[] list8 = logic.SelectCharacterInformation(3);
            CharacterLevelPannelLabel3.Text = String.Join("", list8[2].ToArray());
            List<string>[] list9 = logic.SelectCharacterInformation(4);
            CharacterLevelPannelLabel4.Text = String.Join("", list9[2].ToArray());
            List<string>[] list10 = logic.SelectCharacterInformation(5);
            CharacterLevelPannelLabel5.Text = String.Join("", list10[2].ToArray());

            //Character Race Label
            List<string>[] list11 = logic.SelectCharacterInformation(1);
            CharacterRacePannelLabel1.Text = String.Join("", list11[3].ToArray());
            List<string>[] list12 = logic.SelectCharacterInformation(2);
            CharacterRacePannelLabel2.Text = String.Join("", list12[3].ToArray());
            List<string>[] list13 = logic.SelectCharacterInformation(3);
            CharacterRacePannelLabel3.Text = String.Join("", list13[3].ToArray());
            List<string>[] list14 = logic.SelectCharacterInformation(4);
            CharacterRacePannelLabel4.Text = String.Join("", list14[3].ToArray());
            List<string>[] list15 = logic.SelectCharacterInformation(5);
            CharacterRacePannelLabel5.Text = String.Join("", list15[3].ToArray());



            switch (numberOfCharecters1)
            {
                case 0:
                    CharacterPannel1.Visible = false;
                    CharacterPannel2.Visible = false;
                    CharacterPannel3.Visible = false;
                    CharacterPannel4.Visible = false;
                    CharacterPannel5.Visible = false;

                    CharacterPannelLabel1.Visible = false;
                    CharacterPannelLabel2.Visible = false;
                    CharacterPannelLabel3.Visible = false;
                    CharacterPannelLabel4.Visible = false;
                    CharacterPannelLabel5.Visible = false;
                    break;
                case 1:
                    CharacterPannel1.Visible = true;
                    CharacterPannel2.Visible = false;
                    CharacterPannel3.Visible = false;
                    CharacterPannel4.Visible = false;
                    CharacterPannel5.Visible = false;

                    CharacterPannelLabel1.Visible = true;
                    CharacterPannelLabel2.Visible = false;
                    CharacterPannelLabel3.Visible = false;
                    CharacterPannelLabel4.Visible = false;
                    CharacterPannelLabel5.Visible = false;
                    break;
                case 2:
                    CharacterPannel1.Visible = true;
                    CharacterPannel2.Visible = true;
                    CharacterPannel3.Visible = false;
                    CharacterPannel4.Visible = false;
                    CharacterPannel5.Visible = false;

                    CharacterPannelLabel1.Visible = true;
                    CharacterPannelLabel2.Visible = true;
                    CharacterPannelLabel3.Visible = false;
                    CharacterPannelLabel4.Visible = false;
                    CharacterPannelLabel5.Visible = false;
                    break;
                case 3:
                    CharacterPannel1.Visible = true;
                    CharacterPannel2.Visible = true;
                    CharacterPannel3.Visible = true;
                    CharacterPannel4.Visible = false;
                    CharacterPannel5.Visible = false;

                    CharacterPannelLabel1.Visible = true;
                    CharacterPannelLabel2.Visible = true;
                    CharacterPannelLabel3.Visible = true;
                    CharacterPannelLabel4.Visible = false;
                    CharacterPannelLabel5.Visible = false;
                    break ;
                case 4:
                    CharacterPannel1.Visible = true;
                    CharacterPannel2.Visible = true;
                    CharacterPannel3.Visible = true;
                    CharacterPannel4.Visible = true;
                    CharacterPannel5.Visible = false;

                    CharacterPannelLabel1.Visible = true;
                    CharacterPannelLabel2.Visible = true;
                    CharacterPannelLabel3.Visible = true;
                    CharacterPannelLabel4.Visible = true;
                    CharacterPannelLabel5.Visible = false;
                    break;
                case 5:
                    CharacterPannel1.Visible = true;
                    CharacterPannel2.Visible = true;
                    CharacterPannel3.Visible = true;
                    CharacterPannel4.Visible = true;
                    CharacterPannel5.Visible = true;

                    CharacterPannelLabel1.Visible = true;
                    CharacterPannelLabel2.Visible = true;
                    CharacterPannelLabel3.Visible = true;
                    CharacterPannelLabel4.Visible = true;
                    CharacterPannelLabel5.Visible = true;
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
            Form1_Load(sender, EventArgs.Empty);
            RefreshButton.Enabled = false;
            System.Threading.Thread.Sleep(3000);
            RefreshButton.Enabled = true;
        }

        private void CharacterPannel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}