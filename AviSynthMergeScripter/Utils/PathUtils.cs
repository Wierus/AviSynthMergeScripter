using System.Text.RegularExpressions;

namespace AviSynthMergeScripter.Utils {

    /// <summary>
    /// Утилиты для работы с путями (на основе регулярных выражений).
    /// </summary>
    public static class PathUtils {

        /// <summary>
        /// Шаблон LFS-пути (Local File System).
        /// </summary>
        private const string LFSPathPattern = @"^(?<Path>((?<Disk>[a-z]):)(\\(?<LastName>[^\x00-\x1F""*/:<>?\\|]+))*)(\\)?$";

        /// <summary>
        /// Шаблон UNC-пути (Universal Naming Convention).
        /// </summary>
        private const string UNCPathPattern = @"^(?<Path>(\\\\(?<Server>[^\x00-\x1F""*/:<>?\\|]+))(\\(?<LastName>[^\x00-\x1F""*/:<>?\\|]+))+)(\\)?$";

        /// <summary>
        /// Регулярное выражение для LFS-пути.
        /// </summary>
        private static readonly Regex LFSRegex = new Regex(LFSPathPattern, RegexOptions.IgnoreCase);

        /// <summary>
        /// Регулярное выражение для UNC-пути.
        /// </summary>
        private static readonly Regex UNCRegex = new Regex(UNCPathPattern, RegexOptions.IgnoreCase);

        /// <summary>
        /// Проверка пути на корректность.
        /// </summary>
        /// <param name="path">Проверяемый путь.</param>
        /// <returns>true, если путь соответствует LFS или UNC шаблону. false, иначе.</returns>
        public static bool IsValidPath(string path) {
            return LFSRegex.IsMatch(path) || UNCRegex.IsMatch(path);
        }

        /// <summary>
        /// Извлечение из пути самого последнего имени папки или файла (независимо от завершающего слэша).
        /// </summary>
        /// <param name="path">Обрабатываемый путь.</param>
        /// <returns>Для LFS: LastName или Disk. Для UNC: LastName. null, если указан некорректный путь.</returns>
        public static string GetLastName(string path) {
            if (LFSRegex.IsMatch(path)) {
                string lastName = LFSRegex.Match(path).Result("${LastName}");
                return (lastName != string.Empty) ? lastName : LFSRegex.Match(path).Result("${Disk}:");
            }
            else if (UNCRegex.IsMatch(path)) {
                string lastName = UNCRegex.Match(path).Result("${LastName}");
                return lastName;
            }
            else {
                return null;
            }
        }

        /// <summary>
        /// Получение пути с завершающим слэшем.
        /// </summary>
        /// <param name="path">Обрабатываемый путь.</param>
        /// <returns>Путь, в который добавлен завершающий слэш, если его не было. Исходный путь, если завершающий слэш был. null, если указан некорректный путь.</returns>
        public static string GetPathWithTrailingSlash(string path) {
            if (LFSRegex.IsMatch(path)) {
                return LFSRegex.Match(path).Result("${Path}\\");
            }
            else if (UNCRegex.IsMatch(path)) {
                return UNCRegex.Match(path).Result("${Path}\\");
            }
            else {
                return null;
            }
        }

        /// <summary>
        /// Получение пути без завершающего слэша.
        /// </summary>
        /// <param name="path">Обрабатываемый путь.</param>
        /// <returns>Путь, из которого убран завершающий слэш, если он был. Исходный путь, если завершающего слэша не было. null, если указан некорректный путь.</returns>
        public static string GetPathWithoutTrailingSlash(string path) {
            if (LFSRegex.IsMatch(path)) {
                return LFSRegex.Match(path).Result("${Path}");
            }
            else if (UNCRegex.IsMatch(path)) {
                return UNCRegex.Match(path).Result("${Path}");
            }
            else {
                return null;
            }
        }

        /// <summary>
        /// Получение форматированного пути для вывода.
        /// Соответствует возврату метода GetPathWithoutTrailingSlash.
        /// </summary>
        /// <param name="path">Обрабатываемый путь.</param>
        /// <returns>См. метод GetPathWithoutTrailingSlash.</returns>
        public static string GetFormattedPath(string path) {
            return GetPathWithoutTrailingSlash(path);
        }

        /// <summary>
        /// Извлечение расширения файла или папки из пути (извлечение части пути после последней точки).
        /// </summary>
        /// <param name="path">Обрабатываемый путь.</param>
        /// <returns>Расширение файла или папки (без точки). null, если в пути отсутствует расширение (отсутствует точка).</returns>
        public static string GetExtension(string path) {
            int indexOfDot = path.LastIndexOf('.');
            if (indexOfDot != -1) {
                return path.Substring(indexOfDot + 1, path.Length - indexOfDot - 1);
            }
            else {
                return null;
            }
        }

    }

}
