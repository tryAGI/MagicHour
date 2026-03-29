
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// The status of the video.<br/>
    /// Example: complete
    /// </summary>
    public enum VideoProjectsGetDetailsResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Canceled,
        /// <summary>
        /// 
        /// </summary>
        Complete,
        /// <summary>
        /// 
        /// </summary>
        Draft,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Rendering,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoProjectsGetDetailsResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoProjectsGetDetailsResponseStatus value)
        {
            return value switch
            {
                VideoProjectsGetDetailsResponseStatus.Canceled => "canceled",
                VideoProjectsGetDetailsResponseStatus.Complete => "complete",
                VideoProjectsGetDetailsResponseStatus.Draft => "draft",
                VideoProjectsGetDetailsResponseStatus.Error => "error",
                VideoProjectsGetDetailsResponseStatus.Queued => "queued",
                VideoProjectsGetDetailsResponseStatus.Rendering => "rendering",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoProjectsGetDetailsResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => VideoProjectsGetDetailsResponseStatus.Canceled,
                "complete" => VideoProjectsGetDetailsResponseStatus.Complete,
                "draft" => VideoProjectsGetDetailsResponseStatus.Draft,
                "error" => VideoProjectsGetDetailsResponseStatus.Error,
                "queued" => VideoProjectsGetDetailsResponseStatus.Queued,
                "rendering" => VideoProjectsGetDetailsResponseStatus.Rendering,
                _ => null,
            };
        }
    }
}