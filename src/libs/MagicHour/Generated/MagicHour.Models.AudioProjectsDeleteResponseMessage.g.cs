
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum AudioProjectsDeleteResponseMessage
    {
        /// <summary>
        ///
        /// </summary>
        Unauthorized,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioProjectsDeleteResponseMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioProjectsDeleteResponseMessage value)
        {
            return value switch
            {
                AudioProjectsDeleteResponseMessage.Unauthorized => "Unauthorized",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioProjectsDeleteResponseMessage? ToEnum(string value)
        {
            return value switch
            {
                "Unauthorized" => AudioProjectsDeleteResponseMessage.Unauthorized,
                _ => null,
            };
        }
    }
}