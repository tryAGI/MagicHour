
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Preset subtitle templates. Please visit https://magichour.ai/create/auto-subtitle-generator to see the style of the existing templates.
    /// </summary>
    public enum AutoSubtitleGeneratorCreateVideoRequestStyleTemplate
    {
        /// <summary>
        ///
        /// </summary>
        Cinematic,
        /// <summary>
        ///
        /// </summary>
        Highlight,
        /// <summary>
        ///
        /// </summary>
        Karaoke,
        /// <summary>
        ///
        /// </summary>
        Minimalist,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSubtitleGeneratorCreateVideoRequestStyleTemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSubtitleGeneratorCreateVideoRequestStyleTemplate value)
        {
            return value switch
            {
                AutoSubtitleGeneratorCreateVideoRequestStyleTemplate.Cinematic => "cinematic",
                AutoSubtitleGeneratorCreateVideoRequestStyleTemplate.Highlight => "highlight",
                AutoSubtitleGeneratorCreateVideoRequestStyleTemplate.Karaoke => "karaoke",
                AutoSubtitleGeneratorCreateVideoRequestStyleTemplate.Minimalist => "minimalist",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSubtitleGeneratorCreateVideoRequestStyleTemplate? ToEnum(string value)
        {
            return value switch
            {
                "cinematic" => AutoSubtitleGeneratorCreateVideoRequestStyleTemplate.Cinematic,
                "highlight" => AutoSubtitleGeneratorCreateVideoRequestStyleTemplate.Highlight,
                "karaoke" => AutoSubtitleGeneratorCreateVideoRequestStyleTemplate.Karaoke,
                "minimalist" => AutoSubtitleGeneratorCreateVideoRequestStyleTemplate.Minimalist,
                _ => null,
            };
        }
    }
}