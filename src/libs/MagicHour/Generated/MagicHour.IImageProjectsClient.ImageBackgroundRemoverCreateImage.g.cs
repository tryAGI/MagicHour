#nullable enable

namespace MagicHour
{
    public partial interface IImageProjectsClient
    {
        /// <summary>
        /// Image Background Remover<br/>
        /// Remove background from image. Each image costs 5 credits.
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
        ///      --url https://api.magichour.ai/v1/image-background-remover \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header "authorization: Bearer $MAGIC_HOUR_API_KEY" \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Background Remover image",<br/>
        ///   "assets": {<br/>
        ///     "image_file_path": "api-assets/id/1234.png",<br/>
        ///     "background_image_file_path": "api-assets/id/1234.png"<br/>
        ///   }<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.ImageBackgroundRemoverCreateImageResponse> ImageBackgroundRemoverCreateImageAsync(

            global::MagicHour.ImageBackgroundRemoverCreateImageRequest request,
            string? idempotencyKey = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Image Background Remover<br/>
        /// Remove background from image. Each image costs 5 credits.
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
        ///      --url https://api.magichour.ai/v1/image-background-remover \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header "authorization: Bearer $MAGIC_HOUR_API_KEY" \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Background Remover image",<br/>
        ///   "assets": {<br/>
        ///     "image_file_path": "api-assets/id/1234.png",<br/>
        ///     "background_image_file_path": "api-assets/id/1234.png"<br/>
        ///   }<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.AutoSDKHttpResponse<global::MagicHour.ImageBackgroundRemoverCreateImageResponse>> ImageBackgroundRemoverCreateImageAsResponseAsync(

            global::MagicHour.ImageBackgroundRemoverCreateImageRequest request,
            string? idempotencyKey = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Image Background Remover<br/>
        /// Remove background from image. Each image costs 5 credits.
        /// </summary>
        /// <param name="idempotencyKey">
        /// A unique string for this request, such as a UUID. Sending the same key again within 24 hours returns the original project instead of creating and charging for a new one. A key applies across all video, image, and audio endpoints on your account, so use a new key for every project.<br/>
        /// Example: 5f3c1b9e-8a41-4a0e-9d3e-2f6a1c7b9e10
        /// </param>
        /// <param name="name">
        /// Give your image a custom name for easy identification.<br/>
        /// Default Value: Background Remover - dateTime<br/>
        /// Example: My Background Remover image
        /// </param>
        /// <param name="assets">
        /// Provide the assets for background removal
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MagicHour.ImageBackgroundRemoverCreateImageResponse> ImageBackgroundRemoverCreateImageAsync(
            global::MagicHour.ImageBackgroundRemoverCreateImageRequestAssets assets,
            string? idempotencyKey = default,
            string? name = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}