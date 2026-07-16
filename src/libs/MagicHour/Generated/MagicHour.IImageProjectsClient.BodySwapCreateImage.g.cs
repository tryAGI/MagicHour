#nullable enable

namespace MagicHour
{
    public partial interface IImageProjectsClient
    {
        /// <summary>
        /// Body Swap<br/>
        /// Swap a person into a scene image using Nano Banana 2. Credits depend on `resolution` (from 50 credits at 640px upward).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/body-swap \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header 'authorization: Bearer &lt;token&gt;' \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Body Swap image",<br/>
        ///   "resolution": "1k",<br/>
        ///   "assets": {<br/>
        ///     "person_file_path": "api-assets/id/1234.png",<br/>
        ///     "scene_file_path": "api-assets/id/5678.png"<br/>
        ///   }<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.BodySwapCreateImageResponse> BodySwapCreateImageAsync(

            global::MagicHour.BodySwapCreateImageRequest request,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Body Swap<br/>
        /// Swap a person into a scene image using Nano Banana 2. Credits depend on `resolution` (from 50 credits at 640px upward).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/body-swap \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header 'authorization: Bearer &lt;token&gt;' \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Body Swap image",<br/>
        ///   "resolution": "1k",<br/>
        ///   "assets": {<br/>
        ///     "person_file_path": "api-assets/id/1234.png",<br/>
        ///     "scene_file_path": "api-assets/id/5678.png"<br/>
        ///   }<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.AutoSDKHttpResponse<global::MagicHour.BodySwapCreateImageResponse>> BodySwapCreateImageAsResponseAsync(

            global::MagicHour.BodySwapCreateImageRequest request,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Body Swap<br/>
        /// Swap a person into a scene image using Nano Banana 2. Credits depend on `resolution` (from 50 credits at 640px upward).
        /// </summary>
        /// <param name="name">
        /// Give your image a custom name for easy identification.<br/>
        /// Default Value: Body Swap - dateTime<br/>
        /// Example: My Body Swap image
        /// </param>
        /// <param name="resolution">
        /// Output resolution. Determines credits charged for the run.<br/>
        /// Example: 1k
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
            string? name = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}