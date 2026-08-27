
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum AiQrCodeGeneratorCreateImageResponseMessage2
    {
        /// <summary>
        ///
        /// </summary>
        NotFound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AiQrCodeGeneratorCreateImageResponseMessage2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiQrCodeGeneratorCreateImageResponseMessage2 value)
        {
            return value switch
            {
                AiQrCodeGeneratorCreateImageResponseMessage2.NotFound => "Not Found",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiQrCodeGeneratorCreateImageResponseMessage2? ToEnum(string value)
        {
            return value switch
            {
                "Not Found" => AiQrCodeGeneratorCreateImageResponseMessage2.NotFound,
                _ => null,
            };
        }
    }
}