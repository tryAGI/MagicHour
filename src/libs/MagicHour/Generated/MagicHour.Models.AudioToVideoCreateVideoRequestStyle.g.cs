
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Attributes used to dictate the style of the output
    /// </summary>
    public sealed partial class AudioToVideoCreateVideoRequestStyle
    {
        /// <summary>
        /// Prompt to guide the visual style of the video.<br/>
        /// Example: Car driving through a city
        /// </summary>
        /// <example>Car driving through a city</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioToVideoCreateVideoRequestStyle" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Prompt to guide the visual style of the video.<br/>
        /// Example: Car driving through a city
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioToVideoCreateVideoRequestStyle(
            string? prompt)
        {
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioToVideoCreateVideoRequestStyle" /> class.
        /// </summary>
        public AudioToVideoCreateVideoRequestStyle()
        {
        }

    }
}