namespace LOGINSETTINGS
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
            this.ClearCacheButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClearCacheButton
            // 
            this.ClearCacheButton.Location = new System.Drawing.Point(12, 12);
            this.ClearCacheButton.Name = "ClearCacheButton";
            this.ClearCacheButton.Size = new System.Drawing.Size(125, 40);
            this.ClearCacheButton.TabIndex = 0;
            this.ClearCacheButton.Text = "Clear Cache";
            this.ClearCacheButton.UseVisualStyleBackColor = true;
            this.ClearCacheButton.Click += new System.EventHandler(this.ClearCacheButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "(The App will restart!)";
            // 
            // LoginSettings
            // 
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 178);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClearCacheButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginSettings";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ClearCacheButton;
        private Label label1;
    }
}