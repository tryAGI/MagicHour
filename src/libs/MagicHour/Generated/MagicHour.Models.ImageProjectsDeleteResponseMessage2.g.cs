
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum ImageProjectsDeleteResponseMessage2
    {
        /// <summary>
        ///
        /// </summary>
        NotFound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageProjectsDeleteResponseMessage2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageProjectsDeleteResponseMessage2 value)
        {
            return value switch
            {
                ImageProjectsDeleteResponseMessage2.NotFound => "Not Found",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageProjectsDeleteResponseMessage2? ToEnum(string value)
        {
            return value switch
            {
                "Not Found" => ImageProjectsDeleteResponseMessage2.NotFound,
                _ => null,
            };
        }
    }
}