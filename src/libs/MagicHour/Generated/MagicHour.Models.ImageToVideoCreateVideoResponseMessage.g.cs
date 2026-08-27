
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum ImageToVideoCreateVideoResponseMessage
    {
        /// <summary>
        ///
        /// </summary>
        Unauthorized,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageToVideoCreateVideoResponseMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageToVideoCreateVideoResponseMessage value)
        {
            return value switch
            {
                ImageToVideoCreateVideoResponseMessage.Unauthorized => "Unauthorized",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageToVideoCreateVideoResponseMessage? ToEnum(string value)
        {
            return value switch
            {
                "Unauthorized" => ImageToVideoCreateVideoResponseMessage.Unauthorized,
                _ => null,
            };
        }
    }
}