
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TextToVideoCreateVideoRequestReference
    {
        /// <summary>
        /// Example: hero
        /// </summary>
        /// <example>hero</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// This value is either<br/>
        /// - a direct URL to the file. The URL path must end in a supported file extension.<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// Example: api-assets/id/1234.png
        /// </summary>
        /// <example>api-assets/id/1234.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FilePath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToVideoCreateVideoRequestReference" /> class.
        /// </summary>
        /// <param name="name">
        /// Example: hero
        /// </param>
        /// <param name="filePath">
        /// This value is either<br/>
        /// - a direct URL to the file. The URL path must end in a supported file extension.<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// Example: api-assets/id/1234.png
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextToVideoCreateVideoRequestReference(
            string name,
            string filePath)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.FilePath = filePath ?? throw new global::System.ArgumentNullException(nameof(filePath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToVideoCreateVideoRequestReference" /> class.
        /// </summary>
        public TextToVideoCreateVideoRequestReference()
        {
        }

    }
}