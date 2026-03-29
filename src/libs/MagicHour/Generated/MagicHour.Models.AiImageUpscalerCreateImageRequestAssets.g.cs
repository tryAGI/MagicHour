
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Provide the assets for upscaling
    /// </summary>
    public sealed partial class AiImageUpscalerCreateImageRequestAssets
    {
        /// <summary>
        /// The image to upscale. This value is either<br/>
        /// - a direct URL to the video file<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// . The maximum input image size is 4096x4096px.<br/>
        /// Example: api-assets/id/1234.png
        /// </summary>
        /// <example>api-assets/id/1234.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_file_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageFilePath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiImageUpscalerCreateImageRequestAssets" /> class.
        /// </summary>
        /// <param name="imageFilePath">
        /// The image to upscale. This value is either<br/>
        /// - a direct URL to the video file<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// . The maximum input image size is 4096x4096px.<br/>
        /// Example: api-assets/id/1234.png
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiImageUpscalerCreateImageRequestAssets(
            string imageFilePath)
        {
            this.ImageFilePath = imageFilePath ?? throw new global::System.ArgumentNullException(nameof(imageFilePath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiImageUpscalerCreateImageRequestAssets" /> class.
        /// </summary>
        public AiImageUpscalerCreateImageRequestAssets()
        {
        }
    }
}