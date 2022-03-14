using FANTASY4YOU;
namespace FANTASY4YOU
{
    partial class CharacterCustomizationChar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterCustomizationChar));
            this.CharacterConstitutionConstitutionLabel = new System.Windows.Forms.Label();
            this.CharacterIntelligenceIntelligenceLabel = new System.Windows.Forms.Label();
            this.CharacterCharismaCharismaLabel = new System.Windows.Forms.Label();
            this.CharacterWisdomWisdomLabel = new System.Windows.Forms.Label();
            this.CharacterStrenghtTextbox = new System.Windows.Forms.TextBox();
            this.CharacterIntelligenceTextbox = new System.Windows.Forms.TextBox();
            this.CharacterConstitutionTextbox = new System.Windows.Forms.TextBox();
            this.CharacterDexterityTextbox = new System.Windows.Forms.TextBox();
            this.CharacterWisdomTextbox = new System.Windows.Forms.TextBox();
            this.CharacterCharismaTextbox = new System.Windows.Forms.TextBox();
            this.MoreCustomizations = new System.Windows.Forms.Button();
            this.CharacterXpCustomizeTextBox = new System.Windows.Forms.TextBox();
            this.CharacterLevelCustomizeTextbox = new System.Windows.Forms.TextBox();
            this.CharacterNameCustomizeTextbox = new System.Windows.Forms.TextBox();
            this.CharacterXpCustomizeLabel = new System.Windows.Forms.Label();
            this.CharacterAlignmentCustomizeLabel = new System.Windows.Forms.Label();
            this.CharacterRaceCustomizeLabel = new System.Windows.Forms.Label();
            this.CharacterLevelCustomizeLabel = new System.Windows.Forms.Label();
            this.CharacterClassCustomizeLabel = new System.Windows.Forms.Label();
            this.CharacterNameCustomizeLabel = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.CharacterClassCustomizeTextbox = new System.Windows.Forms.ComboBox();
            this.CharacterRaceCustomizeCombobox = new System.Windows.Forms.ComboBox();
            this.CharacterAlignmentCustomizeCombobox = new System.Windows.Forms.ComboBox();
            this.MoreCustomizations2 = new System.Windows.Forms.Button();
            this.CharacterBackgroundCustomizeLabel = new System.Windows.Forms.Label();
            this.CharacterBackgroundCustomizeTextbox = new System.Windows.Forms.TextBox();
            this.MoreCustomizations3 = new System.Windows.Forms.Button();
            this.BackgroundPannel = new System.Windows.Forms.Panel();
            this.CharacterBackgroundCustomizeButton = new FontAwesome.Sharp.IconButton();
            this.CharNamePannel = new System.Windows.Forms.Panel();
            this.UpdateCharacterDetailsButton2 = new FontAwesome.Sharp.IconButton();
            this.StrenghtPanel = new System.Windows.Forms.Panel();
            this.UpdateCharacterDetailsButton = new FontAwesome.Sharp.IconButton();
            this.CharacterDexterityDexterityLabel = new System.Windows.Forms.Label();
            this.CharacterStrenghtStrenghtLabel = new System.Windows.Forms.Label();
            this.WindowTopBar = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.MinimizeForm = new FontAwesome.Sharp.IconButton();
            this.CloseFormButton = new FontAwesome.Sharp.IconButton();
            this.BackgroundPannel.SuspendLayout();
            this.CharNamePannel.SuspendLayout();
            this.StrenghtPanel.SuspendLayout();
            this.WindowTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // CharacterConstitutionConstitutionLabel
            // 
            this.CharacterConstitutionConstitutionLabel.AutoSize = true;
            this.CharacterConstitutionConstitutionLabel.BackColor = System.Drawing.Color.Transparent;
            this.CharacterConstitutionConstitutionLabel.Font = new System.Drawing.Font("Old London", 31F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CharacterConstitutionConstitutionLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.CharacterConstitutionConstitutionLabel.Location = new System.Drawing.Point(7, 123);
            this.CharacterConstitutionConstitutionLabel.Name = "CharacterConstitutionConstitutionLabel";
            this.CharacterConstitutionConstitutionLabel.Size = new System.Drawing.Size(223, 48);
            this.CharacterConstitutionConstitutionLabel.TabIndex = 2;
            this.CharacterConstitutionConstitutionLabel.Text = "Constitution :";
            this.CharacterConstitutionConstitutionLabel.Click += new System.EventHandler(this.CharacterConstitutionConstitutionLabel_Click);
            // 
            // CharacterIntelligenceIntelligenceLabel
            // 
            this.CharacterIntelligenceIntelligenceLabel.AutoSize = true;
            this.CharacterIntelligenceIntelligenceLabel.BackColor = System.Drawing.Color.Transparent;
            this.CharacterIntelligenceIntelligenceLabel.Font = new System.Drawing.Font("Old London", 31F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CharacterIntelligenceIntelligenceLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.CharacterIntelligenceIntelligenceLabel.Location = new System.Drawing.Point(7, 189);
            this.CharacterIntelligenceIntelligenceLabel.Name = "CharacterIntelligenceIntelligenceLabel";
            this.CharacterIntelligenceIntelligenceLabel.Size = new System.Drawing.Size(216, 48);
            this.CharacterIntelligenceIntelligenceLabel.TabIndex = 3;
            this.CharacterIntelligenceIntelligenceLabel.Text = "Intelligence :";
            // 
            // CharacterCharismaCharismaLabel
            // 
            this.CharacterCharismaCharismaLabel.AutoSize = true;
            this.CharacterCharismaCharismaLabel.BackColor = System.Drawing.Color.Transparent;
            this.CharacterCharismaCharismaLabel.Font = new System.Drawing.Font("Old London", 31F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CharacterCharismaCharismaLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.CharacterCharismaCharismaLabel.Location = new System.Drawing.Point(7, 315);
            this.CharacterCharismaCharismaLabel.Name = "CharacterCharismaCharismaLabel";
            this.CharacterCharismaCharismaLabel.Size = new System.Drawing.Size(185, 48);
            this.CharacterCharismaCharismaLabel.TabIndex = 4;
            this.CharacterCharismaCharismaLabel.Text = "Charisma :";
            // 
            // CharacterWisdomWisdomLabel
            // 
            this.CharacterWisdomWisdomLabel.AutoSize = true;
            this.CharacterWisdomWisdomLabel.BackColor = System.Drawing.Color.Transparent;
            this.CharacterWisdomWisdomLabel.Font = new System.Drawing.Font("Old London", 31F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CharacterWisdomWisdomLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.CharacterWisdomWisdomLabel.Location = new System.Drawing.Point(7, 254);
            this.CharacterWisdomWisdomLabel.Name = "CharacterWisdomWisdomLabel";
            this.CharacterWisdomWisdomLabel.Size = new System.Drawing.Size(175, 48);
            this.CharacterWisdomWisdomLabel.TabIndex = 5;
            this.CharacterWisdomWisdomLabel.Text = "Wisdom :";
            // 
            // CharacterStrenghtTextbox
            // 
            this.CharacterStrenghtTextbox.Location = new System.Drawing.Point(173, 17);
            this.CharacterStrenghtTextbox.Name = "CharacterStrenghtTextbox";
            this.CharacterStrenghtTextbox.Size = new System.Drawing.Size(136, 23);
            this.CharacterStrenghtTextbox.TabIndex = 6;
            this.CharacterStrenghtTextbox.TabStop = false;
            // 
            // CharacterIntelligenceTextbox
            // 
            this.CharacterIntelligenceTextbox.Location = new System.Drawing.Point(214, 206);
            this.CharacterIntelligenceTextbox.Name = "CharacterIntelligenceTextbox";
            this.CharacterIntelligenceTextbox.Size = new System.Drawing.Size(136, 23);
            this.CharacterIntelligenceTextbox.TabIndex = 7;
            this.CharacterIntelligenceTextbox.TabStop = false;
            // 
            // CharacterConstitutionTextbox
            // 
            this.CharacterConstitutionTextbox.Location = new System.Drawing.Point(224, 139);
            this.CharacterConstitutionTextbox.Name = "CharacterConstitutionTextbox";
            this.CharacterConstitutionTextbox.Size = new System.Drawing.Size(136, 23);
            this.CharacterConstitutionTextbox.TabIndex = 8;
            this.CharacterConstitutionTextbox.TabStop = false;
            // 
            // CharacterDexterityTextbox
            // 
            this.CharacterDexterityTextbox.Location = new System.Drawing.Point(178, 76);
            this.CharacterDexterityTextbox.Name = "CharacterDexterityTextbox";
            this.CharacterDexterityTextbox.Size = new System.Drawing.Size(136, 23);
            this.CharacterDexterityTextbox.TabIndex = 9;
            this.CharacterDexterityTextbox.TabStop = false;
            // 
            // CharacterWisdomTextbox
            // 
            this.CharacterWisdomTextbox.Location = new System.Drawing.Point(172, 271);
            this.CharacterWisdomTextbox.Name = "CharacterWisdomTextbox";
            this.CharacterWisdomTextbox.Size = new System.Drawing.Size(136, 23);
            this.CharacterWisdomTextbox.TabIndex = 10;
            this.CharacterWisdomTextbox.TabStop = false;
            // 
            // CharacterCharismaTextbox
            // 
            this.CharacterCharismaTextbox.Location = new System.Drawing.Point(184, 332);
            this.CharacterCharismaTextbox.Name = "CharacterCharismaTextbox";
            this.CharacterCharismaTextbox.Size = new System.Drawing.Size(136, 23);
            this.CharacterCharismaTextbox.TabIndex = 11;
            this.CharacterCharismaTextbox.TabStop = false;
            // 
            // MoreCustomizations
            // 
            this.MoreCustomizations.Font = new System.Drawing.Font("Old London", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MoreCustomizations.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.MoreCustomizations.Location = new System.Drawing.Point(483, 132);
            this.MoreCustomizations.Name = "MoreCustomizations";
            this.MoreCustomizations.Size = new System.Drawing.Size(34, 67);
            this.MoreCustomizations.TabIndex = 13;
            this.MoreCustomizations.Text = ">";
            this.MoreCustomizations.UseVisualStyleBackColor = true;
            this.MoreCustomizations.Click += new System.EventHandler(this.MoreCustomizations_Click);
            // 
            // CharacterXpCustomizeTextBox
            // 
            this.CharacterXpCustomizeTextBox.Location = new System.Drawing.Point(89, 272);
            this.CharacterXpCustomizeTextBox.Name = "CharacterXpCustomizeTextBox";
            this.CharacterXpCustomizeTextBox.Size = new System.Drawing.Size(136, 23);
            this.CharacterXpCustomizeTextBox.TabIndex = 24;
            this.CharacterXpCustomizeTextBox.TabStop = false;
            // 
            // CharacterLevelCustomizeTextbox
            // 
            this.CharacterLevelCustomizeTextbox.Location = new System.Drawing.Point(137, 144);
            this.CharacterLevelCustomizeTextbox.Name = "CharacterLevelCustomizeTextbox";
            this.CharacterLevelCustomizeTextbox.Size = new System.Drawing.Size(136, 23);
            this.CharacterLevelCustomizeTextbox.TabIndex = 22;
            this.CharacterLevelCustomizeTextbox.TabStop = false;
            // 
            // CharacterNameCustomizeTextbox
            // 
            this.CharacterNameCustomizeTextbox.Location = new System.Drawing.Point(281, 16);
            this.CharacterNameCustomizeTextbox.Name = "CharacterNameCustomizeTextbox";
            this.CharacterNameCustomizeTextbox.Size = new System.Drawing.Size(136, 23);
            this.CharacterNameCustomizeTextbox.TabIndex = 20;
            this.CharacterNameCustomizeTextbox.TabStop = false;
            // 
            // CharacterXpCustomizeLabel
            // 
            this.CharacterXpCustomizeLabel.AutoSize = true;
            this.CharacterXpCustomizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.CharacterXpCustomizeLabel.Font = new System.Drawing.Font("Old London", 31F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CharacterXpCustomizeLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.CharacterXpCustomizeLabel.Location = new System.Drawing.Point(13, 255);
            this.CharacterXpCustomizeLabel.Name = "CharacterXpCustomizeLabel";
            this.CharacterXpCustomizeLabel.Size = new System.Drawing.Size(83, 48);
            this.CharacterXpCustomizeLabel.TabIndex = 19;
            this.CharacterXpCustomizeLabel.Text = "Xp :";
            // 
            // CharacterAlignmentCustomizeLabel
            // 
            this.CharacterAlignmentCustomizeLabel.AutoSize = true;
            this.CharacterAlignmentCustomizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.CharacterAlignmentCustomizeLabel.Font = new System.Drawing.Font("Old London", 31F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CharacterAlignmentCustomizeLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.CharacterAlignmentCustomizeLabel.Location = new System.Drawing.Point(13, 316);
            this.CharacterAlignmentCustomizeLabel.Name = "CharacterAlignmentCustomizeLabel";
            this.CharacterAlignmentCustomizeLabel.Size = new System.Drawing.Size(183, 48);
            this.CharacterAlignmentCustomizeLabel.TabIndex = 18;
            this.CharacterAlignmentCustomizeLabel.Text = "Alignment:";
            // 
            // CharacterRaceCustomizeLabel
            // 
            this.CharacterRaceCustomizeLabel.AutoSize = true;
            this.CharacterRaceCustomizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.CharacterRaceCustomizeLabel.Font = new System.Drawing.Font("Old London", 31F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CharacterRaceCustomizeLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.CharacterRaceCustomizeLabel.Location = new System.Drawing.Point(13, 190);
            this.CharacterRaceCustomizeLabel.Name = "CharacterRaceCustomizeLabel";
            this.CharacterRaceCustomizeLabel.Size = new System.Drawing.Size(116, 48);
            this.CharacterRaceCustomizeLabel.TabIndex = 17;
            this.CharacterRaceCustomizeLabel.Text = "Race :";
            // 
            // CharacterLevelCustomizeLabel
            // 
            this.CharacterLevelCustomizeLabel.AutoSize = true;
            this.CharacterLevelCustomizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.CharacterLevelCustomizeLabel.Font = new System.Drawing.Font("Old London", 31F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CharacterLevelCustomizeLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.CharacterLevelCustomizeLabel.Location = new System.Drawing.Point(13, 124);
            this.CharacterLevelCustomizeLabel.Name = "CharacterLevelCustomizeLabel";
            this.CharacterLevelCustomizeLabel.Size = new System.Drawing.Size(123, 48);
            this.CharacterLevelCustomizeLabel.TabIndex = 16;
            this.CharacterLevelCustomizeLabel.Text = "Level :";
            // 
            // CharacterClassCustomizeLabel
            // 
            this.CharacterClassCustomizeLabel.AutoSize = true;
            this.CharacterClassCustomizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.CharacterClassCustomizeLabel.Font = new System.Drawing.Font("Old London", 31F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CharacterClassCustomizeLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.CharacterClassCustomizeLabel.Location = new System.Drawing.Point(13, 62);
            this.CharacterClassCustomizeLabel.Name = "CharacterClassCustomizeLabel";
            this.CharacterClassCustomizeLabel.Size = new System.Drawing.Size(128, 48);
            this.CharacterClassCustomizeLabel.TabIndex = 15;
            this.CharacterClassCustomizeLabel.Text = "Class :";
            // 
            // CharacterNameCustomizeLabel
            // 
            this.CharacterNameCustomizeLabel.AutoSize = true;
            this.CharacterNameCustomizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.CharacterNameCustomizeLabel.Font = new System.Drawing.Font("Old London", 31F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CharacterNameCustomizeLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.CharacterNameCustomizeLabel.Location = new System.Drawing.Point(9, 1);
            this.CharacterNameCustomizeLabel.Name = "CharacterNameCustomizeLabel";
            this.CharacterNameCustomizeLabel.Size = new System.Drawing.Size(273, 48);
            this.CharacterNameCustomizeLabel.TabIndex = 14;
            this.CharacterNameCustomizeLabel.Text = "Character Name:";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // CharacterClassCustomizeTextbox
            // 
            this.CharacterClassCustomizeTextbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CharacterClassCustomizeTextbox.FormattingEnabled = true;
            this.CharacterClassCustomizeTextbox.Items.AddRange(new object[] {
            "Class1",
            "Class2",
            "Class3"});
            this.CharacterClassCustomizeTextbox.Location = new System.Drawing.Point(137, 80);
            this.CharacterClassCustomizeTextbox.Name = "CharacterClassCustomizeTextbox";
            this.CharacterClassCustomizeTextbox.Size = new System.Drawing.Size(136, 23);
            this.CharacterClassCustomizeTextbox.TabIndex = 26;
            // 
            // CharacterRaceCustomizeCombobox
            // 
            this.CharacterRaceCustomizeCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CharacterRaceCustomizeCombobox.FormattingEnabled = true;
            this.CharacterRaceCustomizeCombobox.Items.AddRange(new object[] {
            "Race1",
            "Race2",
            "Race3"});
            this.CharacterRaceCustomizeCombobox.Location = new System.Drawing.Point(122, 208);
            this.CharacterRaceCustomizeCombobox.Name = "CharacterRaceCustomizeCombobox";
            this.CharacterRaceCustomizeCombobox.Size = new System.Drawing.Size(136, 23);
            this.CharacterRaceCustomizeCombobox.TabIndex = 27;
            // 
            // CharacterAlignmentCustomizeCombobox
            // 
            this.CharacterAlignmentCustomizeCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CharacterAlignmentCustomizeCombobox.FormattingEnabled = true;
            this.CharacterAlignmentCustomizeCombobox.Items.AddRange(new object[] {
            "Alignment1",
            "Alignment2",
            "Alignment3"});
            this.CharacterAlignmentCustomizeCombobox.Location = new System.Drawing.Point(200, 332);
            this.CharacterAlignmentCustomizeCombobox.Name = "CharacterAlignmentCustomizeCombobox";
            this.CharacterAlignmentCustomizeCombobox.Size = new System.Drawing.Size(136, 23);
            this.CharacterAlignmentCustomizeCombobox.TabIndex = 28;
            // 
            // MoreCustomizations2
            // 
            this.MoreCustomizations2.Font = new System.Drawing.Font("Old London", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MoreCustomizations2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.MoreCustomizations2.Location = new System.Drawing.Point(483, 132);
            this.MoreCustomizations2.Name = "MoreCustomizations2";
            this.MoreCustomizations2.Size = new System.Drawing.Size(34, 67);
            this.MoreCustomizations2.TabIndex = 30;
            this.MoreCustomizations2.Text = ">";
            this.MoreCustomizations2.UseVisualStyleBackColor = true;
            this.MoreCustomizations2.Click += new System.EventHandler(this.MoreCustomizations2_Click);
            // 
            // CharacterBackgroundCustomizeLabel
            // 
            this.CharacterBackgroundCustomizeLabel.AutoSize = true;
            this.CharacterBackgroundCustomizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.CharacterBackgroundCustomizeLabel.Font = new System.Drawing.Font("Old London", 31F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CharacterBackgroundCustomizeLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.CharacterBackgroundCustomizeLabel.Location = new System.Drawing.Point(137, 94);
            this.CharacterBackgroundCustomizeLabel.Name = "CharacterBackgroundCustomizeLabel";
            this.CharacterBackgroundCustomizeLabel.Size = new System.Drawing.Size(223, 48);
            this.CharacterBackgroundCustomizeLabel.TabIndex = 31;
            this.CharacterBackgroundCustomizeLabel.Text = "Background :";
            // 
            // CharacterBackgroundCustomizeTextbox
            // 
            this.CharacterBackgroundCustomizeTextbox.Location = new System.Drawing.Point(142, 145);
            this.CharacterBackgroundCustomizeTextbox.Multiline = true;
            this.CharacterBackgroundCustomizeTextbox.Name = "CharacterBackgroundCustomizeTextbox";
            this.CharacterBackgroundCustomizeTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CharacterBackgroundCustomizeTextbox.Size = new System.Drawing.Size(265, 93);
            this.CharacterBackgroundCustomizeTextbox.TabIndex = 32;
            // 
            // MoreCustomizations3
            // 
            this.MoreCustomizations3.Font = new System.Drawing.Font("Old London", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MoreCustomizations3.Location = new System.Drawing.Point(483, 132);
            this.MoreCustomizations3.Name = "MoreCustomizations3";
            this.MoreCustomizations3.Size = new System.Drawing.Size(34, 67);
            this.MoreCustomizations3.TabIndex = 34;
            this.MoreCustomizations3.Text = ">";
            this.MoreCustomizations3.UseVisualStyleBackColor = true;
            this.MoreCustomizations3.Click += new System.EventHandler(this.MoreCustomizations3_Click);
            // 
            // BackgroundPannel
            // 
            this.BackgroundPannel.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundPannel.Controls.Add(this.CharacterBackgroundCustomizeButton);
            this.BackgroundPannel.Controls.Add(this.CharacterBackgroundCustomizeLabel);
            this.BackgroundPannel.Controls.Add(this.MoreCustomizations3);
            this.BackgroundPannel.Controls.Add(this.CharacterBackgroundCustomizeTextbox);
            this.BackgroundPannel.Location = new System.Drawing.Point(2, 44);
            this.BackgroundPannel.Name = "BackgroundPannel";
            this.BackgroundPannel.Size = new System.Drawing.Size(534, 424);
            this.BackgroundPannel.TabIndex = 35;
            this.BackgroundPannel.Visible = false;
            // 
            // CharacterBackgroundCustomizeButton
            // 
            this.CharacterBackgroundCustomizeButton.FlatAppearance.BorderSize = 0;
            this.CharacterBackgroundCustomizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CharacterBackgroundCustomizeButton.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.CharacterBackgroundCustomizeButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.CharacterBackgroundCustomizeButton.IconColor = System.Drawing.Color.DarkGoldenrod;
            this.CharacterBackgroundCustomizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CharacterBackgroundCustomizeButton.IconSize = 60;
            this.CharacterBackgroundCustomizeButton.Location = new System.Drawing.Point(230, 254);
            this.CharacterBackgroundCustomizeButton.Name = "CharacterBackgroundCustomizeButton";
            this.CharacterBackgroundCustomizeButton.Size = new System.Drawing.Size(85, 71);
            this.CharacterBackgroundCustomizeButton.TabIndex = 35;
            this.CharacterBackgroundCustomizeButton.UseVisualStyleBackColor = true;
            this.CharacterBackgroundCustomizeButton.Click += new System.EventHandler(this.CharacterBackgroundCustomizeButton_Click);
            this.CharacterBackgroundCustomizeButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            this.CharacterBackgroundCustomizeButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            this.CharacterBackgroundCustomizeButton.FlatAppearance.BorderSize = 0;
            this.CharacterBackgroundCustomizeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CharacterBackgroundCustomizeButton.TabStop = false;
            this.CharacterBackgroundCustomizeButton.BackColor = Color.Transparent;
            // 
            // CharNamePannel
            // 
            this.CharNamePannel.BackColor = System.Drawing.Color.Transparent;
            this.CharNamePannel.Controls.Add(this.UpdateCharacterDetailsButton2);
            this.CharNamePannel.Controls.Add(this.CharacterNameCustomizeTextbox);
            this.CharNamePannel.Controls.Add(this.CharacterAlignmentCustomizeCombobox);
            this.CharNamePannel.Controls.Add(this.CharacterXpCustomizeTextBox);
            this.CharNamePannel.Controls.Add(this.CharacterRaceCustomizeCombobox);
            this.CharNamePannel.Controls.Add(this.CharacterLevelCustomizeTextbox);
            this.CharNamePannel.Controls.Add(this.CharacterClassCustomizeTextbox);
            this.CharNamePannel.Controls.Add(this.CharacterAlignmentCustomizeLabel);
            this.CharNamePannel.Controls.Add(this.CharacterNameCustomizeLabel);
            this.CharNamePannel.Controls.Add(this.MoreCustomizations2);
            this.CharNamePannel.Controls.Add(this.CharacterClassCustomizeLabel);
            this.CharNamePannel.Controls.Add(this.CharacterLevelCustomizeLabel);
            this.CharNamePannel.Controls.Add(this.CharacterRaceCustomizeLabel);
            this.CharNamePannel.Controls.Add(this.CharacterXpCustomizeLabel);
            this.CharNamePannel.Location = new System.Drawing.Point(12, 34);
            this.CharNamePannel.Name = "CharNamePannel";
            this.CharNamePannel.Size = new System.Drawing.Size(531, 427);
            this.CharNamePannel.TabIndex = 36;
            this.CharNamePannel.Visible = false;
            // 
            // UpdateCharacterDetailsButton2
            // 
            this.UpdateCharacterDetailsButton2.FlatAppearance.BorderSize = 0;
            this.UpdateCharacterDetailsButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateCharacterDetailsButton2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.UpdateCharacterDetailsButton2.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.UpdateCharacterDetailsButton2.IconColor = System.Drawing.Color.DarkGoldenrod;
            this.UpdateCharacterDetailsButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UpdateCharacterDetailsButton2.IconSize = 60;
            this.UpdateCharacterDetailsButton2.Location = new System.Drawing.Point(443, 316);
            this.UpdateCharacterDetailsButton2.Name = "UpdateCharacterDetailsButton2";
            this.UpdateCharacterDetailsButton2.Size = new System.Drawing.Size(85, 71);
            this.UpdateCharacterDetailsButton2.TabIndex = 31;
            this.UpdateCharacterDetailsButton2.UseVisualStyleBackColor = true;
            this.UpdateCharacterDetailsButton2.Click += new System.EventHandler(this.UpdateCharacterDetailsButton2_Click);
            this.UpdateCharacterDetailsButton2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            this.UpdateCharacterDetailsButton2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            this.UpdateCharacterDetailsButton2.FlatAppearance.BorderSize = 0;
            this.UpdateCharacterDetailsButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UpdateCharacterDetailsButton2.TabStop = false;
            this.UpdateCharacterDetailsButton2.BackColor = Color.Transparent;
            // 
            // StrenghtPanel
            // 
            this.StrenghtPanel.BackColor = System.Drawing.Color.Transparent;
            this.StrenghtPanel.Controls.Add(this.UpdateCharacterDetailsButton);
            this.StrenghtPanel.Controls.Add(this.CharacterCharismaTextbox);
            this.StrenghtPanel.Controls.Add(this.CharacterWisdomTextbox);
            this.StrenghtPanel.Controls.Add(this.CharacterIntelligenceTextbox);
            this.StrenghtPanel.Controls.Add(this.CharacterConstitutionTextbox);
            this.StrenghtPanel.Controls.Add(this.CharacterDexterityTextbox);
            this.StrenghtPanel.Controls.Add(this.CharacterStrenghtTextbox);
            this.StrenghtPanel.Controls.Add(this.CharacterConstitutionConstitutionLabel);
            this.StrenghtPanel.Controls.Add(this.CharacterDexterityDexterityLabel);
            this.StrenghtPanel.Controls.Add(this.MoreCustomizations);
            this.StrenghtPanel.Controls.Add(this.CharacterStrenghtStrenghtLabel);
            this.StrenghtPanel.Controls.Add(this.CharacterIntelligenceIntelligenceLabel);
            this.StrenghtPanel.Controls.Add(this.CharacterCharismaCharismaLabel);
            this.StrenghtPanel.Controls.Add(this.CharacterWisdomWisdomLabel);
            this.StrenghtPanel.Location = new System.Drawing.Point(448, 75);
            this.StrenghtPanel.Name = "StrenghtPanel";
            this.StrenghtPanel.Size = new System.Drawing.Size(534, 424);
            this.StrenghtPanel.TabIndex = 37;
            // 
            // UpdateCharacterDetailsButton
            // 
            this.UpdateCharacterDetailsButton.FlatAppearance.BorderSize = 0;
            this.UpdateCharacterDetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateCharacterDetailsButton.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.UpdateCharacterDetailsButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.UpdateCharacterDetailsButton.IconColor = System.Drawing.Color.DarkGoldenrod;
            this.UpdateCharacterDetailsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UpdateCharacterDetailsButton.IconSize = 60;
            this.UpdateCharacterDetailsButton.Location = new System.Drawing.Point(443, 316);
            this.UpdateCharacterDetailsButton.Name = "UpdateCharacterDetailsButton";
            this.UpdateCharacterDetailsButton.Size = new System.Drawing.Size(85, 71);
            this.UpdateCharacterDetailsButton.TabIndex = 32;
            this.UpdateCharacterDetailsButton.UseVisualStyleBackColor = true;
            this.UpdateCharacterDetailsButton.Click += new System.EventHandler(this.UpdateCharacterDetailsButton_Click);
            this.UpdateCharacterDetailsButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            this.UpdateCharacterDetailsButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            this.UpdateCharacterDetailsButton.FlatAppearance.BorderSize = 0;
            this.UpdateCharacterDetailsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UpdateCharacterDetailsButton.TabStop = false;
            this.UpdateCharacterDetailsButton.BackColor = Color.Transparent;
            // 
            // CharacterDexterityDexterityLabel
            // 
            this.CharacterDexterityDexterityLabel.AutoSize = true;
            this.CharacterDexterityDexterityLabel.BackColor = System.Drawing.Color.Transparent;
            this.CharacterDexterityDexterityLabel.Font = new System.Drawing.Font("Old London", 31F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CharacterDexterityDexterityLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.CharacterDexterityDexterityLabel.Location = new System.Drawing.Point(4, 61);
            this.CharacterDexterityDexterityLabel.Name = "CharacterDexterityDexterityLabel";
            this.CharacterDexterityDexterityLabel.Size = new System.Drawing.Size(181, 48);
            this.CharacterDexterityDexterityLabel.TabIndex = 1;
            this.CharacterDexterityDexterityLabel.Text = "Dexterity :";
            // 
            // CharacterStrenghtStrenghtLabel
            // 
            this.CharacterStrenghtStrenghtLabel.AutoSize = true;
            this.CharacterStrenghtStrenghtLabel.BackColor = System.Drawing.Color.Transparent;
            this.CharacterStrenghtStrenghtLabel.Font = new System.Drawing.Font("Old London", 31F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CharacterStrenghtStrenghtLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.CharacterStrenghtStrenghtLabel.Location = new System.Drawing.Point(4, 0);
            this.CharacterStrenghtStrenghtLabel.Name = "CharacterStrenghtStrenghtLabel";
            this.CharacterStrenghtStrenghtLabel.Size = new System.Drawing.Size(176, 48);
            this.CharacterStrenghtStrenghtLabel.TabIndex = 0;
            this.CharacterStrenghtStrenghtLabel.Text = "Strenght :";
            // 
            // WindowTopBar
            // 
            this.WindowTopBar.BackColor = System.Drawing.Color.IndianRed;
            this.WindowTopBar.Controls.Add(this.iconButton1);
            this.WindowTopBar.Controls.Add(this.iconButton2);
            this.WindowTopBar.Controls.Add(this.MinimizeForm);
            this.WindowTopBar.Controls.Add(this.CloseFormButton);
            this.WindowTopBar.Location = new System.Drawing.Point(0, 0);
            this.WindowTopBar.Name = "WindowTopBar";
            this.WindowTopBar.Size = new System.Drawing.Size(528, 28);
            this.WindowTopBar.TabIndex = 38;
            this.WindowTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowTopBar_MouseDown);
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconButton1.IconColor = System.Drawing.Color.Snow;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 26;
            this.iconButton1.Location = new System.Drawing.Point(458, -3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(39, 41);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.TabStop = false;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton2.BackColor = System.Drawing.Color.Transparent;
            this.iconButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.iconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconButton2.IconColor = System.Drawing.Color.Snow;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 44;
            this.iconButton2.Location = new System.Drawing.Point(489, -5);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(47, 45);
            this.iconButton2.TabIndex = 2;
            this.iconButton2.TabStop = false;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // MinimizeForm
            // 
            this.MinimizeForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeForm.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MinimizeForm.FlatAppearance.BorderSize = 0;
            this.MinimizeForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.MinimizeForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.MinimizeForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeForm.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.MinimizeForm.IconColor = System.Drawing.Color.Snow;
            this.MinimizeForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MinimizeForm.IconSize = 26;
            this.MinimizeForm.Location = new System.Drawing.Point(701, 0);
            this.MinimizeForm.Name = "MinimizeForm";
            this.MinimizeForm.Size = new System.Drawing.Size(358, 3);
            this.MinimizeForm.TabIndex = 0;
            this.MinimizeForm.TabStop = false;
            this.MinimizeForm.UseVisualStyleBackColor = false;
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseFormButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseFormButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CloseFormButton.FlatAppearance.BorderSize = 0;
            this.CloseFormButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.CloseFormButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.CloseFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseFormButton.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.CloseFormButton.IconColor = System.Drawing.Color.Snow;
            this.CloseFormButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CloseFormButton.IconSize = 40;
            this.CloseFormButton.Location = new System.Drawing.Point(730, -1);
            this.CloseFormButton.Name = "CloseFormButton";
            this.CloseFormButton.Size = new System.Drawing.Size(358, 3);
            this.CloseFormButton.TabIndex = 0;
            this.CloseFormButton.TabStop = false;
            this.CloseFormButton.UseVisualStyleBackColor = false;
            // 
            // CharacterCustomizationChar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(529, 452);
            this.Controls.Add(this.BackgroundPannel);
            this.Controls.Add(this.CharNamePannel);
            this.Controls.Add(this.StrenghtPanel);
            this.Controls.Add(this.WindowTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CharacterCustomizationChar";
            this.Text = "/";
            this.Load += new System.EventHandler(this.CharacterCustomization_Load);
            this.BackgroundPannel.ResumeLayout(false);
            this.BackgroundPannel.PerformLayout();
            this.CharNamePannel.ResumeLayout(false);
            this.CharNamePannel.PerformLayout();
            this.StrenghtPanel.ResumeLayout(false);
            this.StrenghtPanel.PerformLayout();
            this.WindowTopBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Label CharacterConstitutionConstitutionLabel;
        private Label CharacterIntelligenceIntelligenceLabel;
        private Label CharacterCharismaCharismaLabel;
        private Label CharacterWisdomWisdomLabel;
        private TextBox CharacterStrenghtTextbox;
        private TextBox CharacterIntelligenceTextbox;
        private TextBox CharacterConstitutionTextbox;
        private TextBox CharacterDexterityTextbox;
        private TextBox CharacterWisdomTextbox;
        private TextBox CharacterCharismaTextbox;
        private Button MoreCustomizations;
        private TextBox CharacterXpCustomizeTextBox;
        private TextBox CharacterLevelCustomizeTextbox;
        private TextBox CharacterNameCustomizeTextbox;
        private Label CharacterXpCustomizeLabel;
        private Label CharacterAlignmentCustomizeLabel;
        private Label CharacterRaceCustomizeLabel;
        private Label CharacterLevelCustomizeLabel;
        private Label CharacterClassCustomizeLabel;
        private Label CharacterNameCustomizeLabel;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private ComboBox CharacterClassCustomizeTextbox;
        private TextBox aw;
        private ComboBox CharacterRaceCustomizeCombobox;
        private ComboBox comboBox1;
        private ComboBox CharacterAlignmentCustomizeCombobox;
        private Button MoreCustomizations2;
        private Label CharacterBackgroundCustomizeLabel;
        private TextBox CharacterBackgroundCustomizeTextbox;
        private Button MoreCustomizations3;
        private Panel BackgroundPannel;
        private Panel CharNamePannel;
        private Panel StrenghtPanel;
        private Label CharacterDexterityDexterityLabel;
        private Label CharacterStrenghtStrenghtLabel;
        private Panel WindowTopBar;
        private FontAwesome.Sharp.IconButton MinimizeForm;
        private FontAwesome.Sharp.IconButton CloseFormButton;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton UpdateCharacterDetailsButton2;
        private FontAwesome.Sharp.IconButton UpdateCharacterDetailsButton;
        private FontAwesome.Sharp.IconButton CharacterBackgroundCustomizeButton;
    }
}