
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AiMemeGeneratorCreateImageRequest
    {
        /// <summary>
        /// The name of the meme.<br/>
        /// Example: My Funny Meme
        /// </summary>
        /// <example>My Funny Meme</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.AiMemeGeneratorCreateImageRequestStyle Style { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiMemeGeneratorCreateImageRequest" /> class.
        /// </summary>
        /// <param name="style"></param>
        /// <param name="name">
        /// The name of the meme.<br/>
        /// Example: My Funny Meme
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiMemeGeneratorCreateImageRequest(
            global::MagicHour.AiMemeGeneratorCreateImageRequestStyle style,
            string? name)
        {
            this.Name = name;
            this.Style = style ?? throw new global::System.ArgumentNullException(nameof(style));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiMemeGeneratorCreateImageRequest" /> class.
        /// </summary>
        public AiMemeGeneratorCreateImageRequest()
        {
        }

    }
}