
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Output resolution. Defaults to `480p` for free tier and `720p` for paid. `gemini-omni-1.1` and deprecated `gemini-omni` support 720p and 1080p; LTX-2.3 supports 480p, 720p, and 1080p.<br/>
    /// Example: 720p
    /// </summary>
    public enum AiVideoEditorCreateVideoRequestResolution
    {
        /// <summary>
        ///
        /// </summary>
        x1080p,
        /// <summary>
        ///
        /// </summary>
        x480p,
        /// <summary>
        ///
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
                AiVideoEditorCreateVideoRequestResolution.x480p => "480p",
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
                "480p" => AiVideoEditorCreateVideoRequestResolution.x480p,
                "720p" => AiVideoEditorCreateVideoRequestResolution.x720p,
                _ => null,
            };
        }
    }
}