
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Controls the output video resolution. Defaults to `720p` on paid tiers and `480p` on free tiers.<br/>
    /// * **`gemini-omni-1.1`**: Supports 360p, 720p, 1080p, 4k.<br/>
    /// * **`kling-2.6`**: Supports 720p, 1080p.<br/>
    /// * **`kling-3.0`**: Supports 720p, 1080p, 4k.<br/>
    /// * **`ltx-2.3`**: Supports 480p, 720p, 1080p.<br/>
    /// * **`ltx-2.5`**: Supports 480p, 720p, 1080p.<br/>
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
    public enum ImageToVideoCreateVideoRequestResolution
    {
        /// <summary>
        /// Supports 360p, 720p, 1080p, 4k.
        /// </summary>
        x1080p,
        /// <summary>
        /// Supports 360p, 720p, 1080p, 4k.
        /// </summary>
        x360p,
        /// <summary>
        /// Supports 480p, 720p, 1080p.
        /// </summary>
        x480p,
        /// <summary>
        /// Supports 360p, 720p, 1080p, 4k.
        /// </summary>
        x4k,
        /// <summary>
        /// Supports 360p, 720p, 1080p, 4k.
        /// </summary>
        x720p,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageToVideoCreateVideoRequestResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageToVideoCreateVideoRequestResolution value)
        {
            return value switch
            {
                ImageToVideoCreateVideoRequestResolution.x1080p => "1080p",
                ImageToVideoCreateVideoRequestResolution.x360p => "360p",
                ImageToVideoCreateVideoRequestResolution.x480p => "480p",
                ImageToVideoCreateVideoRequestResolution.x4k => "4k",
                ImageToVideoCreateVideoRequestResolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageToVideoCreateVideoRequestResolution? ToEnum(string value)
        {
            return value switch
            {
                "1080p" => ImageToVideoCreateVideoRequestResolution.x1080p,
                "360p" => ImageToVideoCreateVideoRequestResolution.x360p,
                "480p" => ImageToVideoCreateVideoRequestResolution.x480p,
                "4k" => ImageToVideoCreateVideoRequestResolution.x4k,
                "720p" => ImageToVideoCreateVideoRequestResolution.x720p,
                _ => null,
            };
        }
    }
}