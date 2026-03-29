
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoToVideoCreateVideoRequest
    {
        /// <summary>
        /// Give your video a custom name for easy identification.<br/>
        /// Default Value: Video To Video - dateTime<br/>
        /// Example: My Video To Video video
        /// </summary>
        /// <example>My Video To Video video</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Start time of your clip (seconds). Must be ≥ 0.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float StartSeconds { get; set; }

        /// <summary>
        /// End time of your clip (seconds). Must be greater than start_seconds.<br/>
        /// Example: 15
        /// </summary>
        /// <example>15</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float EndSeconds { get; set; }

        /// <summary>
        /// Determines whether the resulting video will have the same frame per second as the original video, or half.<br/>
        /// * `FULL` - the result video will have the same FPS as the input video<br/>
        /// * `HALF` - the result video will have half the FPS as the input video<br/>
        /// Default Value: HALF<br/>
        /// Example: HALF
        /// </summary>
        /// <example>HALF</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("fps_resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.VideoToVideoCreateVideoRequestFpsResolutionJsonConverter))]
        public global::MagicHour.VideoToVideoCreateVideoRequestFpsResolution? FpsResolution { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.VideoToVideoCreateVideoRequestStyle Style { get; set; }

        /// <summary>
        /// Provide the assets for video-to-video. For video, The `video_source` field determines whether `video_file_path` or `youtube_url` field is used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.VideoToVideoCreateVideoRequestAssets Assets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoToVideoCreateVideoRequest" /> class.
        /// </summary>
        /// <param name="startSeconds">
        /// Start time of your clip (seconds). Must be ≥ 0.<br/>
        /// Example: 0
        /// </param>
        /// <param name="endSeconds">
        /// End time of your clip (seconds). Must be greater than start_seconds.<br/>
        /// Example: 15
        /// </param>
        /// <param name="style"></param>
        /// <param name="assets">
        /// Provide the assets for video-to-video. For video, The `video_source` field determines whether `video_file_path` or `youtube_url` field is used
        /// </param>
        /// <param name="name">
        /// Give your video a custom name for easy identification.<br/>
        /// Default Value: Video To Video - dateTime<br/>
        /// Example: My Video To Video video
        /// </param>
        /// <param name="fpsResolution">
        /// Determines whether the resulting video will have the same frame per second as the original video, or half.<br/>
        /// * `FULL` - the result video will have the same FPS as the input video<br/>
        /// * `HALF` - the result video will have half the FPS as the input video<br/>
        /// Default Value: HALF<br/>
        /// Example: HALF
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoToVideoCreateVideoRequest(
            float startSeconds,
            float endSeconds,
            global::MagicHour.VideoToVideoCreateVideoRequestStyle style,
            global::MagicHour.VideoToVideoCreateVideoRequestAssets assets,
            string? name,
            global::MagicHour.VideoToVideoCreateVideoRequestFpsResolution? fpsResolution)
        {
            this.Name = name;
            this.StartSeconds = startSeconds;
            this.EndSeconds = endSeconds;
            this.FpsResolution = fpsResolution;
            this.Style = style ?? throw new global::System.ArgumentNullException(nameof(style));
            this.Assets = assets ?? throw new global::System.ArgumentNullException(nameof(assets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoToVideoCreateVideoRequest" /> class.
        /// </summary>
        public VideoToVideoCreateVideoRequest()
        {
        }
    }
}