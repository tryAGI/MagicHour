
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Unprocessable Entity
    /// </summary>
    public sealed partial class AiVoiceGeneratorCreateAudioResponse6
    {
        /// <summary>
        /// Example: Unable to generate speech
        /// </summary>
        /// <example>Unable to generate speech</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiVoiceGeneratorCreateAudioResponse6" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: Unable to generate speech
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiVoiceGeneratorCreateAudioResponse6(
            string message)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiVoiceGeneratorCreateAudioResponse6" /> class.
        /// </summary>
        public AiVoiceGeneratorCreateAudioResponse6()
        {
        }

    }
}