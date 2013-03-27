using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

using AviSynthMergeScripter.Scripting;
using AviSynthMergeScripter.Utils;

namespace AviSynthMergeScripter {

    public partial class MainForm : Form {

        private Settings settings;

        private AviSynthSettings                  aviSynthSettings;
        private X264CodecSettings                 x264CodecSettings;
        private VideoFilePropertiesReaderSettings videoFilePropertiesReaderSettings;

        private WorkMode workMode;

        private List<X264CodecScript> x264CodecScripts;
        private int                   currentX264CodecScriptIndex;

        private List<VideoFilePropertiesReaderScript> videoFilePropertiesReaderScripts;

        private string rootFolderPath;

        private static readonly Color OnMouseEnterColor = SystemColors.ControlLightLight;
        private static readonly Color OnMouseLeaveColor = SystemColors.Control;

        public MainForm() {
            this.InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            this.settings = new Settings();
            this.LoadAviSynthSettings();
            this.LoadX264CodecSettings();
            this.LoadVideoFilePropertiesReaderSettings();
            this.workMode = WorkMode.Undefined;
            this.RefreshRadioButtonsCheckState();
            this.rootFolderPathTextBox.Text                    = Application.StartupPath;
            this.aviSynthSettingsOutputFolderPathTextBox.Text  = Application.StartupPath;
            this.x264CodecSettingsOutputFolderPathTextBox.Text = Application.StartupPath;
            this.videoFilePropertiesReaderSettingsStatusLabel.Text = "Записей в базе: " + this.videoFilesTableAdapter.GetData().Rows.Count.ToString();
        }

        private void LoadAviSynthSettings() {
            this.aviSynthSettings = new AviSynthSettings();
            this.aviSynthSettingsShowFilesComboBox.DataSource       = this.settings.GetListControlItems      ("AviSynthSettings/ShowFiles");
            this.aviSynthSettingsShowFilesComboBox.SelectedItem     = this.settings.GetDefaultListControlItem("AviSynthSettings/ShowFiles");
            this.aviSynthSettingsSearchPatternСomboBox.DataSource   = this.settings.GetListControlItems      ("AviSynthSettings/SearchPattern");
            this.aviSynthSettingsSearchPatternСomboBox.SelectedItem = this.settings.GetDefaultListControlItem("AviSynthSettings/SearchPattern");
            this.aviSynthSettingsLoadingPluginComboBox.DataSource   = this.settings.GetListControlItems      ("AviSynthSettings/LoadingPlugin");
            this.aviSynthSettingsLoadingPluginComboBox.SelectedItem = this.settings.GetDefaultListControlItem("AviSynthSettings/LoadingPlugin");
            this.aviSynthSettingsCompressRatioComboBox.DataSource   = this.settings.GetListControlItems      ("AviSynthSettings/CompressRatio");
            this.aviSynthSettingsCompressRatioComboBox.SelectedItem = this.settings.GetDefaultListControlItem("AviSynthSettings/CompressRatio");
            this.aviSynthSettingsOutputFPSComboBox.DataSource       = this.settings.GetListControlItems      ("AviSynthSettings/OutputFPS");
            this.aviSynthSettingsOutputFPSComboBox.SelectedItem     = this.settings.GetDefaultListControlItem("AviSynthSettings/OutputFPS");
        }

        private void LoadX264CodecSettings() {
            this.x264CodecSettings = new X264CodecSettings();
            this.x264CodecSettingsShowFilesComboBox.DataSource                = this.settings.GetListControlItems      ("X264CodecSettings/ShowFiles");
            this.x264CodecSettingsShowFilesComboBox.SelectedItem              = this.settings.GetDefaultListControlItem("X264CodecSettings/ShowFiles");
            this.x264CodecSettingsSearchPatternComboBox.DataSource            = this.settings.GetListControlItems      ("X264CodecSettings/SearchPattern");
            this.x264CodecSettingsSearchPatternComboBox.SelectedItem          = this.settings.GetDefaultListControlItem("X264CodecSettings/SearchPattern");
            this.x264CodecSettingsCodecPathComboBox.DataSource                = this.settings.GetListControlItems      ("X264CodecSettings/CodecPath");
            this.x264CodecSettingsCodecPathComboBox.SelectedItem              = this.settings.GetDefaultListControlItem("X264CodecSettings/CodecPath");
            this.x264CodecSettingsStandardStreamsUseModeComboBox.DataSource   = this.settings.GetListControlItems      ("X264CodecSettings/StandardStreamsUseMode");
            this.x264CodecSettingsStandardStreamsUseModeComboBox.SelectedItem = this.settings.GetDefaultListControlItem("X264CodecSettings/StandardStreamsUseMode");
            this.x264CodecSettingsCodecOptionsComboBox.DataSource             = this.settings.GetListControlItems      ("X264CodecSettings/CodecOptions");
            this.x264CodecSettingsCodecOptionsComboBox.SelectedItem           = this.settings.GetDefaultListControlItem("X264CodecSettings/CodecOptions");
            this.x264CodecSettingsOutputFileExtensionComboBox.DataSource      = this.settings.GetListControlItems      ("X264CodecSettings/OutputFileExtension");
            this.x264CodecSettingsOutputFileExtensionComboBox.SelectedItem    = this.settings.GetDefaultListControlItem("X264CodecSettings/OutputFileExtension");
        }

