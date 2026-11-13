
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Attributed used to dictate the style of the output
    /// </summary>
    public sealed partial class ImageToVideoCreateVideoRequestStyle
    {
        /// <summary>
        /// The prompt used for the video. Maximum length depends on the model that runs, in characters:<br/>
        /// * **`gemini-omni-1.2`**: 4000 characters.<br/>
        /// * **`kling-2.6`**: 2500 characters.<br/>
        /// * **`kling-3.0`**: 2500 characters.<br/>
        /// * **`kling-4.0`**: 10000 characters.<br/>
        /// * **`ltx-2.5`**: 4000 characters.<br/>
        /// * **`minimax-h3`**: 20000 characters.<br/>
        /// * **`seedance-1.5`**: 4000 characters.<br/>
        /// * **`seedance-2.0`**: 4000 characters.<br/>
        /// * **`seedance-2.0-fast`**: 4000 characters.<br/>
        /// * **`seedance-2.0-mini`**: 4000 characters.<br/>
        /// * **`seedance-2.5`**: 4000 characters.<br/>
        /// * **`veo3.1`**: 2500 characters.<br/>
        /// * **`veo3.1-lite`**: 2500 characters.<br/>
        /// * **`wan-2.2`**: 10000 characters.<br/>
        /// * **`wan-3.0`**: 10000 characters.<br/>
        /// For `default`, the limit of the automatically selected model applies. Selection depends on subscription tier, resolution and duration. Specify an explicit model to use a known prompt limit. Prompts exceeding the effective model's limit are rejected, not truncated.<br/>
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
        /// The prompt used for the video. Maximum length depends on the model that runs, in characters:<br/>
        /// * **`gemini-omni-1.2`**: 4000 characters.<br/>
        /// * **`kling-2.6`**: 2500 characters.<br/>
        /// * **`kling-3.0`**: 2500 characters.<br/>
        /// * **`kling-4.0`**: 10000 characters.<br/>
        /// * **`ltx-2.5`**: 4000 characters.<br/>
        /// * **`minimax-h3`**: 20000 characters.<br/>
        /// * **`seedance-1.5`**: 4000 characters.<br/>
        /// * **`seedance-2.0`**: 4000 characters.<br/>
        /// * **`seedance-2.0-fast`**: 4000 characters.<br/>
        /// * **`seedance-2.0-mini`**: 4000 characters.<br/>
        /// * **`seedance-2.5`**: 4000 characters.<br/>
        /// * **`veo3.1`**: 2500 characters.<br/>
        /// * **`veo3.1-lite`**: 2500 characters.<br/>
        /// * **`wan-2.2`**: 10000 characters.<br/>
        /// * **`wan-3.0`**: 10000 characters.<br/>
        /// For `default`, the limit of the automatically selected model applies. Selection depends on subscription tier, resolution and duration. Specify an explicit model to use a known prompt limit. Prompts exceeding the effective model's limit are rejected, not truncated.<br/>
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