
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// The request is not properly authenticated<br/>
    /// Example: {"message":"Unauthorized"}
    /// </summary>
    public sealed partial class AiVoiceClonerCreateAudioResponse3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.AiVoiceClonerCreateAudioResponseMessageJsonConverter))]
        public global::MagicHour.AiVoiceClonerCreateAudioResponseMessage Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiVoiceClonerCreateAudioResponse3" /> class.
        /// </summary>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiVoiceClonerCreateAudioResponse3(
            global::MagicHour.AiVoiceClonerCreateAudioResponseMessage message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiVoiceClonerCreateAudioResponse3" /> class.
        /// </summary>
        public AiVoiceClonerCreateAudioResponse3()
        {
        }

    }
}