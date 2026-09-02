
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Type of clothing item to swap. If not provided, swaps the entire outfit. <br/>
    /// * `upper_body` - for shirts/jackets <br/>
    /// * `lower_body` - for pants/skirts <br/>
    /// * `dresses` - for entire outfit (deprecated, use `entire_outfit` instead) <br/>
    /// * `entire_outfit` - for entire outfit<br/>
    /// Example: entire_outfit
    /// </summary>
    public enum AiClothesChangerCreateImageRequestAssetsGarmentType
    {
        /// <summary>
        ///
        /// </summary>
        Dresses,
        /// <summary>
        ///
        /// </summary>
        EntireOutfit,
        /// <summary>
        ///
        /// </summary>
        LowerBody,
        /// <summary>
        ///
        /// </summary>
        UpperBody,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AiClothesChangerCreateImageRequestAssetsGarmentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiClothesChangerCreateImageRequestAssetsGarmentType value)
        {
            return value switch
            {
                AiClothesChangerCreateImageRequestAssetsGarmentType.Dresses => "dresses",
                AiClothesChangerCreateImageRequestAssetsGarmentType.EntireOutfit => "entire_outfit",
                AiClothesChangerCreateImageRequestAssetsGarmentType.LowerBody => "lower_body",
                AiClothesChangerCreateImageRequestAssetsGarmentType.UpperBody => "upper_body",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiClothesChangerCreateImageRequestAssetsGarmentType? ToEnum(string value)
        {
            return value switch
            {
                "dresses" => AiClothesChangerCreateImageRequestAssetsGarmentType.Dresses,
                "entire_outfit" => AiClothesChangerCreateImageRequestAssetsGarmentType.EntireOutfit,
                "lower_body" => AiClothesChangerCreateImageRequestAssetsGarmentType.LowerBody,
                "upper_body" => AiClothesChangerCreateImageRequestAssetsGarmentType.UpperBody,
                _ => null,
            };
        }
    }
}