
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Controls the output video resolution. Defaults to `720p` on paid tiers and `480p` on free tiers.<br/>
    /// * **`kling-2.6`**: Supports 720p, 1080p.<br/>
    /// * **`kling-3.0`**: Supports 720p, 1080p, 4k.<br/>
    /// * **`ltx-2.3`**: Supports 480p, 720p, 1080p.<br/>
    /// * **`minimax-h3`**: Supports 480p, 720p, 1080p.<br/>
    /// * **`seedance-1.5`**: Supports 480p, 720p, 1080p.<br/>
    /// * **`seedance-2.0`**: Supports 480p, 720p.<br/>
    /// * **`seedance-2.0-mini`**: Supports 480p, 720p.<br/>
    /// * **`seedance-2.5`**: Supports 480p, 720p.<br/>
    /// * **`sora-2`**: Supports 720p.<br/>
    /// * **`veo3.1`**: Supports 720p, 1080p.<br/>
    /// * **`veo3.1-lite`**: Supports 720p, 1080p.<br/>
    /// * **`wan-2.2`**: Supports 480p, 720p, 1080p.<br/>
    /// Example: 720p
    /// </summary>
    public enum TextToVideoCreateVideoRequestResolution
    {
        /// <summary>
        /// Supports 720p, 1080p.
        /// </summary>
        x1080p,
        /// <summary>
        /// Supports 480p, 720p, 1080p.
        /// </summary>
        x480p,
        /// <summary>
        /// Supports 720p, 1080p, 4k.
        /// </summary>
        x4k,
        /// <summary>
        /// Supports 720p, 1080p.
        /// </summary>
        x720p,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextToVideoCreateVideoRequestResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextToVideoCreateVideoRequestResolution value)
        {
            return value switch
            {
                TextToVideoCreateVideoRequestResolution.x1080p => "1080p",
                TextToVideoCreateVideoRequestResolution.x480p => "480p",
                TextToVideoCreateVideoRequestResolution.x4k => "4k",
                TextToVideoCreateVideoRequestResolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextToVideoCreateVideoRequestResolution? ToEnum(string value)
        {
            return value switch
            {
                "1080p" => TextToVideoCreateVideoRequestResolution.x1080p,
                "480p" => TextToVideoCreateVideoRequestResolution.x480p,
                "4k" => TextToVideoCreateVideoRequestResolution.x4k,
                "720p" => TextToVideoCreateVideoRequestResolution.x720p,
                _ => null,
            };
        }
    }
}