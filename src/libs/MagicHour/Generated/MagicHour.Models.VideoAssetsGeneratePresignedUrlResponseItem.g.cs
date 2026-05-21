
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoAssetsGeneratePresignedUrlResponseItem
    {
        /// <summary>
        /// Used to upload the file to storage, send a PUT request with the file as data to upload.<br/>
        /// Example: https://videos.magichour.ai/id/video.mp4?auth-value=1234567890
        /// </summary>
        /// <example>https://videos.magichour.ai/id/video.mp4?auth-value=1234567890</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UploadUrl { get; set; }

        /// <summary>
        /// when the upload url expires, and will need to request a new one.<br/>
        /// Example: 2024-07-21T17:32:28Z
        /// </summary>
        /// <example>2024-07-21T17:32:28Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpiresAt { get; set; }

        /// <summary>
        /// this value is used in APIs that needs assets, such as image_file_path, video_file_path, and audio_file_path<br/>
        /// Example: video/id/1234.mp4
        /// </summary>
        /// <example>video/id/1234.mp4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FilePath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoAssetsGeneratePresignedUrlResponseItem" /> class.
        /// </summary>
        /// <param name="uploadUrl">
        /// Used to upload the file to storage, send a PUT request with the file as data to upload.<br/>
        /// Example: https://videos.magichour.ai/id/video.mp4?auth-value=1234567890
        /// </param>
        /// <param name="expiresAt">
        /// when the upload url expires, and will need to request a new one.<br/>
        /// Example: 2024-07-21T17:32:28Z
        /// </param>
        /// <param name="filePath">
        /// this value is used in APIs that needs assets, such as image_file_path, video_file_path, and audio_file_path<br/>
        /// Example: video/id/1234.mp4
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoAssetsGeneratePresignedUrlResponseItem(
            string uploadUrl,
            global::System.DateTime expiresAt,
            string filePath)
        {
            this.UploadUrl = uploadUrl ?? throw new global::System.ArgumentNullException(nameof(uploadUrl));
            this.ExpiresAt = expiresAt;
            this.FilePath = filePath ?? throw new global::System.ArgumentNullException(nameof(filePath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoAssetsGeneratePresignedUrlResponseItem" /> class.
        /// </summary>
        public VideoAssetsGeneratePresignedUrlResponseItem()
        {
        }

    }
}