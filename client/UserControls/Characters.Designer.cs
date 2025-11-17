namespace client.UserControls
{
    partial class Characters
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
            splitContainer1 = new SplitContainer();
            numStrength = new NumericUpDown();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnView = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            tabEditor = new TabControl();
            tabPageMain = new TabPage();
            tableLayoutPanelMain = new TableLayoutPanel();
            lblName = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            lblLevel = new Label();
            lblHealth = new Label();
            flowLayoutPanel4 = new FlowLayoutPanel();
            lblCurrentLevel = new Label();
            btnLevelUp = new Button();
            tabPageStats = new TabPage();
            ConstitutionUp = new Button();
            DexterityUp = new Button();
            StrengthUp = new Button();
            CharismaUp = new Button();
            WisdomUp = new Button();
            InteligenceUp = new Button();
            labelCharisma = new Label();
            labelWisdom = new Label();
            labelInteligence = new Label();
            labelConstitution = new Label();
            labelDexterity = new Label();
            labelStrength = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            labelPoints = new Label();
            label2 = new Label();
            tabPageInventory = new TabPage();
            AddToInventorybutton = new Button();
            textBox2 = new TextBox();
            InventorylistBoxUp = new ListBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numStrength).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            tabEditor.SuspendLayout();
            tabPageMain.SuspendLayout();
            tableLayoutPanelMain.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            tabPageStats.SuspendLayout();
            tabPageInventory.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(numStrength);
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel2);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(560, 228);
            splitContainer1.SplitterDistance = 249;
            splitContainer1.TabIndex = 0;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // numStrength
            // 
            numStrength.Location = new Point(263, 119);
            numStrength.Name = "numStrength";
            numStrength.Size = new Size(104, 23);
            numStrength.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(243, 222);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(textBox1);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(237, 30);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 23);
            label1.TabIndex = 0;
            label1.Text = "Пошук";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(59, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(91, 23);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(156, 3);
            button1.Name = "button1";
            button1.Size = new Size(70, 23);
            button1.TabIndex = 2;
            button1.Text = "Очистити";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 39);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(237, 180);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(flowLayoutPanel2, 0, 0);
            tableLayoutPanel2.Controls.Add(tabEditor, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(307, 228);
            tableLayoutPanel2.TabIndex = 0;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint_1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btnView);
            flowLayoutPanel2.Controls.Add(btnEdit);
            flowLayoutPanel2.Controls.Add(btnDelete);
            flowLayoutPanel2.Controls.Add(btnRefresh);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(301, 85);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // btnView
            // 
            btnView.AutoSize = true;
            btnView.Enabled = false;
            btnView.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnView.Location = new Point(20, 9);
            btnView.Margin = new Padding(20, 9, 30, 10);
            btnView.Name = "btnView";
            btnView.Size = new Size(115, 31);
            btnView.TabIndex = 0;
            btnView.Text = "Переглянути";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnEdit
            // 
            btnEdit.AutoSize = true;
            btnEdit.Enabled = false;
            btnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.Location = new Point(165, 9);
            btnEdit.Margin = new Padding(0, 9, 20, 10);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(115, 31);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Редагувати";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.Enabled = false;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(20, 50);
            btnDelete.Margin = new Padding(20, 0, 30, 9);
            btnDelete.Name = "btnDelete";
            btnDelete.Padding = new Padding(10, 0, 0, 0);
            btnDelete.Size = new Size(115, 31);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Видалити";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.AutoSize = true;
            btnRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefresh.Location = new Point(165, 50);
            btnRefresh.Margin = new Padding(0, 0, 20, 9);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(115, 31);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Оновити";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // tabEditor
            // 
            tabEditor.Controls.Add(tabPageMain);
            tabEditor.Controls.Add(tabPageStats);
            tabEditor.Controls.Add(tabPageInventory);
            tabEditor.Dock = DockStyle.Fill;
            tabEditor.Location = new Point(3, 94);
            tabEditor.Name = "tabEditor";
            tabEditor.SelectedIndex = 0;
            tabEditor.Size = new Size(301, 131);
            tabEditor.TabIndex = 1;
            // 
            // tabPageMain
            // 
            tabPageMain.Controls.Add(tableLayoutPanelMain);
            tabPageMain.Location = new Point(4, 24);
            tabPageMain.Name = "tabPageMain";
            tabPageMain.Padding = new Padding(3);
            tabPageMain.Size = new Size(293, 103);
            tabPageMain.TabIndex = 0;
            tabPageMain.Text = "Основне";
            tabPageMain.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 1;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Controls.Add(lblName, 0, 0);
            tableLayoutPanelMain.Controls.Add(flowLayoutPanel3, 0, 1);
            tableLayoutPanelMain.Controls.Add(flowLayoutPanel4, 0, 2);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(3, 3);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 3;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanelMain.Size = new Size(287, 97);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Dock = DockStyle.Fill;
            lblName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(3, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(281, 29);
            lblName.TabIndex = 2;
            lblName.Text = "label2";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(lblLevel);
            flowLayoutPanel3.Controls.Add(lblHealth);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(3, 32);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(281, 27);
            flowLayoutPanel3.TabIndex = 6;
            // 
            // lblLevel
            // 
            lblLevel.Anchor = AnchorStyles.Left;
            lblLevel.Location = new Point(3, 0);
            lblLevel.Margin = new Padding(3, 0, 7, 0);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(130, 25);
            lblLevel.TabIndex = 5;
            lblLevel.Text = "Leveltxt";
            lblLevel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHealth
            // 
            lblHealth.Location = new Point(140, 0);
            lblHealth.Margin = new Padding(0, 0, 3, 0);
            lblHealth.Name = "lblHealth";
            lblHealth.Size = new Size(130, 25);
            lblHealth.TabIndex = 5;
            lblHealth.Text = "Healthtxt";
            lblHealth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(lblCurrentLevel);
            flowLayoutPanel4.Controls.Add(btnLevelUp);
            flowLayoutPanel4.Dock = DockStyle.Fill;
            flowLayoutPanel4.Enabled = false;
            flowLayoutPanel4.Location = new Point(3, 65);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(281, 29);
            flowLayoutPanel4.TabIndex = 7;
            // 
            // lblCurrentLevel
            // 
            lblCurrentLevel.Location = new Point(3, 0);
            lblCurrentLevel.Name = "lblCurrentLevel";
            lblCurrentLevel.Size = new Size(132, 30);
            lblCurrentLevel.TabIndex = 0;
            lblCurrentLevel.Text = "label2";
            lblCurrentLevel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLevelUp
            // 
            btnLevelUp.Location = new Point(141, 3);
            btnLevelUp.Name = "btnLevelUp";
            btnLevelUp.Size = new Size(122, 23);
            btnLevelUp.TabIndex = 1;
            btnLevelUp.Text = "Підняти рівень";
            btnLevelUp.UseVisualStyleBackColor = true;
            // 
            // tabPageStats
            // 
            tabPageStats.Controls.Add(ConstitutionUp);
            tabPageStats.Controls.Add(DexterityUp);
            tabPageStats.Controls.Add(StrengthUp);
            tabPageStats.Controls.Add(CharismaUp);
            tabPageStats.Controls.Add(WisdomUp);
            tabPageStats.Controls.Add(InteligenceUp);
            tabPageStats.Controls.Add(labelCharisma);
            tabPageStats.Controls.Add(labelWisdom);
            tabPageStats.Controls.Add(labelInteligence);
            tabPageStats.Controls.Add(labelConstitution);
            tabPageStats.Controls.Add(labelDexterity);
            tabPageStats.Controls.Add(labelStrength);
            tabPageStats.Controls.Add(label8);
            tabPageStats.Controls.Add(label7);
            tabPageStats.Controls.Add(label6);
            tabPageStats.Controls.Add(label5);
            tabPageStats.Controls.Add(label4);
            tabPageStats.Controls.Add(label3);
            tabPageStats.Controls.Add(labelPoints);
            tabPageStats.Controls.Add(label2);
            tabPageStats.Location = new Point(4, 24);
            tabPageStats.Name = "tabPageStats";
            tabPageStats.Padding = new Padding(3);
            tabPageStats.Size = new Size(293, 103);
            tabPageStats.TabIndex = 1;
            tabPageStats.Text = "Характеристики";
            tabPageStats.UseVisualStyleBackColor = true;
            // 
            // ConstitutionUp
            // 
            ConstitutionUp.Anchor = AnchorStyles.None;
            ConstitutionUp.AutoSize = true;
            ConstitutionUp.Enabled = false;
            ConstitutionUp.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ConstitutionUp.Location = new Point(113, 77);
            ConstitutionUp.Name = "ConstitutionUp";
            ConstitutionUp.Size = new Size(29, 29);
            ConstitutionUp.TabIndex = 19;
            ConstitutionUp.Text = "+";
            ConstitutionUp.UseVisualStyleBackColor = true;
            // 
            // DexterityUp
            // 
            DexterityUp.Anchor = AnchorStyles.None;
            DexterityUp.AutoSize = true;
            DexterityUp.Enabled = false;
            DexterityUp.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            DexterityUp.Location = new Point(113, 50);
            DexterityUp.Name = "DexterityUp";
            DexterityUp.Size = new Size(29, 29);
            DexterityUp.TabIndex = 18;
            DexterityUp.Text = "+";
            DexterityUp.UseVisualStyleBackColor = true;
            // 
            // StrengthUp
            // 
            StrengthUp.Anchor = AnchorStyles.None;
            StrengthUp.AutoSize = true;
            StrengthUp.Enabled = false;
            StrengthUp.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            StrengthUp.Location = new Point(113, 21);
            StrengthUp.Name = "StrengthUp";
            StrengthUp.Size = new Size(29, 29);
            StrengthUp.TabIndex = 17;
            StrengthUp.Text = "+";
            StrengthUp.UseVisualStyleBackColor = true;
            // 
            // CharismaUp
            // 
            CharismaUp.Anchor = AnchorStyles.None;
            CharismaUp.AutoSize = true;
            CharismaUp.Enabled = false;
            CharismaUp.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            CharismaUp.Location = new Point(250, 74);
            CharismaUp.Name = "CharismaUp";
            CharismaUp.Size = new Size(29, 29);
            CharismaUp.TabIndex = 16;
            CharismaUp.Text = "+";
            CharismaUp.UseVisualStyleBackColor = true;
            // 
            // WisdomUp
            // 
            WisdomUp.Anchor = AnchorStyles.None;
            WisdomUp.AutoSize = true;
            WisdomUp.Enabled = false;
            WisdomUp.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            WisdomUp.Location = new Point(249, 47);
            WisdomUp.Name = "WisdomUp";
            WisdomUp.Size = new Size(29, 29);
            WisdomUp.TabIndex = 15;
            WisdomUp.Text = "+";
            WisdomUp.UseVisualStyleBackColor = true;
            // 
            // InteligenceUp
            // 
            InteligenceUp.Anchor = AnchorStyles.None;
            InteligenceUp.AutoSize = true;
            InteligenceUp.Enabled = false;
            InteligenceUp.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            InteligenceUp.Location = new Point(249, 21);
            InteligenceUp.Name = "InteligenceUp";
            InteligenceUp.Size = new Size(29, 29);
            InteligenceUp.TabIndex = 14;
            InteligenceUp.Text = "+";
            InteligenceUp.UseVisualStyleBackColor = true;
            // 
            // labelCharisma
            // 
            labelCharisma.AutoSize = true;
            labelCharisma.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelCharisma.Location = new Point(226, 81);
            labelCharisma.Name = "labelCharisma";
            labelCharisma.Size = new Size(17, 19);
            labelCharisma.TabIndex = 13;
            labelCharisma.Text = "0";
            labelCharisma.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelWisdom
            // 
            labelWisdom.AutoSize = true;
            labelWisdom.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelWisdom.Location = new Point(226, 51);
            labelWisdom.Name = "labelWisdom";
            labelWisdom.Size = new Size(17, 19);
            labelWisdom.TabIndex = 12;
            labelWisdom.Text = "0";
            labelWisdom.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelInteligence
            // 
            labelInteligence.AutoSize = true;
            labelInteligence.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelInteligence.Location = new Point(226, 23);
            labelInteligence.Name = "labelInteligence";
            labelInteligence.Size = new Size(17, 19);
            labelInteligence.TabIndex = 11;
            labelInteligence.Text = "0";
            labelInteligence.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelConstitution
            // 
            labelConstitution.AutoSize = true;
            labelConstitution.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelConstitution.Location = new Point(91, 81);
            labelConstitution.Name = "labelConstitution";
            labelConstitution.Size = new Size(17, 19);
            labelConstitution.TabIndex = 10;
            labelConstitution.Text = "0";
            labelConstitution.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelDexterity
            // 
            labelDexterity.AutoSize = true;
            labelDexterity.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelDexterity.Location = new Point(90, 51);
            labelDexterity.Name = "labelDexterity";
            labelDexterity.Size = new Size(17, 19);
            labelDexterity.TabIndex = 9;
            labelDexterity.Text = "0";
            labelDexterity.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelStrength
            // 
            labelStrength.AutoSize = true;
            labelStrength.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelStrength.Location = new Point(90, 21);
            labelStrength.Name = "labelStrength";
            labelStrength.Size = new Size(17, 19);
            labelStrength.TabIndex = 8;
            labelStrength.Text = "0";
            labelStrength.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(149, 81);
            label8.Name = "label8";
            label8.Size = new Size(85, 19);
            label8.TabIndex = 7;
            label8.Text = "Charisma";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(149, 51);
            label7.Name = "label7";
            label7.Size = new Size(85, 19);
            label7.TabIndex = 6;
            label7.Text = "Wisdom";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(149, 23);
            label6.Name = "label6";
            label6.Size = new Size(85, 19);
            label6.TabIndex = 5;
            label6.Text = "Inteligence";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(0, 81);
            label5.Name = "label5";
            label5.Size = new Size(85, 19);
            label5.TabIndex = 4;
            label5.Text = "Constitution";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(0, 51);
            label4.Name = "label4";
            label4.Size = new Size(85, 19);
            label4.TabIndex = 3;
            label4.Text = "Dexterity";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(-3, 21);
            label3.Name = "label3";
            label3.Size = new Size(88, 23);
            label3.TabIndex = 2;
            label3.Text = "Strength";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelPoints
            // 
            labelPoints.AutoSize = true;
            labelPoints.Location = new Point(277, 3);
            labelPoints.Name = "labelPoints";
            labelPoints.Size = new Size(13, 15);
            labelPoints.TabIndex = 1;
            labelPoints.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(226, 3);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 0;
            label2.Text = "Поінти";
            // 
            // tabPageInventory
            // 
            tabPageInventory.Controls.Add(AddToInventorybutton);
            tabPageInventory.Controls.Add(textBox2);
            tabPageInventory.Controls.Add(InventorylistBoxUp);
            tabPageInventory.Location = new Point(4, 24);
            tabPageInventory.Name = "tabPageInventory";
            tabPageInventory.Size = new Size(293, 103);
            tabPageInventory.TabIndex = 2;
            tabPageInventory.Text = "Інвентар";
            tabPageInventory.UseVisualStyleBackColor = true;
            // 
            // AddToInventorybutton
            // 
            AddToInventorybutton.Location = new Point(218, 78);
            AddToInventorybutton.Name = "AddToInventorybutton";
            AddToInventorybutton.Size = new Size(75, 24);
            AddToInventorybutton.TabIndex = 2;
            AddToInventorybutton.Text = "Додати";
            AddToInventorybutton.UseVisualStyleBackColor = true;
            AddToInventorybutton.Click += AddToInventorybutton_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(3, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(209, 23);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged_1;
            // 
            // InventorylistBoxUp
            // 
            InventorylistBoxUp.FormattingEnabled = true;
            InventorylistBoxUp.ItemHeight = 15;
            InventorylistBoxUp.Location = new Point(3, 1);
            InventorylistBoxUp.Name = "InventorylistBoxUp";
            InventorylistBoxUp.Size = new Size(290, 79);
            InventorylistBoxUp.TabIndex = 0;
            InventorylistBoxUp.SelectedIndexChanged += InventorylistBoxUp_SelectedIndexChanged;
            // 
            // Characters
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Margin = new Padding(2);
            Name = "Characters";
            Size = new Size(560, 228);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numStrength).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            tabEditor.ResumeLayout(false);
            tabPageMain.ResumeLayout(false);
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelMain.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            tabPageStats.ResumeLayout(false);
            tabPageStats.PerformLayout();
            tabPageInventory.ResumeLayout(false);
            tabPageInventory.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnView;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnRefresh;
        private NumericUpDown numStrength;
        private TabControl tabEditor;
        private TabPage tabPageMain;
        private TabPage tabPageInventory;
        private TableLayoutPanel tableLayoutPanelMain;
        private Label lblName;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label lblLevel;
        private Label lblHealth;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label lblCurrentLevel;
        private Button btnLevelUp;
        private TabPage tabPageStats;
        private Label label3;
        private Label labelPoints;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label6;
        private Button InteligenceUp;
        private Label labelCharisma;
        private Label labelWisdom;
        private Label labelInteligence;
        private Label labelConstitution;
        private Label labelDexterity;
        private Label labelStrength;
        private Label label8;
        private Button ConstitutionUp;
        private Button DexterityUp;
        private Button StrengthUp;
        private Button CharismaUp;
        private Button WisdomUp;
        private ListBox InventorylistBoxUp;
        private TextBox textBox2;
        private Button AddToInventorybutton;
    }
}
