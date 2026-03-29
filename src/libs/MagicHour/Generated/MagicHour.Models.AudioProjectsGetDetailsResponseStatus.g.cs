
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// The status of the audio.<br/>
    /// Example: complete
    /// </summary>
    public enum AudioProjectsGetDetailsResponseStatus
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
    public static class AudioProjectsGetDetailsResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioProjectsGetDetailsResponseStatus value)
        {
            return value switch
            {
                AudioProjectsGetDetailsResponseStatus.Canceled => "canceled",
                AudioProjectsGetDetailsResponseStatus.Complete => "complete",
                AudioProjectsGetDetailsResponseStatus.Draft => "draft",
                AudioProjectsGetDetailsResponseStatus.Error => "error",
                AudioProjectsGetDetailsResponseStatus.Queued => "queued",
                AudioProjectsGetDetailsResponseStatus.Rendering => "rendering",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioProjectsGetDetailsResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => AudioProjectsGetDetailsResponseStatus.Canceled,
                "complete" => AudioProjectsGetDetailsResponseStatus.Complete,
                "draft" => AudioProjectsGetDetailsResponseStatus.Draft,
                "error" => AudioProjectsGetDetailsResponseStatus.Error,
                "queued" => AudioProjectsGetDetailsResponseStatus.Queued,
                "rendering" => AudioProjectsGetDetailsResponseStatus.Rendering,
                _ => null,
            };
        }
    }
}