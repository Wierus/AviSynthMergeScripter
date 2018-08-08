using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

using AviSynthMergeScripter.Scripting;
using AviSynthMergeScripter.Utils;

namespace AviSynthMergeScripter {

    public partial class MainForm : Form {

        private Settings settings;

        private AviSynthSettings  aviSynthSettings;
        private X264CodecSettings x264CodecSettings;

        private WorkMode workMode;

        private List<X264CodecScript> x264CodecScripts;
        private int                   currentX264CodecScriptIndex;

        private string rootFolderPath;

        private static readonly Color OnMouseEnterColor = SystemColors.ControlLight;
        private static readonly Color OnMouseLeaveColor = SystemColors.Control;

        public MainForm() {
            this.InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            this.settings = new Settings();
            this.LoadAviSynthSettings();
            this.LoadX264CodecSettings();
            this.workMode = WorkMode.Undefined;
            this.rootFolderPathTextBox.Text                    = Application.StartupPath;
            this.aviSynthSettingsOutputFolderPathTextBox.Text  = Application.StartupPath;
            this.x264CodecSettingsOutputFolderPathTextBox.Text = Application.StartupPath;
        }

        private void LoadAviSynthSettings() {
            this.aviSynthSettings = new AviSynthSettings();
            this.aviSynthSettingsShowFilesComboBox.DataSource           = this.settings.GetListControlItems      ("AviSynthSettings/ShowFiles");
            this.aviSynthSettingsShowFilesComboBox.SelectedItem         = this.settings.GetDefaultListControlItem("AviSynthSettings/ShowFiles");
            this.aviSynthSettingsSearchPatternСomboBox.DataSource       = this.settings.GetListControlItems      ("AviSynthSettings/SearchPattern");
            this.aviSynthSettingsSearchPatternСomboBox.SelectedItem     = this.settings.GetDefaultListControlItem("AviSynthSettings/SearchPattern");
            this.aviSynthSettingsLoadingPluginComboBox.DataSource       = this.settings.GetListControlItems      ("AviSynthSettings/LoadingPlugin");
            this.aviSynthSettingsLoadingPluginComboBox.SelectedItem     = this.settings.GetDefaultListControlItem("AviSynthSettings/LoadingPlugin");
            this.aviSynthSettingsCompressRatioComboBox.DataSource       = this.settings.GetListControlItems      ("AviSynthSettings/CompressRatio");
            this.aviSynthSettingsCompressRatioComboBox.SelectedItem     = this.settings.GetDefaultListControlItem("AviSynthSettings/CompressRatio");
            this.aviSynthSettingsOutputFPSComboBox.DataSource           = this.settings.GetListControlItems      ("AviSynthSettings/OutputFPS");
            this.aviSynthSettingsOutputFPSComboBox.SelectedItem         = this.settings.GetDefaultListControlItem("AviSynthSettings/OutputFPS");
            this.aviSynthSettingsSourceReplaceTextComboBox.DataSource   = this.settings.GetListControlItems      ("AviSynthSettings/SourceReplaceText");
            this.aviSynthSettingsSourceReplaceTextComboBox.SelectedItem = this.settings.GetDefaultListControlItem("AviSynthSettings/SourceReplaceText");
            this.aviSynthSettingsTargetReplaceTextComboBox.DataSource   = this.settings.GetListControlItems      ("AviSynthSettings/TargetReplaceText");
            this.aviSynthSettingsTargetReplaceTextComboBox.SelectedItem = this.settings.GetDefaultListControlItem("AviSynthSettings/TargetReplaceText");
        }

