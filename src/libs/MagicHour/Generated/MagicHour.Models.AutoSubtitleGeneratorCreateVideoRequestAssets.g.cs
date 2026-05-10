
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Provide the assets for auto subtitle generator
    /// </summary>
    public sealed partial class AutoSubtitleGeneratorCreateVideoRequestAssets
    {
        /// <summary>
        /// This is the video used to add subtitles. This value is either<br/>
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
        /// Initializes a new instance of the <see cref="AutoSubtitleGeneratorCreateVideoRequestAssets" /> class.
        /// </summary>
        /// <param name="videoFilePath">
        /// This is the video used to add subtitles. This value is either<br/>
        /// - a direct URL to the video file<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// Example: api-assets/id/1234.mp4
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSubtitleGeneratorCreateVideoRequestAssets(
            string videoFilePath)
        {
            this.VideoFilePath = videoFilePath ?? throw new global::System.ArgumentNullException(nameof(videoFilePath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSubtitleGeneratorCreateVideoRequestAssets" /> class.
        /// </summary>
        public AutoSubtitleGeneratorCreateVideoRequestAssets()
        {
        }

    }
}