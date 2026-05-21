
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Requested resource is not found<br/>
    /// Example: {"message":"Not Found"}
    /// </summary>
    public sealed partial class AiImageGeneratorCreateImageResponse5
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.AiImageGeneratorCreateImageResponseMessage2JsonConverter))]
        public global::MagicHour.AiImageGeneratorCreateImageResponseMessage2 Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiImageGeneratorCreateImageResponse5" /> class.
        /// </summary>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiImageGeneratorCreateImageResponse5(
            global::MagicHour.AiImageGeneratorCreateImageResponseMessage2 message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiImageGeneratorCreateImageResponse5" /> class.
        /// </summary>
        public AiImageGeneratorCreateImageResponse5()
        {
        }

    }
}