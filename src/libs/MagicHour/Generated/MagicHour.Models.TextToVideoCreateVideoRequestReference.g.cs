
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TextToVideoCreateVideoRequestReference
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
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
        /// <param name="name"></param>
        /// <param name="filePath"></param>
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