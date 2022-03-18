namespace FANTASY4YOU
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.ChangePasswordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.CurrentPasswordLabel = new System.Windows.Forms.Label();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.NewPasswordLabel = new System.Windows.Forms.Label();
            this.ChangePasswordButton = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // ChangePasswordLabel
            // 
            this.ChangePasswordLabel.AutoSize = true;
            this.ChangePasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.ChangePasswordLabel.Font = new System.Drawing.Font("Old London", 30.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangePasswordLabel.ForeColor = System.Drawing.Color.BurlyWood;
            this.ChangePasswordLabel.Location = new System.Drawing.Point(83, 9);
            this.ChangePasswordLabel.Name = "ChangePasswordLabel";
            this.ChangePasswordLabel.Size = new System.Drawing.Size(286, 47);
            this.ChangePasswordLabel.TabIndex = 0;
            this.ChangePasswordLabel.Text = "Change Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(228, 122);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(139, 23);
            this.passwordTextBox.TabIndex = 10;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // CurrentPasswordLabel
            // 
            this.CurrentPasswordLabel.AutoSize = true;
            this.CurrentPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.CurrentPasswordLabel.Font = new System.Drawing.Font("Old London", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CurrentPasswordLabel.ForeColor = System.Drawing.Color.BurlyWood;
            this.CurrentPasswordLabel.Location = new System.Drawing.Point(31, 114);
            this.CurrentPasswordLabel.Name = "CurrentPasswordLabel";
            this.CurrentPasswordLabel.Size = new System.Drawing.Size(199, 31);
            this.CurrentPasswordLabel.TabIndex = 9;
            this.CurrentPasswordLabel.Text = "Current Password:";
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Location = new System.Drawing.Point(228, 73);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Size = new System.Drawing.Size(139, 23);
            this.newPasswordTextBox.TabIndex = 8;
            this.newPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // NewPasswordLabel
            // 
            this.NewPasswordLabel.AutoSize = true;
            this.NewPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.NewPasswordLabel.Font = new System.Drawing.Font("Old London", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewPasswordLabel.ForeColor = System.Drawing.Color.BurlyWood;
            this.NewPasswordLabel.Location = new System.Drawing.Point(51, 65);
            this.NewPasswordLabel.Name = "NewPasswordLabel";
            this.NewPasswordLabel.Size = new System.Drawing.Size(179, 31);
            this.NewPasswordLabel.TabIndex = 7;
            this.NewPasswordLabel.Text = "New Password :";
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.BackColor = System.Drawing.Color.Transparent;
            this.ChangePasswordButton.BorderColor = System.Drawing.Color.Transparent;
            this.ChangePasswordButton.ButtonColor = System.Drawing.Color.BurlyWood;
            this.ChangePasswordButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ChangePasswordButton.FlatAppearance.BorderSize = 0;
            this.ChangePasswordButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ChangePasswordButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ChangePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePasswordButton.Font = new System.Drawing.Font("Old London", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangePasswordButton.Location = new System.Drawing.Point(174, 151);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.OnHoverBackColor = System.Drawing.Color.Transparent;
            this.ChangePasswordButton.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.ChangePasswordButton.OnHoverButtonColor = System.Drawing.Color.BurlyWood;
            this.ChangePasswordButton.OnHoverTextColor = System.Drawing.Color.SandyBrown;
            this.ChangePasswordButton.Size = new System.Drawing.Size(221, 56);
            this.ChangePasswordButton.TabIndex = 20;
            this.ChangePasswordButton.TabStop = false;
            this.ChangePasswordButton.Text = "Change";
            this.ChangePasswordButton.TextColor = System.Drawing.Color.White;
            this.ChangePasswordButton.UseVisualStyleBackColor = false;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(452, 217);
            this.Controls.Add(this.ChangePasswordButton);
            this.Controls.Add(this.newPasswordTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.CurrentPasswordLabel);
            this.Controls.Add(this.NewPasswordLabel);
            this.Controls.Add(this.ChangePasswordLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fantasy4You";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ChangePasswordLabel;
        private TextBox passwordTextBox;
        private Label CurrentPasswordLabel;
        private TextBox newPasswordTextBox;
        private Label NewPasswordLabel;
        private ePOSOne.btnProduct.Button_WOC ChangePasswordButton;
    }
}