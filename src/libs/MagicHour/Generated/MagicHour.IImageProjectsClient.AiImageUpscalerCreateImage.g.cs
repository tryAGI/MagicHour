#nullable enable

namespace MagicHour
{
    public partial interface IImageProjectsClient
    {
        /// <summary>
        /// AI Image Upscaler<br/>
        /// Upscale your image using AI. Each 2x upscale costs 50 credits for balanced/creative modes, and 25 credits for preserve. 4x upscale costs 200 and 100 credits respectively.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/ai-image-upscaler \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header 'authorization: Bearer &lt;token&gt;' \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Image Upscaler image",<br/>
        ///   "scale_factor": 2,<br/>
        ///   "style": {<br/>
        ///     "enhancement": "Resemblance",<br/>
        ///     "prompt": "string"<br/>
        ///   },<br/>
        ///   "assets": {<br/>
        ///     "image_file_path": "api-assets/id/1234.png"<br/>
        ///   }<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.AiImageUpscalerCreateImageResponse> AiImageUpscalerCreateImageAsync(

            global::MagicHour.AiImageUpscalerCreateImageRequest request,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// AI Image Upscaler<br/>
        /// Upscale your image using AI. Each 2x upscale costs 50 credits for balanced/creative modes, and 25 credits for preserve. 4x upscale costs 200 and 100 credits respectively.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/ai-image-upscaler \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header 'authorization: Bearer &lt;token&gt;' \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Image Upscaler image",<br/>
        ///   "scale_factor": 2,<br/>
        ///   "style": {<br/>
        ///     "enhancement": "Resemblance",<br/>
        ///     "prompt": "string"<br/>
        ///   },<br/>
        ///   "assets": {<br/>
        ///     "image_file_path": "api-assets/id/1234.png"<br/>
        ///   }<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.AutoSDKHttpResponse<global::MagicHour.AiImageUpscalerCreateImageResponse>> AiImageUpscalerCreateImageAsResponseAsync(

            global::MagicHour.AiImageUpscalerCreateImageRequest request,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// AI Image Upscaler<br/>
        /// Upscale your image using AI. Each 2x upscale costs 50 credits for balanced/creative modes, and 25 credits for preserve. 4x upscale costs 200 and 100 credits respectively.
        /// </summary>
        /// <param name="name">
        /// Give your image a custom name for easy identification.<br/>
        /// Default Value: Image Upscaler - dateTime<br/>
        /// Example: My Image Upscaler image
        /// </param>
        /// <param name="scaleFactor">
        /// How much to scale the image. Must be either 2 or 4.<br/>
        ///             <br/>
        /// Note: 4x upscale is only available on Creator, Pro, or Business tier.<br/>
        /// Example: 2
        /// </param>
        /// <param name="style">
        /// Style settings for the upscale. Use `mode` (`"preserve"`, `"balanced"`, or `"creative"`). Defaults to `"balanced"`.<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="assets">
        /// Provide the assets for upscaling
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MagicHour.AiImageUpscalerCreateImageResponse> AiImageUpscalerCreateImageAsync(
            double scaleFactor,
            global::MagicHour.AiImageUpscalerCreateImageRequestAssets assets,
            string? name = default,
            global::MagicHour.AiImageUpscalerCreateImageRequestStyle? style = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}