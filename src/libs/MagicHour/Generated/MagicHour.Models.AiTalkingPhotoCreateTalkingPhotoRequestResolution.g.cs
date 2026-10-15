
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Output preset. Overrides `max_resolution`. Defaults to 480p in prompted mode; realistic mode uses the mapped plan maximum.<br/>
    /// Example: 480p
    /// </summary>
    public enum AiTalkingPhotoCreateTalkingPhotoRequestResolution
    {
        /// <summary>
        ///
        /// </summary>
        x480p,
        /// <summary>
        ///
        /// </summary>
        x720p,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AiTalkingPhotoCreateTalkingPhotoRequestResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiTalkingPhotoCreateTalkingPhotoRequestResolution value)
        {
            return value switch
            {
                AiTalkingPhotoCreateTalkingPhotoRequestResolution.x480p => "480p",
                AiTalkingPhotoCreateTalkingPhotoRequestResolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiTalkingPhotoCreateTalkingPhotoRequestResolution? ToEnum(string value)
        {
            return value switch
            {
                "480p" => AiTalkingPhotoCreateTalkingPhotoRequestResolution.x480p,
                "720p" => AiTalkingPhotoCreateTalkingPhotoRequestResolution.x720p,
                _ => null,
            };
        }
    }
}