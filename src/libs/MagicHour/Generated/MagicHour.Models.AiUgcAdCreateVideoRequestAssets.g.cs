
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AiUgcAdCreateVideoRequestAssets
    {
        /// <summary>
        /// Prepared image to animate. This value is either<br/>
        /// - a direct URL to the video file<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// Example: api-assets/id/image.jpg
        /// </summary>
        /// <example>api-assets/id/image.jpg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_file_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageFilePath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiUgcAdCreateVideoRequestAssets" /> class.
        /// </summary>
        /// <param name="imageFilePath">
        /// Prepared image to animate. This value is either<br/>
        /// - a direct URL to the video file<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// Example: api-assets/id/image.jpg
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiUgcAdCreateVideoRequestAssets(
            string imageFilePath)
        {
            this.ImageFilePath = imageFilePath ?? throw new global::System.ArgumentNullException(nameof(imageFilePath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiUgcAdCreateVideoRequestAssets" /> class.
        /// </summary>
        public AiUgcAdCreateVideoRequestAssets()
        {
        }

    }
}