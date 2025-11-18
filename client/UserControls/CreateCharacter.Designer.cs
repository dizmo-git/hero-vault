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
            charismaLabel = new Label();
            wisdomLabel = new Label();
            intelligenceLabel = new Label();
            constitutionLabel = new Label();
            dexterityLabel = new Label();
            strengthLabel = new Label();
            inventoryListBox = new ListBox();
            statsGroup.SuspendLayout();
            SuspendLayout();
            // 
            // nameInput
            // 
            nameInput.Location = new Point(3, 2);
            nameInput.Margin = new Padding(3, 2, 3, 2);
            nameInput.Name = "nameInput";
            nameInput.PlaceholderText = "Name";
            nameInput.Size = new Size(185, 23);
            nameInput.TabIndex = 0;
            // 
            // raceDropdown
            // 
            raceDropdown.FormattingEnabled = true;
            raceDropdown.Location = new Point(3, 27);
            raceDropdown.Margin = new Padding(3, 2, 3, 2);
            raceDropdown.Name = "raceDropdown";
            raceDropdown.Size = new Size(185, 23);
            raceDropdown.TabIndex = 1;
            raceDropdown.SelectedIndexChanged += raceDropdown_SelectedIndexChanged;
            // 
            // classDropdown
            // 
            classDropdown.FormattingEnabled = true;
            classDropdown.Location = new Point(3, 52);
            classDropdown.Margin = new Padding(3, 2, 3, 2);
            classDropdown.Name = "classDropdown";
            classDropdown.Size = new Size(185, 23);
            classDropdown.TabIndex = 2;
            classDropdown.SelectedIndexChanged += classDropdown_SelectedIndexChanged;
            // 
            // createButton
            // 
            createButton.Location = new Point(3, 78);
            createButton.Margin = new Padding(3, 2, 3, 2);
            createButton.Name = "createButton";
            createButton.Size = new Size(185, 22);
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
            statsGroup.Location = new Point(192, 2);
            statsGroup.Margin = new Padding(3, 2, 3, 2);
            statsGroup.Name = "statsGroup";
            statsGroup.Padding = new Padding(3, 2, 3, 2);
            statsGroup.Size = new Size(365, 98);
            statsGroup.TabIndex = 4;
            statsGroup.TabStop = false;
            statsGroup.Text = "Stats";
            // 
            // charismaLabel
            // 
            charismaLabel.AutoSize = true;
            charismaLabel.Location = new Point(152, 31);
            charismaLabel.Name = "charismaLabel";
            charismaLabel.Size = new Size(13, 15);
            charismaLabel.TabIndex = 5;
            charismaLabel.Text = "6";
            // 
            // wisdomLabel
            // 
            wisdomLabel.AutoSize = true;
            wisdomLabel.Location = new Point(152, 17);
            wisdomLabel.Name = "wisdomLabel";
            wisdomLabel.Size = new Size(13, 15);
            wisdomLabel.TabIndex = 4;
            wisdomLabel.Text = "5";
            // 
            // intelligenceLabel
            // 
            intelligenceLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            intelligenceLabel.AutoSize = true;
            intelligenceLabel.Location = new Point(5, 62);
            intelligenceLabel.Name = "intelligenceLabel";
            intelligenceLabel.Size = new Size(13, 15);
            intelligenceLabel.TabIndex = 3;
            intelligenceLabel.Text = "4";
            // 
            // constitutionLabel
            // 
            constitutionLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            constitutionLabel.AutoSize = true;
            constitutionLabel.Location = new Point(5, 47);
            constitutionLabel.Name = "constitutionLabel";
            constitutionLabel.Size = new Size(13, 15);
            constitutionLabel.TabIndex = 2;
            constitutionLabel.Text = "3";
            // 
            // dexterityLabel
            // 
            dexterityLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dexterityLabel.AutoSize = true;
            dexterityLabel.Location = new Point(5, 32);
            dexterityLabel.Name = "dexterityLabel";
            dexterityLabel.Size = new Size(13, 15);
            dexterityLabel.TabIndex = 1;
            dexterityLabel.Text = "2";
            // 
            // strengthLabel
            // 
            strengthLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            strengthLabel.AutoSize = true;
            strengthLabel.Location = new Point(5, 17);
            strengthLabel.Name = "strengthLabel";
            strengthLabel.Size = new Size(13, 15);
            strengthLabel.TabIndex = 0;
            strengthLabel.Text = "1";
            // 
            // inventoryListBox
            // 
            inventoryListBox.FormattingEnabled = true;
            inventoryListBox.ItemHeight = 15;
            inventoryListBox.Location = new Point(192, 104);
            inventoryListBox.Margin = new Padding(3, 2, 3, 2);
            inventoryListBox.Name = "inventoryListBox";
            inventoryListBox.Size = new Size(365, 79);
            inventoryListBox.TabIndex = 5;
            // 
            // CreateCharacter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(inventoryListBox);
            Controls.Add(statsGroup);
            Controls.Add(createButton);
            Controls.Add(classDropdown);
            Controls.Add(raceDropdown);
            Controls.Add(nameInput);
            Margin = new Padding(2);
            Name = "CreateCharacter";
            Size = new Size(560, 228);
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
