
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FaceDetectionDetectFacesResponse
    {
        /// <summary>
        /// The id of the task. Use this value in the [get face detection details API](https://docs.magichour.ai/api-reference/files/get-face-detection-details) to get the details of the face detection task.<br/>
        /// Example: uuid-example
        /// </summary>
        /// <example>uuid-example</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The credits charged for the task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits_charged")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreditsCharged { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceDetectionDetectFacesResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The id of the task. Use this value in the [get face detection details API](https://docs.magichour.ai/api-reference/files/get-face-detection-details) to get the details of the face detection task.<br/>
        /// Example: uuid-example
        /// </param>
        /// <param name="creditsCharged">
        /// The credits charged for the task.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FaceDetectionDetectFacesResponse(
            string id,
            int creditsCharged)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreditsCharged = creditsCharged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceDetectionDetectFacesResponse" /> class.
        /// </summary>
        public FaceDetectionDetectFacesResponse()
        {
        }

    }
}