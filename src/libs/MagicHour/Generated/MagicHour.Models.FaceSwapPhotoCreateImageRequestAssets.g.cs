
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Provide the assets for face swap photo
    /// </summary>
    public sealed partial class FaceSwapPhotoCreateImageRequestAssets
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.FaceSwapPhotoCreateImageRequestAssetsFaceSwapModeJsonConverter))]
        public global::MagicHour.FaceSwapPhotoCreateImageRequestAssetsFaceSwapMode? FaceSwapMode { get; set; }

        /// <summary>
        /// This is the image from which the face is extracted. The value is required if `face_swap_mode` is `all-faces`.<br/>
        /// This value is either<br/>
        /// - a direct URL to the video file<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// Example: api-assets/id/1234.png
        /// </summary>
        /// <example>api-assets/id/1234.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_file_path")]
        public string? SourceFilePath { get; set; }

        /// <summary>
        /// This is the array of face mappings used for multiple face swap. The value is required if `face_swap_mode` is `individual-faces`.<br/>
        /// Example: [{"original_face":"api-assets/id/0-0.png","new_face":"api-assets/id/1234.png"}]
        /// </summary>
        /// <example>[{"original_face":"api-assets/id/0-0.png","new_face":"api-assets/id/1234.png"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("face_mappings")]
        public global::System.Collections.Generic.IList<global::MagicHour.FaceSwapPhotoCreateImageRequestAssetsFaceMapping>? FaceMappings { get; set; }

        /// <summary>
        /// This is the image where the face from the source image will be placed. This value is either<br/>
        /// - a direct URL to the video file<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// Example: api-assets/id/1234.png
        /// </summary>
        /// <example>api-assets/id/1234.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_file_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetFilePath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceSwapPhotoCreateImageRequestAssets" /> class.
        /// </summary>
        /// <param name="targetFilePath">
        /// This is the image where the face from the source image will be placed. This value is either<br/>
        /// - a direct URL to the video file<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// Example: api-assets/id/1234.png
        /// </param>
        /// <param name="faceSwapMode">
        /// Choose how to swap faces:<br/>
        /// **all-faces** (recommended) — swap all detected faces using one source image (`source_file_path` required)<br/>
        /// +- **individual-faces** — specify exact mappings using `face_mappings`<br/>
        /// Default Value: all-faces<br/>
        /// Example: all-faces
        /// </param>
        /// <param name="sourceFilePath">
        /// This is the image from which the face is extracted. The value is required if `face_swap_mode` is `all-faces`.<br/>
        /// This value is either<br/>
        /// - a direct URL to the video file<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// Example: api-assets/id/1234.png
        /// </param>
        /// <param name="faceMappings">
        /// This is the array of face mappings used for multiple face swap. The value is required if `face_swap_mode` is `individual-faces`.<br/>
        /// Example: [{"original_face":"api-assets/id/0-0.png","new_face":"api-assets/id/1234.png"}]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FaceSwapPhotoCreateImageRequestAssets(
            string targetFilePath,
            global::MagicHour.FaceSwapPhotoCreateImageRequestAssetsFaceSwapMode? faceSwapMode,
            string? sourceFilePath,
            global::System.Collections.Generic.IList<global::MagicHour.FaceSwapPhotoCreateImageRequestAssetsFaceMapping>? faceMappings)
        {
            this.FaceSwapMode = faceSwapMode;
            this.SourceFilePath = sourceFilePath;
            this.FaceMappings = faceMappings;
            this.TargetFilePath = targetFilePath ?? throw new global::System.ArgumentNullException(nameof(targetFilePath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceSwapPhotoCreateImageRequestAssets" /> class.
        /// </summary>
        public FaceSwapPhotoCreateImageRequestAssets()
        {
        }
    }
}