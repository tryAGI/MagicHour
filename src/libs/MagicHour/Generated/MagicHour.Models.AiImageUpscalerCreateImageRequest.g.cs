
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AiImageUpscalerCreateImageRequest
    {
        /// <summary>
        /// Give your image a custom name for easy identification.<br/>
        /// Default Value: Image Upscaler - dateTime<br/>
        /// Example: My Image Upscaler image
        /// </summary>
        /// <example>My Image Upscaler image</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// How much to scale the image. Must be either 2 or 4.<br/>
        ///             <br/>
        /// Note: 4x upscale is only available on Creator, Pro, or Business tier.<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("scale_factor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ScaleFactor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.AiImageUpscalerCreateImageRequestStyle Style { get; set; }

        /// <summary>
        /// Provide the assets for upscaling
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.AiImageUpscalerCreateImageRequestAssets Assets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiImageUpscalerCreateImageRequest" /> class.
        /// </summary>
        /// <param name="scaleFactor">
        /// How much to scale the image. Must be either 2 or 4.<br/>
        ///             <br/>
        /// Note: 4x upscale is only available on Creator, Pro, or Business tier.<br/>
        /// Example: 2
        /// </param>
        /// <param name="style"></param>
        /// <param name="assets">
        /// Provide the assets for upscaling
        /// </param>
        /// <param name="name">
        /// Give your image a custom name for easy identification.<br/>
        /// Default Value: Image Upscaler - dateTime<br/>
        /// Example: My Image Upscaler image
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiImageUpscalerCreateImageRequest(
            double scaleFactor,
            global::MagicHour.AiImageUpscalerCreateImageRequestStyle style,
            global::MagicHour.AiImageUpscalerCreateImageRequestAssets assets,
            string? name)
        {
            this.Name = name;
            this.ScaleFactor = scaleFactor;
            this.Style = style ?? throw new global::System.ArgumentNullException(nameof(style));
            this.Assets = assets ?? throw new global::System.ArgumentNullException(nameof(assets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiImageUpscalerCreateImageRequest" /> class.
        /// </summary>
        public AiImageUpscalerCreateImageRequest()
        {
        }

    }
}