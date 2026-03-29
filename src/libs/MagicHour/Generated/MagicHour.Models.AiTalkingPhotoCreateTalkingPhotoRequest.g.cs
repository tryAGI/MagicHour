
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Provide the assets for creating a talking photo
    /// </summary>
    public sealed partial class AiTalkingPhotoCreateTalkingPhotoRequest
    {
        /// <summary>
        /// Give your image a custom name for easy identification.<br/>
        /// Default Value: Talking Photo - dateTime<br/>
        /// Example: My Talking Photo image
        /// </summary>
        /// <example>My Talking Photo image</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The start time of the input audio in seconds. The maximum duration allowed is 60 seconds.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float StartSeconds { get; set; }

        /// <summary>
        /// The end time of the input audio in seconds. The maximum duration allowed is 60 seconds.<br/>
        /// Example: 15
        /// </summary>
        /// <example>15</example>
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
        /// Constrains the larger dimension (height or width) of the output video. Allows you to set a lower resolution than your plan's maximum if desired. The value is capped by your plan's max resolution.<br/>
        /// Example: 1024
        /// </summary>
        /// <example>1024</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_resolution")]
        public int? MaxResolution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiTalkingPhotoCreateTalkingPhotoRequest" /> class.
        /// </summary>
        /// <param name="startSeconds">
        /// The start time of the input audio in seconds. The maximum duration allowed is 60 seconds.<br/>
        /// Example: 0
        /// </param>
        /// <param name="endSeconds">
        /// The end time of the input audio in seconds. The maximum duration allowed is 60 seconds.<br/>
        /// Example: 15
        /// </param>
        /// <param name="assets">
        /// Provide the assets for creating a talking photo
        /// </param>
        /// <param name="name">
        /// Give your image a custom name for easy identification.<br/>
        /// Default Value: Talking Photo - dateTime<br/>
        /// Example: My Talking Photo image
        /// </param>
        /// <param name="style">
        /// Attributes used to dictate the style of the output
        /// </param>
        /// <param name="maxResolution">
        /// Constrains the larger dimension (height or width) of the output video. Allows you to set a lower resolution than your plan's maximum if desired. The value is capped by your plan's max resolution.<br/>
        /// Example: 1024
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
            int? maxResolution)
        {
            this.Name = name;
            this.StartSeconds = startSeconds;
            this.EndSeconds = endSeconds;
            this.Assets = assets ?? throw new global::System.ArgumentNullException(nameof(assets));
            this.Style = style;
            this.MaxResolution = maxResolution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiTalkingPhotoCreateTalkingPhotoRequest" /> class.
        /// </summary>
        public AiTalkingPhotoCreateTalkingPhotoRequest()
        {
        }
    }
}