
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Output video resolution. Defaults to 480p. 720p and 1080p require a paid plan.<br/>
    /// Example: 720p
    /// </summary>
    public enum AiVideoTranslatorCreateVideoRequestResolution
    {
        /// <summary>
        ///
        /// </summary>
        x1080p,
        /// <summary>
        ///
        /// </summary>
        x480p,
        /// <summary>
        ///
        /// </summary>
        x720p,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AiVideoTranslatorCreateVideoRequestResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiVideoTranslatorCreateVideoRequestResolution value)
        {
            return value switch
            {
                AiVideoTranslatorCreateVideoRequestResolution.x1080p => "1080p",
                AiVideoTranslatorCreateVideoRequestResolution.x480p => "480p",
                AiVideoTranslatorCreateVideoRequestResolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiVideoTranslatorCreateVideoRequestResolution? ToEnum(string value)
        {
            return value switch
            {
                "1080p" => AiVideoTranslatorCreateVideoRequestResolution.x1080p,
                "480p" => AiVideoTranslatorCreateVideoRequestResolution.x480p,
                "720p" => AiVideoTranslatorCreateVideoRequestResolution.x720p,
                _ => null,
            };
        }
    }
}