namespace FANTASY4YOU
{
    partial class RecoveryPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecoveryPassword));
            this.ChangePasswordLabel = new System.Windows.Forms.Label();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPassword = new System.Windows.Forms.Label();
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
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(228, 122);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(139, 23);
            this.confirmPasswordTextBox.TabIndex = 10;
            this.confirmPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.AutoSize = true;
            this.ConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.ConfirmPassword.Font = new System.Drawing.Font("Old London", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConfirmPassword.ForeColor = System.Drawing.Color.BurlyWood;
            this.ConfirmPassword.Location = new System.Drawing.Point(31, 114);
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.Size = new System.Drawing.Size(195, 31);
            this.ConfirmPassword.TabIndex = 9;
            this.ConfirmPassword.Text = "ConfirmPassword:";
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
            // RecoveryPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(452, 217);
            this.Controls.Add(this.confirmPasswordTextBox);
            this.Controls.Add(this.ChangePasswordButton);
            this.Controls.Add(this.newPasswordTextBox);
            this.Controls.Add(this.ConfirmPassword);
            this.Controls.Add(this.NewPasswordLabel);
            this.Controls.Add(this.ChangePasswordLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RecoveryPassword";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fantasy4You";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ChangePasswordLabel;
        private TextBox confirmPasswordTextBox;
        private Label ConfirmPassword;
        private TextBox newPasswordTextBox;
        private Label NewPasswordLabel;
        private ePOSOne.btnProduct.Button_WOC ChangePasswordButton;
    }
}