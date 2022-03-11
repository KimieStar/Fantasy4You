using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FANTASY4YOU;

namespace FANTASY4YOU
{
    public partial class CharacterCustomizationChar : Form
    {
        LogicController logic = new LogicController();
        public int characterNumberSelectedToCustomize;
        //Characters characters = new Characters();


        public CharacterCustomizationChar()
        {
            InitializeComponent();
        }

        private void CharacterCustomization_Load(object sender, EventArgs e)
        {
            int charNum = User.CharSelected;
            Character character = logic.SelectCharInfo(charNum);
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
            logic.UpdateCharacterDetails(User.CharSelected, Int32.Parse(CharacterStrenghtTextbox.Text),
            Int32.Parse(CharacterDexterityTextbox.Text), Int32.Parse(CharacterConstitutionTextbox.Text),
            Int32.Parse(CharacterIntelligenceTextbox.Text), Int32.Parse(CharacterWisdomTextbox.Text), Int32.Parse(CharacterCharismaTextbox.Text)); ;
            MessageBox.Show("Success!");
            
        }

        private void MoreCustomizations_Click(object sender, EventArgs e)
        {
            CharacterStrenghtStrenghtLabel.Visible = false;
            CharacterDexterityDexterityLabel.Visible = false;
            CharacterConstitutionConstitutionLabel.Visible = false;
            CharacterIntelligenceIntelligenceLabel.Visible = false;
            CharacterWisdomWisdomLabel.Visible = false;
            CharacterCharismaCharismaLabel.Visible = false;
            CharacterStrenghtTextbox.Visible = false;
            CharacterDexterityTextbox.Visible=false;
            CharacterConstitutionTextbox.Visible=false;
            CharacterIntelligenceTextbox.Visible = false;
            CharacterWisdomTextbox.Visible = false;
            CharacterCharismaTextbox.Visible = false;
            UpdateCharacterDetailsButton.Visible = false;
            MoreCustomizations.Visible = false;

            CharacterNameCustomizeLabel.Visible = true;
            CharacterClassCustomizeLabel.Visible = true;
            CharacterLevelCustomizeLabel.Visible = true;
            CharacterRaceCustomizeLabel.Visible = true;
            CharacterXpCustomizeLabel.Visible = true;
            CharacterAlignmentCustomizeLabel.Visible = true;
            CharacterNameCustomizeTextbox.Visible = true;
            CharacterClassCustomizeTextbox.Visible = true;
            CharacterLevelCustomizeTextbox.Visible = true;
            CharacterRaceCustomizeCombobox.Visible = true;
            CharacterXpCustomizeTextBox.Visible = true;
            CharacterAlignmentCustomizeCombobox.Visible = true;
            UpdateCharacterDetailsButton2.Visible = true;
            MoreCustomizations2.Visible = true;
        }

        private void UpdateCharacterDetailsButton2_Click(object sender, EventArgs e)
        {
            
            logic.UpdateCharacterDetails2(User.CharSelected, CharacterNameCustomizeTextbox.Text, CharacterClassCustomizeTextbox.Text,
            Int32.Parse(CharacterLevelCustomizeTextbox.Text), CharacterRaceCustomizeCombobox.Text,
            Int32.Parse(CharacterXpCustomizeTextBox.Text), CharacterAlignmentCustomizeCombobox.Text);
            MessageBox.Show("Success!");
        }

        private void MoreCustomizations2_Click(object sender, EventArgs e)
        {
            CharacterNameCustomizeLabel.Visible = false;
            CharacterClassCustomizeLabel.Visible = false;
            CharacterLevelCustomizeLabel.Visible = false;
            CharacterRaceCustomizeLabel.Visible = false;
            CharacterXpCustomizeLabel.Visible = false;
            CharacterAlignmentCustomizeLabel.Visible = false;
            CharacterNameCustomizeTextbox.Visible = false;
            CharacterClassCustomizeTextbox.Visible = false;
            CharacterLevelCustomizeTextbox.Visible = false;
            CharacterRaceCustomizeCombobox.Visible = false;
            CharacterXpCustomizeTextBox.Visible = false;
            CharacterAlignmentCustomizeCombobox.Visible = false;
            UpdateCharacterDetailsButton2.Visible = false;
            MoreCustomizations2.Visible = false;

            CharacterBackgroundCustomizeLabel.Visible = true;
            CharacterBackgroundCustomizeTextbox.Visible = true;
            CharacterBackgroundCustomizeButton.Visible = true;
            MoreCustomizations3.Visible = true;
        }

        private void CharacterBackgroundCustomizeButton_Click(object sender, EventArgs e)
        {
            logic.UpdateCharacterDetails3(User.CharSelected, CharacterBackgroundCustomizeTextbox.Text);
            MessageBox.Show("Success!");
        }

        private void MoreCustomizations3_Click(object sender, EventArgs e)
        {
            CharacterBackgroundCustomizeLabel.Visible = false;
            CharacterBackgroundCustomizeTextbox.Visible = false;
            CharacterBackgroundCustomizeButton.Visible = false;
            MoreCustomizations3.Visible = false;

            CharacterStrenghtStrenghtLabel.Visible = true;
            CharacterDexterityDexterityLabel.Visible = true;
            CharacterConstitutionConstitutionLabel.Visible = true;
            CharacterIntelligenceIntelligenceLabel.Visible = true;
            CharacterWisdomWisdomLabel.Visible = true;
            CharacterCharismaCharismaLabel.Visible = true;
            CharacterStrenghtTextbox.Visible = true;
            CharacterDexterityTextbox.Visible = true;
            CharacterConstitutionTextbox.Visible = true;
            CharacterIntelligenceTextbox.Visible = true;
            CharacterWisdomTextbox.Visible = true;
            CharacterCharismaTextbox.Visible = true;
            UpdateCharacterDetailsButton.Visible = true;
            MoreCustomizations.Visible = true;
        }
        
    }
}
