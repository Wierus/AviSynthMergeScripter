using System.IO;

namespace AviSynthMergeScripter {

    public static class Utils {

        /// <summary>Возвращает путь с обязательным слэшем в конце.</summary>
        /// <param name="path">Путь к папке.</param>
        /// <returns>Путь со слэшем в конце.</returns>
        public static string AddSlashAtEndOfPath(string path) {
            if (path[path.Length - 1] != Path.DirectorySeparatorChar) {
                path += Path.DirectorySeparatorChar;
            }
            return path;
        }

    }

}
