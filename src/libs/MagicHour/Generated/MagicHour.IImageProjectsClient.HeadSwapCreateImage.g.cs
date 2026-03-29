#nullable enable

namespace MagicHour
{
    public partial interface IImageProjectsClient
    {
        /// <summary>
        /// Head Swap<br/>
        /// Swap a head onto a body image. Each image costs 10 credits. Output resolution depends on your subscription; you may set `max_resolution` lower than your plan maximum if desired.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/head-swap \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header 'authorization: Bearer &lt;token&gt;' \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Head Swap image",<br/>
        ///   "max_resolution": 1024,<br/>
        ///   "assets": {<br/>
        ///     "body_file_path": "api-assets/id/1234.png",<br/>
        ///     "head_file_path": "api-assets/id/5678.png"<br/>
        ///   }<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.HeadSwapCreateImageResponse> HeadSwapCreateImageAsync(

            global::MagicHour.HeadSwapCreateImageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Head Swap<br/>
        /// Swap a head onto a body image. Each image costs 10 credits. Output resolution depends on your subscription; you may set `max_resolution` lower than your plan maximum if desired.
        /// </summary>
        /// <param name="name">
        /// Give your image a custom name for easy identification.<br/>
        /// Default Value: Head Swap - dateTime<br/>
        /// Example: My Head Swap image
        /// </param>
        /// <param name="maxResolution">
        /// Constrains the larger dimension (height or width) of the output. Omit to use the maximum allowed for your plan (capped at 2048px). Values above your plan maximum are clamped down to your plan's maximum.<br/>
        /// Example: 1024
        /// </param>
        /// <param name="assets">
        /// Provide the body and head images for head swap
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MagicHour.HeadSwapCreateImageResponse> HeadSwapCreateImageAsync(
            global::MagicHour.HeadSwapCreateImageRequestAssets assets,
            string? name = default,
            int? maxResolution = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}