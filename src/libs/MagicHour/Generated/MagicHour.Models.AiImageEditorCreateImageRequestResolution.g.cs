
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
    /// - `nano-banana-2` - 640px, 1k, 2k, 4k<br/>
    /// - `gpt-image-2` - 640px, 1k, 2k, 4k<br/>
    /// - `flux-2-klein` - 640px, 1k, 2k<br/>
    /// - `nano-banana-2-lite` - 640px, 1k<br/>
    /// - `qwen-edit` - 640px, 1k, 2k<br/>
    /// - `seedream-v4` - 640px, 1k, 2k, 4k<br/>
    /// - `seedream-v4.5` - 640px, 1k, 2k, 4k<br/>
    /// - `seedream-v5-pro` - 640px, 1k, 2k<br/>
    /// - `nano-banana` - 640px, 1k<br/>
    /// - `nano-banana-pro` - 1k, 2k, 4k<br/>
    /// Note: Resolution availability depends on the model and your subscription tier.<br/>
    /// Example: 1k
    /// </summary>
    public enum AiImageEditorCreateImageRequestResolution
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
    public static class AiImageEditorCreateImageRequestResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiImageEditorCreateImageRequestResolution value)
        {
            return value switch
            {
                AiImageEditorCreateImageRequestResolution.x1k => "1k",
                AiImageEditorCreateImageRequestResolution.x2k => "2k",
                AiImageEditorCreateImageRequestResolution.x4k => "4k",
                AiImageEditorCreateImageRequestResolution.x640px => "640px",
                AiImageEditorCreateImageRequestResolution.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiImageEditorCreateImageRequestResolution? ToEnum(string value)
        {
            return value switch
            {
                "1k" => AiImageEditorCreateImageRequestResolution.x1k,
                "2k" => AiImageEditorCreateImageRequestResolution.x2k,
                "4k" => AiImageEditorCreateImageRequestResolution.x4k,
                "640px" => AiImageEditorCreateImageRequestResolution.x640px,
                "auto" => AiImageEditorCreateImageRequestResolution.Auto,
                _ => null,
            };
        }
    }
}