
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// The art style to use for image generation.
    /// </summary>
    public sealed partial class AiImageGeneratorCreateImageRequestStyle
    {
        /// <summary>
        /// The prompt used for the image(s).<br/>
        /// Example: Cool image
        /// </summary>
        /// <example>Cool image</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The art style to use for image generation. Defaults to 'general' if not provided.<br/>
        /// Default Value: general<br/>
        /// Example: ai-anime-generator
        /// </summary>
        /// <example>ai-anime-generator</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.AiImageGeneratorCreateImageRequestStyleToolJsonConverter))]
        public global::MagicHour.AiImageGeneratorCreateImageRequestStyleTool? Tool { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiImageGeneratorCreateImageRequestStyle" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt used for the image(s).<br/>
        /// Example: Cool image
        /// </param>
        /// <param name="tool">
        /// The art style to use for image generation. Defaults to 'general' if not provided.<br/>
        /// Default Value: general<br/>
        /// Example: ai-anime-generator
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiImageGeneratorCreateImageRequestStyle(
            string prompt,
            global::MagicHour.AiImageGeneratorCreateImageRequestStyleTool? tool)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Tool = tool;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiImageGeneratorCreateImageRequestStyle" /> class.
        /// </summary>
        public AiImageGeneratorCreateImageRequestStyle()
        {
        }
    }
}