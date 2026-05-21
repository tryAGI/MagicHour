
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AiHeadshotGeneratorCreateImageRequestStyle
    {
        /// <summary>
        /// Prompt used to guide the style of your headshot. We recommend omitting the prompt unless you want to customize your headshot. You can visit [AI headshot generator](https://magichour.ai/create/ai-headshot-generator) to view an example of a good prompt used for our 'Professional' style.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiHeadshotGeneratorCreateImageRequestStyle" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Prompt used to guide the style of your headshot. We recommend omitting the prompt unless you want to customize your headshot. You can visit [AI headshot generator](https://magichour.ai/create/ai-headshot-generator) to view an example of a good prompt used for our 'Professional' style.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiHeadshotGeneratorCreateImageRequestStyle(
            string? prompt)
        {
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiHeadshotGeneratorCreateImageRequestStyle" /> class.
        /// </summary>
        public AiHeadshotGeneratorCreateImageRequestStyle()
        {
        }

    }
}