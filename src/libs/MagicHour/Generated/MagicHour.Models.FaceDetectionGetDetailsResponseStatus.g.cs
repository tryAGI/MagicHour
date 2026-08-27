
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// The status of the detection.<br/>
    /// Example: complete
    /// </summary>
    public enum FaceDetectionGetDetailsResponseStatus
    {
        /// <summary>
        ///
        /// </summary>
        Complete,
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        Queued,
        /// <summary>
        ///
        /// </summary>
        Rendering,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FaceDetectionGetDetailsResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FaceDetectionGetDetailsResponseStatus value)
        {
            return value switch
            {
                FaceDetectionGetDetailsResponseStatus.Complete => "complete",
                FaceDetectionGetDetailsResponseStatus.Error => "error",
                FaceDetectionGetDetailsResponseStatus.Queued => "queued",
                FaceDetectionGetDetailsResponseStatus.Rendering => "rendering",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FaceDetectionGetDetailsResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "complete" => FaceDetectionGetDetailsResponseStatus.Complete,
                "error" => FaceDetectionGetDetailsResponseStatus.Error,
                "queued" => FaceDetectionGetDetailsResponseStatus.Queued,
                "rendering" => FaceDetectionGetDetailsResponseStatus.Rendering,
                _ => null,
            };
        }
    }
}