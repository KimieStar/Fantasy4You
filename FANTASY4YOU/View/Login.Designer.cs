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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
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
            this.RefreshButton = new FontAwesome.Sharp.IconButton();
            this.LoginSettingsButton = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeLabel.Font = new System.Drawing.Font("Old London", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.WelcomeLabel.ForeColor = System.Drawing.Color.SandyBrown;
            this.WelcomeLabel.Location = new System.Drawing.Point(134, 28);
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
            this.WelcomeLabel2.Location = new System.Drawing.Point(168, 95);
            this.WelcomeLabel2.Name = "WelcomeLabel2";
            this.WelcomeLabel2.Size = new System.Drawing.Size(408, 31);
            this.WelcomeLabel2.TabIndex = 2;
            this.WelcomeLabel2.Text = "to continue please put in your credentials";
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Location = new System.Drawing.Point(287, 176);
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
            this.UsernameLabel.Location = new System.Drawing.Point(154, 164);
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
            this.PasswordLabel.Location = new System.Drawing.Point(154, 214);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(124, 35);
            this.PasswordLabel.TabIndex = 6;
            this.PasswordLabel.Text = "Password";
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Location = new System.Drawing.Point(284, 227);
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
            this.ShowPassword.Location = new System.Drawing.Point(467, 226);
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
            this.HidePassword.Location = new System.Drawing.Point(467, 227);
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
            this.PleaseWaitLabel.Location = new System.Drawing.Point(331, 349);
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
            this.checkBox1.Location = new System.Drawing.Point(157, 297);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 19);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Remember Me";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // DontHaveAnAccountLabel
            // 
            this.DontHaveAnAccountLabel.AutoSize = true;
            this.DontHaveAnAccountLabel.BackColor = System.Drawing.Color.Transparent;
            this.DontHaveAnAccountLabel.ForeColor = System.Drawing.Color.Coral;
            this.DontHaveAnAccountLabel.LinkColor = System.Drawing.Color.SandyBrown;
            this.DontHaveAnAccountLabel.Location = new System.Drawing.Point(494, 313);
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
            this.LoginButton.Location = new System.Drawing.Point(267, 277);
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
            // RefreshButton
            // 
            this.RefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.RefreshButton.Location = new System.Drawing.Point(666, 367);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(50, 97);
            this.RefreshButton.TabIndex = 20;
            this.RefreshButton.TabStop = false;
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshFormButton_Click);
            // 
            // LoginSettingsButton
            // 
            this.LoginSettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.LoginSettingsButton.Location = new System.Drawing.Point(707, 367);
            this.LoginSettingsButton.Name = "LoginSettingsButton";
            this.LoginSettingsButton.Size = new System.Drawing.Size(50, 97);
            this.LoginSettingsButton.TabIndex = 19;
            this.LoginSettingsButton.TabStop = false;
            this.LoginSettingsButton.UseVisualStyleBackColor = false;
            this.LoginSettingsButton.Click += new System.EventHandler(this.LoginSettingsButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(759, 448);
            this.Controls.Add(this.LoginSettingsButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.ShowPassword);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.WelcomeLabel2);
            this.Controls.Add(this.DontHaveAnAccountLabel);
            this.Controls.Add(this.HidePassword);
            this.Controls.Add(this.UsernameTextbox);
            this.Controls.Add(this.PleaseWaitLabel);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.UsernameLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(10, 10);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fantasy4You";
            this.TransparencyKey = System.Drawing.Color.LimeGreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private FontAwesome.Sharp.IconButton LoginSettingsButton;
        private FontAwesome.Sharp.IconButton RefreshButton;
    }
}