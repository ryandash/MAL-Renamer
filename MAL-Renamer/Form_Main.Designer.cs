namespace MALRenamer
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            dataGridView1 = new System.Windows.Forms.DataGridView();
            Edit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            Current = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Preview = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label1 = new System.Windows.Forms.Label();
            textBox_SourceFolder = new System.Windows.Forms.TextBox();
            button_SourceFolder = new System.Windows.Forms.Button();
            folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            textBox_AnimeID = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            button_GetAnimeInfo = new System.Windows.Forms.Button();
            button_Rename = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            radioButton_Title_None = new System.Windows.Forms.RadioButton();
            radioButton_Title_Jp = new System.Windows.Forms.RadioButton();
            radioButton_Title_En = new System.Windows.Forms.RadioButton();
            radioButton_Title_Title = new System.Windows.Forms.RadioButton();
            textBox_Title_Default = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            textBox_Title_English = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            textBox_Title_Japanese = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            textBox_AddExtraToEpisodes = new System.Windows.Forms.TextBox();
            label17 = new System.Windows.Forms.Label();
            textBox_ReplaceInvalidCharacters = new System.Windows.Forms.TextBox();
            label11 = new System.Windows.Forms.Label();
            checkBox_BackupFiles = new System.Windows.Forms.CheckBox();
            textBox_StartingEpisode = new System.Windows.Forms.TextBox();
            textBox_SectionDivider = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            checkBox_IncludeEpisode = new System.Windows.Forms.CheckBox();
            checkBox_IncludeSeason = new System.Windows.Forms.CheckBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            radioButton_Episodes_None = new System.Windows.Forms.RadioButton();
            radioButton_Episodes_Jp = new System.Windows.Forms.RadioButton();
            radioButton_Episodes_En = new System.Windows.Forms.RadioButton();
            radioButton_Episodes_Default = new System.Windows.Forms.RadioButton();
            textBox_Season = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            groupBox4 = new System.Windows.Forms.GroupBox();
            textBox_Season_Suffix = new System.Windows.Forms.TextBox();
            label13 = new System.Windows.Forms.Label();
            textBox_Season_Prefix = new System.Windows.Forms.TextBox();
            label12 = new System.Windows.Forms.Label();
            textBox_Season_Digits = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            groupBox5 = new System.Windows.Forms.GroupBox();
            textBox_Episode_Suffix = new System.Windows.Forms.TextBox();
            label14 = new System.Windows.Forms.Label();
            textBox_Episode_Prefix = new System.Windows.Forms.TextBox();
            label15 = new System.Windows.Forms.Label();
            textBox_Episode_Digits = new System.Windows.Forms.TextBox();
            label16 = new System.Windows.Forms.Label();
            button_Refresh = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            presetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            seriesS00E00ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            seriesS00E00EpisodeTitleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            seriesS00E00ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            seriesS00E00EpisodeTitleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            episodeTitleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            projectGitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            reportABugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Edit, Current, Preview });
            dataGridView1.Location = new System.Drawing.Point(20, 42);
            dataGridView1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new System.Drawing.Size(1867, 522);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += UpdateGridEvent;
            dataGridView1.CellMouseDoubleClick += DataGridView1_CellMouseDoubleClick;
            dataGridView1.CellValueChanged += UpdateGridEvent;
            dataGridView1.MouseClick += UpdateGridEvent;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            Edit.HeaderText = "Edit";
            Edit.MinimumWidth = 8;
            Edit.Name = "Edit";
            Edit.Width = 48;
            // 
            // Current
            // 
            Current.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Current.HeaderText = "Current";
            Current.MinimumWidth = 8;
            Current.Name = "Current";
            // 
            // Preview
            // 
            Preview.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Preview.HeaderText = "Preview";
            Preview.MinimumWidth = 8;
            Preview.Name = "Preview";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(20, 576);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(121, 25);
            label1.TabIndex = 1;
            label1.Text = "Source Folder";
            // 
            // textBox_SourceFolder
            // 
            textBox_SourceFolder.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBox_SourceFolder.Location = new System.Drawing.Point(20, 607);
            textBox_SourceFolder.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            textBox_SourceFolder.Name = "textBox_SourceFolder";
            textBox_SourceFolder.Size = new System.Drawing.Size(624, 31);
            textBox_SourceFolder.TabIndex = 2;
            textBox_SourceFolder.TextChanged += TextBox_SourceFolder_TextChanged;
            // 
            // button_SourceFolder
            // 
            button_SourceFolder.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            button_SourceFolder.Location = new System.Drawing.Point(657, 607);
            button_SourceFolder.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            button_SourceFolder.Name = "button_SourceFolder";
            button_SourceFolder.Size = new System.Drawing.Size(38, 37);
            button_SourceFolder.TabIndex = 3;
            button_SourceFolder.Text = "...";
            button_SourceFolder.UseVisualStyleBackColor = true;
            button_SourceFolder.Click += Button_SourceFolder_Click;
            // 
            // folderBrowserDialog1
            // 
            folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // textBox_AnimeID
            // 
            textBox_AnimeID.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            textBox_AnimeID.Location = new System.Drawing.Point(20, 703);
            textBox_AnimeID.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            textBox_AnimeID.Name = "textBox_AnimeID";
            textBox_AnimeID.Size = new System.Drawing.Size(99, 31);
            textBox_AnimeID.TabIndex = 5;
            textBox_AnimeID.KeyPress += TextBox_AnimeID_KeyPress;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(20, 672);
            label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(86, 25);
            label2.TabIndex = 4;
            label2.Text = "Anime ID";
            // 
            // button_GetAnimeInfo
            // 
            button_GetAnimeInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            button_GetAnimeInfo.Location = new System.Drawing.Point(317, 680);
            button_GetAnimeInfo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            button_GetAnimeInfo.Name = "button_GetAnimeInfo";
            button_GetAnimeInfo.Size = new System.Drawing.Size(155, 62);
            button_GetAnimeInfo.TabIndex = 6;
            button_GetAnimeInfo.Text = "Manual Load";
            button_GetAnimeInfo.UseVisualStyleBackColor = true;
            button_GetAnimeInfo.Click += Button_GetAnimeInfo_Click;
            // 
            // button_Rename
            // 
            button_Rename.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            button_Rename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            button_Rename.Location = new System.Drawing.Point(1580, 1189);
            button_Rename.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            button_Rename.Name = "button_Rename";
            button_Rename.Size = new System.Drawing.Size(305, 106);
            button_Rename.TabIndex = 7;
            button_Rename.Text = "Rename";
            button_Rename.UseVisualStyleBackColor = true;
            button_Rename.Click += Button_Rename_Click;
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            button1.Location = new System.Drawing.Point(138, 680);
            button1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(168, 62);
            button1.TabIndex = 9;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            groupBox1.Controls.Add(radioButton_Title_None);
            groupBox1.Controls.Add(radioButton_Title_Jp);
            groupBox1.Controls.Add(radioButton_Title_En);
            groupBox1.Controls.Add(radioButton_Title_Title);
            groupBox1.Location = new System.Drawing.Point(1125, 576);
            groupBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            groupBox1.Size = new System.Drawing.Size(248, 229);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Title";
            // 
            // radioButton_Title_None
            // 
            radioButton_Title_None.AutoSize = true;
            radioButton_Title_None.Location = new System.Drawing.Point(12, 171);
            radioButton_Title_None.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            radioButton_Title_None.Name = "radioButton_Title_None";
            radioButton_Title_None.Size = new System.Drawing.Size(114, 29);
            radioButton_Title_None.TabIndex = 3;
            radioButton_Title_None.Text = "Omit Title";
            radioButton_Title_None.UseVisualStyleBackColor = true;
            radioButton_Title_None.CheckedChanged += UpdateGridEvent;
            // 
            // radioButton_Title_Jp
            // 
            radioButton_Title_Jp.AutoSize = true;
            radioButton_Title_Jp.Location = new System.Drawing.Point(12, 127);
            radioButton_Title_Jp.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            radioButton_Title_Jp.Name = "radioButton_Title_Jp";
            radioButton_Title_Jp.Size = new System.Drawing.Size(142, 29);
            radioButton_Title_Jp.TabIndex = 2;
            radioButton_Title_Jp.Text = "Use Japanese";
            radioButton_Title_Jp.UseVisualStyleBackColor = true;
            radioButton_Title_Jp.CheckedChanged += UpdateGridEvent;
            // 
            // radioButton_Title_En
            // 
            radioButton_Title_En.AutoSize = true;
            radioButton_Title_En.Location = new System.Drawing.Point(12, 83);
            radioButton_Title_En.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            radioButton_Title_En.Name = "radioButton_Title_En";
            radioButton_Title_En.Size = new System.Drawing.Size(127, 29);
            radioButton_Title_En.TabIndex = 1;
            radioButton_Title_En.Text = "Use English";
            radioButton_Title_En.UseVisualStyleBackColor = true;
            radioButton_Title_En.CheckedChanged += UpdateGridEvent;
            // 
            // radioButton_Title_Title
            // 
            radioButton_Title_Title.AutoSize = true;
            radioButton_Title_Title.Checked = true;
            radioButton_Title_Title.Location = new System.Drawing.Point(12, 38);
            radioButton_Title_Title.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            radioButton_Title_Title.Name = "radioButton_Title_Title";
            radioButton_Title_Title.Size = new System.Drawing.Size(165, 29);
            radioButton_Title_Title.TabIndex = 0;
            radioButton_Title_Title.TabStop = true;
            radioButton_Title_Title.Text = "Use Default Title";
            radioButton_Title_Title.UseVisualStyleBackColor = true;
            radioButton_Title_Title.CheckedChanged += UpdateGridEvent;
            // 
            // textBox_Title_Default
            // 
            textBox_Title_Default.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBox_Title_Default.Location = new System.Drawing.Point(20, 843);
            textBox_Title_Default.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            textBox_Title_Default.Name = "textBox_Title_Default";
            textBox_Title_Default.Size = new System.Drawing.Size(624, 31);
            textBox_Title_Default.TabIndex = 12;
            textBox_Title_Default.TextChanged += UpdateGridEvent;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(20, 812);
            label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(106, 25);
            label3.TabIndex = 11;
            label3.Text = "Default Title";
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label4.Location = new System.Drawing.Point(20, 791);
            label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(675, 4);
            label4.TabIndex = 13;
            // 
            // textBox_Title_English
            // 
            textBox_Title_English.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBox_Title_English.Location = new System.Drawing.Point(20, 935);
            textBox_Title_English.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            textBox_Title_English.Name = "textBox_Title_English";
            textBox_Title_English.Size = new System.Drawing.Size(624, 31);
            textBox_Title_English.TabIndex = 15;
            textBox_Title_English.TextChanged += UpdateGridEvent;
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(20, 905);
            label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(105, 25);
            label5.TabIndex = 14;
            label5.Text = "English Title";
            // 
            // textBox_Title_Japanese
            // 
            textBox_Title_Japanese.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBox_Title_Japanese.Location = new System.Drawing.Point(20, 1028);
            textBox_Title_Japanese.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            textBox_Title_Japanese.Name = "textBox_Title_Japanese";
            textBox_Title_Japanese.Size = new System.Drawing.Size(624, 31);
            textBox_Title_Japanese.TabIndex = 17;
            textBox_Title_Japanese.TextChanged += UpdateGridEvent;
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(20, 997);
            label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(120, 25);
            label6.TabIndex = 16;
            label6.Text = "Japanese Title";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            groupBox2.Controls.Add(textBox_AddExtraToEpisodes);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(textBox_ReplaceInvalidCharacters);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(checkBox_BackupFiles);
            groupBox2.Controls.Add(textBox_StartingEpisode);
            groupBox2.Controls.Add(textBox_SectionDivider);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new System.Drawing.Point(1383, 576);
            groupBox2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            groupBox2.Size = new System.Drawing.Size(502, 469);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Advanced";
            // 
            // textBox_AddExtraToEpisodes
            // 
            textBox_AddExtraToEpisodes.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            textBox_AddExtraToEpisodes.Location = new System.Drawing.Point(192, 158);
            textBox_AddExtraToEpisodes.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            textBox_AddExtraToEpisodes.Name = "textBox_AddExtraToEpisodes";
            textBox_AddExtraToEpisodes.Size = new System.Drawing.Size(129, 31);
            textBox_AddExtraToEpisodes.TabIndex = 27;
            textBox_AddExtraToEpisodes.Text = "0";
            textBox_AddExtraToEpisodes.TextChanged += textBox_AddExtraToEpisodes_TextChanged;
            // 
            // label17
            // 
            label17.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label17.AutoSize = true;
            label17.Location = new System.Drawing.Point(192, 127);
            label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(266, 25);
            label17.TabIndex = 26;
            label17.Text = "Add Extra Numbers To Episodes";
            // 
            // textBox_ReplaceInvalidCharacters
            // 
            textBox_ReplaceInvalidCharacters.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            textBox_ReplaceInvalidCharacters.Location = new System.Drawing.Point(10, 248);
            textBox_ReplaceInvalidCharacters.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            textBox_ReplaceInvalidCharacters.Name = "textBox_ReplaceInvalidCharacters";
            textBox_ReplaceInvalidCharacters.Size = new System.Drawing.Size(129, 31);
            textBox_ReplaceInvalidCharacters.TabIndex = 25;
            textBox_ReplaceInvalidCharacters.TextChanged += UpdateGridEvent;
            // 
            // label11
            // 
            label11.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(10, 217);
            label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(258, 25);
            label11.TabIndex = 24;
            label11.Text = "Replace Invalid Characters With";
            // 
            // checkBox_BackupFiles
            // 
            checkBox_BackupFiles.AutoSize = true;
            checkBox_BackupFiles.Location = new System.Drawing.Point(10, 321);
            checkBox_BackupFiles.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            checkBox_BackupFiles.Name = "checkBox_BackupFiles";
            checkBox_BackupFiles.Size = new System.Drawing.Size(288, 29);
            checkBox_BackupFiles.TabIndex = 23;
            checkBox_BackupFiles.Text = "Create backup before renaming";
            checkBox_BackupFiles.UseVisualStyleBackColor = true;
            // 
            // textBox_StartingEpisode
            // 
            textBox_StartingEpisode.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            textBox_StartingEpisode.Location = new System.Drawing.Point(10, 158);
            textBox_StartingEpisode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            textBox_StartingEpisode.Name = "textBox_StartingEpisode";
            textBox_StartingEpisode.Size = new System.Drawing.Size(129, 31);
            textBox_StartingEpisode.TabIndex = 22;
            textBox_StartingEpisode.Text = "1";
            textBox_StartingEpisode.TextChanged += UpdateGridEvent;
            // 
            // textBox_SectionDivider
            // 
            textBox_SectionDivider.AccessibleDescription = "";
            textBox_SectionDivider.Location = new System.Drawing.Point(10, 62);
            textBox_SectionDivider.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            textBox_SectionDivider.Name = "textBox_SectionDivider";
            textBox_SectionDivider.Size = new System.Drawing.Size(129, 31);
            textBox_SectionDivider.TabIndex = 1;
            textBox_SectionDivider.Text = " - ";
            textBox_SectionDivider.TextChanged += UpdateGridEvent;
            // 
            // label9
            // 
            label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(10, 127);
            label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(141, 25);
            label9.TabIndex = 21;
            label9.Text = "Starting Episode";
            // 
            // label7
            // 
            label7.AccessibleDescription = "";
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(10, 31);
            label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(131, 25);
            label7.TabIndex = 0;
            label7.Text = "Section Divider";
            // 
            // checkBox_IncludeEpisode
            // 
            checkBox_IncludeEpisode.AutoSize = true;
            checkBox_IncludeEpisode.Checked = true;
            checkBox_IncludeEpisode.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBox_IncludeEpisode.Location = new System.Drawing.Point(12, 0);
            checkBox_IncludeEpisode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            checkBox_IncludeEpisode.Name = "checkBox_IncludeEpisode";
            checkBox_IncludeEpisode.Size = new System.Drawing.Size(101, 29);
            checkBox_IncludeEpisode.TabIndex = 24;
            checkBox_IncludeEpisode.Text = "Episode";
            checkBox_IncludeEpisode.UseVisualStyleBackColor = true;
            checkBox_IncludeEpisode.CheckedChanged += CheckBox_IncludeEpisode_CheckedChanged;
            // 
            // checkBox_IncludeSeason
            // 
            checkBox_IncludeSeason.AutoSize = true;
            checkBox_IncludeSeason.Checked = true;
            checkBox_IncludeSeason.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBox_IncludeSeason.Location = new System.Drawing.Point(12, 0);
            checkBox_IncludeSeason.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            checkBox_IncludeSeason.Name = "checkBox_IncludeSeason";
            checkBox_IncludeSeason.Size = new System.Drawing.Size(95, 29);
            checkBox_IncludeSeason.TabIndex = 23;
            checkBox_IncludeSeason.Text = "Season";
            checkBox_IncludeSeason.UseVisualStyleBackColor = true;
            checkBox_IncludeSeason.CheckedChanged += CheckBox_IncludeSeason_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            groupBox3.Controls.Add(radioButton_Episodes_None);
            groupBox3.Controls.Add(radioButton_Episodes_Jp);
            groupBox3.Controls.Add(radioButton_Episodes_En);
            groupBox3.Controls.Add(radioButton_Episodes_Default);
            groupBox3.Location = new System.Drawing.Point(1125, 816);
            groupBox3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            groupBox3.Size = new System.Drawing.Size(248, 229);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Episodes";
            // 
            // radioButton_Episodes_None
            // 
            radioButton_Episodes_None.AutoSize = true;
            radioButton_Episodes_None.Location = new System.Drawing.Point(12, 171);
            radioButton_Episodes_None.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            radioButton_Episodes_None.Name = "radioButton_Episodes_None";
            radioButton_Episodes_None.Size = new System.Drawing.Size(114, 29);
            radioButton_Episodes_None.TabIndex = 3;
            radioButton_Episodes_None.Text = "Omit Title";
            radioButton_Episodes_None.UseVisualStyleBackColor = true;
            radioButton_Episodes_None.CheckedChanged += UpdateGridEvent;
            // 
            // radioButton_Episodes_Jp
            // 
            radioButton_Episodes_Jp.AutoSize = true;
            radioButton_Episodes_Jp.Location = new System.Drawing.Point(12, 127);
            radioButton_Episodes_Jp.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            radioButton_Episodes_Jp.Name = "radioButton_Episodes_Jp";
            radioButton_Episodes_Jp.Size = new System.Drawing.Size(142, 29);
            radioButton_Episodes_Jp.TabIndex = 2;
            radioButton_Episodes_Jp.Text = "Use Japanese";
            radioButton_Episodes_Jp.UseVisualStyleBackColor = true;
            radioButton_Episodes_Jp.CheckedChanged += UpdateGridEvent;
            // 
            // radioButton_Episodes_En
            // 
            radioButton_Episodes_En.AutoSize = true;
            radioButton_Episodes_En.Location = new System.Drawing.Point(12, 83);
            radioButton_Episodes_En.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            radioButton_Episodes_En.Name = "radioButton_Episodes_En";
            radioButton_Episodes_En.Size = new System.Drawing.Size(127, 29);
            radioButton_Episodes_En.TabIndex = 1;
            radioButton_Episodes_En.Text = "Use English";
            radioButton_Episodes_En.UseVisualStyleBackColor = true;
            radioButton_Episodes_En.CheckedChanged += UpdateGridEvent;
            // 
            // radioButton_Episodes_Default
            // 
            radioButton_Episodes_Default.AutoSize = true;
            radioButton_Episodes_Default.Checked = true;
            radioButton_Episodes_Default.Location = new System.Drawing.Point(12, 38);
            radioButton_Episodes_Default.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            radioButton_Episodes_Default.Name = "radioButton_Episodes_Default";
            radioButton_Episodes_Default.Size = new System.Drawing.Size(165, 29);
            radioButton_Episodes_Default.TabIndex = 0;
            radioButton_Episodes_Default.TabStop = true;
            radioButton_Episodes_Default.Text = "Use Default Title";
            radioButton_Episodes_Default.UseVisualStyleBackColor = true;
            radioButton_Episodes_Default.CheckedChanged += UpdateGridEvent;
            // 
            // textBox_Season
            // 
            textBox_Season.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            textBox_Season.Location = new System.Drawing.Point(20, 1120);
            textBox_Season.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            textBox_Season.Name = "textBox_Season";
            textBox_Season.Size = new System.Drawing.Size(69, 31);
            textBox_Season.TabIndex = 20;
            textBox_Season.TextChanged += UpdateGridEvent;
            // 
            // label8
            // 
            label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(20, 1089);
            label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(69, 25);
            label8.TabIndex = 19;
            label8.Text = "Season";
            // 
            // groupBox4
            // 
            groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            groupBox4.Controls.Add(textBox_Season_Suffix);
            groupBox4.Controls.Add(checkBox_IncludeSeason);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(textBox_Season_Prefix);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(textBox_Season_Digits);
            groupBox4.Controls.Add(label10);
            groupBox4.Location = new System.Drawing.Point(1125, 1057);
            groupBox4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            groupBox4.Size = new System.Drawing.Size(445, 113);
            groupBox4.TabIndex = 21;
            groupBox4.TabStop = false;
            // 
            // textBox_Season_Suffix
            // 
            textBox_Season_Suffix.Location = new System.Drawing.Point(258, 62);
            textBox_Season_Suffix.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            textBox_Season_Suffix.Name = "textBox_Season_Suffix";
            textBox_Season_Suffix.Size = new System.Drawing.Size(171, 31);
            textBox_Season_Suffix.TabIndex = 30;
            textBox_Season_Suffix.TextChanged += UpdateGridEvent;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(258, 31);
            label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(56, 25);
            label13.TabIndex = 29;
            label13.Text = "Suffix";
            // 
            // textBox_Season_Prefix
            // 
            textBox_Season_Prefix.Location = new System.Drawing.Point(10, 62);
            textBox_Season_Prefix.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            textBox_Season_Prefix.Name = "textBox_Season_Prefix";
            textBox_Season_Prefix.Size = new System.Drawing.Size(171, 31);
            textBox_Season_Prefix.TabIndex = 28;
            textBox_Season_Prefix.Text = "S";
            textBox_Season_Prefix.TextChanged += UpdateGridEvent;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(10, 31);
            label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(55, 25);
            label12.TabIndex = 27;
            label12.Text = "Prefix";
            // 
            // textBox_Season_Digits
            // 
            textBox_Season_Digits.Location = new System.Drawing.Point(193, 62);
            textBox_Season_Digits.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            textBox_Season_Digits.Name = "textBox_Season_Digits";
            textBox_Season_Digits.Size = new System.Drawing.Size(52, 31);
            textBox_Season_Digits.TabIndex = 26;
            textBox_Season_Digits.Text = "00";
            textBox_Season_Digits.TextChanged += UpdateGridEvent;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(193, 31);
            label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(58, 25);
            label10.TabIndex = 25;
            label10.Text = "Digits";
            // 
            // groupBox5
            // 
            groupBox5.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            groupBox5.Controls.Add(checkBox_IncludeEpisode);
            groupBox5.Controls.Add(textBox_Episode_Suffix);
            groupBox5.Controls.Add(label14);
            groupBox5.Controls.Add(textBox_Episode_Prefix);
            groupBox5.Controls.Add(label15);
            groupBox5.Controls.Add(textBox_Episode_Digits);
            groupBox5.Controls.Add(label16);
            groupBox5.Location = new System.Drawing.Point(1125, 1182);
            groupBox5.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            groupBox5.Size = new System.Drawing.Size(445, 113);
            groupBox5.TabIndex = 31;
            groupBox5.TabStop = false;
            // 
            // textBox_Episode_Suffix
            // 
            textBox_Episode_Suffix.Location = new System.Drawing.Point(258, 62);
            textBox_Episode_Suffix.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            textBox_Episode_Suffix.Name = "textBox_Episode_Suffix";
            textBox_Episode_Suffix.Size = new System.Drawing.Size(171, 31);
            textBox_Episode_Suffix.TabIndex = 30;
            textBox_Episode_Suffix.TextChanged += UpdateGridEvent;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(258, 31);
            label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(56, 25);
            label14.TabIndex = 29;
            label14.Text = "Suffix";
            // 
            // textBox_Episode_Prefix
            // 
            textBox_Episode_Prefix.Location = new System.Drawing.Point(10, 62);
            textBox_Episode_Prefix.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            textBox_Episode_Prefix.Name = "textBox_Episode_Prefix";
            textBox_Episode_Prefix.Size = new System.Drawing.Size(171, 31);
            textBox_Episode_Prefix.TabIndex = 28;
            textBox_Episode_Prefix.Text = "E";
            textBox_Episode_Prefix.TextChanged += UpdateGridEvent;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(10, 31);
            label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(55, 25);
            label15.TabIndex = 27;
            label15.Text = "Prefix";
            // 
            // textBox_Episode_Digits
            // 
            textBox_Episode_Digits.Location = new System.Drawing.Point(193, 62);
            textBox_Episode_Digits.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            textBox_Episode_Digits.Name = "textBox_Episode_Digits";
            textBox_Episode_Digits.Size = new System.Drawing.Size(52, 31);
            textBox_Episode_Digits.TabIndex = 26;
            textBox_Episode_Digits.Text = "00";
            textBox_Episode_Digits.TextChanged += UpdateGridEvent;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(193, 31);
            label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(58, 25);
            label16.TabIndex = 25;
            label16.Text = "Digits";
            // 
            // button_Refresh
            // 
            button_Refresh.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            button_Refresh.Location = new System.Drawing.Point(1580, 1120);
            button_Refresh.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            button_Refresh.Name = "button_Refresh";
            button_Refresh.Size = new System.Drawing.Size(305, 60);
            button_Refresh.TabIndex = 32;
            button_Refresh.Text = "Refresh Preview";
            button_Refresh.UseVisualStyleBackColor = true;
            button_Refresh.Click += UpdateGridEvent;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            pictureBox1.Location = new System.Drawing.Point(740, 576);
            pictureBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(375, 594);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += PictureBox1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, presetsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            menuStrip1.Size = new System.Drawing.Size(1907, 37);
            menuStrip1.TabIndex = 33;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(141, 34);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // presetsToolStripMenuItem
            // 
            presetsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { seriesS00E00ToolStripMenuItem, seriesS00E00EpisodeTitleToolStripMenuItem, seriesS00E00ToolStripMenuItem1, seriesS00E00EpisodeTitleToolStripMenuItem1, episodeTitleToolStripMenuItem });
            presetsToolStripMenuItem.Name = "presetsToolStripMenuItem";
            presetsToolStripMenuItem.Size = new System.Drawing.Size(84, 29);
            presetsToolStripMenuItem.Text = "&Presets";
            // 
            // seriesS00E00ToolStripMenuItem
            // 
            seriesS00E00ToolStripMenuItem.Name = "seriesS00E00ToolStripMenuItem";
            seriesS00E00ToolStripMenuItem.Size = new System.Drawing.Size(353, 34);
            seriesS00E00ToolStripMenuItem.Text = "Series - S00E00";
            seriesS00E00ToolStripMenuItem.Click += SeriesS00E00ToolStripMenuItem_Click;
            // 
            // seriesS00E00EpisodeTitleToolStripMenuItem
            // 
            seriesS00E00EpisodeTitleToolStripMenuItem.Name = "seriesS00E00EpisodeTitleToolStripMenuItem";
            seriesS00E00EpisodeTitleToolStripMenuItem.Size = new System.Drawing.Size(353, 34);
            seriesS00E00EpisodeTitleToolStripMenuItem.Text = "Series - S00E00 - Episode Title";
            seriesS00E00EpisodeTitleToolStripMenuItem.Click += SeriesS00E00EpisodeTitleToolStripMenuItem_Click;
            // 
            // seriesS00E00ToolStripMenuItem1
            // 
            seriesS00E00ToolStripMenuItem1.Name = "seriesS00E00ToolStripMenuItem1";
            seriesS00E00ToolStripMenuItem1.Size = new System.Drawing.Size(353, 34);
            seriesS00E00ToolStripMenuItem1.Text = "Series [S00E00]";
            seriesS00E00ToolStripMenuItem1.Click += SeriesS00E00ToolStripMenuItem1_Click;
            // 
            // seriesS00E00EpisodeTitleToolStripMenuItem1
            // 
            seriesS00E00EpisodeTitleToolStripMenuItem1.Name = "seriesS00E00EpisodeTitleToolStripMenuItem1";
            seriesS00E00EpisodeTitleToolStripMenuItem1.Size = new System.Drawing.Size(353, 34);
            seriesS00E00EpisodeTitleToolStripMenuItem1.Text = "Series [S00E00] Episode Title";
            seriesS00E00EpisodeTitleToolStripMenuItem1.Click += SeriesS00E00EpisodeTitleToolStripMenuItem1_Click;
            // 
            // episodeTitleToolStripMenuItem
            // 
            episodeTitleToolStripMenuItem.Name = "episodeTitleToolStripMenuItem";
            episodeTitleToolStripMenuItem.Size = new System.Drawing.Size(353, 34);
            episodeTitleToolStripMenuItem.Text = "00 - Episode Title";
            episodeTitleToolStripMenuItem.Click += EpisodeTitleToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { projectGitHubToolStripMenuItem, reportABugToolStripMenuItem, checkForUpdatesToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // projectGitHubToolStripMenuItem
            // 
            projectGitHubToolStripMenuItem.Name = "projectGitHubToolStripMenuItem";
            projectGitHubToolStripMenuItem.Size = new System.Drawing.Size(263, 34);
            projectGitHubToolStripMenuItem.Text = "Project GitHub";
            projectGitHubToolStripMenuItem.Click += ProjectGitHubToolStripMenuItem_Click;
            // 
            // reportABugToolStripMenuItem
            // 
            reportABugToolStripMenuItem.Name = "reportABugToolStripMenuItem";
            reportABugToolStripMenuItem.Size = new System.Drawing.Size(263, 34);
            reportABugToolStripMenuItem.Text = "Report A Bug";
            reportABugToolStripMenuItem.Click += ReportABugToolStripMenuItem_Click;
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(263, 34);
            checkForUpdatesToolStripMenuItem.Text = "Check For &Updates";
            checkForUpdatesToolStripMenuItem.Click += CheckForUpdatesToolStripMenuItem_Click;
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1907, 1320);
            Controls.Add(groupBox5);
            Controls.Add(button_Refresh);
            Controls.Add(groupBox4);
            Controls.Add(textBox_Season);
            Controls.Add(label8);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(textBox_Title_Japanese);
            Controls.Add(label6);
            Controls.Add(textBox_Title_English);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox_Title_Default);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(button_Rename);
            Controls.Add(button_GetAnimeInfo);
            Controls.Add(textBox_AnimeID);
            Controls.Add(label2);
            Controls.Add(button_SourceFolder);
            Controls.Add(textBox_SourceFolder);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            MinimumSize = new System.Drawing.Size(1929, 910);
            Name = "Form_Main";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "MAL Renamer";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Current;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_SourceFolder;
        private System.Windows.Forms.Button button_SourceFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox textBox_AnimeID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_GetAnimeInfo;
        private System.Windows.Forms.Button button_Rename;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_Title_None;
        private System.Windows.Forms.RadioButton radioButton_Title_Jp;
        private System.Windows.Forms.RadioButton radioButton_Title_En;
        private System.Windows.Forms.RadioButton radioButton_Title_Title;
        private System.Windows.Forms.TextBox textBox_Title_Default;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Title_English;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Title_Japanese;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_SectionDivider;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_StartingEpisode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton_Episodes_None;
        private System.Windows.Forms.RadioButton radioButton_Episodes_Jp;
        private System.Windows.Forms.RadioButton radioButton_Episodes_En;
        private System.Windows.Forms.RadioButton radioButton_Episodes_Default;
        private System.Windows.Forms.TextBox textBox_Season;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox_Season_Suffix;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_Season_Prefix;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_Season_Digits;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox_Episode_Suffix;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_Episode_Prefix;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_Episode_Digits;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.CheckBox checkBox_IncludeEpisode;
        private System.Windows.Forms.CheckBox checkBox_IncludeSeason;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seriesS00E00ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seriesS00E00EpisodeTitleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seriesS00E00ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem seriesS00E00EpisodeTitleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem episodeTitleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectGitHubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportABugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox_BackupFiles;
        private System.Windows.Forms.TextBox textBox_ReplaceInvalidCharacters;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_AddExtraToEpisodes;
        private System.Windows.Forms.Label label17;
    }
}

