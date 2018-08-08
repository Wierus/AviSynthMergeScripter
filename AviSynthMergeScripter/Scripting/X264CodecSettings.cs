using System;

namespace AviSynthMergeScripter.Scripting {

    /// <summary>
    /// Настройки для кодека x264.
    /// </summary>
    public class X264CodecSettings {
        
        /// <summary>
        /// Флаг, указывающий, требуется ли отображать обрабатываемые файлы при построении дерева (на форме).
        /// </summary>
        private bool showFiles;

        /// <summary>
        /// Обрабатываемые файлы.
        /// </summary>
        private string searchPattern;

        /// <summary>
        /// Путь к кодеку.
        /// </summary>
        private string codecPath;

        /// <summary>
        /// Параметры командной строки кодека.
        /// </summary>
        private string codecOptions;

        /// <summary>
        /// Расширение выходного файла.
        /// </summary>
        private string outputFileExtension;

        /// <summary>
        /// Максимально допустимое время кодирования файла, по истечении которого процесс кодека будет принудительно завершен.
        /// </summary>
        private TimeSpan maxEncodingTime;

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
        /// Путь к кодеку.
        /// </summary>
        public string CodecPath {
            get {
                return this.codecPath;
            }
            set {
                this.codecPath = value;
            }
        }

        /// <summary>
        /// Параметры командной строки кодека.
        /// </summary>
        public string CodecOptions {
            get {
                return this.codecOptions;
            }
            set {
                this.codecOptions = value;
            }
        }

        /// <summary>
        /// Расширение выходного файла.
        /// </summary>
        public string OutputFileExtension {
            get {
                return this.outputFileExtension;
            }
            set {
                this.outputFileExtension = value;
            }
        }

        /// <summary>
        /// Максимально допустимое время кодирования файла, по истечении которого процесс кодека будет принудительно завершен.
        /// </summary>
        public TimeSpan MaxEncodingTime {
            get {
                return this.maxEncodingTime;
            }
            set {
                this.maxEncodingTime = value;
            }
        }

        public X264CodecSettings() {
        }

    }

}
