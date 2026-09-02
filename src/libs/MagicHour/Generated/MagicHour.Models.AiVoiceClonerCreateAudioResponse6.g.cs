
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AiVoiceClonerCreateAudioResponse6
    {
        /// <summary>
        /// Machine-readable error code.<br/>
        /// - `unprocessable_entity`: Change the request values before retrying.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.AiVoiceClonerCreateAudioResponseCode5JsonConverter))]
        public global::MagicHour.AiVoiceClonerCreateAudioResponseCode5 Code { get; set; }

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
        /// Initializes a new instance of the <see cref="AiVoiceClonerCreateAudioResponse6" /> class.
        /// </summary>
        /// <param name="message">
        /// Human-readable error message.
        /// </param>
        /// <param name="code">
        /// Machine-readable error code.<br/>
        /// - `unprocessable_entity`: Change the request values before retrying.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiVoiceClonerCreateAudioResponse6(
            string message,
            global::MagicHour.AiVoiceClonerCreateAudioResponseCode5 code)
        {
            this.Code = code;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiVoiceClonerCreateAudioResponse6" /> class.
        /// </summary>
        public AiVoiceClonerCreateAudioResponse6()
        {
        }

    }
}