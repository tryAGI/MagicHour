
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// The upscaling mode. `"pro"` is faster and does not require `enhancement`. `"creative"` requires `enhancement`. Defaults to `"creative"`.<br/>
    /// Example: creative
    /// </summary>
    public enum AiImageUpscalerCreateImageRequestStyleMode
    {
        /// <summary>
        /// 
        /// </summary>
        Creative,
        /// <summary>
        /// 
        /// </summary>
        Pro,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AiImageUpscalerCreateImageRequestStyleModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiImageUpscalerCreateImageRequestStyleMode value)
        {
            return value switch
            {
                AiImageUpscalerCreateImageRequestStyleMode.Creative => "creative",
                AiImageUpscalerCreateImageRequestStyleMode.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiImageUpscalerCreateImageRequestStyleMode? ToEnum(string value)
        {
            return value switch
            {
                "creative" => AiImageUpscalerCreateImageRequestStyleMode.Creative,
                "pro" => AiImageUpscalerCreateImageRequestStyleMode.Pro,
                _ => null,
            };
        }
    }
}