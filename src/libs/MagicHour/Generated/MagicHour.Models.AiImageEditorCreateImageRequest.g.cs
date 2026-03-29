
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
        /// Maximum resolution for the generated image.<br/>
        /// **Options:**<br/>
        /// - `auto` - Automatic resolution (all tiers, default)<br/>
        /// - `2k` - Up to 2048px (requires Pro or Business tier)<br/>
        /// - `4k` - Up to 4096px (requires Business tier)<br/>
        /// Note: Resolution availability depends on your subscription tier. Defaults to `auto` if not specified.<br/>
        /// Example: auto
        /// </summary>
        /// <example>auto</example>
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