
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AiVideoEditorCreateVideoRequestStyle
    {
        /// <summary>
        /// The prompt used to edit the video.<br/>
        /// Example: Change the car color to blue
        /// </summary>
        /// <example>Change the car color to blue</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiVideoEditorCreateVideoRequestStyle" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt used to edit the video.<br/>
        /// Example: Change the car color to blue
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiVideoEditorCreateVideoRequestStyle(
            string prompt)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiVideoEditorCreateVideoRequestStyle" /> class.
        /// </summary>
        public AiVideoEditorCreateVideoRequestStyle()
        {
        }

    }
}