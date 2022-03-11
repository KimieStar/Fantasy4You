namespace FANTASY4YOU
{
    partial class MainInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainInterface));
            this.comingsoonLabel2 = new System.Windows.Forms.Label();
            this.comingsoonLabel1 = new System.Windows.Forms.Label();
            this.YourCharactersLabel = new System.Windows.Forms.Label();
            this.IdL = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.usernameL = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.WindowTopBar = new System.Windows.Forms.Panel();
            this.PanelHelper = new System.Windows.Forms.Panel();
            this.CloseFormButton = new FontAwesome.Sharp.IconButton();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.comingSoonButton2 = new FontAwesome.Sharp.IconButton();
            this.comingSoonButton1 = new FontAwesome.Sharp.IconButton();
            this.YourCharactersButton = new FontAwesome.Sharp.IconButton();
            this.WindowTopBar.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // comingsoonLabel2
            // 
            this.comingsoonLabel2.AutoSize = true;
            this.comingsoonLabel2.Font = new System.Drawing.Font("Old London", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comingsoonLabel2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.comingsoonLabel2.Location = new System.Drawing.Point(773, 395);
            this.comingsoonLabel2.Name = "comingsoonLabel2";
            this.comingsoonLabel2.Size = new System.Drawing.Size(213, 45);
            this.comingsoonLabel2.TabIndex = 19;
            this.comingsoonLabel2.Text = "Coming soon!";
            // 
            // comingsoonLabel1
            // 
            this.comingsoonLabel1.AutoSize = true;
            this.comingsoonLabel1.Font = new System.Drawing.Font("Old London", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comingsoonLabel1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.comingsoonLabel1.Location = new System.Drawing.Point(503, 395);
            this.comingsoonLabel1.Name = "comingsoonLabel1";
            this.comingsoonLabel1.Size = new System.Drawing.Size(213, 45);
            this.comingsoonLabel1.TabIndex = 18;
            this.comingsoonLabel1.Text = "Coming soon!";
            // 
            // YourCharactersLabel
            // 
            this.YourCharactersLabel.AutoSize = true;
            this.YourCharactersLabel.Font = new System.Drawing.Font("Old London", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.YourCharactersLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.YourCharactersLabel.Location = new System.Drawing.Point(215, 395);
            this.YourCharactersLabel.Name = "YourCharactersLabel";
            this.YourCharactersLabel.Size = new System.Drawing.Size(252, 45);
            this.YourCharactersLabel.TabIndex = 17;
            this.YourCharactersLabel.Text = "Your Characters";
            // 
            // IdL
            // 
            this.IdL.AutoSize = true;
            this.IdL.Font = new System.Drawing.Font("Old London", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdL.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.IdL.Location = new System.Drawing.Point(104, 68);
            this.IdL.Name = "IdL";
            this.IdL.Size = new System.Drawing.Size(117, 31);
            this.IdL.TabIndex = 13;
            this.IdL.Text = "placeholder";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Old London", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.IdLabel.Location = new System.Drawing.Point(46, 66);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(65, 33);
            this.IdLabel.TabIndex = 12;
            this.IdLabel.Text = "ID :";
            // 
            // usernameL
            // 
            this.usernameL.AutoSize = true;
            this.usernameL.Font = new System.Drawing.Font("Old London", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameL.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.usernameL.Location = new System.Drawing.Point(173, 35);
            this.usernameL.Name = "usernameL";
            this.usernameL.Size = new System.Drawing.Size(105, 31);
            this.usernameL.TabIndex = 11;
            this.usernameL.Text = "username";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Old London", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.UsernameLabel.Location = new System.Drawing.Point(46, 32);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(133, 33);
            this.UsernameLabel.TabIndex = 10;
            this.UsernameLabel.Text = "Username :";
            // 
            // WindowTopBar
            // 
            this.WindowTopBar.BackColor = System.Drawing.Color.IndianRed;
            this.WindowTopBar.Controls.Add(this.PanelHelper);
            this.WindowTopBar.Controls.Add(this.CloseFormButton);
            this.WindowTopBar.Location = new System.Drawing.Point(0, 0);
            this.WindowTopBar.Name = "WindowTopBar";
            this.WindowTopBar.Size = new System.Drawing.Size(1250, 35);
            this.WindowTopBar.TabIndex = 20;
            this.WindowTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowTopBar_MouseDown);
            // 
            // PanelHelper
            // 
            this.PanelHelper.Location = new System.Drawing.Point(1174, 0);
            this.PanelHelper.Name = "PanelHelper";
            this.PanelHelper.Size = new System.Drawing.Size(36, 100);
            this.PanelHelper.TabIndex = 2;
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
            this.CloseFormButton.IconSize = 55;
            this.CloseFormButton.Location = new System.Drawing.Point(1208, -1);
            this.CloseFormButton.Name = "CloseFormButton";
            this.CloseFormButton.Size = new System.Drawing.Size(44, 46);
            this.CloseFormButton.TabIndex = 1;
            this.CloseFormButton.TabStop = false;
            this.CloseFormButton.UseVisualStyleBackColor = false;
            this.CloseFormButton.Click += new System.EventHandler(this.CloseFormButton_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.Controls.Add(this.comingSoonButton2);
            this.MainPanel.Controls.Add(this.comingSoonButton1);
            this.MainPanel.Controls.Add(this.YourCharactersButton);
            this.MainPanel.Controls.Add(this.IdL);
            this.MainPanel.Controls.Add(this.comingsoonLabel2);
            this.MainPanel.Controls.Add(this.IdLabel);
            this.MainPanel.Controls.Add(this.usernameL);
            this.MainPanel.Controls.Add(this.comingsoonLabel1);
            this.MainPanel.Controls.Add(this.UsernameLabel);
            this.MainPanel.Controls.Add(this.YourCharactersLabel);
            this.MainPanel.Location = new System.Drawing.Point(0, 35);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1252, 683);
            this.MainPanel.TabIndex = 21;
            // 
            // comingSoonButton2
            // 
            this.comingSoonButton2.Enabled = false;
            this.comingSoonButton2.FlatAppearance.BorderSize = 0;
            this.comingSoonButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comingSoonButton2.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.comingSoonButton2.IconColor = System.Drawing.Color.Firebrick;
            this.comingSoonButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.comingSoonButton2.IconSize = 100;
            this.comingSoonButton2.Location = new System.Drawing.Point(842, 309);
            this.comingSoonButton2.Name = "comingSoonButton2";
            this.comingSoonButton2.Size = new System.Drawing.Size(75, 92);
            this.comingSoonButton2.TabIndex = 23;
            this.comingSoonButton2.UseVisualStyleBackColor = true;
            // 
            // comingSoonButton1
            // 
            this.comingSoonButton1.Enabled = false;
            this.comingSoonButton1.FlatAppearance.BorderSize = 0;
            this.comingSoonButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comingSoonButton1.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.comingSoonButton1.IconColor = System.Drawing.Color.Firebrick;
            this.comingSoonButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.comingSoonButton1.IconSize = 100;
            this.comingSoonButton1.Location = new System.Drawing.Point(574, 309);
            this.comingSoonButton1.Name = "comingSoonButton1";
            this.comingSoonButton1.Size = new System.Drawing.Size(75, 92);
            this.comingSoonButton1.TabIndex = 22;
            this.comingSoonButton1.UseVisualStyleBackColor = true;
            // 
            // YourCharactersButton
            // 
            this.YourCharactersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.YourCharactersButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.YourCharactersButton.FlatAppearance.BorderSize = 0;
            this.YourCharactersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.YourCharactersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.YourCharactersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YourCharactersButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.YourCharactersButton.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.YourCharactersButton.IconColor = System.Drawing.Color.Wheat;
            this.YourCharactersButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.YourCharactersButton.IconSize = 100;
            this.YourCharactersButton.Location = new System.Drawing.Point(297, 321);
            this.YourCharactersButton.Name = "YourCharactersButton";
            this.YourCharactersButton.Size = new System.Drawing.Size(70, 68);
            this.YourCharactersButton.TabIndex = 21;
            this.YourCharactersButton.TabStop = false;
            this.YourCharactersButton.UseVisualStyleBackColor = false;
            this.YourCharactersButton.Click += new System.EventHandler(this.YourCharactersButton_Click);
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1249, 713);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.WindowTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainInterface";
            this.Text = "MainInterface";
            this.Load += new System.EventHandler(this.MainInterface_Load);
            this.WindowTopBar.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label comingsoonLabel2;
        private Label comingsoonLabel1;
        private Label YourCharactersLabel;
        private Label IdL;
        private Label IdLabel;
        private Label usernameL;
        private Label UsernameLabel;
        private Panel WindowTopBar;
        private FontAwesome.Sharp.IconButton CloseFormButton;
        private Panel MainPanel;
        private Panel PanelHelper;
        private FontAwesome.Sharp.IconButton YourCharactersButton;
        private FontAwesome.Sharp.IconButton comingSoonButton2;
        private FontAwesome.Sharp.IconButton comingSoonButton1;
    }
}