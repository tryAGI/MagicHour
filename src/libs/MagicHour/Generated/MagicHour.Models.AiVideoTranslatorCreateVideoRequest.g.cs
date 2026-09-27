
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AiVideoTranslatorCreateVideoRequest
    {
        /// <summary>
        /// Give your video a custom name for easy identification.<br/>
        /// Default Value: Video Translator - dateTime<br/>
        /// Example: My Video Translator video
        /// </summary>
        /// <example>My Video Translator video</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Start time of your clip (seconds). Must be ≥ 0.<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_seconds")]
        public float? StartSeconds { get; set; }

        /// <summary>
        /// End time of your clip (seconds). Must be greater than start_seconds. The clip must be 1-30 seconds long.<br/>
        /// Example: 15
        /// </summary>
        /// <example>15</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float EndSeconds { get; set; }

        /// <summary>
        /// Language to translate the video's speech into.<br/>
        /// Example: Spanish
        /// </summary>
        /// <example>Spanish</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.AiVideoTranslatorCreateVideoRequestTargetLanguageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.AiVideoTranslatorCreateVideoRequestTargetLanguage TargetLanguage { get; set; }

        /// <summary>
        /// Output video resolution. Defaults to 480p. 720p and 1080p require a paid plan.<br/>
        /// Example: 720p
        /// </summary>
        /// <example>720p</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.AiVideoTranslatorCreateVideoRequestResolutionJsonConverter))]
        public global::MagicHour.AiVideoTranslatorCreateVideoRequestResolution? Resolution { get; set; }

        /// <summary>
        /// Source video for the translation job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.AiVideoTranslatorCreateVideoRequestAssets Assets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiVideoTranslatorCreateVideoRequest" /> class.
        /// </summary>
        /// <param name="endSeconds">
        /// End time of your clip (seconds). Must be greater than start_seconds. The clip must be 1-30 seconds long.<br/>
        /// Example: 15
        /// </param>
        /// <param name="targetLanguage">
        /// Language to translate the video's speech into.<br/>
        /// Example: Spanish
        /// </param>
        /// <param name="assets">
        /// Source video for the translation job.
        /// </param>
        /// <param name="name">
        /// Give your video a custom name for easy identification.<br/>
        /// Default Value: Video Translator - dateTime<br/>
        /// Example: My Video Translator video
        /// </param>
        /// <param name="startSeconds">
        /// Start time of your clip (seconds). Must be ≥ 0.<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="resolution">
        /// Output video resolution. Defaults to 480p. 720p and 1080p require a paid plan.<br/>
        /// Example: 720p
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiVideoTranslatorCreateVideoRequest(
            float endSeconds,
            global::MagicHour.AiVideoTranslatorCreateVideoRequestTargetLanguage targetLanguage,
            global::MagicHour.AiVideoTranslatorCreateVideoRequestAssets assets,
            string? name,
            float? startSeconds,
            global::MagicHour.AiVideoTranslatorCreateVideoRequestResolution? resolution)
        {
            this.Name = name;
            this.StartSeconds = startSeconds;
            this.EndSeconds = endSeconds;
            this.TargetLanguage = targetLanguage;
            this.Resolution = resolution;
            this.Assets = assets ?? throw new global::System.ArgumentNullException(nameof(assets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiVideoTranslatorCreateVideoRequest" /> class.
        /// </summary>
        public AiVideoTranslatorCreateVideoRequest()
        {
        }

    }
}