        private void LoadX264CodecSettings() {
            this.x264CodecSettings = new X264CodecSettings();
            this.x264CodecSettingsShowFilesComboBox.DataSource             = this.settings.GetListControlItems      ("X264CodecSettings/ShowFiles");
            this.x264CodecSettingsShowFilesComboBox.SelectedItem           = this.settings.GetDefaultListControlItem("X264CodecSettings/ShowFiles");
            this.x264CodecSettingsSearchPatternComboBox.DataSource         = this.settings.GetListControlItems      ("X264CodecSettings/SearchPattern");
            this.x264CodecSettingsSearchPatternComboBox.SelectedItem       = this.settings.GetDefaultListControlItem("X264CodecSettings/SearchPattern");
            this.x264CodecSettingsCodecPathComboBox.DataSource             = this.settings.GetListControlItems      ("X264CodecSettings/CodecPath");
            this.x264CodecSettingsCodecPathComboBox.SelectedItem           = this.settings.GetDefaultListControlItem("X264CodecSettings/CodecPath");
            this.x264CodecSettingsCodecOptionsComboBox.DataSource          = this.settings.GetListControlItems      ("X264CodecSettings/CodecOptions");
            this.x264CodecSettingsCodecOptionsComboBox.SelectedItem        = this.settings.GetDefaultListControlItem("X264CodecSettings/CodecOptions");
            this.x264CodecSettingsOutputFileExtensionComboBox.DataSource   = this.settings.GetListControlItems      ("X264CodecSettings/OutputFileExtension");
            this.x264CodecSettingsOutputFileExtensionComboBox.SelectedItem = this.settings.GetDefaultListControlItem("X264CodecSettings/OutputFileExtension");
            this.x264CodecSettingsMaxEncodingTimeComboBox.DataSource       = this.settings.GetListControlItems      ("X264CodecSettings/MaxEncodingTime");
            this.x264CodecSettingsMaxEncodingTimeComboBox.SelectedItem     = this.settings.GetDefaultListControlItem("X264CodecSettings/MaxEncodingTime");
        }

        #region Processing AviSynth settings

        private void AviSynthSettingsShowFilesComboBox_SelectedValueChanged(object sender, EventArgs e) {
            this.aviSynthSettings.ShowFiles = bool.Parse((string)(this.aviSynthSettingsShowFilesComboBox.SelectedValue));
            this.LoadFolderToTreeView();
        }

        private void AviSynthSettingsSearchPatternСomboBox_SelectedValueChanged(object sender, EventArgs e) {
            this.aviSynthSettings.SearchPattern = (string)(this.aviSynthSettingsSearchPatternСomboBox.SelectedValue);
            this.LoadFolderToTreeView();
        }

        private void AviSynthSettingsLoadingPluginComboBox_SelectedValueChanged(object sender, EventArgs e) {
            this.aviSynthSettings.LoadingPlugin = (string)(this.aviSynthSettingsLoadingPluginComboBox.SelectedValue);
        }

        private void AviSynthSettingsCompressRatioComboBox_SelectedValueChanged(object sender, EventArgs e) {
            this.aviSynthSettings.CompressRatio = (string)(this.aviSynthSettingsCompressRatioComboBox.SelectedValue);
        }

        private void AviSynthSettingsOutputFPSComboBox_SelectedValueChanged(object sender, EventArgs e) {
            this.aviSynthSettings.OutputFPS = (string)(this.aviSynthSettingsOutputFPSComboBox.SelectedValue);
        }

        private void AviSynthSettingsSourceReplaceTextComboBox_SelectedValueChanged(object sender, EventArgs e) {
            this.aviSynthSettings.SourceReplaceText = (string)(this.aviSynthSettingsSourceReplaceTextComboBox.SelectedValue);
        }

        private void AviSynthSettingsTargetReplaceTextComboBox_SelectedValueChanged(object sender, EventArgs e) {
            this.aviSynthSettings.TargetReplaceText = (string)(this.aviSynthSettingsTargetReplaceTextComboBox.SelectedValue);
        }

        #endregion

        #region Processing X264 Codec settings

        private void X264CodecSettingsShowFilesComboBox_SelectedValueChanged(object sender, EventArgs e) {
            this.x264CodecSettings.ShowFiles = bool.Parse((string)(this.x264CodecSettingsShowFilesComboBox.SelectedValue));
            this.LoadFolderToTreeView();
        }

        private void X264CodecSettingsSearchPatternComboBox_SelectedValueChanged(object sender, EventArgs e) {
            this.x264CodecSettings.SearchPattern = (string)(this.x264CodecSettingsSearchPatternComboBox.SelectedValue);
            this.LoadFolderToTreeView();
        }

        private void X264CodecSettingsCodecPathComboBox_SelectedValueChanged(object sender, EventArgs e) {
            this.x264CodecSettings.CodecPath = (string)(this.x264CodecSettingsCodecPathComboBox.SelectedValue);
        }

