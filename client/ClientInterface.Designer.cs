namespace client
{
    partial class ClientInterface
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
            panelContainer = new Panel();
            buttonsTab = new FlowLayoutPanel();
            loginButton = new Button();
            createButton = new Button();
            charactersButton = new Button();
            playButton = new Button();
            buttonsTab.SuspendLayout();
            SuspendLayout();
            // 
            // panelContainer
            // 
            panelContainer.Dock = DockStyle.Bottom;
            panelContainer.Location = new Point(0, 70);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(800, 380);
            panelContainer.TabIndex = 0;
            // 
            // buttonsTab
            // 
            buttonsTab.Controls.Add(loginButton);
            buttonsTab.Controls.Add(createButton);
            buttonsTab.Controls.Add(charactersButton);
            buttonsTab.Controls.Add(playButton);
            buttonsTab.Dock = DockStyle.Top;
            buttonsTab.Location = new Point(0, 0);
            buttonsTab.Name = "buttonsTab";
            buttonsTab.Size = new Size(800, 60);
            buttonsTab.TabIndex = 1;
            buttonsTab.WrapContents = false;
            // 
            // loginButton
            // 
            loginButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            loginButton.Location = new Point(3, 3);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(193, 57);
            loginButton.TabIndex = 0;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // createButton
            // 
            createButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            createButton.Location = new Point(202, 3);
            createButton.Name = "createButton";
            createButton.Size = new Size(193, 57);
            createButton.TabIndex = 1;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // charactersButton
            // 
            charactersButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            charactersButton.Location = new Point(401, 3);
            charactersButton.Name = "charactersButton";
            charactersButton.Size = new Size(193, 57);
            charactersButton.TabIndex = 2;
            charactersButton.Text = "Manage";
            charactersButton.UseVisualStyleBackColor = true;
            charactersButton.Click += charactersButton_Click;
            // 
            // playButton
            // 
            playButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            playButton.Location = new Point(600, 3);
            playButton.Name = "playButton";
            playButton.Size = new Size(193, 57);
            playButton.TabIndex = 3;
            playButton.Text = "Play";
            playButton.UseVisualStyleBackColor = true;
            playButton.Click += playButton_Click;
            // 
            // ClientInterface
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonsTab);
            Controls.Add(panelContainer);
            Name = "ClientInterface";
            Text = "Hero Vault";
            Load += ClientInterface_Load;
            buttonsTab.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContainer;
        private FlowLayoutPanel buttonsTab;
        private Button loginButton;
        private Button createButton;
        private Button charactersButton;
        private Button playButton;
    }
}