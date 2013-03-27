namespace AviSynthMergeScripter.Scripting {

    /// <summary>
    /// Настройки для сохранения свойств видеофайлов.
    /// </summary>
    public class VideoFilePropertiesReaderSettings {

        /// <summary>
        /// Флаг, указывающий, требуется ли отображать обрабатываемые файлы при построении дерева (на форме).
        /// </summary>
        private bool showFiles;

        /// <summary>
        /// Обрабатываемые файлы.
        /// </summary>
        private string searchPattern;

        /// <summary>
        /// Путь к программе чтения свойств видеофайлов.
        /// </summary>
        private string readerPath;

        /// <summary>
        /// Режим использования стандартных потоков программы чтения.
        /// </summary>
        private StandardStreamsUseMode standardStreamsUseMode;

        /// <summary>
        /// Флаг, указывающий, требуется ли отображать обрабатываемые файлы при построении дерева (на форме).
        /// </summary>
        public bool ShowFiles {
            get {
                return this.showFiles;
            }
            set {
                this.showFiles = value;
            }
        }

        /// <summary>
        /// Обрабатываемые файлы.
        /// </summary>
        public string SearchPattern {
            get {
                return this.searchPattern;
            }
            set {
                this.searchPattern = value;
            }
        }

        /// <summary>
        /// Путь к программе чтения свойств видеофайлов.
        /// </summary>
        public string ReaderPath {
            get {
                return this.readerPath;
            }
            set {
                this.readerPath = value;
            }
        }

        /// <summary>
        /// Режим использования стандартных потоков программы чтения.
        /// </summary>
        public StandardStreamsUseMode StandardStreamsUseMode {
            get {
                return this.standardStreamsUseMode;
            }
            set {
                this.standardStreamsUseMode = value;
            }
        }

        public VideoFilePropertiesReaderSettings() {
        }

    }

}
