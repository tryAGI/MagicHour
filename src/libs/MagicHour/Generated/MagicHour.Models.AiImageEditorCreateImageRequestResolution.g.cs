
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Maximum resolution for the generated image.<br/>
    /// **Options:**<br/>
    /// - `auto` - Automatic resolution (all tiers, default)<br/>
    /// - `2k` - Up to 2048px (requires Pro or Business tier)<br/>
    /// - `4k` - Up to 4096px (requires Business tier)<br/>
    /// Note: Resolution availability depends on your subscription tier. Defaults to `auto` if not specified.<br/>
    /// Example: auto
    /// </summary>
    public enum AiImageEditorCreateImageRequestResolution
    {
        /// <summary>
        /// 
        /// </summary>
        x2k,
        /// <summary>
        /// 
        /// </summary>
        x4k,
        /// <summary>
        /// Resolution availability depends on your subscription tier. Defaults to `auto` if not specified.
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
                AiImageEditorCreateImageRequestResolution.x2k => "2k",
                AiImageEditorCreateImageRequestResolution.x4k => "4k",
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
                "2k" => AiImageEditorCreateImageRequestResolution.x2k,
                "4k" => AiImageEditorCreateImageRequestResolution.x4k,
                "auto" => AiImageEditorCreateImageRequestResolution.Auto,
                _ => null,
            };
        }
    }
}