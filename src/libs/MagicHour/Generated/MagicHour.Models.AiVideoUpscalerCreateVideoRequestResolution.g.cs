
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Output resolution. `720p` and `1080p` set the output's short side, `2k` and `4k` its long side; the aspect ratio is kept. Requires a paid plan.<br/>
    /// Example: 1080p
    /// </summary>
    public enum AiVideoUpscalerCreateVideoRequestResolution
    {
        /// <summary>
        ///
        /// </summary>
        x1080p,
        /// <summary>
        ///
        /// </summary>
        x2k,
        /// <summary>
        ///
        /// </summary>
        x4k,
        /// <summary>
        ///
        /// </summary>
        x720p,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AiVideoUpscalerCreateVideoRequestResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiVideoUpscalerCreateVideoRequestResolution value)
        {
            return value switch
            {
                AiVideoUpscalerCreateVideoRequestResolution.x1080p => "1080p",
                AiVideoUpscalerCreateVideoRequestResolution.x2k => "2k",
                AiVideoUpscalerCreateVideoRequestResolution.x4k => "4k",
                AiVideoUpscalerCreateVideoRequestResolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiVideoUpscalerCreateVideoRequestResolution? ToEnum(string value)
        {
            return value switch
            {
                "1080p" => AiVideoUpscalerCreateVideoRequestResolution.x1080p,
                "2k" => AiVideoUpscalerCreateVideoRequestResolution.x2k,
                "4k" => AiVideoUpscalerCreateVideoRequestResolution.x4k,
                "720p" => AiVideoUpscalerCreateVideoRequestResolution.x720p,
                _ => null,
            };
        }
    }
}