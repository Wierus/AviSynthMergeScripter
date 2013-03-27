using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml;

using AviSynthMergeScripter.Utils;

namespace AviSynthMergeScripter.Scripting {

    /// <summary>
    /// Свойства видеофайла, сохраняемые в таблице базы данных.
    /// </summary>
    public class VideoFileProperties {

        /// <summary>
        /// Путь к видеофайлу.
        /// </summary>
        private string filePath;

        /// <summary>
        /// Вспомогательный объект, хранящий некоторые свойства файла.
        /// Используется для открытия и чтения содержимого файла в поток в памяти.
        /// </summary>
        private FileInfo fileInfo;

        /// <summary>
        /// Временный поток в памяти, хранящий содержимое файла.
        /// Используется для вычисления различных типов хэшей файла.
        /// </summary>
        private MemoryStream stream;

        /// <summary>
        /// Глобальный уникальный идентификатор файла.
        /// </summary>
        public Guid ID;
        
        /// <summary>
        /// Название канала видеокамеры, с которой записан файл.
        /// Извлекается из пути к файлу согласно шаблону "ChannelPattern".
        /// Принимает значение null, если название канала не соответствует шаблону.
        /// </summary>
        public string Channel;
        
        /// <summary>
        /// Имя файла без расширения.
        /// </summary>
        public string Name;

        /// <summary>
        /// Расширение файла без точки.
        /// </summary>
        public string Extension;

        /// <summary>
        /// Размер файла в байтах.
        /// </summary>
        public long Length;

        /// <summary>
        /// Дата и время создания файла.
        /// Извлекается из пути к файлу согласно шаблону "DateTimePattern".
        /// Принимает значение null, если дата и время не соответствуют шаблону.
        /// </summary>
        public Nullable<DateTime> DateTime;

        /// <summary>
        /// Дата и время последней операции записи в файл.
        /// </summary>
        public DateTime LastWriteDateTime;

        /// <summary>
        /// MD5-хэш файла.
        /// </summary>
        public byte[] MD5;

        /// <summary>
        /// SHA512-хэш файла.
        /// </summary>
        public byte[] SHA512;

        /// <summary>
        /// Свойства видеофайла, представленные в виде XML-документа.
        /// </summary>
        public XmlDocument XMLStreamProperties;

        /// <summary>
        /// Шаблон названия канала видеокамеры.
        /// </summary>
        private const string ChannelPattern  = @"\\(?<Channel>CH[^\x00-\x1F""*/:<>?\\|]+)\\";

        /// <summary>
        /// Шаблон даты и времени создания файла.
        /// </summary>
        private const string DateTimePattern = @"(?<Year>\d{4})_(?<Month>\d{2})_(?<Day>\d{2})__(?<Hour>\d{2})_(?<Minute>\d{2})_(?<Second>\d{2})";

        /// <summary>
        /// Регулярное выражение для названия канала видеокамеры.
        /// </summary>
        private static readonly Regex ChannelRegex  = new Regex(ChannelPattern, RegexOptions.IgnoreCase);

        /// <summary>
        /// Регулярное выражение для даты и времени создания файла.
        /// </summary>
        private static readonly Regex DateTimeRegex = new Regex(DateTimePattern, RegexOptions.IgnoreCase);

        /// <summary>
        /// Конструктор свойств видеофайла.
        /// </summary>
        /// <param name="filePath">Путь к видеофайлу.</param>
        /// <param name="xmlStreamProperties">Свойства видеофайла, представленные в виде XML-документа.</param>
        public VideoFileProperties(string filePath, XmlDocument xmlStreamProperties) {
            this.filePath = filePath;
            this.XMLStreamProperties = xmlStreamProperties;
            this.fileInfo = new FileInfo(this.filePath);
            this.stream = new MemoryStream();
            this.stream.SetLength(this.fileInfo.Length);
            this.fileInfo.OpenRead().Read(stream.GetBuffer(), 0, (int)this.fileInfo.Length);
            this.ID                = this.GetID();
            this.Channel           = this.GetChannel();
            this.Name              = this.GetName();
            this.Extension         = this.GetExtension();
            this.Length            = this.GetLength();
            this.DateTime          = this.GetDateTime();
            this.LastWriteDateTime = this.GetLastWriteDateTime();
            this.MD5               = this.GetMD5();
            this.SHA512            = this.GetSHA512();
            this.stream.Close();
        }

