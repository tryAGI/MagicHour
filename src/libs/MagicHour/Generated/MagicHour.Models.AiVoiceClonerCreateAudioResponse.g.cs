
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Success
    /// </summary>
    public sealed partial class AiVoiceClonerCreateAudioResponse
    {
        /// <summary>
        /// Unique ID of the audio. Use it with the [Get audio Project API](https://docs.magichour.ai/api-reference/audio-projects/get-audio-details) to fetch status and downloads.<br/>
        /// Example: cuid-example
        /// </summary>
        /// <example>cuid-example</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The amount of credits deducted from your account to generate the audio. We charge credits right when the request is made. <br/>
        /// If an error occurred while generating the audio, credits will be refunded and this field will be updated to include the refund.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits_charged")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreditsCharged { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiVoiceClonerCreateAudioResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique ID of the audio. Use it with the [Get audio Project API](https://docs.magichour.ai/api-reference/audio-projects/get-audio-details) to fetch status and downloads.<br/>
        /// Example: cuid-example
        /// </param>
        /// <param name="creditsCharged">
        /// The amount of credits deducted from your account to generate the audio. We charge credits right when the request is made. <br/>
        /// If an error occurred while generating the audio, credits will be refunded and this field will be updated to include the refund.<br/>
        /// Example: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiVoiceClonerCreateAudioResponse(
            string id,
            int creditsCharged)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreditsCharged = creditsCharged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiVoiceClonerCreateAudioResponse" /> class.
        /// </summary>
        public AiVoiceClonerCreateAudioResponse()
        {
        }

    }
}