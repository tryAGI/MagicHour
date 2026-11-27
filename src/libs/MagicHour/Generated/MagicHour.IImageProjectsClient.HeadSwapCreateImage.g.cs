#nullable enable

namespace MagicHour
{
    public partial interface IImageProjectsClient
    {
        /// <summary>
        /// Head Swap<br/>
        /// Swap a head onto a body image. Each image costs 10 credits. Output resolution depends on your subscription; you may set `max_resolution` lower than your plan maximum if desired.
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
        ///      --url https://api.magichour.ai/v1/head-swap \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header "authorization: Bearer $MAGIC_HOUR_API_KEY" \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Head Swap image",<br/>
        ///   "max_resolution": 512,<br/>
        ///   "assets": {<br/>
        ///     "body_file_path": "api-assets/id/1234.png",<br/>
        ///     "head_file_path": "api-assets/id/5678.png"<br/>
        ///   }<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.HeadSwapCreateImageResponse> HeadSwapCreateImageAsync(

            global::MagicHour.HeadSwapCreateImageRequest request,
            string? idempotencyKey = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Head Swap<br/>
        /// Swap a head onto a body image. Each image costs 10 credits. Output resolution depends on your subscription; you may set `max_resolution` lower than your plan maximum if desired.
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
        ///      --url https://api.magichour.ai/v1/head-swap \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header "authorization: Bearer $MAGIC_HOUR_API_KEY" \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Head Swap image",<br/>
        ///   "max_resolution": 512,<br/>
        ///   "assets": {<br/>
        ///     "body_file_path": "api-assets/id/1234.png",<br/>
        ///     "head_file_path": "api-assets/id/5678.png"<br/>
        ///   }<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.AutoSDKHttpResponse<global::MagicHour.HeadSwapCreateImageResponse>> HeadSwapCreateImageAsResponseAsync(

            global::MagicHour.HeadSwapCreateImageRequest request,
            string? idempotencyKey = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Head Swap<br/>
        /// Swap a head onto a body image. Each image costs 10 credits. Output resolution depends on your subscription; you may set `max_resolution` lower than your plan maximum if desired.
        /// </summary>
        /// <param name="idempotencyKey">
        /// A unique string for this request, such as a UUID. Sending the same key again within 24 hours returns the original project instead of creating and charging for a new one. A key applies across all video, image, and audio endpoints on your account, so use a new key for every project.<br/>
        /// Example: 5f3c1b9e-8a41-4a0e-9d3e-2f6a1c7b9e10
        /// </param>
        /// <param name="name">
        /// Give your image a custom name for easy identification.<br/>
        /// Default Value: Head Swap - dateTime<br/>
        /// Example: My Head Swap image
        /// </param>
        /// <param name="maxResolution">
        /// Constrains the larger dimension (height or width) of the output. Omit to use the maximum allowed for your plan (capped at 2048px). Values above your plan maximum are clamped down to your plan's maximum.<br/>
        /// Example: 512
        /// </param>
        /// <param name="assets">
        /// Provide the body and head images for head swap
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MagicHour.HeadSwapCreateImageResponse> HeadSwapCreateImageAsync(
            global::MagicHour.HeadSwapCreateImageRequestAssets assets,
            string? idempotencyKey = default,
            string? name = default,
            int? maxResolution = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}