
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Provide the assets for creating a talking photo
    /// </summary>
    public sealed partial class AiTalkingPhotoCreateTalkingPhotoRequest
    {
        /// <summary>
        /// Give your video a custom name for easy identification.<br/>
        /// Default Value: Talking Photo - dateTime<br/>
        /// Example: My Talking Photo video
        /// </summary>
        /// <example>My Talking Photo video</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The start time of the input audio in seconds. Maximum clip length depends on style.generation_mode: realistic 300s, prompted 60s.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float StartSeconds { get; set; }

        /// <summary>
        /// The end time of the input audio in seconds. Maximum clip length depends on style.generation_mode: realistic 300s, prompted 60s.<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float EndSeconds { get; set; }

        /// <summary>
        /// Provide the assets for creating a talking photo
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.AiTalkingPhotoCreateTalkingPhotoRequestAssets Assets { get; set; }

        /// <summary>
        /// Attributes used to dictate the style of the output
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        public global::MagicHour.AiTalkingPhotoCreateTalkingPhotoRequestStyle? Style { get; set; }

        /// <summary>
        /// Output preset. Overrides `max_resolution`. Defaults to 480p in prompted mode; realistic mode uses the mapped plan maximum.<br/>
        /// Example: 480p
        /// </summary>
        /// <example>480p</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.AiTalkingPhotoCreateTalkingPhotoRequestResolutionJsonConverter))]
        public global::MagicHour.AiTalkingPhotoCreateTalkingPhotoRequestResolution? Resolution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiTalkingPhotoCreateTalkingPhotoRequest" /> class.
        /// </summary>
        /// <param name="startSeconds">
        /// The start time of the input audio in seconds. Maximum clip length depends on style.generation_mode: realistic 300s, prompted 60s.<br/>
        /// Example: 0
        /// </param>
        /// <param name="endSeconds">
        /// The end time of the input audio in seconds. Maximum clip length depends on style.generation_mode: realistic 300s, prompted 60s.<br/>
        /// Example: 5
        /// </param>
        /// <param name="assets">
        /// Provide the assets for creating a talking photo
        /// </param>
        /// <param name="name">
        /// Give your video a custom name for easy identification.<br/>
        /// Default Value: Talking Photo - dateTime<br/>
        /// Example: My Talking Photo video
        /// </param>
        /// <param name="style">
        /// Attributes used to dictate the style of the output
        /// </param>
        /// <param name="resolution">
        /// Output preset. Overrides `max_resolution`. Defaults to 480p in prompted mode; realistic mode uses the mapped plan maximum.<br/>
        /// Example: 480p
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiTalkingPhotoCreateTalkingPhotoRequest(
            float startSeconds,
            float endSeconds,
            global::MagicHour.AiTalkingPhotoCreateTalkingPhotoRequestAssets assets,
            string? name,
            global::MagicHour.AiTalkingPhotoCreateTalkingPhotoRequestStyle? style,
            global::MagicHour.AiTalkingPhotoCreateTalkingPhotoRequestResolution? resolution)
        {
            this.Name = name;
            this.StartSeconds = startSeconds;
            this.EndSeconds = endSeconds;
            this.Assets = assets ?? throw new global::System.ArgumentNullException(nameof(assets));
            this.Style = style;
            this.Resolution = resolution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiTalkingPhotoCreateTalkingPhotoRequest" /> class.
        /// </summary>
        public AiTalkingPhotoCreateTalkingPhotoRequest()
        {
        }

    }
}