
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// 
    /// </summary>
    public enum BodySwapCreateImageResponseMessage2
    {
        /// <summary>
        /// 
        /// </summary>
        NotFound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodySwapCreateImageResponseMessage2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodySwapCreateImageResponseMessage2 value)
        {
            return value switch
            {
                BodySwapCreateImageResponseMessage2.NotFound => "Not Found",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodySwapCreateImageResponseMessage2? ToEnum(string value)
        {
            return value switch
            {
                "Not Found" => BodySwapCreateImageResponseMessage2.NotFound,
                _ => null,
            };
        }
    }
}