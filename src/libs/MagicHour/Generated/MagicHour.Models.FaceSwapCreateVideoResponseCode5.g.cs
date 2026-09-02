
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Machine-readable error code.<br/>
    /// - `unprocessable_entity`: Change the request values before retrying.
    /// </summary>
    public enum FaceSwapCreateVideoResponseCode5
    {
        /// <summary>
        /// Change the request values before retrying.
        /// </summary>
        UnprocessableEntity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FaceSwapCreateVideoResponseCode5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FaceSwapCreateVideoResponseCode5 value)
        {
            return value switch
            {
                FaceSwapCreateVideoResponseCode5.UnprocessableEntity => "unprocessable_entity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FaceSwapCreateVideoResponseCode5? ToEnum(string value)
        {
            return value switch
            {
                "unprocessable_entity" => FaceSwapCreateVideoResponseCode5.UnprocessableEntity,
                _ => null,
            };
        }
    }
}