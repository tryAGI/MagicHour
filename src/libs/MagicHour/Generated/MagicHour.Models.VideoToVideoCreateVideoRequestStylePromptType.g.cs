
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// * `default` - Use the default recommended prompt for the art style.<br/>
    /// * `custom` - Only use the prompt passed in the API. Note: for v1, lora prompt will still be auto added to apply the art style properly.<br/>
    /// * `append_default` - Add the default recommended prompt to the end of the prompt passed in the API.<br/>
    /// Default Value: default<br/>
    /// Example: default
    /// </summary>
    public enum VideoToVideoCreateVideoRequestStylePromptType
    {
        /// <summary>
        ///
        /// </summary>
        AppendDefault,
        /// <summary>
        /// for v1, lora prompt will still be auto added to apply the art style properly.
        /// </summary>
        Custom,
        /// <summary>
        ///
        /// </summary>
        Default,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoToVideoCreateVideoRequestStylePromptTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoToVideoCreateVideoRequestStylePromptType value)
        {
            return value switch
            {
                VideoToVideoCreateVideoRequestStylePromptType.AppendDefault => "append_default",
                VideoToVideoCreateVideoRequestStylePromptType.Custom => "custom",
                VideoToVideoCreateVideoRequestStylePromptType.Default => "default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoToVideoCreateVideoRequestStylePromptType? ToEnum(string value)
        {
            return value switch
            {
                "append_default" => VideoToVideoCreateVideoRequestStylePromptType.AppendDefault,
                "custom" => VideoToVideoCreateVideoRequestStylePromptType.Custom,
                "default" => VideoToVideoCreateVideoRequestStylePromptType.Default,
                _ => null,
            };
        }
    }
}