using FANTASY4YOU;
namespace FANTASY4YOU
{
    public partial class CharacterDisplayer : Form
    {
        Logic logic = new Logic();
        public CharacterDisplayer()
        {
            InitializeComponent();
        }

        private void CharacterDisplayer_Load(object sender, EventArgs e)
        {
            int chNum = logic.readCharSelectedToDisplayFile();
            List<string>[] list = logic.SelectCharacterInformation(chNum);
            List<string>[] list2 = logic.SelectCharacterInformation2(chNum);
            CharacterName.Text = String.Join("", list[0]);
            CharacterClass.Text = String.Join("", list[1]);
            CharacterLevel.Text = String.Join("", list[2]);
            CharacterRace.Text = String.Join("", list[3]);
            CharacterXp.Text = String.Join("", list[5]);
            CharacterAlignment.Text = String.Join("", list[6]);
            CharacterBackground.Text = String.Join("", list[4]);
            CharacterStrenght.Text = String.Join("", list2[0]);
            CharacterDexterity.Text = String.Join("", list2[1]);
            CharacterConstitution.Text = String.Join("", list2[2]);
            CharacterIntelligence.Text = String.Join("", list2[3]);
            CharacterWisdom.Text = String.Join("", list2[4]);
            CharacterCharisma.Text = String.Join("", list2[5]);
        }
    }
}