
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum BodySwapCreateImageResponseMessage
    {
        /// <summary>
        ///
        /// </summary>
        Unauthorized,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodySwapCreateImageResponseMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodySwapCreateImageResponseMessage value)
        {
            return value switch
            {
                BodySwapCreateImageResponseMessage.Unauthorized => "Unauthorized",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodySwapCreateImageResponseMessage? ToEnum(string value)
        {
            return value switch
            {
                "Unauthorized" => BodySwapCreateImageResponseMessage.Unauthorized,
                _ => null,
            };
        }
    }
}