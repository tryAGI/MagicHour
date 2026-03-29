
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Provide the assets for voice cloning.
    /// </summary>
    public sealed partial class AiVoiceClonerCreateAudioRequestAssets
    {
        /// <summary>
        /// The audio used to clone the voice. This value is either<br/>
        /// - a direct URL to the video file<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// Example: api-assets/id/1234.mp3
        /// </summary>
        /// <example>api-assets/id/1234.mp3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_file_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AudioFilePath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiVoiceClonerCreateAudioRequestAssets" /> class.
        /// </summary>
        /// <param name="audioFilePath">
        /// The audio used to clone the voice. This value is either<br/>
        /// - a direct URL to the video file<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// Example: api-assets/id/1234.mp3
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiVoiceClonerCreateAudioRequestAssets(
            string audioFilePath)
        {
            this.AudioFilePath = audioFilePath ?? throw new global::System.ArgumentNullException(nameof(audioFilePath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiVoiceClonerCreateAudioRequestAssets" /> class.
        /// </summary>
        public AiVoiceClonerCreateAudioRequestAssets()
        {
        }
    }
}