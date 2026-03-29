
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImageToVideoCreateVideoResponseMessage2
    {
        /// <summary>
        /// 
        /// </summary>
        NotFound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageToVideoCreateVideoResponseMessage2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageToVideoCreateVideoResponseMessage2 value)
        {
            return value switch
            {
                ImageToVideoCreateVideoResponseMessage2.NotFound => "Not Found",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageToVideoCreateVideoResponseMessage2? ToEnum(string value)
        {
            return value switch
            {
                "Not Found" => ImageToVideoCreateVideoResponseMessage2.NotFound,
                _ => null,
            };
        }
    }
}