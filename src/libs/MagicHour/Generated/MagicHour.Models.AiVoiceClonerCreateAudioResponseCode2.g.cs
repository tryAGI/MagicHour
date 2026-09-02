
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Machine-readable error code.<br/>
    /// - `unauthorized`: Provide a valid API key before retrying.
    /// </summary>
    public enum AiVoiceClonerCreateAudioResponseCode2
    {
        /// <summary>
        /// Provide a valid API key before retrying.
        /// </summary>
        Unauthorized,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AiVoiceClonerCreateAudioResponseCode2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiVoiceClonerCreateAudioResponseCode2 value)
        {
            return value switch
            {
                AiVoiceClonerCreateAudioResponseCode2.Unauthorized => "unauthorized",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiVoiceClonerCreateAudioResponseCode2? ToEnum(string value)
        {
            return value switch
            {
                "unauthorized" => AiVoiceClonerCreateAudioResponseCode2.Unauthorized,
                _ => null,
            };
        }
    }
}