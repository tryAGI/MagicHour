
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AiMusicGeneratorCreateAudioRequestStyle
    {
        /// <summary>
        /// Describe the song, including genre, mood, and instruments.<br/>
        /// Example: Dreamy synthwave with warm bass and soft vocals
        /// </summary>
        /// <example>Dreamy synthwave with warm bass and soft vocals</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Generate music without vocals. When true, lyrics is ignored.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("instrumental")]
        public bool? Instrumental { get; set; }

        /// <summary>
        /// Custom lyrics. Omit or leave blank for AI-generated lyrics when instrumental is false.<br/>
        /// Example: City lights are fading...
        /// </summary>
        /// <example>City lights are fading...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("lyrics")]
        public string? Lyrics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiMusicGeneratorCreateAudioRequestStyle" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Describe the song, including genre, mood, and instruments.<br/>
        /// Example: Dreamy synthwave with warm bass and soft vocals
        /// </param>
        /// <param name="instrumental">
        /// Generate music without vocals. When true, lyrics is ignored.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="lyrics">
        /// Custom lyrics. Omit or leave blank for AI-generated lyrics when instrumental is false.<br/>
        /// Example: City lights are fading...
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiMusicGeneratorCreateAudioRequestStyle(
            string prompt,
            bool? instrumental,
            string? lyrics)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Instrumental = instrumental;
            this.Lyrics = lyrics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiMusicGeneratorCreateAudioRequestStyle" /> class.
        /// </summary>
        public AiMusicGeneratorCreateAudioRequestStyle()
        {
        }

    }
}