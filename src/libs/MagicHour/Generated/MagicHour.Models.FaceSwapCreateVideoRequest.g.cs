
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FaceSwapCreateVideoRequest
    {
        /// <summary>
        /// Give your video a custom name for easy identification.<br/>
        /// Default Value: Face Swap - dateTime<br/>
        /// Example: My Face Swap video
        /// </summary>
        /// <example>My Face Swap video</example>
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
        /// Style of the face swap video.<br/>
        /// Example: {"version":"default"}
        /// </summary>
        /// <example>{"version":"default"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        public global::MagicHour.FaceSwapCreateVideoRequestStyle? Style { get; set; }

        /// <summary>
        /// Provide the assets for face swap. For video, The `video_source` field determines whether `video_file_path` or `youtube_url` field is used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.FaceSwapCreateVideoRequestAssets Assets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceSwapCreateVideoRequest" /> class.
        /// </summary>
        /// <param name="startSeconds">
        /// Start time of your clip (seconds). Must be ≥ 0.<br/>
        /// Example: 0
        /// </param>
        /// <param name="endSeconds">
        /// End time of your clip (seconds). Must be greater than start_seconds.<br/>
        /// Example: 15
        /// </param>
        /// <param name="assets">
        /// Provide the assets for face swap. For video, The `video_source` field determines whether `video_file_path` or `youtube_url` field is used
        /// </param>
        /// <param name="name">
        /// Give your video a custom name for easy identification.<br/>
        /// Default Value: Face Swap - dateTime<br/>
        /// Example: My Face Swap video
        /// </param>
        /// <param name="style">
        /// Style of the face swap video.<br/>
        /// Example: {"version":"default"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FaceSwapCreateVideoRequest(
            float startSeconds,
            float endSeconds,
            global::MagicHour.FaceSwapCreateVideoRequestAssets assets,
            string? name,
            global::MagicHour.FaceSwapCreateVideoRequestStyle? style)
        {
            this.Name = name;
            this.StartSeconds = startSeconds;
            this.EndSeconds = endSeconds;
            this.Style = style;
            this.Assets = assets ?? throw new global::System.ArgumentNullException(nameof(assets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceSwapCreateVideoRequest" /> class.
        /// </summary>
        public FaceSwapCreateVideoRequest()
        {
        }

    }
}