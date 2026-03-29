
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoAssetsGeneratePresignedUrlResponseMessage2
    {
        /// <summary>
        /// 
        /// </summary>
        NotFound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoAssetsGeneratePresignedUrlResponseMessage2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoAssetsGeneratePresignedUrlResponseMessage2 value)
        {
            return value switch
            {
                VideoAssetsGeneratePresignedUrlResponseMessage2.NotFound => "Not Found",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoAssetsGeneratePresignedUrlResponseMessage2? ToEnum(string value)
        {
            return value switch
            {
                "Not Found" => VideoAssetsGeneratePresignedUrlResponseMessage2.NotFound,
                _ => null,
            };
        }
    }
}