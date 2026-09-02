
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Determines the aspect ratio of the output video.<br/>
    /// * **`gemini-omni-1.1`**: Supports 16:9, 9:16.<br/>
    /// * **`kling-2.6`**: Supports 9:16, 16:9, 1:1.<br/>
    /// * **`kling-3.0`**: Supports 9:16, 16:9, 1:1.<br/>
    /// * **`ltx-2.3`**: Supports 9:16, 16:9, 1:1.<br/>
    /// * **`ltx-2.5`**: Supports 9:16, 16:9, 1:1.<br/>
    /// * **`minimax-h3`**: Supports 16:9, 9:16, 1:1.<br/>
    /// * **`seedance-1.5`**: Supports 9:16, 16:9, 1:1.<br/>
    /// * **`seedance-2.0`**: Supports 9:16, 16:9, 1:1.<br/>
    /// * **`seedance-2.0-mini`**: Supports 9:16, 16:9, 1:1.<br/>
    /// * **`seedance-2.5`**: Supports 9:16, 16:9, 1:1.<br/>
    /// * **`sora-2`**: Supports 9:16, 16:9.<br/>
    /// * **`veo3.1`**: Supports 9:16, 16:9.<br/>
    /// * **`veo3.1-lite`**: Supports 9:16, 16:9.<br/>
    /// * **`wan-2.2`**: Supports 9:16, 16:9, 1:1.<br/>
    /// Example: 16:9
    /// </summary>
    public enum TextToVideoCreateVideoRequestAspectRatio
    {
        /// <summary>
        /// Supports 16:9, 9:16.
        /// </summary>
        x16_9,
        /// <summary>
        /// Supports 9:16, 16:9, 1:1.
        /// </summary>
        x1_1,
        /// <summary>
        /// Supports 16:9, 9:16.
        /// </summary>
        x9_16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextToVideoCreateVideoRequestAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextToVideoCreateVideoRequestAspectRatio value)
        {
            return value switch
            {
                TextToVideoCreateVideoRequestAspectRatio.x16_9 => "16:9",
                TextToVideoCreateVideoRequestAspectRatio.x1_1 => "1:1",
                TextToVideoCreateVideoRequestAspectRatio.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextToVideoCreateVideoRequestAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => TextToVideoCreateVideoRequestAspectRatio.x16_9,
                "1:1" => TextToVideoCreateVideoRequestAspectRatio.x1_1,
                "9:16" => TextToVideoCreateVideoRequestAspectRatio.x9_16,
                _ => null,
            };
        }
    }
}