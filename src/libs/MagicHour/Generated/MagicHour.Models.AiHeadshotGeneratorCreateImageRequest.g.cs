
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AiHeadshotGeneratorCreateImageRequest
    {
        /// <summary>
        /// Give your image a custom name for easy identification.<br/>
        /// Default Value: Ai Headshot - dateTime<br/>
        /// Example: My Ai Headshot image
        /// </summary>
        /// <example>My Ai Headshot image</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        public global::MagicHour.AiHeadshotGeneratorCreateImageRequestStyle? Style { get; set; }

        /// <summary>
        /// Provide the assets for headshot photo
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.AiHeadshotGeneratorCreateImageRequestAssets Assets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiHeadshotGeneratorCreateImageRequest" /> class.
        /// </summary>
        /// <param name="assets">
        /// Provide the assets for headshot photo
        /// </param>
        /// <param name="name">
        /// Give your image a custom name for easy identification.<br/>
        /// Default Value: Ai Headshot - dateTime<br/>
        /// Example: My Ai Headshot image
        /// </param>
        /// <param name="style"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiHeadshotGeneratorCreateImageRequest(
            global::MagicHour.AiHeadshotGeneratorCreateImageRequestAssets assets,
            string? name,
            global::MagicHour.AiHeadshotGeneratorCreateImageRequestStyle? style)
        {
            this.Name = name;
            this.Style = style;
            this.Assets = assets ?? throw new global::System.ArgumentNullException(nameof(assets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiHeadshotGeneratorCreateImageRequest" /> class.
        /// </summary>
        public AiHeadshotGeneratorCreateImageRequest()
        {
        }
    }
}