
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Choose your video source.<br/>
    /// Example: file
    /// </summary>
    public enum FaceSwapCreateVideoRequestAssetsVideoSource
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
    public static class FaceSwapCreateVideoRequestAssetsVideoSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FaceSwapCreateVideoRequestAssetsVideoSource value)
        {
            return value switch
            {
                FaceSwapCreateVideoRequestAssetsVideoSource.File => "file",
                FaceSwapCreateVideoRequestAssetsVideoSource.Youtube => "youtube",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FaceSwapCreateVideoRequestAssetsVideoSource? ToEnum(string value)
        {
            return value switch
            {
                "file" => FaceSwapCreateVideoRequestAssetsVideoSource.File,
                "youtube" => FaceSwapCreateVideoRequestAssetsVideoSource.Youtube,
                _ => null,
            };
        }
    }
}