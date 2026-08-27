
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum AiHeadshotGeneratorCreateImageResponseMessage
    {
        /// <summary>
        ///
        /// </summary>
        Unauthorized,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AiHeadshotGeneratorCreateImageResponseMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiHeadshotGeneratorCreateImageResponseMessage value)
        {
            return value switch
            {
                AiHeadshotGeneratorCreateImageResponseMessage.Unauthorized => "Unauthorized",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiHeadshotGeneratorCreateImageResponseMessage? ToEnum(string value)
        {
            return value switch
            {
                "Unauthorized" => AiHeadshotGeneratorCreateImageResponseMessage.Unauthorized,
                _ => null,
            };
        }
    }
}