using FANTASY4YOU;
namespace FANTASY4YOU
{
    public partial class CharacterDisplayer : Form
    {
        LogicController logic = new LogicController();
        
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
    }
}