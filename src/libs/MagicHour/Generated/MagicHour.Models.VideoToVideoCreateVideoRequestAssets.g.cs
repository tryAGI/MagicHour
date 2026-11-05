
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Provide the assets for video-to-video. For video, The `video_source` field determines whether `video_file_path` or `youtube_url` field is used<br/>
    /// Example: {"video_source":"file","video_file_path":"api-assets/id/1234.mp4"}
    /// </summary>
    public sealed partial class VideoToVideoCreateVideoRequestAssets
    {
        /// <summary>
        /// Choose your video source.<br/>
        /// Example: file
        /// </summary>
        /// <example>file</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.VideoToVideoCreateVideoRequestAssetsVideoSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.VideoToVideoCreateVideoRequestAssetsVideoSource VideoSource { get; set; }

        /// <summary>
        /// Your video file. Required if `video_source` is `file`. This value is either<br/>
        /// - a direct URL to the file. The URL path must end in a supported file extension.<br/>
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
        /// Required for v3: an uploaded reference image path, or a completed image output owned by you. The caller supplies this image; the API does not generate it.<br/>
        /// Example: api-assets/id/reference.png
        /// </summary>
        /// <example>api-assets/id/reference.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("initial_image_path")]
        public string? InitialImagePath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoToVideoCreateVideoRequestAssets" /> class.
        /// </summary>
        /// <param name="videoSource">
        /// Choose your video source.<br/>
        /// Example: file
        /// </param>
        /// <param name="videoFilePath">
        /// Your video file. Required if `video_source` is `file`. This value is either<br/>
        /// - a direct URL to the file. The URL path must end in a supported file extension.<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// Example: api-assets/id/1234.mp4
        /// </param>
        /// <param name="youtubeUrl">
        /// YouTube URL (required if `video_source` is `youtube`).
        /// </param>
        /// <param name="initialImagePath">
        /// Required for v3: an uploaded reference image path, or a completed image output owned by you. The caller supplies this image; the API does not generate it.<br/>
        /// Example: api-assets/id/reference.png
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoToVideoCreateVideoRequestAssets(
            global::MagicHour.VideoToVideoCreateVideoRequestAssetsVideoSource videoSource,
            string? videoFilePath,
            string? youtubeUrl,
            string? initialImagePath)
        {
            this.VideoSource = videoSource;
            this.VideoFilePath = videoFilePath;
            this.YoutubeUrl = youtubeUrl;
            this.InitialImagePath = initialImagePath;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoToVideoCreateVideoRequestAssets" /> class.
        /// </summary>
        public VideoToVideoCreateVideoRequestAssets()
        {
        }

    }
}