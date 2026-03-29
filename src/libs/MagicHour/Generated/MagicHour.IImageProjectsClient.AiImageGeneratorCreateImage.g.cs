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
        /// - `flux-schnell` - 5 credits/image<br/>
        ///   - Supported resolutions: auto<br/>
        ///   - Available for tiers: free, creator, pro, business<br/>
        ///   - Image count allowed: 1, 2, 3, 4<br/>
        /// - `z-image-turbo` - 5 credits/image<br/>
        ///   - Supported resolutions: auto, 2k<br/>
        ///   - Available for tiers: free, creator, pro, business<br/>
        ///   - Image count allowed: 1, 2, 3, 4<br/>
        /// - `seedream` - 30 credits/image<br/>
        ///   - Supported resolutions: auto, 2k, 4k<br/>
        ///   - Available for tiers: free, creator, pro, business<br/>
        ///   - Image count allowed: 1, 2, 3, 4<br/>
        /// - `nano-banana` - 50 credits/image<br/>
        ///   - Supported resolutions: auto<br/>
        ///   - Available for tiers: free, creator, pro, business<br/>
        ///   - Image count allowed: 1, 2, 3, 4<br/>
        /// - `nano-banana-2` - 100 credits/image<br/>
        ///   - Supported resolutions: auto, 2k, 4k<br/>
        ///   - Available for tiers: free, creator, pro, business<br/>
        ///   - Image count allowed: 1, 2, 3, 4<br/>
        /// - `nano-banana-pro` - 150 credits/image<br/>
        ///   - Supported resolutions: auto, 2k, 4k<br/>
        ///   - Available for tiers: creator, pro, business<br/>
        ///   - Image count allowed: 1, 4, 9, 16<br/>
        /// Example: default
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio of the output image(s). If not specified, defaults to `1:1` (square).<br/>
        /// Example: 1:1
        /// </param>
        /// <param name="resolution">
        /// Maximum resolution for the generated image.<br/>
        /// **Options:**<br/>
        /// - `auto` - Automatic resolution (all tiers, default)<br/>
        /// - `2k` - Up to 2048px (requires Pro or Business tier)<br/>
        /// - `4k` - Up to 4096px (requires Business tier)<br/>
        /// Note: Resolution availability depends on the model and your subscription tier. See `model` field for which resolutions each model supports. Defaults to `auto` if not specified.<br/>
        /// Default Value: auto<br/>
        /// Example: auto
        /// </param>
        /// <param name="style">
        /// The art style to use for image generation.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MagicHour.AiImageGeneratorCreateImageResponse> AiImageGeneratorCreateImageAsync(
            int imageCount,
            global::MagicHour.AiImageGeneratorCreateImageRequestStyle style,
            string? name = default,
            global::MagicHour.AiImageGeneratorCreateImageRequestModel? model = default,
            global::MagicHour.AiImageGeneratorCreateImageRequestAspectRatio? aspectRatio = default,
            global::MagicHour.AiImageGeneratorCreateImageRequestResolution? resolution = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}