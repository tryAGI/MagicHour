
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AiMusicGeneratorCreateAudioRequest
    {
        /// <summary>
        /// Give your audio a custom name for easy identification.<br/>
        /// Default Value: AI Music Generator<br/>
        /// Example: My Music Generator audio
        /// </summary>
        /// <example>My Music Generator audio</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Requested track duration in seconds, from 15 to 300. Determines credits charged.<br/>
        /// Example: 120
        /// </summary>
        /// <example>120</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Duration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.AiMusicGeneratorCreateAudioRequestStyle Style { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiMusicGeneratorCreateAudioRequest" /> class.
        /// </summary>
        /// <param name="duration">
        /// Requested track duration in seconds, from 15 to 300. Determines credits charged.<br/>
        /// Example: 120
        /// </param>
        /// <param name="style"></param>
        /// <param name="name">
        /// Give your audio a custom name for easy identification.<br/>
        /// Default Value: AI Music Generator<br/>
        /// Example: My Music Generator audio
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiMusicGeneratorCreateAudioRequest(
            int duration,
            global::MagicHour.AiMusicGeneratorCreateAudioRequestStyle style,
            string? name)
        {
            this.Name = name;
            this.Duration = duration;
            this.Style = style ?? throw new global::System.ArgumentNullException(nameof(style));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiMusicGeneratorCreateAudioRequest" /> class.
        /// </summary>
        public AiMusicGeneratorCreateAudioRequest()
        {
        }

    }
}