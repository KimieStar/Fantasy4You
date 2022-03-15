using FANTASY4YOU;
using System.Runtime.InteropServices;

namespace FANTASY4YOU
{
    public partial class CharacterDisplayer : Form
    {
        LogicController logic = new LogicController();
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public CharacterDisplayer()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
    {
        get
        {
            CreateParams cp = base.CreateParams;
            cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
            return cp;
        }
    }

        private void CharacterDisplayer_Load(object sender, EventArgs e)
        {
            DisplayPanel.BackColor = Color.FromArgb(125, Color.Black);
            WindowTopBar.BackColor = Color.FromArgb(165, Color.Black);
            HelperPanel.BackColor = Color.FromArgb(165, Color.Black);
            int chNum = User.CharSelected;
            Character character = logic.SelectCharInfo(chNum);
            CharacterName.Text = character.CharacterName;
            CharacterClass.Text = character.CharacterClass;
            CharacterLevel.Text = character.CharacterLevel.ToString();
            CharacterRace.Text = character.CharacterRace;
            CharacterXp.Text = character.CharacterXp.ToString();
            CharacterAlignment.Text = character.CharacterAlignment;
            CharacterBackground.Text = character.CharacterBackgroundStory;
            CharacterStrenght.Text = character.CharacterStrenght.ToString();
            CharacterDexterity.Text = character.CharacterDexterity.ToString();
            CharacterConstitution.Text = character.CharacterConstitution.ToString();
            CharacterIntelligence.Text = character.CharacterIntelligence.ToString();
            CharacterWisdom.Text = character.CharacterWisdom.ToString();
            CharacterCharisma.Text = character.CharacterCharisma.ToString();
        }

        private void WindowTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void HelperPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}