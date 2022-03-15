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
        public int characterNumberSelectedToCustomize;
        //Characters characters = new Characters();
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

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
            WindowTopBar.BackColor = Color.FromArgb(190, Color.Black);
            HelperPanel.BackColor = Color.FromArgb(190, Color.Black);
            CharNamePannel.BackColor  = Color.FromArgb(165, Color.Black);
            StrenghtPanel.BackColor = Color.FromArgb(165, Color.Black);
            BackgroundPannel.BackColor= Color.FromArgb(165,Color.Black);
            CharNamePannel.Location = new Point(0, 28);
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
                logic.UpdateCharacterDetails(User.CharSelected, Int32.Parse(CharacterStrenghtTextbox.Text),
                Int32.Parse(CharacterDexterityTextbox.Text), Int32.Parse(CharacterConstitutionTextbox.Text),
                Int32.Parse(CharacterIntelligenceTextbox.Text), Int32.Parse(CharacterWisdomTextbox.Text), Int32.Parse(CharacterCharismaTextbox.Text)); ;
                MessageBox.Show("Success!");
            }
            
            
        }

        private void MoreCustomizationsToBackground_Click(object sender, EventArgs e)
        {
            StrenghtPanel.Visible = false;
            
            BackgroundPannel.Location = new Point(0, 28);
            BackgroundPannel.Visible = true;
            
        }

        private void UpdateCharacterDetailsButton2_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(CharacterNameCustomizeTextbox.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Character name can be only letters");
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
                logic.UpdateCharacterDetails2(User.CharSelected, CharacterNameCustomizeTextbox.Text, CharacterClassCustomizeTextbox.Text,
                Int32.Parse(CharacterLevelCustomizeTextbox.Text), CharacterRaceCustomizeCombobox.Text,
                Int32.Parse(CharacterXpCustomizeTextBox.Text), CharacterAlignmentCustomizeCombobox.Text);
                MessageBox.Show("Success!");
            }
            
        }

        private void MoreCustomizationsToCharName_Click(object sender, EventArgs e)
        {
            BackgroundPannel.Visible = false;

            CharNamePannel.Location = new Point(0, 28);
            CharNamePannel.Visible = true;
            
        }

        private void CharacterBackgroundCustomizeButton_Click(object sender, EventArgs e)
        {
            logic.UpdateCharacterDetails3(User.CharSelected, CharacterBackgroundCustomizeTextbox.Text);
            MessageBox.Show("Success!");
        }

        private void MoreCustomizationsToSrenght_Click(object sender, EventArgs e)
        {
            CharNamePannel.Visible = false;
            StrenghtPanel.Location = new Point(0, 28);
            StrenghtPanel.Visible = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CharacterConstitutionConstitutionLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void WindowTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void HelperPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CharacterBackgroundCustomizeTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
