
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Choose your video source.<br/>
    /// Example: file
    /// </summary>
    public enum VideoToVideoCreateVideoRequestAssetsVideoSource
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
    public static class VideoToVideoCreateVideoRequestAssetsVideoSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoToVideoCreateVideoRequestAssetsVideoSource value)
        {
            return value switch
            {
                VideoToVideoCreateVideoRequestAssetsVideoSource.File => "file",
                VideoToVideoCreateVideoRequestAssetsVideoSource.Youtube => "youtube",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoToVideoCreateVideoRequestAssetsVideoSource? ToEnum(string value)
        {
            return value switch
            {
                "file" => VideoToVideoCreateVideoRequestAssetsVideoSource.File,
                "youtube" => VideoToVideoCreateVideoRequestAssetsVideoSource.Youtube,
                _ => null,
            };
        }
    }
}