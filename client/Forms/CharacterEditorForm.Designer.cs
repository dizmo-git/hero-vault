namespace client
{
    partial class CharacterEditorForm
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
            nameInput = new TextBox();
            statsGroup = new GroupBox();
            ConstitutionUp = new Button();
            label2 = new Label();
            DexterityUp = new Button();
            labelPoints = new Label();
            StrengthUp = new Button();
            label3 = new Label();
            CharismaUp = new Button();
            label4 = new Label();
            WisdomUp = new Button();
            label5 = new Label();
            InteligenceUp = new Button();
            label6 = new Label();
            labelCharisma = new Label();
            label7 = new Label();
            labelWisdom = new Label();
            label8 = new Label();
            labelInteligence = new Label();
            labelStrength = new Label();
            labelConstitution = new Label();
            labelDexterity = new Label();
            inventoryListBox = new ListBox();
            raceLabel = new Label();
            classLabel = new Label();
            lvlLabel = new Label();
            healthLabel = new TextBox();
            btnSave = new Button();
            btnLevelUp = new Button();
            label1 = new Label();
            statsGroup.SuspendLayout();
            SuspendLayout();
            // 
            // nameInput
            // 
            nameInput.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            nameInput.Location = new Point(166, 11);
            nameInput.Margin = new Padding(3, 2, 3, 2);
            nameInput.Name = "nameInput";
            nameInput.PlaceholderText = "Name";
            nameInput.Size = new Size(185, 39);
            nameInput.TabIndex = 1;
            nameInput.TextAlign = HorizontalAlignment.Center;
            nameInput.TextChanged += nameInput_TextChanged;
            // 
            // statsGroup
            // 
            statsGroup.Controls.Add(ConstitutionUp);
            statsGroup.Controls.Add(label2);
            statsGroup.Controls.Add(DexterityUp);
            statsGroup.Controls.Add(labelPoints);
            statsGroup.Controls.Add(StrengthUp);
            statsGroup.Controls.Add(label3);
            statsGroup.Controls.Add(CharismaUp);
            statsGroup.Controls.Add(label4);
            statsGroup.Controls.Add(WisdomUp);
            statsGroup.Controls.Add(label5);
            statsGroup.Controls.Add(InteligenceUp);
            statsGroup.Controls.Add(label6);
            statsGroup.Controls.Add(labelCharisma);
            statsGroup.Controls.Add(label7);
            statsGroup.Controls.Add(labelWisdom);
            statsGroup.Controls.Add(label8);
            statsGroup.Controls.Add(labelInteligence);
            statsGroup.Controls.Add(labelStrength);
            statsGroup.Controls.Add(labelConstitution);
            statsGroup.Controls.Add(labelDexterity);
            statsGroup.Location = new Point(167, 56);
            statsGroup.Margin = new Padding(3, 2, 3, 2);
            statsGroup.Name = "statsGroup";
            statsGroup.Padding = new Padding(3, 2, 3, 2);
            statsGroup.Size = new Size(365, 101);
            statsGroup.TabIndex = 5;
            statsGroup.TabStop = false;
            statsGroup.Text = "Stats";
            // 
            // ConstitutionUp
            // 
            ConstitutionUp.Anchor = AnchorStyles.None;
            ConstitutionUp.AutoSize = true;
            ConstitutionUp.Enabled = false;
            ConstitutionUp.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ConstitutionUp.Location = new Point(117, 70);
            ConstitutionUp.Name = "ConstitutionUp";
            ConstitutionUp.Size = new Size(29, 29);
            ConstitutionUp.TabIndex = 39;
            ConstitutionUp.Text = "+";
            ConstitutionUp.UseVisualStyleBackColor = true;
            ConstitutionUp.Click += StatUp_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(295, 12);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 20;
            label2.Text = "Поінти";
            // 
            // DexterityUp
            // 
            DexterityUp.Anchor = AnchorStyles.None;
            DexterityUp.AutoSize = true;
            DexterityUp.Enabled = false;
            DexterityUp.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            DexterityUp.Location = new Point(117, 44);
            DexterityUp.Name = "DexterityUp";
            DexterityUp.Size = new Size(29, 29);
            DexterityUp.TabIndex = 38;
            DexterityUp.Text = "+";
            DexterityUp.UseVisualStyleBackColor = true;
            DexterityUp.Click += StatUp_Click;
            // 
            // labelPoints
            // 
            labelPoints.AutoSize = true;
            labelPoints.Location = new Point(346, 12);
            labelPoints.Name = "labelPoints";
            labelPoints.Size = new Size(13, 15);
            labelPoints.TabIndex = 21;
            labelPoints.Text = "0";
            // 
            // StrengthUp
            // 
            StrengthUp.Anchor = AnchorStyles.None;
            StrengthUp.AutoSize = true;
            StrengthUp.Enabled = false;
            StrengthUp.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            StrengthUp.Location = new Point(117, 14);
            StrengthUp.Name = "StrengthUp";
            StrengthUp.Size = new Size(29, 29);
            StrengthUp.TabIndex = 37;
            StrengthUp.Text = "+";
            StrengthUp.UseVisualStyleBackColor = true;
            StrengthUp.Click += StatUp_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 18);
            label3.Name = "label3";
            label3.Size = new Size(88, 23);
            label3.TabIndex = 22;
            label3.Text = "Strength";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CharismaUp
            // 
            CharismaUp.Anchor = AnchorStyles.None;
            CharismaUp.AutoSize = true;
            CharismaUp.Enabled = false;
            CharismaUp.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            CharismaUp.Location = new Point(257, 70);
            CharismaUp.Name = "CharismaUp";
            CharismaUp.Size = new Size(29, 29);
            CharismaUp.TabIndex = 36;
            CharismaUp.Text = "+";
            CharismaUp.UseVisualStyleBackColor = true;
            CharismaUp.Click += StatUp_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(4, 48);
            label4.Name = "label4";
            label4.Size = new Size(85, 19);
            label4.TabIndex = 23;
            label4.Text = "Dexterity";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // WisdomUp
            // 
            WisdomUp.Anchor = AnchorStyles.None;
            WisdomUp.AutoSize = true;
            WisdomUp.Enabled = false;
            WisdomUp.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            WisdomUp.Location = new Point(257, 44);
            WisdomUp.Name = "WisdomUp";
            WisdomUp.Size = new Size(29, 29);
            WisdomUp.TabIndex = 35;
            WisdomUp.Text = "+";
            WisdomUp.UseVisualStyleBackColor = true;
            WisdomUp.Click += StatUp_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(4, 78);
            label5.Name = "label5";
            label5.Size = new Size(85, 19);
            label5.TabIndex = 24;
            label5.Text = "Constitution";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // InteligenceUp
            // 
            InteligenceUp.Anchor = AnchorStyles.None;
            InteligenceUp.AutoSize = true;
            InteligenceUp.Enabled = false;
            InteligenceUp.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            InteligenceUp.Location = new Point(257, 18);
            InteligenceUp.Name = "InteligenceUp";
            InteligenceUp.Size = new Size(29, 29);
            InteligenceUp.TabIndex = 34;
            InteligenceUp.Text = "+";
            InteligenceUp.UseVisualStyleBackColor = true;
            InteligenceUp.Click += StatUp_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(153, 20);
            label6.Name = "label6";
            label6.Size = new Size(75, 19);
            label6.TabIndex = 25;
            label6.Text = "Inteligence";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelCharisma
            // 
            labelCharisma.AutoSize = true;
            labelCharisma.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelCharisma.Location = new Point(234, 78);
            labelCharisma.Name = "labelCharisma";
            labelCharisma.Size = new Size(17, 19);
            labelCharisma.TabIndex = 33;
            labelCharisma.Text = "0";
            labelCharisma.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(153, 48);
            label7.Name = "label7";
            label7.Size = new Size(85, 19);
            label7.TabIndex = 26;
            label7.Text = "Wisdom";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelWisdom
            // 
            labelWisdom.AutoSize = true;
            labelWisdom.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelWisdom.Location = new Point(234, 48);
            labelWisdom.Name = "labelWisdom";
            labelWisdom.Size = new Size(17, 19);
            labelWisdom.TabIndex = 32;
            labelWisdom.Text = "0";
            labelWisdom.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(153, 78);
            label8.Name = "label8";
            label8.Size = new Size(85, 19);
            label8.TabIndex = 27;
            label8.Text = "Charisma";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelInteligence
            // 
            labelInteligence.AutoSize = true;
            labelInteligence.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelInteligence.Location = new Point(234, 20);
            labelInteligence.Name = "labelInteligence";
            labelInteligence.Size = new Size(17, 19);
            labelInteligence.TabIndex = 31;
            labelInteligence.Text = "0";
            labelInteligence.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelStrength
            // 
            labelStrength.AutoSize = true;
            labelStrength.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelStrength.Location = new Point(94, 18);
            labelStrength.Name = "labelStrength";
            labelStrength.Size = new Size(17, 19);
            labelStrength.TabIndex = 28;
            labelStrength.Text = "0";
            labelStrength.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelConstitution
            // 
            labelConstitution.AutoSize = true;
            labelConstitution.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelConstitution.Location = new Point(95, 78);
            labelConstitution.Name = "labelConstitution";
            labelConstitution.Size = new Size(17, 19);
            labelConstitution.TabIndex = 30;
            labelConstitution.Text = "0";
            labelConstitution.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelDexterity
            // 
            labelDexterity.AutoSize = true;
            labelDexterity.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelDexterity.Location = new Point(94, 48);
            labelDexterity.Name = "labelDexterity";
            labelDexterity.Size = new Size(17, 19);
            labelDexterity.TabIndex = 29;
            labelDexterity.Text = "0";
            labelDexterity.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // inventoryListBox
            // 
            inventoryListBox.FormattingEnabled = true;
            inventoryListBox.ItemHeight = 15;
            inventoryListBox.Location = new Point(166, 171);
            inventoryListBox.Margin = new Padding(3, 2, 3, 2);
            inventoryListBox.Name = "inventoryListBox";
            inventoryListBox.Size = new Size(365, 79);
            inventoryListBox.TabIndex = 6;
            // 
            // raceLabel
            // 
            raceLabel.AutoSize = true;
            raceLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            raceLabel.Location = new Point(12, 56);
            raceLabel.Name = "raceLabel";
            raceLabel.Size = new Size(68, 30);
            raceLabel.TabIndex = 7;
            raceLabel.Text = "label1";
            // 
            // classLabel
            // 
            classLabel.AutoSize = true;
            classLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            classLabel.Location = new Point(12, 104);
            classLabel.Name = "classLabel";
            classLabel.Size = new Size(68, 30);
            classLabel.TabIndex = 8;
            classLabel.Text = "label1";
            // 
            // lvlLabel
            // 
            lvlLabel.AutoSize = true;
            lvlLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lvlLabel.Location = new Point(73, 18);
            lvlLabel.Name = "lvlLabel";
            lvlLabel.Size = new Size(35, 30);
            lvlLabel.TabIndex = 10;
            lvlLabel.Text = "20";
            // 
            // healthLabel
            // 
            healthLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            healthLabel.Location = new Point(357, 11);
            healthLabel.Name = "healthLabel";
            healthLabel.Size = new Size(100, 35);
            healthLabel.TabIndex = 11;
            healthLabel.TextChanged += healthLabel_TextChanged;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(12, 211);
            btnSave.Name = "btnSave";
            btnSave.Padding = new Padding(0, 0, 0, 3);
            btnSave.Size = new Size(95, 38);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.TextAlign = ContentAlignment.TopCenter;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnLevelUp
            // 
            btnLevelUp.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLevelUp.Location = new Point(114, 19);
            btnLevelUp.Name = "btnLevelUp";
            btnLevelUp.Size = new Size(29, 29);
            btnLevelUp.TabIndex = 13;
            btnLevelUp.Text = "+";
            btnLevelUp.UseVisualStyleBackColor = true;
            btnLevelUp.Click += btnLevelUp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(65, 30);
            label1.TabIndex = 14;
            label1.Text = "Level:";
            // 
            // CharacterEditorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 261);
            Controls.Add(label1);
            Controls.Add(btnLevelUp);
            Controls.Add(btnSave);
            Controls.Add(healthLabel);
            Controls.Add(lvlLabel);
            Controls.Add(classLabel);
            Controls.Add(raceLabel);
            Controls.Add(inventoryListBox);
            Controls.Add(statsGroup);
            Controls.Add(nameInput);
            Name = "CharacterEditorForm";
            Text = "CharacterEditorForm";
            Shown += CharacterEditorForm_Shown;
            statsGroup.ResumeLayout(false);
            statsGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameInput;
        private GroupBox statsGroup;
        private ListBox inventoryListBox;
        private Label raceLabel;
        private Label classLabel;
        private Label lvlLabel;
        private TextBox healthLabel;
        private Button ConstitutionUp;
        private Label label2;
        private Button DexterityUp;
        private Label labelPoints;
        private Button StrengthUp;
        private Label label3;
        private Button CharismaUp;
        private Label label4;
        private Button WisdomUp;
        private Label label5;
        private Button InteligenceUp;
        private Label label6;
        private Label labelCharisma;
        private Label label7;
        private Label labelWisdom;
        private Label label8;
        private Label labelInteligence;
        private Label labelStrength;
        private Label labelConstitution;
        private Label labelDexterity;
        private Button btnSave;
        private Button btnLevelUp;
        private Label label1;
    }
}