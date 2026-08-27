
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum VideoProjectsDeleteResponseMessage2
    {
        /// <summary>
        ///
        /// </summary>
        NotFound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoProjectsDeleteResponseMessage2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoProjectsDeleteResponseMessage2 value)
        {
            return value switch
            {
                VideoProjectsDeleteResponseMessage2.NotFound => "Not Found",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoProjectsDeleteResponseMessage2? ToEnum(string value)
        {
            return value switch
            {
                "Not Found" => VideoProjectsDeleteResponseMessage2.NotFound,
                _ => null,
            };
        }
    }
}