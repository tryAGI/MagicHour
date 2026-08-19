
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Success
    /// </summary>
    public sealed partial class AudioProjectsGetDetailsResponse
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
        /// The name of the audio.<br/>
        /// Example: Example Name
        /// </summary>
        /// <example>Example Name</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The status of the audio.<br/>
        /// - `draft` - the project was created but has not been submitted for rendering<br/>
        /// - `queued` - the job is waiting for an available server<br/>
        /// - `rendering` - the job is being processed; the `audio.started` webhook event fires when rendering begins<br/>
        /// - `complete` - the job finished successfully; fires `audio.completed`<br/>
        /// - `error` - the job failed during processing; fires `audio.errored`<br/>
        /// - `canceled` - the job was manually canceled (for example from the Magic Hour web app)<br/>
        /// **Note:** `rendering`, `complete`, and `error` have matching webhook events; `canceled` does not - a canceled job emits no webhook event, so poll this endpoint to detect cancellation.<br/>
        /// Example: complete
        /// </summary>
        /// <example>complete</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.AudioProjectsGetDetailsResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.AudioProjectsGetDetailsResponseStatus Status { get; set; }

        /// <summary>
        /// The type of the audio project. Possible values are VOICE_GENERATOR, VOICE_CHANGER, VOICE_CLONER, VIDEO_TO_AUDIO, MUSIC_GENERATOR<br/>
        /// Example: VOICE_GENERATOR
        /// </summary>
        /// <example>VOICE_GENERATOR</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Whether this resource is active. If false, it is deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// The amount of credits deducted from your account to generate the audio. We charge credits right when the request is made. <br/>
        /// If an error occurred while generating the audio, credits will be refunded and this field will be updated to include the refund.<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits_charged")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreditsCharged { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("downloads")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::MagicHour.AudioProjectsGetDetailsResponseDownload> Downloads { get; set; }

        /// <summary>
        /// In the case of an error, this object will contain the error encountered during video render<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::MagicHour.AudioProjectsGetDetailsResponseError? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioProjectsGetDetailsResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique ID of the audio. Use it with the [Get audio Project API](https://docs.magichour.ai/api-reference/audio-projects/get-audio-details) to fetch status and downloads.<br/>
        /// Example: cuid-example
        /// </param>
        /// <param name="status">
        /// The status of the audio.<br/>
        /// - `draft` - the project was created but has not been submitted for rendering<br/>
        /// - `queued` - the job is waiting for an available server<br/>
        /// - `rendering` - the job is being processed; the `audio.started` webhook event fires when rendering begins<br/>
        /// - `complete` - the job finished successfully; fires `audio.completed`<br/>
        /// - `error` - the job failed during processing; fires `audio.errored`<br/>
        /// - `canceled` - the job was manually canceled (for example from the Magic Hour web app)<br/>
        /// **Note:** `rendering`, `complete`, and `error` have matching webhook events; `canceled` does not - a canceled job emits no webhook event, so poll this endpoint to detect cancellation.<br/>
        /// Example: complete
        /// </param>
        /// <param name="type">
        /// The type of the audio project. Possible values are VOICE_GENERATOR, VOICE_CHANGER, VOICE_CLONER, VIDEO_TO_AUDIO, MUSIC_GENERATOR<br/>
        /// Example: VOICE_GENERATOR
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="enabled">
        /// Whether this resource is active. If false, it is deleted.
        /// </param>
        /// <param name="creditsCharged">
        /// The amount of credits deducted from your account to generate the audio. We charge credits right when the request is made. <br/>
        /// If an error occurred while generating the audio, credits will be refunded and this field will be updated to include the refund.<br/>
        /// Example: 2
        /// </param>
        /// <param name="downloads"></param>
        /// <param name="name">
        /// The name of the audio.<br/>
        /// Example: Example Name
        /// </param>
        /// <param name="error">
        /// In the case of an error, this object will contain the error encountered during video render<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioProjectsGetDetailsResponse(
            string id,
            global::MagicHour.AudioProjectsGetDetailsResponseStatus status,
            string type,
            global::System.DateTime createdAt,
            bool enabled,
            int creditsCharged,
            global::System.Collections.Generic.IList<global::MagicHour.AudioProjectsGetDetailsResponseDownload> downloads,
            string? name,
            global::MagicHour.AudioProjectsGetDetailsResponseError? error)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name;
            this.Status = status;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.CreatedAt = createdAt;
            this.Enabled = enabled;
            this.CreditsCharged = creditsCharged;
            this.Downloads = downloads ?? throw new global::System.ArgumentNullException(nameof(downloads));
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioProjectsGetDetailsResponse" /> class.
        /// </summary>
        public AudioProjectsGetDetailsResponse()
        {
        }

    }
}