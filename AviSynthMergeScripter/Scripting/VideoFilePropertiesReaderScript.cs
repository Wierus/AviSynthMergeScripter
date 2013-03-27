using System.Diagnostics;
using System.Xml;

namespace AviSynthMergeScripter.Scripting {

    /// <summary>
    /// Скрипт для чтения и сохранения свойств видеофайлов.
    /// </summary>
    public class VideoFilePropertiesReaderScript {

        /// <summary>
        /// Формат аргументов командной строки программы чтения.
        /// {0} - Параметры командной строки кодека.
        /// {1} - Путь к видеофайлу, свойства которого требуется прочитать.
        /// </summary>
        private const string ReaderArgumentsFormat = "{0} \"{1}\"";
        
        /// <summary>
        /// Настройки скрипта, загружаемые из XML-файла.
        /// </summary>
        private VideoFilePropertiesReaderSettings settings;

        /// <summary>
        /// Путь к видеофайлу, свойства которого требуется прочитать.
        /// </summary>
        private string inputFilePath;

        /// <summary>
        /// Конструктор скрипта.
        /// </summary>
        /// <param name="inputFilePath">Путь к видеофайлу, свойства которого требуется прочитать.</param>
        /// <param name="settings">Настройки скрипта, загружаемые из XML-файла.</param>
        public VideoFilePropertiesReaderScript(string inputFilePath, VideoFilePropertiesReaderSettings settings) {
            this.settings = settings;
            this.inputFilePath = inputFilePath;
        }

        /// <summary>
        /// Чтение свойств видеофайла.
        /// </summary>
        /// <returns>Свойства видеофайла.</returns>
        public VideoFileProperties ReadProperties() {
            string arguments = string.Format(ReaderArgumentsFormat, "-f --output=XML", this.inputFilePath);
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo(this.settings.ReaderPath, arguments);
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.Start();
            XmlDocument xmlStreamProperties = new XmlDocument();
            switch (this.settings.StandardStreamsUseMode) {
                case StandardStreamsUseMode.UseOnlyStandardOutput: {
                    xmlStreamProperties.LoadXml(process.StandardOutput.ReadToEnd());
                    break;
                }
                case StandardStreamsUseMode.UseOnlyStandardError: {
                    xmlStreamProperties.LoadXml(process.StandardError.ReadToEnd());
                    break;
                }
            }
            return new VideoFileProperties(this.inputFilePath, xmlStreamProperties);
        }

    }

}
