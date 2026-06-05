#nullable enable

namespace MagicHour
{
    public partial interface IImageProjectsClient
    {
        /// <summary>
        /// AI Image Generator<br/>
        /// Create an AI image with advanced model selection and quality controls.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/ai-image-generator \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header 'authorization: Bearer &lt;token&gt;' \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Ai Image image",<br/>
        ///   "image_count": 1,<br/>
        ///   "model": "default",<br/>
        ///   "aspect_ratio": "1:1",<br/>
        ///   "resolution": "auto",<br/>
        ///   "style": {<br/>
        ///     "prompt": "Cool image",<br/>
        ///     "tool": "ai-anime-generator"<br/>
        ///   }<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.AiImageGeneratorCreateImageResponse> AiImageGeneratorCreateImageAsync(

            global::MagicHour.AiImageGeneratorCreateImageRequest request,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// AI Image Generator<br/>
        /// Create an AI image with advanced model selection and quality controls.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/ai-image-generator \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header 'authorization: Bearer &lt;token&gt;' \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Ai Image image",<br/>
        ///   "image_count": 1,<br/>
        ///   "model": "default",<br/>
        ///   "aspect_ratio": "1:1",<br/>
        ///   "resolution": "auto",<br/>
        ///   "style": {<br/>
        ///     "prompt": "Cool image",<br/>
        ///     "tool": "ai-anime-generator"<br/>
        ///   }<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.AutoSDKHttpResponse<global::MagicHour.AiImageGeneratorCreateImageResponse>> AiImageGeneratorCreateImageAsResponseAsync(

            global::MagicHour.AiImageGeneratorCreateImageRequest request,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// AI Image Generator<br/>
        /// Create an AI image with advanced model selection and quality controls.
        /// </summary>
        /// <param name="name">
        /// Give your image a custom name for easy identification.<br/>
        /// Default Value: Ai Image - dateTime<br/>
        /// Example: My Ai Image image
        /// </param>
        /// <param name="imageCount">
        /// Number of images to generate. Maximum varies by model.<br/>
        /// Example: 1
        /// </param>
        /// <param name="model">
        /// The AI model to use for image generation. Each model has different capabilities and costs.<br/>
        /// **Models:**<br/>
        /// - `default` - Use the model we recommend, which will change over time. This is recommended unless you need a specific model. This is the default behavior.<br/>
        /// - `flux-schnell` - from 5 credits/image<br/>
        ///   - Supported resolutions: 640px, 1k, 2k<br/>
        ///   - Available for tiers: free, creator, pro, business<br/>
        ///   - Image count allowed: 1, 2, 3, 4<br/>
        /// - `flux-2-klein` - from 5 credits/image<br/>
        ///   - Supported resolutions: 640px, 1k, 2k<br/>
        ///   - Available for tiers: free, creator, pro, business<br/>
        ///   - Image count allowed: 1<br/>
        /// - `z-image-turbo` - from 5 credits/image<br/>
        ///   - Supported resolutions: 640px, 1k, 2k<br/>
        ///   - Available for tiers: free, creator, pro, business<br/>
        ///   - Image count allowed: 1, 2, 3, 4<br/>
        /// - `seedream-v4` - from 40 credits/image<br/>
        ///   - Supported resolutions: 640px, 1k, 2k, 4k<br/>
        ///   - Available for tiers: creator, pro, business<br/>
        ///   - Image count allowed: 1, 2, 3, 4<br/>
        /// - `nano-banana` - from 50 credits/image<br/>
        ///   - Supported resolutions: 640px, 1k<br/>
        ///   - Available for tiers: creator, pro, business<br/>
        ///   - Image count allowed: 1, 2, 3, 4<br/>
        /// - `nano-banana-2` - from 100 credits/image<br/>
        ///   - Supported resolutions: 640px, 1k, 2k, 4k<br/>
        ///   - Available for tiers: creator, pro, business<br/>
        ///   - Image count allowed: 1, 4, 9, 16<br/>
        /// - `nano-banana-pro` - from 150 credits/image<br/>
        ///   - Supported resolutions: 1k, 2k, 4k<br/>
        ///   - Available for tiers: creator, pro, business<br/>
        ///   - Image count allowed: 1, 4, 9, 16<br/>
        /// - `gpt-image-2` - from 50 credits/image<br/>
        ///   - Supported resolutions: 640px, 1k, 2k, 4k<br/>
        ///   - Available for tiers: creator, pro, business<br/>
        ///   - Image count allowed: 1, 2, 3, 4<br/>
        /// **Deprecated Enum Values:**<br/>
        /// - `seedream` - Use `seedream-v4` instead.<br/>
        /// Example: default
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio of the output image(s). If not specified, defaults to `1:1` (square).<br/>
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
        /// - `flux-schnell` - 640px, 1k, 2k<br/>
        /// - `flux-2-klein` - 640px, 1k, 2k<br/>
        /// - `z-image-turbo` - 640px, 1k, 2k<br/>
        /// - `seedream-v4` - 640px, 1k, 2k, 4k<br/>
        /// - `nano-banana` - 640px, 1k<br/>
        /// - `nano-banana-2` - 640px, 1k, 2k, 4k<br/>
        /// - `nano-banana-pro` - 1k, 2k, 4k<br/>
        /// - `gpt-image-2` - 640px, 1k, 2k, 4k<br/>
        /// Note: Resolution availability depends on the model and your subscription tier.<br/>
        /// Default Value: auto<br/>
        /// Example: auto
        /// </param>
        /// <param name="style">
        /// The art style to use for image generation.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MagicHour.AiImageGeneratorCreateImageResponse> AiImageGeneratorCreateImageAsync(
            int imageCount,
            global::MagicHour.AiImageGeneratorCreateImageRequestStyle style,
            string? name = default,
            global::MagicHour.AiImageGeneratorCreateImageRequestModel? model = default,
            global::MagicHour.AiImageGeneratorCreateImageRequestAspectRatio? aspectRatio = default,
            global::MagicHour.AiImageGeneratorCreateImageRequestResolution? resolution = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}