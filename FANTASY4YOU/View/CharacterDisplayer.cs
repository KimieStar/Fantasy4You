using FANTASY4YOU;
using System.Runtime.InteropServices;

namespace FANTASY4YOU
{
    public partial class CharacterDisplayer : Form
    {
        DatabaseController connection = new DatabaseController();
        public CharacterDisplayer()
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

        private void CharacterDisplayer_Load(object sender, EventArgs e)
        {
            int chNum = User.CharSelected;
            Character character = connection.SelectCharInfo(chNum);
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