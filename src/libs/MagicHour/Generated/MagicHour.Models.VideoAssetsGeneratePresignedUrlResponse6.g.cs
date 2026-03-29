
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Unprocessable Entity
    /// </summary>
    public sealed partial class VideoAssetsGeneratePresignedUrlResponse6
    {
        /// <summary>
        /// Example: 'mp4' is an invalid audio extension. Possible extensions are 'mp3, wav, aac, flac, webm, m4a'
        /// </summary>
        /// <example>'mp4' is an invalid audio extension. Possible extensions are 'mp3, wav, aac, flac, webm, m4a'</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoAssetsGeneratePresignedUrlResponse6" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: 'mp4' is an invalid audio extension. Possible extensions are 'mp3, wav, aac, flac, webm, m4a'
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoAssetsGeneratePresignedUrlResponse6(
            string message)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoAssetsGeneratePresignedUrlResponse6" /> class.
        /// </summary>
        public VideoAssetsGeneratePresignedUrlResponse6()
        {
        }
    }
}