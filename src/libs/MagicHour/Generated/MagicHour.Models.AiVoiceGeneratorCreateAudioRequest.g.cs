
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AiVoiceGeneratorCreateAudioRequest
    {
        /// <summary>
        /// Give your audio a custom name for easy identification.<br/>
        /// Default Value: Voice Generator - dateTime<br/>
        /// Example: My Voice Generator audio
        /// </summary>
        /// <example>My Voice Generator audio</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The content used to generate speech.<br/>
        /// Example: {"prompt":"Hello, how are you?","voice_name":"Elon Musk"}
        /// </summary>
        /// <example>{"prompt":"Hello, how are you?","voice_name":"Elon Musk"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.AiVoiceGeneratorCreateAudioRequestStyle Style { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiVoiceGeneratorCreateAudioRequest" /> class.
        /// </summary>
        /// <param name="style">
        /// The content used to generate speech.<br/>
        /// Example: {"prompt":"Hello, how are you?","voice_name":"Elon Musk"}
        /// </param>
        /// <param name="name">
        /// Give your audio a custom name for easy identification.<br/>
        /// Default Value: Voice Generator - dateTime<br/>
        /// Example: My Voice Generator audio
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiVoiceGeneratorCreateAudioRequest(
            global::MagicHour.AiVoiceGeneratorCreateAudioRequestStyle style,
            string? name)
        {
            this.Name = name;
            this.Style = style ?? throw new global::System.ArgumentNullException(nameof(style));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiVoiceGeneratorCreateAudioRequest" /> class.
        /// </summary>
        public AiVoiceGeneratorCreateAudioRequest()
        {
        }
    }
}