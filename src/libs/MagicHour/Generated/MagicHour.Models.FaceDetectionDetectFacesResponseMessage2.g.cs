
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum FaceDetectionDetectFacesResponseMessage2
    {
        /// <summary>
        ///
        /// </summary>
        NotFound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FaceDetectionDetectFacesResponseMessage2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FaceDetectionDetectFacesResponseMessage2 value)
        {
            return value switch
            {
                FaceDetectionDetectFacesResponseMessage2.NotFound => "Not Found",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FaceDetectionDetectFacesResponseMessage2? ToEnum(string value)
        {
            return value switch
            {
                "Not Found" => FaceDetectionDetectFacesResponseMessage2.NotFound,
                _ => null,
            };
        }
    }
}