
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum FaceDetectionGetDetailsResponseMessage
    {
        /// <summary>
        ///
        /// </summary>
        Unauthorized,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FaceDetectionGetDetailsResponseMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FaceDetectionGetDetailsResponseMessage value)
        {
            return value switch
            {
                FaceDetectionGetDetailsResponseMessage.Unauthorized => "Unauthorized",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FaceDetectionGetDetailsResponseMessage? ToEnum(string value)
        {
            return value switch
            {
                "Unauthorized" => FaceDetectionGetDetailsResponseMessage.Unauthorized,
                _ => null,
            };
        }
    }
}