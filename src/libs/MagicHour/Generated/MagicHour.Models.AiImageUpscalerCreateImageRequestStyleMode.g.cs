
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// The upscaling mode. `"preserve"` uses the fast pro pipeline (1× credit multiplier). `"balanced"` and `"creative"` use the creative pipeline (2× credit multiplier). `"pro"` is deprecated and maps to `"preserve"`. Defaults to `"balanced"`.<br/>
    /// Example: balanced
    /// </summary>
    public enum AiImageUpscalerCreateImageRequestStyleMode
    {
        /// <summary>
        /// 
        /// </summary>
        Balanced,
        /// <summary>
        /// 
        /// </summary>
        Creative,
        /// <summary>
        /// 
        /// </summary>
        Preserve,
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
                AiImageUpscalerCreateImageRequestStyleMode.Balanced => "balanced",
                AiImageUpscalerCreateImageRequestStyleMode.Creative => "creative",
                AiImageUpscalerCreateImageRequestStyleMode.Preserve => "preserve",
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
                "balanced" => AiImageUpscalerCreateImageRequestStyleMode.Balanced,
                "creative" => AiImageUpscalerCreateImageRequestStyleMode.Creative,
                "preserve" => AiImageUpscalerCreateImageRequestStyleMode.Preserve,
                "pro" => AiImageUpscalerCreateImageRequestStyleMode.Pro,
                _ => null,
            };
        }
    }
}