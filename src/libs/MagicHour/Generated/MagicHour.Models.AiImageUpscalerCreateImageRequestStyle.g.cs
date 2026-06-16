
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Style settings for the upscale. Use `mode` to select between `"pro"` (faster, no enhancement required) and `"creative"` (defaults to `"Balanced"` enhancement). Defaults to `"creative"`.
    /// </summary>
    public sealed partial class AiImageUpscalerCreateImageRequestStyle
    {
        /// <summary>
        /// The upscaling mode. `"pro"` is faster and does not require `enhancement`. `"creative"` requires `enhancement`. Defaults to `"creative"`.<br/>
        /// Example: creative
        /// </summary>
        /// <example>creative</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.AiImageUpscalerCreateImageRequestStyleModeJsonConverter))]
        public global::MagicHour.AiImageUpscalerCreateImageRequestStyleMode? Mode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enhancement")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.AiImageUpscalerCreateImageRequestStyleEnhancementJsonConverter))]
        public global::MagicHour.AiImageUpscalerCreateImageRequestStyleEnhancement? Enhancement { get; set; }

        /// <summary>
        /// A prompt to guide the final image. This value is ignored if `enhancement` is not Creative
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
        /// The upscaling mode. `"pro"` is faster and does not require `enhancement`. `"creative"` requires `enhancement`. Defaults to `"creative"`.<br/>
        /// Example: creative
        /// </param>
        /// <param name="enhancement"></param>
        /// <param name="prompt">
        /// A prompt to guide the final image. This value is ignored if `enhancement` is not Creative
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiImageUpscalerCreateImageRequestStyle(
            global::MagicHour.AiImageUpscalerCreateImageRequestStyleMode? mode,
            global::MagicHour.AiImageUpscalerCreateImageRequestStyleEnhancement? enhancement,
            string? prompt)
        {
            this.Mode = mode;
            this.Enhancement = enhancement;
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