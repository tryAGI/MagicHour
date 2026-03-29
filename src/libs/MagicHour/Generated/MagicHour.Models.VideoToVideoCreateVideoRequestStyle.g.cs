
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoToVideoCreateVideoRequestStyle
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("art_style")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.VideoToVideoCreateVideoRequestStyleArtStyleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.VideoToVideoCreateVideoRequestStyleArtStyle ArtStyle { get; set; }

        /// <summary>
        /// * `v1` - more detail, closer prompt adherence, and frame-by-frame previews.<br/>
        /// * `v2` - faster, more consistent, and less noisy.<br/>
        /// * `default` - use the default version for the selected art style.<br/>
        /// Default Value: default<br/>
        /// Example: default
        /// </summary>
        /// <example>default</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.VideoToVideoCreateVideoRequestStyleVersionJsonConverter))]
        public global::MagicHour.VideoToVideoCreateVideoRequestStyleVersion? Version { get; set; }

        /// <summary>
        /// * `default` - Use the default recommended prompt for the art style.<br/>
        /// * `custom` - Only use the prompt passed in the API. Note: for v1, lora prompt will still be auto added to apply the art style properly.<br/>
        /// * `append_default` - Add the default recommended prompt to the end of the prompt passed in the API.<br/>
        /// Default Value: default<br/>
        /// Example: default
        /// </summary>
        /// <example>default</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.VideoToVideoCreateVideoRequestStylePromptTypeJsonConverter))]
        public global::MagicHour.VideoToVideoCreateVideoRequestStylePromptType? PromptType { get; set; }

        /// <summary>
        /// The prompt used for the video. Prompt is required if `prompt_type` is `custom` or `append_default`. If `prompt_type` is `default`, then the `prompt` value passed will be ignored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// * `Dreamshaper` - a good all-around model that works for both animations as well as realism.<br/>
        /// * `Absolute Reality` - better at realism, but you'll often get similar results with Dreamshaper as well.<br/>
        /// * `Flat 2D Anime` - best for a flat illustration style that's common in most anime.<br/>
        /// * `default` - use the default recommended model for the selected art style.<br/>
        /// Default Value: default<br/>
        /// Example: default
        /// </summary>
        /// <example>default</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.VideoToVideoCreateVideoRequestStyleModelJsonConverter))]
        public global::MagicHour.VideoToVideoCreateVideoRequestStyleModel? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoToVideoCreateVideoRequestStyle" /> class.
        /// </summary>
        /// <param name="artStyle"></param>
        /// <param name="version">
        /// * `v1` - more detail, closer prompt adherence, and frame-by-frame previews.<br/>
        /// * `v2` - faster, more consistent, and less noisy.<br/>
        /// * `default` - use the default version for the selected art style.<br/>
        /// Default Value: default<br/>
        /// Example: default
        /// </param>
        /// <param name="promptType">
        /// * `default` - Use the default recommended prompt for the art style.<br/>
        /// * `custom` - Only use the prompt passed in the API. Note: for v1, lora prompt will still be auto added to apply the art style properly.<br/>
        /// * `append_default` - Add the default recommended prompt to the end of the prompt passed in the API.<br/>
        /// Default Value: default<br/>
        /// Example: default
        /// </param>
        /// <param name="prompt">
        /// The prompt used for the video. Prompt is required if `prompt_type` is `custom` or `append_default`. If `prompt_type` is `default`, then the `prompt` value passed will be ignored.
        /// </param>
        /// <param name="model">
        /// * `Dreamshaper` - a good all-around model that works for both animations as well as realism.<br/>
        /// * `Absolute Reality` - better at realism, but you'll often get similar results with Dreamshaper as well.<br/>
        /// * `Flat 2D Anime` - best for a flat illustration style that's common in most anime.<br/>
        /// * `default` - use the default recommended model for the selected art style.<br/>
        /// Default Value: default<br/>
        /// Example: default
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoToVideoCreateVideoRequestStyle(
            global::MagicHour.VideoToVideoCreateVideoRequestStyleArtStyle artStyle,
            global::MagicHour.VideoToVideoCreateVideoRequestStyleVersion? version,
            global::MagicHour.VideoToVideoCreateVideoRequestStylePromptType? promptType,
            string? prompt,
            global::MagicHour.VideoToVideoCreateVideoRequestStyleModel? model)
        {
            this.ArtStyle = artStyle;
            this.Version = version;
            this.PromptType = promptType;
            this.Prompt = prompt;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoToVideoCreateVideoRequestStyle" /> class.
        /// </summary>
        public VideoToVideoCreateVideoRequestStyle()
        {
        }
    }
}