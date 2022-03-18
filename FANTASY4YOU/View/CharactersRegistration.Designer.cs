using FANTASY4YOU;
namespace FANTASY4YOU
{
    partial class CharacterRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterRegistration));
            this.characterNameTextBox = new System.Windows.Forms.TextBox();
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.levelBox = new System.Windows.Forms.TextBox();
            this.CharacterNameLabel = new System.Windows.Forms.Label();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.raceComboBox = new System.Windows.Forms.ComboBox();
            this.RaceLabel = new System.Windows.Forms.Label();
            this.backgroundTextBox = new System.Windows.Forms.TextBox();
            this.BackgroundLabel = new System.Windows.Forms.Label();
            this.xpTextBox = new System.Windows.Forms.TextBox();
            this.XpLabel = new System.Windows.Forms.Label();
            this.AlignmentLabel = new System.Windows.Forms.Label();
            this.alignmentComboBox = new System.Windows.Forms.ComboBox();
            this.CreateCharacter = new ePOSOne.btnProduct.Button_WOC();
            this.RegisterCharacterLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // characterNameTextBox
            // 
            this.characterNameTextBox.Location = new System.Drawing.Point(459, 108);
            this.characterNameTextBox.Name = "characterNameTextBox";
            this.characterNameTextBox.Size = new System.Drawing.Size(121, 23);
            this.characterNameTextBox.TabIndex = 0;
            this.characterNameTextBox.TabStop = false;
            // 
            // classComboBox
            // 
            this.classComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Items.AddRange(new object[] {
            "Barbarian",
            "Bard",
            "Cleric",
            "Druid",
            "Fighter",
            "Monk",
            "Paladin",
            "Ranger",
            "Rogue",
            "Sorcerer",
            "Warlock",
            "Wizard",
            "Artificer"});
            this.classComboBox.Location = new System.Drawing.Point(459, 156);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(121, 23);
            this.classComboBox.TabIndex = 1;
            this.classComboBox.TabStop = false;
            // 
            // levelBox
            // 
            this.levelBox.Location = new System.Drawing.Point(459, 198);
            this.levelBox.MaxLength = 2;
            this.levelBox.Name = "levelBox";
            this.levelBox.Size = new System.Drawing.Size(66, 23);
            this.levelBox.TabIndex = 2;
            this.levelBox.TabStop = false;
            // 
            // CharacterNameLabel
            // 
            this.CharacterNameLabel.AutoSize = true;
            this.CharacterNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.CharacterNameLabel.Font = new System.Drawing.Font("Old London", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CharacterNameLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.CharacterNameLabel.Location = new System.Drawing.Point(267, 100);
            this.CharacterNameLabel.Name = "CharacterNameLabel";
            this.CharacterNameLabel.Size = new System.Drawing.Size(186, 31);
            this.CharacterNameLabel.TabIndex = 3;
            this.CharacterNameLabel.Text = "Character Name :";
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.BackColor = System.Drawing.Color.Transparent;
            this.ClassLabel.Font = new System.Drawing.Font("Old London", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClassLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.ClassLabel.Location = new System.Drawing.Point(369, 146);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(84, 31);
            this.ClassLabel.TabIndex = 4;
            this.ClassLabel.Text = "Class :";
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.BackColor = System.Drawing.Color.Transparent;
            this.LevelLabel.Font = new System.Drawing.Font("Old London", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LevelLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.LevelLabel.Location = new System.Drawing.Point(378, 190);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(80, 31);
            this.LevelLabel.TabIndex = 5;
            this.LevelLabel.Text = "Level :";
            // 
            // raceComboBox
            // 
            this.raceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.raceComboBox.FormattingEnabled = true;
            this.raceComboBox.Items.AddRange(new object[] {
            "Dragonborn",
            "Dwarf",
            "Elf",
            "Half-Elf",
            "Halfling",
            "Human",
            "Fairy",
            "Owlin",
            "Kobold",
            "Tortle",
            "Shifter"});
            this.raceComboBox.Location = new System.Drawing.Point(459, 242);
            this.raceComboBox.Name = "raceComboBox";
            this.raceComboBox.Size = new System.Drawing.Size(121, 23);
            this.raceComboBox.TabIndex = 6;
            this.raceComboBox.TabStop = false;
            // 
            // RaceLabel
            // 
            this.RaceLabel.AutoSize = true;
            this.RaceLabel.BackColor = System.Drawing.Color.Transparent;
            this.RaceLabel.Font = new System.Drawing.Font("Old London", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RaceLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.RaceLabel.Location = new System.Drawing.Point(378, 232);
            this.RaceLabel.Name = "RaceLabel";
            this.RaceLabel.Size = new System.Drawing.Size(75, 31);
            this.RaceLabel.TabIndex = 7;
            this.RaceLabel.Text = "Race :";
            // 
            // backgroundTextBox
            // 
            this.backgroundTextBox.Location = new System.Drawing.Point(459, 387);
            this.backgroundTextBox.Multiline = true;
            this.backgroundTextBox.Name = "backgroundTextBox";
            this.backgroundTextBox.Size = new System.Drawing.Size(263, 94);
            this.backgroundTextBox.TabIndex = 8;
            this.backgroundTextBox.TabStop = false;
            // 
            // BackgroundLabel
            // 
            this.BackgroundLabel.AutoSize = true;
            this.BackgroundLabel.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundLabel.Font = new System.Drawing.Font("Old London", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackgroundLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.BackgroundLabel.Location = new System.Drawing.Point(310, 377);
            this.BackgroundLabel.Name = "BackgroundLabel";
            this.BackgroundLabel.Size = new System.Drawing.Size(143, 31);
            this.BackgroundLabel.TabIndex = 9;
            this.BackgroundLabel.Text = "Background :";
            // 
            // xpTextBox
            // 
            this.xpTextBox.Location = new System.Drawing.Point(459, 288);
            this.xpTextBox.MaxLength = 4;
            this.xpTextBox.Name = "xpTextBox";
            this.xpTextBox.Size = new System.Drawing.Size(66, 23);
            this.xpTextBox.TabIndex = 10;
            this.xpTextBox.TabStop = false;
            // 
            // XpLabel
            // 
            this.XpLabel.AutoSize = true;
            this.XpLabel.BackColor = System.Drawing.Color.Transparent;
            this.XpLabel.Font = new System.Drawing.Font("Old London", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.XpLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.XpLabel.Location = new System.Drawing.Point(391, 280);
            this.XpLabel.Name = "XpLabel";
            this.XpLabel.Size = new System.Drawing.Size(62, 31);
            this.XpLabel.TabIndex = 11;
            this.XpLabel.Text = "XP :";
            // 
            // AlignmentLabel
            // 
            this.AlignmentLabel.AutoSize = true;
            this.AlignmentLabel.BackColor = System.Drawing.Color.Transparent;
            this.AlignmentLabel.Font = new System.Drawing.Font("Old London", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AlignmentLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.AlignmentLabel.Location = new System.Drawing.Point(326, 328);
            this.AlignmentLabel.Name = "AlignmentLabel";
            this.AlignmentLabel.Size = new System.Drawing.Size(127, 31);
            this.AlignmentLabel.TabIndex = 13;
            this.AlignmentLabel.Text = "Alignment :";
            // 
            // alignmentComboBox
            // 
            this.alignmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.alignmentComboBox.FormattingEnabled = true;
            this.alignmentComboBox.Items.AddRange(new object[] {
            "Lawful Good",
            "Neutral Good",
            "Chaotic Good",
            "Lawful Neutral",
            "True Neutral",
            "Chaotic Neutral",
            "Lawful Evil",
            "Neutral Evil",
            "Chaotic Evil"});
            this.alignmentComboBox.Location = new System.Drawing.Point(459, 336);
            this.alignmentComboBox.Name = "alignmentComboBox";
            this.alignmentComboBox.Size = new System.Drawing.Size(121, 23);
            this.alignmentComboBox.TabIndex = 14;
            this.alignmentComboBox.TabStop = false;
            // 
            // CreateCharacter
            // 
            this.CreateCharacter.BackColor = System.Drawing.Color.Transparent;
            this.CreateCharacter.BorderColor = System.Drawing.Color.Transparent;
            this.CreateCharacter.ButtonColor = System.Drawing.Color.DarkGoldenrod;
            this.CreateCharacter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CreateCharacter.FlatAppearance.BorderSize = 0;
            this.CreateCharacter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CreateCharacter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CreateCharacter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateCharacter.Font = new System.Drawing.Font("Old London", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateCharacter.Location = new System.Drawing.Point(459, 508);
            this.CreateCharacter.Name = "CreateCharacter";
            this.CreateCharacter.OnHoverBackColor = System.Drawing.Color.Transparent;
            this.CreateCharacter.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.CreateCharacter.OnHoverButtonColor = System.Drawing.Color.DarkGoldenrod;
            this.CreateCharacter.OnHoverTextColor = System.Drawing.Color.Goldenrod;
            this.CreateCharacter.Size = new System.Drawing.Size(221, 56);
            this.CreateCharacter.TabIndex = 19;
            this.CreateCharacter.TabStop = false;
            this.CreateCharacter.Text = "Create";
            this.CreateCharacter.TextColor = System.Drawing.Color.White;
            this.CreateCharacter.UseVisualStyleBackColor = false;
            this.CreateCharacter.Click += new System.EventHandler(this.CreateCharacter_Click);
            // 
            // RegisterCharacterLabel
            // 
            this.RegisterCharacterLabel.AutoSize = true;
            this.RegisterCharacterLabel.BackColor = System.Drawing.Color.Transparent;
            this.RegisterCharacterLabel.Font = new System.Drawing.Font("Old London", 40.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegisterCharacterLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.RegisterCharacterLabel.Location = new System.Drawing.Point(344, 14);
            this.RegisterCharacterLabel.Name = "RegisterCharacterLabel";
            this.RegisterCharacterLabel.Size = new System.Drawing.Size(387, 61);
            this.RegisterCharacterLabel.TabIndex = 20;
            this.RegisterCharacterLabel.Text = "Register Character";
            // 
            // CharacterRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1108, 658);
            this.Controls.Add(this.RegisterCharacterLabel);
            this.Controls.Add(this.CreateCharacter);
            this.Controls.Add(this.raceComboBox);
            this.Controls.Add(this.CharacterNameLabel);
            this.Controls.Add(this.characterNameTextBox);
            this.Controls.Add(this.backgroundTextBox);
            this.Controls.Add(this.classComboBox);
            this.Controls.Add(this.RaceLabel);
            this.Controls.Add(this.alignmentComboBox);
            this.Controls.Add(this.BackgroundLabel);
            this.Controls.Add(this.levelBox);
            this.Controls.Add(this.LevelLabel);
            this.Controls.Add(this.AlignmentLabel);
            this.Controls.Add(this.xpTextBox);
            this.Controls.Add(this.ClassLabel);
            this.Controls.Add(this.XpLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CharacterRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fantasy4You";
            this.Load += new System.EventHandler(this.CharacterRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox characterNameTextBox;
        private ComboBox classComboBox;
        private TextBox levelBox;
        private Label CharacterNameLabel;
        private Label ClassLabel;
        private Label LevelLabel;
        private ComboBox raceComboBox;
        private Label RaceLabel;
        private TextBox backgroundTextBox;
        private Label BackgroundLabel;
        private TextBox xpTextBox;
        private Label XpLabel;
        private Label AlignmentLabel;
        private ComboBox alignmentComboBox;
        private ePOSOne.btnProduct.Button_WOC CreateCharacter;
        private Label RegisterCharacterLabel;
    }
}