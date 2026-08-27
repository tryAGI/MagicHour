
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AiMemeGeneratorCreateImageRequestStyle
    {
        /// <summary>
        /// The topic of the meme.<br/>
        /// Example: When the code finally works
        /// </summary>
        /// <example>When the code finally works</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("topic")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Topic { get; set; }

        /// <summary>
        /// To use our templates, pass in one of the enum values.<br/>
        /// Example: Drake Hotline Bling
        /// </summary>
        /// <example>Drake Hotline Bling</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("template")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.AiMemeGeneratorCreateImageRequestStyleTemplateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.AiMemeGeneratorCreateImageRequestStyleTemplate Template { get; set; }

        /// <summary>
        /// Whether to search the web for meme content.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("searchWeb")]
        public bool? SearchWeb { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiMemeGeneratorCreateImageRequestStyle" /> class.
        /// </summary>
        /// <param name="topic">
        /// The topic of the meme.<br/>
        /// Example: When the code finally works
        /// </param>
        /// <param name="template">
        /// To use our templates, pass in one of the enum values.<br/>
        /// Example: Drake Hotline Bling
        /// </param>
        /// <param name="searchWeb">
        /// Whether to search the web for meme content.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiMemeGeneratorCreateImageRequestStyle(
            string topic,
            global::MagicHour.AiMemeGeneratorCreateImageRequestStyleTemplate template,
            bool? searchWeb)
        {
            this.Topic = topic ?? throw new global::System.ArgumentNullException(nameof(topic));
            this.Template = template;
            this.SearchWeb = searchWeb;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiMemeGeneratorCreateImageRequestStyle" /> class.
        /// </summary>
        public AiMemeGeneratorCreateImageRequestStyle()
        {
        }

    }
}