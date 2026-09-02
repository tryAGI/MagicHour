
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Machine-readable error code.<br/>
    /// - `internal_server_error`: Retry later or contact support if the error continues.
    /// </summary>
    public enum ImageProjectsDeleteResponseCode5
    {
        /// <summary>
        /// Retry later or contact support if the error continues.
        /// </summary>
        InternalServerError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageProjectsDeleteResponseCode5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageProjectsDeleteResponseCode5 value)
        {
            return value switch
            {
                ImageProjectsDeleteResponseCode5.InternalServerError => "internal_server_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageProjectsDeleteResponseCode5? ToEnum(string value)
        {
            return value switch
            {
                "internal_server_error" => ImageProjectsDeleteResponseCode5.InternalServerError,
                _ => null,
            };
        }
    }
}