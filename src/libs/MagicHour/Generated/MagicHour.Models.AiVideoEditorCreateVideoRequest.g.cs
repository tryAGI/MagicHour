
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AiVideoEditorCreateVideoRequest
    {
        /// <summary>
        /// Give your video a custom name for easy identification.<br/>
        /// Default Value: Video Editor - dateTime<br/>
        /// Example: My Video Editor video
        /// </summary>
        /// <example>My Video Editor video</example>
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
        /// End time of your clip in seconds. Must be greater than `start_seconds`. Duration must be between 3 and 10 seconds.<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float EndSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.AiVideoEditorCreateVideoRequestStyle Style { get; set; }

        /// <summary>
        /// Provide the assets for video editing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.AiVideoEditorCreateVideoRequestAssets Assets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiVideoEditorCreateVideoRequest" /> class.
        /// </summary>
        /// <param name="endSeconds">
        /// End time of your clip in seconds. Must be greater than `start_seconds`. Duration must be between 3 and 10 seconds.<br/>
        /// Example: 5
        /// </param>
        /// <param name="style"></param>
        /// <param name="assets">
        /// Provide the assets for video editing.
        /// </param>
        /// <param name="name">
        /// Give your video a custom name for easy identification.<br/>
        /// Default Value: Video Editor - dateTime<br/>
        /// Example: My Video Editor video
        /// </param>
        /// <param name="startSeconds">
        /// Start time of your clip (seconds). Must be ≥ 0.<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiVideoEditorCreateVideoRequest(
            float endSeconds,
            global::MagicHour.AiVideoEditorCreateVideoRequestStyle style,
            global::MagicHour.AiVideoEditorCreateVideoRequestAssets assets,
            string? name,
            float? startSeconds)
        {
            this.Name = name;
            this.StartSeconds = startSeconds;
            this.EndSeconds = endSeconds;
            this.Style = style ?? throw new global::System.ArgumentNullException(nameof(style));
            this.Assets = assets ?? throw new global::System.ArgumentNullException(nameof(assets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiVideoEditorCreateVideoRequest" /> class.
        /// </summary>
        public AiVideoEditorCreateVideoRequest()
        {
        }

    }
}