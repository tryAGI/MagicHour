
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Provide the assets for face swap. For video, The `video_source` field determines whether `video_file_path` or `youtube_url` field is used
    /// </summary>
    public sealed partial class FaceSwapCreateVideoRequestAssets
    {
        /// <summary>
        /// Choose how to swap faces:<br/>
        /// **all-faces** (recommended) — swap all detected faces using one source image (`source_file_path` required)<br/>
        /// +- **individual-faces** — specify exact mappings using `face_mappings`<br/>
        /// Default Value: all-faces<br/>
        /// Example: all-faces
        /// </summary>
        /// <example>all-faces</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("face_swap_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.FaceSwapCreateVideoRequestAssetsFaceSwapModeJsonConverter))]
        public global::MagicHour.FaceSwapCreateVideoRequestAssetsFaceSwapMode? FaceSwapMode { get; set; }

        /// <summary>
        /// The path of the input image with the face to be swapped.  The value is required if `face_swap_mode` is `all-faces`.<br/>
        /// This value is either<br/>
        /// - a direct URL to the video file<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// Example: image/id/1234.png
        /// </summary>
        /// <example>image/id/1234.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_file_path")]
        public string? ImageFilePath { get; set; }

        /// <summary>
        /// This is the array of face mappings used for multiple face swap. The value is required if `face_swap_mode` is `individual-faces`.<br/>
        /// Example: [{"original_face":"api-assets/id/0-0.png","new_face":"api-assets/id/1234.png"}]
        /// </summary>
        /// <example>[{"original_face":"api-assets/id/0-0.png","new_face":"api-assets/id/1234.png"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("face_mappings")]
        public global::System.Collections.Generic.IList<global::MagicHour.FaceSwapCreateVideoRequestAssetsFaceMapping>? FaceMappings { get; set; }

        /// <summary>
        /// Choose your video source.<br/>
        /// Example: file
        /// </summary>
        /// <example>file</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.FaceSwapCreateVideoRequestAssetsVideoSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.FaceSwapCreateVideoRequestAssetsVideoSource VideoSource { get; set; }

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
        /// Initializes a new instance of the <see cref="FaceSwapCreateVideoRequestAssets" /> class.
        /// </summary>
        /// <param name="videoSource">
        /// Choose your video source.<br/>
        /// Example: file
        /// </param>
        /// <param name="faceSwapMode">
        /// Choose how to swap faces:<br/>
        /// **all-faces** (recommended) — swap all detected faces using one source image (`source_file_path` required)<br/>
        /// +- **individual-faces** — specify exact mappings using `face_mappings`<br/>
        /// Default Value: all-faces<br/>
        /// Example: all-faces
        /// </param>
        /// <param name="imageFilePath">
        /// The path of the input image with the face to be swapped.  The value is required if `face_swap_mode` is `all-faces`.<br/>
        /// This value is either<br/>
        /// - a direct URL to the video file<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// Example: image/id/1234.png
        /// </param>
        /// <param name="faceMappings">
        /// This is the array of face mappings used for multiple face swap. The value is required if `face_swap_mode` is `individual-faces`.<br/>
        /// Example: [{"original_face":"api-assets/id/0-0.png","new_face":"api-assets/id/1234.png"}]
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
        public FaceSwapCreateVideoRequestAssets(
            global::MagicHour.FaceSwapCreateVideoRequestAssetsVideoSource videoSource,
            global::MagicHour.FaceSwapCreateVideoRequestAssetsFaceSwapMode? faceSwapMode,
            string? imageFilePath,
            global::System.Collections.Generic.IList<global::MagicHour.FaceSwapCreateVideoRequestAssetsFaceMapping>? faceMappings,
            string? videoFilePath,
            string? youtubeUrl)
        {
            this.FaceSwapMode = faceSwapMode;
            this.ImageFilePath = imageFilePath;
            this.FaceMappings = faceMappings;
            this.VideoSource = videoSource;
            this.VideoFilePath = videoFilePath;
            this.YoutubeUrl = youtubeUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceSwapCreateVideoRequestAssets" /> class.
        /// </summary>
        public FaceSwapCreateVideoRequestAssets()
        {
        }

    }
}