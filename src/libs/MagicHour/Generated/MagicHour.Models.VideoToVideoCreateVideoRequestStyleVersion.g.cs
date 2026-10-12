
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// * `v1` - more detail, closer prompt adherence, and frame-by-frame previews.<br/>
    /// * `v2` - faster, more consistent, and less noisy.<br/>
    /// * `default` - use the selected art style's default version. Some art styles default to v3, which is unavailable through this API. For `Studio Ghibli`, explicitly set `version` to `v2` to use its supported preset.<br/>
    /// Default Value: default<br/>
    /// Example: default
    /// </summary>
    public enum VideoToVideoCreateVideoRequestStyleVersion
    {
        /// <summary>
        ///
        /// </summary>
        Default,
        /// <summary>
        ///
        /// </summary>
        V1,
        /// <summary>
        ///
        /// </summary>
        V2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoToVideoCreateVideoRequestStyleVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoToVideoCreateVideoRequestStyleVersion value)
        {
            return value switch
            {
                VideoToVideoCreateVideoRequestStyleVersion.Default => "default",
                VideoToVideoCreateVideoRequestStyleVersion.V1 => "v1",
                VideoToVideoCreateVideoRequestStyleVersion.V2 => "v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoToVideoCreateVideoRequestStyleVersion? ToEnum(string value)
        {
            return value switch
            {
                "default" => VideoToVideoCreateVideoRequestStyleVersion.Default,
                "v1" => VideoToVideoCreateVideoRequestStyleVersion.V1,
                "v2" => VideoToVideoCreateVideoRequestStyleVersion.V2,
                _ => null,
            };
        }
    }
}