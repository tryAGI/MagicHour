
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// The status of the image.<br/>
    /// - `draft` - the project was created but has not been submitted for rendering<br/>
    /// - `queued` - the job is waiting for an available server<br/>
    /// - `rendering` - the job is being processed; the `image.started` webhook event fires when rendering begins<br/>
    /// - `complete` - the job finished successfully; fires `image.completed`<br/>
    /// - `error` - the job failed during processing; fires `image.errored`<br/>
    /// - `canceled` - the job was manually canceled (for example from the Magic Hour web app)<br/>
    /// **Note:** `rendering`, `complete`, and `error` have matching webhook events; `canceled` does not - a canceled job emits no webhook event, so poll this endpoint to detect cancellation.<br/>
    /// Example: complete
    /// </summary>
    public enum ImageProjectsGetDetailsResponseStatus
    {
        /// <summary>
        /// ** `rendering`, `complete`, and `error` have matching webhook events; `canceled` does not - a canceled job emits no webhook event, so poll this endpoint to detect cancellation.
        /// </summary>
        Canceled,
        /// <summary>
        /// ** `rendering`, `complete`, and `error` have matching webhook events; `canceled` does not - a canceled job emits no webhook event, so poll this endpoint to detect cancellation.
        /// </summary>
        Complete,
        /// <summary>
        ///
        /// </summary>
        Draft,
        /// <summary>
        /// ** `rendering`, `complete`, and `error` have matching webhook events; `canceled` does not - a canceled job emits no webhook event, so poll this endpoint to detect cancellation.
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        Queued,
        /// <summary>
        /// ** `rendering`, `complete`, and `error` have matching webhook events; `canceled` does not - a canceled job emits no webhook event, so poll this endpoint to detect cancellation.
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