
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// The upscaling mode. `preserve` keeps the image faithful using the v2 pipeline with a 1x credit multiplier. `balanced` applies natural improvements using the v1 pipeline with creativity set to 0.2 and a 2x credit multiplier. `creative` reimagines details using the v1 pipeline with creativity set to 0.35, accepts `prompt`, and has a 2x credit multiplier. `pro` is deprecated and maps to `preserve`. Defaults to `balanced`.<br/>
    /// Default Value: balanced<br/>
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