
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// The aspect ratio of the output image(s). If not specified, defaults to `1:1` (square).<br/>
    /// Example: 1:1
    /// </summary>
    public enum AiImageGeneratorCreateImageRequestAspectRatio
    {
        /// <summary>
        ///
        /// </summary>
        x16_9,
        /// <summary>
        /// 1` (square).
        /// </summary>
        x1_1,
        /// <summary>
        ///
        /// </summary>
        x9_16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AiImageGeneratorCreateImageRequestAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiImageGeneratorCreateImageRequestAspectRatio value)
        {
            return value switch
            {
                AiImageGeneratorCreateImageRequestAspectRatio.x16_9 => "16:9",
                AiImageGeneratorCreateImageRequestAspectRatio.x1_1 => "1:1",
                AiImageGeneratorCreateImageRequestAspectRatio.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiImageGeneratorCreateImageRequestAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => AiImageGeneratorCreateImageRequestAspectRatio.x16_9,
                "1:1" => AiImageGeneratorCreateImageRequestAspectRatio.x1_1,
                "9:16" => AiImageGeneratorCreateImageRequestAspectRatio.x9_16,
                _ => null,
            };
        }
    }
}