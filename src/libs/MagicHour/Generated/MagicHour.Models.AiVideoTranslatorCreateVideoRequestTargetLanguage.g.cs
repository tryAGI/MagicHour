
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Language to translate the video's speech into.<br/>
    /// Example: Spanish
    /// </summary>
    public enum AiVideoTranslatorCreateVideoRequestTargetLanguage
    {
        /// <summary>
        ///
        /// </summary>
        Afrikaans,
        /// <summary>
        ///
        /// </summary>
        Arabic,
        /// <summary>
        ///
        /// </summary>
        Bengali,
        /// <summary>
        ///
        /// </summary>
        Bulgarian,
        /// <summary>
        ///
        /// </summary>
        Catalan,
        /// <summary>
        ///
        /// </summary>
        ChineseSimplified,
        /// <summary>
        ///
        /// </summary>
        ChineseTraditional,
        /// <summary>
        ///
        /// </summary>
        Croatian,
        /// <summary>
        ///
        /// </summary>
        Czech,
        /// <summary>
        ///
        /// </summary>
        Danish,
        /// <summary>
        ///
        /// </summary>
        Dutch,
        /// <summary>
        ///
        /// </summary>
        English,
        /// <summary>
        ///
        /// </summary>
        Estonian,
        /// <summary>
        ///
        /// </summary>
        Finnish,
        /// <summary>
        ///
        /// </summary>
        French,
        /// <summary>
        ///
        /// </summary>
        German,
        /// <summary>
        ///
        /// </summary>
        Greek,
        /// <summary>
        ///
        /// </summary>
        Gujarati,
        /// <summary>
        ///
        /// </summary>
        Hebrew,
        /// <summary>
        ///
        /// </summary>
        Hindi,
        /// <summary>
        ///
        /// </summary>
        Hungarian,
        /// <summary>
        ///
        /// </summary>
        Indonesian,
        /// <summary>
        ///
        /// </summary>
        Italian,
        /// <summary>
        ///
        /// </summary>
        Japanese,
        /// <summary>
        ///
        /// </summary>
        Kannada,
        /// <summary>
        ///
        /// </summary>
        Kazakh,
        /// <summary>
        ///
        /// </summary>
        Korean,
        /// <summary>
        ///
        /// </summary>
        Latvian,
        /// <summary>
        ///
        /// </summary>
        Lithuanian,
        /// <summary>
        ///
        /// </summary>
        Malay,
        /// <summary>
        ///
        /// </summary>
        Malayalam,
        /// <summary>
        ///
        /// </summary>
        Marathi,
        /// <summary>
        ///
        /// </summary>
        Norwegian,
        /// <summary>
        ///
        /// </summary>
        Persian,
        /// <summary>
        ///
        /// </summary>
        Polish,
        /// <summary>
        ///
        /// </summary>
        Portuguese,
        /// <summary>
        ///
        /// </summary>
        Punjabi,
        /// <summary>
        ///
        /// </summary>
        Romanian,
        /// <summary>
        ///
        /// </summary>
        Russian,
        /// <summary>
        ///
        /// </summary>
        Serbian,
        /// <summary>
        ///
        /// </summary>
        Slovak,
        /// <summary>
        ///
        /// </summary>
        Slovenian,
        /// <summary>
        ///
        /// </summary>
        Spanish,
        /// <summary>
        ///
        /// </summary>
        Swahili,
        /// <summary>
        ///
        /// </summary>
        Swedish,
        /// <summary>
        ///
        /// </summary>
        Tamil,
        /// <summary>
        ///
        /// </summary>
        Telugu,
        /// <summary>
        ///
        /// </summary>
        Thai,
        /// <summary>
        ///
        /// </summary>
        Turkish,
        /// <summary>
        ///
        /// </summary>
        Ukrainian,
        /// <summary>
        ///
        /// </summary>
        Urdu,
        /// <summary>
        ///
        /// </summary>
        Vietnamese,
        /// <summary>
        ///
        /// </summary>
        Welsh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AiVideoTranslatorCreateVideoRequestTargetLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiVideoTranslatorCreateVideoRequestTargetLanguage value)
        {
            return value switch
            {
                AiVideoTranslatorCreateVideoRequestTargetLanguage.Afrikaans => "Afrikaans",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.Arabic => "Arabic",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.Bengali => "Bengali",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.Bulgarian => "Bulgarian",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.Catalan => "Catalan",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.ChineseSimplified => "Chinese (Simplified)",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.ChineseTraditional => "Chinese (Traditional)",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.Croatian => "Croatian",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.Czech => "Czech",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.Danish => "Danish",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.Dutch => "Dutch",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.English => "English",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.Estonian => "Estonian",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.Finnish => "Finnish",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.French => "French",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.German => "German",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.Greek => "Greek",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.Gujarati => "Gujarati",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.Hebrew => "Hebrew",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.Hindi => "Hindi",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.Hungarian => "Hungarian",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.Indonesian => "Indonesian",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.Italian => "Italian",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.Japanese => "Japanese",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.Kannada => "Kannada",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.Kazakh => "Kazakh",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.Korean => "Korean",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.Latvian => "Latvian",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.Lithuanian => "Lithuanian",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.Malay => "Malay",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.Malayalam => "Malayalam",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.Marathi => "Marathi",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.Norwegian => "Norwegian",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.Persian => "Persian",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.Polish => "Polish",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.Portuguese => "Portuguese",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.Punjabi => "Punjabi",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.Romanian => "Romanian",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.Russian => "Russian",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.Serbian => "Serbian",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.Slovak => "Slovak",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.Slovenian => "Slovenian",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.Spanish => "Spanish",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.Swahili => "Swahili",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.Swedish => "Swedish",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.Tamil => "Tamil",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.Telugu => "Telugu",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.Thai => "Thai",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.Turkish => "Turkish",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.Ukrainian => "Ukrainian",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.Urdu => "Urdu",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.Vietnamese => "Vietnamese",
                AiVideoTranslatorCreateVideoRequestTargetLanguage.Welsh => "Welsh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiVideoTranslatorCreateVideoRequestTargetLanguage? ToEnum(string value)
        {
            return value switch
            {
                "Afrikaans" => AiVideoTranslatorCreateVideoRequestTargetLanguage.Afrikaans,
                "Arabic" => AiVideoTranslatorCreateVideoRequestTargetLanguage.Arabic,
                "Bengali" => AiVideoTranslatorCreateVideoRequestTargetLanguage.Bengali,
                "Bulgarian" => AiVideoTranslatorCreateVideoRequestTargetLanguage.Bulgarian,
                "Catalan" => AiVideoTranslatorCreateVideoRequestTargetLanguage.Catalan,
                "Chinese (Simplified)" => AiVideoTranslatorCreateVideoRequestTargetLanguage.ChineseSimplified,
                "Chinese (Traditional)" => AiVideoTranslatorCreateVideoRequestTargetLanguage.ChineseTraditional,
                "Croatian" => AiVideoTranslatorCreateVideoRequestTargetLanguage.Croatian,
                "Czech" => AiVideoTranslatorCreateVideoRequestTargetLanguage.Czech,
                "Danish" => AiVideoTranslatorCreateVideoRequestTargetLanguage.Danish,
                "Dutch" => AiVideoTranslatorCreateVideoRequestTargetLanguage.Dutch,
                "English" => AiVideoTranslatorCreateVideoRequestTargetLanguage.English,
                "Estonian" => AiVideoTranslatorCreateVideoRequestTargetLanguage.Estonian,
                "Finnish" => AiVideoTranslatorCreateVideoRequestTargetLanguage.Finnish,
                "French" => AiVideoTranslatorCreateVideoRequestTargetLanguage.French,
                "German" => AiVideoTranslatorCreateVideoRequestTargetLanguage.German,
                "Greek" => AiVideoTranslatorCreateVideoRequestTargetLanguage.Greek,
                "Gujarati" => AiVideoTranslatorCreateVideoRequestTargetLanguage.Gujarati,
                "Hebrew" => AiVideoTranslatorCreateVideoRequestTargetLanguage.Hebrew,
                "Hindi" => AiVideoTranslatorCreateVideoRequestTargetLanguage.Hindi,
                "Hungarian" => AiVideoTranslatorCreateVideoRequestTargetLanguage.Hungarian,
                "Indonesian" => AiVideoTranslatorCreateVideoRequestTargetLanguage.Indonesian,
                "Italian" => AiVideoTranslatorCreateVideoRequestTargetLanguage.Italian,
                "Japanese" => AiVideoTranslatorCreateVideoRequestTargetLanguage.Japanese,
                "Kannada" => AiVideoTranslatorCreateVideoRequestTargetLanguage.Kannada,
                "Kazakh" => AiVideoTranslatorCreateVideoRequestTargetLanguage.Kazakh,
                "Korean" => AiVideoTranslatorCreateVideoRequestTargetLanguage.Korean,
                "Latvian" => AiVideoTranslatorCreateVideoRequestTargetLanguage.Latvian,
                "Lithuanian" => AiVideoTranslatorCreateVideoRequestTargetLanguage.Lithuanian,
                "Malay" => AiVideoTranslatorCreateVideoRequestTargetLanguage.Malay,
                "Malayalam" => AiVideoTranslatorCreateVideoRequestTargetLanguage.Malayalam,
                "Marathi" => AiVideoTranslatorCreateVideoRequestTargetLanguage.Marathi,
                "Norwegian" => AiVideoTranslatorCreateVideoRequestTargetLanguage.Norwegian,
                "Persian" => AiVideoTranslatorCreateVideoRequestTargetLanguage.Persian,
                "Polish" => AiVideoTranslatorCreateVideoRequestTargetLanguage.Polish,
                "Portuguese" => AiVideoTranslatorCreateVideoRequestTargetLanguage.Portuguese,
                "Punjabi" => AiVideoTranslatorCreateVideoRequestTargetLanguage.Punjabi,
                "Romanian" => AiVideoTranslatorCreateVideoRequestTargetLanguage.Romanian,
                "Russian" => AiVideoTranslatorCreateVideoRequestTargetLanguage.Russian,
                "Serbian" => AiVideoTranslatorCreateVideoRequestTargetLanguage.Serbian,
                "Slovak" => AiVideoTranslatorCreateVideoRequestTargetLanguage.Slovak,
                "Slovenian" => AiVideoTranslatorCreateVideoRequestTargetLanguage.Slovenian,
                "Spanish" => AiVideoTranslatorCreateVideoRequestTargetLanguage.Spanish,
                "Swahili" => AiVideoTranslatorCreateVideoRequestTargetLanguage.Swahili,
                "Swedish" => AiVideoTranslatorCreateVideoRequestTargetLanguage.Swedish,
                "Tamil" => AiVideoTranslatorCreateVideoRequestTargetLanguage.Tamil,
                "Telugu" => AiVideoTranslatorCreateVideoRequestTargetLanguage.Telugu,
                "Thai" => AiVideoTranslatorCreateVideoRequestTargetLanguage.Thai,
                "Turkish" => AiVideoTranslatorCreateVideoRequestTargetLanguage.Turkish,
                "Ukrainian" => AiVideoTranslatorCreateVideoRequestTargetLanguage.Ukrainian,
                "Urdu" => AiVideoTranslatorCreateVideoRequestTargetLanguage.Urdu,
                "Vietnamese" => AiVideoTranslatorCreateVideoRequestTargetLanguage.Vietnamese,
                "Welsh" => AiVideoTranslatorCreateVideoRequestTargetLanguage.Welsh,
                _ => null,
            };
        }
    }
}