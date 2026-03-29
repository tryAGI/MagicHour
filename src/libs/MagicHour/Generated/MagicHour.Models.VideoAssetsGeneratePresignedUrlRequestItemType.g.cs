
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// The type of asset to upload. Possible types are video, audio, image<br/>
    /// Example: video
    /// </summary>
    public enum VideoAssetsGeneratePresignedUrlRequestItemType
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
    public static class VideoAssetsGeneratePresignedUrlRequestItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoAssetsGeneratePresignedUrlRequestItemType value)
        {
            return value switch
            {
                VideoAssetsGeneratePresignedUrlRequestItemType.Audio => "audio",
                VideoAssetsGeneratePresignedUrlRequestItemType.Image => "image",
                VideoAssetsGeneratePresignedUrlRequestItemType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoAssetsGeneratePresignedUrlRequestItemType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => VideoAssetsGeneratePresignedUrlRequestItemType.Audio,
                "image" => VideoAssetsGeneratePresignedUrlRequestItemType.Image,
                "video" => VideoAssetsGeneratePresignedUrlRequestItemType.Video,
                _ => null,
            };
        }
    }
}