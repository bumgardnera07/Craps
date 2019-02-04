namespace Craps
{
    partial class FormMainPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainPage));
            this.gbWelcomeScreen = new System.Windows.Forms.GroupBox();
            this.lsboxChooseName = new System.Windows.Forms.ListBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crapsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crapsDataSet = new Craps.CrapsDataSet();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.lblOR = new System.Windows.Forms.Label();
            this.WelcomeTitle = new System.Windows.Forms.Label();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.lblChooseName = new System.Windows.Forms.Label();
            this.lblEnterName = new System.Windows.Forms.Label();
            this.gbPlayerMenu = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GameNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rollNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.die1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.die2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rollHistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnChangePlayer = new System.Windows.Forms.Button();
            this.btnClearHistory = new System.Windows.Forms.Button();
            this.btnDeletePlayer = new System.Windows.Forms.Button();
            this.btnUpdateName = new System.Windows.Forms.Button();
            this.gbPlayMenu = new System.Windows.Forms.GroupBox();
            this.lblLossValue = new System.Windows.Forms.Label();
            this.lblWinValue = new System.Windows.Forms.Label();
            this.lblDieTotalValue = new System.Windows.Forms.Label();
            this.lblDie2Value = new System.Windows.Forms.Label();
            this.lblDie1Value = new System.Windows.Forms.Label();
            this.lblOutcome = new System.Windows.Forms.Label();
            this.lblRollTotal = new System.Windows.Forms.Label();
            this.lblLoseCondition = new System.Windows.Forms.Label();
            this.lblWinCondition = new System.Windows.Forms.Label();
            this.lblRollDie2 = new System.Windows.Forms.Label();
            this.lblRollDie1 = new System.Windows.Forms.Label();
            this.btnRollDice = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.tableAdapterManager = new Craps.CrapsDataSetTableAdapters.TableAdapterManager();
            this.gameTableAdapter = new Craps.CrapsDataSetTableAdapters.GameTableAdapter();
            this.userTableAdapter = new Craps.CrapsDataSetTableAdapters.UserTableAdapter();
            this.rollHistTableAdapter = new Craps.CrapsDataSetTableAdapters.RollHistTableAdapter();
            this.rollBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rollTableAdapter = new Craps.CrapsDataSetTableAdapters.RollTableAdapter();
            this.gameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbWelcomeScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crapsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crapsDataSet)).BeginInit();
            this.gbPlayerMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollHistBindingSource)).BeginInit();
            this.gbPlayMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rollBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbWelcomeScreen
            // 
            this.gbWelcomeScreen.Controls.Add(this.lsboxChooseName);
            this.gbWelcomeScreen.Controls.Add(this.btnAddUser);
            this.gbWelcomeScreen.Controls.Add(this.Exit);
            this.gbWelcomeScreen.Controls.Add(this.lblOR);
            this.gbWelcomeScreen.Controls.Add(this.WelcomeTitle);
            this.gbWelcomeScreen.Controls.Add(this.txtAddName);
            this.gbWelcomeScreen.Controls.Add(this.lblChooseName);
            this.gbWelcomeScreen.Controls.Add(this.lblEnterName);
            this.gbWelcomeScreen.Location = new System.Drawing.Point(0, 0);
            this.gbWelcomeScreen.Name = "gbWelcomeScreen";
            this.gbWelcomeScreen.Size = new System.Drawing.Size(315, 546);
            this.gbWelcomeScreen.TabIndex = 1;
            this.gbWelcomeScreen.TabStop = false;
            // 
            // lsboxChooseName
            // 
            this.lsboxChooseName.DataSource = this.userBindingSource;
            this.lsboxChooseName.DisplayMember = "Name";
            this.lsboxChooseName.FormattingEnabled = true;
            this.lsboxChooseName.Location = new System.Drawing.Point(9, 264);
            this.lsboxChooseName.Margin = new System.Windows.Forms.Padding(6);
            this.lsboxChooseName.Name = "lsboxChooseName";
            this.lsboxChooseName.Size = new System.Drawing.Size(296, 277);
            this.lsboxChooseName.TabIndex = 3;
            this.lsboxChooseName.DoubleClick += new System.EventHandler(this.LsboxChooseName_DoubleClick);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.crapsDataSetBindingSource;
            // 
            // crapsDataSetBindingSource
            // 
            this.crapsDataSetBindingSource.DataSource = this.crapsDataSet;
            this.crapsDataSetBindingSource.Position = 0;
            // 
            // crapsDataSet
            // 
            this.crapsDataSet.DataSetName = "CrapsDataSet";
            this.crapsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(230, 172);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 23);
            this.btnAddUser.TabIndex = 2;
            this.btnAddUser.Text = "Let\'s Play!";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(692, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 10;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // lblOR
            // 
            this.lblOR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOR.AutoSize = true;
            this.lblOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOR.Location = new System.Drawing.Point(126, 212);
            this.lblOR.Name = "lblOR";
            this.lblOR.Size = new System.Drawing.Size(43, 20);
            this.lblOR.TabIndex = 11;
            this.lblOR.Text = "-OR-";
            // 
            // WelcomeTitle
            // 
            this.WelcomeTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.WelcomeTitle.Font = new System.Drawing.Font("Garamond", 38F, System.Drawing.FontStyle.Bold);
            this.WelcomeTitle.Location = new System.Drawing.Point(3, 16);
            this.WelcomeTitle.Name = "WelcomeTitle";
            this.WelcomeTitle.Size = new System.Drawing.Size(309, 142);
            this.WelcomeTitle.TabIndex = 0;
            this.WelcomeTitle.Text = "Welcome to Craps!";
            this.WelcomeTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(9, 175);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(215, 20);
            this.txtAddName.TabIndex = 1;
            this.txtAddName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtAddName_KeyDown);
            // 
            // lblChooseName
            // 
            this.lblChooseName.AutoSize = true;
            this.lblChooseName.Location = new System.Drawing.Point(13, 245);
            this.lblChooseName.Name = "lblChooseName";
            this.lblChooseName.Size = new System.Drawing.Size(106, 13);
            this.lblChooseName.TabIndex = 13;
            this.lblChooseName.Text = "Choose from the List:";
            // 
            // lblEnterName
            // 
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.Location = new System.Drawing.Point(6, 159);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(87, 13);
            this.lblEnterName.TabIndex = 12;
            this.lblEnterName.Text = "Enter your name:";
            // 
            // gbPlayerMenu
            // 
            this.gbPlayerMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPlayerMenu.Controls.Add(this.dataGridView1);
            this.gbPlayerMenu.Controls.Add(this.btnChangePlayer);
            this.gbPlayerMenu.Controls.Add(this.btnClearHistory);
            this.gbPlayerMenu.Controls.Add(this.btnDeletePlayer);
            this.gbPlayerMenu.Controls.Add(this.btnUpdateName);
            this.gbPlayerMenu.Enabled = false;
            this.gbPlayerMenu.Location = new System.Drawing.Point(323, 0);
            this.gbPlayerMenu.Margin = new System.Windows.Forms.Padding(0);
            this.gbPlayerMenu.MaximumSize = new System.Drawing.Size(668, 158);
            this.gbPlayerMenu.MinimumSize = new System.Drawing.Size(668, 158);
            this.gbPlayerMenu.Name = "gbPlayerMenu";
            this.gbPlayerMenu.Size = new System.Drawing.Size(668, 158);
            this.gbPlayerMenu.TabIndex = 2;
            this.gbPlayerMenu.TabStop = false;
            this.gbPlayerMenu.Text = "Player Management";
            this.gbPlayerMenu.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GameNo,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.rollNumDataGridViewTextBoxColumn,
            this.Total,
            this.die1DataGridViewTextBoxColumn,
            this.die2DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rollHistBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(117, 16);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(543, 125);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(543, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(543, 125);
            this.dataGridView1.TabIndex = 4;
            // 
            // GameNo
            // 
            this.GameNo.DataPropertyName = "GameNo";
            this.GameNo.HeaderText = "GameNo";
            this.GameNo.Name = "GameNo";
            this.GameNo.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Result";
            this.dataGridViewTextBoxColumn1.HeaderText = "Result";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Point";
            this.dataGridViewTextBoxColumn2.HeaderText = "Point";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // rollNumDataGridViewTextBoxColumn
            // 
            this.rollNumDataGridViewTextBoxColumn.DataPropertyName = "RollNum";
            this.rollNumDataGridViewTextBoxColumn.HeaderText = "RollNum";
            this.rollNumDataGridViewTextBoxColumn.Name = "rollNumDataGridViewTextBoxColumn";
            this.rollNumDataGridViewTextBoxColumn.ReadOnly = true;
            this.rollNumDataGridViewTextBoxColumn.Width = 60;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 60;
            // 
            // die1DataGridViewTextBoxColumn
            // 
            this.die1DataGridViewTextBoxColumn.DataPropertyName = "Die1";
            this.die1DataGridViewTextBoxColumn.HeaderText = "Die1";
            this.die1DataGridViewTextBoxColumn.Name = "die1DataGridViewTextBoxColumn";
            this.die1DataGridViewTextBoxColumn.ReadOnly = true;
            this.die1DataGridViewTextBoxColumn.Width = 60;
            // 
            // die2DataGridViewTextBoxColumn
            // 
            this.die2DataGridViewTextBoxColumn.DataPropertyName = "Die2";
            this.die2DataGridViewTextBoxColumn.HeaderText = "Die2";
            this.die2DataGridViewTextBoxColumn.MinimumWidth = 50;
            this.die2DataGridViewTextBoxColumn.Name = "die2DataGridViewTextBoxColumn";
            this.die2DataGridViewTextBoxColumn.ReadOnly = true;
            this.die2DataGridViewTextBoxColumn.Width = 60;
            // 
            // rollHistBindingSource
            // 
            this.rollHistBindingSource.DataMember = "RollHist";
            this.rollHistBindingSource.DataSource = this.crapsDataSet;
            this.rollHistBindingSource.Filter = "";
            // 
            // btnChangePlayer
            // 
            this.btnChangePlayer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnChangePlayer.Location = new System.Drawing.Point(6, 23);
            this.btnChangePlayer.Name = "btnChangePlayer";
            this.btnChangePlayer.Size = new System.Drawing.Size(105, 24);
            this.btnChangePlayer.TabIndex = 4;
            this.btnChangePlayer.Text = "Change Player";
            this.btnChangePlayer.UseVisualStyleBackColor = true;
            this.btnChangePlayer.Click += new System.EventHandler(this.BtnChangePlayer_Click);
            // 
            // btnClearHistory
            // 
            this.btnClearHistory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClearHistory.Location = new System.Drawing.Point(6, 83);
            this.btnClearHistory.Name = "btnClearHistory";
            this.btnClearHistory.Size = new System.Drawing.Size(105, 24);
            this.btnClearHistory.TabIndex = 6;
            this.btnClearHistory.Text = "Clear History";
            this.btnClearHistory.UseVisualStyleBackColor = true;
            this.btnClearHistory.Click += new System.EventHandler(this.BtnClearHistory_Click);
            // 
            // btnDeletePlayer
            // 
            this.btnDeletePlayer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeletePlayer.Location = new System.Drawing.Point(6, 113);
            this.btnDeletePlayer.Name = "btnDeletePlayer";
            this.btnDeletePlayer.Size = new System.Drawing.Size(105, 24);
            this.btnDeletePlayer.TabIndex = 7;
            this.btnDeletePlayer.Text = "Delete Player";
            this.btnDeletePlayer.UseVisualStyleBackColor = true;
            this.btnDeletePlayer.Click += new System.EventHandler(this.BtnDeletePlayer_Click);
            // 
            // btnUpdateName
            // 
            this.btnUpdateName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdateName.Location = new System.Drawing.Point(6, 53);
            this.btnUpdateName.Name = "btnUpdateName";
            this.btnUpdateName.Size = new System.Drawing.Size(105, 24);
            this.btnUpdateName.TabIndex = 5;
            this.btnUpdateName.Text = "Change Name";
            this.btnUpdateName.UseVisualStyleBackColor = true;
            this.btnUpdateName.Click += new System.EventHandler(this.BtnUpdateName_Click);
            // 
            // gbPlayMenu
            // 
            this.gbPlayMenu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gbPlayMenu.Controls.Add(this.lblLossValue);
            this.gbPlayMenu.Controls.Add(this.lblWinValue);
            this.gbPlayMenu.Controls.Add(this.lblDieTotalValue);
            this.gbPlayMenu.Controls.Add(this.lblDie2Value);
            this.gbPlayMenu.Controls.Add(this.lblDie1Value);
            this.gbPlayMenu.Controls.Add(this.lblOutcome);
            this.gbPlayMenu.Controls.Add(this.lblRollTotal);
            this.gbPlayMenu.Controls.Add(this.lblLoseCondition);
            this.gbPlayMenu.Controls.Add(this.lblWinCondition);
            this.gbPlayMenu.Controls.Add(this.lblRollDie2);
            this.gbPlayMenu.Controls.Add(this.lblRollDie1);
            this.gbPlayMenu.Controls.Add(this.btnRollDice);
            this.gbPlayMenu.Enabled = false;
            this.gbPlayMenu.Location = new System.Drawing.Point(323, 164);
            this.gbPlayMenu.Margin = new System.Windows.Forms.Padding(0);
            this.gbPlayMenu.MaximumSize = new System.Drawing.Size(670, 421);
            this.gbPlayMenu.MinimumSize = new System.Drawing.Size(670, 421);
            this.gbPlayMenu.Name = "gbPlayMenu";
            this.gbPlayMenu.Size = new System.Drawing.Size(670, 421);
            this.gbPlayMenu.TabIndex = 3;
            this.gbPlayMenu.TabStop = false;
            this.gbPlayMenu.Text = "Let\'s Play Craps!";
            this.gbPlayMenu.Visible = false;
            // 
            // lblLossValue
            // 
            this.lblLossValue.AutoSize = true;
            this.lblLossValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLossValue.Location = new System.Drawing.Point(430, 319);
            this.lblLossValue.Name = "lblLossValue";
            this.lblLossValue.Size = new System.Drawing.Size(162, 31);
            this.lblLossValue.TabIndex = 11;
            this.lblLossValue.Text = "2 or 3 or 12";
            // 
            // lblWinValue
            // 
            this.lblWinValue.AutoSize = true;
            this.lblWinValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinValue.Location = new System.Drawing.Point(430, 206);
            this.lblWinValue.Name = "lblWinValue";
            this.lblWinValue.Size = new System.Drawing.Size(104, 31);
            this.lblWinValue.TabIndex = 10;
            this.lblWinValue.Text = "7 or 11";
            // 
            // lblDieTotalValue
            // 
            this.lblDieTotalValue.AutoSize = true;
            this.lblDieTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDieTotalValue.Location = new System.Drawing.Point(573, 69);
            this.lblDieTotalValue.Name = "lblDieTotalValue";
            this.lblDieTotalValue.Size = new System.Drawing.Size(30, 31);
            this.lblDieTotalValue.TabIndex = 9;
            this.lblDieTotalValue.Text = "6";
            this.lblDieTotalValue.Visible = false;
            // 
            // lblDie2Value
            // 
            this.lblDie2Value.AutoSize = true;
            this.lblDie2Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDie2Value.Location = new System.Drawing.Point(441, 70);
            this.lblDie2Value.Name = "lblDie2Value";
            this.lblDie2Value.Size = new System.Drawing.Size(30, 31);
            this.lblDie2Value.TabIndex = 8;
            this.lblDie2Value.Text = "3";
            this.lblDie2Value.Visible = false;
            // 
            // lblDie1Value
            // 
            this.lblDie1Value.AutoSize = true;
            this.lblDie1Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDie1Value.Location = new System.Drawing.Point(312, 70);
            this.lblDie1Value.Name = "lblDie1Value";
            this.lblDie1Value.Size = new System.Drawing.Size(30, 31);
            this.lblDie1Value.TabIndex = 7;
            this.lblDie1Value.Text = "3";
            this.lblDie1Value.Visible = false;
            // 
            // lblOutcome
            // 
            this.lblOutcome.AutoSize = true;
            this.lblOutcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutcome.Location = new System.Drawing.Point(6, 157);
            this.lblOutcome.Name = "lblOutcome";
            this.lblOutcome.Size = new System.Drawing.Size(163, 31);
            this.lblOutcome.TabIndex = 6;
            this.lblOutcome.Text = "Good Luck!";
            this.lblOutcome.Visible = false;
            // 
            // lblRollTotal
            // 
            this.lblRollTotal.AutoSize = true;
            this.lblRollTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRollTotal.Location = new System.Drawing.Point(497, 80);
            this.lblRollTotal.Name = "lblRollTotal";
            this.lblRollTotal.Size = new System.Drawing.Size(48, 20);
            this.lblRollTotal.TabIndex = 5;
            this.lblRollTotal.Text = "Total:";
            this.lblRollTotal.Visible = false;
            // 
            // lblLoseCondition
            // 
            this.lblLoseCondition.AutoSize = true;
            this.lblLoseCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblLoseCondition.Location = new System.Drawing.Point(176, 321);
            this.lblLoseCondition.Name = "lblLoseCondition";
            this.lblLoseCondition.Size = new System.Drawing.Size(216, 29);
            this.lblLoseCondition.TabIndex = 4;
            this.lblLoseCondition.Text = "You lose if you roll:";
            // 
            // lblWinCondition
            // 
            this.lblWinCondition.AutoSize = true;
            this.lblWinCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblWinCondition.Location = new System.Drawing.Point(176, 209);
            this.lblWinCondition.Name = "lblWinCondition";
            this.lblWinCondition.Size = new System.Drawing.Size(138, 29);
            this.lblWinCondition.TabIndex = 3;
            this.lblWinCondition.Text = "To win, roll:";
            // 
            // lblRollDie2
            // 
            this.lblRollDie2.AutoSize = true;
            this.lblRollDie2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRollDie2.Location = new System.Drawing.Point(367, 80);
            this.lblRollDie2.Name = "lblRollDie2";
            this.lblRollDie2.Size = new System.Drawing.Size(42, 20);
            this.lblRollDie2.TabIndex = 2;
            this.lblRollDie2.Text = "And:";
            this.lblRollDie2.Visible = false;
            // 
            // lblRollDie1
            // 
            this.lblRollDie1.AutoSize = true;
            this.lblRollDie1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRollDie1.Location = new System.Drawing.Point(212, 80);
            this.lblRollDie1.Name = "lblRollDie1";
            this.lblRollDie1.Size = new System.Drawing.Size(84, 20);
            this.lblRollDie1.TabIndex = 1;
            this.lblRollDie1.Text = "You rolled:";
            this.lblRollDie1.Visible = false;
            // 
            // btnRollDice
            // 
            this.btnRollDice.Location = new System.Drawing.Point(18, 34);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(139, 104);
            this.btnRollDice.TabIndex = 8;
            this.btnRollDice.Text = "Roll Dice!";
            this.btnRollDice.UseVisualStyleBackColor = true;
            this.btnRollDice.Click += new System.EventHandler(this.BtnRollDice_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuit.Location = new System.Drawing.Point(9, 550);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(296, 35);
            this.btnQuit.TabIndex = 18;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GameTableAdapter = this.gameTableAdapter;
            this.tableAdapterManager.RollTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Craps.CrapsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = this.userTableAdapter;
            // 
            // gameTableAdapter
            // 
            this.gameTableAdapter.ClearBeforeFill = true;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // rollHistTableAdapter
            // 
            this.rollHistTableAdapter.ClearBeforeFill = true;
            // 
            // rollBindingSource
            // 
            this.rollBindingSource.DataMember = "Roll";
            this.rollBindingSource.DataSource = this.crapsDataSet;
            // 
            // rollTableAdapter
            // 
            this.rollTableAdapter.ClearBeforeFill = true;
            // 
            // gameBindingSource
            // 
            this.gameBindingSource.DataMember = "Game";
            this.gameBindingSource.DataSource = this.crapsDataSet;
            // 
            // FormMainPage
            // 
            this.AcceptButton = this.btnAddUser;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.btnQuit;
            this.ClientSize = new System.Drawing.Size(1003, 592);
            this.ControlBox = false;
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.gbPlayMenu);
            this.Controls.Add(this.gbPlayerMenu);
            this.Controls.Add(this.gbWelcomeScreen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1019, 630);
            this.MinimumSize = new System.Drawing.Size(1019, 630);
            this.Name = "FormMainPage";
            this.Text = "Craps";
            this.Load += new System.EventHandler(this.CrapsForm_Load);
            this.gbWelcomeScreen.ResumeLayout(false);
            this.gbWelcomeScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crapsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crapsDataSet)).EndInit();
            this.gbPlayerMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollHistBindingSource)).EndInit();
            this.gbPlayMenu.ResumeLayout(false);
            this.gbPlayMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rollBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbWelcomeScreen;
        private System.Windows.Forms.Label WelcomeTitle;
        private CrapsDataSet crapsDataSet;
        private CrapsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private CrapsDataSetTableAdapters.GameTableAdapter gameTableAdapter;
        private CrapsDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.GroupBox gbPlayerMenu;
        private System.Windows.Forms.GroupBox gbPlayMenu;
        private System.Windows.Forms.ListBox lsboxChooseName;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label lblOR;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.Label lblChooseName;
        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnChangePlayer;
        private System.Windows.Forms.Button btnClearHistory;
        private System.Windows.Forms.Button btnDeletePlayer;
        private System.Windows.Forms.Button btnUpdateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn timeDataGridViewImageColumn;
        private System.Windows.Forms.BindingSource rollHistBindingSource;
        private CrapsDataSetTableAdapters.RollHistTableAdapter rollHistTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource crapsDataSetBindingSource;
        private System.Windows.Forms.Label lblRollDie2;
        private System.Windows.Forms.Label lblRollDie1;
        private System.Windows.Forms.Button btnRollDice;
        private System.Windows.Forms.Label lblDie1Value;
        private System.Windows.Forms.Label lblOutcome;
        private System.Windows.Forms.Label lblRollTotal;
        private System.Windows.Forms.Label lblLoseCondition;
        private System.Windows.Forms.Label lblWinCondition;
        private System.Windows.Forms.Label lblLossValue;
        private System.Windows.Forms.Label lblWinValue;
        private System.Windows.Forms.Label lblDieTotalValue;
        private System.Windows.Forms.Label lblDie2Value;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.BindingSource rollBindingSource;
        private CrapsDataSetTableAdapters.RollTableAdapter rollTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn GameNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn die1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn die2DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource gameBindingSource;
    }
}