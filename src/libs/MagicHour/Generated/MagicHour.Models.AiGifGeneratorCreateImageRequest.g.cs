
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AiGifGeneratorCreateImageRequest
    {
        /// <summary>
        /// Give your gif a custom name for easy identification.<br/>
        /// Default Value: Ai Gif - dateTime<br/>
        /// Example: My Ai Gif gif
        /// </summary>
        /// <example>My Ai Gif gif</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.AiGifGeneratorCreateImageRequestStyle Style { get; set; }

        /// <summary>
        /// The output file format for the generated animation.<br/>
        /// Default Value: gif<br/>
        /// Example: gif
        /// </summary>
        /// <example>gif</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.AiGifGeneratorCreateImageRequestOutputFormatJsonConverter))]
        public global::MagicHour.AiGifGeneratorCreateImageRequestOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiGifGeneratorCreateImageRequest" /> class.
        /// </summary>
        /// <param name="style"></param>
        /// <param name="name">
        /// Give your gif a custom name for easy identification.<br/>
        /// Default Value: Ai Gif - dateTime<br/>
        /// Example: My Ai Gif gif
        /// </param>
        /// <param name="outputFormat">
        /// The output file format for the generated animation.<br/>
        /// Default Value: gif<br/>
        /// Example: gif
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiGifGeneratorCreateImageRequest(
            global::MagicHour.AiGifGeneratorCreateImageRequestStyle style,
            string? name,
            global::MagicHour.AiGifGeneratorCreateImageRequestOutputFormat? outputFormat)
        {
            this.Name = name;
            this.Style = style ?? throw new global::System.ArgumentNullException(nameof(style));
            this.OutputFormat = outputFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiGifGeneratorCreateImageRequest" /> class.
        /// </summary>
        public AiGifGeneratorCreateImageRequest()
        {
        }

    }
}