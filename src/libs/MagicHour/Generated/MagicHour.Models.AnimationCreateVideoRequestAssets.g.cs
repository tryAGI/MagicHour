
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Provide the assets for animation.
    /// </summary>
    public sealed partial class AnimationCreateVideoRequestAssets
    {
        /// <summary>
        /// Optionally add an audio source if you'd like to incorporate audio into your video<br/>
        /// Example: file
        /// </summary>
        /// <example>file</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.AnimationCreateVideoRequestAssetsAudioSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.AnimationCreateVideoRequestAssetsAudioSource AudioSource { get; set; }

        /// <summary>
        /// The path of the input audio. This field is required if `audio_source` is `file`. This value is either<br/>
        /// - a direct URL to the video file<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// Example: api-assets/id/1234.mp3
        /// </summary>
        /// <example>api-assets/id/1234.mp3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_file_path")]
        public string? AudioFilePath { get; set; }

        /// <summary>
        /// Using a youtube video as the input source. This field is required if `audio_source` is `youtube`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("youtube_url")]
        public string? YoutubeUrl { get; set; }

        /// <summary>
        /// An initial image to use a the first frame of the video. This value is either<br/>
        /// - a direct URL to the video file<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// Example: api-assets/id/1234.png
        /// </summary>
        /// <example>api-assets/id/1234.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_file_path")]
        public string? ImageFilePath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnimationCreateVideoRequestAssets" /> class.
        /// </summary>
        /// <param name="audioSource">
        /// Optionally add an audio source if you'd like to incorporate audio into your video<br/>
        /// Example: file
        /// </param>
        /// <param name="audioFilePath">
        /// The path of the input audio. This field is required if `audio_source` is `file`. This value is either<br/>
        /// - a direct URL to the video file<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// Example: api-assets/id/1234.mp3
        /// </param>
        /// <param name="youtubeUrl">
        /// Using a youtube video as the input source. This field is required if `audio_source` is `youtube`
        /// </param>
        /// <param name="imageFilePath">
        /// An initial image to use a the first frame of the video. This value is either<br/>
        /// - a direct URL to the video file<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// Example: api-assets/id/1234.png
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnimationCreateVideoRequestAssets(
            global::MagicHour.AnimationCreateVideoRequestAssetsAudioSource audioSource,
            string? audioFilePath,
            string? youtubeUrl,
            string? imageFilePath)
        {
            this.AudioSource = audioSource;
            this.AudioFilePath = audioFilePath;
            this.YoutubeUrl = youtubeUrl;
            this.ImageFilePath = imageFilePath;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnimationCreateVideoRequestAssets" /> class.
        /// </summary>
        public AnimationCreateVideoRequestAssets()
        {
        }
    }
}