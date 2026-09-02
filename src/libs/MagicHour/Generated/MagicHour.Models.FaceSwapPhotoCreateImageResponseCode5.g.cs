
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Machine-readable error code.<br/>
    /// - `unprocessable_entity`: Change the request values before retrying.
    /// </summary>
    public enum FaceSwapPhotoCreateImageResponseCode5
    {
        /// <summary>
        /// Change the request values before retrying.
        /// </summary>
        UnprocessableEntity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FaceSwapPhotoCreateImageResponseCode5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FaceSwapPhotoCreateImageResponseCode5 value)
        {
            return value switch
            {
                FaceSwapPhotoCreateImageResponseCode5.UnprocessableEntity => "unprocessable_entity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FaceSwapPhotoCreateImageResponseCode5? ToEnum(string value)
        {
            return value switch
            {
                "unprocessable_entity" => FaceSwapPhotoCreateImageResponseCode5.UnprocessableEntity,
                _ => null,
            };
        }
    }
}