        private void X264CodecSettingsCodecOptionsComboBox_SelectedValueChanged(object sender, EventArgs e) {
            this.x264CodecSettings.CodecOptions = (string)(this.x264CodecSettingsCodecOptionsComboBox.SelectedValue);
        }

        private void X264CodecSettingsOutputFileExtensionComboBox_SelectedValueChanged(object sender, EventArgs e) {
            this.x264CodecSettings.OutputFileExtension = (string)(this.x264CodecSettingsOutputFileExtensionComboBox.SelectedValue);
        }

        private void X264CodecSettingsMaxEncodingTimeComboBox_SelectedValueChanged(object sender, EventArgs e) {
            this.x264CodecSettings.MaxEncodingTime = TimeSpan.Parse((string)(this.x264CodecSettingsMaxEncodingTimeComboBox.SelectedValue));
        }

        #endregion

        private void RootFolderPathTextBox_TextChanged(object sender, EventArgs e) {
            this.rootFolderPath = this.rootFolderPathTextBox.Text;
            this.LoadFolderToTreeView();
        }

        private void RootFolderPathBrowseButton_Click(object sender, EventArgs e) {
            if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK) {
                this.rootFolderPathTextBox.Text = this.folderBrowserDialog.SelectedPath;
                this.LoadFolderToTreeView();
            }
        }

