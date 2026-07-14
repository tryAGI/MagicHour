#nullable enable

namespace MagicHour
{
    public partial interface IImageProjectsClient
    {
        /// <summary>
        /// AI Image Upscaler<br/>
        /// Upscale your image using AI.<br/>
        /// ### Modes<br/>
        /// - `preserve`: Keeps the image faithful using the v2 pipeline with a 1x credit multiplier.<br/>
        /// - `balanced`: Applies natural improvements using the v1 pipeline with creativity set to 0.2 and a 2x credit multiplier.<br/>
        /// - `creative`: Reimagines details using the v1 pipeline with creativity set to 0.35, accepts `style.prompt`, and has a 2x credit multiplier.<br/>
        /// If `style` or `style.mode` is omitted, the mode defaults to `balanced`.<br/>
        /// ### Costs<br/>
        /// - 2x `preserve`: 25 credits.<br/>
        /// - 2x `balanced` or `creative`: 50 credits.<br/>
        /// - 4x `preserve`: 100 credits.<br/>
        /// - 4x `balanced` or `creative`: 200 credits.<br/>
        /// 4x upscaling is available only on Creator, Pro, or Business plans.<br/>
        /// ### Backward compatibility<br/>
        /// `style.mode: "pro"` is deprecated and maps to `preserve`. `style.enhancement` is also deprecated: `Resemblance` maps to `preserve`, `Balanced` maps to `balanced`, and `Creative` maps to `creative`. `style.mode: "creative"` without `enhancement` resolves to `creative`.
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
        ///   "name": "Upscale",<br/>
        ///   "scale_factor": 2,<br/>
        ///   "style": {<br/>
        ///     "mode": "balanced"<br/>
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
        /// Upscale your image using AI.<br/>
        /// ### Modes<br/>
        /// - `preserve`: Keeps the image faithful using the v2 pipeline with a 1x credit multiplier.<br/>
        /// - `balanced`: Applies natural improvements using the v1 pipeline with creativity set to 0.2 and a 2x credit multiplier.<br/>
        /// - `creative`: Reimagines details using the v1 pipeline with creativity set to 0.35, accepts `style.prompt`, and has a 2x credit multiplier.<br/>
        /// If `style` or `style.mode` is omitted, the mode defaults to `balanced`.<br/>
        /// ### Costs<br/>
        /// - 2x `preserve`: 25 credits.<br/>
        /// - 2x `balanced` or `creative`: 50 credits.<br/>
        /// - 4x `preserve`: 100 credits.<br/>
        /// - 4x `balanced` or `creative`: 200 credits.<br/>
        /// 4x upscaling is available only on Creator, Pro, or Business plans.<br/>
        /// ### Backward compatibility<br/>
        /// `style.mode: "pro"` is deprecated and maps to `preserve`. `style.enhancement` is also deprecated: `Resemblance` maps to `preserve`, `Balanced` maps to `balanced`, and `Creative` maps to `creative`. `style.mode: "creative"` without `enhancement` resolves to `creative`.
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
        ///   "name": "Upscale",<br/>
        ///   "scale_factor": 2,<br/>
        ///   "style": {<br/>
        ///     "mode": "balanced"<br/>
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
        /// Upscale your image using AI.<br/>
        /// ### Modes<br/>
        /// - `preserve`: Keeps the image faithful using the v2 pipeline with a 1x credit multiplier.<br/>
        /// - `balanced`: Applies natural improvements using the v1 pipeline with creativity set to 0.2 and a 2x credit multiplier.<br/>
        /// - `creative`: Reimagines details using the v1 pipeline with creativity set to 0.35, accepts `style.prompt`, and has a 2x credit multiplier.<br/>
        /// If `style` or `style.mode` is omitted, the mode defaults to `balanced`.<br/>
        /// ### Costs<br/>
        /// - 2x `preserve`: 25 credits.<br/>
        /// - 2x `balanced` or `creative`: 50 credits.<br/>
        /// - 4x `preserve`: 100 credits.<br/>
        /// - 4x `balanced` or `creative`: 200 credits.<br/>
        /// 4x upscaling is available only on Creator, Pro, or Business plans.<br/>
        /// ### Backward compatibility<br/>
        /// `style.mode: "pro"` is deprecated and maps to `preserve`. `style.enhancement` is also deprecated: `Resemblance` maps to `preserve`, `Balanced` maps to `balanced`, and `Creative` maps to `creative`. `style.mode: "creative"` without `enhancement` resolves to `creative`.
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
        /// Optional style settings for the upscale. If `style` or `mode` is omitted, `mode` defaults to `balanced`.
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