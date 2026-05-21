
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FaceDetectionGetDetailsResponseFace
    {
        /// <summary>
        /// The path to the face image. This should be used in face swap photo/video API calls as `.assets.face_mappings.original_face`<br/>
        /// Example: api-assets/id/0-0.png
        /// </summary>
        /// <example>api-assets/id/0-0.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// The url to the face image. This is used to render the image in your applications.<br/>
        /// Example: https://videos.magichour.ai/api-assets/id/0-0.png
        /// </summary>
        /// <example>https://videos.magichour.ai/api-assets/id/0-0.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceDetectionGetDetailsResponseFace" /> class.
        /// </summary>
        /// <param name="path">
        /// The path to the face image. This should be used in face swap photo/video API calls as `.assets.face_mappings.original_face`<br/>
        /// Example: api-assets/id/0-0.png
        /// </param>
        /// <param name="url">
        /// The url to the face image. This is used to render the image in your applications.<br/>
        /// Example: https://videos.magichour.ai/api-assets/id/0-0.png
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FaceDetectionGetDetailsResponseFace(
            string path,
            string url)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceDetectionGetDetailsResponseFace" /> class.
        /// </summary>
        public FaceDetectionGetDetailsResponseFace()
        {
        }

    }
}