        private void LoadVideoFilePropertiesReaderSettings() {
            this.videoFilePropertiesReaderSettings = new VideoFilePropertiesReaderSettings();
            this.videoFilePropertiesReaderSettingsShowFilesComboBox.DataSource                = this.settings.GetListControlItems      ("VideoFilePropertiesReaderSettings/ShowFiles");
            this.videoFilePropertiesReaderSettingsShowFilesComboBox.SelectedItem              = this.settings.GetDefaultListControlItem("VideoFilePropertiesReaderSettings/ShowFiles");
            this.videoFilePropertiesReaderSettingsSearchPatternComboBox.DataSource            = this.settings.GetListControlItems      ("VideoFilePropertiesReaderSettings/SearchPattern");
            this.videoFilePropertiesReaderSettingsSearchPatternComboBox.SelectedItem          = this.settings.GetDefaultListControlItem("VideoFilePropertiesReaderSettings/SearchPattern");
            this.videoFilePropertiesReaderSettingsReaderPathComboBox.DataSource               = this.settings.GetListControlItems      ("VideoFilePropertiesReaderSettings/ReaderPath");
            this.videoFilePropertiesReaderSettingsReaderPathComboBox.SelectedItem             = this.settings.GetDefaultListControlItem("VideoFilePropertiesReaderSettings/ReaderPath");
            this.videoFilePropertiesReaderSettingsStandardStreamsUseModeComboBox.DataSource   = this.settings.GetListControlItems      ("VideoFilePropertiesReaderSettings/StandardStreamsUseMode");
            this.videoFilePropertiesReaderSettingsStandardStreamsUseModeComboBox.SelectedItem = this.settings.GetDefaultListControlItem("VideoFilePropertiesReaderSettings/StandardStreamsUseMode");
        }

        #region Processing AviSynth settings

        private void aviSynthSettingsShowFilesComboBox_SelectedValueChanged(object sender, EventArgs e) {
            this.aviSynthSettings.ShowFiles = bool.Parse((string)(this.aviSynthSettingsShowFilesComboBox.SelectedValue));
            this.LoadFolderToTreeView();
        }

        private void aviSynthSettingsSearchPatternСomboBox_SelectedValueChanged(object sender, EventArgs e) {
            this.aviSynthSettings.SearchPattern = (string)(this.aviSynthSettingsSearchPatternСomboBox.SelectedValue);
            this.LoadFolderToTreeView();
        }

        private void aviSynthSettingsLoadingPluginComboBox_SelectedValueChanged(object sender, EventArgs e) {
            this.aviSynthSettings.LoadingPlugin = (string)(this.aviSynthSettingsLoadingPluginComboBox.SelectedValue);
        }

        private void aviSynthSettingsCompressRatioComboBox_SelectedValueChanged(object sender, EventArgs e) {
            this.aviSynthSettings.CompressRatio = (string)(this.aviSynthSettingsCompressRatioComboBox.SelectedValue);
        }

        private void aviSynthSettingsOutputFPSComboBox_SelectedValueChanged(object sender, EventArgs e) {
            this.aviSynthSettings.OutputFPS = (string)(this.aviSynthSettingsOutputFPSComboBox.SelectedValue);
        }

        #endregion

        #region Processing X264 codec settings

        private void x264CodecSettingsShowFilesComboBox_SelectedValueChanged(object sender, EventArgs e) {
            this.x264CodecSettings.ShowFiles = bool.Parse((string)(this.x264CodecSettingsShowFilesComboBox.SelectedValue));
            this.LoadFolderToTreeView();
        }

        private void x264CodecSettingsSearchPatternComboBox_SelectedValueChanged(object sender, EventArgs e) {
            this.x264CodecSettings.SearchPattern = (string)(this.x264CodecSettingsSearchPatternComboBox.SelectedValue);
            this.LoadFolderToTreeView();
        }

