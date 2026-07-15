
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Style settings for the upscale. Use `mode` (`"preserve"`, `"balanced"`, or `"creative"`). Defaults to `"balanced"`.<br/>
    /// Default Value: {}
    /// </summary>
    public sealed partial class AiImageUpscalerCreateImageRequestStyle
    {
        /// <summary>
        /// The upscaling mode. `"preserve"` uses the fast pro pipeline (1× credit multiplier). `"balanced"` and `"creative"` use the creative pipeline (2× credit multiplier). `"pro"` is deprecated and maps to `"preserve"`. Defaults to `"balanced"`.<br/>
        /// Example: balanced
        /// </summary>
        /// <example>balanced</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.AiImageUpscalerCreateImageRequestStyleModeJsonConverter))]
        public global::MagicHour.AiImageUpscalerCreateImageRequestStyleMode? Mode { get; set; }

        /// <summary>
        /// A prompt to guide the final image. Only used when mode is `creative`.
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
        /// The upscaling mode. `"preserve"` uses the fast pro pipeline (1× credit multiplier). `"balanced"` and `"creative"` use the creative pipeline (2× credit multiplier). `"pro"` is deprecated and maps to `"preserve"`. Defaults to `"balanced"`.<br/>
        /// Example: balanced
        /// </param>
        /// <param name="prompt">
        /// A prompt to guide the final image. Only used when mode is `creative`.
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