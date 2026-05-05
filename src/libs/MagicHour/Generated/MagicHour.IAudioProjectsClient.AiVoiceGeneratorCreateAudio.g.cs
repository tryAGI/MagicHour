#nullable enable

namespace MagicHour
{
    public partial interface IAudioProjectsClient
    {
        /// <summary>
        /// AI Voice Generator<br/>
        /// Generate speech from text. Each character costs 0.05 credits. The cost is rounded up to the nearest whole number.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/ai-voice-generator \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header 'authorization: Bearer &lt;token&gt;' \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Voice Generator audio",<br/>
        ///   "style": {<br/>
        ///     "prompt": "Hello, how are you?",<br/>
        ///     "voice_name": "Elon Musk"<br/>
        ///   }<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.AiVoiceGeneratorCreateAudioResponse> AiVoiceGeneratorCreateAudioAsync(

            global::MagicHour.AiVoiceGeneratorCreateAudioRequest request,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// AI Voice Generator<br/>
        /// Generate speech from text. Each character costs 0.05 credits. The cost is rounded up to the nearest whole number.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/ai-voice-generator \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header 'authorization: Bearer &lt;token&gt;' \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Voice Generator audio",<br/>
        ///   "style": {<br/>
        ///     "prompt": "Hello, how are you?",<br/>
        ///     "voice_name": "Elon Musk"<br/>
        ///   }<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.AutoSDKHttpResponse<global::MagicHour.AiVoiceGeneratorCreateAudioResponse>> AiVoiceGeneratorCreateAudioAsResponseAsync(

            global::MagicHour.AiVoiceGeneratorCreateAudioRequest request,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// AI Voice Generator<br/>
        /// Generate speech from text. Each character costs 0.05 credits. The cost is rounded up to the nearest whole number.
        /// </summary>
        /// <param name="name">
        /// Give your audio a custom name for easy identification.<br/>
        /// Default Value: Voice Generator - dateTime<br/>
        /// Example: My Voice Generator audio
        /// </param>
        /// <param name="style">
        /// The content used to generate speech.<br/>
        /// Example: {"prompt":"Hello, how are you?","voice_name":"Elon Musk"}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MagicHour.AiVoiceGeneratorCreateAudioResponse> AiVoiceGeneratorCreateAudioAsync(
            global::MagicHour.AiVoiceGeneratorCreateAudioRequestStyle style,
            string? name = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}