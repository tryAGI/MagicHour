
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// The status of the image.<br/>
    /// Example: complete
    /// </summary>
    public enum ImageProjectsGetDetailsResponseStatus
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
    public static class ImageProjectsGetDetailsResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageProjectsGetDetailsResponseStatus value)
        {
            return value switch
            {
                ImageProjectsGetDetailsResponseStatus.Canceled => "canceled",
                ImageProjectsGetDetailsResponseStatus.Complete => "complete",
                ImageProjectsGetDetailsResponseStatus.Draft => "draft",
                ImageProjectsGetDetailsResponseStatus.Error => "error",
                ImageProjectsGetDetailsResponseStatus.Queued => "queued",
                ImageProjectsGetDetailsResponseStatus.Rendering => "rendering",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageProjectsGetDetailsResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => ImageProjectsGetDetailsResponseStatus.Canceled,
                "complete" => ImageProjectsGetDetailsResponseStatus.Complete,
                "draft" => ImageProjectsGetDetailsResponseStatus.Draft,
                "error" => ImageProjectsGetDetailsResponseStatus.Error,
                "queued" => ImageProjectsGetDetailsResponseStatus.Queued,
                "rendering" => ImageProjectsGetDetailsResponseStatus.Rendering,
                _ => null,
            };
        }
    }
}