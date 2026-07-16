
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Source video and reference character image for the job.
    /// </summary>
    public sealed partial class CharacterReplaceCreateVideoRequestAssets
    {
        /// <summary>
        /// Source video containing the subject to replace or animate. This value is either<br/>
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
        /// Reference character image used as the replacement or animation target. This value is either<br/>
        /// - a direct URL to the video file<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// Example: api-assets/id/5678.png
        /// </summary>
        /// <example>api-assets/id/5678.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_file_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageFilePath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterReplaceCreateVideoRequestAssets" /> class.
        /// </summary>
        /// <param name="videoFilePath">
        /// Source video containing the subject to replace or animate. This value is either<br/>
        /// - a direct URL to the video file<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// Example: api-assets/id/1234.mp4
        /// </param>
        /// <param name="imageFilePath">
        /// Reference character image used as the replacement or animation target. This value is either<br/>
        /// - a direct URL to the video file<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// Example: api-assets/id/5678.png
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CharacterReplaceCreateVideoRequestAssets(
            string videoFilePath,
            string imageFilePath)
        {
            this.VideoFilePath = videoFilePath ?? throw new global::System.ArgumentNullException(nameof(videoFilePath));
            this.ImageFilePath = imageFilePath ?? throw new global::System.ArgumentNullException(nameof(imageFilePath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterReplaceCreateVideoRequestAssets" /> class.
        /// </summary>
        public CharacterReplaceCreateVideoRequestAssets()
        {
        }

    }
}