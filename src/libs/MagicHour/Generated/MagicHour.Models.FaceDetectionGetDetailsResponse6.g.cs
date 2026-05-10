
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Unprocessable Entity
    /// </summary>
    public sealed partial class FaceDetectionGetDetailsResponse6
    {
        /// <summary>
        /// Example: Unable to get face detection details
        /// </summary>
        /// <example>Unable to get face detection details</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceDetectionGetDetailsResponse6" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: Unable to get face detection details
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FaceDetectionGetDetailsResponse6(
            string message)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceDetectionGetDetailsResponse6" /> class.
        /// </summary>
        public FaceDetectionGetDetailsResponse6()
        {
        }

    }
}