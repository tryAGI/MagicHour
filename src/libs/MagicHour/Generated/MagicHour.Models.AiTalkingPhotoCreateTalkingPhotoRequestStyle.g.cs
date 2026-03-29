
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Attributes used to dictate the style of the output
    /// </summary>
    public sealed partial class AiTalkingPhotoCreateTalkingPhotoRequestStyle
    {
        /// <summary>
        /// Controls overall motion style.<br/>
        /// * `realistic` - Maintains likeness well, high quality, and reliable.<br/>
        /// * `prompted` - Slightly lower likeness; allows option to prompt scene.<br/>
        /// **Deprecated values (maintained for backward compatibility):**<br/>
        /// * `pro` - Deprecated: use `realistic`<br/>
        /// * `standard` - Deprecated: use `prompted`<br/>
        /// * `stable` - Deprecated: use `realistic`<br/>
        /// * `expressive` - Deprecated: use `prompted`<br/>
        /// Default Value: realistic<br/>
        /// Example: realistic
        /// </summary>
        /// <example>realistic</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.AiTalkingPhotoCreateTalkingPhotoRequestStyleGenerationModeJsonConverter))]
        public global::MagicHour.AiTalkingPhotoCreateTalkingPhotoRequestStyleGenerationMode? GenerationMode { get; set; }

        /// <summary>
        /// A text prompt to guide the generation. Only applicable when generation_mode is `prompted`.<br/>
        /// This field is ignored for other modes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiTalkingPhotoCreateTalkingPhotoRequestStyle" /> class.
        /// </summary>
        /// <param name="generationMode">
        /// Controls overall motion style.<br/>
        /// * `realistic` - Maintains likeness well, high quality, and reliable.<br/>
        /// * `prompted` - Slightly lower likeness; allows option to prompt scene.<br/>
        /// **Deprecated values (maintained for backward compatibility):**<br/>
        /// * `pro` - Deprecated: use `realistic`<br/>
        /// * `standard` - Deprecated: use `prompted`<br/>
        /// * `stable` - Deprecated: use `realistic`<br/>
        /// * `expressive` - Deprecated: use `prompted`<br/>
        /// Default Value: realistic<br/>
        /// Example: realistic
        /// </param>
        /// <param name="prompt">
        /// A text prompt to guide the generation. Only applicable when generation_mode is `prompted`.<br/>
        /// This field is ignored for other modes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiTalkingPhotoCreateTalkingPhotoRequestStyle(
            global::MagicHour.AiTalkingPhotoCreateTalkingPhotoRequestStyleGenerationMode? generationMode,
            string? prompt)
        {
            this.GenerationMode = generationMode;
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiTalkingPhotoCreateTalkingPhotoRequestStyle" /> class.
        /// </summary>
        public AiTalkingPhotoCreateTalkingPhotoRequestStyle()
        {
        }
    }
}