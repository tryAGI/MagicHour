#nullable enable

namespace MagicHour
{
    public partial interface IImageProjectsClient
    {
        /// <summary>
        /// AI Image Editor<br/>
        /// Edit images with AI.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/ai-image-editor \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header 'authorization: Bearer &lt;token&gt;' \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Ai Image Editor image",<br/>
        ///   "image_count": 1,<br/>
        ///   "model": "default",<br/>
        ///   "aspect_ratio": "1:1",<br/>
        ///   "resolution": "1k",<br/>
        ///   "style": {<br/>
        ///     "prompt": "Give me sunglasses"<br/>
        ///   },<br/>
        ///   "assets": {<br/>
        ///     "image_file_paths": [<br/>
        ///       "api-assets/id/1234.png",<br/>
        ///       "api-assets/id/1235.png"<br/>
        ///     ]<br/>
        ///   }<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.AiImageEditorCreateImageResponse> AiImageEditorCreateImageAsync(

            global::MagicHour.AiImageEditorCreateImageRequest request,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// AI Image Editor<br/>
        /// Edit images with AI.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/ai-image-editor \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header 'authorization: Bearer &lt;token&gt;' \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Ai Image Editor image",<br/>
        ///   "image_count": 1,<br/>
        ///   "model": "default",<br/>
        ///   "aspect_ratio": "1:1",<br/>
        ///   "resolution": "1k",<br/>
        ///   "style": {<br/>
        ///     "prompt": "Give me sunglasses"<br/>
        ///   },<br/>
        ///   "assets": {<br/>
        ///     "image_file_paths": [<br/>
        ///       "api-assets/id/1234.png",<br/>
        ///       "api-assets/id/1235.png"<br/>
        ///     ]<br/>
        ///   }<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.AutoSDKHttpResponse<global::MagicHour.AiImageEditorCreateImageResponse>> AiImageEditorCreateImageAsResponseAsync(

            global::MagicHour.AiImageEditorCreateImageRequest request,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// AI Image Editor<br/>
        /// Edit images with AI.
        /// </summary>
        /// <param name="name">
        /// Give your image a custom name for easy identification.<br/>
        /// Default Value: Ai Image Editor - dateTime<br/>
        /// Example: My Ai Image Editor image
        /// </param>
        /// <param name="imageCount">
        /// Number of images to generate. Maximum varies by model. Defaults to 1 if not specified.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="model">
        /// The AI model to use for image editing. Each model has different capabilities and costs.<br/>
        /// **Models:**<br/>
        /// - `default` - Use the model we recommend, which will change over time. This is recommended unless you need a specific model. This is the default behavior.<br/>
        /// - `qwen-edit` - from 10 credits/image<br/>
        ///   - Supported resolutions: 640px, 1k, 2k<br/>
        ///   - Available for tiers: free, creator, pro, business<br/>
        ///   - Max additional input images: 2<br/>
        /// - `flux-2-klein` - from 5 credits/image<br/>
        ///   - Supported resolutions: 640px, 1k, 2k<br/>
        ///   - Available for tiers: free, creator, pro, business<br/>
        ///   - Max additional input images: 5<br/>
        /// - `nano-banana` - from 50 credits/image<br/>
        ///   - Supported resolutions: 640px, 1k<br/>
        ///   - Available for tiers: creator, pro, business<br/>
        ///   - Max additional input images: 9<br/>
        /// - `nano-banana-2` - from 100 credits/image<br/>
        ///   - Supported resolutions: 640px, 1k, 2k, 4k<br/>
        ///   - Available for tiers: creator, pro, business<br/>
        ///   - Max additional input images: 9<br/>
        /// - `nano-banana-2-lite` - from 50 credits/image<br/>
        ///   - Supported resolutions: 640px, 1k<br/>
        ///   - Available for tiers: creator, pro, business<br/>
        ///   - Max additional input images: 9<br/>
        /// - `seedream-v4` - from 40 credits/image<br/>
        ///   - Supported resolutions: 640px, 1k, 2k, 4k<br/>
        ///   - Available for tiers: creator, pro, business<br/>
        ///   - Max additional input images: 9<br/>
        /// - `nano-banana-pro` - from 150 credits/image<br/>
        ///   - Supported resolutions: 1k, 2k, 4k<br/>
        ///   - Available for tiers: creator, pro, business<br/>
        ///   - Max additional input images: 9<br/>
        /// - `seedream-v4.5` - from 50 credits/image<br/>
        ///   - Supported resolutions: 640px, 1k, 2k, 4k<br/>
        ///   - Available for tiers: creator, pro, business<br/>
        ///   - Max additional input images: 9<br/>
        /// - `seedream-v5-pro` - from 75 credits/image<br/>
        ///   - Supported resolutions: 640px, 1k, 2k<br/>
        ///   - Available for tiers: creator, pro, business<br/>
        ///   - Max additional input images: 9<br/>
        /// - `gpt-image-2` - from 50 credits/image<br/>
        ///   - Supported resolutions: 640px, 1k, 2k, 4k<br/>
        ///   - Available for tiers: creator, pro, business<br/>
        ///   - Max additional input images: 9<br/>
        /// Example: default
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio of the output image(s). If not specified, defaults to `auto`.<br/>
        /// Example: 1:1
        /// </param>
        /// <param name="resolution">
        /// Maximum resolution (longest edge) for the output image.<br/>
        /// **Options:**<br/>
        /// - `640px` — up to 640px<br/>
        /// - `1k` — up to 1024px<br/>
        /// - `2k` — up to 2048px<br/>
        /// - `4k` — up to 4096px<br/>
        /// - `auto` — **Deprecated.** Mapped server-side from your subscription tier to the best matching resolution the model supports<br/>
        /// **Per-model support:**<br/>
        /// - `qwen-edit` - 640px, 1k, 2k<br/>
        /// - `flux-2-klein` - 640px, 1k, 2k<br/>
        /// - `nano-banana` - 640px, 1k<br/>
        /// - `nano-banana-2` - 640px, 1k, 2k, 4k<br/>
        /// - `nano-banana-2-lite` - 640px, 1k<br/>
        /// - `seedream-v4` - 640px, 1k, 2k, 4k<br/>
        /// - `nano-banana-pro` - 1k, 2k, 4k<br/>
        /// - `seedream-v4.5` - 640px, 1k, 2k, 4k<br/>
        /// - `seedream-v5-pro` - 640px, 1k, 2k<br/>
        /// - `gpt-image-2` - 640px, 1k, 2k, 4k<br/>
        /// Note: Resolution availability depends on the model and your subscription tier.<br/>
        /// Example: 1k
        /// </param>
        /// <param name="style"></param>
        /// <param name="assets">
        /// Provide the assets for image edit
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MagicHour.AiImageEditorCreateImageResponse> AiImageEditorCreateImageAsync(
            global::MagicHour.AiImageEditorCreateImageRequestStyle style,
            global::MagicHour.AiImageEditorCreateImageRequestAssets assets,
            string? name = default,
            double? imageCount = default,
            global::MagicHour.AiImageEditorCreateImageRequestModel? model = default,
            global::MagicHour.AiImageEditorCreateImageRequestAspectRatio? aspectRatio = default,
            global::MagicHour.AiImageEditorCreateImageRequestResolution? resolution = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}