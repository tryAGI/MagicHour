
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum HeadSwapCreateImageResponseMessage
    {
        /// <summary>
        ///
        /// </summary>
        Unauthorized,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HeadSwapCreateImageResponseMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HeadSwapCreateImageResponseMessage value)
        {
            return value switch
            {
                HeadSwapCreateImageResponseMessage.Unauthorized => "Unauthorized",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HeadSwapCreateImageResponseMessage? ToEnum(string value)
        {
            return value switch
            {
                "Unauthorized" => HeadSwapCreateImageResponseMessage.Unauthorized,
                _ => null,
            };
        }
    }
}