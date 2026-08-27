
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum LipSyncCreateVideoResponseMessage2
    {
        /// <summary>
        ///
        /// </summary>
        NotFound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LipSyncCreateVideoResponseMessage2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LipSyncCreateVideoResponseMessage2 value)
        {
            return value switch
            {
                LipSyncCreateVideoResponseMessage2.NotFound => "Not Found",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LipSyncCreateVideoResponseMessage2? ToEnum(string value)
        {
            return value switch
            {
                "Not Found" => LipSyncCreateVideoResponseMessage2.NotFound,
                _ => null,
            };
        }
    }
}