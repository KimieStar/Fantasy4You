namespace FANTASY4YOU
{
    partial class UserAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAccount));
            this.AccountLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NumberOfcharacters = new System.Windows.Forms.Label();
            this.ChangeUsernameButton = new System.Windows.Forms.Button();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.DeleteCharacters = new FontAwesome.Sharp.IconButton();
            this.DeleteUserAccount = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AccountLabel
            // 
            this.AccountLabel.AutoSize = true;
            this.AccountLabel.BackColor = System.Drawing.Color.Transparent;
            this.AccountLabel.Font = new System.Drawing.Font("Old London", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccountLabel.ForeColor = System.Drawing.Color.BurlyWood;
            this.AccountLabel.Location = new System.Drawing.Point(247, 9);
            this.AccountLabel.Name = "AccountLabel";
            this.AccountLabel.Size = new System.Drawing.Size(170, 60);
            this.AccountLabel.TabIndex = 0;
            this.AccountLabel.Text = "Account";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.Font = new System.Drawing.Font("Old London", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameLabel.ForeColor = System.Drawing.Color.BurlyWood;
            this.UsernameLabel.Location = new System.Drawing.Point(231, 92);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(63, 31);
            this.UsernameLabel.TabIndex = 3;
            this.UsernameLabel.Text = "User";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // NumberOfcharacters
            // 
            this.NumberOfcharacters.AutoSize = true;
            this.NumberOfcharacters.BackColor = System.Drawing.Color.Transparent;
            this.NumberOfcharacters.Font = new System.Drawing.Font("Old London", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumberOfcharacters.ForeColor = System.Drawing.Color.BurlyWood;
            this.NumberOfcharacters.Location = new System.Drawing.Point(231, 134);
            this.NumberOfcharacters.Name = "NumberOfcharacters";
            this.NumberOfcharacters.Size = new System.Drawing.Size(33, 23);
            this.NumberOfcharacters.TabIndex = 6;
            this.NumberOfcharacters.Text = "0/5";
            // 
            // ChangeUsernameButton
            // 
            this.ChangeUsernameButton.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ChangeUsernameButton.FlatAppearance.BorderSize = 0;
            this.ChangeUsernameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeUsernameButton.Font = new System.Drawing.Font("Old London", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangeUsernameButton.ForeColor = System.Drawing.Color.IndianRed;
            this.ChangeUsernameButton.Location = new System.Drawing.Point(231, 172);
            this.ChangeUsernameButton.Name = "ChangeUsernameButton";
            this.ChangeUsernameButton.Size = new System.Drawing.Size(186, 41);
            this.ChangeUsernameButton.TabIndex = 7;
            this.ChangeUsernameButton.Text = "ChangeUsername";
            this.ChangeUsernameButton.UseVisualStyleBackColor = false;
            this.ChangeUsernameButton.Click += new System.EventHandler(this.ChangeUsernameButton_Click);
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.changePasswordButton.FlatAppearance.BorderSize = 0;
            this.changePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePasswordButton.Font = new System.Drawing.Font("Old London", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changePasswordButton.ForeColor = System.Drawing.Color.IndianRed;
            this.changePasswordButton.Location = new System.Drawing.Point(231, 219);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(186, 41);
            this.changePasswordButton.TabIndex = 8;
            this.changePasswordButton.Text = "ChangePassword";
            this.changePasswordButton.UseVisualStyleBackColor = false;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // DeleteCharacters
            // 
            this.DeleteCharacters.BackColor = System.Drawing.Color.Transparent;
            this.DeleteCharacters.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DeleteCharacters.FlatAppearance.BorderSize = 0;
            this.DeleteCharacters.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.DeleteCharacters.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.DeleteCharacters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteCharacters.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.DeleteCharacters.IconColor = System.Drawing.Color.BurlyWood;
            this.DeleteCharacters.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DeleteCharacters.IconSize = 37;
            this.DeleteCharacters.Location = new System.Drawing.Point(341, 124);
            this.DeleteCharacters.Name = "DeleteCharacters";
            this.DeleteCharacters.Size = new System.Drawing.Size(50, 46);
            this.DeleteCharacters.TabIndex = 23;
            this.DeleteCharacters.TabStop = false;
            this.DeleteCharacters.UseVisualStyleBackColor = false;
            this.DeleteCharacters.Click += new System.EventHandler(this.DeleteCharacters_Click);
            // 
            // DeleteUserAccount
            // 
            this.DeleteUserAccount.BackColor = System.Drawing.Color.Transparent;
            this.DeleteUserAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DeleteUserAccount.FlatAppearance.BorderSize = 0;
            this.DeleteUserAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.DeleteUserAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.DeleteUserAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteUserAccount.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.DeleteUserAccount.IconColor = System.Drawing.Color.IndianRed;
            this.DeleteUserAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DeleteUserAccount.IconSize = 50;
            this.DeleteUserAccount.Location = new System.Drawing.Point(591, 295);
            this.DeleteUserAccount.Name = "DeleteUserAccount";
            this.DeleteUserAccount.Size = new System.Drawing.Size(72, 68);
            this.DeleteUserAccount.TabIndex = 24;
            this.DeleteUserAccount.TabStop = false;
            this.DeleteUserAccount.UseVisualStyleBackColor = false;
            this.DeleteUserAccount.Click += new System.EventHandler(this.DeleteUserAccount_Click);
            // 
            // UserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(656, 358);
            this.Controls.Add(this.DeleteUserAccount);
            this.Controls.Add(this.DeleteCharacters);
            this.Controls.Add(this.changePasswordButton);
            this.Controls.Add(this.ChangeUsernameButton);
            this.Controls.Add(this.NumberOfcharacters);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.AccountLabel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserAccount";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fantasy4You";
            this.Load += new System.EventHandler(this.UserAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label AccountLabel;
        private Label UsernameLabel;
        private PictureBox pictureBox1;
        private Label NumberOfcharacters;
        private Button ChangeUsernameButton;
        private Button changePasswordButton;
        private FontAwesome.Sharp.IconButton DeleteCharacters;
        private FontAwesome.Sharp.IconButton DeleteUserAccount;
    }
}