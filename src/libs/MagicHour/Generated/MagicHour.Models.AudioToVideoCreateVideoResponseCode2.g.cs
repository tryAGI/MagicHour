
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Machine-readable error code.<br/>
    /// - `unauthorized`: Provide a valid API key before retrying.
    /// </summary>
    public enum AudioToVideoCreateVideoResponseCode2
    {
        /// <summary>
        /// Provide a valid API key before retrying.
        /// </summary>
        Unauthorized,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioToVideoCreateVideoResponseCode2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioToVideoCreateVideoResponseCode2 value)
        {
            return value switch
            {
                AudioToVideoCreateVideoResponseCode2.Unauthorized => "unauthorized",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioToVideoCreateVideoResponseCode2? ToEnum(string value)
        {
            return value switch
            {
                "unauthorized" => AudioToVideoCreateVideoResponseCode2.Unauthorized,
                _ => null,
            };
        }
    }
}