
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Output video resolution. Defaults to `720p` on paid tiers and `480p` on free tiers.<br/>
    /// Example: 720p
    /// </summary>
    public enum AudioToVideoCreateVideoRequestResolution
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
    public static class AudioToVideoCreateVideoRequestResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioToVideoCreateVideoRequestResolution value)
        {
            return value switch
            {
                AudioToVideoCreateVideoRequestResolution.x1080p => "1080p",
                AudioToVideoCreateVideoRequestResolution.x480p => "480p",
                AudioToVideoCreateVideoRequestResolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioToVideoCreateVideoRequestResolution? ToEnum(string value)
        {
            return value switch
            {
                "1080p" => AudioToVideoCreateVideoRequestResolution.x1080p,
                "480p" => AudioToVideoCreateVideoRequestResolution.x480p,
                "720p" => AudioToVideoCreateVideoRequestResolution.x720p,
                _ => null,
            };
        }
    }
}