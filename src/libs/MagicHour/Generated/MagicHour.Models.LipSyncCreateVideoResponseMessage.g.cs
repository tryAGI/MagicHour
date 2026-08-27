
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum LipSyncCreateVideoResponseMessage
    {
        /// <summary>
        ///
        /// </summary>
        Unauthorized,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LipSyncCreateVideoResponseMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LipSyncCreateVideoResponseMessage value)
        {
            return value switch
            {
                LipSyncCreateVideoResponseMessage.Unauthorized => "Unauthorized",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LipSyncCreateVideoResponseMessage? ToEnum(string value)
        {
            return value switch
            {
                "Unauthorized" => LipSyncCreateVideoResponseMessage.Unauthorized,
                _ => null,
            };
        }
    }
}