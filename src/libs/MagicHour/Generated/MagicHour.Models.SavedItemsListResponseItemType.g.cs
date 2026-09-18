
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Saved item type.<br/>
    /// Example: character
    /// </summary>
    public enum SavedItemsListResponseItemType
    {
        /// <summary>
        ///
        /// </summary>
        BrandKit,
        /// <summary>
        ///
        /// </summary>
        Character,
        /// <summary>
        ///
        /// </summary>
        Moodboard,
        /// <summary>
        ///
        /// </summary>
        Reference,
        /// <summary>
        ///
        /// </summary>
        Voice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SavedItemsListResponseItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SavedItemsListResponseItemType value)
        {
            return value switch
            {
                SavedItemsListResponseItemType.BrandKit => "brand_kit",
                SavedItemsListResponseItemType.Character => "character",
                SavedItemsListResponseItemType.Moodboard => "moodboard",
                SavedItemsListResponseItemType.Reference => "reference",
                SavedItemsListResponseItemType.Voice => "voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SavedItemsListResponseItemType? ToEnum(string value)
        {
            return value switch
            {
                "brand_kit" => SavedItemsListResponseItemType.BrandKit,
                "character" => SavedItemsListResponseItemType.Character,
                "moodboard" => SavedItemsListResponseItemType.Moodboard,
                "reference" => SavedItemsListResponseItemType.Reference,
                "voice" => SavedItemsListResponseItemType.Voice,
                _ => null,
            };
        }
    }
}