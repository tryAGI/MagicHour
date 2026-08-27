
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// The output file format for the generated animation.<br/>
    /// Default Value: gif<br/>
    /// Example: gif
    /// </summary>
    public enum AiGifGeneratorCreateImageRequestOutputFormat
    {
        /// <summary>
        ///
        /// </summary>
        Gif,
        /// <summary>
        ///
        /// </summary>
        Mp4,
        /// <summary>
        ///
        /// </summary>
        Webm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AiGifGeneratorCreateImageRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiGifGeneratorCreateImageRequestOutputFormat value)
        {
            return value switch
            {
                AiGifGeneratorCreateImageRequestOutputFormat.Gif => "gif",
                AiGifGeneratorCreateImageRequestOutputFormat.Mp4 => "mp4",
                AiGifGeneratorCreateImageRequestOutputFormat.Webm => "webm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiGifGeneratorCreateImageRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "gif" => AiGifGeneratorCreateImageRequestOutputFormat.Gif,
                "mp4" => AiGifGeneratorCreateImageRequestOutputFormat.Mp4,
                "webm" => AiGifGeneratorCreateImageRequestOutputFormat.Webm,
                _ => null,
            };
        }
    }
}