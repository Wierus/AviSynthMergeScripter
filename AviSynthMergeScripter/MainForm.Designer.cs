namespace AviSynthMergeScripter {

    public partial class MainForm {

        /// <summary>Требуется переменная конструктора.</summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>Освободить все используемые ресурсы.</summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
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
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.folderLabel = new System.Windows.Forms.Label();
            this.folderTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.createScriptButton = new System.Windows.Forms.Button();
            this.searchPatternLabel = new System.Windows.Forms.Label();
            this.compressRatioLabel = new System.Windows.Forms.Label();
            this.scriptFileNamePrefixLabel = new System.Windows.Forms.Label();
            this.targetFPSLabel = new System.Windows.Forms.Label();
            this.compressRatioComboBox = new System.Windows.Forms.ComboBox();
            this.loadPluginStringLabel = new System.Windows.Forms.Label();
            this.targetFPSComboBox = new System.Windows.Forms.ComboBox();
            this.scriptFileExtensionLabel = new System.Windows.Forms.Label();
            this.loadPluginStringComboBox = new System.Windows.Forms.ComboBox();
            this.searchPatternСomboBox = new System.Windows.Forms.ComboBox();
            this.scriptFileNamePrefixСomboBox = new System.Windows.Forms.ComboBox();
            this.scriptFileExtensionСomboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // folderLabel
            // 
            this.folderLabel.AutoSize = true;
            this.folderLabel.Location = new System.Drawing.Point(12, 15);
            this.folderLabel.Name = "folderLabel";
            this.folderLabel.Size = new System.Drawing.Size(100, 13);
            this.folderLabel.TabIndex = 0;
            this.folderLabel.Text = "Папка с файлами:";
            // 
            // folderTextBox
            // 
            this.folderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.folderTextBox.Location = new System.Drawing.Point(118, 12);
            this.folderTextBox.Name = "folderTextBox";
            this.folderTextBox.Size = new System.Drawing.Size(573, 20);
            this.folderTextBox.TabIndex = 1;
            // 
            // browseButton
            // 
            this.browseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseButton.Location = new System.Drawing.Point(697, 10);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "Обзор...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // createScriptButton
            // 
            this.createScriptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createScriptButton.Location = new System.Drawing.Point(672, 117);
            this.createScriptButton.Name = "createScriptButton";
            this.createScriptButton.Size = new System.Drawing.Size(100, 23);
            this.createScriptButton.TabIndex = 15;
            this.createScriptButton.Text = "Создать скрипт";
            this.createScriptButton.UseVisualStyleBackColor = true;
            this.createScriptButton.Click += new System.EventHandler(this.createScriptButton_Click);
            // 
            // searchPatternLabel
            // 
            this.searchPatternLabel.AutoSize = true;
            this.searchPatternLabel.Location = new System.Drawing.Point(28, 68);
            this.searchPatternLabel.Name = "searchPatternLabel";
            this.searchPatternLabel.Size = new System.Drawing.Size(210, 13);
            this.searchPatternLabel.TabIndex = 5;
            this.searchPatternLabel.Text = "Шаблон имен обрабатываемых файлов:";
            // 
            // compressRatioLabel
            // 
            this.compressRatioLabel.AutoSize = true;
            this.compressRatioLabel.Location = new System.Drawing.Point(338, 68);
            this.compressRatioLabel.Name = "compressRatioLabel";
            this.compressRatioLabel.Size = new System.Drawing.Size(120, 13);
            this.compressRatioLabel.TabIndex = 11;
            this.compressRatioLabel.Text = "Коэффициент сжатия:";
            // 
            // scriptFileNamePrefixLabel
            // 
            this.scriptFileNamePrefixLabel.AutoSize = true;
            this.scriptFileNamePrefixLabel.Location = new System.Drawing.Point(68, 95);
            this.scriptFileNamePrefixLabel.Name = "scriptFileNamePrefixLabel";
            this.scriptFileNamePrefixLabel.Size = new System.Drawing.Size(170, 13);
            this.scriptFileNamePrefixLabel.TabIndex = 7;
            this.scriptFileNamePrefixLabel.Text = "Префикс имени файла скрипта:";
            // 
            // targetFPSLabel
            // 
            this.targetFPSLabel.AutoSize = true;
            this.targetFPSLabel.Location = new System.Drawing.Point(325, 95);
            this.targetFPSLabel.Name = "targetFPSLabel";
            this.targetFPSLabel.Size = new System.Drawing.Size(133, 13);
            this.targetFPSLabel.TabIndex = 13;
            this.targetFPSLabel.Text = "Выходное значение FPS:";
            // 
            // compressRatioComboBox
            // 
            this.compressRatioComboBox.IntegralHeight = false;
            this.compressRatioComboBox.ItemHeight = 13;
            this.compressRatioComboBox.Location = new System.Drawing.Point(464, 65);
            this.compressRatioComboBox.Name = "compressRatioComboBox";
            this.compressRatioComboBox.Size = new System.Drawing.Size(75, 21);
            this.compressRatioComboBox.TabIndex = 12;
            // 
            // loadPluginStringLabel
            // 
            this.loadPluginStringLabel.AutoSize = true;
            this.loadPluginStringLabel.Location = new System.Drawing.Point(12, 41);
            this.loadPluginStringLabel.Name = "loadPluginStringLabel";
            this.loadPluginStringLabel.Size = new System.Drawing.Size(226, 13);
            this.loadPluginStringLabel.TabIndex = 3;
            this.loadPluginStringLabel.Text = "Строка загрузки дополнительного модуля:";
            // 
            // targetFPSComboBox
            // 
            this.targetFPSComboBox.IntegralHeight = false;
            this.targetFPSComboBox.ItemHeight = 13;
            this.targetFPSComboBox.Location = new System.Drawing.Point(464, 92);
            this.targetFPSComboBox.Name = "targetFPSComboBox";
            this.targetFPSComboBox.Size = new System.Drawing.Size(75, 21);
            this.targetFPSComboBox.TabIndex = 14;
            // 
            // scriptFileExtensionLabel
            // 
            this.scriptFileExtensionLabel.AutoSize = true;
            this.scriptFileExtensionLabel.Location = new System.Drawing.Point(86, 122);
            this.scriptFileExtensionLabel.Name = "scriptFileExtensionLabel";
            this.scriptFileExtensionLabel.Size = new System.Drawing.Size(152, 13);
            this.scriptFileExtensionLabel.TabIndex = 9;
            this.scriptFileExtensionLabel.Text = "Расширение файла скрипта:";
            // 
            // loadPluginStringComboBox
            // 
            this.loadPluginStringComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadPluginStringComboBox.IntegralHeight = false;
            this.loadPluginStringComboBox.ItemHeight = 13;
            this.loadPluginStringComboBox.Location = new System.Drawing.Point(244, 38);
            this.loadPluginStringComboBox.Name = "loadPluginStringComboBox";
            this.loadPluginStringComboBox.Size = new System.Drawing.Size(447, 21);
            this.loadPluginStringComboBox.TabIndex = 4;
            // 
            // searchPatternСomboBox
            // 
            this.searchPatternСomboBox.IntegralHeight = false;
            this.searchPatternСomboBox.ItemHeight = 13;
            this.searchPatternСomboBox.Location = new System.Drawing.Point(244, 65);
            this.searchPatternСomboBox.Name = "searchPatternСomboBox";
            this.searchPatternСomboBox.Size = new System.Drawing.Size(75, 21);
            this.searchPatternСomboBox.TabIndex = 6;
            // 
            // scriptFileNamePrefixСomboBox
            // 
            this.scriptFileNamePrefixСomboBox.IntegralHeight = false;
            this.scriptFileNamePrefixСomboBox.ItemHeight = 13;
            this.scriptFileNamePrefixСomboBox.Location = new System.Drawing.Point(244, 92);
            this.scriptFileNamePrefixСomboBox.Name = "scriptFileNamePrefixСomboBox";
            this.scriptFileNamePrefixСomboBox.Size = new System.Drawing.Size(75, 21);
            this.scriptFileNamePrefixСomboBox.TabIndex = 8;
            // 
            // scriptFileExtensionСomboBox
            // 
            this.scriptFileExtensionСomboBox.IntegralHeight = false;
            this.scriptFileExtensionСomboBox.ItemHeight = 13;
            this.scriptFileExtensionСomboBox.Location = new System.Drawing.Point(244, 119);
            this.scriptFileExtensionСomboBox.Name = "scriptFileExtensionСomboBox";
            this.scriptFileExtensionСomboBox.Size = new System.Drawing.Size(75, 21);
            this.scriptFileExtensionСomboBox.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 152);
            this.Controls.Add(this.scriptFileExtensionСomboBox);
            this.Controls.Add(this.scriptFileNamePrefixСomboBox);
            this.Controls.Add(this.searchPatternСomboBox);
            this.Controls.Add(this.loadPluginStringComboBox);
            this.Controls.Add(this.scriptFileExtensionLabel);
            this.Controls.Add(this.targetFPSComboBox);
            this.Controls.Add(this.loadPluginStringLabel);
            this.Controls.Add(this.compressRatioComboBox);
            this.Controls.Add(this.targetFPSLabel);
            this.Controls.Add(this.scriptFileNamePrefixLabel);
            this.Controls.Add(this.compressRatioLabel);
            this.Controls.Add(this.searchPatternLabel);
            this.Controls.Add(this.createScriptButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.folderTextBox);
            this.Controls.Add(this.folderLabel);
            this.Name = "MainForm";
            this.Text = "AviSynth Merge Scripter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label    folderLabel;
        private System.Windows.Forms.TextBox  folderTextBox;
        private System.Windows.Forms.Button   browseButton;
        private System.Windows.Forms.Label    loadPluginStringLabel;
        private System.Windows.Forms.ComboBox loadPluginStringComboBox;
        private System.Windows.Forms.Label    searchPatternLabel;
        private System.Windows.Forms.ComboBox searchPatternСomboBox;
        private System.Windows.Forms.Label    scriptFileNamePrefixLabel;
        private System.Windows.Forms.ComboBox scriptFileNamePrefixСomboBox;
        private System.Windows.Forms.Label    scriptFileExtensionLabel;
        private System.Windows.Forms.ComboBox scriptFileExtensionСomboBox;
        private System.Windows.Forms.Label    compressRatioLabel;
        private System.Windows.Forms.ComboBox compressRatioComboBox;
        private System.Windows.Forms.Label    targetFPSLabel;
        private System.Windows.Forms.ComboBox targetFPSComboBox;
        private System.Windows.Forms.Button createScriptButton;

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;

    }

}
