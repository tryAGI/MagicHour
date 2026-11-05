
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Spoken language. Use a canonical lowercase language name, or auto to detect the language from the text. Defaults to auto.<br/>
    /// Default Value: auto<br/>
    /// Example: spanish
    /// </summary>
    public enum AiVoiceGeneratorCreateAudioRequestStyleLanguage
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
    public static class AiVoiceGeneratorCreateAudioRequestStyleLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiVoiceGeneratorCreateAudioRequestStyleLanguage value)
        {
            return value switch
            {
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Afrikaans => "afrikaans",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Albanian => "albanian",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Amharic => "amharic",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Arabic => "arabic",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Armenian => "armenian",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Assamese => "assamese",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Auto => "auto",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Azerbaijani => "azerbaijani",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Basque => "basque",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Belarusian => "belarusian",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Bengali => "bengali",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Bulgarian => "bulgarian",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Burmese => "burmese",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Cantonese => "cantonese",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Catalan => "catalan",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Cebuano => "cebuano",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Chinese => "chinese",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Croatian => "croatian",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Czech => "czech",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Danish => "danish",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Dutch => "dutch",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.English => "english",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Estonian => "estonian",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Finnish => "finnish",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.French => "french",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Galician => "galician",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Georgian => "georgian",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.German => "german",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Greek => "greek",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Gujarati => "gujarati",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.HaitianCreole => "haitian creole",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Hebrew => "hebrew",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Hindi => "hindi",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Hungarian => "hungarian",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Icelandic => "icelandic",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Indonesian => "indonesian",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Italian => "italian",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Japanese => "japanese",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Javanese => "javanese",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Kannada => "kannada",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Kazakh => "kazakh",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Konkani => "konkani",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Korean => "korean",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Lao => "lao",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Latvian => "latvian",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Lithuanian => "lithuanian",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Luxembourgish => "luxembourgish",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Macedonian => "macedonian",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Maithili => "maithili",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Malagasy => "malagasy",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Malay => "malay",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Malayalam => "malayalam",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Marathi => "marathi",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Mongolian => "mongolian",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Nepali => "nepali",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Norwegian => "norwegian",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Odia => "odia",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Pashto => "pashto",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Persian => "persian",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Polish => "polish",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Portuguese => "portuguese",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Punjabi => "punjabi",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Romanian => "romanian",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Russian => "russian",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Serbian => "serbian",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Sindhi => "sindhi",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Sinhala => "sinhala",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Slovak => "slovak",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Slovenian => "slovenian",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Spanish => "spanish",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Swahili => "swahili",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Swedish => "swedish",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Tagalog => "tagalog",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Tamil => "tamil",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Telugu => "telugu",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Thai => "thai",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Turkish => "turkish",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Ukrainian => "ukrainian",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Urdu => "urdu",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Uzbek => "uzbek",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Vietnamese => "vietnamese",
                AiVoiceGeneratorCreateAudioRequestStyleLanguage.Welsh => "welsh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiVoiceGeneratorCreateAudioRequestStyleLanguage? ToEnum(string value)
        {
            return value switch
            {
                "afrikaans" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Afrikaans,
                "albanian" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Albanian,
                "amharic" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Amharic,
                "arabic" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Arabic,
                "armenian" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Armenian,
                "assamese" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Assamese,
                "auto" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Auto,
                "azerbaijani" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Azerbaijani,
                "basque" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Basque,
                "belarusian" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Belarusian,
                "bengali" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Bengali,
                "bulgarian" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Bulgarian,
                "burmese" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Burmese,
                "cantonese" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Cantonese,
                "catalan" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Catalan,
                "cebuano" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Cebuano,
                "chinese" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Chinese,
                "croatian" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Croatian,
                "czech" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Czech,
                "danish" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Danish,
                "dutch" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Dutch,
                "english" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.English,
                "estonian" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Estonian,
                "finnish" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Finnish,
                "french" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.French,
                "galician" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Galician,
                "georgian" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Georgian,
                "german" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.German,
                "greek" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Greek,
                "gujarati" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Gujarati,
                "haitian creole" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.HaitianCreole,
                "hebrew" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Hebrew,
                "hindi" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Hindi,
                "hungarian" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Hungarian,
                "icelandic" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Icelandic,
                "indonesian" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Indonesian,
                "italian" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Italian,
                "japanese" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Japanese,
                "javanese" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Javanese,
                "kannada" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Kannada,
                "kazakh" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Kazakh,
                "konkani" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Konkani,
                "korean" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Korean,
                "lao" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Lao,
                "latvian" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Latvian,
                "lithuanian" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Lithuanian,
                "luxembourgish" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Luxembourgish,
                "macedonian" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Macedonian,
                "maithili" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Maithili,
                "malagasy" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Malagasy,
                "malay" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Malay,
                "malayalam" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Malayalam,
                "marathi" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Marathi,
                "mongolian" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Mongolian,
                "nepali" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Nepali,
                "norwegian" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Norwegian,
                "odia" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Odia,
                "pashto" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Pashto,
                "persian" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Persian,
                "polish" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Polish,
                "portuguese" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Portuguese,
                "punjabi" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Punjabi,
                "romanian" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Romanian,
                "russian" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Russian,
                "serbian" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Serbian,
                "sindhi" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Sindhi,
                "sinhala" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Sinhala,
                "slovak" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Slovak,
                "slovenian" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Slovenian,
                "spanish" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Spanish,
                "swahili" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Swahili,
                "swedish" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Swedish,
                "tagalog" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Tagalog,
                "tamil" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Tamil,
                "telugu" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Telugu,
                "thai" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Thai,
                "turkish" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Turkish,
                "ukrainian" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Ukrainian,
                "urdu" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Urdu,
                "uzbek" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Uzbek,
                "vietnamese" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Vietnamese,
                "welsh" => AiVoiceGeneratorCreateAudioRequestStyleLanguage.Welsh,
                _ => null,
            };
        }
    }
}