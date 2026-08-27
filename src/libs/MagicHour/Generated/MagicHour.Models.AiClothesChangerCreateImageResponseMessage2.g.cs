
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum AiClothesChangerCreateImageResponseMessage2
    {
        /// <summary>
        ///
        /// </summary>
        NotFound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AiClothesChangerCreateImageResponseMessage2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiClothesChangerCreateImageResponseMessage2 value)
        {
            return value switch
            {
                AiClothesChangerCreateImageResponseMessage2.NotFound => "Not Found",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiClothesChangerCreateImageResponseMessage2? ToEnum(string value)
        {
            return value switch
            {
                "Not Found" => AiClothesChangerCreateImageResponseMessage2.NotFound,
                _ => null,
            };
        }
    }
}