        private void AviSynthSettingsOutputFolderPathBrowseButton_Click(object sender, EventArgs e) {
            if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK) {
                this.aviSynthSettingsOutputFolderPathTextBox.Text = this.folderBrowserDialog.SelectedPath;
            }
        }

        private void X264CodecSettingsOutputFolderPathBrowseButton_Click(object sender, EventArgs e) {
            if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK) {
                this.x264CodecSettingsOutputFolderPathTextBox.Text = this.folderBrowserDialog.SelectedPath;
            }
        }

        private void ProcessRadioButtonsCheckState() {
            if (this.aviSynthSettingsRadioButton.Checked) {
                this.aviSynthSettingsGroupBox.Enabled  = true;
                this.x264CodecSettingsGroupBox.Enabled = false;
            }
            else if (this.x264CodecSettingsRadioButton.Checked) {
                this.x264CodecSettingsGroupBox.Enabled = true;
                this.aviSynthSettingsGroupBox.Enabled  = false;
            }
            this.LoadFolderToTreeView();
        }

        private void AviSynthSettingsRadioButton_CheckedChanged(object sender, EventArgs e) {
            if (this.aviSynthSettingsRadioButton.Checked) {
                this.workMode = WorkMode.AviSynthScript;
                this.ProcessRadioButtonsCheckState();
            }
        }

        private void X264CodecSettingsRadioButton_CheckedChanged(object sender, EventArgs e) {
            if (this.x264CodecSettingsRadioButton.Checked) {
                this.workMode = WorkMode.X264Codec;
                this.ProcessRadioButtonsCheckState();
            }
        }

        private void AviSynthSettingsRadioButton_MouseEnter(object sender, EventArgs e) {
            this.aviSynthSettingsRadioButton.BackColor = OnMouseEnterColor;
            this.aviSynthSettingsGroupBox.BackColor    = OnMouseEnterColor;
        }

        private void AviSynthSettingsRadioButton_MouseLeave(object sender, EventArgs e) {
            this.aviSynthSettingsRadioButton.BackColor = OnMouseLeaveColor;
            this.aviSynthSettingsGroupBox.BackColor    = OnMouseLeaveColor;
        }

        private void X264CodecSettingsRadioButton_MouseEnter(object sender, EventArgs e) {
            this.x264CodecSettingsRadioButton.BackColor = OnMouseEnterColor;
            this.x264CodecSettingsGroupBox.BackColor    = OnMouseEnterColor;
        }

        private void X264CodecSettingsRadioButton_MouseLeave(object sender, EventArgs e) {
            this.x264CodecSettingsRadioButton.BackColor = OnMouseLeaveColor;
            this.x264CodecSettingsGroupBox.BackColor    = OnMouseLeaveColor;
        }
        
        private void LoadFolderToTreeView() {
            try {
                switch (this.workMode) {
                    case WorkMode.AviSynthScript: {
                        TreeViewUtils.LoadFolderToTreeView(this.pathesTreeView, this.rootFolderPath, this.aviSynthSettings.ShowFiles, this.aviSynthSettings.SearchPattern);
                        break;
                    }
                    case WorkMode.X264Codec: {
                        TreeViewUtils.LoadFolderToTreeView(this.pathesTreeView, this.rootFolderPath, this.x264CodecSettings.ShowFiles, this.x264CodecSettings.SearchPattern);
                        break;
                    }
                    case WorkMode.Undefined: {
                        return;
                    }
                }
                TreeNode rootNode = this.pathesTreeView.Nodes[0];
                rootNode.Checked = true;
                TreeViewUtils.SetCheckStateOfChildNodes(rootNode, TreeViewAction.ByKeyboard);
                this.pathesTreeView.ExpandAll();
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }

        private void PathesTreeView_AfterCheck(object sender, TreeViewEventArgs e) {
            TreeViewUtils.SetCheckStateOfChildNodes(e.Node, e.Action);
            TreeViewUtils.SetCheckStateOfParentNodes(e.Node, e.Action);
        }

        private void AviSynthSettingsCreateScriptsButton_Click(object sender, EventArgs e) {
            List<string> checkedPathesList = TreeViewUtils.GetCheckedFolders(this.pathesTreeView);
            if ((checkedPathesList == null) || (checkedPathesList.Count == 0)) {
                return;
            }
            foreach (string path in checkedPathesList) {
                AviSynthScript script = new AviSynthScript(path, this.aviSynthSettingsOutputFolderPathTextBox.Text, this.aviSynthSettings);
                script.GenerateScriptToFile();
            }
        }

        private void X264CodecSettingsEncodeFilesButton_Click(object sender, EventArgs e) {
            List<string> checkedPathesList = TreeViewUtils.GetCheckedFiles(this.pathesTreeView);
            if ((checkedPathesList == null) || (checkedPathesList.Count == 0)) {
                return;
            }
            if (!File.Exists(this.x264CodecSettings.CodecPath)) {
                MessageBox.Show(string.Format("Отсутствует запускаемый файл кодека:\n{0}", this.x264CodecSettings.CodecPath), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.x264CodecScripts = new List<X264CodecScript>();
            this.currentX264CodecScriptIndex = -1;
            foreach (string path in checkedPathesList) {
                X264CodecScript x264CodecScript = new X264CodecScript(path, this.x264CodecSettingsOutputFolderPathTextBox.Text, this.x264CodecSettings);
                x264CodecScript.CodecOutputDataReceived += new DataReceivedEventHandler(X264CodecScript_CodecOutputDataReceived);
                x264CodecScript.CodecErrorDataReceived  += new DataReceivedEventHandler(X264CodecScript_CodecErrorDataReceived);
                x264CodecScript.EncodeFileCompleted     += new EventHandler(X264CodecScript_EncodeFileCompleted);
                this.x264CodecScripts.Add(x264CodecScript);
            }
            this.currentX264CodecScriptIndex = 0;
            this.x264CodecScripts[this.currentX264CodecScriptIndex].StartEncodeFile();
        }

        private void X264CodecScript_CodecOutputDataReceived(object sender, DataReceivedEventArgs e) {
            if (this.InvokeRequired) {
                this.Invoke(new MethodInvoker(delegate() {
                    this.statusLabel.Text = e.Data;
                }));
            }
            else {
                this.statusLabel.Text = e.Data;
            }
        }

        private void X264CodecScript_CodecErrorDataReceived(object sender, DataReceivedEventArgs e) {
            if (this.InvokeRequired) {
                this.Invoke(new MethodInvoker(delegate() {
                    this.statusLabel.Text = e.Data;
                }));
            }
            else {
                this.statusLabel.Text = e.Data;
            }
        }
        
        private void X264CodecScript_EncodeFileCompleted(object sender, EventArgs e) {
            if (this.currentX264CodecScriptIndex < this.x264CodecScripts.Count - 1) {
                this.currentX264CodecScriptIndex++;
                this.x264CodecScripts[this.currentX264CodecScriptIndex].StartEncodeFile();
            }
            else {
                if (this.InvokeRequired) {
                    this.Invoke(new MethodInvoker(delegate() {
                        this.statusLabel.Text = "Completed!";
                    }));
                }
                else {
                    this.statusLabel.Text = "Completed!";
                }
            }
        }

    }

}
