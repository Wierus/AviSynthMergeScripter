﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AviSynthMergeScripter {

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
        /// Не указанный режим работы.
        /// </summary>
        Undefined

    }

}