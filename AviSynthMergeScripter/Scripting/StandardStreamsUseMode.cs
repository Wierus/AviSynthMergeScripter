namespace AviSynthMergeScripter.Scripting {

    /// <summary>
    /// Режимы использования стандартных потоков приложения.
    /// </summary>
    public enum StandardStreamsUseMode {

        /// <summary>
        /// Использование только стандартного потока вывода.
        /// </summary>
        UseOnlyStandardOutput,

        /// <summary>
        /// Использование только стандартного потока ошибок.
        /// </summary>
        UseOnlyStandardError,

        /// <summary>
        /// Использование обоих стандартных потоков: потока вывода и потока ошибок.
        /// </summary>
        UseBothStandardOutputAndStandardError,

        /// <summary>
        /// Отмена использования стандартных потоков приложения.
        /// </summary>
        UseNothing

    }

}
