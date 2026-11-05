
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VoicesListResponseVoice
    {
        /// <summary>
        /// Unique ID of the voice. Pass it as `style.voice_name` when generating speech. Names are not unique, so use the ID.<br/>
        /// Example: cv-0001
        /// </summary>
        /// <example>cv-0001</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Display name of the voice.<br/>
        /// Example: Ashley
        /// </summary>
        /// <example>Ashley</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// URL of the voice's avatar image, or null when the voice has no avatar.<br/>
        /// Example: https://d28dkohlqf5vwj.cloudfront.net/models/nano-banana/female-portrait-turtleneck.webp
        /// </summary>
        /// <example>https://d28dkohlqf5vwj.cloudfront.net/models/nano-banana/female-portrait-turtleneck.webp</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_url")]
        public string? AvatarUrl { get; set; }

        /// <summary>
        /// URL of an audio sample of the voice.<br/>
        /// Example: https://videos.magichour.ai/presets/voices/v2/cv-0001-ashley.mp3
        /// </summary>
        /// <example>https://videos.magichour.ai/presets/voices/v2/cv-0001-ashley.mp3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PreviewUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicesListResponseVoice" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique ID of the voice. Pass it as `style.voice_name` when generating speech. Names are not unique, so use the ID.<br/>
        /// Example: cv-0001
        /// </param>
        /// <param name="name">
        /// Display name of the voice.<br/>
        /// Example: Ashley
        /// </param>
        /// <param name="previewUrl">
        /// URL of an audio sample of the voice.<br/>
        /// Example: https://videos.magichour.ai/presets/voices/v2/cv-0001-ashley.mp3
        /// </param>
        /// <param name="avatarUrl">
        /// URL of the voice's avatar image, or null when the voice has no avatar.<br/>
        /// Example: https://d28dkohlqf5vwj.cloudfront.net/models/nano-banana/female-portrait-turtleneck.webp
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoicesListResponseVoice(
            string id,
            string name,
            string previewUrl,
            string? avatarUrl)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AvatarUrl = avatarUrl;
            this.PreviewUrl = previewUrl ?? throw new global::System.ArgumentNullException(nameof(previewUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicesListResponseVoice" /> class.
        /// </summary>
        public VoicesListResponseVoice()
        {
        }

    }
}