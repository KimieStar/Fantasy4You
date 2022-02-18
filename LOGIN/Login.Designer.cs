namespace Fantasy4You
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.ShowPassword = new System.Windows.Forms.Button();
            this.HidePassword = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.LoggingInLabel = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.DontHaveAnAccountLabel = new System.Windows.Forms.LinkLabel();
            this.RefreshFormButton = new System.Windows.Forms.Button();
            this.LoginSettingsButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(186, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to Fantasy4You";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(176, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "to continue please put in your credentials";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Location = new System.Drawing.Point(277, 158);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(152, 23);
            this.UsernameTextbox.TabIndex = 3;
            this.UsernameTextbox.TextChanged += new System.EventHandler(this.UsernameTextbox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.SandyBrown;
            this.label3.Location = new System.Drawing.Point(186, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Username";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.SandyBrown;
            this.label4.Location = new System.Drawing.Point(186, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Location = new System.Drawing.Point(277, 208);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(152, 23);
            this.PasswordTextbox.TabIndex = 8;
            this.PasswordTextbox.UseSystemPasswordChar = true;
            this.PasswordTextbox.TextChanged += new System.EventHandler(this.PasswordTextbox_TextChanged);
            // 
            // ShowPassword
            // 
            this.ShowPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ShowPassword.Location = new System.Drawing.Point(435, 208);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(29, 23);
            this.ShowPassword.TabIndex = 9;
            this.ShowPassword.Text = "X";
            this.ShowPassword.UseVisualStyleBackColor = true;
            this.ShowPassword.Click += new System.EventHandler(this.ShowPassword_Click);
            // 
            // HidePassword
            // 
            this.HidePassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HidePassword.Location = new System.Drawing.Point(435, 208);
            this.HidePassword.Name = "HidePassword";
            this.HidePassword.Size = new System.Drawing.Size(29, 23);
            this.HidePassword.TabIndex = 10;
            this.HidePassword.Text = "X";
            this.HidePassword.UseVisualStyleBackColor = true;
            this.HidePassword.Visible = false;
            this.HidePassword.Click += new System.EventHandler(this.HidePassword_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(226, 277);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(221, 47);
            this.LoginButton.TabIndex = 11;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoggingInLabel
            // 
            this.LoggingInLabel.AutoSize = true;
            this.LoggingInLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoggingInLabel.Location = new System.Drawing.Point(304, 336);
            this.LoggingInLabel.Name = "LoggingInLabel";
            this.LoggingInLabel.Size = new System.Drawing.Size(76, 15);
            this.LoggingInLabel.TabIndex = 12;
            this.LoggingInLabel.Text = "Please Wait...";
            this.LoggingInLabel.Visible = false;
            this.LoggingInLabel.Click += new System.EventHandler(this.LoggingInLabel_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.ForeColor = System.Drawing.Color.SandyBrown;
            this.checkBox1.Location = new System.Drawing.Point(212, 252);
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
            this.DontHaveAnAccountLabel.LinkColor = System.Drawing.Color.Coral;
            this.DontHaveAnAccountLabel.Location = new System.Drawing.Point(453, 309);
            this.DontHaveAnAccountLabel.Name = "DontHaveAnAccountLabel";
            this.DontHaveAnAccountLabel.Size = new System.Drawing.Size(128, 15);
            this.DontHaveAnAccountLabel.TabIndex = 14;
            this.DontHaveAnAccountLabel.TabStop = true;
            this.DontHaveAnAccountLabel.Text = "Dont have an account?";
            this.DontHaveAnAccountLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DontHaveAnAccountLabel_LinkClicked);
            // 
            // RefreshFormButton
            // 
            this.RefreshFormButton.Location = new System.Drawing.Point(640, 395);
            this.RefreshFormButton.Name = "RefreshFormButton";
            this.RefreshFormButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshFormButton.TabIndex = 15;
            this.RefreshFormButton.Text = "Refresh";
            this.RefreshFormButton.UseVisualStyleBackColor = true;
            this.RefreshFormButton.Click += new System.EventHandler(this.RefreshFormButton_Click);
            // 
            // LoginSettingsButton
            // 
            this.LoginSettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginSettingsButton.Location = new System.Drawing.Point(605, 395);
            this.LoginSettingsButton.Name = "LoginSettingsButton";
            this.LoginSettingsButton.Size = new System.Drawing.Size(29, 23);
            this.LoginSettingsButton.TabIndex = 16;
            this.LoginSettingsButton.UseVisualStyleBackColor = true;
            this.LoginSettingsButton.Click += new System.EventHandler(this.LoginSettingsButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(731, 436);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::LOGIN.Properties.Resources.starter1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(727, 430);
            this.Controls.Add(this.LoginSettingsButton);
            this.Controls.Add(this.RefreshFormButton);
            this.Controls.Add(this.DontHaveAnAccountLabel);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.LoggingInLabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.HidePassword);
            this.Controls.Add(this.ShowPassword);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UsernameTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(10, 10);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fantasy4You";
            this.TransparencyKey = System.Drawing.Color.LimeGreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button LoginButton;
        private Label label1;
        private Label label2;
        private TextBox UsernameTextbox;
        private Label label3;
        private Label label4;
        private TextBox PasswordTextbox;
        private Button ShowPassword;
        private Button HidePassword;
        private Label LoggingInLabel;
        private CheckBox checkBox1;
        private LinkLabel DontHaveAnAccountLabel;
        private Button RefreshFormButton;
        private Button LoginSettingsButton;
        private PictureBox pictureBox1;
    }
}