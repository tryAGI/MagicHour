
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Person image and scene image for body swap
    /// </summary>
    public sealed partial class BodySwapCreateImageRequestAssets
    {
        /// <summary>
        /// Image of the person to place into the scene. This value is either<br/>
        /// - a direct URL to the video file<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// Example: api-assets/id/1234.png
        /// </summary>
        /// <example>api-assets/id/1234.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("person_file_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PersonFilePath { get; set; }

        /// <summary>
        /// Original scene image (background). This value is either<br/>
        /// - a direct URL to the video file<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// Example: api-assets/id/5678.png
        /// </summary>
        /// <example>api-assets/id/5678.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("scene_file_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SceneFilePath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodySwapCreateImageRequestAssets" /> class.
        /// </summary>
        /// <param name="personFilePath">
        /// Image of the person to place into the scene. This value is either<br/>
        /// - a direct URL to the video file<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// Example: api-assets/id/1234.png
        /// </param>
        /// <param name="sceneFilePath">
        /// Original scene image (background). This value is either<br/>
        /// - a direct URL to the video file<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// Example: api-assets/id/5678.png
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodySwapCreateImageRequestAssets(
            string personFilePath,
            string sceneFilePath)
        {
            this.PersonFilePath = personFilePath ?? throw new global::System.ArgumentNullException(nameof(personFilePath));
            this.SceneFilePath = sceneFilePath ?? throw new global::System.ArgumentNullException(nameof(sceneFilePath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodySwapCreateImageRequestAssets" /> class.
        /// </summary>
        public BodySwapCreateImageRequestAssets()
        {
        }

    }
}