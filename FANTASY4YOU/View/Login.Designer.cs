using FANTASY4YOU;
namespace FANTASY4YOU
{
    partial class Login
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.WelcomeLabel2 = new System.Windows.Forms.Label();
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.ShowPassword = new System.Windows.Forms.Button();
            this.HidePassword = new System.Windows.Forms.Button();
            this.PleaseWaitLabel = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.DontHaveAnAccountLabel = new System.Windows.Forms.LinkLabel();
            this.LoginButton = new ePOSOne.btnProduct.Button_WOC();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.RefreshButton = new FontAwesome.Sharp.IconButton();
            this.LoginSettingsButton = new FontAwesome.Sharp.IconButton();
            this.CloseHelperPannel2 = new System.Windows.Forms.Panel();
            this.WindowTopBar = new System.Windows.Forms.Panel();
            this.CloseFormButton = new FontAwesome.Sharp.IconButton();
            this.CloseHelperPannel1 = new System.Windows.Forms.Panel();
            this.LoginPanel.SuspendLayout();
            this.WindowTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeLabel.Font = new System.Drawing.Font("Old London", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.WelcomeLabel.ForeColor = System.Drawing.Color.SandyBrown;
            this.WelcomeLabel.Location = new System.Drawing.Point(137, 26);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(479, 55);
            this.WelcomeLabel.TabIndex = 1;
            this.WelcomeLabel.Text = "Welcome to Fantasy4You";
            // 
            // WelcomeLabel2
            // 
            this.WelcomeLabel2.AutoSize = true;
            this.WelcomeLabel2.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeLabel2.Font = new System.Drawing.Font("Old London", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WelcomeLabel2.ForeColor = System.Drawing.Color.SandyBrown;
            this.WelcomeLabel2.Location = new System.Drawing.Point(171, 93);
            this.WelcomeLabel2.Name = "WelcomeLabel2";
            this.WelcomeLabel2.Size = new System.Drawing.Size(408, 31);
            this.WelcomeLabel2.TabIndex = 2;
            this.WelcomeLabel2.Text = "to continue please put in your credentials";
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Location = new System.Drawing.Point(290, 174);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(177, 23);
            this.UsernameTextbox.TabIndex = 3;
            this.UsernameTextbox.TabStop = false;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.Font = new System.Drawing.Font("Old London", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameLabel.ForeColor = System.Drawing.Color.SandyBrown;
            this.UsernameLabel.Location = new System.Drawing.Point(157, 162);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(127, 35);
            this.UsernameLabel.TabIndex = 5;
            this.UsernameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Font = new System.Drawing.Font("Old London", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordLabel.ForeColor = System.Drawing.Color.SandyBrown;
            this.PasswordLabel.Location = new System.Drawing.Point(157, 212);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(124, 35);
            this.PasswordLabel.TabIndex = 6;
            this.PasswordLabel.Text = "Password";
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Location = new System.Drawing.Point(287, 225);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(177, 23);
            this.PasswordTextbox.TabIndex = 8;
            this.PasswordTextbox.TabStop = false;
            this.PasswordTextbox.UseSystemPasswordChar = true;
            // 
            // ShowPassword
            // 
            this.ShowPassword.BackColor = System.Drawing.Color.Tan;
            this.ShowPassword.FlatAppearance.BorderSize = 0;
            this.ShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ShowPassword.Location = new System.Drawing.Point(488, 225);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(29, 23);
            this.ShowPassword.TabIndex = 9;
            this.ShowPassword.Text = "X";
            this.ShowPassword.UseVisualStyleBackColor = false;
            this.ShowPassword.Click += new System.EventHandler(this.ShowPassword_Click);
            // 
            // HidePassword
            // 
            this.HidePassword.BackColor = System.Drawing.Color.Tan;
            this.HidePassword.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.HidePassword.FlatAppearance.BorderSize = 0;
            this.HidePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HidePassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HidePassword.Location = new System.Drawing.Point(488, 225);
            this.HidePassword.Name = "HidePassword";
            this.HidePassword.Size = new System.Drawing.Size(29, 23);
            this.HidePassword.TabIndex = 10;
            this.HidePassword.Text = "X";
            this.HidePassword.UseVisualStyleBackColor = false;
            this.HidePassword.Visible = false;
            this.HidePassword.Click += new System.EventHandler(this.HidePassword_Click);
            // 
            // PleaseWaitLabel
            // 
            this.PleaseWaitLabel.AutoSize = true;
            this.PleaseWaitLabel.BackColor = System.Drawing.Color.Transparent;
            this.PleaseWaitLabel.ForeColor = System.Drawing.Color.SandyBrown;
            this.PleaseWaitLabel.Location = new System.Drawing.Point(334, 347);
            this.PleaseWaitLabel.Name = "PleaseWaitLabel";
            this.PleaseWaitLabel.Size = new System.Drawing.Size(76, 15);
            this.PleaseWaitLabel.TabIndex = 12;
            this.PleaseWaitLabel.Text = "Please Wait...";
            this.PleaseWaitLabel.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.ForeColor = System.Drawing.Color.SandyBrown;
            this.checkBox1.Location = new System.Drawing.Point(160, 295);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 19);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Remember Me";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // DontHaveAnAccountLabel
            // 
            this.DontHaveAnAccountLabel.AutoSize = true;
            this.DontHaveAnAccountLabel.BackColor = System.Drawing.Color.Transparent;
            this.DontHaveAnAccountLabel.ForeColor = System.Drawing.Color.Coral;
            this.DontHaveAnAccountLabel.LinkColor = System.Drawing.Color.SandyBrown;
            this.DontHaveAnAccountLabel.Location = new System.Drawing.Point(490, 309);
            this.DontHaveAnAccountLabel.Name = "DontHaveAnAccountLabel";
            this.DontHaveAnAccountLabel.Size = new System.Drawing.Size(128, 15);
            this.DontHaveAnAccountLabel.TabIndex = 14;
            this.DontHaveAnAccountLabel.TabStop = true;
            this.DontHaveAnAccountLabel.Text = "Dont have an account?";
            this.DontHaveAnAccountLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DontHaveAnAccountLabel_LinkClicked);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Transparent;
            this.LoginButton.BorderColor = System.Drawing.Color.Transparent;
            this.LoginButton.ButtonColor = System.Drawing.Color.SandyBrown;
            this.LoginButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LoginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Old London", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginButton.Location = new System.Drawing.Point(270, 275);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.OnHoverBackColor = System.Drawing.Color.Transparent;
            this.LoginButton.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.LoginButton.OnHoverButtonColor = System.Drawing.Color.SandyBrown;
            this.LoginButton.OnHoverTextColor = System.Drawing.Color.Coral;
            this.LoginButton.Size = new System.Drawing.Size(221, 56);
            this.LoginButton.TabIndex = 18;
            this.LoginButton.TabStop = false;
            this.LoginButton.Text = "Login";
            this.LoginButton.TextColor = System.Drawing.Color.White;
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.Transparent;
            this.LoginPanel.Controls.Add(this.RefreshButton);
            this.LoginPanel.Controls.Add(this.LoginSettingsButton);
            this.LoginPanel.Controls.Add(this.UsernameTextbox);
            this.LoginPanel.Controls.Add(this.LoginButton);
            this.LoginPanel.Controls.Add(this.WelcomeLabel);
            this.LoginPanel.Controls.Add(this.WelcomeLabel2);
            this.LoginPanel.Controls.Add(this.UsernameLabel);
            this.LoginPanel.Controls.Add(this.DontHaveAnAccountLabel);
            this.LoginPanel.Controls.Add(this.PasswordLabel);
            this.LoginPanel.Controls.Add(this.checkBox1);
            this.LoginPanel.Controls.Add(this.PasswordTextbox);
            this.LoginPanel.Controls.Add(this.PleaseWaitLabel);
            this.LoginPanel.Controls.Add(this.ShowPassword);
            this.LoginPanel.Controls.Add(this.HidePassword);
            this.LoginPanel.Location = new System.Drawing.Point(0, 25);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(760, 424);
            this.LoginPanel.TabIndex = 19;
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.Transparent;
            this.RefreshButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RefreshButton.FlatAppearance.BorderSize = 0;
            this.RefreshButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RefreshButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.RefreshButton.IconColor = System.Drawing.Color.SandyBrown;
            this.RefreshButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RefreshButton.IconSize = 29;
            this.RefreshButton.Location = new System.Drawing.Point(673, 378);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(44, 46);
            this.RefreshButton.TabIndex = 20;
            this.RefreshButton.TabStop = false;
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshFormButton_Click);
            // 
            // LoginSettingsButton
            // 
            this.LoginSettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.LoginSettingsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LoginSettingsButton.FlatAppearance.BorderSize = 0;
            this.LoginSettingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LoginSettingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.LoginSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginSettingsButton.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.LoginSettingsButton.IconColor = System.Drawing.Color.SandyBrown;
            this.LoginSettingsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LoginSettingsButton.IconSize = 29;
            this.LoginSettingsButton.Location = new System.Drawing.Point(710, 378);
            this.LoginSettingsButton.Name = "LoginSettingsButton";
            this.LoginSettingsButton.Size = new System.Drawing.Size(48, 46);
            this.LoginSettingsButton.TabIndex = 19;
            this.LoginSettingsButton.TabStop = false;
            this.LoginSettingsButton.UseVisualStyleBackColor = false;
            this.LoginSettingsButton.Click += new System.EventHandler(this.LoginSettingsButton_Click);
            // 
            // CloseHelperPannel2
            // 
            this.CloseHelperPannel2.Location = new System.Drawing.Point(706, 0);
            this.CloseHelperPannel2.Name = "CloseHelperPannel2";
            this.CloseHelperPannel2.Size = new System.Drawing.Size(24, 26);
            this.CloseHelperPannel2.TabIndex = 20;
            // 
            // WindowTopBar
            // 
            this.WindowTopBar.BackColor = System.Drawing.Color.IndianRed;
            this.WindowTopBar.Controls.Add(this.CloseHelperPannel2);
            this.WindowTopBar.Controls.Add(this.CloseFormButton);
            this.WindowTopBar.Controls.Add(this.CloseHelperPannel1);
            this.WindowTopBar.Location = new System.Drawing.Point(0, 0);
            this.WindowTopBar.Name = "WindowTopBar";
            this.WindowTopBar.Size = new System.Drawing.Size(763, 25);
            this.WindowTopBar.TabIndex = 20;
            this.WindowTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowTopBar_MouseDown);
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
            this.CloseFormButton.Location = new System.Drawing.Point(729, -1);
            this.CloseFormButton.Name = "CloseFormButton";
            this.CloseFormButton.Size = new System.Drawing.Size(30, 33);
            this.CloseFormButton.TabIndex = 0;
            this.CloseFormButton.TabStop = false;
            this.CloseFormButton.UseVisualStyleBackColor = false;
            this.CloseFormButton.Click += new System.EventHandler(this.CloseFormButton_Click);
            // 
            // CloseHelperPannel1
            // 
            this.CloseHelperPannel1.Location = new System.Drawing.Point(710, 22);
            this.CloseHelperPannel1.Name = "CloseHelperPannel1";
            this.CloseHelperPannel1.Size = new System.Drawing.Size(69, 22);
            this.CloseHelperPannel1.TabIndex = 19;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::FANTASY4YOU.Properties.Resources.starter1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(759, 448);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.WindowTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(10, 10);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fantasy4You";
            this.TransparencyKey = System.Drawing.Color.LimeGreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.WindowTopBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Label WelcomeLabel;
        private Label WelcomeLabel2;
        private TextBox UsernameTextbox;
        private Label UsernameLabel;
        private Label PasswordLabel;
        private TextBox PasswordTextbox;
        private Button ShowPassword;
        private Button HidePassword;
        private Label PleaseWaitLabel;
        private CheckBox checkBox1;
        private LinkLabel DontHaveAnAccountLabel;
        private ePOSOne.btnProduct.Button_WOC LoginButton;
        private Panel LoginPanel;
        private Panel WindowTopBar;
        private FontAwesome.Sharp.IconButton CloseFormButton;
        private Panel CloseHelperPannel1;
        private Panel CloseHelperPannel2;
        private FontAwesome.Sharp.IconButton LoginSettingsButton;
        private FontAwesome.Sharp.IconButton RefreshButton;
    }
}