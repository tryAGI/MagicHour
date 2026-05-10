
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Requested resource is not found<br/>
    /// Example: {"message":"Not Found"}
    /// </summary>
    public sealed partial class AiImageEditorCreateImageResponse5
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.AiImageEditorCreateImageResponseMessage2JsonConverter))]
        public global::MagicHour.AiImageEditorCreateImageResponseMessage2 Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiImageEditorCreateImageResponse5" /> class.
        /// </summary>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiImageEditorCreateImageResponse5(
            global::MagicHour.AiImageEditorCreateImageResponseMessage2 message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiImageEditorCreateImageResponse5" /> class.
        /// </summary>
        public AiImageEditorCreateImageResponse5()
        {
        }

    }
}