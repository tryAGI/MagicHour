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
        ///   "resolution": "auto",<br/>
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
        /// - `qwen-edit` - 10 credits/image<br/>
        ///   - Available for tiers: free, creator, pro, business<br/>
        ///   - Image count allowed: 1<br/>
        ///   - Max additional input images: 2<br/>
        /// - `nano-banana` - 50 credits/image<br/>
        ///   - Available for tiers: free, creator, pro, business<br/>
        ///   - Image count allowed: 1<br/>
        ///   - Max additional input images: 9<br/>
        /// - `nano-banana-2` - 100 credits/image<br/>
        ///   - Available for tiers: free, creator, pro, business<br/>
        ///   - Image count allowed: 1<br/>
        ///   - Max additional input images: 9<br/>
        /// - `seedream-v4` - 50 credits/image<br/>
        ///   - Available for tiers: free, creator, pro, business<br/>
        ///   - Image count allowed: 1<br/>
        ///   - Max additional input images: 9<br/>
        /// - `nano-banana-pro` - 150 credits/image<br/>
        ///   - Available for tiers: creator, pro, business<br/>
        ///   - Image count allowed: 1, 4, 9, 16<br/>
        ///   - Max additional input images: 9<br/>
        /// - `seedream-v4.5` - 100 credits/image<br/>
        ///   - Available for tiers: creator, pro, business<br/>
        ///   - Image count allowed: 1<br/>
        ///   - Max additional input images: 9<br/>
        /// Example: default
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio of the output image(s). If not specified, defaults to `auto`.<br/>
        /// Example: 1:1
        /// </param>
        /// <param name="resolution">
        /// Maximum resolution for the generated image.<br/>
        /// **Options:**<br/>
        /// - `auto` - Automatic resolution (all tiers, default)<br/>
        /// - `2k` - Up to 2048px (requires Pro or Business tier)<br/>
        /// - `4k` - Up to 4096px (requires Business tier)<br/>
        /// Note: Resolution availability depends on your subscription tier. Defaults to `auto` if not specified.<br/>
        /// Example: auto
        /// </param>
        /// <param name="style"></param>
        /// <param name="assets">
        /// Provide the assets for image edit
        /// </param>
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
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}