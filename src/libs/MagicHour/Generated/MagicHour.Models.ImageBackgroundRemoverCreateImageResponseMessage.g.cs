
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImageBackgroundRemoverCreateImageResponseMessage
    {
        /// <summary>
        /// 
        /// </summary>
        Unauthorized,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageBackgroundRemoverCreateImageResponseMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageBackgroundRemoverCreateImageResponseMessage value)
        {
            return value switch
            {
                ImageBackgroundRemoverCreateImageResponseMessage.Unauthorized => "Unauthorized",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageBackgroundRemoverCreateImageResponseMessage? ToEnum(string value)
        {
            return value switch
            {
                "Unauthorized" => ImageBackgroundRemoverCreateImageResponseMessage.Unauthorized,
                _ => null,
            };
        }
    }
}