
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AutoSubtitleGeneratorCreateVideoRequest
    {
        /// <summary>
        /// Give your video a custom name for easy identification.<br/>
        /// Default Value: Auto Subtitle - dateTime<br/>
        /// Example: My Auto Subtitle video
        /// </summary>
        /// <example>My Auto Subtitle video</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Start time of your clip (seconds). Must be ≥ 0.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float StartSeconds { get; set; }

        /// <summary>
        /// End time of your clip (seconds). Must be greater than start_seconds.<br/>
        /// Example: 15
        /// </summary>
        /// <example>15</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float EndSeconds { get; set; }

        /// <summary>
        /// Provide the assets for auto subtitle generator
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.AutoSubtitleGeneratorCreateVideoRequestAssets Assets { get; set; }

        /// <summary>
        /// Style of the subtitle. At least one of `.style.template` or `.style.custom_config` must be provided. <br/>
        /// * If only `.style.template` is provided, default values for the template will be used.<br/>
        /// * If both are provided, the fields in `.style.custom_config` will be used to overwrite the fields in `.style.template`.<br/>
        /// * If only `.style.custom_config` is provided, then all fields in `.style.custom_config` will be used.<br/>
        /// To use custom config only, the following `custom_config` params are required:<br/>
        /// * `.style.custom_config.font`<br/>
        /// * `.style.custom_config.text_color`<br/>
        /// * `.style.custom_config.vertical_position`<br/>
        /// * `.style.custom_config.horizontal_position`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.AutoSubtitleGeneratorCreateVideoRequestStyle Style { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSubtitleGeneratorCreateVideoRequest" /> class.
        /// </summary>
        /// <param name="startSeconds">
        /// Start time of your clip (seconds). Must be ≥ 0.<br/>
        /// Example: 0
        /// </param>
        /// <param name="endSeconds">
        /// End time of your clip (seconds). Must be greater than start_seconds.<br/>
        /// Example: 15
        /// </param>
        /// <param name="assets">
        /// Provide the assets for auto subtitle generator
        /// </param>
        /// <param name="style">
        /// Style of the subtitle. At least one of `.style.template` or `.style.custom_config` must be provided. <br/>
        /// * If only `.style.template` is provided, default values for the template will be used.<br/>
        /// * If both are provided, the fields in `.style.custom_config` will be used to overwrite the fields in `.style.template`.<br/>
        /// * If only `.style.custom_config` is provided, then all fields in `.style.custom_config` will be used.<br/>
        /// To use custom config only, the following `custom_config` params are required:<br/>
        /// * `.style.custom_config.font`<br/>
        /// * `.style.custom_config.text_color`<br/>
        /// * `.style.custom_config.vertical_position`<br/>
        /// * `.style.custom_config.horizontal_position`
        /// </param>
        /// <param name="name">
        /// Give your video a custom name for easy identification.<br/>
        /// Default Value: Auto Subtitle - dateTime<br/>
        /// Example: My Auto Subtitle video
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSubtitleGeneratorCreateVideoRequest(
            float startSeconds,
            float endSeconds,
            global::MagicHour.AutoSubtitleGeneratorCreateVideoRequestAssets assets,
            global::MagicHour.AutoSubtitleGeneratorCreateVideoRequestStyle style,
            string? name)
        {
            this.Name = name;
            this.StartSeconds = startSeconds;
            this.EndSeconds = endSeconds;
            this.Assets = assets ?? throw new global::System.ArgumentNullException(nameof(assets));
            this.Style = style ?? throw new global::System.ArgumentNullException(nameof(style));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSubtitleGeneratorCreateVideoRequest" /> class.
        /// </summary>
        public AutoSubtitleGeneratorCreateVideoRequest()
        {
        }
    }
}