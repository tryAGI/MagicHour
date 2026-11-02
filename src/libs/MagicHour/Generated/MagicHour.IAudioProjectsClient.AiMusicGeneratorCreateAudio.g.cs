#nullable enable

namespace MagicHour
{
    public partial interface IAudioProjectsClient
    {
        /// <summary>
        /// AI Music Generator<br/>
        /// Generate music from a description, with optional custom lyrics or instrumental-only output. Costs 1 credits per requested second. Returns a project ID; poll GET /v1/audio-projects/{id} for status and downloads.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/ai-music-generator \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header "authorization: Bearer $MAGIC_HOUR_API_KEY" \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Music Generator audio",<br/>
        ///   "duration": 120,<br/>
        ///   "style": {<br/>
        ///     "prompt": "Dreamy synthwave with warm bass and soft vocals",<br/>
        ///     "instrumental": false,<br/>
        ///     "lyrics": "City lights are fading..."<br/>
        ///   }<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.AiMusicGeneratorCreateAudioResponse> AiMusicGeneratorCreateAudioAsync(

            global::MagicHour.AiMusicGeneratorCreateAudioRequest request,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// AI Music Generator<br/>
        /// Generate music from a description, with optional custom lyrics or instrumental-only output. Costs 1 credits per requested second. Returns a project ID; poll GET /v1/audio-projects/{id} for status and downloads.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/ai-music-generator \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header "authorization: Bearer $MAGIC_HOUR_API_KEY" \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Music Generator audio",<br/>
        ///   "duration": 120,<br/>
        ///   "style": {<br/>
        ///     "prompt": "Dreamy synthwave with warm bass and soft vocals",<br/>
        ///     "instrumental": false,<br/>
        ///     "lyrics": "City lights are fading..."<br/>
        ///   }<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.AutoSDKHttpResponse<global::MagicHour.AiMusicGeneratorCreateAudioResponse>> AiMusicGeneratorCreateAudioAsResponseAsync(

            global::MagicHour.AiMusicGeneratorCreateAudioRequest request,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// AI Music Generator<br/>
        /// Generate music from a description, with optional custom lyrics or instrumental-only output. Costs 1 credits per requested second. Returns a project ID; poll GET /v1/audio-projects/{id} for status and downloads.
        /// </summary>
        /// <param name="name">
        /// Give your audio a custom name for easy identification.<br/>
        /// Default Value: AI Music Generator<br/>
        /// Example: My Music Generator audio
        /// </param>
        /// <param name="duration">
        /// Requested track duration in seconds, from 15 to 300. Determines credits charged.<br/>
        /// Example: 120
        /// </param>
        /// <param name="style"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MagicHour.AiMusicGeneratorCreateAudioResponse> AiMusicGeneratorCreateAudioAsync(
            int duration,
            global::MagicHour.AiMusicGeneratorCreateAudioRequestStyle style,
            string? name = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}