#nullable enable

namespace MagicHour
{
    public partial interface IImageProjectsClient
    {
        /// <summary>
        /// Body Swap<br/>
        /// Swap a person into a scene image using Nano Banana 2 Lite (640px/1k) or Nano Banana 2.1 (2k/4k). Credits depend on `resolution` (from 50 credits at 640px upward).
        /// </summary>
        /// <param name="idempotencyKey">
        /// A unique string for this request, such as a UUID. Sending the same key again within 24 hours returns the original project instead of creating and charging for a new one. A key applies across all video, image, and audio endpoints on your account, so use a new key for every project.<br/>
        /// Example: 5f3c1b9e-8a41-4a0e-9d3e-2f6a1c7b9e10
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/body-swap \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header "authorization: Bearer $MAGIC_HOUR_API_KEY" \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Body Swap image",<br/>
        ///   "resolution": "640px",<br/>
        ///   "assets": {<br/>
        ///     "person_file_path": "api-assets/id/1234.png",<br/>
        ///     "scene_file_path": "api-assets/id/5678.png"<br/>
        ///   }<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.BodySwapCreateImageResponse> BodySwapCreateImageAsync(

            global::MagicHour.BodySwapCreateImageRequest request,
            string? idempotencyKey = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Body Swap<br/>
        /// Swap a person into a scene image using Nano Banana 2 Lite (640px/1k) or Nano Banana 2.1 (2k/4k). Credits depend on `resolution` (from 50 credits at 640px upward).
        /// </summary>
        /// <param name="idempotencyKey">
        /// A unique string for this request, such as a UUID. Sending the same key again within 24 hours returns the original project instead of creating and charging for a new one. A key applies across all video, image, and audio endpoints on your account, so use a new key for every project.<br/>
        /// Example: 5f3c1b9e-8a41-4a0e-9d3e-2f6a1c7b9e10
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/body-swap \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header "authorization: Bearer $MAGIC_HOUR_API_KEY" \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Body Swap image",<br/>
        ///   "resolution": "640px",<br/>
        ///   "assets": {<br/>
        ///     "person_file_path": "api-assets/id/1234.png",<br/>
        ///     "scene_file_path": "api-assets/id/5678.png"<br/>
        ///   }<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.AutoSDKHttpResponse<global::MagicHour.BodySwapCreateImageResponse>> BodySwapCreateImageAsResponseAsync(

            global::MagicHour.BodySwapCreateImageRequest request,
            string? idempotencyKey = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Body Swap<br/>
        /// Swap a person into a scene image using Nano Banana 2 Lite (640px/1k) or Nano Banana 2.1 (2k/4k). Credits depend on `resolution` (from 50 credits at 640px upward).
        /// </summary>
        /// <param name="idempotencyKey">
        /// A unique string for this request, such as a UUID. Sending the same key again within 24 hours returns the original project instead of creating and charging for a new one. A key applies across all video, image, and audio endpoints on your account, so use a new key for every project.<br/>
        /// Example: 5f3c1b9e-8a41-4a0e-9d3e-2f6a1c7b9e10
        /// </param>
        /// <param name="name">
        /// Give your image a custom name for easy identification.<br/>
        /// Default Value: Body Swap - dateTime<br/>
        /// Example: My Body Swap image
        /// </param>
        /// <param name="resolution">
        /// Output resolution. Determines credits charged for the run.<br/>
        /// Example: 640px
        /// </param>
        /// <param name="assets">
        /// Person image and scene image for body swap
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MagicHour.BodySwapCreateImageResponse> BodySwapCreateImageAsync(
            global::MagicHour.BodySwapCreateImageRequestResolution resolution,
            global::MagicHour.BodySwapCreateImageRequestAssets assets,
            string? idempotencyKey = default,
            string? name = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}