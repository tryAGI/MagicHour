
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Provide the body and head images for head swap
    /// </summary>
    public sealed partial class HeadSwapCreateImageRequestAssets
    {
        /// <summary>
        /// Image that receives the swapped head. This value is either<br/>
        /// - a direct URL to the video file<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// Example: api-assets/id/1234.png
        /// </summary>
        /// <example>api-assets/id/1234.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("body_file_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BodyFilePath { get; set; }

        /// <summary>
        /// Image of the head to place on the body. This value is either<br/>
        /// - a direct URL to the video file<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// Example: api-assets/id/5678.png
        /// </summary>
        /// <example>api-assets/id/5678.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("head_file_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HeadFilePath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HeadSwapCreateImageRequestAssets" /> class.
        /// </summary>
        /// <param name="bodyFilePath">
        /// Image that receives the swapped head. This value is either<br/>
        /// - a direct URL to the video file<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// Example: api-assets/id/1234.png
        /// </param>
        /// <param name="headFilePath">
        /// Image of the head to place on the body. This value is either<br/>
        /// - a direct URL to the video file<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// Example: api-assets/id/5678.png
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HeadSwapCreateImageRequestAssets(
            string bodyFilePath,
            string headFilePath)
        {
            this.BodyFilePath = bodyFilePath ?? throw new global::System.ArgumentNullException(nameof(bodyFilePath));
            this.HeadFilePath = headFilePath ?? throw new global::System.ArgumentNullException(nameof(headFilePath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HeadSwapCreateImageRequestAssets" /> class.
        /// </summary>
        public HeadSwapCreateImageRequestAssets()
        {
        }

    }
}