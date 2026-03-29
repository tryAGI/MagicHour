
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FaceDetectionGetDetailsResponse
    {
        /// <summary>
        /// The id of the task. This value is returned by the [face detection API](https://docs.magichour.ai/api-reference/files/face-detection#response-id).<br/>
        /// Example: uuid-example
        /// </summary>
        /// <example>uuid-example</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The credits charged for the task.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits_charged")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreditsCharged { get; set; }

        /// <summary>
        /// The status of the detection.<br/>
        /// Example: complete
        /// </summary>
        /// <example>complete</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.FaceDetectionGetDetailsResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.FaceDetectionGetDetailsResponseStatus Status { get; set; }

        /// <summary>
        /// The faces detected in the image or video. The list is populated as faces are detected.<br/>
        /// Example: [{"path":"api-assets/id/0-0.png","url":"https://videos.magichour.ai/api-assets/id/0-0.png"}]
        /// </summary>
        /// <example>[{"path":"api-assets/id/0-0.png","url":"https://videos.magichour.ai/api-assets/id/0-0.png"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("faces")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::MagicHour.FaceDetectionGetDetailsResponseFace> Faces { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceDetectionGetDetailsResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The id of the task. This value is returned by the [face detection API](https://docs.magichour.ai/api-reference/files/face-detection#response-id).<br/>
        /// Example: uuid-example
        /// </param>
        /// <param name="creditsCharged">
        /// The credits charged for the task.<br/>
        /// Example: 0
        /// </param>
        /// <param name="status">
        /// The status of the detection.<br/>
        /// Example: complete
        /// </param>
        /// <param name="faces">
        /// The faces detected in the image or video. The list is populated as faces are detected.<br/>
        /// Example: [{"path":"api-assets/id/0-0.png","url":"https://videos.magichour.ai/api-assets/id/0-0.png"}]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FaceDetectionGetDetailsResponse(
            string id,
            int creditsCharged,
            global::MagicHour.FaceDetectionGetDetailsResponseStatus status,
            global::System.Collections.Generic.IList<global::MagicHour.FaceDetectionGetDetailsResponseFace> faces)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreditsCharged = creditsCharged;
            this.Status = status;
            this.Faces = faces ?? throw new global::System.ArgumentNullException(nameof(faces));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceDetectionGetDetailsResponse" /> class.
        /// </summary>
        public FaceDetectionGetDetailsResponse()
        {
        }
    }
}