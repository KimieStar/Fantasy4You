using FANTASY4YOU;
namespace FANTASY4YOU
{
    partial class LoginSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginSettings));
            this.ClearCacheButton = new System.Windows.Forms.Button();
            this.RestartLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClearCacheButton
            // 
            this.ClearCacheButton.Location = new System.Drawing.Point(11, 19);
            this.ClearCacheButton.Name = "ClearCacheButton";
            this.ClearCacheButton.Size = new System.Drawing.Size(125, 40);
            this.ClearCacheButton.TabIndex = 0;
            this.ClearCacheButton.Text = "Clear Cache";
            this.ClearCacheButton.UseVisualStyleBackColor = true;
            this.ClearCacheButton.Click += new System.EventHandler(this.ClearCacheButton_Click);
            // 
            // RestartLabel
            // 
            this.RestartLabel.AutoSize = true;
            this.RestartLabel.BackColor = System.Drawing.Color.Transparent;
            this.RestartLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RestartLabel.Location = new System.Drawing.Point(13, 69);
            this.RestartLabel.Name = "RestartLabel";
            this.RestartLabel.Size = new System.Drawing.Size(119, 15);
            this.RestartLabel.TabIndex = 1;
            this.RestartLabel.Text = "(The App will restart!)";
            // 
            // LoginSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(261, 113);
            this.Controls.Add(this.RestartLabel);
            this.Controls.Add(this.ClearCacheButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginSettings";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fantasy4You";
            this.Load += new System.EventHandler(this.LoginSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ClearCacheButton;
        private Label RestartLabel;
    }
}