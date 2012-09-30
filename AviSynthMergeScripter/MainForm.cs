using System;
using System.IO;
using System.Windows.Forms;

namespace AviSynthMergeScripter {

    public partial class MainForm : Form {

        private string folder;
        private string loadPluginString;
        private string searchPattern;
        private string scriptFileNamePrefix;
        private string scriptFileExtension;
        private string compressRatio;
        private string targetFPS;

        private Settings settings;

        public MainForm() {
            this.InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            this.folderTextBox.Text = Application.StartupPath;
            this.settings = new Settings();
            this.loadPluginStringComboBox.Items.AddRange(this.settings.GetSettingValues("LoadPluginString").ToArray());
            this.searchPatternСomboBox.Items.AddRange(this.settings.GetSettingValues("SearchPattern").ToArray());
            this.scriptFileNamePrefixСomboBox.Items.AddRange(this.settings.GetSettingValues("ScriptFileNamePrefix").ToArray());
            this.scriptFileExtensionСomboBox.Items.AddRange(this.settings.GetSettingValues("ScriptFileExtension").ToArray());
            this.compressRatioComboBox.Items.AddRange(this.settings.GetSettingValues("CompressRatio").ToArray());
            this.targetFPSComboBox.Items.AddRange(this.settings.GetSettingValues("TargetFPS").ToArray());
            this.loadPluginStringComboBox.SelectedItem     = this.settings.GetDefaultSettingValue("LoadPluginString");
            this.searchPatternСomboBox.SelectedItem        = this.settings.GetDefaultSettingValue("SearchPattern");
            this.scriptFileNamePrefixСomboBox.SelectedItem = this.settings.GetDefaultSettingValue("ScriptFileNamePrefix");
            this.scriptFileExtensionСomboBox.SelectedItem  = this.settings.GetDefaultSettingValue("ScriptFileExtension");
            this.compressRatioComboBox.SelectedItem        = this.settings.GetDefaultSettingValue("CompressRatio");
            this.targetFPSComboBox.SelectedItem            = this.settings.GetDefaultSettingValue("TargetFPS");
        }

        private void LoadSettings() {
            this.folder               = Utils.AddSlashAtEndOfPath(this.folderTextBox.Text);
            this.loadPluginString     = this.loadPluginStringComboBox.Text;
            this.searchPattern        = this.searchPatternСomboBox.Text;
            this.scriptFileNamePrefix = this.scriptFileNamePrefixСomboBox.Text;
            this.scriptFileExtension  = this.scriptFileExtensionСomboBox.Text;
            this.compressRatio        = this.compressRatioComboBox.Text;
            this.targetFPS            = this.targetFPSComboBox.Text;
        }

        private void browseButton_Click(object sender, EventArgs e) {
            if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK) {
                this.folderTextBox.Text = this.folderBrowserDialog.SelectedPath;
            }
        }

        private void createScriptButton_Click(object sender, EventArgs e) {
            this.LoadSettings();
            string scriptFileName = string.Format("{0}{1} {2} [x{3}@{4}fps]", this.scriptFileNamePrefix, Path.GetFileName(Path.GetDirectoryName(Path.GetDirectoryName(this.folder))), Path.GetFileName(Path.GetDirectoryName(this.folder)), this.compressRatio, this.targetFPS);
            StreamWriter writer = new StreamWriter(string.Format("{0}.{1}", scriptFileName, this.scriptFileExtension));
            writer.WriteLine(this.loadPluginString);
            writer.WriteLine("K = {0}", this.compressRatio);
            string[] files = Directory.GetFiles(this.folder, this.searchPattern);
            Array.Sort(files);
            int filesCount = files.Length;
            writer.WriteLine("MergedClip = \\");
            for (int i = 0; i < filesCount - 1; i++) {
                writer.WriteLine("ChangeFPS(AssumeFPS(FFVideoSource(\"{0}\", -1, true, \"\", -1, 1, \"\", 1), K * Framerate(FFVideoSource(\"{0}\", -1, true, \"\", -1, 1, \"\", 1))), {1}, false) + \\", files[i], this.targetFPS);
            }
            writer.WriteLine("ChangeFPS(AssumeFPS(FFVideoSource(\"{0}\", -1, true, \"\", -1, 1, \"\", 1), K * Framerate(FFVideoSource(\"{0}\", -1, true, \"\", -1, 1, \"\", 1))), {1}, false)", files[filesCount - 1], this.targetFPS);
            writer.WriteLine("return MergedClip");
            writer.Close();
        }

    }

}
