
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Deprecated. Use `mode` instead. `Resemblance` maps to `preserve`, `Balanced` maps to `balanced`, and `Creative` maps to `creative`.
    /// </summary>
    public enum AiImageUpscalerCreateImageRequestStyleEnhancement
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
        Resemblance,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AiImageUpscalerCreateImageRequestStyleEnhancementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiImageUpscalerCreateImageRequestStyleEnhancement value)
        {
            return value switch
            {
                AiImageUpscalerCreateImageRequestStyleEnhancement.Balanced => "Balanced",
                AiImageUpscalerCreateImageRequestStyleEnhancement.Creative => "Creative",
                AiImageUpscalerCreateImageRequestStyleEnhancement.Resemblance => "Resemblance",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiImageUpscalerCreateImageRequestStyleEnhancement? ToEnum(string value)
        {
            return value switch
            {
                "Balanced" => AiImageUpscalerCreateImageRequestStyleEnhancement.Balanced,
                "Creative" => AiImageUpscalerCreateImageRequestStyleEnhancement.Creative,
                "Resemblance" => AiImageUpscalerCreateImageRequestStyleEnhancement.Resemblance,
                _ => null,
            };
        }
    }
}