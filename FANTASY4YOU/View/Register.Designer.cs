using FANTASY4YOU;
namespace FANTASY4YOU
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.label1 = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RememberMeCheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ShowPasswordButton = new System.Windows.Forms.Button();
            this.HidePasswordButton = new System.Windows.Forms.Button();
            this.RegisterPanel = new System.Windows.Forms.Panel();
            this.RegisterButton = new ePOSOne.btnProduct.Button_WOC();
            this.WindowTopBar = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.MinimizeForm = new FontAwesome.Sharp.IconButton();
            this.CloseFormButton = new FontAwesome.Sharp.IconButton();
            this.HelperPanel = new System.Windows.Forms.Panel();
            this.RegisterPanel.SuspendLayout();
            this.WindowTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Old London", 44.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(123, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(193, 210);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(211, 23);
            this.UsernameTextBox.TabIndex = 1;
            this.UsernameTextBox.TabStop = false;
            this.UsernameTextBox.TextChanged += new System.EventHandler(this.UsernameTextBox_TextChanged);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(193, 252);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(211, 23);
            this.PasswordTextBox.TabIndex = 2;
            this.PasswordTextBox.TabStop = false;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(193, 299);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(211, 23);
            this.EmailTextBox.TabIndex = 3;
            this.EmailTextBox.TabStop = false;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Old London", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Location = new System.Drawing.Point(32, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Old London", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Location = new System.Drawing.Point(34, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Old London", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label4.Location = new System.Drawing.Point(13, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email (optional) :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RememberMeCheckBox
            // 
            this.RememberMeCheckBox.AutoSize = true;
            this.RememberMeCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.RememberMeCheckBox.Font = new System.Drawing.Font("Old London", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RememberMeCheckBox.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.RememberMeCheckBox.Location = new System.Drawing.Point(44, 373);
            this.RememberMeCheckBox.Name = "RememberMeCheckBox";
            this.RememberMeCheckBox.Size = new System.Drawing.Size(131, 27);
            this.RememberMeCheckBox.TabIndex = 8;
            this.RememberMeCheckBox.Text = "Rememebr me";
            this.RememberMeCheckBox.UseVisualStyleBackColor = false;
            this.RememberMeCheckBox.CheckedChanged += new System.EventHandler(this.RememberMeCheckBox_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Old London", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label5.Location = new System.Drawing.Point(94, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(296, 45);
            this.label5.TabIndex = 9;
            this.label5.Text = "Join up on the fun!";
            // 
            // ShowPasswordButton
            // 
            this.ShowPasswordButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ShowPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowPasswordButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ShowPasswordButton.ForeColor = System.Drawing.Color.PeachPuff;
            this.ShowPasswordButton.Location = new System.Drawing.Point(410, 252);
            this.ShowPasswordButton.Name = "ShowPasswordButton";
            this.ShowPasswordButton.Size = new System.Drawing.Size(27, 23);
            this.ShowPasswordButton.TabIndex = 10;
            this.ShowPasswordButton.Text = "X";
            this.ShowPasswordButton.UseVisualStyleBackColor = false;
            this.ShowPasswordButton.Click += new System.EventHandler(this.ShowPasswordButton_Click);
            // 
            // HidePasswordButton
            // 
            this.HidePasswordButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.HidePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HidePasswordButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HidePasswordButton.ForeColor = System.Drawing.Color.PeachPuff;
            this.HidePasswordButton.Location = new System.Drawing.Point(410, 252);
            this.HidePasswordButton.Name = "HidePasswordButton";
            this.HidePasswordButton.Size = new System.Drawing.Size(27, 23);
            this.HidePasswordButton.TabIndex = 11;
            this.HidePasswordButton.Text = "X";
            this.HidePasswordButton.UseVisualStyleBackColor = false;
            this.HidePasswordButton.Visible = false;
            this.HidePasswordButton.Click += new System.EventHandler(this.HidePasswordButton_Click);
            // 
            // RegisterPanel
            // 
            this.RegisterPanel.BackColor = System.Drawing.Color.Transparent;
            this.RegisterPanel.Controls.Add(this.RegisterButton);
            this.RegisterPanel.Controls.Add(this.EmailTextBox);
            this.RegisterPanel.Controls.Add(this.PasswordTextBox);
            this.RegisterPanel.Controls.Add(this.UsernameTextBox);
            this.RegisterPanel.Controls.Add(this.label1);
            this.RegisterPanel.Controls.Add(this.HidePasswordButton);
            this.RegisterPanel.Controls.Add(this.ShowPasswordButton);
            this.RegisterPanel.Controls.Add(this.label5);
            this.RegisterPanel.Controls.Add(this.RememberMeCheckBox);
            this.RegisterPanel.Controls.Add(this.label2);
            this.RegisterPanel.Controls.Add(this.label3);
            this.RegisterPanel.Controls.Add(this.label4);
            this.RegisterPanel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.RegisterPanel.Location = new System.Drawing.Point(-1, 43);
            this.RegisterPanel.Name = "RegisterPanel";
            this.RegisterPanel.Size = new System.Drawing.Size(485, 487);
            this.RegisterPanel.TabIndex = 12;
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.Transparent;
            this.RegisterButton.BorderColor = System.Drawing.Color.Transparent;
            this.RegisterButton.ButtonColor = System.Drawing.Color.DarkGoldenrod;
            this.RegisterButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RegisterButton.FlatAppearance.BorderSize = 0;
            this.RegisterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RegisterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterButton.Font = new System.Drawing.Font("Old London", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegisterButton.Location = new System.Drawing.Point(181, 365);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.OnHoverBackColor = System.Drawing.Color.Transparent;
            this.RegisterButton.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.RegisterButton.OnHoverButtonColor = System.Drawing.Color.DarkGoldenrod;
            this.RegisterButton.OnHoverTextColor = System.Drawing.Color.SandyBrown;
            this.RegisterButton.Size = new System.Drawing.Size(221, 56);
            this.RegisterButton.TabIndex = 19;
            this.RegisterButton.TabStop = false;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.TextColor = System.Drawing.Color.White;
            this.RegisterButton.UseVisualStyleBackColor = false;
            // 
            // WindowTopBar
            // 
            this.WindowTopBar.BackColor = System.Drawing.Color.IndianRed;
            this.WindowTopBar.Controls.Add(this.HelperPanel);
            this.WindowTopBar.Controls.Add(this.iconButton2);
            this.WindowTopBar.Controls.Add(this.MinimizeForm);
            this.WindowTopBar.Controls.Add(this.CloseFormButton);
            this.WindowTopBar.Location = new System.Drawing.Point(-1, 0);
            this.WindowTopBar.Name = "WindowTopBar";
            this.WindowTopBar.Size = new System.Drawing.Size(485, 43);
            this.WindowTopBar.TabIndex = 21;
            this.WindowTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowTopBar_MouseDown);
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton2.BackColor = System.Drawing.Color.Transparent;
            this.iconButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.iconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconButton2.IconColor = System.Drawing.Color.Snow;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 69;
            this.iconButton2.Location = new System.Drawing.Point(429, -6);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(61, 65);
            this.iconButton2.TabIndex = 2;
            this.iconButton2.TabStop = false;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // MinimizeForm
            // 
            this.MinimizeForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeForm.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MinimizeForm.FlatAppearance.BorderSize = 0;
            this.MinimizeForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.MinimizeForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.MinimizeForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeForm.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.MinimizeForm.IconColor = System.Drawing.Color.Snow;
            this.MinimizeForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MinimizeForm.IconSize = 26;
            this.MinimizeForm.Location = new System.Drawing.Point(701, 0);
            this.MinimizeForm.Name = "MinimizeForm";
            this.MinimizeForm.Size = new System.Drawing.Size(315, 18);
            this.MinimizeForm.TabIndex = 0;
            this.MinimizeForm.TabStop = false;
            this.MinimizeForm.UseVisualStyleBackColor = false;
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
            this.CloseFormButton.Location = new System.Drawing.Point(730, -1);
            this.CloseFormButton.Name = "CloseFormButton";
            this.CloseFormButton.Size = new System.Drawing.Size(315, 18);
            this.CloseFormButton.TabIndex = 0;
            this.CloseFormButton.TabStop = false;
            this.CloseFormButton.UseVisualStyleBackColor = false;
            // 
            // HelperPanel
            // 
            this.HelperPanel.Location = new System.Drawing.Point(391, -6);
            this.HelperPanel.Name = "HelperPanel";
            this.HelperPanel.Size = new System.Drawing.Size(44, 65);
            this.HelperPanel.TabIndex = 3;
            this.HelperPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HelperPanel_MouseDown);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(482, 529);
            this.Controls.Add(this.WindowTopBar);
            this.Controls.Add(this.RegisterPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fantasy4You";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.RegisterPanel.ResumeLayout(false);
            this.RegisterPanel.PerformLayout();
            this.WindowTopBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private TextBox UsernameTextBox;
        private TextBox PasswordTextBox;
        private TextBox EmailTextBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox RememberMeCheckBox;
        private Label label5;
        private Button ShowPasswordButton;
        private Button HidePasswordButton;
        private Panel RegisterPanel;
        private Panel WindowTopBar;
        private FontAwesome.Sharp.IconButton MinimizeForm;
        private FontAwesome.Sharp.IconButton CloseFormButton;
        private FontAwesome.Sharp.IconButton iconButton2;
        private ePOSOne.btnProduct.Button_WOC RegisterButton;
        private Panel HelperPanel;
    }
}