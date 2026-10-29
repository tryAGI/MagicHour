#nullable enable

namespace MagicHour
{
    public partial interface IVideoProjectsClient
    {
        /// <summary>
        /// AI UGC Ad Generator<br/>
        /// Create a spoken UGC video from a prepared image and script. Returns a project ID; poll GET /v1/video-projects/{id} for status and downloads. To compose an image, generate the image separately with the Image Editor API and supply its download URL.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/ai-ugc-ad \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header "authorization: Bearer $MAGIC_HOUR_API_KEY" \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "assets": {<br/>
        ///     "image_file_path": "api-assets/id/image.jpg"<br/>
        ///   },<br/>
        ///   "script": "Meet your new everyday essential.",<br/>
        ///   "end_seconds": 4,<br/>
        ///   "model": "kling-3.0",<br/>
        ///   "resolution": "480p"<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.AiUgcAdCreateVideoResponse> AiUgcAdCreateVideoAsync(

            global::MagicHour.AiUgcAdCreateVideoRequest request,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// AI UGC Ad Generator<br/>
        /// Create a spoken UGC video from a prepared image and script. Returns a project ID; poll GET /v1/video-projects/{id} for status and downloads. To compose an image, generate the image separately with the Image Editor API and supply its download URL.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/ai-ugc-ad \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header "authorization: Bearer $MAGIC_HOUR_API_KEY" \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "assets": {<br/>
        ///     "image_file_path": "api-assets/id/image.jpg"<br/>
        ///   },<br/>
        ///   "script": "Meet your new everyday essential.",<br/>
        ///   "end_seconds": 4,<br/>
        ///   "model": "kling-3.0",<br/>
        ///   "resolution": "480p"<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.AutoSDKHttpResponse<global::MagicHour.AiUgcAdCreateVideoResponse>> AiUgcAdCreateVideoAsResponseAsync(

            global::MagicHour.AiUgcAdCreateVideoRequest request,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// AI UGC Ad Generator<br/>
        /// Create a spoken UGC video from a prepared image and script. Returns a project ID; poll GET /v1/video-projects/{id} for status and downloads. To compose an image, generate the image separately with the Image Editor API and supply its download URL.
        /// </summary>
        /// <param name="assets"></param>
        /// <param name="script">
        /// The words the actor should speak. Character limits apply after trimming:<br/>
        /// * kling-3.0: 2304 characters.<br/>
        /// * ltx-2.5: 1804 characters.<br/>
        /// * veo3.1: 2500 characters.<br/>
        /// LTX and Kling dialogue wrappers count toward their model prompt limit.<br/>
        /// Example: Meet your new everyday essential.
        /// </param>
        /// <param name="endSeconds">
        /// Video duration in seconds. Supported values by model:<br/>
        /// * kling-3.0: 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 seconds.<br/>
        /// * ltx-2.5: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60 seconds.<br/>
        /// * veo3.1: 4, 6, 8, 15, 22, 29, 36, 43, 50, 57, 64, 71, 78, 85, 92, 99, 106, 113, 120, 127, 134, 141 seconds.<br/>
        /// Free plans are limited to 5 seconds unless a credit pack has been purchased.<br/>
        /// Example: 4
        /// </param>
        /// <param name="model">
        /// Defaults to kling-3.0 on paid plans and ltx-2.5 on free plans.
        /// </param>
        /// <param name="resolution">
        /// Defaults to 720p on paid plans and 480p on free plans. Unsupported model/resolution combinations and resolutions unavailable for your plan are rejected.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MagicHour.AiUgcAdCreateVideoResponse> AiUgcAdCreateVideoAsync(
            global::MagicHour.AiUgcAdCreateVideoRequestAssets assets,
            string script,
            double endSeconds,
            global::MagicHour.AiUgcAdCreateVideoRequestModel? model = default,
            global::MagicHour.AiUgcAdCreateVideoRequestResolution? resolution = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}