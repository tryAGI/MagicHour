
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Example: ai-voice-generator
    /// </summary>
    public enum EstimateAudioTool
    {
        /// <summary>
        ///
        /// </summary>
        AiMusicGenerator,
        /// <summary>
        ///
        /// </summary>
        AiVoiceCloner,
        /// <summary>
        ///
        /// </summary>
        AiVoiceGenerator,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EstimateAudioToolExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EstimateAudioTool value)
        {
            return value switch
            {
                EstimateAudioTool.AiMusicGenerator => "ai-music-generator",
                EstimateAudioTool.AiVoiceCloner => "ai-voice-cloner",
                EstimateAudioTool.AiVoiceGenerator => "ai-voice-generator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EstimateAudioTool? ToEnum(string value)
        {
            return value switch
            {
                "ai-music-generator" => EstimateAudioTool.AiMusicGenerator,
                "ai-voice-cloner" => EstimateAudioTool.AiVoiceCloner,
                "ai-voice-generator" => EstimateAudioTool.AiVoiceGenerator,
                _ => null,
            };
        }
    }
}