        private void x264CodecSettingsCodecPathComboBox_SelectedValueChanged(object sender, EventArgs e) {
            this.x264CodecSettings.CodecPath = (string)(this.x264CodecSettingsCodecPathComboBox.SelectedValue);
        }

        private void x264CodecSettingsStandardStreamsUseModeComboBox_SelectedValueChanged(object sender, EventArgs e) {
            StandardStreamsUseMode standardStreamsUseMode = (StandardStreamsUseMode)Enum.Parse(typeof(StandardStreamsUseMode), (string)(this.x264CodecSettingsStandardStreamsUseModeComboBox.SelectedValue));
            this.x264CodecSettings.StandardStreamsUseMode = standardStreamsUseMode;
        }

        private void x264CodecSettingsCodecOptionsComboBox_SelectedValueChanged(object sender, EventArgs e) {
            this.x264CodecSettings.CodecOptions = (string)(this.x264CodecSettingsCodecOptionsComboBox.SelectedValue);
        }

        private void x264CodecSettingsOutputFileExtensionComboBox_SelectedValueChanged(object sender, EventArgs e) {
            this.x264CodecSettings.OutputFileExtension = (string)(this.x264CodecSettingsOutputFileExtensionComboBox.SelectedValue);
        }

        #endregion

        #region Processing Save video files properties settings

        private void videoFilePropertiesReaderShowFilesComboBox_SelectedValueChanged(object sender, EventArgs e) {
            this.videoFilePropertiesReaderSettings.ShowFiles = bool.Parse((string)(this.videoFilePropertiesReaderSettingsShowFilesComboBox.SelectedValue));
            this.LoadFolderToTreeView();
        }

        private void videoFilePropertiesReaderSearchPatternComboBox_SelectedValueChanged(object sender, EventArgs e) {
            this.videoFilePropertiesReaderSettings.SearchPattern = (string)(this.videoFilePropertiesReaderSettingsSearchPatternComboBox.SelectedValue);
            this.LoadFolderToTreeView();
        }

        private void videoFilePropertiesReaderSettingsReaderPathComboBox_SelectedValueChanged(object sender, EventArgs e) {
            this.videoFilePropertiesReaderSettings.ReaderPath = (string)(this.videoFilePropertiesReaderSettingsReaderPathComboBox.SelectedValue);
        }

        private void videoFilePropertiesReaderSettingsUseStandardOutputComboBox_SelectedValueChanged(object sender, EventArgs e) {
            StandardStreamsUseMode standardStreamsUseMode = (StandardStreamsUseMode)Enum.Parse(typeof(StandardStreamsUseMode), (string)(this.videoFilePropertiesReaderSettingsStandardStreamsUseModeComboBox.SelectedValue));
            this.videoFilePropertiesReaderSettings.StandardStreamsUseMode = standardStreamsUseMode;
        }

        #endregion

        private void rootFolderPathTextBox_TextChanged(object sender, EventArgs e) {
            this.rootFolderPath = this.rootFolderPathTextBox.Text;
            this.LoadFolderToTreeView();
        }

        private void rootFolderPathBrowseButton_Click(object sender, EventArgs e) {
            if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK) {
                this.rootFolderPathTextBox.Text = this.folderBrowserDialog.SelectedPath;
                this.LoadFolderToTreeView();
            }
        }

