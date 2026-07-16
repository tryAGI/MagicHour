
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CharacterReplaceCreateVideoRequest
    {
        /// <summary>
        /// Give your video a custom name for easy identification.<br/>
        /// Default Value: Character Replace - dateTime<br/>
        /// Example: My Character Replace video
        /// </summary>
        /// <example>My Character Replace video</example>
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
        /// Output video resolution. Defaults to 480p, the lowest resolution available on your plan.<br/>
        /// Example: 720p
        /// </summary>
        /// <example>720p</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.CharacterReplaceCreateVideoRequestResolutionJsonConverter))]
        public global::MagicHour.CharacterReplaceCreateVideoRequestResolution? Resolution { get; set; }

        /// <summary>
        /// Source video and reference character image for the job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.CharacterReplaceCreateVideoRequestAssets Assets { get; set; }

        /// <summary>
        /// Optional style controls for replace vs animate mode and subject selection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        public global::MagicHour.CharacterReplaceCreateVideoRequestStyle? Style { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterReplaceCreateVideoRequest" /> class.
        /// </summary>
        /// <param name="endSeconds">
        /// End time of your clip (seconds). Must be greater than start_seconds.<br/>
        /// Example: 15
        /// </param>
        /// <param name="assets">
        /// Source video and reference character image for the job.
        /// </param>
        /// <param name="name">
        /// Give your video a custom name for easy identification.<br/>
        /// Default Value: Character Replace - dateTime<br/>
        /// Example: My Character Replace video
        /// </param>
        /// <param name="startSeconds">
        /// Start time of your clip (seconds). Must be ≥ 0.<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="resolution">
        /// Output video resolution. Defaults to 480p, the lowest resolution available on your plan.<br/>
        /// Example: 720p
        /// </param>
        /// <param name="style">
        /// Optional style controls for replace vs animate mode and subject selection.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CharacterReplaceCreateVideoRequest(
            float endSeconds,
            global::MagicHour.CharacterReplaceCreateVideoRequestAssets assets,
            string? name,
            float? startSeconds,
            global::MagicHour.CharacterReplaceCreateVideoRequestResolution? resolution,
            global::MagicHour.CharacterReplaceCreateVideoRequestStyle? style)
        {
            this.Name = name;
            this.StartSeconds = startSeconds;
            this.EndSeconds = endSeconds;
            this.Resolution = resolution;
            this.Assets = assets ?? throw new global::System.ArgumentNullException(nameof(assets));
            this.Style = style;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterReplaceCreateVideoRequest" /> class.
        /// </summary>
        public CharacterReplaceCreateVideoRequest()
        {
        }

    }
}