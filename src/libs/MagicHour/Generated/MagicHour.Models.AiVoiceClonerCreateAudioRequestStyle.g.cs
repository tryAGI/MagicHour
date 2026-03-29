
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AiVoiceClonerCreateAudioRequestStyle
    {
        /// <summary>
        /// Text used to generate speech from the cloned voice. The character limit is 1000 characters.<br/>
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
        /// Text used to generate speech from the cloned voice. The character limit is 1000 characters.<br/>
        /// Example: Hello, this is my cloned voice.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiVoiceClonerCreateAudioRequestStyle(
            string prompt)
        {
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