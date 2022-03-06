using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FANTASY4YOU
{
    public class Character
    {
        private string characterName = string.Empty;
        private string characterClass = string.Empty;
        private int characterLevel;
        private string characterRace = string.Empty;
        private string backgroundStory = string.Empty;
        private int xp;
        private string alignment = string.Empty;
        private int strenght;
        private int dexterity;
        private int constitution;
        private int intelligence;
        private int wisdom;
        private int charisma;

        public string CharacterName
        {
            get { return characterName; }
            set { characterName = value; }
        }
        public string CharacterClass
        {
            get { return characterClass; }
            set { characterClass = value; }
        }
        public int CharacterLevel
        {
            get { return characterLevel; }
            set { characterLevel = value; }
        }
        public string CharacterRace
        {
            get { return characterRace; }
            set { characterRace = value; }
        }
        public string CharacterBackgroundStory
        {
            get { return backgroundStory; }
            set { backgroundStory = value; }
        }
        public int CharacterXp
        {
            get { return xp; }
            set { xp = value; }
        }
        public string CharacterAlignment
        {
            get { return alignment; }
            set { alignment = value; }
        }
        public int CharacterStrenght
        {
            get { return strenght; }
            set { strenght = value; }
        }
        public int CharacterDexterity
        {
            get { return dexterity; }
            set { dexterity = value; }
        }
        public int CharacterConstitution
        {
            get { return constitution; }
            set { constitution = value; }
        }
        public int CharacterIntelligence
        {
            get { return intelligence; }
            set { intelligence = value; }
        }
        public int CharacterWisdom
        {
            get { return wisdom; }
            set { wisdom = value; }
        }
        public int CharacterCharisma
        {
            get { return charisma; }
            set { charisma = value; }
        }


        public Character(string characterName, string characterClass, int characterLevel, string characterRace, string backgroundStory, int xp, string alignment, int strenght, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
        {
            CharacterName = characterName;
            CharacterClass = characterClass;
            CharacterLevel = characterLevel;
            CharacterRace = characterRace;
            CharacterBackgroundStory = backgroundStory;
            CharacterXp = xp;
            CharacterAlignment = alignment;
            CharacterStrenght = strenght;
            CharacterDexterity = dexterity;
            CharacterConstitution = constitution;
            CharacterIntelligence = intelligence;
            CharacterWisdom = wisdom;
            CharacterCharisma = charisma;
        }

       
    }


}
