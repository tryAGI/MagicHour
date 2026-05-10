
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Attributed used to dictate the style of the output
    /// </summary>
    public sealed partial class ImageToVideoCreateVideoRequestStyle
    {
        /// <summary>
        /// The prompt used for the video.<br/>
        /// Example: a dog running
        /// </summary>
        /// <example>a dog running</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageToVideoCreateVideoRequestStyle" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt used for the video.<br/>
        /// Example: a dog running
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageToVideoCreateVideoRequestStyle(
            string? prompt)
        {
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageToVideoCreateVideoRequestStyle" /> class.
        /// </summary>
        public ImageToVideoCreateVideoRequestStyle()
        {
        }

    }
}