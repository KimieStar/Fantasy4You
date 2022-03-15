using FANTASY4YOU;
namespace FANTASY4YOU
{
    partial class WelcomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeScreen));
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.GladLabel = new System.Windows.Forms.Label();
            this.WelcomePannel = new System.Windows.Forms.Panel();
            this.WindowTopBar = new System.Windows.Forms.Panel();
            this.CloseFormButton = new FontAwesome.Sharp.IconButton();
            this.HelperPanel = new System.Windows.Forms.Panel();
            this.WelcomePannel.SuspendLayout();
            this.WindowTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Font = new System.Drawing.Font("Old London", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.welcomeLabel.ForeColor = System.Drawing.Color.Brown;
            this.welcomeLabel.Location = new System.Drawing.Point(122, 16);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(533, 91);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome aboard!";
            this.welcomeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Old London", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.ForeColor = System.Drawing.Color.Chocolate;
            this.nameLabel.Location = new System.Drawing.Point(333, 136);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(225, 60);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "placeholder";
            this.nameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // GladLabel
            // 
            this.GladLabel.AutoSize = true;
            this.GladLabel.Font = new System.Drawing.Font("Old London", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GladLabel.ForeColor = System.Drawing.Color.Brown;
            this.GladLabel.Location = new System.Drawing.Point(70, 238);
            this.GladLabel.Name = "GladLabel";
            this.GladLabel.Size = new System.Drawing.Size(674, 91);
            this.GladLabel.TabIndex = 2;
            this.GladLabel.Text = "Glad to have you here!";
            // 
            // WelcomePannel
            // 
            this.WelcomePannel.BackColor = System.Drawing.Color.Transparent;
            this.WelcomePannel.Controls.Add(this.welcomeLabel);
            this.WelcomePannel.Controls.Add(this.nameLabel);
            this.WelcomePannel.Controls.Add(this.GladLabel);
            this.WelcomePannel.Location = new System.Drawing.Point(0, 33);
            this.WelcomePannel.Name = "WelcomePannel";
            this.WelcomePannel.Size = new System.Drawing.Size(802, 418);
            this.WelcomePannel.TabIndex = 3;
            // 
            // WindowTopBar
            // 
            this.WindowTopBar.BackColor = System.Drawing.Color.IndianRed;
            this.WindowTopBar.Controls.Add(this.HelperPanel);
            this.WindowTopBar.Controls.Add(this.CloseFormButton);
            this.WindowTopBar.Location = new System.Drawing.Point(0, 0);
            this.WindowTopBar.Name = "WindowTopBar";
            this.WindowTopBar.Size = new System.Drawing.Size(802, 33);
            this.WindowTopBar.TabIndex = 21;
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
            this.CloseFormButton.IconSize = 52;
            this.CloseFormButton.Location = new System.Drawing.Point(761, -1);
            this.CloseFormButton.Name = "CloseFormButton";
            this.CloseFormButton.Size = new System.Drawing.Size(43, 43);
            this.CloseFormButton.TabIndex = 21;
            this.CloseFormButton.TabStop = false;
            this.CloseFormButton.UseVisualStyleBackColor = false;
            this.CloseFormButton.Click += new System.EventHandler(this.CloseFormButton_Click);
            // 
            // HelperPanel
            // 
            this.HelperPanel.Location = new System.Drawing.Point(724, -5);
            this.HelperPanel.Name = "HelperPanel";
            this.HelperPanel.Size = new System.Drawing.Size(39, 43);
            this.HelperPanel.TabIndex = 22;
            this.HelperPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HelperPanel_MouseDown);
            // 
            // WelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WelcomePannel);
            this.Controls.Add(this.WindowTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WelcomeScreen";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WelcomeScreen_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.WelcomePannel.ResumeLayout(false);
            this.WelcomePannel.PerformLayout();
            this.WindowTopBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label welcomeLabel;
        private Label nameLabel;
        private Label GladLabel;
        private Panel WelcomePannel;
        private Panel WindowTopBar;
        private FontAwesome.Sharp.IconButton CloseFormButton;
        private Panel HelperPanel;
    }
}