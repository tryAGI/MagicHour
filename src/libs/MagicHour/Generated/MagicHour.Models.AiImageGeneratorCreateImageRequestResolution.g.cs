
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Maximum resolution (longest edge) for the output image.<br/>
    /// **Options:**<br/>
    /// - `640px` — up to 640px<br/>
    /// - `1k` — up to 1024px<br/>
    /// - `2k` — up to 2048px<br/>
    /// - `4k` — up to 4096px<br/>
    /// - `auto` — **Deprecated.** Mapped server-side from your subscription tier to the best matching resolution the model supports<br/>
    /// **Per-model support:**<br/>
    /// - `flux-schnell` - 640px, 1k, 2k<br/>
    /// - `z-image-turbo` - 640px, 1k, 2k<br/>
    /// - `seedream-v4` - 640px, 1k, 2k, 4k<br/>
    /// - `nano-banana` - 640px, 1k<br/>
    /// - `nano-banana-2` - 640px, 1k, 2k, 4k<br/>
    /// - `nano-banana-pro` - 1k, 2k, 4k<br/>
    /// Note: Resolution availability depends on the model and your subscription tier.<br/>
    /// Default Value: auto<br/>
    /// Example: auto
    /// </summary>
    public enum AiImageGeneratorCreateImageRequestResolution
    {
        /// <summary>
        /// 
        /// </summary>
        x1k,
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
        x640px,
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AiImageGeneratorCreateImageRequestResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiImageGeneratorCreateImageRequestResolution value)
        {
            return value switch
            {
                AiImageGeneratorCreateImageRequestResolution.x1k => "1k",
                AiImageGeneratorCreateImageRequestResolution.x2k => "2k",
                AiImageGeneratorCreateImageRequestResolution.x4k => "4k",
                AiImageGeneratorCreateImageRequestResolution.x640px => "640px",
                AiImageGeneratorCreateImageRequestResolution.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiImageGeneratorCreateImageRequestResolution? ToEnum(string value)
        {
            return value switch
            {
                "1k" => AiImageGeneratorCreateImageRequestResolution.x1k,
                "2k" => AiImageGeneratorCreateImageRequestResolution.x2k,
                "4k" => AiImageGeneratorCreateImageRequestResolution.x4k,
                "640px" => AiImageGeneratorCreateImageRequestResolution.x640px,
                "auto" => AiImageGeneratorCreateImageRequestResolution.Auto,
                _ => null,
            };
        }
    }
}