namespace client.UserControls
{
    partial class CreateCharacter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nameInput = new TextBox();
            raceDropdown = new ComboBox();
            classDropdown = new ComboBox();
            createButton = new Button();
            statsGroup = new GroupBox();
            strengthLabel = new Label();
            dexterityLabel = new Label();
            constitutionLabel = new Label();
            intelligenceLabel = new Label();
            wisdomLabel = new Label();
            charismaLabel = new Label();
            inventoryListBox = new ListBox();
            statsGroup.SuspendLayout();
            SuspendLayout();
            // 
            // nameInput
            // 
            nameInput.Location = new Point(3, 3);
            nameInput.Name = "nameInput";
            nameInput.PlaceholderText = "Name";
            nameInput.Size = new Size(211, 27);
            nameInput.TabIndex = 0;
            // 
            // raceDropdown
            // 
            raceDropdown.FormattingEnabled = true;
            raceDropdown.Location = new Point(3, 36);
            raceDropdown.Name = "raceDropdown";
            raceDropdown.Size = new Size(211, 28);
            raceDropdown.TabIndex = 1;
            raceDropdown.SelectedIndexChanged += raceDropdown_SelectedIndexChanged;
            // 
            // classDropdown
            // 
            classDropdown.FormattingEnabled = true;
            classDropdown.Location = new Point(3, 70);
            classDropdown.Name = "classDropdown";
            classDropdown.Size = new Size(211, 28);
            classDropdown.TabIndex = 2;
            classDropdown.SelectedIndexChanged += classDropdown_SelectedIndexChanged;
            // 
            // createButton
            // 
            createButton.Location = new Point(3, 104);
            createButton.Name = "createButton";
            createButton.Size = new Size(211, 29);
            createButton.TabIndex = 3;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // statsGroup
            // 
            statsGroup.Controls.Add(charismaLabel);
            statsGroup.Controls.Add(wisdomLabel);
            statsGroup.Controls.Add(intelligenceLabel);
            statsGroup.Controls.Add(constitutionLabel);
            statsGroup.Controls.Add(dexterityLabel);
            statsGroup.Controls.Add(strengthLabel);
            statsGroup.Location = new Point(220, 3);
            statsGroup.Name = "statsGroup";
            statsGroup.Size = new Size(417, 130);
            statsGroup.TabIndex = 4;
            statsGroup.TabStop = false;
            statsGroup.Text = "Stats";
            // 
            // strengthLabel
            // 
            strengthLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            strengthLabel.AutoSize = true;
            strengthLabel.Location = new Point(6, 23);
            strengthLabel.Name = "strengthLabel";
            strengthLabel.Size = new Size(17, 20);
            strengthLabel.TabIndex = 0;
            strengthLabel.Text = "1";
            // 
            // dexterityLabel
            // 
            dexterityLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dexterityLabel.AutoSize = true;
            dexterityLabel.Location = new Point(6, 43);
            dexterityLabel.Name = "dexterityLabel";
            dexterityLabel.Size = new Size(17, 20);
            dexterityLabel.TabIndex = 1;
            dexterityLabel.Text = "2";
            // 
            // constitutionLabel
            // 
            constitutionLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            constitutionLabel.AutoSize = true;
            constitutionLabel.Location = new Point(6, 63);
            constitutionLabel.Name = "constitutionLabel";
            constitutionLabel.Size = new Size(17, 20);
            constitutionLabel.TabIndex = 2;
            constitutionLabel.Text = "3";
            // 
            // intelligenceLabel
            // 
            intelligenceLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            intelligenceLabel.AutoSize = true;
            intelligenceLabel.Location = new Point(6, 83);
            intelligenceLabel.Name = "intelligenceLabel";
            intelligenceLabel.Size = new Size(17, 20);
            intelligenceLabel.TabIndex = 3;
            intelligenceLabel.Text = "4";
            // 
            // wisdomLabel
            // 
            wisdomLabel.AutoSize = true;
            wisdomLabel.Location = new Point(174, 23);
            wisdomLabel.Name = "wisdomLabel";
            wisdomLabel.Size = new Size(17, 20);
            wisdomLabel.TabIndex = 4;
            wisdomLabel.Text = "5";
            // 
            // charismaLabel
            // 
            charismaLabel.AutoSize = true;
            charismaLabel.Location = new Point(174, 41);
            charismaLabel.Name = "charismaLabel";
            charismaLabel.Size = new Size(17, 20);
            charismaLabel.TabIndex = 5;
            charismaLabel.Text = "6";
            // 
            // inventoryListBox
            // 
            inventoryListBox.FormattingEnabled = true;
            inventoryListBox.ItemHeight = 20;
            inventoryListBox.Location = new Point(220, 139);
            inventoryListBox.Name = "inventoryListBox";
            inventoryListBox.Size = new Size(417, 104);
            inventoryListBox.TabIndex = 5;
            // 
            // CreateCharacter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(inventoryListBox);
            Controls.Add(statsGroup);
            Controls.Add(createButton);
            Controls.Add(classDropdown);
            Controls.Add(raceDropdown);
            Controls.Add(nameInput);
            Margin = new Padding(2);
            Name = "CreateCharacter";
            Size = new Size(640, 304);
            Load += CreateCharacter_Load;
            statsGroup.ResumeLayout(false);
            statsGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameInput;
        private ComboBox raceDropdown;
        private ComboBox classDropdown;
        private Button createButton;
        private GroupBox statsGroup;
        private Label strengthLabel;
        private Label charismaLabel;
        private Label wisdomLabel;
        private Label intelligenceLabel;
        private Label constitutionLabel;
        private Label dexterityLabel;
        private ListBox inventoryListBox;
    }
}
