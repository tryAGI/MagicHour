
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AiVoiceClonerCreateAudioRequest
    {
        /// <summary>
        /// Give your audio a custom name for easy identification.<br/>
        /// Default Value: Voice Cloner - dateTime<br/>
        /// Example: My Voice Cloner audio
        /// </summary>
        /// <example>My Voice Cloner audio</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Provide the assets for voice cloning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.AiVoiceClonerCreateAudioRequestAssets Assets { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.AiVoiceClonerCreateAudioRequestStyle Style { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiVoiceClonerCreateAudioRequest" /> class.
        /// </summary>
        /// <param name="assets">
        /// Provide the assets for voice cloning.
        /// </param>
        /// <param name="style"></param>
        /// <param name="name">
        /// Give your audio a custom name for easy identification.<br/>
        /// Default Value: Voice Cloner - dateTime<br/>
        /// Example: My Voice Cloner audio
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiVoiceClonerCreateAudioRequest(
            global::MagicHour.AiVoiceClonerCreateAudioRequestAssets assets,
            global::MagicHour.AiVoiceClonerCreateAudioRequestStyle style,
            string? name)
        {
            this.Name = name;
            this.Assets = assets ?? throw new global::System.ArgumentNullException(nameof(assets));
            this.Style = style ?? throw new global::System.ArgumentNullException(nameof(style));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiVoiceClonerCreateAudioRequest" /> class.
        /// </summary>
        public AiVoiceClonerCreateAudioRequest()
        {
        }

    }
}