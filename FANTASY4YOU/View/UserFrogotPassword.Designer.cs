using FANTASY4YOU;
namespace FANTASY4YOU
{
    partial class UserFrogotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserFrogotPassword));
            this.EnterYourEmailLabel = new System.Windows.Forms.Label();
            this.enterEmailTextBox = new System.Windows.Forms.TextBox();
            this.SendCodeButton = new System.Windows.Forms.Button();
            this.VerifyCodeButton = new System.Windows.Forms.Button();
            this.RecoveryCodeTextBox = new System.Windows.Forms.TextBox();
            this.RecoveryCodeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EnterYourEmailLabel
            // 
            this.EnterYourEmailLabel.AutoSize = true;
            this.EnterYourEmailLabel.BackColor = System.Drawing.Color.Transparent;
            this.EnterYourEmailLabel.Font = new System.Drawing.Font("Old London", 30.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnterYourEmailLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.EnterYourEmailLabel.Location = new System.Drawing.Point(72, 34);
            this.EnterYourEmailLabel.Name = "EnterYourEmailLabel";
            this.EnterYourEmailLabel.Size = new System.Drawing.Size(296, 47);
            this.EnterYourEmailLabel.TabIndex = 0;
            this.EnterYourEmailLabel.Text = "Enter your Email :";
            // 
            // enterEmailTextBox
            // 
            this.enterEmailTextBox.Location = new System.Drawing.Point(370, 50);
            this.enterEmailTextBox.Name = "enterEmailTextBox";
            this.enterEmailTextBox.Size = new System.Drawing.Size(172, 23);
            this.enterEmailTextBox.TabIndex = 1;
            // 
            // SendCodeButton
            // 
            this.SendCodeButton.Location = new System.Drawing.Point(548, 49);
            this.SendCodeButton.Name = "SendCodeButton";
            this.SendCodeButton.Size = new System.Drawing.Size(75, 23);
            this.SendCodeButton.TabIndex = 2;
            this.SendCodeButton.Text = "SendCode";
            this.SendCodeButton.UseVisualStyleBackColor = true;
            this.SendCodeButton.Click += new System.EventHandler(this.SendCodeButton_Click);
            // 
            // VerifyCodeButton
            // 
            this.VerifyCodeButton.Enabled = false;
            this.VerifyCodeButton.Location = new System.Drawing.Point(545, 128);
            this.VerifyCodeButton.Name = "VerifyCodeButton";
            this.VerifyCodeButton.Size = new System.Drawing.Size(75, 23);
            this.VerifyCodeButton.TabIndex = 5;
            this.VerifyCodeButton.Text = "Verify";
            this.VerifyCodeButton.UseVisualStyleBackColor = true;
            this.VerifyCodeButton.Click += new System.EventHandler(this.VerifyCodeButton_Click);
            // 
            // RecoveryCodeTextBox
            // 
            this.RecoveryCodeTextBox.Enabled = false;
            this.RecoveryCodeTextBox.Location = new System.Drawing.Point(367, 128);
            this.RecoveryCodeTextBox.Name = "RecoveryCodeTextBox";
            this.RecoveryCodeTextBox.Size = new System.Drawing.Size(172, 23);
            this.RecoveryCodeTextBox.TabIndex = 4;
            // 
            // RecoveryCodeLabel
            // 
            this.RecoveryCodeLabel.AutoSize = true;
            this.RecoveryCodeLabel.BackColor = System.Drawing.Color.Transparent;
            this.RecoveryCodeLabel.Font = new System.Drawing.Font("Old London", 30.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RecoveryCodeLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.RecoveryCodeLabel.Location = new System.Drawing.Point(131, 112);
            this.RecoveryCodeLabel.Name = "RecoveryCodeLabel";
            this.RecoveryCodeLabel.Size = new System.Drawing.Size(237, 47);
            this.RecoveryCodeLabel.TabIndex = 3;
            this.RecoveryCodeLabel.Text = "Recovery Code:";
            // 
            // UserFrogotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(717, 217);
            this.Controls.Add(this.VerifyCodeButton);
            this.Controls.Add(this.RecoveryCodeTextBox);
            this.Controls.Add(this.RecoveryCodeLabel);
            this.Controls.Add(this.SendCodeButton);
            this.Controls.Add(this.enterEmailTextBox);
            this.Controls.Add(this.EnterYourEmailLabel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserFrogotPassword";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fantasy4You";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label EnterYourEmailLabel;
        private TextBox enterEmailTextBox;
        private Button SendCodeButton;
        private Button VerifyCodeButton;
        private TextBox RecoveryCodeTextBox;
        private Label RecoveryCodeLabel;
    }
}