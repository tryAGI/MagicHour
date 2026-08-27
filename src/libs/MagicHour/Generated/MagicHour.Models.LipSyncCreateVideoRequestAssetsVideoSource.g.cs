
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Choose your video source.<br/>
    /// Example: file
    /// </summary>
    public enum LipSyncCreateVideoRequestAssetsVideoSource
    {
        /// <summary>
        ///
        /// </summary>
        File,
        /// <summary>
        ///
        /// </summary>
        Youtube,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LipSyncCreateVideoRequestAssetsVideoSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LipSyncCreateVideoRequestAssetsVideoSource value)
        {
            return value switch
            {
                LipSyncCreateVideoRequestAssetsVideoSource.File => "file",
                LipSyncCreateVideoRequestAssetsVideoSource.Youtube => "youtube",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LipSyncCreateVideoRequestAssetsVideoSource? ToEnum(string value)
        {
            return value switch
            {
                "file" => LipSyncCreateVideoRequestAssetsVideoSource.File,
                "youtube" => LipSyncCreateVideoRequestAssetsVideoSource.Youtube,
                _ => null,
            };
        }
    }
}