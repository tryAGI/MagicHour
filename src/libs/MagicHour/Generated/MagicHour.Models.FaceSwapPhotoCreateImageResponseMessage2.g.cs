
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum FaceSwapPhotoCreateImageResponseMessage2
    {
        /// <summary>
        ///
        /// </summary>
        NotFound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FaceSwapPhotoCreateImageResponseMessage2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FaceSwapPhotoCreateImageResponseMessage2 value)
        {
            return value switch
            {
                FaceSwapPhotoCreateImageResponseMessage2.NotFound => "Not Found",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FaceSwapPhotoCreateImageResponseMessage2? ToEnum(string value)
        {
            return value switch
            {
                "Not Found" => FaceSwapPhotoCreateImageResponseMessage2.NotFound,
                _ => null,
            };
        }
    }
}