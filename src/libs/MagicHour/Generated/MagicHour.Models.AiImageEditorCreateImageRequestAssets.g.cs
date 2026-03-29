
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Provide the assets for image edit
    /// </summary>
    public sealed partial class AiImageEditorCreateImageRequestAssets
    {
        /// <summary>
        /// The image(s) used in the edit, maximum of 10 images. This value is either<br/>
        /// - a direct URL to the video file<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// Example: [api-assets/id/1234.png, api-assets/id/1235.png]
        /// </summary>
        /// <example>[api-assets/id/1234.png, api-assets/id/1235.png]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_file_paths")]
        public global::System.Collections.Generic.IList<string>? ImageFilePaths { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiImageEditorCreateImageRequestAssets" /> class.
        /// </summary>
        /// <param name="imageFilePaths">
        /// The image(s) used in the edit, maximum of 10 images. This value is either<br/>
        /// - a direct URL to the video file<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// Example: [api-assets/id/1234.png, api-assets/id/1235.png]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiImageEditorCreateImageRequestAssets(
            global::System.Collections.Generic.IList<string>? imageFilePaths)
        {
            this.ImageFilePaths = imageFilePaths;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiImageEditorCreateImageRequestAssets" /> class.
        /// </summary>
        public AiImageEditorCreateImageRequestAssets()
        {
        }
    }
}