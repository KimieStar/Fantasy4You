using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FANTASY4YOU
{
    public partial class CharacterCustomizationChar4 : Form
    {
        Logic logic = new Logic();
        public CharacterCustomizationChar4()
        {
            InitializeComponent();
        }

        private void CharacterCustomizationChar4_Load(object sender, EventArgs e)
        {
            List<string>[] list1 = logic.SelectCharacterInformation2(4);
            CharacterStrenghtTextbox.Text = string.Join("", list1[0].ToArray());
            List<string>[] list2 = logic.SelectCharacterInformation2(4);
            CharacterDexterityTextbox.Text = string.Join("", list2[1].ToArray());
            List<string>[] list3 = logic.SelectCharacterInformation2(4);
            CharacterConstitutionTextbox.Text = string.Join("", list3[2].ToArray());
            List<string>[] list4 = logic.SelectCharacterInformation2(4);
            CharacterIntelligenceTextbox.Text = string.Join("", list4[3].ToArray());
            List<string>[] list5 = logic.SelectCharacterInformation2(4);
            CharacterWisdomTextbox.Text = string.Join("", list5[4].ToArray());
            List<string>[] list6 = logic.SelectCharacterInformation2(4);
            CharacterCharismaTextbox.Text = string.Join("", list6[5].ToArray());
        }

        private void UpdateCharacterDetailsButton_Click(object sender, EventArgs e)
        {
            int charNum = 4;
            int strenght = Int32.Parse(CharacterStrenghtTextbox.Text);
            int dexterity = Int32.Parse(CharacterDexterityTextbox.Text);
            int constitution = Int32.Parse(CharacterConstitutionTextbox.Text);
            int intelligence = Int32.Parse(CharacterIntelligenceTextbox.Text);
            int wisdom = Int32.Parse(CharacterWisdomTextbox.Text);
            int charisma = Int32.Parse(CharacterCharismaTextbox.Text);
            logic.UpdateCharacterDetails(charNum, strenght, dexterity, constitution, intelligence, wisdom, charisma);
            MessageBox.Show("Success!");
        }
    }
}
