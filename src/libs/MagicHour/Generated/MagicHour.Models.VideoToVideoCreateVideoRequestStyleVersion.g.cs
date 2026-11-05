
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// * `v1` - more detail, closer prompt adherence, and frame-by-frame previews.<br/>
    /// * `v2` - faster, more consistent, and less noisy.<br/>
    /// * `v3` - consistent styling guided by a caller-supplied reference image. Requires assets.initial_image_path and positive width/height.<br/>
    /// * `default` - use the selected art style's default version, including v3.<br/>
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
        /// <summary>
        ///
        /// </summary>
        V3,
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
                VideoToVideoCreateVideoRequestStyleVersion.V3 => "v3",
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
                "v3" => VideoToVideoCreateVideoRequestStyleVersion.V3,
                _ => null,
            };
        }
    }
}