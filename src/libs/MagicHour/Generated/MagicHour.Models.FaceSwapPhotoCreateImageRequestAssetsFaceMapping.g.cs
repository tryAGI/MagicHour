
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FaceSwapPhotoCreateImageRequestAssetsFaceMapping
    {
        /// <summary>
        /// The face detected from the image in `target_file_path`. The file name is in the format of `&lt;face_frame&gt;-&lt;face_index&gt;.png`. This value is corresponds to the response in the [face detection API](https://docs.magichour.ai/api-reference/files/get-face-detection-details).<br/>
        /// * The face_frame is the frame number of the face in the target image. For images, the frame number is always 0.<br/>
        /// * The face_index is the index of the face in the target image, starting from 0 going left to right.<br/>
        /// Example: api-assets/id/0-0.png
        /// </summary>
        /// <example>api-assets/id/0-0.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_face")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OriginalFace { get; set; }

        /// <summary>
        /// The face image that will be used to replace the face in the `original_face`. This value is either<br/>
        /// - a direct URL to the video file<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// Example: api-assets/id/1234.png
        /// </summary>
        /// <example>api-assets/id/1234.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_face")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NewFace { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceSwapPhotoCreateImageRequestAssetsFaceMapping" /> class.
        /// </summary>
        /// <param name="originalFace">
        /// The face detected from the image in `target_file_path`. The file name is in the format of `&lt;face_frame&gt;-&lt;face_index&gt;.png`. This value is corresponds to the response in the [face detection API](https://docs.magichour.ai/api-reference/files/get-face-detection-details).<br/>
        /// * The face_frame is the frame number of the face in the target image. For images, the frame number is always 0.<br/>
        /// * The face_index is the index of the face in the target image, starting from 0 going left to right.<br/>
        /// Example: api-assets/id/0-0.png
        /// </param>
        /// <param name="newFace">
        /// The face image that will be used to replace the face in the `original_face`. This value is either<br/>
        /// - a direct URL to the video file<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// Example: api-assets/id/1234.png
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FaceSwapPhotoCreateImageRequestAssetsFaceMapping(
            string originalFace,
            string newFace)
        {
            this.OriginalFace = originalFace ?? throw new global::System.ArgumentNullException(nameof(originalFace));
            this.NewFace = newFace ?? throw new global::System.ArgumentNullException(nameof(newFace));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceSwapPhotoCreateImageRequestAssetsFaceMapping" /> class.
        /// </summary>
        public FaceSwapPhotoCreateImageRequestAssetsFaceMapping()
        {
        }

    }
}