        private void aviSynthSettingsOutputFolderPathBrowseButton_Click(object sender, EventArgs e) {
            if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK) {
                this.aviSynthSettingsOutputFolderPathTextBox.Text = this.folderBrowserDialog.SelectedPath;
            }
        }

        private void x264CodecSettingsOutputFolderPathBrowseButton_Click(object sender, EventArgs e) {
            if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK) {
                this.x264CodecSettingsOutputFolderPathTextBox.Text = this.folderBrowserDialog.SelectedPath;
            }
        }

        private void RefreshRadioButtonsCheckState() {
            this.aviSynthSettingsGroupBox.Enabled                  = this.aviSynthSettingsRadioButton.Checked;
            this.x264CodecSettingsGroupBox.Enabled                 = this.x264CodecSettingsRadioButton.Checked;
            this.videoFilePropertiesReaderSettingsGroupBox.Enabled = this.videoFilePropertiesReaderSettingsRadioButton.Checked;
            this.LoadFolderToTreeView();
        }

        private void aviSynthSettingsRadioButton_CheckedChanged(object sender, EventArgs e) {
            if (this.aviSynthSettingsRadioButton.Checked) {
                this.workMode = WorkMode.AviSynthScript;
                this.RefreshRadioButtonsCheckState();
            }
        }

        private void x264CodecSettingsRadioButton_CheckedChanged(object sender, EventArgs e) {
            if (this.x264CodecSettingsRadioButton.Checked) {
                this.workMode = WorkMode.X264Codec;
                this.RefreshRadioButtonsCheckState();
            }
        }

        private void videoFilePropertiesReaderSettingsRadioButton_CheckedChanged(object sender, EventArgs e) {
            if (this.videoFilePropertiesReaderSettingsRadioButton.Checked) {
                this.workMode = WorkMode.VideoFilePropertiesReader;
                this.RefreshRadioButtonsCheckState();
            }
        }

        private void aviSynthSettingsRadioButton_MouseEnter(object sender, EventArgs e) {
            this.aviSynthSettingsRadioButton.BackColor = OnMouseEnterColor;
            this.aviSynthSettingsGroupBox.BackColor    = OnMouseEnterColor;
        }

        private void aviSynthSettingsRadioButton_MouseLeave(object sender, EventArgs e) {
            this.aviSynthSettingsRadioButton.BackColor = OnMouseLeaveColor;
            this.aviSynthSettingsGroupBox.BackColor    = OnMouseLeaveColor;
        }

        private void x264CodecSettingsRadioButton_MouseEnter(object sender, EventArgs e) {
            this.x264CodecSettingsRadioButton.BackColor = OnMouseEnterColor;
            this.x264CodecSettingsGroupBox.BackColor    = OnMouseEnterColor;
        }

        private void x264CodecSettingsRadioButton_MouseLeave(object sender, EventArgs e) {
            this.x264CodecSettingsRadioButton.BackColor = OnMouseLeaveColor;
            this.x264CodecSettingsGroupBox.BackColor    = OnMouseLeaveColor;
        }

        private void videoFilePropertiesReaderSettingsRadioButton_MouseEnter(object sender, EventArgs e) {
            this.videoFilePropertiesReaderSettingsRadioButton.BackColor = OnMouseEnterColor;
            this.videoFilePropertiesReaderSettingsGroupBox.BackColor    = OnMouseEnterColor;
        }

        private void videoFilePropertiesReaderSettingsRadioButton_MouseLeave(object sender, EventArgs e) {
            this.videoFilePropertiesReaderSettingsRadioButton.BackColor = OnMouseLeaveColor;
            this.videoFilePropertiesReaderSettingsGroupBox.BackColor    = OnMouseLeaveColor;
        }

        private void LoadFolderToTreeView() {
            try {
                switch (this.workMode) {
                    case WorkMode.AviSynthScript: {
                        TreeViewUtils.LoadFolderToTreeView(this.pathesTreeView, this.rootFolderPath, this.aviSynthSettings.ShowFiles, this.aviSynthSettings.SearchPattern);
                        this.pathesTreeStatusLabel.Text = "Дерево папок загружено.";
                        break;
                    }
                    case WorkMode.X264Codec: {
                        TreeViewUtils.LoadFolderToTreeView(this.pathesTreeView, this.rootFolderPath, this.x264CodecSettings.ShowFiles, this.x264CodecSettings.SearchPattern);
                        this.pathesTreeStatusLabel.Text = "Дерево папок загружено.";
                        break;
                    }
                    case WorkMode.VideoFilePropertiesReader: {
                        TreeViewUtils.LoadFolderToTreeView(this.pathesTreeView, this.rootFolderPath, this.videoFilePropertiesReaderSettings.ShowFiles, this.videoFilePropertiesReaderSettings.SearchPattern);
                        this.pathesTreeStatusLabel.Text = "Дерево папок загружено.";
                        break;
                    }
                    case WorkMode.Undefined: {
                        this.pathesTreeStatusLabel.Text = "Выберите режим работы.";
                        return;
                    }
                }
                TreeNode rootNode = this.pathesTreeView.Nodes[0];
                rootNode.Checked = true;
                TreeViewUtils.SetCheckStateOfChildNodes(rootNode, TreeViewAction.ByKeyboard);
                this.pathesTreeView.ExpandAll();
            }
            catch (Exception e) {
                this.pathesTreeStatusLabel.Text = e.Message;
            }
        }

        private void pathesTreeView_AfterCheck(object sender, TreeViewEventArgs e) {
            TreeViewUtils.SetCheckStateOfChildNodes(e.Node, e.Action);
            TreeViewUtils.SetCheckStateOfParentNodes(e.Node, e.Action);
        }

        private void aviSynthSettingsCreateScriptsButton_Click(object sender, EventArgs e) {
            List<string> checkedPathesList = TreeViewUtils.GetCheckedFolders(this.pathesTreeView);
            if ((checkedPathesList == null) || (checkedPathesList.Count == 0)) {
                return;
            }
            foreach (string path in checkedPathesList) {
                AviSynthScript script = new AviSynthScript(path, this.aviSynthSettingsOutputFolderPathTextBox.Text, this.aviSynthSettings);
                script.GenerateScriptToFile();
            }
        }

        private void x264CodecSettingsEncodeFilesButton_Click(object sender, EventArgs e) {
            List<string> checkedPathesList = TreeViewUtils.GetCheckedFiles(this.pathesTreeView);
            if ((checkedPathesList == null) || (checkedPathesList.Count == 0)) {
                return;
            }
            this.x264CodecScripts = new List<X264CodecScript>();
            this.currentX264CodecScriptIndex = -1;
            foreach (string path in checkedPathesList) {
                X264CodecScript x264CodecScript = new X264CodecScript(path, this.x264CodecSettingsOutputFolderPathTextBox.Text, this.x264CodecSettings);
                x264CodecScript.CodecOutputDataReceived += new DataReceivedEventHandler(x264CodecScript_CodecOutputDataReceived);
                x264CodecScript.CodecErrorDataReceived  += new DataReceivedEventHandler(x264CodecScript_CodecErrorDataReceived);
                x264CodecScript.EncodeFileCompleted     += new EventHandler(x264CodecScript_EncodeFileCompleted);
                this.x264CodecScripts.Add(x264CodecScript);
            }
            this.currentX264CodecScriptIndex = 0;
            this.x264CodecScripts[this.currentX264CodecScriptIndex].StartEncodeFile();
        }

        private void x264CodecScript_CodecOutputDataReceived(object sender, DataReceivedEventArgs e) {
            if (this.InvokeRequired) {
                this.Invoke(new MethodInvoker(delegate() {
                    this.x264CodecSettingsStatusLabel.Text = e.Data;
                }));
            }
            else {
                this.x264CodecSettingsStatusLabel.Text = e.Data;
            }
        }

        private void x264CodecScript_CodecErrorDataReceived(object sender, DataReceivedEventArgs e) {
            if (this.InvokeRequired) {
                this.Invoke(new MethodInvoker(delegate() {
                    this.x264CodecSettingsStatusLabel.Text = e.Data;
                }));
            }
            else {
                this.x264CodecSettingsStatusLabel.Text = e.Data;
            }
        }
        
        private void x264CodecScript_EncodeFileCompleted(object sender, EventArgs e) {
            if (this.currentX264CodecScriptIndex < this.x264CodecScripts.Count - 1) {
                this.currentX264CodecScriptIndex++;
                this.x264CodecScripts[this.currentX264CodecScriptIndex].StartEncodeFile();
            }
            else {
                if (this.InvokeRequired) {
                    this.Invoke(new MethodInvoker(delegate() {
                        this.x264CodecSettingsStatusLabel.Text = "Completed!";
                    }));
                }
                else {
                    this.x264CodecSettingsStatusLabel.Text = "Completed!";
                }
            }
        }

        private void videoFilePropertiesReaderReadPropertiesButton_Click(object sender, EventArgs e) {
            List<string> checkedPathesList = TreeViewUtils.GetCheckedFiles(this.pathesTreeView);
            if ((checkedPathesList == null) || (checkedPathesList.Count == 0)) {
                return;
            }
            this.videoFilePropertiesReaderScripts = new List<VideoFilePropertiesReaderScript>();
            foreach (string path in checkedPathesList) {
                VideoFilePropertiesReaderScript videoFilePropertiesReaderScript = new VideoFilePropertiesReaderScript(path, this.videoFilePropertiesReaderSettings);
                this.videoFilePropertiesReaderScripts.Add(videoFilePropertiesReaderScript);
                VideoFileProperties videoFileProperties = videoFilePropertiesReaderScript.ReadProperties();
                this.videoFilesTableAdapter.Insert(videoFileProperties.ID, videoFileProperties.Channel, videoFileProperties.Name, videoFileProperties.Extension, videoFileProperties.Length, videoFileProperties.DateTime, videoFileProperties.LastWriteDateTime, videoFileProperties.MD5, videoFileProperties.SHA512, videoFileProperties.XMLStreamProperties.OuterXml);
                Thread.Sleep(0);
                this.Refresh();
            }
        }

    }

}
