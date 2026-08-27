
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AiQrCodeGeneratorCreateImageRequest
    {
        /// <summary>
        /// Give your image a custom name for easy identification.<br/>
        /// Default Value: Qr Code - dateTime<br/>
        /// Example: My Qr Code image
        /// </summary>
        /// <example>My Qr Code image</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The content of the QR code.<br/>
        /// Example: https://magichour.ai
        /// </summary>
        /// <example>https://magichour.ai</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.AiQrCodeGeneratorCreateImageRequestStyle Style { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiQrCodeGeneratorCreateImageRequest" /> class.
        /// </summary>
        /// <param name="content">
        /// The content of the QR code.<br/>
        /// Example: https://magichour.ai
        /// </param>
        /// <param name="style"></param>
        /// <param name="name">
        /// Give your image a custom name for easy identification.<br/>
        /// Default Value: Qr Code - dateTime<br/>
        /// Example: My Qr Code image
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiQrCodeGeneratorCreateImageRequest(
            string content,
            global::MagicHour.AiQrCodeGeneratorCreateImageRequestStyle style,
            string? name)
        {
            this.Name = name;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Style = style ?? throw new global::System.ArgumentNullException(nameof(style));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiQrCodeGeneratorCreateImageRequest" /> class.
        /// </summary>
        public AiQrCodeGeneratorCreateImageRequest()
        {
        }

    }
}