using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FANTASY4YOU
{
    public partial class DeleteCharacter : Form
    {
        DatabaseController connection = new DatabaseController();
        Character character;
        public DeleteCharacter()
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

        private void DeleteCharacter_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < connection.NumberOfCharactersCreated() + 1; i++)
            {
                switch (i)
                {
                    case 0:
                        this.Size = new System.Drawing.Size(643, 176);

                        Character1.Visible = false;
                        DeleteCharacterButton1.Visible = false;

                        Character2.Visible = false;
                        DeleteCharacterButton2.Visible = false;

                        Character3.Visible = false;
                        DeleteCharacterButton3.Visible = false;

                        Character4.Visible = false;
                        DeleteCharacterButton4.Visible = false;

                        Character5.Visible = false;
                        DeleteCharacterButton5.Visible = false;
                        break;
                    case 1:
                        this.Size = new System.Drawing.Size(643, 176);

                        Character1.Visible = true;
                        DeleteCharacterButton1.Visible = true;

                        Character2.Visible = false;
                        DeleteCharacterButton2.Visible = false;

                        Character3.Visible = false;
                        DeleteCharacterButton3.Visible = false;

                        Character4.Visible = false;
                        DeleteCharacterButton4.Visible = false;

                        Character5.Visible = false;
                        DeleteCharacterButton5.Visible = false;
                        break;
                    case 2:
                        this.Size = new System.Drawing.Size(643, 216);

                        Character1.Visible = true;
                        DeleteCharacterButton1.Visible = true;

                        Character2.Visible = true;
                        DeleteCharacterButton2.Visible = true;

                        Character3.Visible = false;
                        DeleteCharacterButton3.Visible = false;

                        Character4.Visible = false;
                        DeleteCharacterButton4.Visible = false;

                        Character5.Visible = false;
                        DeleteCharacterButton5.Visible = false;
                        break;
                    case 3:
                        this.Size = new System.Drawing.Size(643, 259);

                        Character1.Visible = true;
                        DeleteCharacterButton1.Visible = true;

                        Character2.Visible = true;
                        DeleteCharacterButton2.Visible = true;

                        Character3.Visible = true;
                        DeleteCharacterButton3.Visible = true;

                        Character4.Visible = false;
                        DeleteCharacterButton4.Visible = false;

                        Character5.Visible = false;
                        DeleteCharacterButton5.Visible = false;
                        break;
                    case 4:
                        this.Size = new System.Drawing.Size(643, 297);

                        Character1.Visible = true;
                        DeleteCharacterButton1.Visible = true;

                        Character2.Visible = true;
                        DeleteCharacterButton2.Visible = true;

                        Character3.Visible = true;
                        DeleteCharacterButton3.Visible = true;

                        Character4.Visible = true;
                        DeleteCharacterButton4.Visible = true;

                        Character5.Visible = false;
                        DeleteCharacterButton5.Visible = false;
                        break;
                    case 5:
                        this.Size = new System.Drawing.Size(643, 342);

                        Character1.Visible = true;
                        DeleteCharacterButton1.Visible = true;

                        Character2.Visible = true;
                        DeleteCharacterButton2.Visible = true;

                        Character3.Visible = true;
                        DeleteCharacterButton3.Visible = true;

                        Character4.Visible = true;
                        DeleteCharacterButton4.Visible = true;

                        Character5.Visible = true;
                        DeleteCharacterButton5.Visible = true;
                        break;
                }
            }

            for (int i = 0; i < connection.NumberOfCharactersCreated() + 1; i++)
            {
                 character = connection.SelectCharInfo(i);

                switch (i)
                {
                    case 1:
                        Character1.Text = character.CharacterName;
                        break;
                    case 2:
                        Character2.Text = character.CharacterName;
                        break;
                    case 3:
                        Character3.Text = character.CharacterName;
                        break;
                    case 4:
                        Character4.Text = character.CharacterName;
                        break;
                    case 5:
                        Character5.Text = character.CharacterName;
                        break;
                }
            }
            NumberOfCharacters.Text = connection.NumberOfCharactersCreated().ToString() + "/5";
            
        }

        private void DeleteCharacterButton1_Click(object sender, EventArgs e)
        {
            connection.DeleteCharacter(1);
            switch (connection.NumberOfCharactersCreated())
            {
                case 1:
                    connection.UpdateCharNum(2, 1);
                    break;
                case 2:
                    connection.UpdateCharNum(2, 1);
                    connection.UpdateCharNum(3, 2);
                    break;
                case 3:
                    connection.UpdateCharNum(2, 1);
                    connection.UpdateCharNum(3, 2);
                    connection.UpdateCharNum(4, 3);
                    break;
                case 4:
                    connection.UpdateCharNum(2, 1);
                    connection.UpdateCharNum(3, 2);
                    connection.UpdateCharNum(4, 3);
                    connection.UpdateCharNum(5, 4);
                    break;
            }
            MessageBox.Show("Success!");
            this.Close();
        }

        private void DeleteCharacterButton2_Click(object sender, EventArgs e)
        {
            connection.DeleteCharacter(2);
            switch (connection.NumberOfCharactersCreated())
            {
                case 2:
                    connection.UpdateCharNum(3, 2);
                    break;
                case 3:
                    connection.UpdateCharNum(3, 2);
                    connection.UpdateCharNum(4, 3);
                    break;
                case 4:
                    connection.UpdateCharNum(3, 2);
                    connection.UpdateCharNum(4, 3);
                    connection.UpdateCharNum(5, 4);
                    break;
            }
            MessageBox.Show("Success!");
            this.Close();
        }

        private void DeleteCharacterButton3_Click(object sender, EventArgs e)
        {
            connection.DeleteCharacter(3);
            switch (connection.NumberOfCharactersCreated())
            {
                case 3:
                    connection.UpdateCharNum(4, 3);
                    break;
                case 4:
                    connection.UpdateCharNum(4, 3);
                    connection.UpdateCharNum(5, 4);
                    break;
            }
            MessageBox.Show("Success!");
            this.Close();
        }

        private void DeleteCharacterButton4_Click(object sender, EventArgs e)
        {
            connection.DeleteCharacter(4);
            switch (connection.NumberOfCharactersCreated())
            {
                case 4:
                    connection.UpdateCharNum(5, 4);
                    break;
            }
            MessageBox.Show("Success!");
            this.Close();
        }

        private void DeleteCharacterButton5_Click(object sender, EventArgs e)
        {
            connection.DeleteCharacter(5);
            MessageBox.Show("Success!");
            this.Close();
        }
    }
}
