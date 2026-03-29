
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// * `custom` - Use your own prompt for the video.<br/>
    /// * `use_lyrics` - Use the lyrics of the audio to create the prompt. If this option is selected, then `assets.audio_source` must be `file` or `youtube`.<br/>
    /// * `ai_choose` - Let AI write the prompt. If this option is selected, then `assets.audio_source` must be `file` or `youtube`.<br/>
    /// Example: custom
    /// </summary>
    public enum AnimationCreateVideoRequestStylePromptType
    {
        /// <summary>
        /// 
        /// </summary>
        AiChoose,
        /// <summary>
        /// 
        /// </summary>
        Custom,
        /// <summary>
        /// 
        /// </summary>
        UseLyrics,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnimationCreateVideoRequestStylePromptTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnimationCreateVideoRequestStylePromptType value)
        {
            return value switch
            {
                AnimationCreateVideoRequestStylePromptType.AiChoose => "ai_choose",
                AnimationCreateVideoRequestStylePromptType.Custom => "custom",
                AnimationCreateVideoRequestStylePromptType.UseLyrics => "use_lyrics",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnimationCreateVideoRequestStylePromptType? ToEnum(string value)
        {
            return value switch
            {
                "ai_choose" => AnimationCreateVideoRequestStylePromptType.AiChoose,
                "custom" => AnimationCreateVideoRequestStylePromptType.Custom,
                "use_lyrics" => AnimationCreateVideoRequestStylePromptType.UseLyrics,
                _ => null,
            };
        }
    }
}