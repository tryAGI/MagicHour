
#nullable enable

namespace MagicHour
{
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
    public sealed partial class AutoSubtitleGeneratorCreateVideoRequestStyle
    {
        /// <summary>
        /// Preset subtitle templates. Please visit https://magichour.ai/create/auto-subtitle-generator to see the style of the existing templates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.AutoSubtitleGeneratorCreateVideoRequestStyleTemplateJsonConverter))]
        public global::MagicHour.AutoSubtitleGeneratorCreateVideoRequestStyleTemplate? Template { get; set; }

        /// <summary>
        /// Custom subtitle configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_config")]
        public global::MagicHour.AutoSubtitleGeneratorCreateVideoRequestStyleCustomConfig? CustomConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSubtitleGeneratorCreateVideoRequestStyle" /> class.
        /// </summary>
        /// <param name="template">
        /// Preset subtitle templates. Please visit https://magichour.ai/create/auto-subtitle-generator to see the style of the existing templates.
        /// </param>
        /// <param name="customConfig">
        /// Custom subtitle configuration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSubtitleGeneratorCreateVideoRequestStyle(
            global::MagicHour.AutoSubtitleGeneratorCreateVideoRequestStyleTemplate? template,
            global::MagicHour.AutoSubtitleGeneratorCreateVideoRequestStyleCustomConfig? customConfig)
        {
            this.Template = template;
            this.CustomConfig = customConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSubtitleGeneratorCreateVideoRequestStyle" /> class.
        /// </summary>
        public AutoSubtitleGeneratorCreateVideoRequestStyle()
        {
        }

    }
}