
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Example: character
    /// </summary>
    public enum SavedItemsListType
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
    public static class SavedItemsListTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SavedItemsListType value)
        {
            return value switch
            {
                SavedItemsListType.BrandKit => "brand_kit",
                SavedItemsListType.Character => "character",
                SavedItemsListType.Moodboard => "moodboard",
                SavedItemsListType.Reference => "reference",
                SavedItemsListType.Voice => "voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SavedItemsListType? ToEnum(string value)
        {
            return value switch
            {
                "brand_kit" => SavedItemsListType.BrandKit,
                "character" => SavedItemsListType.Character,
                "moodboard" => SavedItemsListType.Moodboard,
                "reference" => SavedItemsListType.Reference,
                "voice" => SavedItemsListType.Voice,
                _ => null,
            };
        }
    }
}