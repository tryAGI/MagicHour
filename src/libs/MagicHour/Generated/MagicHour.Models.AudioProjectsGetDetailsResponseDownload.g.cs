
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// The download url and expiration date of the audio project
    /// </summary>
    public sealed partial class AudioProjectsGetDetailsResponseDownload
    {
        /// <summary>
        /// Example: https://videos.magichour.ai/id/output.wav
        /// </summary>
        /// <example>https://videos.magichour.ai/id/output.wav</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Example: 2024-10-19T05:16:19.027Z
        /// </summary>
        /// <example>2024-10-19T05:16:19.027Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioProjectsGetDetailsResponseDownload" /> class.
        /// </summary>
        /// <param name="url">
        /// Example: https://videos.magichour.ai/id/output.wav
        /// </param>
        /// <param name="expiresAt">
        /// Example: 2024-10-19T05:16:19.027Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioProjectsGetDetailsResponseDownload(
            string url,
            global::System.DateTime expiresAt)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioProjectsGetDetailsResponseDownload" /> class.
        /// </summary>
        public AudioProjectsGetDetailsResponseDownload()
        {
        }
    }
}