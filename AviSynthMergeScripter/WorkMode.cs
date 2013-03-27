﻿namespace AviSynthMergeScripter {

    /// <summary>
    /// Режим работы программы.
    /// </summary>
    public enum WorkMode {

        /// <summary>
        /// Режим генерации скриптов AviSynth.
        /// </summary>
        AviSynthScript,

        /// <summary>
        /// Режим кодирования x264.
        /// </summary>
        X264Codec,

        /// <summary>
        /// Режим чтения и сохранения свойств видеофайлов.
        /// </summary>
        VideoFilePropertiesReader,

        /// <summary>
        /// Не указанный режим работы.
        /// </summary>
        Undefined

    }

}
