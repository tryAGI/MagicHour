
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AiImageEditorCreateImageRequest
    {
        /// <summary>
        /// Give your image a custom name for easy identification.<br/>
        /// Default Value: Ai Image Editor - dateTime<br/>
        /// Example: My Ai Image Editor image
        /// </summary>
        /// <example>My Ai Image Editor image</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Number of images to generate. Maximum varies by model. Defaults to 1 if not specified.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_count")]
        public double? ImageCount { get; set; }

        /// <summary>
        /// The AI model to use for image editing. Each model has different capabilities and costs.<br/>
        /// **Models:**<br/>
        /// - `default` - Use the model we recommend, which will change over time. This is recommended unless you need a specific model. This is the default behavior.<br/>
        /// - `flux-2-klein` - from 5 credits/image<br/>
        ///   - Supported resolutions: 640px, 1k, 2k<br/>
        ///   - Available for tiers: free, creator, pro, business<br/>
        ///   - Max additional input images: 5<br/>
        /// - `gpt-image-2` - from 50 credits/image<br/>
        ///   - Supported resolutions: 640px, 1k, 2k, 4k<br/>
        ///   - Available for tiers: creator, pro, business<br/>
        ///   - Max additional input images: 9<br/>
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
        /// - `nano-banana-pro` - from 150 credits/image<br/>
        ///   - Supported resolutions: 1k, 2k, 4k<br/>
        ///   - Available for tiers: creator, pro, business<br/>
        ///   - Max additional input images: 9<br/>
        /// - `qwen-edit` - from 10 credits/image<br/>
        ///   - Supported resolutions: 640px, 1k, 2k<br/>
        ///   - Available for tiers: free, creator, pro, business<br/>
        ///   - Max additional input images: 2<br/>
        /// - `seedream-v4` - from 40 credits/image<br/>
        ///   - Supported resolutions: 640px, 1k, 2k, 4k<br/>
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
        /// Example: default
        /// </summary>
        /// <example>default</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.AiImageEditorCreateImageRequestModelJsonConverter))]
        public global::MagicHour.AiImageEditorCreateImageRequestModel? Model { get; set; }

        /// <summary>
        /// The aspect ratio of the output image(s). If not specified, defaults to `auto`.<br/>
        /// Example: 1:1
        /// </summary>
        /// <example>1:1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.AiImageEditorCreateImageRequestAspectRatioJsonConverter))]
        public global::MagicHour.AiImageEditorCreateImageRequestAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Maximum resolution (longest edge) for the output image.<br/>
        /// **Options:**<br/>
        /// - `640px` — up to 640px<br/>
        /// - `1k` — up to 1024px<br/>
        /// - `2k` — up to 2048px<br/>
        /// - `4k` — up to 4096px<br/>
        /// - `auto` — **Deprecated.** Mapped server-side from your subscription tier to the best matching resolution the model supports<br/>
        /// **Per-model support:**<br/>
        /// - `flux-2-klein` - 640px, 1k, 2k<br/>
        /// - `gpt-image-2` - 640px, 1k, 2k, 4k<br/>
        /// - `nano-banana` - 640px, 1k<br/>
        /// - `nano-banana-2` - 640px, 1k, 2k, 4k<br/>
        /// - `nano-banana-2-lite` - 640px, 1k<br/>
        /// - `nano-banana-pro` - 1k, 2k, 4k<br/>
        /// - `qwen-edit` - 640px, 1k, 2k<br/>
        /// - `seedream-v4` - 640px, 1k, 2k, 4k<br/>
        /// - `seedream-v4.5` - 640px, 1k, 2k, 4k<br/>
        /// - `seedream-v5-pro` - 640px, 1k, 2k<br/>
        /// Note: Resolution availability depends on the model and your subscription tier.<br/>
        /// Example: 1k
        /// </summary>
        /// <example>1k</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.AiImageEditorCreateImageRequestResolutionJsonConverter))]
        public global::MagicHour.AiImageEditorCreateImageRequestResolution? Resolution { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.AiImageEditorCreateImageRequestStyle Style { get; set; }

        /// <summary>
        /// Provide the assets for image edit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.AiImageEditorCreateImageRequestAssets Assets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiImageEditorCreateImageRequest" /> class.
        /// </summary>
        /// <param name="style"></param>
        /// <param name="assets">
        /// Provide the assets for image edit
        /// </param>
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
        /// - `flux-2-klein` - from 5 credits/image<br/>
        ///   - Supported resolutions: 640px, 1k, 2k<br/>
        ///   - Available for tiers: free, creator, pro, business<br/>
        ///   - Max additional input images: 5<br/>
        /// - `gpt-image-2` - from 50 credits/image<br/>
        ///   - Supported resolutions: 640px, 1k, 2k, 4k<br/>
        ///   - Available for tiers: creator, pro, business<br/>
        ///   - Max additional input images: 9<br/>
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
        /// - `nano-banana-pro` - from 150 credits/image<br/>
        ///   - Supported resolutions: 1k, 2k, 4k<br/>
        ///   - Available for tiers: creator, pro, business<br/>
        ///   - Max additional input images: 9<br/>
        /// - `qwen-edit` - from 10 credits/image<br/>
        ///   - Supported resolutions: 640px, 1k, 2k<br/>
        ///   - Available for tiers: free, creator, pro, business<br/>
        ///   - Max additional input images: 2<br/>
        /// - `seedream-v4` - from 40 credits/image<br/>
        ///   - Supported resolutions: 640px, 1k, 2k, 4k<br/>
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
        /// - `flux-2-klein` - 640px, 1k, 2k<br/>
        /// - `gpt-image-2` - 640px, 1k, 2k, 4k<br/>
        /// - `nano-banana` - 640px, 1k<br/>
        /// - `nano-banana-2` - 640px, 1k, 2k, 4k<br/>
        /// - `nano-banana-2-lite` - 640px, 1k<br/>
        /// - `nano-banana-pro` - 1k, 2k, 4k<br/>
        /// - `qwen-edit` - 640px, 1k, 2k<br/>
        /// - `seedream-v4` - 640px, 1k, 2k, 4k<br/>
        /// - `seedream-v4.5` - 640px, 1k, 2k, 4k<br/>
        /// - `seedream-v5-pro` - 640px, 1k, 2k<br/>
        /// Note: Resolution availability depends on the model and your subscription tier.<br/>
        /// Example: 1k
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiImageEditorCreateImageRequest(
            global::MagicHour.AiImageEditorCreateImageRequestStyle style,
            global::MagicHour.AiImageEditorCreateImageRequestAssets assets,
            string? name,
            double? imageCount,
            global::MagicHour.AiImageEditorCreateImageRequestModel? model,
            global::MagicHour.AiImageEditorCreateImageRequestAspectRatio? aspectRatio,
            global::MagicHour.AiImageEditorCreateImageRequestResolution? resolution)
        {
            this.Name = name;
            this.ImageCount = imageCount;
            this.Model = model;
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
            this.Style = style ?? throw new global::System.ArgumentNullException(nameof(style));
            this.Assets = assets ?? throw new global::System.ArgumentNullException(nameof(assets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiImageEditorCreateImageRequest" /> class.
        /// </summary>
        public AiImageEditorCreateImageRequest()
        {
        }

    }
}