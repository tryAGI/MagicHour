
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Provide the assets for video editing.
    /// </summary>
    public sealed partial class AiVideoEditorCreateVideoRequestAssets
    {
        /// <summary>
        /// The video to edit. This value is either<br/>
        /// - a direct URL to the video file<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// Example: api-assets/id/1234.mp4
        /// </summary>
        /// <example>api-assets/id/1234.mp4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_file_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VideoFilePath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiVideoEditorCreateVideoRequestAssets" /> class.
        /// </summary>
        /// <param name="videoFilePath">
        /// The video to edit. This value is either<br/>
        /// - a direct URL to the video file<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// Example: api-assets/id/1234.mp4
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiVideoEditorCreateVideoRequestAssets(
            string videoFilePath)
        {
            this.VideoFilePath = videoFilePath ?? throw new global::System.ArgumentNullException(nameof(videoFilePath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiVideoEditorCreateVideoRequestAssets" /> class.
        /// </summary>
        public AiVideoEditorCreateVideoRequestAssets()
        {
        }

    }
}