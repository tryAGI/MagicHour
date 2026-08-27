
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// The status of the video.<br/>
    /// - `draft` - the project was created but has not been submitted for rendering<br/>
    /// - `queued` - the job is waiting for an available server<br/>
    /// - `rendering` - the job is being processed; the `video.started` webhook event fires when rendering begins<br/>
    /// - `complete` - the job finished successfully; fires `video.completed`<br/>
    /// - `error` - the job failed during processing; fires `video.errored`<br/>
    /// - `canceled` - the job was manually canceled (for example from the Magic Hour web app)<br/>
    /// **Note:** `rendering`, `complete`, and `error` have matching webhook events; `canceled` does not - a canceled job emits no webhook event, so poll this endpoint to detect cancellation.<br/>
    /// Example: complete
    /// </summary>
    public enum VideoProjectsGetDetailsResponseStatus
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