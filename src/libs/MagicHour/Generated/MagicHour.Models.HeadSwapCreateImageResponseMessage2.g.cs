
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum HeadSwapCreateImageResponseMessage2
    {
        /// <summary>
        ///
        /// </summary>
        NotFound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HeadSwapCreateImageResponseMessage2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HeadSwapCreateImageResponseMessage2 value)
        {
            return value switch
            {
                HeadSwapCreateImageResponseMessage2.NotFound => "Not Found",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HeadSwapCreateImageResponseMessage2? ToEnum(string value)
        {
            return value switch
            {
                "Not Found" => HeadSwapCreateImageResponseMessage2.NotFound,
                _ => null,
            };
        }
    }
}