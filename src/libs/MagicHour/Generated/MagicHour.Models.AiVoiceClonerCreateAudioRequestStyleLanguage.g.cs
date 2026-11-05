
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Spoken language. Use a canonical lowercase language name, or auto to detect the language from the text. Defaults to auto.<br/>
    /// Default Value: auto<br/>
    /// Example: spanish
    /// </summary>
    public enum AiVoiceClonerCreateAudioRequestStyleLanguage
    {
        /// <summary>
        ///
        /// </summary>
        Afrikaans,
        /// <summary>
        ///
        /// </summary>
        Albanian,
        /// <summary>
        ///
        /// </summary>
        Amharic,
        /// <summary>
        ///
        /// </summary>
        Arabic,
        /// <summary>
        ///
        /// </summary>
        Armenian,
        /// <summary>
        ///
        /// </summary>
        Assamese,
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        Azerbaijani,
        /// <summary>
        ///
        /// </summary>
        Basque,
        /// <summary>
        ///
        /// </summary>
        Belarusian,
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
        Burmese,
        /// <summary>
        ///
        /// </summary>
        Cantonese,
        /// <summary>
        ///
        /// </summary>
        Catalan,
        /// <summary>
        ///
        /// </summary>
        Cebuano,
        /// <summary>
        ///
        /// </summary>
        Chinese,
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
        Galician,
        /// <summary>
        ///
        /// </summary>
        Georgian,
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
        HaitianCreole,
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
        Icelandic,
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
        Javanese,
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
        Konkani,
        /// <summary>
        ///
        /// </summary>
        Korean,
        /// <summary>
        ///
        /// </summary>
        Lao,
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
        Luxembourgish,
        /// <summary>
        ///
        /// </summary>
        Macedonian,
        /// <summary>
        ///
        /// </summary>
        Maithili,
        /// <summary>
        ///
        /// </summary>
        Malagasy,
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
        Mongolian,
        /// <summary>
        ///
        /// </summary>
        Nepali,
        /// <summary>
        ///
        /// </summary>
        Norwegian,
        /// <summary>
        ///
        /// </summary>
        Odia,
        /// <summary>
        ///
        /// </summary>
        Pashto,
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
        Sindhi,
        /// <summary>
        ///
        /// </summary>
        Sinhala,
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
        Tagalog,
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
        Uzbek,
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
    public static class AiVoiceClonerCreateAudioRequestStyleLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiVoiceClonerCreateAudioRequestStyleLanguage value)
        {
            return value switch
            {
                AiVoiceClonerCreateAudioRequestStyleLanguage.Afrikaans => "afrikaans",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Albanian => "albanian",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Amharic => "amharic",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Arabic => "arabic",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Armenian => "armenian",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Assamese => "assamese",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Auto => "auto",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Azerbaijani => "azerbaijani",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Basque => "basque",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Belarusian => "belarusian",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Bengali => "bengali",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Bulgarian => "bulgarian",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Burmese => "burmese",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Cantonese => "cantonese",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Catalan => "catalan",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Cebuano => "cebuano",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Chinese => "chinese",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Croatian => "croatian",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Czech => "czech",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Danish => "danish",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Dutch => "dutch",
                AiVoiceClonerCreateAudioRequestStyleLanguage.English => "english",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Estonian => "estonian",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Finnish => "finnish",
                AiVoiceClonerCreateAudioRequestStyleLanguage.French => "french",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Galician => "galician",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Georgian => "georgian",
                AiVoiceClonerCreateAudioRequestStyleLanguage.German => "german",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Greek => "greek",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Gujarati => "gujarati",
                AiVoiceClonerCreateAudioRequestStyleLanguage.HaitianCreole => "haitian creole",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Hebrew => "hebrew",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Hindi => "hindi",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Hungarian => "hungarian",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Icelandic => "icelandic",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Indonesian => "indonesian",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Italian => "italian",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Japanese => "japanese",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Javanese => "javanese",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Kannada => "kannada",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Kazakh => "kazakh",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Konkani => "konkani",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Korean => "korean",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Lao => "lao",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Latvian => "latvian",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Lithuanian => "lithuanian",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Luxembourgish => "luxembourgish",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Macedonian => "macedonian",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Maithili => "maithili",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Malagasy => "malagasy",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Malay => "malay",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Malayalam => "malayalam",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Marathi => "marathi",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Mongolian => "mongolian",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Nepali => "nepali",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Norwegian => "norwegian",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Odia => "odia",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Pashto => "pashto",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Persian => "persian",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Polish => "polish",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Portuguese => "portuguese",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Punjabi => "punjabi",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Romanian => "romanian",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Russian => "russian",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Serbian => "serbian",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Sindhi => "sindhi",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Sinhala => "sinhala",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Slovak => "slovak",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Slovenian => "slovenian",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Spanish => "spanish",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Swahili => "swahili",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Swedish => "swedish",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Tagalog => "tagalog",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Tamil => "tamil",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Telugu => "telugu",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Thai => "thai",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Turkish => "turkish",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Ukrainian => "ukrainian",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Urdu => "urdu",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Uzbek => "uzbek",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Vietnamese => "vietnamese",
                AiVoiceClonerCreateAudioRequestStyleLanguage.Welsh => "welsh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiVoiceClonerCreateAudioRequestStyleLanguage? ToEnum(string value)
        {
            return value switch
            {
                "afrikaans" => AiVoiceClonerCreateAudioRequestStyleLanguage.Afrikaans,
                "albanian" => AiVoiceClonerCreateAudioRequestStyleLanguage.Albanian,
                "amharic" => AiVoiceClonerCreateAudioRequestStyleLanguage.Amharic,
                "arabic" => AiVoiceClonerCreateAudioRequestStyleLanguage.Arabic,
                "armenian" => AiVoiceClonerCreateAudioRequestStyleLanguage.Armenian,
                "assamese" => AiVoiceClonerCreateAudioRequestStyleLanguage.Assamese,
                "auto" => AiVoiceClonerCreateAudioRequestStyleLanguage.Auto,
                "azerbaijani" => AiVoiceClonerCreateAudioRequestStyleLanguage.Azerbaijani,
                "basque" => AiVoiceClonerCreateAudioRequestStyleLanguage.Basque,
                "belarusian" => AiVoiceClonerCreateAudioRequestStyleLanguage.Belarusian,
                "bengali" => AiVoiceClonerCreateAudioRequestStyleLanguage.Bengali,
                "bulgarian" => AiVoiceClonerCreateAudioRequestStyleLanguage.Bulgarian,
                "burmese" => AiVoiceClonerCreateAudioRequestStyleLanguage.Burmese,
                "cantonese" => AiVoiceClonerCreateAudioRequestStyleLanguage.Cantonese,
                "catalan" => AiVoiceClonerCreateAudioRequestStyleLanguage.Catalan,
                "cebuano" => AiVoiceClonerCreateAudioRequestStyleLanguage.Cebuano,
                "chinese" => AiVoiceClonerCreateAudioRequestStyleLanguage.Chinese,
                "croatian" => AiVoiceClonerCreateAudioRequestStyleLanguage.Croatian,
                "czech" => AiVoiceClonerCreateAudioRequestStyleLanguage.Czech,
                "danish" => AiVoiceClonerCreateAudioRequestStyleLanguage.Danish,
                "dutch" => AiVoiceClonerCreateAudioRequestStyleLanguage.Dutch,
                "english" => AiVoiceClonerCreateAudioRequestStyleLanguage.English,
                "estonian" => AiVoiceClonerCreateAudioRequestStyleLanguage.Estonian,
                "finnish" => AiVoiceClonerCreateAudioRequestStyleLanguage.Finnish,
                "french" => AiVoiceClonerCreateAudioRequestStyleLanguage.French,
                "galician" => AiVoiceClonerCreateAudioRequestStyleLanguage.Galician,
                "georgian" => AiVoiceClonerCreateAudioRequestStyleLanguage.Georgian,
                "german" => AiVoiceClonerCreateAudioRequestStyleLanguage.German,
                "greek" => AiVoiceClonerCreateAudioRequestStyleLanguage.Greek,
                "gujarati" => AiVoiceClonerCreateAudioRequestStyleLanguage.Gujarati,
                "haitian creole" => AiVoiceClonerCreateAudioRequestStyleLanguage.HaitianCreole,
                "hebrew" => AiVoiceClonerCreateAudioRequestStyleLanguage.Hebrew,
                "hindi" => AiVoiceClonerCreateAudioRequestStyleLanguage.Hindi,
                "hungarian" => AiVoiceClonerCreateAudioRequestStyleLanguage.Hungarian,
                "icelandic" => AiVoiceClonerCreateAudioRequestStyleLanguage.Icelandic,
                "indonesian" => AiVoiceClonerCreateAudioRequestStyleLanguage.Indonesian,
                "italian" => AiVoiceClonerCreateAudioRequestStyleLanguage.Italian,
                "japanese" => AiVoiceClonerCreateAudioRequestStyleLanguage.Japanese,
                "javanese" => AiVoiceClonerCreateAudioRequestStyleLanguage.Javanese,
                "kannada" => AiVoiceClonerCreateAudioRequestStyleLanguage.Kannada,
                "kazakh" => AiVoiceClonerCreateAudioRequestStyleLanguage.Kazakh,
                "konkani" => AiVoiceClonerCreateAudioRequestStyleLanguage.Konkani,
                "korean" => AiVoiceClonerCreateAudioRequestStyleLanguage.Korean,
                "lao" => AiVoiceClonerCreateAudioRequestStyleLanguage.Lao,
                "latvian" => AiVoiceClonerCreateAudioRequestStyleLanguage.Latvian,
                "lithuanian" => AiVoiceClonerCreateAudioRequestStyleLanguage.Lithuanian,
                "luxembourgish" => AiVoiceClonerCreateAudioRequestStyleLanguage.Luxembourgish,
                "macedonian" => AiVoiceClonerCreateAudioRequestStyleLanguage.Macedonian,
                "maithili" => AiVoiceClonerCreateAudioRequestStyleLanguage.Maithili,
                "malagasy" => AiVoiceClonerCreateAudioRequestStyleLanguage.Malagasy,
                "malay" => AiVoiceClonerCreateAudioRequestStyleLanguage.Malay,
                "malayalam" => AiVoiceClonerCreateAudioRequestStyleLanguage.Malayalam,
                "marathi" => AiVoiceClonerCreateAudioRequestStyleLanguage.Marathi,
                "mongolian" => AiVoiceClonerCreateAudioRequestStyleLanguage.Mongolian,
                "nepali" => AiVoiceClonerCreateAudioRequestStyleLanguage.Nepali,
                "norwegian" => AiVoiceClonerCreateAudioRequestStyleLanguage.Norwegian,
                "odia" => AiVoiceClonerCreateAudioRequestStyleLanguage.Odia,
                "pashto" => AiVoiceClonerCreateAudioRequestStyleLanguage.Pashto,
                "persian" => AiVoiceClonerCreateAudioRequestStyleLanguage.Persian,
                "polish" => AiVoiceClonerCreateAudioRequestStyleLanguage.Polish,
                "portuguese" => AiVoiceClonerCreateAudioRequestStyleLanguage.Portuguese,
                "punjabi" => AiVoiceClonerCreateAudioRequestStyleLanguage.Punjabi,
                "romanian" => AiVoiceClonerCreateAudioRequestStyleLanguage.Romanian,
                "russian" => AiVoiceClonerCreateAudioRequestStyleLanguage.Russian,
                "serbian" => AiVoiceClonerCreateAudioRequestStyleLanguage.Serbian,
                "sindhi" => AiVoiceClonerCreateAudioRequestStyleLanguage.Sindhi,
                "sinhala" => AiVoiceClonerCreateAudioRequestStyleLanguage.Sinhala,
                "slovak" => AiVoiceClonerCreateAudioRequestStyleLanguage.Slovak,
                "slovenian" => AiVoiceClonerCreateAudioRequestStyleLanguage.Slovenian,
                "spanish" => AiVoiceClonerCreateAudioRequestStyleLanguage.Spanish,
                "swahili" => AiVoiceClonerCreateAudioRequestStyleLanguage.Swahili,
                "swedish" => AiVoiceClonerCreateAudioRequestStyleLanguage.Swedish,
                "tagalog" => AiVoiceClonerCreateAudioRequestStyleLanguage.Tagalog,
                "tamil" => AiVoiceClonerCreateAudioRequestStyleLanguage.Tamil,
                "telugu" => AiVoiceClonerCreateAudioRequestStyleLanguage.Telugu,
                "thai" => AiVoiceClonerCreateAudioRequestStyleLanguage.Thai,
                "turkish" => AiVoiceClonerCreateAudioRequestStyleLanguage.Turkish,
                "ukrainian" => AiVoiceClonerCreateAudioRequestStyleLanguage.Ukrainian,
                "urdu" => AiVoiceClonerCreateAudioRequestStyleLanguage.Urdu,
                "uzbek" => AiVoiceClonerCreateAudioRequestStyleLanguage.Uzbek,
                "vietnamese" => AiVoiceClonerCreateAudioRequestStyleLanguage.Vietnamese,
                "welsh" => AiVoiceClonerCreateAudioRequestStyleLanguage.Welsh,
                _ => null,
            };
        }
    }
}