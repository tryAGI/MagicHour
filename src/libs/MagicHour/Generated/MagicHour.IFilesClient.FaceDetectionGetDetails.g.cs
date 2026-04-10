#nullable enable

namespace MagicHour
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Get face detection details<br/>
        /// Get the details of a face detection task. <br/>
        /// Use this API to get the list of faces detected in the image or video to use in the [face swap photo](https://docs.magichour.ai/api-reference/image-projects/face-swap-photo) or [face swap video](https://docs.magichour.ai/api-reference/video-projects/face-swap-video) API calls for multi-face swaps.
        /// </summary>
        /// <param name="id">
        /// Example: uuid-example
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        ///      --url https://api.magichour.ai/v1/face-detection/id \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header 'authorization: Bearer &lt;token&gt;'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.FaceDetectionGetDetailsResponse> FaceDetectionGetDetailsAsync(
            string id,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}