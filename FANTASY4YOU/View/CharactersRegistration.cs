using FANTASY4YOU;
namespace FANTASY4YOU
{
    public partial class CharacterRegistration : Form
    {
        LogicController logic = new LogicController();

        
        
        public CharacterRegistration()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string characterName1 = characterNameTextBox.Text;
            string levelTextBox = levelBox.Text;
            string xpTextbox = xpTextBox.Text;
            string backgroundText = backgroundTextBox.Text;
            
            if (characterNameTextBox.Text == "" || classComboBox.Text == "" || levelBox.Text == "" || raceComboBox.Text == "" || backgroundTextBox.Text == "" || xpTextBox.Text == "" || alignmentComboBox.Text == "")
            {
                MessageBox.Show("Please fill in your character specifications");
            }
            else if (logic.CheckCharacterNameExistForUser(characterName1) == true)
            {
                MessageBox.Show("You already have character with that name");
            }
            else if (logic.CheckIfTextBoxOnlyNumbers(levelTextBox) == false)
            {
                MessageBox.Show("Level can be only a number");
            }
            else if (logic.CheckIfTextBoxOnlyNumbers(xpTextbox) == false)
            {
                MessageBox.Show("Xp can only be a number");
            }
            else if (logic.NumberOfCharactersCreated() == 5)
            {
                MessageBox.Show("You cannot create more Characters. You need to upgade to premium account.");
            }
            else if (characterNameTextBox.Text != "" || classComboBox.Text != "" || levelBox.Text != "" || raceComboBox.Text != "" || backgroundTextBox.Text != "" || xpTextBox.Text != "" || alignmentComboBox.Text != "")
            {
                string characterName = characterNameTextBox.Text;
                string classs = classComboBox.Text;
                int level = Int32.Parse(levelBox.Text);
                string race = raceComboBox.Text;
                string backgroundStory = backgroundTextBox.Text;
                int xpPoints = Int32.Parse(xpTextBox.Text);
                string alignment = alignmentComboBox.Text;

                logic.InsertCharacterDetails(characterName, classs, level, race, backgroundStory, xpPoints, alignment);
                MessageBox.Show("Character succefully created. Enjoy!");
            }
        
         }

        private void characterNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CharactersRegistration_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}