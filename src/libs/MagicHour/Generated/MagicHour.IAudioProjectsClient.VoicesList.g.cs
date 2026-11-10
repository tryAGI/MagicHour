#nullable enable

namespace MagicHour
{
    public partial interface IAudioProjectsClient
    {
        /// <summary>
        /// List voices<br/>
        /// List the voices available for text-to-speech. Use a voice's `id` as `style.voice_name` in the AI Voice Generator API. To fetch the next page, pass the response's next_cursor as cursor.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20<br/>
        /// Example: 20
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        ///      --url https://api.magichour.ai/v1/voices \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header "authorization: Bearer $MAGIC_HOUR_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.VoicesListResponse> VoicesListAsync(
            int? limit = default,
            string? cursor = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List voices<br/>
        /// List the voices available for text-to-speech. Use a voice's `id` as `style.voice_name` in the AI Voice Generator API. To fetch the next page, pass the response's next_cursor as cursor.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20<br/>
        /// Example: 20
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        ///      --url https://api.magichour.ai/v1/voices \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header "authorization: Bearer $MAGIC_HOUR_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.AutoSDKHttpResponse<global::MagicHour.VoicesListResponse>> VoicesListAsResponseAsync(
            int? limit = default,
            string? cursor = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}