
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// The content used to generate speech.<br/>
    /// Example: {"prompt":"Hello, how are you?","voice_name":"Elon Musk","language":"spanish","speed":1.15}
    /// </summary>
    public sealed partial class AiVoiceGeneratorCreateAudioRequestStyle
    {
        /// <summary>
        /// Text used to generate speech. The character limit is 5000 characters.<br/>
        /// Example: Hello, how are you?
        /// </summary>
        /// <example>Hello, how are you?</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The voice to use for the speech. Use the `id` of a voice returned by `GET /v1/voices`.<br/>
        /// Example: Elon Musk
        /// </summary>
        /// <example>Elon Musk</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.AiVoiceGeneratorCreateAudioRequestStyleVoiceNameJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.AiVoiceGeneratorCreateAudioRequestStyleVoiceName VoiceName { get; set; }

        /// <summary>
        /// Spoken language. Use a canonical lowercase language name, or auto to detect the language from the text. Defaults to auto.<br/>
        /// Default Value: auto<br/>
        /// Example: spanish
        /// </summary>
        /// <example>spanish</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.AiVoiceGeneratorCreateAudioRequestStyleLanguageJsonConverter))]
        public global::MagicHour.AiVoiceGeneratorCreateAudioRequestStyleLanguage? Language { get; set; }

        /// <summary>
        /// Speech speed multiplier, from 0.75 to 1.30 inclusive. Defaults to 1 (normal speed).<br/>
        /// Default Value: 1<br/>
        /// Example: 1.15F
        /// </summary>
        /// <example>1.15F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiVoiceGeneratorCreateAudioRequestStyle" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Text used to generate speech. The character limit is 5000 characters.<br/>
        /// Example: Hello, how are you?
        /// </param>
        /// <param name="voiceName">
        /// The voice to use for the speech. Use the `id` of a voice returned by `GET /v1/voices`.<br/>
        /// Example: Elon Musk
        /// </param>
        /// <param name="language">
        /// Spoken language. Use a canonical lowercase language name, or auto to detect the language from the text. Defaults to auto.<br/>
        /// Default Value: auto<br/>
        /// Example: spanish
        /// </param>
        /// <param name="speed">
        /// Speech speed multiplier, from 0.75 to 1.30 inclusive. Defaults to 1 (normal speed).<br/>
        /// Default Value: 1<br/>
        /// Example: 1.15F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiVoiceGeneratorCreateAudioRequestStyle(
            string prompt,
            global::MagicHour.AiVoiceGeneratorCreateAudioRequestStyleVoiceName voiceName,
            global::MagicHour.AiVoiceGeneratorCreateAudioRequestStyleLanguage? language,
            double? speed)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.VoiceName = voiceName;
            this.Language = language;
            this.Speed = speed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiVoiceGeneratorCreateAudioRequestStyle" /> class.
        /// </summary>
        public AiVoiceGeneratorCreateAudioRequestStyle()
        {
        }

    }
}