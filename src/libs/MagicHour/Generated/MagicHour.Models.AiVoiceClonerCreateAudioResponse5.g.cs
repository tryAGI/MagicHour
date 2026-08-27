
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Requested resource is not found<br/>
    /// Example: {"message":"Not Found"}
    /// </summary>
    public sealed partial class AiVoiceClonerCreateAudioResponse5
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.AiVoiceClonerCreateAudioResponseMessage2JsonConverter))]
        public global::MagicHour.AiVoiceClonerCreateAudioResponseMessage2 Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiVoiceClonerCreateAudioResponse5" /> class.
        /// </summary>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiVoiceClonerCreateAudioResponse5(
            global::MagicHour.AiVoiceClonerCreateAudioResponseMessage2 message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiVoiceClonerCreateAudioResponse5" /> class.
        /// </summary>
        public AiVoiceClonerCreateAudioResponse5()
        {
        }

    }
}