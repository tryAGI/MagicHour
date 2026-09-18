
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SavedItemsListResponseItemAsset
    {
        /// <summary>
        /// Durable asset path. Pass it to a compatible API asset field without uploading it again.<br/>
        /// Example: saved-items/user-id/item-id/image.png
        /// </summary>
        /// <example>saved-items/user-id/item-id/image.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FilePath { get; set; }

        /// <summary>
        /// Media type of the asset.<br/>
        /// Example: IMAGE
        /// </summary>
        /// <example>IMAGE</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.SavedItemsListResponseItemAssetMediaKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.SavedItemsListResponseItemAssetMediaKind MediaKind { get; set; }

        /// <summary>
        /// Whether this asset is the saved item's primary asset.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_primary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsPrimary { get; set; }

        /// <summary>
        /// Signed URL for previewing or downloading the asset. Expires after 24 hours.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// When the signed URL expires. The saved asset and file_path do not expire.<br/>
        /// Example: 2026-09-17T00:00:00.000Z
        /// </summary>
        /// <example>2026-09-17T00:00:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url_expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UrlExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SavedItemsListResponseItemAsset" /> class.
        /// </summary>
        /// <param name="filePath">
        /// Durable asset path. Pass it to a compatible API asset field without uploading it again.<br/>
        /// Example: saved-items/user-id/item-id/image.png
        /// </param>
        /// <param name="mediaKind">
        /// Media type of the asset.<br/>
        /// Example: IMAGE
        /// </param>
        /// <param name="isPrimary">
        /// Whether this asset is the saved item's primary asset.<br/>
        /// Example: true
        /// </param>
        /// <param name="url">
        /// Signed URL for previewing or downloading the asset. Expires after 24 hours.
        /// </param>
        /// <param name="urlExpiresAt">
        /// When the signed URL expires. The saved asset and file_path do not expire.<br/>
        /// Example: 2026-09-17T00:00:00.000Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SavedItemsListResponseItemAsset(
            string filePath,
            global::MagicHour.SavedItemsListResponseItemAssetMediaKind mediaKind,
            bool isPrimary,
            string url,
            global::System.DateTime urlExpiresAt)
        {
            this.FilePath = filePath ?? throw new global::System.ArgumentNullException(nameof(filePath));
            this.MediaKind = mediaKind;
            this.IsPrimary = isPrimary;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.UrlExpiresAt = urlExpiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SavedItemsListResponseItemAsset" /> class.
        /// </summary>
        public SavedItemsListResponseItemAsset()
        {
        }

    }
}