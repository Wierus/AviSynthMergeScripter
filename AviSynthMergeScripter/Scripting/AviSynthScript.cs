using System;
using System.IO;

using AviSynthMergeScripter.Utils;

namespace AviSynthMergeScripter.Scripting {

    /// <summary>
    /// Генерируемый скрипт для AviSynth.
    /// </summary>
    public class AviSynthScript {

        /// <summary>
        /// Расширение файла генерируемого скрипта.
        /// </summary>
        private const string ScriptFileExtension = "avs";

        /// <summary>
        /// Формат имени файла генерируемого скрипта.
        /// {0} - Имя папки, для которой генерируется скрипт.
        /// {1} - Коэффициент сжатия.
        /// {2} - Выходное значение FPS.
        /// {3} - Расширение файла генерируемого скрипта.
        /// </summary>
        private const string OutputFileNameFormat = "{0} [x{1}@{2}fps].{3}";

        /// <summary>
        /// Путь к папке, для которой генерируется скрипт.
        /// </summary>
        private string inputFolderPath;

        /// <summary>
        /// Путь к файлу генерируемого скрипта.
        /// </summary>
        private string outputFilePath;

        /// <summary>
        /// Настройки скрипта, загружаемые из XML-файла.
        /// </summary>
        private AviSynthSettings settings;

        /// <summary>
        /// Строка изменения FPS.
        /// {0} - Путь к обрабатываемому файлу.
        /// {1} - Выходное значение FPS.
        /// </summary>
        private const string ChangeFPSFormatString = "ChangeFPS(AssumeFPS(FFVideoSource(\"{0}\", -1, true, \"\", -1, 1, \"\", 1), R * Framerate(FFVideoSource(\"{0}\", -1, true, \"\", -1, 1, \"\", 1))), {1}, false)";

        /// <summary>
        /// Конструктор скрипта.
        /// </summary>
        /// <param name="inputFolderPath">Путь к папке, для которой генерируется скрипт.</param>
        /// <param name="outputFolderPath">Путь к папке генерируемого скрипта.</param>
        /// <param name="settings">Настройки скрипта, загружаемые из XML-файла.</param>
        public AviSynthScript(string inputFolderPath, string outputFolderPath, AviSynthSettings settings) {
            this.settings = settings;
            this.inputFolderPath = inputFolderPath;
            string outputFileName = string.Format(OutputFileNameFormat, PathUtils.GetLastName(this.inputFolderPath), this.settings.CompressRatio, this.settings.OutputFPS, ScriptFileExtension);
            this.outputFilePath = PathUtils.GetPathWithTrailingSlash(outputFolderPath) + outputFileName;
        }

        /// <summary>
        /// Генерация скрипта и сохранение его в файл.
        /// Скрипт не будет сгенерирован, если в папке отсутствуют обрабатываемые файлы.
        /// </summary>
        public void GenerateScriptToFile() {
            if (!Directory.Exists(this.inputFolderPath)) {
                return;
            }
            string[] files = Directory.GetFiles(this.inputFolderPath, this.settings.SearchPattern);
            int filesCount = files.Length;
            if (filesCount == 0) {
                return;
            }
            Array.Sort(files);
            StreamWriter writer = new StreamWriter(this.outputFilePath);
            writer.WriteLine("LoadPlugin(\"{0}\")", this.settings.LoadingPlugin);
            writer.WriteLine("R = {0}", this.settings.CompressRatio);
            writer.WriteLine("FPS = {0}", this.settings.OutputFPS);
            writer.WriteLine("MergedClip = \\");
            for (int i = 0; i < filesCount; i++) {
                // добавление соединителя строк для всех строк, кроме последней
                string formatString = (i < filesCount - 1) ? ChangeFPSFormatString + " + \\" : ChangeFPSFormatString;
                string line = string.Format(formatString, files[i], "FPS");
                if (!string.IsNullOrEmpty(this.settings.SourceReplaceText)) {
                    line = line.Replace(this.settings.SourceReplaceText, this.settings.TargetReplaceText);
                }
                writer.WriteLine(line);
            }
            writer.WriteLine("return MergedClip");
            writer.Close();
        }

    }

}
