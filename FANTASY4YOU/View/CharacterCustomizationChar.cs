using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public CharacterCustomizationChar()
        {
            InitializeComponent();
        }

        private void CharacterCustomization_Load(object sender, EventArgs e)
        {
            WindowTopBar.BackColor = Color.FromArgb(190, Color.Black);
            CharNamePannel.BackColor  = Color.FromArgb(165, Color.Black);
            StrenghtPanel.BackColor = Color.FromArgb(165, Color.Black);
            BackgroundPannel.BackColor= Color.FromArgb(165,Color.Black);
            StrenghtPanel.Location = new Point(0, 28);
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
            StrenghtPanel.Visible = false;

            CharNamePannel.Location = new Point(0, 28);
            CharNamePannel.Visible = true;
            
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
            CharNamePannel.Visible = false;

            BackgroundPannel.Location = new Point(0, 28);
            BackgroundPannel.Visible = true;
            
        }

        private void CharacterBackgroundCustomizeButton_Click(object sender, EventArgs e)
        {
            logic.UpdateCharacterDetails3(User.CharSelected, CharacterBackgroundCustomizeTextbox.Text);
            MessageBox.Show("Success!");
        }

        private void MoreCustomizations3_Click(object sender, EventArgs e)
        {
            BackgroundPannel.Visible = false;

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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
