#nullable enable

namespace MagicHour
{
    public partial interface IImageProjectsClient
    {
        /// <summary>
        /// Face Swap Photo<br/>
        /// Create a face swap photo. Each photo costs 10 credits. The height/width of the output image depends on your subscription. Please refer to our [pricing](https://magichour.ai/pricing) page for more details
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/face-swap-photo \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header 'authorization: Bearer &lt;token&gt;' \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Face Swap image",<br/>
        ///   "assets": {<br/>
        ///     "face_swap_mode": "all-faces",<br/>
        ///     "source_file_path": "api-assets/id/1234.png",<br/>
        ///     "face_mappings": [<br/>
        ///       {<br/>
        ///         "original_face": "api-assets/id/0-0.png",<br/>
        ///         "new_face": "api-assets/id/1234.png"<br/>
        ///       }<br/>
        ///     ],<br/>
        ///     "target_file_path": "api-assets/id/1234.png"<br/>
        ///   }<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.FaceSwapPhotoCreateImageResponse> FaceSwapPhotoCreateImageAsync(

            global::MagicHour.FaceSwapPhotoCreateImageRequest request,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Face Swap Photo<br/>
        /// Create a face swap photo. Each photo costs 10 credits. The height/width of the output image depends on your subscription. Please refer to our [pricing](https://magichour.ai/pricing) page for more details
        /// </summary>
        /// <param name="name">
        /// Give your image a custom name for easy identification.<br/>
        /// Default Value: Face Swap - dateTime<br/>
        /// Example: My Face Swap image
        /// </param>
        /// <param name="assets">
        /// Provide the assets for face swap photo
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MagicHour.FaceSwapPhotoCreateImageResponse> FaceSwapPhotoCreateImageAsync(
            global::MagicHour.FaceSwapPhotoCreateImageRequestAssets assets,
            string? name = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}