
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// 
    /// </summary>
    public enum AiGifGeneratorCreateImageResponseMessage2
    {
        /// <summary>
        /// 
        /// </summary>
        NotFound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AiGifGeneratorCreateImageResponseMessage2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiGifGeneratorCreateImageResponseMessage2 value)
        {
            return value switch
            {
                AiGifGeneratorCreateImageResponseMessage2.NotFound => "Not Found",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiGifGeneratorCreateImageResponseMessage2? ToEnum(string value)
        {
            return value switch
            {
                "Not Found" => AiGifGeneratorCreateImageResponseMessage2.NotFound,
                _ => null,
            };
        }
    }
}