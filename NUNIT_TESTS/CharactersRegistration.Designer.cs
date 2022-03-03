//using FANTASY4YOU;
//namespace FANTASY4YOU
//{
//    partial class CharacterRegistration
//    {
//        /// <summary>
//        ///  Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;
//
//        /// <summary>
//        ///  Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }
//
//        #region Windows Form Designer generated code
//
//        /// <summary>
//        ///  Required method for Designer support - do not modify
//        ///  the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.characterNameTextBox = new System.Windows.Forms.TextBox();
//            this.classComboBox = new System.Windows.Forms.ComboBox();
//            this.levelBox = new System.Windows.Forms.TextBox();
//            this.label1 = new System.Windows.Forms.Label();
//            this.label2 = new System.Windows.Forms.Label();
//            this.label3 = new System.Windows.Forms.Label();
//            this.raceComboBox = new System.Windows.Forms.ComboBox();
//            this.label4 = new System.Windows.Forms.Label();
//            this.backgroundTextBox = new System.Windows.Forms.TextBox();
//            this.label5 = new System.Windows.Forms.Label();
//            this.xpTextBox = new System.Windows.Forms.TextBox();
//            this.label6 = new System.Windows.Forms.Label();
//            this.label7 = new System.Windows.Forms.Label();
//            this.alignmentComboBox = new System.Windows.Forms.ComboBox();
//            this.button1 = new System.Windows.Forms.Button();
//            this.SuspendLayout();
//            // 
//            // characterNameTextBox
//            // 
//            this.characterNameTextBox.Location = new System.Drawing.Point(478, 123);
//            this.characterNameTextBox.Name = "characterNameTextBox";
//            this.characterNameTextBox.Size = new System.Drawing.Size(100, 23);
//            this.characterNameTextBox.TabIndex = 0;
//            this.characterNameTextBox.TextChanged += new System.EventHandler(this.characterNameTextBox_TextChanged);
//            // 
//            // classComboBox
//            // 
//            this.classComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
//            this.classComboBox.FormattingEnabled = true;
//            this.classComboBox.Items.AddRange(new object[] {
//            "Class1",
//            "Class2",
//            "Class3"});
//            this.classComboBox.Location = new System.Drawing.Point(478, 171);
//            this.classComboBox.Name = "classComboBox";
//            this.classComboBox.Size = new System.Drawing.Size(121, 23);
//            this.classComboBox.TabIndex = 1;
//            this.classComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
//            // 
//            // levelBox
//            // 
//            this.levelBox.Location = new System.Drawing.Point(478, 210);
//            this.levelBox.Name = "levelBox";
//            this.levelBox.Size = new System.Drawing.Size(100, 23);
//            this.levelBox.TabIndex = 2;
//            // 
//            // label1
//            // 
//            this.label1.AutoSize = true;
//            this.label1.Location = new System.Drawing.Point(379, 126);
//            this.label1.Name = "label1";
//            this.label1.Size = new System.Drawing.Size(93, 15);
//            this.label1.TabIndex = 3;
//            this.label1.Text = "Character Name";
//            // 
//            // label2
//            // 
//            this.label2.AutoSize = true;
//            this.label2.Location = new System.Drawing.Point(438, 174);
//            this.label2.Name = "label2";
//            this.label2.Size = new System.Drawing.Size(34, 15);
//            this.label2.TabIndex = 4;
//            this.label2.Text = "Class";
//            // 
//            // label3
//            // 
//            this.label3.AutoSize = true;
//            this.label3.Location = new System.Drawing.Point(438, 218);
//            this.label3.Name = "label3";
//            this.label3.Size = new System.Drawing.Size(34, 15);
//            this.label3.TabIndex = 5;
//            this.label3.Text = "Level";
//            // 
//            // raceComboBox
//            // 
//            this.raceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
//            this.raceComboBox.FormattingEnabled = true;
//            this.raceComboBox.Items.AddRange(new object[] {
//            "Race1",
//            "Race2",
//            "Race3"});
//            this.raceComboBox.Location = new System.Drawing.Point(478, 257);
//            this.raceComboBox.Name = "raceComboBox";
//            this.raceComboBox.Size = new System.Drawing.Size(121, 23);
//            this.raceComboBox.TabIndex = 6;
//            // 
//            // label4
//            // 
//            this.label4.AutoSize = true;
//            this.label4.Location = new System.Drawing.Point(438, 260);
//            this.label4.Name = "label4";
//            this.label4.Size = new System.Drawing.Size(32, 15);
//            this.label4.TabIndex = 7;
//            this.label4.Text = "Race";
//            // 
//            // backgroundTextBox
//            // 
//            this.backgroundTextBox.Location = new System.Drawing.Point(478, 404);
//            this.backgroundTextBox.Multiline = true;
//            this.backgroundTextBox.Name = "backgroundTextBox";
//            this.backgroundTextBox.Size = new System.Drawing.Size(263, 94);
//            this.backgroundTextBox.TabIndex = 8;
//            // 
//            // label5
//            // 
//            this.label5.AutoSize = true;
//            this.label5.Location = new System.Drawing.Point(401, 407);
//            this.label5.Name = "label5";
//            this.label5.Size = new System.Drawing.Size(71, 15);
//            this.label5.TabIndex = 9;
//            this.label5.Text = "Background";
//            // 
//            // xpTextBox
//            // 
//            this.xpTextBox.Location = new System.Drawing.Point(478, 297);
//            this.xpTextBox.Name = "xpTextBox";
//            this.xpTextBox.Size = new System.Drawing.Size(100, 23);
//            this.xpTextBox.TabIndex = 10;
//            // 
//            // label6
//            // 
//            this.label6.AutoSize = true;
//            this.label6.Location = new System.Drawing.Point(415, 300);
//            this.label6.Name = "label6";
//            this.label6.Size = new System.Drawing.Size(57, 15);
//            this.label6.TabIndex = 11;
//            this.label6.Text = "XP Points";
//            // 
//            // label7
//            // 
//            this.label7.AutoSize = true;
//            this.label7.Location = new System.Drawing.Point(407, 356);
//            this.label7.Name = "label7";
//            this.label7.Size = new System.Drawing.Size(63, 15);
//            this.label7.TabIndex = 13;
//            this.label7.Text = "Alignment";
//            this.label7.Click += new System.EventHandler(this.label7_Click);
//            // 
//            // alignmentComboBox
//            // 
//            this.alignmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
//            this.alignmentComboBox.FormattingEnabled = true;
//            this.alignmentComboBox.Items.AddRange(new object[] {
//            "Alignment 1",
//            "Alignment 2",
//            "Alignment 3"});
//            this.alignmentComboBox.Location = new System.Drawing.Point(478, 353);
//            this.alignmentComboBox.Name = "alignmentComboBox";
//            this.alignmentComboBox.Size = new System.Drawing.Size(121, 23);
//            this.alignmentComboBox.TabIndex = 14;
//            // 
//            // button1
//            // 
//            this.button1.Location = new System.Drawing.Point(478, 522);
//            this.button1.Name = "button1";
//            this.button1.Size = new System.Drawing.Size(121, 53);
//            this.button1.TabIndex = 15;
//            this.button1.Text = "Create";
//            this.button1.UseVisualStyleBackColor = true;
//            this.button1.Click += new System.EventHandler(this.button1_Click);
//            // 
//            // CharacterRegistration
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(1108, 701);
//            this.Controls.Add(this.button1);
//            this.Controls.Add(this.alignmentComboBox);
//            this.Controls.Add(this.label7);
//            this.Controls.Add(this.label6);
//            this.Controls.Add(this.xpTextBox);
//            this.Controls.Add(this.label5);
//            this.Controls.Add(this.backgroundTextBox);
//            this.Controls.Add(this.label4);
//            this.Controls.Add(this.raceComboBox);
//            this.Controls.Add(this.label3);
//            this.Controls.Add(this.label2);
//            this.Controls.Add(this.label1);
//            this.Controls.Add(this.levelBox);
//            this.Controls.Add(this.classComboBox);
//            this.Controls.Add(this.characterNameTextBox);
//            this.Name = "CharacterRegistration";
//            this.Text = "CharactersRegistration";
//            this.Load += new System.EventHandler(this.CharactersRegistration_Load);
//            this.ResumeLayout(false);
//            this.PerformLayout();
//
//        }
//
//        #endregion
//
//        private TextBox characterNameTextBox;
//        private ComboBox classComboBox;
//        private TextBox levelBox;
//        private Label label1;
//        private Label label2;
//        private Label label3;
//        private ComboBox raceComboBox;
//        private Label label4;
//        private TextBox backgroundTextBox;
//        private Label label5;
//        private TextBox xpTextBox;
//        private Label label6;
//        private Label label7;
//        private ComboBox alignmentComboBox;
//        private Button button1;
//    }
//}