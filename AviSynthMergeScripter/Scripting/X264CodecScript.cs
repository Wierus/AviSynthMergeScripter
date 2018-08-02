using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

using AviSynthMergeScripter.Utils;

namespace AviSynthMergeScripter.Scripting {

    /// <summary>
    /// Скрипт для кодека x264.
    /// </summary>
    public class X264CodecScript {

        /// <summary>
        /// Формат имени выходного файла.
        /// {0} - Имя кодируемого файла.
        /// {1} - Параметры командной строки кодека.
        /// {2} - Расширение выходного файла.
        /// </summary>
        private const string OutputFileNameFormat = "{0}.[{1}].{2}";

        /// <summary>
        /// Строка в имени выходного файла при отсутствии параметров кодека.
        /// </summary>
        private const string EmptyCodecOptionsString = "no options";

        /// <summary>
        /// Расширение лог-файла.
        /// </summary>
        private const string LogFileExtension = "log";

        /// <summary>
        /// Формат имени лог-файла.
        /// {0} - Путь к выходному файлу.
        /// {1} - Расширение лог-файла.
        /// </summary>
        private const string LogFileNameFormat = "{0}.{1}";

        /// <summary>
        /// Формат аргументов командной строки кодека.
        /// {0} - Параметры командной строки кодека.
        /// {1} - Путь к выходному файлу.
        /// {2} - Путь к кодируемому файлу.
        /// </summary>
        private const string CodecArgumentsFormat = "{0} -o \"{1}\" \"{2}\"";

        /// <summary>
        /// Путь к кодируемому файлу.
        /// </summary>
        private string inputFilePath;

        /// <summary>
        /// Путь к выходному файлу.
        /// </summary>
        private string outputFilePath;

        /// <summary>
        /// Настройки скрипта, загружаемые из XML-файла.
        /// </summary>
        private X264CodecSettings settings;

        /// <summary>
        /// Поток записи лог-файла.
        /// </summary>
        private StreamWriter logWriter;

        /// <summary>
        /// Флаг, указывающий, закрыт ли стандартный поток вывода кодека.
        /// </summary>
        private bool isCodecStandardOutputClosed;

        /// <summary>
        /// Флаг, указывающий, закрыт ли стандартный поток ошибок кодека.
        /// </summary>
        private bool isCodecStandardErrorClosed;
        
        /// <summary>
        /// Событие, происходящее при записи в стандартный поток вывода кодека.
        /// </summary>
        public event DataReceivedEventHandler CodecOutputDataReceived;

        /// <summary>
        /// Событие, происходящее при записи в стандартный поток ошибок кодека.
        /// </summary>
        public event DataReceivedEventHandler CodecErrorDataReceived;

        /// <summary>
        /// Событие, происходящее при завершении процесса кодирования.
        /// </summary>
        public event EventHandler EncodeFileCompleted;

        /// <summary>
        /// Конструктор скрипта.
        /// </summary>
        /// <param name="inputFilePath">Путь к кодируемому файлу.</param>
        /// <param name="outputFolderPath">Путь к выходной папке.</param>
        /// <param name="settings">Настройки скрипта, загружаемые из XML-файла.</param>
        public X264CodecScript(string inputFilePath, string outputFolderPath, X264CodecSettings settings) {
            this.settings = settings;
            this.inputFilePath = inputFilePath;
            string outputFileName = string.Format(OutputFileNameFormat, PathUtils.GetLastName(inputFilePath), (!string.IsNullOrEmpty(this.settings.CodecOptions)) ? this.settings.CodecOptions : EmptyCodecOptionsString, this.settings.OutputFileExtension);
            this.outputFilePath = PathUtils.GetPathWithTrailingSlash(outputFolderPath) + outputFileName;
        }

        /// <summary>
        /// Запуск кодирования файла с сохранением лога.
        /// </summary>
        public void StartEncodeFile() {
            this.logWriter = new StreamWriter(string.Format(LogFileNameFormat, this.outputFilePath, LogFileExtension));
            string arguments = string.Format(CodecArgumentsFormat, this.settings.CodecOptions, this.outputFilePath, this.inputFilePath);
            this.isCodecStandardOutputClosed = false;
            this.isCodecStandardErrorClosed = false;
            Process process = new Process {
                StartInfo = new ProcessStartInfo(this.settings.CodecPath, arguments) {
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true
                },
                EnableRaisingEvents = true
            };
            process.OutputDataReceived += new DataReceivedEventHandler(Process_OutputDataReceived);
            process.ErrorDataReceived += new DataReceivedEventHandler(Process_ErrorDataReceived);
            process.Exited += new EventHandler(Process_Exited);
            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
        }

        /// <summary>
        /// Обработка записи в стандартный поток вывода кодека.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные, относящиеся к событию.</param>
        private void Process_OutputDataReceived(object sender, DataReceivedEventArgs e) {
            if (e.Data != null) {
                lock (this.logWriter) {
                    this.logWriter.WriteLine(e.Data);
                    this.CodecOutputDataReceived(sender, e);
                }
            }
            else {
                this.isCodecStandardOutputClosed = true;
            }
        }

        /// <summary>
        /// Обработка записи в стандартный поток ошибок кодека.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные, относящиеся к событию.</param>
        private void Process_ErrorDataReceived(object sender, DataReceivedEventArgs e) {
            if (e.Data != null) {
                lock (this.logWriter) {
                    this.logWriter.WriteLine(e.Data);
                    this.CodecErrorDataReceived(sender, e);
                }
            }
            else {
                this.isCodecStandardErrorClosed = true;
            }
        }

        /// <summary>
        /// Обработка завершения процесса кодирования.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные, относящиеся к событию.</param>
        private void Process_Exited(object sender, EventArgs e) {
            while (!(this.isCodecStandardOutputClosed && this.isCodecStandardErrorClosed)) {
                Thread.Sleep(0);
            }
            this.logWriter.Close();
            this.EncodeFileCompleted(sender, e);
        }

    }

}
