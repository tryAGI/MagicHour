
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoAssetsGeneratePresignedUrlRequest
    {
        /// <summary>
        /// The list of assets to upload. The response array will match the order of items in the request body.<br/>
        /// Example: [{"type":"video","extension":"mp4"}, {"type":"audio","extension":"mp3"}]
        /// </summary>
        /// <example>[{"type":"video","extension":"mp4"}, {"type":"audio","extension":"mp3"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::MagicHour.VideoAssetsGeneratePresignedUrlRequestItem> Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoAssetsGeneratePresignedUrlRequest" /> class.
        /// </summary>
        /// <param name="items">
        /// The list of assets to upload. The response array will match the order of items in the request body.<br/>
        /// Example: [{"type":"video","extension":"mp4"}, {"type":"audio","extension":"mp3"}]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoAssetsGeneratePresignedUrlRequest(
            global::System.Collections.Generic.IList<global::MagicHour.VideoAssetsGeneratePresignedUrlRequestItem> items)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoAssetsGeneratePresignedUrlRequest" /> class.
        /// </summary>
        public VideoAssetsGeneratePresignedUrlRequest()
        {
        }
    }
}