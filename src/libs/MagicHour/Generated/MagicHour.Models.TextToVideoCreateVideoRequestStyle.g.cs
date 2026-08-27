
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TextToVideoCreateVideoRequestStyle
    {
        /// <summary>
        /// The prompt used for the video.<br/>
        /// Example: a dog running
        /// </summary>
        /// <example>a dog running</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToVideoCreateVideoRequestStyle" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt used for the video.<br/>
        /// Example: a dog running
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextToVideoCreateVideoRequestStyle(
            string prompt)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToVideoCreateVideoRequestStyle" /> class.
        /// </summary>
        public TextToVideoCreateVideoRequestStyle()
        {
        }

    }
}