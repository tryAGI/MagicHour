#nullable enable

namespace MagicHour
{
    public partial interface IAudioProjectsClient
    {
        /// <summary>
        /// Estimate audio credits<br/>
        /// Get the credits an audio create request charges. Pass `tool`, then the field below that the tool's create request uses. Does not create a project or spend credits. It prices the fields passed here. It does not check your plan, your balance or the rest of the create request.
        /// </summary>
        /// <param name="tool">
        /// Example: ai-voice-generator
        /// </param>
        /// <param name="characterCount">
        /// Example: 120
        /// </param>
        /// <param name="duration"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::MagicHour.EstimateAudioResponse> EstimateAudioAsync(
            global::MagicHour.EstimateAudioTool tool,
            int? characterCount = default,
            int? duration = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Estimate audio credits<br/>
        /// Get the credits an audio create request charges. Pass `tool`, then the field below that the tool's create request uses. Does not create a project or spend credits. It prices the fields passed here. It does not check your plan, your balance or the rest of the create request.
        /// </summary>
        /// <param name="tool">
        /// Example: ai-voice-generator
        /// </param>
        /// <param name="characterCount">
        /// Example: 120
        /// </param>
        /// <param name="duration"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::MagicHour.AutoSDKHttpResponse<global::MagicHour.EstimateAudioResponse>> EstimateAudioAsResponseAsync(
            global::MagicHour.EstimateAudioTool tool,
            int? characterCount = default,
            int? duration = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}