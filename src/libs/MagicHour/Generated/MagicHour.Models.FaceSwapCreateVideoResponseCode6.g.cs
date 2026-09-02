
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Machine-readable error code.<br/>
    /// - `internal_server_error`: Retry later or contact support if the error continues.
    /// </summary>
    public enum FaceSwapCreateVideoResponseCode6
    {
        /// <summary>
        /// Retry later or contact support if the error continues.
        /// </summary>
        InternalServerError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FaceSwapCreateVideoResponseCode6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FaceSwapCreateVideoResponseCode6 value)
        {
            return value switch
            {
                FaceSwapCreateVideoResponseCode6.InternalServerError => "internal_server_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FaceSwapCreateVideoResponseCode6? ToEnum(string value)
        {
            return value switch
            {
                "internal_server_error" => FaceSwapCreateVideoResponseCode6.InternalServerError,
                _ => null,
            };
        }
    }
}