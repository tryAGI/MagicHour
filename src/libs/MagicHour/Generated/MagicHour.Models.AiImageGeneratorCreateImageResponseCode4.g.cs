
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Machine-readable error code.<br/>
    /// - `not_found`: Check the route or resource identifier.
    /// </summary>
    public enum AiImageGeneratorCreateImageResponseCode4
    {
        /// <summary>
        /// Check the route or resource identifier.
        /// </summary>
        NotFound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AiImageGeneratorCreateImageResponseCode4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiImageGeneratorCreateImageResponseCode4 value)
        {
            return value switch
            {
                AiImageGeneratorCreateImageResponseCode4.NotFound => "not_found",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiImageGeneratorCreateImageResponseCode4? ToEnum(string value)
        {
            return value switch
            {
                "not_found" => AiImageGeneratorCreateImageResponseCode4.NotFound,
                _ => null,
            };
        }
    }
}