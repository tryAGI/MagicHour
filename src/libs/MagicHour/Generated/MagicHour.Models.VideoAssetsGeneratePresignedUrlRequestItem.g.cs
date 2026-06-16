
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoAssetsGeneratePresignedUrlRequestItem
    {
        /// <summary>
        /// The type of asset to upload. Possible types are video, audio, image<br/>
        /// Example: video
        /// </summary>
        /// <example>video</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.VideoAssetsGeneratePresignedUrlRequestItemTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.VideoAssetsGeneratePresignedUrlRequestItemType Type { get; set; }

        /// <summary>
        /// The extension of the file to upload. Do not include the dot (.) before the extension. Possible extensions are mp4,m4v,mov,webm,mp3,wav,aac,flac,webm,m4a,opus,ogg,aiff,amr,png,jpg,jpeg,heic,heif,webp,avif,jp2,tiff,bmp,gif,webp,webm<br/>
        /// Example: mp4
        /// </summary>
        /// <example>mp4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("extension")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Extension { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoAssetsGeneratePresignedUrlRequestItem" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of asset to upload. Possible types are video, audio, image<br/>
        /// Example: video
        /// </param>
        /// <param name="extension">
        /// The extension of the file to upload. Do not include the dot (.) before the extension. Possible extensions are mp4,m4v,mov,webm,mp3,wav,aac,flac,webm,m4a,opus,ogg,aiff,amr,png,jpg,jpeg,heic,heif,webp,avif,jp2,tiff,bmp,gif,webp,webm<br/>
        /// Example: mp4
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoAssetsGeneratePresignedUrlRequestItem(
            global::MagicHour.VideoAssetsGeneratePresignedUrlRequestItemType type,
            string extension)
        {
            this.Type = type;
            this.Extension = extension ?? throw new global::System.ArgumentNullException(nameof(extension));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoAssetsGeneratePresignedUrlRequestItem" /> class.
        /// </summary>
        public VideoAssetsGeneratePresignedUrlRequestItem()
        {
        }

    }
}