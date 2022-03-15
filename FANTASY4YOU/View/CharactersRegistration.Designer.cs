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
            this.HelperPanel = new System.Windows.Forms.Panel();
            this.CloseFormButton = new FontAwesome.Sharp.IconButton();
            this.WindowTopBar = new System.Windows.Forms.Panel();
            this.CharacterCreationPanel = new System.Windows.Forms.Panel();
            this.CreateCharacter = new ePOSOne.btnProduct.Button_WOC();
            this.WindowTopBar.SuspendLayout();
            this.CharacterCreationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // characterNameTextBox
            // 
            this.characterNameTextBox.Location = new System.Drawing.Point(448, 93);
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
            "Class1",
            "Class2",
            "Class3"});
            this.classComboBox.Location = new System.Drawing.Point(448, 141);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(121, 23);
            this.classComboBox.TabIndex = 1;
            this.classComboBox.TabStop = false;
            // 
            // levelBox
            // 
            this.levelBox.Location = new System.Drawing.Point(448, 183);
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
            this.CharacterNameLabel.Location = new System.Drawing.Point(256, 85);
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
            this.ClassLabel.Location = new System.Drawing.Point(358, 131);
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
            this.LevelLabel.Location = new System.Drawing.Point(367, 175);
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
            "Race1",
            "Race2",
            "Race3"});
            this.raceComboBox.Location = new System.Drawing.Point(448, 227);
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
            this.RaceLabel.Location = new System.Drawing.Point(367, 217);
            this.RaceLabel.Name = "RaceLabel";
            this.RaceLabel.Size = new System.Drawing.Size(75, 31);
            this.RaceLabel.TabIndex = 7;
            this.RaceLabel.Text = "Race :";
            // 
            // backgroundTextBox
            // 
            this.backgroundTextBox.Location = new System.Drawing.Point(448, 372);
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
            this.BackgroundLabel.Location = new System.Drawing.Point(299, 362);
            this.BackgroundLabel.Name = "BackgroundLabel";
            this.BackgroundLabel.Size = new System.Drawing.Size(143, 31);
            this.BackgroundLabel.TabIndex = 9;
            this.BackgroundLabel.Text = "Background :";
            // 
            // xpTextBox
            // 
            this.xpTextBox.Location = new System.Drawing.Point(448, 273);
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
            this.XpLabel.Location = new System.Drawing.Point(380, 265);
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
            this.AlignmentLabel.Location = new System.Drawing.Point(315, 313);
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
            "Alignment1",
            "Alignment2",
            "Alignment3"});
            this.alignmentComboBox.Location = new System.Drawing.Point(448, 321);
            this.alignmentComboBox.Name = "alignmentComboBox";
            this.alignmentComboBox.Size = new System.Drawing.Size(121, 23);
            this.alignmentComboBox.TabIndex = 14;
            this.alignmentComboBox.TabStop = false;
            // 
            // HelperPanel
            // 
            this.HelperPanel.Location = new System.Drawing.Point(1037, -4);
            this.HelperPanel.Name = "HelperPanel";
            this.HelperPanel.Size = new System.Drawing.Size(37, 37);
            this.HelperPanel.TabIndex = 25;
            this.HelperPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HelperPanel_MouseDown);
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
            this.CloseFormButton.IconSize = 49;
            this.CloseFormButton.Location = new System.Drawing.Point(1066, -6);
            this.CloseFormButton.Name = "CloseFormButton";
            this.CloseFormButton.Size = new System.Drawing.Size(52, 50);
            this.CloseFormButton.TabIndex = 24;
            this.CloseFormButton.TabStop = false;
            this.CloseFormButton.UseVisualStyleBackColor = false;
            this.CloseFormButton.Click += new System.EventHandler(this.CloseFormButton_Click);
            // 
            // WindowTopBar
            // 
            this.WindowTopBar.BackColor = System.Drawing.Color.IndianRed;
            this.WindowTopBar.Controls.Add(this.HelperPanel);
            this.WindowTopBar.Controls.Add(this.CloseFormButton);
            this.WindowTopBar.Location = new System.Drawing.Point(0, 0);
            this.WindowTopBar.Name = "WindowTopBar";
            this.WindowTopBar.Size = new System.Drawing.Size(1109, 31);
            this.WindowTopBar.TabIndex = 0;
            this.WindowTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowTopBar_MouseDown);
            // 
            // CharacterCreationPanel
            // 
            this.CharacterCreationPanel.BackColor = System.Drawing.Color.Transparent;
            this.CharacterCreationPanel.Controls.Add(this.CreateCharacter);
            this.CharacterCreationPanel.Controls.Add(this.raceComboBox);
            this.CharacterCreationPanel.Controls.Add(this.characterNameTextBox);
            this.CharacterCreationPanel.Controls.Add(this.classComboBox);
            this.CharacterCreationPanel.Controls.Add(this.alignmentComboBox);
            this.CharacterCreationPanel.Controls.Add(this.levelBox);
            this.CharacterCreationPanel.Controls.Add(this.AlignmentLabel);
            this.CharacterCreationPanel.Controls.Add(this.CharacterNameLabel);
            this.CharacterCreationPanel.Controls.Add(this.XpLabel);
            this.CharacterCreationPanel.Controls.Add(this.ClassLabel);
            this.CharacterCreationPanel.Controls.Add(this.xpTextBox);
            this.CharacterCreationPanel.Controls.Add(this.LevelLabel);
            this.CharacterCreationPanel.Controls.Add(this.BackgroundLabel);
            this.CharacterCreationPanel.Controls.Add(this.RaceLabel);
            this.CharacterCreationPanel.Controls.Add(this.backgroundTextBox);
            this.CharacterCreationPanel.Location = new System.Drawing.Point(0, 28);
            this.CharacterCreationPanel.Name = "CharacterCreationPanel";
            this.CharacterCreationPanel.Size = new System.Drawing.Size(1109, 633);
            this.CharacterCreationPanel.TabIndex = 16;
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
            this.CreateCharacter.Location = new System.Drawing.Point(448, 493);
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
            // CharacterRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1108, 658);
            this.Controls.Add(this.WindowTopBar);
            this.Controls.Add(this.CharacterCreationPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CharacterRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CharactersRegistration";
            this.Load += new System.EventHandler(this.CharacterRegistration_Load);
            this.WindowTopBar.ResumeLayout(false);
            this.CharacterCreationPanel.ResumeLayout(false);
            this.CharacterCreationPanel.PerformLayout();
            this.ResumeLayout(false);

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
        private Panel HelperPanel;
        private FontAwesome.Sharp.IconButton CloseFormButton;
        private Panel WindowTopBar;
        private Panel CharacterCreationPanel;
        private ePOSOne.btnProduct.Button_WOC CreateCharacter;
    }
}