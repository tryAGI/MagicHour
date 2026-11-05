
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Output resolution. Defaults to `480p` for free tier and `720p` for paid. Supported per model: `gemini-omni-1.1`: 360p, 720p, 1080p, 4k; `wan-3.0`: 480p, 720p, 1080p; `ltx-2.5`: 480p, 720p, 1080p.<br/>
    /// Example: 480p
    /// </summary>
    public enum AiVideoEditorCreateVideoRequestResolution
    {
        /// <summary>
        /// `gemini-omni-1.1`: 360p, 720p, 1080p, 4k; `wan-3.0`: 480p, 720p, 1080p; `ltx-2.5`: 480p, 720p, 1080p.
        /// </summary>
        x1080p,
        /// <summary>
        /// `gemini-omni-1.1`: 360p, 720p, 1080p, 4k; `wan-3.0`: 480p, 720p, 1080p; `ltx-2.5`: 480p, 720p, 1080p.
        /// </summary>
        x360p,
        /// <summary>
        /// `gemini-omni-1.1`: 360p, 720p, 1080p, 4k; `wan-3.0`: 480p, 720p, 1080p; `ltx-2.5`: 480p, 720p, 1080p.
        /// </summary>
        x480p,
        /// <summary>
        /// `gemini-omni-1.1`: 360p, 720p, 1080p, 4k; `wan-3.0`: 480p, 720p, 1080p; `ltx-2.5`: 480p, 720p, 1080p.
        /// </summary>
        x4k,
        /// <summary>
        /// `gemini-omni-1.1`: 360p, 720p, 1080p, 4k; `wan-3.0`: 480p, 720p, 1080p; `ltx-2.5`: 480p, 720p, 1080p.
        /// </summary>
        x720p,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AiVideoEditorCreateVideoRequestResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiVideoEditorCreateVideoRequestResolution value)
        {
            return value switch
            {
                AiVideoEditorCreateVideoRequestResolution.x1080p => "1080p",
                AiVideoEditorCreateVideoRequestResolution.x360p => "360p",
                AiVideoEditorCreateVideoRequestResolution.x480p => "480p",
                AiVideoEditorCreateVideoRequestResolution.x4k => "4k",
                AiVideoEditorCreateVideoRequestResolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiVideoEditorCreateVideoRequestResolution? ToEnum(string value)
        {
            return value switch
            {
                "1080p" => AiVideoEditorCreateVideoRequestResolution.x1080p,
                "360p" => AiVideoEditorCreateVideoRequestResolution.x360p,
                "480p" => AiVideoEditorCreateVideoRequestResolution.x480p,
                "4k" => AiVideoEditorCreateVideoRequestResolution.x4k,
                "720p" => AiVideoEditorCreateVideoRequestResolution.x720p,
                _ => null,
            };
        }
    }
}