
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Success
    /// </summary>
    public sealed partial class VideoProjectsGetDetailsResponse
    {
        /// <summary>
        /// Unique ID of the video. Use it with the [Get video Project API](https://docs.magichour.ai/api-reference/video-projects/get-video-details) to fetch status and downloads.<br/>
        /// Example: cuid-example
        /// </summary>
        /// <example>cuid-example</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The name of the video.<br/>
        /// Example: Example Name
        /// </summary>
        /// <example>Example Name</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The status of the video.<br/>
        /// - `draft` - the project was created but has not been submitted for rendering<br/>
        /// - `queued` - the job is waiting for an available server<br/>
        /// - `rendering` - the job is being processed; the `video.started` webhook event fires when rendering begins<br/>
        /// - `complete` - the job finished successfully; fires `video.completed`<br/>
        /// - `error` - the job failed during processing; fires `video.errored`<br/>
        /// - `canceled` - the job was manually canceled (for example from the Magic Hour web app)<br/>
        /// **Note:** `rendering`, `complete`, and `error` have matching webhook events; `canceled` does not - a canceled job emits no webhook event, so poll this endpoint to detect cancellation.<br/>
        /// Example: complete
        /// </summary>
        /// <example>complete</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.VideoProjectsGetDetailsResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.VideoProjectsGetDetailsResponseStatus Status { get; set; }

        /// <summary>
        /// The type of the video project. Possible values are ANIMATION, AUTO_SUBTITLE, VIDEO_TO_VIDEO, FACE_SWAP, TEXT_TO_VIDEO, IMAGE_TO_VIDEO, LIP_SYNC, TALKING_PHOTO, AVATAR, VIDEO_UPSCALER, VIDEO_EDITOR, CHARACTER_REPLACE, VIDEO_COLORIZER, MUSIC_VIDEO, EXTEND, AUDIO_TO_VIDEO, VIDEO_EXPANDER, UGC_AD<br/>
        /// Example: FACE_SWAP
        /// </summary>
        /// <example>FACE_SWAP</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The width of the final output video. A value of -1 indicates the width can be ignored.<br/>
        /// Example: 512
        /// </summary>
        /// <example>512</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Width { get; set; }

        /// <summary>
        /// The height of the final output video. A value of -1 indicates the height can be ignored.<br/>
        /// Example: 960
        /// </summary>
        /// <example>960</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Height { get; set; }

        /// <summary>
        /// Whether this resource is active. If false, it is deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Start time of your clip (seconds). Must be ≥ 0.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float StartSeconds { get; set; }

        /// <summary>
        /// End time of your clip (seconds). Must be greater than start_seconds.<br/>
        /// Example: 15
        /// </summary>
        /// <example>15</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float EndSeconds { get; set; }

        /// <summary>
        /// The amount of credits deducted from your account to generate the video. If the status is not 'complete', this value is an estimate and may be adjusted upon completion based on the actual FPS of the output video. <br/>
        /// If video generation fails, credits will be refunded, and this field will be updated to include the refund.<br/>
        /// Example: 450
        /// </summary>
        /// <example>450</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits_charged")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreditsCharged { get; set; }

        /// <summary>
        /// Frame rate of the video. If the status is not 'complete', the frame rate is an estimate and will be adjusted when the video completes.<br/>
        /// Example: 30
        /// </summary>
        /// <example>30</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("fps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Fps { get; set; }

        /// <summary>
        /// In the case of an error, this object will contain the error encountered during video render<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::MagicHour.VideoProjectsGetDetailsResponseError? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("downloads")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::MagicHour.VideoProjectsGetDetailsResponseDownload> Downloads { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoProjectsGetDetailsResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique ID of the video. Use it with the [Get video Project API](https://docs.magichour.ai/api-reference/video-projects/get-video-details) to fetch status and downloads.<br/>
        /// Example: cuid-example
        /// </param>
        /// <param name="status">
        /// The status of the video.<br/>
        /// - `draft` - the project was created but has not been submitted for rendering<br/>
        /// - `queued` - the job is waiting for an available server<br/>
        /// - `rendering` - the job is being processed; the `video.started` webhook event fires when rendering begins<br/>
        /// - `complete` - the job finished successfully; fires `video.completed`<br/>
        /// - `error` - the job failed during processing; fires `video.errored`<br/>
        /// - `canceled` - the job was manually canceled (for example from the Magic Hour web app)<br/>
        /// **Note:** `rendering`, `complete`, and `error` have matching webhook events; `canceled` does not - a canceled job emits no webhook event, so poll this endpoint to detect cancellation.<br/>
        /// Example: complete
        /// </param>
        /// <param name="type">
        /// The type of the video project. Possible values are ANIMATION, AUTO_SUBTITLE, VIDEO_TO_VIDEO, FACE_SWAP, TEXT_TO_VIDEO, IMAGE_TO_VIDEO, LIP_SYNC, TALKING_PHOTO, AVATAR, VIDEO_UPSCALER, VIDEO_EDITOR, CHARACTER_REPLACE, VIDEO_COLORIZER, MUSIC_VIDEO, EXTEND, AUDIO_TO_VIDEO, VIDEO_EXPANDER, UGC_AD<br/>
        /// Example: FACE_SWAP
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="width">
        /// The width of the final output video. A value of -1 indicates the width can be ignored.<br/>
        /// Example: 512
        /// </param>
        /// <param name="height">
        /// The height of the final output video. A value of -1 indicates the height can be ignored.<br/>
        /// Example: 960
        /// </param>
        /// <param name="enabled">
        /// Whether this resource is active. If false, it is deleted.
        /// </param>
        /// <param name="startSeconds">
        /// Start time of your clip (seconds). Must be ≥ 0.<br/>
        /// Example: 0
        /// </param>
        /// <param name="endSeconds">
        /// End time of your clip (seconds). Must be greater than start_seconds.<br/>
        /// Example: 15
        /// </param>
        /// <param name="creditsCharged">
        /// The amount of credits deducted from your account to generate the video. If the status is not 'complete', this value is an estimate and may be adjusted upon completion based on the actual FPS of the output video. <br/>
        /// If video generation fails, credits will be refunded, and this field will be updated to include the refund.<br/>
        /// Example: 450
        /// </param>
        /// <param name="fps">
        /// Frame rate of the video. If the status is not 'complete', the frame rate is an estimate and will be adjusted when the video completes.<br/>
        /// Example: 30
        /// </param>
        /// <param name="downloads"></param>
        /// <param name="name">
        /// The name of the video.<br/>
        /// Example: Example Name
        /// </param>
        /// <param name="error">
        /// In the case of an error, this object will contain the error encountered during video render<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoProjectsGetDetailsResponse(
            string id,
            global::MagicHour.VideoProjectsGetDetailsResponseStatus status,
            string type,
            global::System.DateTime createdAt,
            int width,
            int height,
            bool enabled,
            float startSeconds,
            float endSeconds,
            int creditsCharged,
            double fps,
            global::System.Collections.Generic.IList<global::MagicHour.VideoProjectsGetDetailsResponseDownload> downloads,
            string? name,
            global::MagicHour.VideoProjectsGetDetailsResponseError? error)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name;
            this.Status = status;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.CreatedAt = createdAt;
            this.Width = width;
            this.Height = height;
            this.Enabled = enabled;
            this.StartSeconds = startSeconds;
            this.EndSeconds = endSeconds;
            this.CreditsCharged = creditsCharged;
            this.Fps = fps;
            this.Error = error;
            this.Downloads = downloads ?? throw new global::System.ArgumentNullException(nameof(downloads));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoProjectsGetDetailsResponse" /> class.
        /// </summary>
        public VideoProjectsGetDetailsResponse()
        {
        }

    }
}