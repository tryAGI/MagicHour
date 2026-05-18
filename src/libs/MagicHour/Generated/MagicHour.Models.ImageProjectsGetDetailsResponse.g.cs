
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Success
    /// </summary>
    public sealed partial class ImageProjectsGetDetailsResponse
    {
        /// <summary>
        /// Unique ID of the image. Use it with the [Get image Project API](https://docs.magichour.ai/api-reference/image-projects/get-image-details) to fetch status and downloads.<br/>
        /// Example: cuid-example
        /// </summary>
        /// <example>cuid-example</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The name of the image.<br/>
        /// Example: Example Name
        /// </summary>
        /// <example>Example Name</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The status of the image.<br/>
        /// Example: complete
        /// </summary>
        /// <example>complete</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.ImageProjectsGetDetailsResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.ImageProjectsGetDetailsResponseStatus Status { get; set; }

        /// <summary>
        /// Number of images generated<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ImageCount { get; set; }

        /// <summary>
        /// The type of the image project. Possible values are FACE_EDITOR, AI_IMAGE_EDITOR, AI_SELFIE, AI_HEADSHOT, AI_IMAGE, AI_MEME, CLOTHES_CHANGER, BACKGROUND_REMOVER, FACE_SWAP, IMAGE_UPSCALER, AI_GIF, QR_CODE, PHOTO_EDITOR, PHOTO_COLORIZER, HEAD_SWAP, BODY_SWAP, STORYBOARD, IMAGE_EXPANDER<br/>
        /// Example: AI_IMAGE
        /// </summary>
        /// <example>AI_IMAGE</example>
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
        /// Whether this resource is active. If false, it is deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// The amount of credits deducted from your account to generate the image. We charge credits right when the request is made. <br/>
        /// If an error occurred while generating the image(s), credits will be refunded and this field will be updated to include the refund.<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits_charged")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreditsCharged { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("downloads")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::MagicHour.ImageProjectsGetDetailsResponseDownload> Downloads { get; set; }

        /// <summary>
        /// In the case of an error, this object will contain the error encountered during video render<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::MagicHour.ImageProjectsGetDetailsResponseError? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageProjectsGetDetailsResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique ID of the image. Use it with the [Get image Project API](https://docs.magichour.ai/api-reference/image-projects/get-image-details) to fetch status and downloads.<br/>
        /// Example: cuid-example
        /// </param>
        /// <param name="status">
        /// The status of the image.<br/>
        /// Example: complete
        /// </param>
        /// <param name="imageCount">
        /// Number of images generated<br/>
        /// Example: 1
        /// </param>
        /// <param name="type">
        /// The type of the image project. Possible values are FACE_EDITOR, AI_IMAGE_EDITOR, AI_SELFIE, AI_HEADSHOT, AI_IMAGE, AI_MEME, CLOTHES_CHANGER, BACKGROUND_REMOVER, FACE_SWAP, IMAGE_UPSCALER, AI_GIF, QR_CODE, PHOTO_EDITOR, PHOTO_COLORIZER, HEAD_SWAP, BODY_SWAP, STORYBOARD, IMAGE_EXPANDER<br/>
        /// Example: AI_IMAGE
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="enabled">
        /// Whether this resource is active. If false, it is deleted.
        /// </param>
        /// <param name="creditsCharged">
        /// The amount of credits deducted from your account to generate the image. We charge credits right when the request is made. <br/>
        /// If an error occurred while generating the image(s), credits will be refunded and this field will be updated to include the refund.<br/>
        /// Example: 5
        /// </param>
        /// <param name="downloads"></param>
        /// <param name="name">
        /// The name of the image.<br/>
        /// Example: Example Name
        /// </param>
        /// <param name="error">
        /// In the case of an error, this object will contain the error encountered during video render<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageProjectsGetDetailsResponse(
            string id,
            global::MagicHour.ImageProjectsGetDetailsResponseStatus status,
            int imageCount,
            string type,
            global::System.DateTime createdAt,
            bool enabled,
            int creditsCharged,
            global::System.Collections.Generic.IList<global::MagicHour.ImageProjectsGetDetailsResponseDownload> downloads,
            string? name,
            global::MagicHour.ImageProjectsGetDetailsResponseError? error)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name;
            this.Status = status;
            this.ImageCount = imageCount;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.CreatedAt = createdAt;
            this.Enabled = enabled;
            this.CreditsCharged = creditsCharged;
            this.Downloads = downloads ?? throw new global::System.ArgumentNullException(nameof(downloads));
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageProjectsGetDetailsResponse" /> class.
        /// </summary>
        public ImageProjectsGetDetailsResponse()
        {
        }

    }
}