
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AiVideoEditorCreateVideoResponse3
    {
        /// <summary>
        /// Machine-readable error code.<br/>
        /// - `unauthorized`: Provide a valid API key before retrying.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.AiVideoEditorCreateVideoResponseCode2JsonConverter))]
        public global::MagicHour.AiVideoEditorCreateVideoResponseCode2 Code { get; set; }

        /// <summary>
        /// Human-readable error message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiVideoEditorCreateVideoResponse3" /> class.
        /// </summary>
        /// <param name="message">
        /// Human-readable error message.
        /// </param>
        /// <param name="code">
        /// Machine-readable error code.<br/>
        /// - `unauthorized`: Provide a valid API key before retrying.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiVideoEditorCreateVideoResponse3(
            string message,
            global::MagicHour.AiVideoEditorCreateVideoResponseCode2 code)
        {
            this.Code = code;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiVideoEditorCreateVideoResponse3" /> class.
        /// </summary>
        public AiVideoEditorCreateVideoResponse3()
        {
        }

    }
}