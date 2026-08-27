
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AudioToVideoCreateVideoRequest
    {
        /// <summary>
        /// Give your video a custom name for easy identification.<br/>
        /// Default Value: Audio To Video - dateTime<br/>
        /// Example: My Audio To Video video
        /// </summary>
        /// <example>My Audio To Video video</example>
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
        /// End time of your clip (seconds). Must be greater than start_seconds.<br/>
        /// Example: 15
        /// </summary>
        /// <example>15</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float EndSeconds { get; set; }

        /// <summary>
        /// Output video resolution. Defaults to `720p` on paid tiers and `480p` on free tiers.<br/>
        /// Example: 720p
        /// </summary>
        /// <example>720p</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.AudioToVideoCreateVideoRequestResolutionJsonConverter))]
        public global::MagicHour.AudioToVideoCreateVideoRequestResolution? Resolution { get; set; }

        /// <summary>
        /// Provide the audio file and an optional reference image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.AudioToVideoCreateVideoRequestAssets Assets { get; set; }

        /// <summary>
        /// Attributes used to dictate the style of the output
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        public global::MagicHour.AudioToVideoCreateVideoRequestStyle? Style { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioToVideoCreateVideoRequest" /> class.
        /// </summary>
        /// <param name="endSeconds">
        /// End time of your clip (seconds). Must be greater than start_seconds.<br/>
        /// Example: 15
        /// </param>
        /// <param name="assets">
        /// Provide the audio file and an optional reference image.
        /// </param>
        /// <param name="name">
        /// Give your video a custom name for easy identification.<br/>
        /// Default Value: Audio To Video - dateTime<br/>
        /// Example: My Audio To Video video
        /// </param>
        /// <param name="startSeconds">
        /// Start time of your clip (seconds). Must be ≥ 0.<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="resolution">
        /// Output video resolution. Defaults to `720p` on paid tiers and `480p` on free tiers.<br/>
        /// Example: 720p
        /// </param>
        /// <param name="style">
        /// Attributes used to dictate the style of the output
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioToVideoCreateVideoRequest(
            float endSeconds,
            global::MagicHour.AudioToVideoCreateVideoRequestAssets assets,
            string? name,
            float? startSeconds,
            global::MagicHour.AudioToVideoCreateVideoRequestResolution? resolution,
            global::MagicHour.AudioToVideoCreateVideoRequestStyle? style)
        {
            this.Name = name;
            this.StartSeconds = startSeconds;
            this.EndSeconds = endSeconds;
            this.Resolution = resolution;
            this.Assets = assets ?? throw new global::System.ArgumentNullException(nameof(assets));
            this.Style = style;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioToVideoCreateVideoRequest" /> class.
        /// </summary>
        public AudioToVideoCreateVideoRequest()
        {
        }

    }
}