        /// <summary>
        /// Получение глобального уникального идентификатора файла.
        /// </summary>
        /// <returns>Глобальный уникальный идентификатор файла.</returns>
        private Guid GetID() {
            return Guid.NewGuid();
        }

        /// <summary>
        /// Извлечение названия канала видеокамеры из пути к файлу согласно шаблону "DateTimePattern".
        /// </summary>
        /// <returns>Название канала видеокамеры, с которой записан файл. null, если название канала не соответствует шаблону.</returns>
        private string GetChannel() {
            if (ChannelRegex.IsMatch(this.filePath)) {
                return ChannelRegex.Match(this.filePath).Result("${Channel}");
            }
            else {
                return null;
            }
        }

        /// <summary>
        /// Извлечение имени файла без расширения из пути к файлу.
        /// </summary>
        /// <returns>Имя файла без расширения.</returns>
        private string GetName() {
            return Path.GetFileNameWithoutExtension(this.filePath);
        }

        /// <summary>
        /// Извлечение расширения файла без точки из пути к файлу.
        /// </summary>
        /// <returns>Расширение файла без точки.</returns>
        private string GetExtension() {
            return PathUtils.GetExtension(this.filePath);
        }

        /// <summary>
        /// Получение размера файла в байтах.
        /// </summary>
        /// <returns>Размер файла в байтах.</returns>
        private long GetLength() {
            return this.fileInfo.Length;
        }

        /// <summary>
        /// Извлечение даты и времени создания файла из пути к файлу согласно шаблону "DateTimePattern".
        /// </summary>
        /// <returns>Дата и время создания файла. null, если дата и время не соответствуют шаблону.</returns>
        private Nullable<DateTime> GetDateTime() {
            if (DateTimeRegex.IsMatch(this.filePath)) {
                return new DateTime(int.Parse(DateTimeRegex.Match(this.filePath).Result("${Year}")), int.Parse(DateTimeRegex.Match(this.filePath).Result("${Month}")), int.Parse(DateTimeRegex.Match(this.filePath).Result("${Day}")), int.Parse(DateTimeRegex.Match(this.filePath).Result("${Hour}")), int.Parse(DateTimeRegex.Match(this.filePath).Result("${Minute}")), int.Parse(DateTimeRegex.Match(this.filePath).Result("${Second}")));
            }
            else {
                return null;
            }
        }

        /// <summary>
        /// Получение даты и времени последней операции записи в файл.
        /// </summary>
        /// <returns>Дата и время последней операции записи в файл.</returns>
        private DateTime GetLastWriteDateTime() {
            return this.fileInfo.LastWriteTime;
        }

        /// <summary>
        /// Вычисление MD5-хэша файла.
        /// </summary>
        /// <returns>MD5-хэш файла.</returns>
        private byte[] GetMD5() {
            this.stream.Seek(0, SeekOrigin.Begin);
            byte[] hash = System.Security.Cryptography.MD5.Create().ComputeHash(this.stream);
            return hash;
        }

        /// <summary>
        /// Вычисление SHA512-хэша файла.
        /// </summary>
        /// <returns>SHA512-хэш файла.</returns>
        private byte[] GetSHA512() {
            this.stream.Seek(0, SeekOrigin.Begin);
            byte[] hash = System.Security.Cryptography.SHA512.Create().ComputeHash(this.stream);
            return hash;
        }

    }

}
