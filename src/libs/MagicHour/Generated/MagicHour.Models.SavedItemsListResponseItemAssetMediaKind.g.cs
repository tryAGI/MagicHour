
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Media type of the asset.<br/>
    /// Example: IMAGE
    /// </summary>
    public enum SavedItemsListResponseItemAssetMediaKind
    {
        /// <summary>
        ///
        /// </summary>
        Audio,
        /// <summary>
        ///
        /// </summary>
        Image,
        /// <summary>
        ///
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SavedItemsListResponseItemAssetMediaKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SavedItemsListResponseItemAssetMediaKind value)
        {
            return value switch
            {
                SavedItemsListResponseItemAssetMediaKind.Audio => "AUDIO",
                SavedItemsListResponseItemAssetMediaKind.Image => "IMAGE",
                SavedItemsListResponseItemAssetMediaKind.Video => "VIDEO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SavedItemsListResponseItemAssetMediaKind? ToEnum(string value)
        {
            return value switch
            {
                "AUDIO" => SavedItemsListResponseItemAssetMediaKind.Audio,
                "IMAGE" => SavedItemsListResponseItemAssetMediaKind.Image,
                "VIDEO" => SavedItemsListResponseItemAssetMediaKind.Video,
                _ => null,
            };
        }
    }
}