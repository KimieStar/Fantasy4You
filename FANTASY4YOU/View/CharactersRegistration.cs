using FANTASY4YOU;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace FANTASY4YOU
{
    public partial class CharacterRegistration : Form
    {
        LogicController logic = new LogicController();

        
        
        public CharacterRegistration()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
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
        private void CreateCharacter_Click(object sender, EventArgs e)
        {
            if (characterNameTextBox.Text == "" || classComboBox.Text == "" || levelBox.Text == "" || raceComboBox.Text == "" || backgroundTextBox.Text == "" || xpTextBox.Text == "" || alignmentComboBox.Text == "")
            {
                MessageBox.Show("Please fill in your character specifications");
            }
            else if (logic.CheckCharacterNameExistForUser(characterNameTextBox.Text) == true)
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
            else if (logic.NumberOfCharactersCreated() == 5)
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
            else if (!Regex.IsMatch(characterNameTextBox.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Character Name can be only be letters");
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

                logic.InsertCharacterDetails(chName, classs, level, race, backgroundStory, xpPoints, alignment);
                MessageBox.Show("Character succefully created. Enjoy!");
            }
        
         }
        private void WindowTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HelperPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CharacterRegistration_Load(object sender, EventArgs e)
        {

            WindowTopBar.BackColor = Color.FromArgb(165, Color.Black);
            CharacterCreationPanel.BackColor = Color.FromArgb(125, Color.Black);
            HelperPanel.BackColor = Color.Transparent;
        }
    }
}