
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// 
    /// </summary>
    public enum AutoSubtitleGeneratorCreateVideoResponseMessage
    {
        /// <summary>
        /// 
        /// </summary>
        Unauthorized,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSubtitleGeneratorCreateVideoResponseMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSubtitleGeneratorCreateVideoResponseMessage value)
        {
            return value switch
            {
                AutoSubtitleGeneratorCreateVideoResponseMessage.Unauthorized => "Unauthorized",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSubtitleGeneratorCreateVideoResponseMessage? ToEnum(string value)
        {
            return value switch
            {
                "Unauthorized" => AutoSubtitleGeneratorCreateVideoResponseMessage.Unauthorized,
                _ => null,
            };
        }
    }
}