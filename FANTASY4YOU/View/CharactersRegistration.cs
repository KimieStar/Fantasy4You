using FANTASY4YOU;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace FANTASY4YOU
{
    public partial class CharacterRegistration : Form
    {
        DatabaseController connection = new DatabaseController();

        
        
        public CharacterRegistration()
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

        private void CreateCharacter_Click(object sender, EventArgs e)
        {
            if (characterNameTextBox.Text == "" || classComboBox.Text == "" || levelBox.Text == "" || raceComboBox.Text == "" || backgroundTextBox.Text == "" || xpTextBox.Text == "" || alignmentComboBox.Text == "")
            {
                MessageBox.Show("Please fill in your character specifications");
            }
            else if (!Regex.IsMatch(characterNameTextBox.Text, @"^[a-zA-Z\s_]+$"))
            {
                MessageBox.Show("Character Name can be only be letters");
            }
            else if (characterNameTextBox.TextLength > 12)
            {
                MessageBox.Show("Username can be only 12 letters long");
            }
            else if (connection.CheckCharacterNameExistForUser(characterNameTextBox.Text) == true)
            {
                MessageBox.Show("You already have character with that name");
            }
            else if (!Regex.IsMatch(levelBox.Text, @"^\d+$"))
            {
                MessageBox.Show("Level can be only a number");
            }
            else if (!Regex.IsMatch(xpTextBox.Text, @"^\d+$"))
            {
                MessageBox.Show("Xp can only be a number");
            }
            else if (connection.NumberOfCharactersCreated() == 5)
            {
                MessageBox.Show("You cannot create more Characters. You need to upgade to premium account.");
            }
            else if (Int32.Parse(levelBox.Text) > 20)
            {
                MessageBox.Show("Level 20 is the max level.");
            }
            else if (Int32.Parse(xpTextBox.Text) > 5000)
            {
                MessageBox.Show("You can start with max of 5000 experience points");
            }
            else if (characterNameTextBox.Text != "" || classComboBox.Text != "" || levelBox.Text != "" || raceComboBox.Text != "" || backgroundTextBox.Text != "" || xpTextBox.Text != "" || alignmentComboBox.Text != "")
            {
                string chName = characterNameTextBox.Text;
                string classs = classComboBox.Text;
                int level = Int32.Parse(levelBox.Text);
                string race = raceComboBox.Text;
                string backgroundStory = backgroundTextBox.Text;
                int xpPoints = Int32.Parse(xpTextBox.Text);
                string alignment = alignmentComboBox.Text;

                connection.InsertCharacterDetails(chName, classs, level, race, backgroundStory, xpPoints, alignment);
                MessageBox.Show("Character succefully created. Enjoy!");
                this.Close();
            }
        
         }
    }
}