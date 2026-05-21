#nullable enable

namespace MagicHour
{
    public partial interface IVideoProjectsClient
    {
        /// <summary>
        /// Get video details<br/>
        /// Check the progress of a video project. The `downloads` field is populated after a successful render.<br/>
        ///   <br/>
        /// **Statuses**<br/>
        /// - `queued` — waiting to start<br/>
        /// - `rendering` — in progress<br/>
        /// - `complete` — ready; see `downloads`<br/>
        /// - `error` — a failure occurred (see `error`)<br/>
        /// - `canceled` — user canceled<br/>
        /// - `draft` — not used
        /// </summary>
        /// <param name="id">
        /// Example: cuid-example
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        ///      --url https://api.magichour.ai/v1/video-projects/id \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header 'authorization: Bearer &lt;token&gt;'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.VideoProjectsGetDetailsResponse> VideoProjectsGetDetailsAsync(
            string id,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get video details<br/>
        /// Check the progress of a video project. The `downloads` field is populated after a successful render.<br/>
        ///   <br/>
        /// **Statuses**<br/>
        /// - `queued` — waiting to start<br/>
        /// - `rendering` — in progress<br/>
        /// - `complete` — ready; see `downloads`<br/>
        /// - `error` — a failure occurred (see `error`)<br/>
        /// - `canceled` — user canceled<br/>
        /// - `draft` — not used
        /// </summary>
        /// <param name="id">
        /// Example: cuid-example
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        ///      --url https://api.magichour.ai/v1/video-projects/id \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header 'authorization: Bearer &lt;token&gt;'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.AutoSDKHttpResponse<global::MagicHour.VideoProjectsGetDetailsResponse>> VideoProjectsGetDetailsAsResponseAsync(
            string id,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}