
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// In the case of an error, this object will contain the error encountered during video render<br/>
    /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public sealed partial class VideoProjectsGetDetailsResponseError
    {
        /// <summary>
        /// Details on the reason why a failure happened.<br/>
        /// Example: Please use an image with a detectable face
        /// </summary>
        /// <example>Please use an image with a detectable face</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// An error code to indicate why a failure happened.<br/>
        /// Example: no_source_face
        /// </summary>
        /// <example>no_source_face</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoProjectsGetDetailsResponseError" /> class.
        /// </summary>
        /// <param name="message">
        /// Details on the reason why a failure happened.<br/>
        /// Example: Please use an image with a detectable face
        /// </param>
        /// <param name="code">
        /// An error code to indicate why a failure happened.<br/>
        /// Example: no_source_face
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoProjectsGetDetailsResponseError(
            string message,
            string code)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoProjectsGetDetailsResponseError" /> class.
        /// </summary>
        public VideoProjectsGetDetailsResponseError()
        {
        }
    }
}