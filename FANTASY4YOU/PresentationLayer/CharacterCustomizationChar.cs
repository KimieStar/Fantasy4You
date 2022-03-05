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
        Logic logic = new Logic();
        public int characterNumberSelectedToCustomize;
        //Characters characters = new Characters();


        public CharacterCustomizationChar()
        {
            InitializeComponent();
        }

        private void CharacterCustomization_Load(object sender, EventArgs e)
        {
                int charNum = logic.readCharSelectedToEditFile();
                List<string>[] list = logic.SelectCharacterInformation2(charNum);
                CharacterStrenghtTextbox.Text = string.Join("", list[0].ToArray());
                CharacterDexterityTextbox.Text = string.Join("", list[1].ToArray());
                CharacterConstitutionTextbox.Text = string.Join("", list[2].ToArray());
                CharacterIntelligenceTextbox.Text = string.Join("", list[3].ToArray());
                CharacterWisdomTextbox.Text = string.Join("", list[4].ToArray());
                CharacterCharismaTextbox.Text = string.Join("", list[5].ToArray());
                
                List<string>[] list2 = logic.SelectCharacterInformation(charNum);
                CharacterNameCustomizeTextbox.Text = string.Join("",list2[0]);
                CharacterClassCustomizeTextbox.Text = string.Join("",list2[1]);
                CharacterLevelCustomizeTextbox.Text = string.Join("", list2[2]);
                CharacterRaceCustomizeTextbox.Text = string.Join("", list2[3]);
                CharacterBackgroundCustomizeTextbox.Text = string.Join("", list2[4]);
                CharacterXpCustomizeTextBox.Text = string.Join("", list2[5]);
                CharacterAlignmentCustomizeTextbox.Text = string.Join("",list2[6]);

        }

        private void UpdateCharacterDetailsButton_Click(object sender, EventArgs e)
        {
            int charNum = logic.readCharSelectedToEditFile();
            int strenght = Int32.Parse(CharacterStrenghtTextbox.Text);
            int dexterity = Int32.Parse(CharacterDexterityTextbox.Text);
            int constitution = Int32.Parse(CharacterConstitutionTextbox.Text);
            int intelligence = Int32.Parse(CharacterIntelligenceTextbox.Text);
            int wisdom = Int32.Parse(CharacterWisdomTextbox.Text);
            int charisma = Int32.Parse(CharacterCharismaTextbox.Text);
            logic.UpdateCharacterDetails(charNum,strenght,dexterity,constitution,intelligence,wisdom,charisma);
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
            CharacterRaceCustomizeTextbox.Visible = true;
            CharacterXpCustomizeTextBox.Visible = true;
            CharacterAlignmentCustomizeTextbox.Visible = true;
            UpdateCharacterDetailsButton.Visible = true;
            MoreCustomizations2.Visible = true;
        }

        private void UpdateCharacterDetailsButton2_Click(object sender, EventArgs e)
        {
            int charNum = logic.readCharSelectedToEditFile();
            string characterName = CharacterNameCustomizeTextbox.Text;
            string characterClass = CharacterClassCustomizeTextbox.Text;
            int level = Int32.Parse(CharacterLevelCustomizeTextbox.Text);
            string race = CharacterRaceCustomizeTextbox.Text;
            int xp = Int32.Parse(CharacterXpCustomizeTextBox.Text);
            string alignment = CharacterAlignmentCustomizeTextbox.Text;
            logic.UpdateCharacterDetails2(charNum,characterName,characterClass,level,race,xp,alignment);
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
            CharacterRaceCustomizeTextbox.Visible = false;
            CharacterXpCustomizeTextBox.Visible = false;
            CharacterAlignmentCustomizeTextbox.Visible = false;
            UpdateCharacterDetailsButton.Visible = false;
            MoreCustomizations2.Visible = false;

            CharacterBackgroundCustomizeLabel.Visible = true;
            CharacterBackgroundCustomizeTextbox.Visible = true;
            CharacterBackgroundCustomizeButton.Visible = true;
            MoreCustomizations3.Visible = true;
        }

        private void CharacterBackgroundCustomizeButton_Click(object sender, EventArgs e)
        {
            int chNum = logic.readCharSelectedToEditFile();
            string characterBackround = CharacterBackgroundCustomizeTextbox.Text;
            logic.UpdateCharacterDetails3(chNum,characterBackround);
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
