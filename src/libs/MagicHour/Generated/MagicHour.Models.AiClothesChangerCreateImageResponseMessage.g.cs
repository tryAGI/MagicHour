
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum AiClothesChangerCreateImageResponseMessage
    {
        /// <summary>
        ///
        /// </summary>
        Unauthorized,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AiClothesChangerCreateImageResponseMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiClothesChangerCreateImageResponseMessage value)
        {
            return value switch
            {
                AiClothesChangerCreateImageResponseMessage.Unauthorized => "Unauthorized",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiClothesChangerCreateImageResponseMessage? ToEnum(string value)
        {
            return value switch
            {
                "Unauthorized" => AiClothesChangerCreateImageResponseMessage.Unauthorized,
                _ => null,
            };
        }
    }
}