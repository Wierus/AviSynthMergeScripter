namespace AviSynthMergeScripter {

    public partial class MainForm {

        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">
        /// Истинно, если управляемый ресурс должен быть удален; иначе ложно.
        /// </param>
        protected override void Dispose(bool disposing) {
            if (disposing && (this.components != null)) {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rootFolderPathGroupBox = new System.Windows.Forms.GroupBox();
            this.rootFolderPathTextBox = new System.Windows.Forms.TextBox();
            this.rootFolderPathBrowseButton = new System.Windows.Forms.Button();
            this.pathesTreeGroupBox = new System.Windows.Forms.GroupBox();
            this.pathesTreeView = new System.Windows.Forms.TreeView();
            this.aviSynthSettingsRadioButton = new System.Windows.Forms.RadioButton();
            this.x264CodecSettingsRadioButton = new System.Windows.Forms.RadioButton();
            this.videoFilePropertiesReaderSettingsRadioButton = new System.Windows.Forms.RadioButton();
            this.aviSynthSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.aviSynthSettingsShowFilesLabel = new System.Windows.Forms.Label();
            this.aviSynthSettingsShowFilesComboBox = new System.Windows.Forms.ComboBox();
            this.aviSynthSettingsSearchPatternLabel = new System.Windows.Forms.Label();
            this.aviSynthSettingsSearchPatternСomboBox = new System.Windows.Forms.ComboBox();
            this.aviSynthSettingsNoteLabel = new System.Windows.Forms.Label();
            this.aviSynthSettingsLoadingPluginLabel = new System.Windows.Forms.Label();
            this.aviSynthSettingsLoadingPluginComboBox = new System.Windows.Forms.ComboBox();
            this.aviSynthSettingsCompressRatioLabel = new System.Windows.Forms.Label();
            this.aviSynthSettingsCompressRatioComboBox = new System.Windows.Forms.ComboBox();
            this.aviSynthSettingsOutputFPSLabel = new System.Windows.Forms.Label();
            this.aviSynthSettingsOutputFPSComboBox = new System.Windows.Forms.ComboBox();
            this.aviSynthSettingsOutputFolderPathLabel = new System.Windows.Forms.Label();
            this.aviSynthSettingsOutputFolderPathTextBox = new System.Windows.Forms.TextBox();
            this.aviSynthSettingsOutputFolderPathBrowseButton = new System.Windows.Forms.Button();
            this.aviSynthSettingsCreateScriptsButton = new System.Windows.Forms.Button();
            this.x264CodecSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.x264CodecSettingsShowFilesLabel = new System.Windows.Forms.Label();
            this.x264CodecSettingsShowFilesComboBox = new System.Windows.Forms.ComboBox();
            this.x264CodecSettingsSearchPatternLabel = new System.Windows.Forms.Label();
            this.x264CodecSettingsSearchPatternComboBox = new System.Windows.Forms.ComboBox();
            this.x264CodecSettingsNoteLabel = new System.Windows.Forms.Label();
            this.x264CodecSettingsCodecPathLabel = new System.Windows.Forms.Label();
            this.x264CodecSettingsCodecPathComboBox = new System.Windows.Forms.ComboBox();
            this.x264CodecSettingsStandardStreamsUseModeLabel = new System.Windows.Forms.Label();
            this.x264CodecSettingsStandardStreamsUseModeComboBox = new System.Windows.Forms.ComboBox();
            this.x264CodecSettingsCodecOptionsLabel = new System.Windows.Forms.Label();
            this.x264CodecSettingsCodecOptionsComboBox = new System.Windows.Forms.ComboBox();
            this.x264CodecSettingsOutputFileExtensionLabel = new System.Windows.Forms.Label();
            this.x264CodecSettingsOutputFileExtensionComboBox = new System.Windows.Forms.ComboBox();
            this.x264CodecSettingsOutputFolderPathLabel = new System.Windows.Forms.Label();
            this.x264CodecSettingsOutputFolderPathTextBox = new System.Windows.Forms.TextBox();
            this.x264CodecSettingsOutputFolderPathBrowseButton = new System.Windows.Forms.Button();
            this.x264CodecSettingsEncodeFilesButton = new System.Windows.Forms.Button();
            this.x264CodecSettingsStatusLabel = new System.Windows.Forms.Label();
            this.videoFilePropertiesReaderSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.videoFilePropertiesReaderSettingsShowFilesLabel = new System.Windows.Forms.Label();
            this.videoFilePropertiesReaderSettingsShowFilesComboBox = new System.Windows.Forms.ComboBox();
            this.videoFilePropertiesReaderSettingsSearchPatternLabel = new System.Windows.Forms.Label();
            this.videoFilePropertiesReaderSettingsSearchPatternComboBox = new System.Windows.Forms.ComboBox();
            this.videoFilePropertiesReaderSettingsNoteLabel = new System.Windows.Forms.Label();
            this.videoFilePropertiesReaderSettingsReaderPathLabel = new System.Windows.Forms.Label();
            this.videoFilePropertiesReaderSettingsReaderPathComboBox = new System.Windows.Forms.ComboBox();
            this.videoFilePropertiesReaderSettingsStandardStreamsUseModeLabel = new System.Windows.Forms.Label();
            this.videoFilePropertiesReaderSettingsStandardStreamsUseModeComboBox = new System.Windows.Forms.ComboBox();
            this.videoFilePropertiesReaderSettingsReadPropertiesButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.videoFilesTableAdapter = new AviSynthMergeScripter.VideoFilesPropertiesDataSetTableAdapters.VideoFilesTableAdapter();
            this.videoFilePropertiesReaderSettingsStatusLabel = new System.Windows.Forms.Label();
            this.videoFilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pathesTreeStatusLabel = new System.Windows.Forms.Label();
            this.rootFolderPathGroupBox.SuspendLayout();
            this.pathesTreeGroupBox.SuspendLayout();
            this.aviSynthSettingsGroupBox.SuspendLayout();
            this.x264CodecSettingsGroupBox.SuspendLayout();
            this.videoFilePropertiesReaderSettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoFilesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rootFolderPathGroupBox
            // 
            this.rootFolderPathGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rootFolderPathGroupBox.Controls.Add(this.rootFolderPathTextBox);
            this.rootFolderPathGroupBox.Controls.Add(this.rootFolderPathBrowseButton);
            this.rootFolderPathGroupBox.Location = new System.Drawing.Point(12, 12);
            this.rootFolderPathGroupBox.Name = "rootFolderPathGroupBox";
            this.rootFolderPathGroupBox.Size = new System.Drawing.Size(879, 41);
            this.rootFolderPathGroupBox.TabIndex = 0;
            this.rootFolderPathGroupBox.TabStop = false;
            this.rootFolderPathGroupBox.Text = "Корневая папка";
            // 
            // rootFolderPathTextBox
            // 
            this.rootFolderPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rootFolderPathTextBox.Location = new System.Drawing.Point(4, 17);
            this.rootFolderPathTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.rootFolderPathTextBox.Name = "rootFolderPathTextBox";
            this.rootFolderPathTextBox.Size = new System.Drawing.Size(844, 20);
            this.rootFolderPathTextBox.TabIndex = 0;
            this.rootFolderPathTextBox.TextChanged += new System.EventHandler(this.rootFolderPathTextBox_TextChanged);
            // 
            // rootFolderPathBrowseButton
            // 
            this.rootFolderPathBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rootFolderPathBrowseButton.Location = new System.Drawing.Point(850, 17);
            this.rootFolderPathBrowseButton.Margin = new System.Windows.Forms.Padding(1);
            this.rootFolderPathBrowseButton.Name = "rootFolderPathBrowseButton";
            this.rootFolderPathBrowseButton.Size = new System.Drawing.Size(25, 20);
            this.rootFolderPathBrowseButton.TabIndex = 1;
            this.rootFolderPathBrowseButton.Text = "...";
            this.rootFolderPathBrowseButton.UseVisualStyleBackColor = true;
            this.rootFolderPathBrowseButton.Click += new System.EventHandler(this.rootFolderPathBrowseButton_Click);
            // 
            // pathesTreeGroupBox
            // 
            this.pathesTreeGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pathesTreeGroupBox.Controls.Add(this.pathesTreeStatusLabel);
            this.pathesTreeGroupBox.Controls.Add(this.pathesTreeView);
            this.pathesTreeGroupBox.Location = new System.Drawing.Point(12, 63);
            this.pathesTreeGroupBox.Name = "pathesTreeGroupBox";
            this.pathesTreeGroupBox.Size = new System.Drawing.Size(308, 462);
            this.pathesTreeGroupBox.TabIndex = 1;
            this.pathesTreeGroupBox.TabStop = false;
            this.pathesTreeGroupBox.Text = "Дерево подпапок";
            // 
            // pathesTreeView
            // 
            this.pathesTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathesTreeView.CheckBoxes = true;
            this.pathesTreeView.HotTracking = true;
            this.pathesTreeView.Location = new System.Drawing.Point(4, 17);
            this.pathesTreeView.Margin = new System.Windows.Forms.Padding(1);
            this.pathesTreeView.Name = "pathesTreeView";
            this.pathesTreeView.ShowNodeToolTips = true;
            this.pathesTreeView.Size = new System.Drawing.Size(300, 428);
            this.pathesTreeView.TabIndex = 0;
            this.pathesTreeView.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.pathesTreeView_AfterCheck);
            // 
            // aviSynthSettingsRadioButton
            // 
            this.aviSynthSettingsRadioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.aviSynthSettingsRadioButton.Location = new System.Drawing.Point(326, 63);
            this.aviSynthSettingsRadioButton.Name = "aviSynthSettingsRadioButton";
            this.aviSynthSettingsRadioButton.Size = new System.Drawing.Size(25, 156);
            this.aviSynthSettingsRadioButton.TabIndex = 2;
            this.aviSynthSettingsRadioButton.TabStop = true;
            this.aviSynthSettingsRadioButton.UseVisualStyleBackColor = true;
            this.aviSynthSettingsRadioButton.CheckedChanged += new System.EventHandler(this.aviSynthSettingsRadioButton_CheckedChanged);
            this.aviSynthSettingsRadioButton.MouseEnter += new System.EventHandler(this.aviSynthSettingsRadioButton_MouseEnter);
            this.aviSynthSettingsRadioButton.MouseLeave += new System.EventHandler(this.aviSynthSettingsRadioButton_MouseLeave);
            // 
            // x264CodecSettingsRadioButton
            // 
            this.x264CodecSettingsRadioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.x264CodecSettingsRadioButton.Location = new System.Drawing.Point(326, 225);
            this.x264CodecSettingsRadioButton.Name = "x264CodecSettingsRadioButton";
            this.x264CodecSettingsRadioButton.Size = new System.Drawing.Size(25, 181);
            this.x264CodecSettingsRadioButton.TabIndex = 3;
            this.x264CodecSettingsRadioButton.TabStop = true;
            this.x264CodecSettingsRadioButton.UseVisualStyleBackColor = true;
            this.x264CodecSettingsRadioButton.CheckedChanged += new System.EventHandler(this.x264CodecSettingsRadioButton_CheckedChanged);
            this.x264CodecSettingsRadioButton.MouseEnter += new System.EventHandler(this.x264CodecSettingsRadioButton_MouseEnter);
            this.x264CodecSettingsRadioButton.MouseLeave += new System.EventHandler(this.x264CodecSettingsRadioButton_MouseLeave);
            // 
            // videoFilePropertiesReaderSettingsRadioButton
            // 
            this.videoFilePropertiesReaderSettingsRadioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.videoFilePropertiesReaderSettingsRadioButton.Location = new System.Drawing.Point(326, 412);
            this.videoFilePropertiesReaderSettingsRadioButton.Name = "videoFilePropertiesReaderSettingsRadioButton";
            this.videoFilePropertiesReaderSettingsRadioButton.Size = new System.Drawing.Size(25, 113);
            this.videoFilePropertiesReaderSettingsRadioButton.TabIndex = 4;
            this.videoFilePropertiesReaderSettingsRadioButton.TabStop = true;
            this.videoFilePropertiesReaderSettingsRadioButton.UseVisualStyleBackColor = true;
            this.videoFilePropertiesReaderSettingsRadioButton.CheckedChanged += new System.EventHandler(this.videoFilePropertiesReaderSettingsRadioButton_CheckedChanged);
            this.videoFilePropertiesReaderSettingsRadioButton.MouseEnter += new System.EventHandler(this.videoFilePropertiesReaderSettingsRadioButton_MouseEnter);
            this.videoFilePropertiesReaderSettingsRadioButton.MouseLeave += new System.EventHandler(this.videoFilePropertiesReaderSettingsRadioButton_MouseLeave);
            // 
            // aviSynthSettingsGroupBox
            // 
            this.aviSynthSettingsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aviSynthSettingsGroupBox.Controls.Add(this.aviSynthSettingsShowFilesLabel);
            this.aviSynthSettingsGroupBox.Controls.Add(this.aviSynthSettingsShowFilesComboBox);
            this.aviSynthSettingsGroupBox.Controls.Add(this.aviSynthSettingsSearchPatternLabel);
            this.aviSynthSettingsGroupBox.Controls.Add(this.aviSynthSettingsSearchPatternСomboBox);
            this.aviSynthSettingsGroupBox.Controls.Add(this.aviSynthSettingsNoteLabel);
            this.aviSynthSettingsGroupBox.Controls.Add(this.aviSynthSettingsLoadingPluginLabel);
            this.aviSynthSettingsGroupBox.Controls.Add(this.aviSynthSettingsLoadingPluginComboBox);
            this.aviSynthSettingsGroupBox.Controls.Add(this.aviSynthSettingsCompressRatioLabel);
            this.aviSynthSettingsGroupBox.Controls.Add(this.aviSynthSettingsCompressRatioComboBox);
            this.aviSynthSettingsGroupBox.Controls.Add(this.aviSynthSettingsOutputFPSLabel);
            this.aviSynthSettingsGroupBox.Controls.Add(this.aviSynthSettingsOutputFPSComboBox);
            this.aviSynthSettingsGroupBox.Controls.Add(this.aviSynthSettingsOutputFolderPathLabel);
            this.aviSynthSettingsGroupBox.Controls.Add(this.aviSynthSettingsOutputFolderPathTextBox);
            this.aviSynthSettingsGroupBox.Controls.Add(this.aviSynthSettingsOutputFolderPathBrowseButton);
            this.aviSynthSettingsGroupBox.Controls.Add(this.aviSynthSettingsCreateScriptsButton);
            this.aviSynthSettingsGroupBox.Location = new System.Drawing.Point(357, 63);
            this.aviSynthSettingsGroupBox.Name = "aviSynthSettingsGroupBox";
            this.aviSynthSettingsGroupBox.Size = new System.Drawing.Size(534, 156);
            this.aviSynthSettingsGroupBox.TabIndex = 5;
            this.aviSynthSettingsGroupBox.TabStop = false;
            this.aviSynthSettingsGroupBox.Text = "Настройки для скриптов AviSynth";
            // 
            // aviSynthSettingsShowFilesLabel
            // 
            this.aviSynthSettingsShowFilesLabel.AutoSize = true;
            this.aviSynthSettingsShowFilesLabel.Location = new System.Drawing.Point(29, 20);
            this.aviSynthSettingsShowFilesLabel.Name = "aviSynthSettingsShowFilesLabel";
            this.aviSynthSettingsShowFilesLabel.Size = new System.Drawing.Size(110, 13);
            this.aviSynthSettingsShowFilesLabel.TabIndex = 0;
            this.aviSynthSettingsShowFilesLabel.Text = "Показывать файлы:";
            // 
            // aviSynthSettingsShowFilesComboBox
            // 
            this.aviSynthSettingsShowFilesComboBox.DisplayMember = "DisplayMember";
            this.aviSynthSettingsShowFilesComboBox.IntegralHeight = false;
            this.aviSynthSettingsShowFilesComboBox.ItemHeight = 13;
            this.aviSynthSettingsShowFilesComboBox.Location = new System.Drawing.Point(143, 17);
            this.aviSynthSettingsShowFilesComboBox.Margin = new System.Windows.Forms.Padding(1);
            this.aviSynthSettingsShowFilesComboBox.Name = "aviSynthSettingsShowFilesComboBox";
            this.aviSynthSettingsShowFilesComboBox.Size = new System.Drawing.Size(75, 21);
            this.aviSynthSettingsShowFilesComboBox.TabIndex = 1;
            this.aviSynthSettingsShowFilesComboBox.ValueMember = "ValueMember";
            this.aviSynthSettingsShowFilesComboBox.SelectedValueChanged += new System.EventHandler(this.aviSynthSettingsShowFilesComboBox_SelectedValueChanged);
            // 
            // aviSynthSettingsSearchPatternLabel
            // 
            this.aviSynthSettingsSearchPatternLabel.AutoSize = true;
            this.aviSynthSettingsSearchPatternLabel.Location = new System.Drawing.Point(222, 20);
            this.aviSynthSettingsSearchPatternLabel.Name = "aviSynthSettingsSearchPatternLabel";
            this.aviSynthSettingsSearchPatternLabel.Size = new System.Drawing.Size(138, 13);
            this.aviSynthSettingsSearchPatternLabel.TabIndex = 2;
            this.aviSynthSettingsSearchPatternLabel.Text = "Обрабатываемые файлы:";
            // 
            // aviSynthSettingsSearchPatternСomboBox
            // 
            this.aviSynthSettingsSearchPatternСomboBox.DisplayMember = "DisplayMember";
            this.aviSynthSettingsSearchPatternСomboBox.IntegralHeight = false;
            this.aviSynthSettingsSearchPatternСomboBox.ItemHeight = 13;
            this.aviSynthSettingsSearchPatternСomboBox.Location = new System.Drawing.Point(364, 17);
            this.aviSynthSettingsSearchPatternСomboBox.Margin = new System.Windows.Forms.Padding(1);
            this.aviSynthSettingsSearchPatternСomboBox.Name = "aviSynthSettingsSearchPatternСomboBox";
            this.aviSynthSettingsSearchPatternСomboBox.Size = new System.Drawing.Size(75, 21);
            this.aviSynthSettingsSearchPatternСomboBox.TabIndex = 3;
            this.aviSynthSettingsSearchPatternСomboBox.ValueMember = "ValueMember";
            this.aviSynthSettingsSearchPatternСomboBox.SelectedValueChanged += new System.EventHandler(this.aviSynthSettingsSearchPatternСomboBox_SelectedValueChanged);
            // 
            // aviSynthSettingsNoteLabel
            // 
            this.aviSynthSettingsNoteLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aviSynthSettingsNoteLabel.AutoSize = true;
            this.aviSynthSettingsNoteLabel.Location = new System.Drawing.Point(447, 20);
            this.aviSynthSettingsNoteLabel.Name = "aviSynthSettingsNoteLabel";
            this.aviSynthSettingsNoteLabel.Size = new System.Drawing.Size(81, 13);
            this.aviSynthSettingsNoteLabel.TabIndex = 4;
            this.aviSynthSettingsNoteLabel.Text = "(только папки)";
            // 
            // aviSynthSettingsLoadingPluginLabel
            // 
            this.aviSynthSettingsLoadingPluginLabel.AutoSize = true;
            this.aviSynthSettingsLoadingPluginLabel.Location = new System.Drawing.Point(18, 43);
            this.aviSynthSettingsLoadingPluginLabel.Name = "aviSynthSettingsLoadingPluginLabel";
            this.aviSynthSettingsLoadingPluginLabel.Size = new System.Drawing.Size(121, 13);
            this.aviSynthSettingsLoadingPluginLabel.TabIndex = 5;
            this.aviSynthSettingsLoadingPluginLabel.Text = "Загружаемый модуль:";
            // 
            // aviSynthSettingsLoadingPluginComboBox
            // 
            this.aviSynthSettingsLoadingPluginComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aviSynthSettingsLoadingPluginComboBox.DisplayMember = "DisplayMember";
            this.aviSynthSettingsLoadingPluginComboBox.IntegralHeight = false;
            this.aviSynthSettingsLoadingPluginComboBox.ItemHeight = 13;
            this.aviSynthSettingsLoadingPluginComboBox.Location = new System.Drawing.Point(143, 40);
            this.aviSynthSettingsLoadingPluginComboBox.Margin = new System.Windows.Forms.Padding(1);
            this.aviSynthSettingsLoadingPluginComboBox.Name = "aviSynthSettingsLoadingPluginComboBox";
            this.aviSynthSettingsLoadingPluginComboBox.Size = new System.Drawing.Size(387, 21);
            this.aviSynthSettingsLoadingPluginComboBox.TabIndex = 6;
            this.aviSynthSettingsLoadingPluginComboBox.ValueMember = "ValueMember";
            this.aviSynthSettingsLoadingPluginComboBox.SelectedValueChanged += new System.EventHandler(this.aviSynthSettingsLoadingPluginComboBox_SelectedValueChanged);
            // 
            // aviSynthSettingsCompressRatioLabel
            // 
            this.aviSynthSettingsCompressRatioLabel.AutoSize = true;
            this.aviSynthSettingsCompressRatioLabel.Location = new System.Drawing.Point(19, 66);
            this.aviSynthSettingsCompressRatioLabel.Name = "aviSynthSettingsCompressRatioLabel";
            this.aviSynthSettingsCompressRatioLabel.Size = new System.Drawing.Size(120, 13);
            this.aviSynthSettingsCompressRatioLabel.TabIndex = 7;
            this.aviSynthSettingsCompressRatioLabel.Text = "Коэффициент сжатия:";
            // 
            // aviSynthSettingsCompressRatioComboBox
            // 
            this.aviSynthSettingsCompressRatioComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aviSynthSettingsCompressRatioComboBox.DisplayMember = "DisplayMember";
            this.aviSynthSettingsCompressRatioComboBox.IntegralHeight = false;
            this.aviSynthSettingsCompressRatioComboBox.ItemHeight = 13;
            this.aviSynthSettingsCompressRatioComboBox.Location = new System.Drawing.Point(143, 63);
            this.aviSynthSettingsCompressRatioComboBox.Margin = new System.Windows.Forms.Padding(1);
            this.aviSynthSettingsCompressRatioComboBox.Name = "aviSynthSettingsCompressRatioComboBox";
            this.aviSynthSettingsCompressRatioComboBox.Size = new System.Drawing.Size(387, 21);
            this.aviSynthSettingsCompressRatioComboBox.TabIndex = 8;
            this.aviSynthSettingsCompressRatioComboBox.ValueMember = "ValueMember";
            this.aviSynthSettingsCompressRatioComboBox.SelectedValueChanged += new System.EventHandler(this.aviSynthSettingsCompressRatioComboBox_SelectedValueChanged);
            // 
            // aviSynthSettingsOutputFPSLabel
            // 
            this.aviSynthSettingsOutputFPSLabel.AutoSize = true;
            this.aviSynthSettingsOutputFPSLabel.Location = new System.Drawing.Point(6, 89);
            this.aviSynthSettingsOutputFPSLabel.Name = "aviSynthSettingsOutputFPSLabel";
            this.aviSynthSettingsOutputFPSLabel.Size = new System.Drawing.Size(133, 13);
            this.aviSynthSettingsOutputFPSLabel.TabIndex = 9;
            this.aviSynthSettingsOutputFPSLabel.Text = "Выходное значение FPS:";
            // 
            // aviSynthSettingsOutputFPSComboBox
            // 
            this.aviSynthSettingsOutputFPSComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aviSynthSettingsOutputFPSComboBox.DisplayMember = "DisplayMember";
            this.aviSynthSettingsOutputFPSComboBox.IntegralHeight = false;
            this.aviSynthSettingsOutputFPSComboBox.ItemHeight = 13;
            this.aviSynthSettingsOutputFPSComboBox.Location = new System.Drawing.Point(143, 86);
            this.aviSynthSettingsOutputFPSComboBox.Margin = new System.Windows.Forms.Padding(1);
            this.aviSynthSettingsOutputFPSComboBox.Name = "aviSynthSettingsOutputFPSComboBox";
            this.aviSynthSettingsOutputFPSComboBox.Size = new System.Drawing.Size(387, 21);
            this.aviSynthSettingsOutputFPSComboBox.TabIndex = 10;
            this.aviSynthSettingsOutputFPSComboBox.ValueMember = "ValueMember";
            this.aviSynthSettingsOutputFPSComboBox.SelectedValueChanged += new System.EventHandler(this.aviSynthSettingsOutputFPSComboBox_SelectedValueChanged);
            // 
            // aviSynthSettingsOutputFolderPathLabel
            // 
            this.aviSynthSettingsOutputFolderPathLabel.AutoSize = true;
            this.aviSynthSettingsOutputFolderPathLabel.Location = new System.Drawing.Point(46, 112);
            this.aviSynthSettingsOutputFolderPathLabel.Name = "aviSynthSettingsOutputFolderPathLabel";
            this.aviSynthSettingsOutputFolderPathLabel.Size = new System.Drawing.Size(93, 13);
            this.aviSynthSettingsOutputFolderPathLabel.TabIndex = 11;
            this.aviSynthSettingsOutputFolderPathLabel.Text = "Выходная папка:";
            // 
            // aviSynthSettingsOutputFolderPathTextBox
            // 
            this.aviSynthSettingsOutputFolderPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aviSynthSettingsOutputFolderPathTextBox.Location = new System.Drawing.Point(143, 109);
            this.aviSynthSettingsOutputFolderPathTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.aviSynthSettingsOutputFolderPathTextBox.Name = "aviSynthSettingsOutputFolderPathTextBox";
            this.aviSynthSettingsOutputFolderPathTextBox.Size = new System.Drawing.Size(360, 20);
            this.aviSynthSettingsOutputFolderPathTextBox.TabIndex = 12;
            // 
            // aviSynthSettingsOutputFolderPathBrowseButton
            // 
            this.aviSynthSettingsOutputFolderPathBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aviSynthSettingsOutputFolderPathBrowseButton.Location = new System.Drawing.Point(505, 109);
            this.aviSynthSettingsOutputFolderPathBrowseButton.Margin = new System.Windows.Forms.Padding(1);
            this.aviSynthSettingsOutputFolderPathBrowseButton.Name = "aviSynthSettingsOutputFolderPathBrowseButton";
            this.aviSynthSettingsOutputFolderPathBrowseButton.Size = new System.Drawing.Size(25, 20);
            this.aviSynthSettingsOutputFolderPathBrowseButton.TabIndex = 13;
            this.aviSynthSettingsOutputFolderPathBrowseButton.Text = "...";
            this.aviSynthSettingsOutputFolderPathBrowseButton.UseVisualStyleBackColor = true;
            this.aviSynthSettingsOutputFolderPathBrowseButton.Click += new System.EventHandler(this.aviSynthSettingsOutputFolderPathBrowseButton_Click);
            // 
            // aviSynthSettingsCreateScriptsButton
            // 
            this.aviSynthSettingsCreateScriptsButton.Location = new System.Drawing.Point(143, 131);
            this.aviSynthSettingsCreateScriptsButton.Margin = new System.Windows.Forms.Padding(1);
            this.aviSynthSettingsCreateScriptsButton.Name = "aviSynthSettingsCreateScriptsButton";
            this.aviSynthSettingsCreateScriptsButton.Size = new System.Drawing.Size(150, 21);
            this.aviSynthSettingsCreateScriptsButton.TabIndex = 14;
            this.aviSynthSettingsCreateScriptsButton.Text = "Создать скрипты";
            this.aviSynthSettingsCreateScriptsButton.UseVisualStyleBackColor = true;
            this.aviSynthSettingsCreateScriptsButton.Click += new System.EventHandler(this.aviSynthSettingsCreateScriptsButton_Click);
            // 
            // x264CodecSettingsGroupBox
            // 
            this.x264CodecSettingsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.x264CodecSettingsGroupBox.Controls.Add(this.x264CodecSettingsShowFilesLabel);
            this.x264CodecSettingsGroupBox.Controls.Add(this.x264CodecSettingsShowFilesComboBox);
            this.x264CodecSettingsGroupBox.Controls.Add(this.x264CodecSettingsSearchPatternLabel);
            this.x264CodecSettingsGroupBox.Controls.Add(this.x264CodecSettingsSearchPatternComboBox);
            this.x264CodecSettingsGroupBox.Controls.Add(this.x264CodecSettingsNoteLabel);
            this.x264CodecSettingsGroupBox.Controls.Add(this.x264CodecSettingsCodecPathLabel);
            this.x264CodecSettingsGroupBox.Controls.Add(this.x264CodecSettingsCodecPathComboBox);
            this.x264CodecSettingsGroupBox.Controls.Add(this.x264CodecSettingsStatusLabel);
            this.x264CodecSettingsGroupBox.Controls.Add(this.x264CodecSettingsStandardStreamsUseModeLabel);
            this.x264CodecSettingsGroupBox.Controls.Add(this.x264CodecSettingsStandardStreamsUseModeComboBox);
            this.x264CodecSettingsGroupBox.Controls.Add(this.x264CodecSettingsCodecOptionsLabel);
            this.x264CodecSettingsGroupBox.Controls.Add(this.x264CodecSettingsCodecOptionsComboBox);
            this.x264CodecSettingsGroupBox.Controls.Add(this.x264CodecSettingsOutputFileExtensionLabel);
            this.x264CodecSettingsGroupBox.Controls.Add(this.x264CodecSettingsOutputFileExtensionComboBox);
            this.x264CodecSettingsGroupBox.Controls.Add(this.x264CodecSettingsOutputFolderPathLabel);
            this.x264CodecSettingsGroupBox.Controls.Add(this.x264CodecSettingsOutputFolderPathTextBox);
            this.x264CodecSettingsGroupBox.Controls.Add(this.x264CodecSettingsOutputFolderPathBrowseButton);
            this.x264CodecSettingsGroupBox.Controls.Add(this.x264CodecSettingsEncodeFilesButton);
            this.x264CodecSettingsGroupBox.Location = new System.Drawing.Point(357, 225);
            this.x264CodecSettingsGroupBox.Name = "x264CodecSettingsGroupBox";
            this.x264CodecSettingsGroupBox.Size = new System.Drawing.Size(534, 181);
            this.x264CodecSettingsGroupBox.TabIndex = 6;
            this.x264CodecSettingsGroupBox.TabStop = false;
            this.x264CodecSettingsGroupBox.Text = "Настройки для кодека X264";
            // 
            // x264CodecSettingsShowFilesLabel
            // 
            this.x264CodecSettingsShowFilesLabel.AutoSize = true;
            this.x264CodecSettingsShowFilesLabel.Location = new System.Drawing.Point(29, 20);
            this.x264CodecSettingsShowFilesLabel.Name = "x264CodecSettingsShowFilesLabel";
            this.x264CodecSettingsShowFilesLabel.Size = new System.Drawing.Size(110, 13);
            this.x264CodecSettingsShowFilesLabel.TabIndex = 0;
            this.x264CodecSettingsShowFilesLabel.Text = "Показывать файлы:";
            // 
            // x264CodecSettingsShowFilesComboBox
            // 
            this.x264CodecSettingsShowFilesComboBox.DisplayMember = "DisplayMember";
            this.x264CodecSettingsShowFilesComboBox.IntegralHeight = false;
            this.x264CodecSettingsShowFilesComboBox.ItemHeight = 13;
            this.x264CodecSettingsShowFilesComboBox.Location = new System.Drawing.Point(143, 17);
            this.x264CodecSettingsShowFilesComboBox.Margin = new System.Windows.Forms.Padding(1);
            this.x264CodecSettingsShowFilesComboBox.Name = "x264CodecSettingsShowFilesComboBox";
            this.x264CodecSettingsShowFilesComboBox.Size = new System.Drawing.Size(75, 21);
            this.x264CodecSettingsShowFilesComboBox.TabIndex = 1;
            this.x264CodecSettingsShowFilesComboBox.ValueMember = "ValueMember";
            this.x264CodecSettingsShowFilesComboBox.SelectedValueChanged += new System.EventHandler(this.x264CodecSettingsShowFilesComboBox_SelectedValueChanged);
            // 
            // x264CodecSettingsSearchPatternLabel
            // 
            this.x264CodecSettingsSearchPatternLabel.AutoSize = true;
            this.x264CodecSettingsSearchPatternLabel.Location = new System.Drawing.Point(222, 20);
            this.x264CodecSettingsSearchPatternLabel.Name = "x264CodecSettingsSearchPatternLabel";
            this.x264CodecSettingsSearchPatternLabel.Size = new System.Drawing.Size(138, 13);
            this.x264CodecSettingsSearchPatternLabel.TabIndex = 2;
            this.x264CodecSettingsSearchPatternLabel.Text = "Обрабатываемые файлы:";
            // 
            // x264CodecSettingsSearchPatternComboBox
            // 
            this.x264CodecSettingsSearchPatternComboBox.DisplayMember = "DisplayMember";
            this.x264CodecSettingsSearchPatternComboBox.IntegralHeight = false;
            this.x264CodecSettingsSearchPatternComboBox.ItemHeight = 13;
            this.x264CodecSettingsSearchPatternComboBox.Location = new System.Drawing.Point(364, 17);
            this.x264CodecSettingsSearchPatternComboBox.Margin = new System.Windows.Forms.Padding(1);
            this.x264CodecSettingsSearchPatternComboBox.Name = "x264CodecSettingsSearchPatternComboBox";
            this.x264CodecSettingsSearchPatternComboBox.Size = new System.Drawing.Size(75, 21);
            this.x264CodecSettingsSearchPatternComboBox.TabIndex = 3;
            this.x264CodecSettingsSearchPatternComboBox.ValueMember = "ValueMember";
            this.x264CodecSettingsSearchPatternComboBox.SelectedValueChanged += new System.EventHandler(this.x264CodecSettingsSearchPatternComboBox_SelectedValueChanged);
            // 
            // x264CodecSettingsNoteLabel
            // 
            this.x264CodecSettingsNoteLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.x264CodecSettingsNoteLabel.AutoSize = true;
            this.x264CodecSettingsNoteLabel.Location = new System.Drawing.Point(443, 20);
            this.x264CodecSettingsNoteLabel.Name = "x264CodecSettingsNoteLabel";
            this.x264CodecSettingsNoteLabel.Size = new System.Drawing.Size(85, 13);
            this.x264CodecSettingsNoteLabel.TabIndex = 4;
            this.x264CodecSettingsNoteLabel.Text = "(только файлы)";
            // 
            // x264CodecSettingsCodecPathLabel
            // 
            this.x264CodecSettingsCodecPathLabel.AutoSize = true;
            this.x264CodecSettingsCodecPathLabel.Location = new System.Drawing.Point(98, 43);
            this.x264CodecSettingsCodecPathLabel.Name = "x264CodecSettingsCodecPathLabel";
            this.x264CodecSettingsCodecPathLabel.Size = new System.Drawing.Size(41, 13);
            this.x264CodecSettingsCodecPathLabel.TabIndex = 5;
            this.x264CodecSettingsCodecPathLabel.Text = "Кодек:";
            // 
            // x264CodecSettingsCodecPathComboBox
            // 
            this.x264CodecSettingsCodecPathComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.x264CodecSettingsCodecPathComboBox.DisplayMember = "DisplayMember";
            this.x264CodecSettingsCodecPathComboBox.IntegralHeight = false;
            this.x264CodecSettingsCodecPathComboBox.ItemHeight = 13;
            this.x264CodecSettingsCodecPathComboBox.Location = new System.Drawing.Point(143, 40);
            this.x264CodecSettingsCodecPathComboBox.Margin = new System.Windows.Forms.Padding(1);
            this.x264CodecSettingsCodecPathComboBox.Name = "x264CodecSettingsCodecPathComboBox";
            this.x264CodecSettingsCodecPathComboBox.Size = new System.Drawing.Size(387, 21);
            this.x264CodecSettingsCodecPathComboBox.TabIndex = 6;
            this.x264CodecSettingsCodecPathComboBox.ValueMember = "ValueMember";
            this.x264CodecSettingsCodecPathComboBox.SelectedValueChanged += new System.EventHandler(this.x264CodecSettingsCodecPathComboBox_SelectedValueChanged);
            // 
            // x264CodecSettingsStandardStreamsUseModeLabel
            // 
            this.x264CodecSettingsStandardStreamsUseModeLabel.AutoSize = true;
            this.x264CodecSettingsStandardStreamsUseModeLabel.Location = new System.Drawing.Point(58, 66);
            this.x264CodecSettingsStandardStreamsUseModeLabel.Name = "x264CodecSettingsStandardStreamsUseModeLabel";
            this.x264CodecSettingsStandardStreamsUseModeLabel.Size = new System.Drawing.Size(81, 13);
            this.x264CodecSettingsStandardStreamsUseModeLabel.TabIndex = 7;
            this.x264CodecSettingsStandardStreamsUseModeLabel.Text = "Вывод потока:";
            // 
            // x264CodecSettingsStandardStreamsUseModeComboBox
            // 
            this.x264CodecSettingsStandardStreamsUseModeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.x264CodecSettingsStandardStreamsUseModeComboBox.DisplayMember = "DisplayMember";
            this.x264CodecSettingsStandardStreamsUseModeComboBox.IntegralHeight = false;
            this.x264CodecSettingsStandardStreamsUseModeComboBox.ItemHeight = 13;
            this.x264CodecSettingsStandardStreamsUseModeComboBox.Location = new System.Drawing.Point(143, 63);
            this.x264CodecSettingsStandardStreamsUseModeComboBox.Margin = new System.Windows.Forms.Padding(1);
            this.x264CodecSettingsStandardStreamsUseModeComboBox.Name = "x264CodecSettingsStandardStreamsUseModeComboBox";
            this.x264CodecSettingsStandardStreamsUseModeComboBox.Size = new System.Drawing.Size(387, 21);
            this.x264CodecSettingsStandardStreamsUseModeComboBox.TabIndex = 8;
            this.x264CodecSettingsStandardStreamsUseModeComboBox.ValueMember = "ValueMember";
            this.x264CodecSettingsStandardStreamsUseModeComboBox.SelectedValueChanged += new System.EventHandler(this.x264CodecSettingsStandardStreamsUseModeComboBox_SelectedValueChanged);
            // 
            // x264CodecSettingsCodecOptionsLabel
            // 
            this.x264CodecSettingsCodecOptionsLabel.AutoSize = true;
            this.x264CodecSettingsCodecOptionsLabel.Location = new System.Drawing.Point(31, 89);
            this.x264CodecSettingsCodecOptionsLabel.Name = "x264CodecSettingsCodecOptionsLabel";
            this.x264CodecSettingsCodecOptionsLabel.Size = new System.Drawing.Size(108, 13);
            this.x264CodecSettingsCodecOptionsLabel.TabIndex = 11;
            this.x264CodecSettingsCodecOptionsLabel.Text = "Параметры кодека:";
            // 
            // x264CodecSettingsCodecOptionsComboBox
            // 
            this.x264CodecSettingsCodecOptionsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.x264CodecSettingsCodecOptionsComboBox.DisplayMember = "DisplayMember";
            this.x264CodecSettingsCodecOptionsComboBox.IntegralHeight = false;
            this.x264CodecSettingsCodecOptionsComboBox.ItemHeight = 13;
            this.x264CodecSettingsCodecOptionsComboBox.Location = new System.Drawing.Point(143, 86);
            this.x264CodecSettingsCodecOptionsComboBox.Margin = new System.Windows.Forms.Padding(1);
            this.x264CodecSettingsCodecOptionsComboBox.Name = "x264CodecSettingsCodecOptionsComboBox";
            this.x264CodecSettingsCodecOptionsComboBox.Size = new System.Drawing.Size(387, 21);
            this.x264CodecSettingsCodecOptionsComboBox.TabIndex = 12;
            this.x264CodecSettingsCodecOptionsComboBox.ValueMember = "ValueMember";
            this.x264CodecSettingsCodecOptionsComboBox.SelectedValueChanged += new System.EventHandler(this.x264CodecSettingsCodecOptionsComboBox_SelectedValueChanged);
            // 
            // x264CodecSettingsOutputFileExtensionLabel
            // 
            this.x264CodecSettingsOutputFileExtensionLabel.AutoSize = true;
            this.x264CodecSettingsOutputFileExtensionLabel.Location = new System.Drawing.Point(18, 112);
            this.x264CodecSettingsOutputFileExtensionLabel.Name = "x264CodecSettingsOutputFileExtensionLabel";
            this.x264CodecSettingsOutputFileExtensionLabel.Size = new System.Drawing.Size(121, 13);
            this.x264CodecSettingsOutputFileExtensionLabel.TabIndex = 13;
            this.x264CodecSettingsOutputFileExtensionLabel.Text = "Тип выходного файла:";
            // 
            // x264CodecSettingsOutputFileExtensionComboBox
            // 
            this.x264CodecSettingsOutputFileExtensionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.x264CodecSettingsOutputFileExtensionComboBox.DisplayMember = "DisplayMember";
            this.x264CodecSettingsOutputFileExtensionComboBox.IntegralHeight = false;
            this.x264CodecSettingsOutputFileExtensionComboBox.ItemHeight = 13;
            this.x264CodecSettingsOutputFileExtensionComboBox.Location = new System.Drawing.Point(143, 109);
            this.x264CodecSettingsOutputFileExtensionComboBox.Margin = new System.Windows.Forms.Padding(1);
            this.x264CodecSettingsOutputFileExtensionComboBox.Name = "x264CodecSettingsOutputFileExtensionComboBox";
            this.x264CodecSettingsOutputFileExtensionComboBox.Size = new System.Drawing.Size(387, 21);
            this.x264CodecSettingsOutputFileExtensionComboBox.TabIndex = 14;
            this.x264CodecSettingsOutputFileExtensionComboBox.ValueMember = "ValueMember";
            this.x264CodecSettingsOutputFileExtensionComboBox.SelectedValueChanged += new System.EventHandler(this.x264CodecSettingsOutputFileExtensionComboBox_SelectedValueChanged);
            // 
            // x264CodecSettingsOutputFolderPathLabel
            // 
            this.x264CodecSettingsOutputFolderPathLabel.AutoSize = true;
            this.x264CodecSettingsOutputFolderPathLabel.Location = new System.Drawing.Point(46, 135);
            this.x264CodecSettingsOutputFolderPathLabel.Name = "x264CodecSettingsOutputFolderPathLabel";
            this.x264CodecSettingsOutputFolderPathLabel.Size = new System.Drawing.Size(93, 13);
            this.x264CodecSettingsOutputFolderPathLabel.TabIndex = 15;
            this.x264CodecSettingsOutputFolderPathLabel.Text = "Выходная папка:";
            // 
            // x264CodecSettingsOutputFolderPathTextBox
            // 
            this.x264CodecSettingsOutputFolderPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.x264CodecSettingsOutputFolderPathTextBox.Location = new System.Drawing.Point(143, 132);
            this.x264CodecSettingsOutputFolderPathTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.x264CodecSettingsOutputFolderPathTextBox.Name = "x264CodecSettingsOutputFolderPathTextBox";
            this.x264CodecSettingsOutputFolderPathTextBox.Size = new System.Drawing.Size(360, 20);
            this.x264CodecSettingsOutputFolderPathTextBox.TabIndex = 16;
            // 
            // x264CodecSettingsOutputFolderPathBrowseButton
            // 
            this.x264CodecSettingsOutputFolderPathBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.x264CodecSettingsOutputFolderPathBrowseButton.Location = new System.Drawing.Point(505, 132);
            this.x264CodecSettingsOutputFolderPathBrowseButton.Name = "x264CodecSettingsOutputFolderPathBrowseButton";
            this.x264CodecSettingsOutputFolderPathBrowseButton.Size = new System.Drawing.Size(25, 20);
            this.x264CodecSettingsOutputFolderPathBrowseButton.TabIndex = 17;
            this.x264CodecSettingsOutputFolderPathBrowseButton.Text = "...";
            this.x264CodecSettingsOutputFolderPathBrowseButton.UseVisualStyleBackColor = true;
            this.x264CodecSettingsOutputFolderPathBrowseButton.Click += new System.EventHandler(this.x264CodecSettingsOutputFolderPathBrowseButton_Click);
            // 
            // x264CodecSettingsEncodeFilesButton
            // 
            this.x264CodecSettingsEncodeFilesButton.Location = new System.Drawing.Point(143, 154);
            this.x264CodecSettingsEncodeFilesButton.Margin = new System.Windows.Forms.Padding(1);
            this.x264CodecSettingsEncodeFilesButton.Name = "x264CodecSettingsEncodeFilesButton";
            this.x264CodecSettingsEncodeFilesButton.Size = new System.Drawing.Size(150, 23);
            this.x264CodecSettingsEncodeFilesButton.TabIndex = 18;
            this.x264CodecSettingsEncodeFilesButton.Text = "Перекодировать файлы";
            this.x264CodecSettingsEncodeFilesButton.UseVisualStyleBackColor = true;
            this.x264CodecSettingsEncodeFilesButton.Click += new System.EventHandler(this.x264CodecSettingsEncodeFilesButton_Click);
            // 
            // x264CodecSettingsStatusLabel
            // 
            this.x264CodecSettingsStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.x264CodecSettingsStatusLabel.AutoSize = true;
            this.x264CodecSettingsStatusLabel.Location = new System.Drawing.Point(297, 159);
            this.x264CodecSettingsStatusLabel.Name = "x264CodecSettingsStatusLabel";
            this.x264CodecSettingsStatusLabel.Size = new System.Drawing.Size(0, 13);
            this.x264CodecSettingsStatusLabel.TabIndex = 7;
            // 
            // videoFilePropertiesReaderSettingsGroupBox
            // 
            this.videoFilePropertiesReaderSettingsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoFilePropertiesReaderSettingsGroupBox.Controls.Add(this.videoFilePropertiesReaderSettingsStatusLabel);
            this.videoFilePropertiesReaderSettingsGroupBox.Controls.Add(this.videoFilePropertiesReaderSettingsShowFilesLabel);
            this.videoFilePropertiesReaderSettingsGroupBox.Controls.Add(this.videoFilePropertiesReaderSettingsShowFilesComboBox);
            this.videoFilePropertiesReaderSettingsGroupBox.Controls.Add(this.videoFilePropertiesReaderSettingsSearchPatternLabel);
            this.videoFilePropertiesReaderSettingsGroupBox.Controls.Add(this.videoFilePropertiesReaderSettingsSearchPatternComboBox);
            this.videoFilePropertiesReaderSettingsGroupBox.Controls.Add(this.videoFilePropertiesReaderSettingsNoteLabel);
            this.videoFilePropertiesReaderSettingsGroupBox.Controls.Add(this.videoFilePropertiesReaderSettingsReaderPathLabel);
            this.videoFilePropertiesReaderSettingsGroupBox.Controls.Add(this.videoFilePropertiesReaderSettingsReaderPathComboBox);
            this.videoFilePropertiesReaderSettingsGroupBox.Controls.Add(this.videoFilePropertiesReaderSettingsStandardStreamsUseModeLabel);
            this.videoFilePropertiesReaderSettingsGroupBox.Controls.Add(this.videoFilePropertiesReaderSettingsStandardStreamsUseModeComboBox);
            this.videoFilePropertiesReaderSettingsGroupBox.Controls.Add(this.videoFilePropertiesReaderSettingsReadPropertiesButton);
            this.videoFilePropertiesReaderSettingsGroupBox.Location = new System.Drawing.Point(357, 412);
            this.videoFilePropertiesReaderSettingsGroupBox.Name = "videoFilePropertiesReaderSettingsGroupBox";
            this.videoFilePropertiesReaderSettingsGroupBox.Size = new System.Drawing.Size(534, 113);
            this.videoFilePropertiesReaderSettingsGroupBox.TabIndex = 8;
            this.videoFilePropertiesReaderSettingsGroupBox.TabStop = false;
            this.videoFilePropertiesReaderSettingsGroupBox.Text = "Настройки для чтения и сохранения свойств видеофайлов";
            // 
            // videoFilePropertiesReaderSettingsShowFilesLabel
            // 
            this.videoFilePropertiesReaderSettingsShowFilesLabel.AutoSize = true;
            this.videoFilePropertiesReaderSettingsShowFilesLabel.Location = new System.Drawing.Point(29, 20);
            this.videoFilePropertiesReaderSettingsShowFilesLabel.Name = "videoFilePropertiesReaderSettingsShowFilesLabel";
            this.videoFilePropertiesReaderSettingsShowFilesLabel.Size = new System.Drawing.Size(110, 13);
            this.videoFilePropertiesReaderSettingsShowFilesLabel.TabIndex = 0;
            this.videoFilePropertiesReaderSettingsShowFilesLabel.Text = "Показывать файлы:";
            // 
            // videoFilePropertiesReaderSettingsShowFilesComboBox
            // 
            this.videoFilePropertiesReaderSettingsShowFilesComboBox.DisplayMember = "DisplayMember";
            this.videoFilePropertiesReaderSettingsShowFilesComboBox.IntegralHeight = false;
            this.videoFilePropertiesReaderSettingsShowFilesComboBox.ItemHeight = 13;
            this.videoFilePropertiesReaderSettingsShowFilesComboBox.Location = new System.Drawing.Point(143, 17);
            this.videoFilePropertiesReaderSettingsShowFilesComboBox.Margin = new System.Windows.Forms.Padding(1);
            this.videoFilePropertiesReaderSettingsShowFilesComboBox.Name = "videoFilePropertiesReaderSettingsShowFilesComboBox";
            this.videoFilePropertiesReaderSettingsShowFilesComboBox.Size = new System.Drawing.Size(75, 21);
            this.videoFilePropertiesReaderSettingsShowFilesComboBox.TabIndex = 1;
            this.videoFilePropertiesReaderSettingsShowFilesComboBox.ValueMember = "ValueMember";
            this.videoFilePropertiesReaderSettingsShowFilesComboBox.SelectedValueChanged += new System.EventHandler(this.videoFilePropertiesReaderShowFilesComboBox_SelectedValueChanged);
            // 
            // videoFilePropertiesReaderSettingsSearchPatternLabel
            // 
            this.videoFilePropertiesReaderSettingsSearchPatternLabel.AutoSize = true;
            this.videoFilePropertiesReaderSettingsSearchPatternLabel.Location = new System.Drawing.Point(222, 20);
            this.videoFilePropertiesReaderSettingsSearchPatternLabel.Name = "videoFilePropertiesReaderSettingsSearchPatternLabel";
            this.videoFilePropertiesReaderSettingsSearchPatternLabel.Size = new System.Drawing.Size(138, 13);
            this.videoFilePropertiesReaderSettingsSearchPatternLabel.TabIndex = 2;
            this.videoFilePropertiesReaderSettingsSearchPatternLabel.Text = "Обрабатываемые файлы:";
            // 
            // videoFilePropertiesReaderSettingsSearchPatternComboBox
            // 
            this.videoFilePropertiesReaderSettingsSearchPatternComboBox.DisplayMember = "DisplayMember";
            this.videoFilePropertiesReaderSettingsSearchPatternComboBox.IntegralHeight = false;
            this.videoFilePropertiesReaderSettingsSearchPatternComboBox.ItemHeight = 13;
            this.videoFilePropertiesReaderSettingsSearchPatternComboBox.Location = new System.Drawing.Point(364, 17);
            this.videoFilePropertiesReaderSettingsSearchPatternComboBox.Margin = new System.Windows.Forms.Padding(1);
            this.videoFilePropertiesReaderSettingsSearchPatternComboBox.Name = "videoFilePropertiesReaderSettingsSearchPatternComboBox";
            this.videoFilePropertiesReaderSettingsSearchPatternComboBox.Size = new System.Drawing.Size(75, 21);
            this.videoFilePropertiesReaderSettingsSearchPatternComboBox.TabIndex = 3;
            this.videoFilePropertiesReaderSettingsSearchPatternComboBox.ValueMember = "ValueMember";
            this.videoFilePropertiesReaderSettingsSearchPatternComboBox.SelectedValueChanged += new System.EventHandler(this.videoFilePropertiesReaderSearchPatternComboBox_SelectedValueChanged);
            // 
            // videoFilePropertiesReaderSettingsNoteLabel
            // 
            this.videoFilePropertiesReaderSettingsNoteLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.videoFilePropertiesReaderSettingsNoteLabel.AutoSize = true;
            this.videoFilePropertiesReaderSettingsNoteLabel.Location = new System.Drawing.Point(443, 20);
            this.videoFilePropertiesReaderSettingsNoteLabel.Name = "videoFilePropertiesReaderSettingsNoteLabel";
            this.videoFilePropertiesReaderSettingsNoteLabel.Size = new System.Drawing.Size(85, 13);
            this.videoFilePropertiesReaderSettingsNoteLabel.TabIndex = 4;
            this.videoFilePropertiesReaderSettingsNoteLabel.Text = "(только файлы)";
            // 
            // videoFilePropertiesReaderSettingsReaderPathLabel
            // 
            this.videoFilePropertiesReaderSettingsReaderPathLabel.AutoSize = true;
            this.videoFilePropertiesReaderSettingsReaderPathLabel.Location = new System.Drawing.Point(33, 43);
            this.videoFilePropertiesReaderSettingsReaderPathLabel.Name = "videoFilePropertiesReaderSettingsReaderPathLabel";
            this.videoFilePropertiesReaderSettingsReaderPathLabel.Size = new System.Drawing.Size(106, 13);
            this.videoFilePropertiesReaderSettingsReaderPathLabel.TabIndex = 5;
            this.videoFilePropertiesReaderSettingsReaderPathLabel.Text = "Программа чтения:";
            // 
            // videoFilePropertiesReaderSettingsReaderPathComboBox
            // 
            this.videoFilePropertiesReaderSettingsReaderPathComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoFilePropertiesReaderSettingsReaderPathComboBox.DisplayMember = "DisplayMember";
            this.videoFilePropertiesReaderSettingsReaderPathComboBox.IntegralHeight = false;
            this.videoFilePropertiesReaderSettingsReaderPathComboBox.ItemHeight = 13;
            this.videoFilePropertiesReaderSettingsReaderPathComboBox.Location = new System.Drawing.Point(143, 40);
            this.videoFilePropertiesReaderSettingsReaderPathComboBox.Margin = new System.Windows.Forms.Padding(1);
            this.videoFilePropertiesReaderSettingsReaderPathComboBox.Name = "videoFilePropertiesReaderSettingsReaderPathComboBox";
            this.videoFilePropertiesReaderSettingsReaderPathComboBox.Size = new System.Drawing.Size(387, 21);
            this.videoFilePropertiesReaderSettingsReaderPathComboBox.TabIndex = 6;
            this.videoFilePropertiesReaderSettingsReaderPathComboBox.ValueMember = "ValueMember";
            this.videoFilePropertiesReaderSettingsReaderPathComboBox.SelectedValueChanged += new System.EventHandler(this.videoFilePropertiesReaderSettingsReaderPathComboBox_SelectedValueChanged);
            // 
            // videoFilePropertiesReaderSettingsStandardStreamsUseModeLabel
            // 
            this.videoFilePropertiesReaderSettingsStandardStreamsUseModeLabel.AutoSize = true;
            this.videoFilePropertiesReaderSettingsStandardStreamsUseModeLabel.Location = new System.Drawing.Point(58, 66);
            this.videoFilePropertiesReaderSettingsStandardStreamsUseModeLabel.Name = "videoFilePropertiesReaderSettingsStandardStreamsUseModeLabel";
            this.videoFilePropertiesReaderSettingsStandardStreamsUseModeLabel.Size = new System.Drawing.Size(81, 13);
            this.videoFilePropertiesReaderSettingsStandardStreamsUseModeLabel.TabIndex = 7;
            this.videoFilePropertiesReaderSettingsStandardStreamsUseModeLabel.Text = "Вывод потока:";
            // 
            // videoFilePropertiesReaderSettingsStandardStreamsUseModeComboBox
            // 
            this.videoFilePropertiesReaderSettingsStandardStreamsUseModeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoFilePropertiesReaderSettingsStandardStreamsUseModeComboBox.DisplayMember = "DisplayMember";
            this.videoFilePropertiesReaderSettingsStandardStreamsUseModeComboBox.IntegralHeight = false;
            this.videoFilePropertiesReaderSettingsStandardStreamsUseModeComboBox.ItemHeight = 13;
            this.videoFilePropertiesReaderSettingsStandardStreamsUseModeComboBox.Location = new System.Drawing.Point(143, 63);
            this.videoFilePropertiesReaderSettingsStandardStreamsUseModeComboBox.Margin = new System.Windows.Forms.Padding(1);
            this.videoFilePropertiesReaderSettingsStandardStreamsUseModeComboBox.Name = "videoFilePropertiesReaderSettingsStandardStreamsUseModeComboBox";
            this.videoFilePropertiesReaderSettingsStandardStreamsUseModeComboBox.Size = new System.Drawing.Size(387, 21);
            this.videoFilePropertiesReaderSettingsStandardStreamsUseModeComboBox.TabIndex = 8;
            this.videoFilePropertiesReaderSettingsStandardStreamsUseModeComboBox.ValueMember = "ValueMember";
            this.videoFilePropertiesReaderSettingsStandardStreamsUseModeComboBox.SelectedValueChanged += new System.EventHandler(this.videoFilePropertiesReaderSettingsUseStandardOutputComboBox_SelectedValueChanged);
            // 
            // videoFilePropertiesReaderSettingsReadPropertiesButton
            // 
            this.videoFilePropertiesReaderSettingsReadPropertiesButton.Location = new System.Drawing.Point(143, 86);
            this.videoFilePropertiesReaderSettingsReadPropertiesButton.Margin = new System.Windows.Forms.Padding(1);
            this.videoFilePropertiesReaderSettingsReadPropertiesButton.Name = "videoFilePropertiesReaderSettingsReadPropertiesButton";
            this.videoFilePropertiesReaderSettingsReadPropertiesButton.Size = new System.Drawing.Size(150, 23);
            this.videoFilePropertiesReaderSettingsReadPropertiesButton.TabIndex = 9;
            this.videoFilePropertiesReaderSettingsReadPropertiesButton.Text = "Сохранить свойства";
            this.videoFilePropertiesReaderSettingsReadPropertiesButton.UseVisualStyleBackColor = true;
            this.videoFilePropertiesReaderSettingsReadPropertiesButton.Click += new System.EventHandler(this.videoFilePropertiesReaderReadPropertiesButton_Click);
            // 
            // videoFilesTableAdapter
            // 
            this.videoFilesTableAdapter.ClearBeforeFill = true;
            // 
            // videoFilePropertiesReaderSettingsStatusLabel
            // 
            this.videoFilePropertiesReaderSettingsStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.videoFilePropertiesReaderSettingsStatusLabel.AutoSize = true;
            this.videoFilePropertiesReaderSettingsStatusLabel.Location = new System.Drawing.Point(297, 91);
            this.videoFilePropertiesReaderSettingsStatusLabel.Name = "videoFilePropertiesReaderSettingsStatusLabel";
            this.videoFilePropertiesReaderSettingsStatusLabel.Size = new System.Drawing.Size(0, 13);
            this.videoFilePropertiesReaderSettingsStatusLabel.TabIndex = 9;
            // 
            // pathesTreeStatusLabel
            // 
            this.pathesTreeStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pathesTreeStatusLabel.Location = new System.Drawing.Point(4, 446);
            this.pathesTreeStatusLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.pathesTreeStatusLabel.Name = "pathesTreeStatusLabel";
            this.pathesTreeStatusLabel.Size = new System.Drawing.Size(300, 13);
            this.pathesTreeStatusLabel.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 537);
            this.Controls.Add(this.rootFolderPathGroupBox);
            this.Controls.Add(this.pathesTreeGroupBox);
            this.Controls.Add(this.aviSynthSettingsRadioButton);
            this.Controls.Add(this.x264CodecSettingsRadioButton);
            this.Controls.Add(this.videoFilePropertiesReaderSettingsRadioButton);
            this.Controls.Add(this.aviSynthSettingsGroupBox);
            this.Controls.Add(this.x264CodecSettingsGroupBox);
            this.Controls.Add(this.videoFilePropertiesReaderSettingsGroupBox);
            this.Name = "MainForm";
            this.Text = "AviSynth Merge Scripter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.rootFolderPathGroupBox.ResumeLayout(false);
            this.rootFolderPathGroupBox.PerformLayout();
            this.pathesTreeGroupBox.ResumeLayout(false);
            this.aviSynthSettingsGroupBox.ResumeLayout(false);
            this.aviSynthSettingsGroupBox.PerformLayout();
            this.x264CodecSettingsGroupBox.ResumeLayout(false);
            this.x264CodecSettingsGroupBox.PerformLayout();
            this.videoFilePropertiesReaderSettingsGroupBox.ResumeLayout(false);
            this.videoFilePropertiesReaderSettingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoFilesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox    rootFolderPathGroupBox;
        private System.Windows.Forms.TextBox     rootFolderPathTextBox;
        private System.Windows.Forms.Button      rootFolderPathBrowseButton;

        private System.Windows.Forms.GroupBox    pathesTreeGroupBox;
        private System.Windows.Forms.TreeView    pathesTreeView;

        private System.Windows.Forms.RadioButton aviSynthSettingsRadioButton;
        private System.Windows.Forms.RadioButton x264CodecSettingsRadioButton;
        private System.Windows.Forms.RadioButton videoFilePropertiesReaderSettingsRadioButton;

        private System.Windows.Forms.GroupBox    aviSynthSettingsGroupBox;
        private System.Windows.Forms.Label       aviSynthSettingsShowFilesLabel;
        private System.Windows.Forms.ComboBox    aviSynthSettingsShowFilesComboBox;
        private System.Windows.Forms.Label       aviSynthSettingsSearchPatternLabel;
        private System.Windows.Forms.ComboBox    aviSynthSettingsSearchPatternСomboBox;
        private System.Windows.Forms.Label       aviSynthSettingsNoteLabel;
        private System.Windows.Forms.Label       aviSynthSettingsLoadingPluginLabel;
        private System.Windows.Forms.ComboBox    aviSynthSettingsLoadingPluginComboBox;
        private System.Windows.Forms.Label       aviSynthSettingsCompressRatioLabel;
        private System.Windows.Forms.ComboBox    aviSynthSettingsCompressRatioComboBox;
        private System.Windows.Forms.Label       aviSynthSettingsOutputFPSLabel;
        private System.Windows.Forms.ComboBox    aviSynthSettingsOutputFPSComboBox;
        private System.Windows.Forms.Label       aviSynthSettingsOutputFolderPathLabel;
        private System.Windows.Forms.TextBox     aviSynthSettingsOutputFolderPathTextBox;
        private System.Windows.Forms.Button      aviSynthSettingsOutputFolderPathBrowseButton;
        private System.Windows.Forms.Button      aviSynthSettingsCreateScriptsButton;

        private System.Windows.Forms.GroupBox    x264CodecSettingsGroupBox;
        private System.Windows.Forms.Label       x264CodecSettingsShowFilesLabel;
        private System.Windows.Forms.ComboBox    x264CodecSettingsShowFilesComboBox;
        private System.Windows.Forms.Label       x264CodecSettingsSearchPatternLabel;
        private System.Windows.Forms.ComboBox    x264CodecSettingsSearchPatternComboBox;
        private System.Windows.Forms.Label       x264CodecSettingsNoteLabel;
        private System.Windows.Forms.Label       x264CodecSettingsCodecPathLabel;
        private System.Windows.Forms.ComboBox    x264CodecSettingsCodecPathComboBox;
        private System.Windows.Forms.Label       x264CodecSettingsStandardStreamsUseModeLabel;
        private System.Windows.Forms.ComboBox    x264CodecSettingsStandardStreamsUseModeComboBox;
        private System.Windows.Forms.Label       x264CodecSettingsCodecOptionsLabel;
        private System.Windows.Forms.ComboBox    x264CodecSettingsCodecOptionsComboBox;
        private System.Windows.Forms.Label       x264CodecSettingsOutputFileExtensionLabel;
        private System.Windows.Forms.ComboBox    x264CodecSettingsOutputFileExtensionComboBox;
        private System.Windows.Forms.Label       x264CodecSettingsOutputFolderPathLabel;
        private System.Windows.Forms.TextBox     x264CodecSettingsOutputFolderPathTextBox;
        private System.Windows.Forms.Button      x264CodecSettingsOutputFolderPathBrowseButton;
        private System.Windows.Forms.Button      x264CodecSettingsEncodeFilesButton;

        private System.Windows.Forms.Label       x264CodecSettingsStatusLabel;

        private System.Windows.Forms.GroupBox    videoFilePropertiesReaderSettingsGroupBox;
        private System.Windows.Forms.Label       videoFilePropertiesReaderSettingsShowFilesLabel;
        private System.Windows.Forms.ComboBox    videoFilePropertiesReaderSettingsShowFilesComboBox;
        private System.Windows.Forms.Label       videoFilePropertiesReaderSettingsSearchPatternLabel;
        private System.Windows.Forms.ComboBox    videoFilePropertiesReaderSettingsSearchPatternComboBox;
        private System.Windows.Forms.Label       videoFilePropertiesReaderSettingsNoteLabel;
        private System.Windows.Forms.Label       videoFilePropertiesReaderSettingsReaderPathLabel;
        private System.Windows.Forms.ComboBox    videoFilePropertiesReaderSettingsReaderPathComboBox;
        private System.Windows.Forms.Label       videoFilePropertiesReaderSettingsStandardStreamsUseModeLabel;
        private System.Windows.Forms.ComboBox    videoFilePropertiesReaderSettingsStandardStreamsUseModeComboBox;
        private System.Windows.Forms.Button      videoFilePropertiesReaderSettingsReadPropertiesButton;

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private VideoFilesPropertiesDataSetTableAdapters.VideoFilesTableAdapter videoFilesTableAdapter;
        private System.Windows.Forms.Label videoFilePropertiesReaderSettingsStatusLabel;
        private System.Windows.Forms.BindingSource videoFilesBindingSource;
        private System.Windows.Forms.Label pathesTreeStatusLabel;

    }

}
