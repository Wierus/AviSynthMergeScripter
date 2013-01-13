namespace AviSynthMergeScripter.Scripting {

    /// <summary>
    /// Настройки для AviSynth.
    /// </summary>
    public class AviSynthSettings {

        /// <summary>
        /// Флаг, указывающий, требуется ли отображать обрабатываемые файлы при построении дерева (на форме).
        /// </summary>
        private bool showFiles;

        /// <summary>
        /// Обрабатываемые файлы.
        /// </summary>
        private string searchPattern;

        /// <summary>
        /// Загружаемый модуль.
        /// </summary>
        private string loadingPlugin;

        /// <summary>
        /// Коэффициент сжатия.
        /// </summary>
        private string compressRatio;

        /// <summary>
        /// Выходное значение FPS.
        /// </summary>
        private string outputFPS;

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
        /// Загружаемый модуль.
        /// </summary>
        public string LoadingPlugin {
            get {
                return this.loadingPlugin;
            }
            set {
                this.loadingPlugin = value;
            }
        }

        /// <summary>
        /// Коэффициент сжатия.
        /// </summary>
        public string CompressRatio {
            get {
                return this.compressRatio;
            }
            set {
                this.compressRatio = value;
            }
        }

        /// <summary>
        /// Выходное значение FPS.
        /// </summary>
        public string OutputFPS {
            get {
                return this.outputFPS;
            }
            set {
                this.outputFPS = value;
            }
        }

        public AviSynthSettings() {
        }

    }

}
