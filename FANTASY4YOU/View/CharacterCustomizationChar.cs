using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using FANTASY4YOU;

namespace FANTASY4YOU
{
    public partial class CharacterCustomizationChar : Form
    {
        LogicController logic = new LogicController();
        DatabaseController connection = new DatabaseController();
        public int characterNumberSelectedToCustomize;

        public CharacterCustomizationChar()
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
        private void CharacterCustomization_Load(object sender, EventArgs e)
        {
            CharNamePannel.BackColor  = Color.FromArgb(165, Color.Black);
            StrenghtPanel.BackColor = Color.FromArgb(165, Color.Black);
            BackgroundPannel.BackColor= Color.FromArgb(165,Color.Black);
            CharNamePannel.Location = new Point(0,0);
            int charNum = User.CharSelected;
            Character character = connection.SelectCharInfo(charNum);
            CharacterNameCustomizeTextbox.Text = character.CharacterName;
            CharacterClassCustomizeTextbox.Text = character.CharacterClass;
            CharacterLevelCustomizeTextbox.Text = character.CharacterLevel.ToString();
            CharacterRaceCustomizeCombobox.Text = character.CharacterRace;
            CharacterBackgroundCustomizeTextbox.Text = character.CharacterBackgroundStory;
            CharacterXpCustomizeTextBox.Text = character.CharacterXp.ToString();
            CharacterAlignmentCustomizeCombobox.SelectedItem = character.CharacterAlignment;
            CharacterStrenghtTextbox.Text = character.CharacterStrenght.ToString();
            CharacterDexterityTextbox.Text = character.CharacterDexterity.ToString();
            CharacterConstitutionTextbox.Text = character.CharacterConstitution.ToString();
            CharacterIntelligenceTextbox.Text = character.CharacterIntelligence.ToString();
            CharacterWisdomTextbox.Text = character.CharacterWisdom.ToString();
            CharacterCharismaTextbox.Text = character.CharacterCharisma.ToString();

        }

