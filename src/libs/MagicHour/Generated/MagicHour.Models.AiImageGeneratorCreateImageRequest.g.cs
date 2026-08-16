
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AiImageGeneratorCreateImageRequest
    {
        /// <summary>
        /// Give your image a custom name for easy identification.<br/>
        /// Default Value: Ai Image - dateTime<br/>
        /// Example: My Ai Image image
        /// </summary>
        /// <example>My Ai Image image</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Number of images to generate. Maximum varies by model.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ImageCount { get; set; }

        /// <summary>
        /// The AI model to use for image generation. Each model has different capabilities and costs.<br/>
        /// **Models:**<br/>
        /// - `default` - Use the model we recommend, which will change over time. This is recommended unless you need a specific model. This is the default behavior.<br/>
        /// - `nano-banana-2` - from 100 credits/image<br/>
        ///   - Supported resolutions: 640px, 1k, 2k, 4k<br/>
        ///   - Available for tiers: creator, pro, business<br/>
        ///   - Image count allowed: 1, 4, 9, 16<br/>
        /// - `gpt-image-2` - from 50 credits/image<br/>
        ///   - Supported resolutions: 640px, 1k, 2k, 4k<br/>
        ///   - Available for tiers: creator, pro, business<br/>
        ///   - Image count allowed: 1, 2, 3, 4<br/>
        /// - `z-image-turbo` - from 5 credits/image<br/>
        ///   - Supported resolutions: 640px, 1k, 2k<br/>
        ///   - Available for tiers: free, creator, pro, business<br/>
        ///   - Image count allowed: 1, 2, 3, 4<br/>
        /// - `flux-2-klein` - from 5 credits/image<br/>
        ///   - Supported resolutions: 640px, 1k, 2k<br/>
        ///   - Available for tiers: free, creator, pro, business<br/>
        ///   - Image count allowed: 1<br/>
        /// - `nano-banana-2-lite` - from 50 credits/image<br/>
        ///   - Supported resolutions: 640px, 1k<br/>
        ///   - Available for tiers: creator, pro, business<br/>
        ///   - Image count allowed: 1, 2, 3, 4<br/>
        /// - `seedream-v4` - from 40 credits/image<br/>
        ///   - Supported resolutions: 640px, 1k, 2k, 4k<br/>
        ///   - Available for tiers: creator, pro, business<br/>
        ///   - Image count allowed: 1, 2, 3, 4<br/>
        /// - `seedream-v5-pro` - from 75 credits/image<br/>
        ///   - Supported resolutions: 640px, 1k, 2k<br/>
        ///   - Available for tiers: creator, pro, business<br/>
        ///   - Image count allowed: 1, 2, 3, 4<br/>
        /// - `nano-banana` - from 50 credits/image<br/>
        ///   - Supported resolutions: 640px, 1k<br/>
        ///   - Available for tiers: creator, pro, business<br/>
        ///   - Image count allowed: 1, 2, 3, 4<br/>
        /// - `nano-banana-pro` - from 150 credits/image<br/>
        ///   - Supported resolutions: 1k, 2k, 4k<br/>
        ///   - Available for tiers: creator, pro, business<br/>
        ///   - Image count allowed: 1, 4, 9, 16<br/>
        /// - `flux-schnell` - from 5 credits/image<br/>
        ///   - Supported resolutions: 640px, 1k, 2k<br/>
        ///   - Available for tiers: free, creator, pro, business<br/>
        ///   - Image count allowed: 1, 2, 3, 4<br/>
        /// **Deprecated Enum Values:**<br/>
        /// - `seedream` - Use `seedream-v4` instead.<br/>
        /// Example: default
        /// </summary>
        /// <example>default</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.AiImageGeneratorCreateImageRequestModelJsonConverter))]
        public global::MagicHour.AiImageGeneratorCreateImageRequestModel? Model { get; set; }

        /// <summary>
        /// The aspect ratio of the output image(s). If not specified, defaults to `1:1` (square).<br/>
        /// Example: 1:1
        /// </summary>
        /// <example>1:1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.AiImageGeneratorCreateImageRequestAspectRatioJsonConverter))]
        public global::MagicHour.AiImageGeneratorCreateImageRequestAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Maximum resolution (longest edge) for the output image.<br/>
        /// **Options:**<br/>
        /// - `640px` — up to 640px<br/>
        /// - `1k` — up to 1024px<br/>
        /// - `2k` — up to 2048px<br/>
        /// - `4k` — up to 4096px<br/>
        /// - `auto` — **Deprecated.** Mapped server-side from your subscription tier to the best matching resolution the model supports<br/>
        /// **Per-model support:**<br/>
        /// - `nano-banana-2` - 640px, 1k, 2k, 4k<br/>
        /// - `gpt-image-2` - 640px, 1k, 2k, 4k<br/>
        /// - `z-image-turbo` - 640px, 1k, 2k<br/>
        /// - `flux-2-klein` - 640px, 1k, 2k<br/>
        /// - `nano-banana-2-lite` - 640px, 1k<br/>
        /// - `seedream-v4` - 640px, 1k, 2k, 4k<br/>
        /// - `seedream-v5-pro` - 640px, 1k, 2k<br/>
        /// - `nano-banana` - 640px, 1k<br/>
        /// - `nano-banana-pro` - 1k, 2k, 4k<br/>
        /// - `flux-schnell` - 640px, 1k, 2k<br/>
        /// Note: Resolution availability depends on the model and your subscription tier.<br/>
        /// Default Value: auto<br/>
        /// Example: auto
        /// </summary>
        /// <example>auto</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.AiImageGeneratorCreateImageRequestResolutionJsonConverter))]
        public global::MagicHour.AiImageGeneratorCreateImageRequestResolution? Resolution { get; set; }

        /// <summary>
        /// The art style to use for image generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.AiImageGeneratorCreateImageRequestStyle Style { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiImageGeneratorCreateImageRequest" /> class.
        /// </summary>
        /// <param name="imageCount">
        /// Number of images to generate. Maximum varies by model.<br/>
        /// Example: 1
        /// </param>
        /// <param name="style">
        /// The art style to use for image generation.
        /// </param>
        /// <param name="name">
        /// Give your image a custom name for easy identification.<br/>
        /// Default Value: Ai Image - dateTime<br/>
        /// Example: My Ai Image image
        /// </param>
        /// <param name="model">
        /// The AI model to use for image generation. Each model has different capabilities and costs.<br/>
        /// **Models:**<br/>
        /// - `default` - Use the model we recommend, which will change over time. This is recommended unless you need a specific model. This is the default behavior.<br/>
        /// - `nano-banana-2` - from 100 credits/image<br/>
        ///   - Supported resolutions: 640px, 1k, 2k, 4k<br/>
        ///   - Available for tiers: creator, pro, business<br/>
        ///   - Image count allowed: 1, 4, 9, 16<br/>
        /// - `gpt-image-2` - from 50 credits/image<br/>
        ///   - Supported resolutions: 640px, 1k, 2k, 4k<br/>
        ///   - Available for tiers: creator, pro, business<br/>
        ///   - Image count allowed: 1, 2, 3, 4<br/>
        /// - `z-image-turbo` - from 5 credits/image<br/>
        ///   - Supported resolutions: 640px, 1k, 2k<br/>
        ///   - Available for tiers: free, creator, pro, business<br/>
        ///   - Image count allowed: 1, 2, 3, 4<br/>
        /// - `flux-2-klein` - from 5 credits/image<br/>
        ///   - Supported resolutions: 640px, 1k, 2k<br/>
        ///   - Available for tiers: free, creator, pro, business<br/>
        ///   - Image count allowed: 1<br/>
        /// - `nano-banana-2-lite` - from 50 credits/image<br/>
        ///   - Supported resolutions: 640px, 1k<br/>
        ///   - Available for tiers: creator, pro, business<br/>
        ///   - Image count allowed: 1, 2, 3, 4<br/>
        /// - `seedream-v4` - from 40 credits/image<br/>
        ///   - Supported resolutions: 640px, 1k, 2k, 4k<br/>
        ///   - Available for tiers: creator, pro, business<br/>
        ///   - Image count allowed: 1, 2, 3, 4<br/>
        /// - `seedream-v5-pro` - from 75 credits/image<br/>
        ///   - Supported resolutions: 640px, 1k, 2k<br/>
        ///   - Available for tiers: creator, pro, business<br/>
        ///   - Image count allowed: 1, 2, 3, 4<br/>
        /// - `nano-banana` - from 50 credits/image<br/>
        ///   - Supported resolutions: 640px, 1k<br/>
        ///   - Available for tiers: creator, pro, business<br/>
        ///   - Image count allowed: 1, 2, 3, 4<br/>
        /// - `nano-banana-pro` - from 150 credits/image<br/>
        ///   - Supported resolutions: 1k, 2k, 4k<br/>
        ///   - Available for tiers: creator, pro, business<br/>
        ///   - Image count allowed: 1, 4, 9, 16<br/>
        /// - `flux-schnell` - from 5 credits/image<br/>
        ///   - Supported resolutions: 640px, 1k, 2k<br/>
        ///   - Available for tiers: free, creator, pro, business<br/>
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
        /// - `nano-banana-2` - 640px, 1k, 2k, 4k<br/>
        /// - `gpt-image-2` - 640px, 1k, 2k, 4k<br/>
        /// - `z-image-turbo` - 640px, 1k, 2k<br/>
        /// - `flux-2-klein` - 640px, 1k, 2k<br/>
        /// - `nano-banana-2-lite` - 640px, 1k<br/>
        /// - `seedream-v4` - 640px, 1k, 2k, 4k<br/>
        /// - `seedream-v5-pro` - 640px, 1k, 2k<br/>
        /// - `nano-banana` - 640px, 1k<br/>
        /// - `nano-banana-pro` - 1k, 2k, 4k<br/>
        /// - `flux-schnell` - 640px, 1k, 2k<br/>
        /// Note: Resolution availability depends on the model and your subscription tier.<br/>
        /// Default Value: auto<br/>
        /// Example: auto
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiImageGeneratorCreateImageRequest(
            int imageCount,
            global::MagicHour.AiImageGeneratorCreateImageRequestStyle style,
            string? name,
            global::MagicHour.AiImageGeneratorCreateImageRequestModel? model,
            global::MagicHour.AiImageGeneratorCreateImageRequestAspectRatio? aspectRatio,
            global::MagicHour.AiImageGeneratorCreateImageRequestResolution? resolution)
        {
            this.Name = name;
            this.ImageCount = imageCount;
            this.Model = model;
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
            this.Style = style ?? throw new global::System.ArgumentNullException(nameof(style));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiImageGeneratorCreateImageRequest" /> class.
        /// </summary>
        public AiImageGeneratorCreateImageRequest()
        {
        }

    }
}