
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Optional style settings for the upscale. If `style` or `mode` is omitted, `mode` defaults to `balanced`.
    /// </summary>
    public sealed partial class AiImageUpscalerCreateImageRequestStyle
    {
        /// <summary>
        /// The upscaling mode. `preserve` keeps the image faithful using the v2 pipeline with a 1x credit multiplier. `balanced` applies natural improvements using the v1 pipeline with creativity set to 0.2 and a 2x credit multiplier. `creative` reimagines details using the v1 pipeline with creativity set to 0.35, accepts `prompt`, and has a 2x credit multiplier. `pro` is deprecated and maps to `preserve`. Defaults to `balanced`.<br/>
        /// Default Value: balanced<br/>
        /// Example: balanced
        /// </summary>
        /// <example>balanced</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.AiImageUpscalerCreateImageRequestStyleModeJsonConverter))]
        public global::MagicHour.AiImageUpscalerCreateImageRequestStyleMode? Mode { get; set; }

        /// <summary>
        /// Deprecated. Use `mode` instead. `Resemblance` maps to `preserve`, `Balanced` maps to `balanced`, and `Creative` maps to `creative`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enhancement")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.AiImageUpscalerCreateImageRequestStyleEnhancementJsonConverter))]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::MagicHour.AiImageUpscalerCreateImageRequestStyleEnhancement? Enhancement { get; set; }

        /// <summary>
        /// A prompt to guide the final image. This value is used only when the resolved mode is `creative`; it is ignored in `preserve` and `balanced` modes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiImageUpscalerCreateImageRequestStyle" /> class.
        /// </summary>
        /// <param name="mode">
        /// The upscaling mode. `preserve` keeps the image faithful using the v2 pipeline with a 1x credit multiplier. `balanced` applies natural improvements using the v1 pipeline with creativity set to 0.2 and a 2x credit multiplier. `creative` reimagines details using the v1 pipeline with creativity set to 0.35, accepts `prompt`, and has a 2x credit multiplier. `pro` is deprecated and maps to `preserve`. Defaults to `balanced`.<br/>
        /// Default Value: balanced<br/>
        /// Example: balanced
        /// </param>
        /// <param name="prompt">
        /// A prompt to guide the final image. This value is used only when the resolved mode is `creative`; it is ignored in `preserve` and `balanced` modes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiImageUpscalerCreateImageRequestStyle(
            global::MagicHour.AiImageUpscalerCreateImageRequestStyleMode? mode,
            string? prompt)
        {
            this.Mode = mode;
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiImageUpscalerCreateImageRequestStyle" /> class.
        /// </summary>
        public AiImageUpscalerCreateImageRequestStyle()
        {
        }

    }
}