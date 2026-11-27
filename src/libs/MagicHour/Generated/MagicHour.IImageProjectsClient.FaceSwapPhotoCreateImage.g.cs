#nullable enable

namespace MagicHour
{
    public partial interface IImageProjectsClient
    {
        /// <summary>
        /// Face Swap Photo<br/>
        /// Create a face swap photo. Each photo costs 10 credits. The height/width of the output image depends on your subscription. Please refer to our [pricing](https://magichour.ai/pricing) page for more details
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
        ///      --url https://api.magichour.ai/v1/face-swap-photo \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header "authorization: Bearer $MAGIC_HOUR_API_KEY" \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Face Swap image",<br/>
        ///   "assets": {<br/>
        ///     "face_swap_mode": "all-faces",<br/>
        ///     "source_file_path": "api-assets/id/1234.png",<br/>
        ///     "target_file_path": "api-assets/id/1234.png"<br/>
        ///   }<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.FaceSwapPhotoCreateImageResponse> FaceSwapPhotoCreateImageAsync(

            global::MagicHour.FaceSwapPhotoCreateImageRequest request,
            string? idempotencyKey = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Face Swap Photo<br/>
        /// Create a face swap photo. Each photo costs 10 credits. The height/width of the output image depends on your subscription. Please refer to our [pricing](https://magichour.ai/pricing) page for more details
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
        ///      --url https://api.magichour.ai/v1/face-swap-photo \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header "authorization: Bearer $MAGIC_HOUR_API_KEY" \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Face Swap image",<br/>
        ///   "assets": {<br/>
        ///     "face_swap_mode": "all-faces",<br/>
        ///     "source_file_path": "api-assets/id/1234.png",<br/>
        ///     "target_file_path": "api-assets/id/1234.png"<br/>
        ///   }<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.AutoSDKHttpResponse<global::MagicHour.FaceSwapPhotoCreateImageResponse>> FaceSwapPhotoCreateImageAsResponseAsync(

            global::MagicHour.FaceSwapPhotoCreateImageRequest request,
            string? idempotencyKey = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Face Swap Photo<br/>
        /// Create a face swap photo. Each photo costs 10 credits. The height/width of the output image depends on your subscription. Please refer to our [pricing](https://magichour.ai/pricing) page for more details
        /// </summary>
        /// <param name="idempotencyKey">
        /// A unique string for this request, such as a UUID. Sending the same key again within 24 hours returns the original project instead of creating and charging for a new one. A key applies across all video, image, and audio endpoints on your account, so use a new key for every project.<br/>
        /// Example: 5f3c1b9e-8a41-4a0e-9d3e-2f6a1c7b9e10
        /// </param>
        /// <param name="name">
        /// Give your image a custom name for easy identification.<br/>
        /// Default Value: Face Swap - dateTime<br/>
        /// Example: My Face Swap image
        /// </param>
        /// <param name="assets">
        /// Provide the assets for face swap photo<br/>
        /// Example: {"face_swap_mode":"all-faces","source_file_path":"api-assets/id/1234.png","target_file_path":"api-assets/id/1234.png"}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MagicHour.FaceSwapPhotoCreateImageResponse> FaceSwapPhotoCreateImageAsync(
            global::MagicHour.FaceSwapPhotoCreateImageRequestAssets assets,
            string? idempotencyKey = default,
            string? name = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}