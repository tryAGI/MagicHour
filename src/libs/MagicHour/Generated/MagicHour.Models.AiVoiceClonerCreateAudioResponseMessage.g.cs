
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum AiVoiceClonerCreateAudioResponseMessage
    {
        /// <summary>
        ///
        /// </summary>
        Unauthorized,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AiVoiceClonerCreateAudioResponseMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiVoiceClonerCreateAudioResponseMessage value)
        {
            return value switch
            {
                AiVoiceClonerCreateAudioResponseMessage.Unauthorized => "Unauthorized",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiVoiceClonerCreateAudioResponseMessage? ToEnum(string value)
        {
            return value switch
            {
                "Unauthorized" => AiVoiceClonerCreateAudioResponseMessage.Unauthorized,
                _ => null,
            };
        }
    }
}