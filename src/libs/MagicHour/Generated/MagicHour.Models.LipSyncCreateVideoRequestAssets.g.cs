
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Provide the assets for lip-sync. For video, The `video_source` field determines whether `video_file_path` or `youtube_url` field is used
    /// </summary>
    public sealed partial class LipSyncCreateVideoRequestAssets
    {
        /// <summary>
        /// The path of the audio file. This value is either<br/>
        /// - a direct URL to the video file<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// Example: api-assets/id/1234.mp3
        /// </summary>
        /// <example>api-assets/id/1234.mp3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_file_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AudioFilePath { get; set; }

        /// <summary>
        /// Choose your video source.<br/>
        /// Example: file
        /// </summary>
        /// <example>file</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.LipSyncCreateVideoRequestAssetsVideoSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.LipSyncCreateVideoRequestAssetsVideoSource VideoSource { get; set; }

        /// <summary>
        /// Your video file. Required if `video_source` is `file`. This value is either<br/>
        /// - a direct URL to the video file<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// Example: api-assets/id/1234.mp4
        /// </summary>
        /// <example>api-assets/id/1234.mp4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_file_path")]
        public string? VideoFilePath { get; set; }

        /// <summary>
        /// YouTube URL (required if `video_source` is `youtube`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("youtube_url")]
        public string? YoutubeUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LipSyncCreateVideoRequestAssets" /> class.
        /// </summary>
        /// <param name="audioFilePath">
        /// The path of the audio file. This value is either<br/>
        /// - a direct URL to the video file<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// Example: api-assets/id/1234.mp3
        /// </param>
        /// <param name="videoSource">
        /// Choose your video source.<br/>
        /// Example: file
        /// </param>
        /// <param name="videoFilePath">
        /// Your video file. Required if `video_source` is `file`. This value is either<br/>
        /// - a direct URL to the video file<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// Example: api-assets/id/1234.mp4
        /// </param>
        /// <param name="youtubeUrl">
        /// YouTube URL (required if `video_source` is `youtube`).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LipSyncCreateVideoRequestAssets(
            string audioFilePath,
            global::MagicHour.LipSyncCreateVideoRequestAssetsVideoSource videoSource,
            string? videoFilePath,
            string? youtubeUrl)
        {
            this.AudioFilePath = audioFilePath ?? throw new global::System.ArgumentNullException(nameof(audioFilePath));
            this.VideoSource = videoSource;
            this.VideoFilePath = videoFilePath;
            this.YoutubeUrl = youtubeUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LipSyncCreateVideoRequestAssets" /> class.
        /// </summary>
        public LipSyncCreateVideoRequestAssets()
        {
        }

    }
}