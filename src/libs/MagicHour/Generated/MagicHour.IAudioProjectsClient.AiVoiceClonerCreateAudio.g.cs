#nullable enable

namespace MagicHour
{
    public partial interface IAudioProjectsClient
    {
        /// <summary>
        /// AI Voice Cloner<br/>
        /// Clone a voice from an audio sample and generate speech. <br/>
        /// * Each character costs 0.1 credits. <br/>
        /// * The cost is rounded up to the nearest whole number
        /// </summary>
        /// <param name="idempotencyKey">
        /// A unique string for this request, such as a UUID. Sending the same key again within 24 hours returns the original project instead of creating and charging for a new one. A key applies across all video, image, and audio endpoints on your account, so use a new key for every project.<br/>
        /// Example: 5f3c1b9e-8a41-4a0e-9d3e-2f6a1c7b9e10
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/ai-voice-cloner \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header "authorization: Bearer $MAGIC_HOUR_API_KEY" \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Voice Cloner audio",<br/>
        ///   "assets": {<br/>
        ///     "audio_file_path": "api-assets/id/1234.mp3"<br/>
        ///   },<br/>
        ///   "style": {<br/>
        ///     "language": "spanish",<br/>
        ///     "speed": 1.15,<br/>
        ///     "prompt": "Hello, this is my cloned voice."<br/>
        ///   }<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.AiVoiceClonerCreateAudioResponse> AiVoiceClonerCreateAudioAsync(

            global::MagicHour.AiVoiceClonerCreateAudioRequest request,
            string? idempotencyKey = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// AI Voice Cloner<br/>
        /// Clone a voice from an audio sample and generate speech. <br/>
        /// * Each character costs 0.1 credits. <br/>
        /// * The cost is rounded up to the nearest whole number
        /// </summary>
        /// <param name="idempotencyKey">
        /// A unique string for this request, such as a UUID. Sending the same key again within 24 hours returns the original project instead of creating and charging for a new one. A key applies across all video, image, and audio endpoints on your account, so use a new key for every project.<br/>
        /// Example: 5f3c1b9e-8a41-4a0e-9d3e-2f6a1c7b9e10
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/ai-voice-cloner \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header "authorization: Bearer $MAGIC_HOUR_API_KEY" \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Voice Cloner audio",<br/>
        ///   "assets": {<br/>
        ///     "audio_file_path": "api-assets/id/1234.mp3"<br/>
        ///   },<br/>
        ///   "style": {<br/>
        ///     "language": "spanish",<br/>
        ///     "speed": 1.15,<br/>
        ///     "prompt": "Hello, this is my cloned voice."<br/>
        ///   }<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.AutoSDKHttpResponse<global::MagicHour.AiVoiceClonerCreateAudioResponse>> AiVoiceClonerCreateAudioAsResponseAsync(

            global::MagicHour.AiVoiceClonerCreateAudioRequest request,
            string? idempotencyKey = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// AI Voice Cloner<br/>
        /// Clone a voice from an audio sample and generate speech. <br/>
        /// * Each character costs 0.1 credits. <br/>
        /// * The cost is rounded up to the nearest whole number
        /// </summary>
        /// <param name="idempotencyKey">
        /// A unique string for this request, such as a UUID. Sending the same key again within 24 hours returns the original project instead of creating and charging for a new one. A key applies across all video, image, and audio endpoints on your account, so use a new key for every project.<br/>
        /// Example: 5f3c1b9e-8a41-4a0e-9d3e-2f6a1c7b9e10
        /// </param>
        /// <param name="name">
        /// Give your audio a custom name for easy identification.<br/>
        /// Default Value: Voice Cloner - dateTime<br/>
        /// Example: My Voice Cloner audio
        /// </param>
        /// <param name="assets">
        /// Provide the assets for voice cloning.
        /// </param>
        /// <param name="style"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MagicHour.AiVoiceClonerCreateAudioResponse> AiVoiceClonerCreateAudioAsync(
            global::MagicHour.AiVoiceClonerCreateAudioRequestAssets assets,
            global::MagicHour.AiVoiceClonerCreateAudioRequestStyle style,
            string? idempotencyKey = default,
            string? name = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}