        private void UpdateCharacterDetailsButton_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(CharacterStrenghtTextbox.Text, @"^\d+$"))
            {
                MessageBox.Show("Strenght can be only a number");
            }
            else if (!Regex.IsMatch(CharacterDexterityTextbox.Text, @"^\d+$"))
            {
                MessageBox.Show("Dexterity can be only a number");
            }
            else if (!Regex.IsMatch(CharacterConstitutionTextbox.Text, @"^\d+$"))
            {
                MessageBox.Show("Constitution can be only a number");
            }
            else if (!Regex.IsMatch(CharacterIntelligenceTextbox.Text, @"^\d+$"))
            {
                MessageBox.Show("Intelligence can be only a number");
            }
            else if (!Regex.IsMatch(CharacterWisdomTextbox.Text, @"^\d+$"))
            {
                MessageBox.Show("Wisdom can be only a number");
            }
            else if (!Regex.IsMatch(CharacterCharismaTextbox.Text, @"^\d+$"))
            {
                MessageBox.Show("Charisma can be only a number");
            }
            else
            {
                connection.UpdateCharacterDetails(User.CharSelected, Int32.Parse(CharacterStrenghtTextbox.Text),
                Int32.Parse(CharacterDexterityTextbox.Text), Int32.Parse(CharacterConstitutionTextbox.Text),
                Int32.Parse(CharacterIntelligenceTextbox.Text), Int32.Parse(CharacterWisdomTextbox.Text), Int32.Parse(CharacterCharismaTextbox.Text)); ;
                MessageBox.Show("Success!");
            }
            
            
        }

        private void MoreCustomizationsToBackground_Click(object sender, EventArgs e)
        {
            if (CharacterStrenghtTextbox.Text == "" || CharacterDexterityTextbox.Text == "" || CharacterConstitutionTextbox.Text == "" || CharacterIntelligenceTextbox.Text == "" || CharacterWisdomTextbox.Text == "" || CharacterCharismaTextbox.Text == "")
            {
                MessageBox.Show("Do not leave empty spaces");
            }
            else if (logic.CheckIfInfoHasBeenSaved2(User.CharSelected, Int32.Parse(CharacterStrenghtTextbox.Text),
                Int32.Parse(CharacterDexterityTextbox.Text), Int32.Parse(CharacterConstitutionTextbox.Text),
                Int32.Parse(CharacterIntelligenceTextbox.Text), Int32.Parse(CharacterWisdomTextbox.Text), Int32.Parse(CharacterCharismaTextbox.Text)) == true)
                {
                    StrenghtPanel.Visible = false;
                    BackgroundPannel.Location = new Point(0, 0);
                    BackgroundPannel.Visible = true;
                }
            else
            {
                MessageBox.Show("You have not saved your info!");
            }
            
        }

        private void UpdateCharacterDetailsButton2_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(CharacterNameCustomizeTextbox.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Character name can be only letters");
            }
            else if (CharacterNameCustomizeTextbox.TextLength > 20)
            {
                MessageBox.Show("Username can be only 20 letters!");
            }
            else if (!Regex.IsMatch(CharacterLevelCustomizeTextbox.Text, @"^\d+$"))
            {
                MessageBox.Show("Level can be only a number");
            }
            else if (!Regex.IsMatch(CharacterXpCustomizeTextBox.Text, @"^\d+$"))
            {
                MessageBox.Show("Xp can only be a number");
            }
            else if (Int32.Parse(CharacterLevelCustomizeTextbox.Text) > 20)
            {
                MessageBox.Show("Level 20 is the max level.");
            }
            else
            {
                connection.UpdateCharacterDetails2(User.CharSelected, CharacterNameCustomizeTextbox.Text, CharacterClassCustomizeTextbox.Text,
                Int32.Parse(CharacterLevelCustomizeTextbox.Text), CharacterRaceCustomizeCombobox.Text,
                Int32.Parse(CharacterXpCustomizeTextBox.Text), CharacterAlignmentCustomizeCombobox.Text);
                MessageBox.Show("Success!");
            }
            
        }

        private void MoreCustomizationsToCharName_Click(object sender, EventArgs e)
        {
            if (CharacterBackgroundCustomizeTextbox.Text == "")
            {
                MessageBox.Show("Do not leave empty spaces");
            }
            else if (logic.CheckIfInfoHasBeenSaved3(User.CharSelected, CharacterBackgroundCustomizeTextbox.Text) == true)
            {
                BackgroundPannel.Visible = false;
                CharNamePannel.Location = new Point(0, 0);
                CharNamePannel.Visible = true;
            }
            else
            {
                MessageBox.Show("You have not saved your info!");
            }

            
        }

        private void CharacterBackgroundCustomizeButton_Click(object sender, EventArgs e)
        {
            connection.UpdateCharacterDetails3(User.CharSelected, CharacterBackgroundCustomizeTextbox.Text);
            MessageBox.Show("Success!");
        }

        private void MoreCustomizationsToSrenght_Click(object sender, EventArgs e)
        {
            if (CharacterNameCustomizeTextbox.Text == "" || CharacterClassCustomizeTextbox.Text == "" || CharacterLevelCustomizeTextbox.Text == "" || CharacterRaceCustomizeCombobox.Text == "" || CharacterXpCustomizeTextBox.Text == "" || CharacterAlignmentCustomizeCombobox.Text == "")
            {
                MessageBox.Show("Do not leave empty spaces");
            }
           else if (logic.CheckIfInfoHasBeenSaved1(User.CharSelected, CharacterNameCustomizeTextbox.Text, CharacterClassCustomizeTextbox.Text,
                Int32.Parse(CharacterLevelCustomizeTextbox.Text), CharacterRaceCustomizeCombobox.Text,
                Int32.Parse(CharacterXpCustomizeTextBox.Text), CharacterAlignmentCustomizeCombobox.Text) == true)
            {
                CharNamePannel.Visible = false;
                StrenghtPanel.Location = new Point(0, 0);
                StrenghtPanel.Visible = true;
            }
            else
            {
                MessageBox.Show("You have not saved your info!");
            }
            
        }
    }
}
