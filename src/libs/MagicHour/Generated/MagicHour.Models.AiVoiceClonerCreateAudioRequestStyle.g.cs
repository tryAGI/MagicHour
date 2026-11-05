
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AiVoiceClonerCreateAudioRequestStyle
    {
        /// <summary>
        /// Spoken language. Use a canonical lowercase language name, or auto to detect the language from the text. Defaults to auto.<br/>
        /// Default Value: auto<br/>
        /// Example: spanish
        /// </summary>
        /// <example>spanish</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.AiVoiceClonerCreateAudioRequestStyleLanguageJsonConverter))]
        public global::MagicHour.AiVoiceClonerCreateAudioRequestStyleLanguage? Language { get; set; }

        /// <summary>
        /// Speech speed multiplier, from 0.75 to 1.30 inclusive. Defaults to 1 (normal speed).<br/>
        /// Default Value: 1<br/>
        /// Example: 1.15F
        /// </summary>
        /// <example>1.15F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Text used to generate speech from the cloned voice. The character limit is 5000 characters.<br/>
        /// Example: Hello, this is my cloned voice.
        /// </summary>
        /// <example>Hello, this is my cloned voice.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiVoiceClonerCreateAudioRequestStyle" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Text used to generate speech from the cloned voice. The character limit is 5000 characters.<br/>
        /// Example: Hello, this is my cloned voice.
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
        public AiVoiceClonerCreateAudioRequestStyle(
            string prompt,
            global::MagicHour.AiVoiceClonerCreateAudioRequestStyleLanguage? language,
            double? speed)
        {
            this.Language = language;
            this.Speed = speed;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiVoiceClonerCreateAudioRequestStyle" /> class.
        /// </summary>
        public AiVoiceClonerCreateAudioRequestStyle()
        {
        }

    }
}