
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Provide the assets for face detection
    /// </summary>
    public sealed partial class FaceDetectionDetectFacesRequestAssets
    {
        /// <summary>
        /// This is the image or video where the face will be detected. This value is either<br/>
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
        /// Initializes a new instance of the <see cref="FaceDetectionDetectFacesRequestAssets" /> class.
        /// </summary>
        /// <param name="targetFilePath">
        /// This is the image or video where the face will be detected. This value is either<br/>
        /// - a direct URL to the video file<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// Example: api-assets/id/1234.png
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FaceDetectionDetectFacesRequestAssets(
            string targetFilePath)
        {
            this.TargetFilePath = targetFilePath ?? throw new global::System.ArgumentNullException(nameof(targetFilePath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceDetectionDetectFacesRequestAssets" /> class.
        /// </summary>
        public FaceDetectionDetectFacesRequestAssets()
        {
        }
    }
}