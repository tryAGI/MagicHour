
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Success
    /// </summary>
    public sealed partial class VideoAssetsGeneratePresignedUrlResponse
    {
        /// <summary>
        /// The list of upload URLs and file paths for the assets. The response array will match the order of items in the request body. Refer to the [Input Files Guide](https://docs.magichour.ai/integration/inputs-and-outputs) for more details.<br/>
        /// Example: [{"upload_url":"https://videos.magichour.ai/api-assets/id/video.mp4?auth-value=1234567890","expires_at":"2024-07-25T16:56:21.932Z","file_path":"api-assets/id/video.mp4"}, {"upload_url":"https://videos.magichour.ai/api-assets/id/audio.mp3?auth-value=1234567890","expires_at":"2024-07-25T16:56:21.932Z","file_path":"api-assets/id/audio.mp3"}]
        /// </summary>
        /// <example>[{"upload_url":"https://videos.magichour.ai/api-assets/id/video.mp4?auth-value=1234567890","expires_at":"2024-07-25T16:56:21.932Z","file_path":"api-assets/id/video.mp4"}, {"upload_url":"https://videos.magichour.ai/api-assets/id/audio.mp3?auth-value=1234567890","expires_at":"2024-07-25T16:56:21.932Z","file_path":"api-assets/id/audio.mp3"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::MagicHour.VideoAssetsGeneratePresignedUrlResponseItem> Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoAssetsGeneratePresignedUrlResponse" /> class.
        /// </summary>
        /// <param name="items">
        /// The list of upload URLs and file paths for the assets. The response array will match the order of items in the request body. Refer to the [Input Files Guide](https://docs.magichour.ai/integration/inputs-and-outputs) for more details.<br/>
        /// Example: [{"upload_url":"https://videos.magichour.ai/api-assets/id/video.mp4?auth-value=1234567890","expires_at":"2024-07-25T16:56:21.932Z","file_path":"api-assets/id/video.mp4"}, {"upload_url":"https://videos.magichour.ai/api-assets/id/audio.mp3?auth-value=1234567890","expires_at":"2024-07-25T16:56:21.932Z","file_path":"api-assets/id/audio.mp3"}]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoAssetsGeneratePresignedUrlResponse(
            global::System.Collections.Generic.IList<global::MagicHour.VideoAssetsGeneratePresignedUrlResponseItem> items)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoAssetsGeneratePresignedUrlResponse" /> class.
        /// </summary>
        public VideoAssetsGeneratePresignedUrlResponse()
        {
        }

    }
}