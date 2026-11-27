#nullable enable

namespace MagicHour
{
    public partial interface IImageProjectsClient
    {
        /// <summary>
        /// AI Meme Generator<br/>
        /// Create an AI generated meme. Each meme costs 10 credits.
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
        ///      --url https://api.magichour.ai/v1/ai-meme-generator \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header "authorization: Bearer $MAGIC_HOUR_API_KEY" \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Funny Meme",<br/>
        ///   "style": {<br/>
        ///     "topic": "When the code finally works",<br/>
        ///     "template": "Drake Hotline Bling",<br/>
        ///     "searchWeb": false<br/>
        ///   }<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.AiMemeGeneratorCreateImageResponse> AiMemeGeneratorCreateImageAsync(

            global::MagicHour.AiMemeGeneratorCreateImageRequest request,
            string? idempotencyKey = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// AI Meme Generator<br/>
        /// Create an AI generated meme. Each meme costs 10 credits.
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
        ///      --url https://api.magichour.ai/v1/ai-meme-generator \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header "authorization: Bearer $MAGIC_HOUR_API_KEY" \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Funny Meme",<br/>
        ///   "style": {<br/>
        ///     "topic": "When the code finally works",<br/>
        ///     "template": "Drake Hotline Bling",<br/>
        ///     "searchWeb": false<br/>
        ///   }<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.AutoSDKHttpResponse<global::MagicHour.AiMemeGeneratorCreateImageResponse>> AiMemeGeneratorCreateImageAsResponseAsync(

            global::MagicHour.AiMemeGeneratorCreateImageRequest request,
            string? idempotencyKey = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// AI Meme Generator<br/>
        /// Create an AI generated meme. Each meme costs 10 credits.
        /// </summary>
        /// <param name="idempotencyKey">
        /// A unique string for this request, such as a UUID. Sending the same key again within 24 hours returns the original project instead of creating and charging for a new one. A key applies across all video, image, and audio endpoints on your account, so use a new key for every project.<br/>
        /// Example: 5f3c1b9e-8a41-4a0e-9d3e-2f6a1c7b9e10
        /// </param>
        /// <param name="name">
        /// The name of the meme.<br/>
        /// Example: My Funny Meme
        /// </param>
        /// <param name="style"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MagicHour.AiMemeGeneratorCreateImageResponse> AiMemeGeneratorCreateImageAsync(
            global::MagicHour.AiMemeGeneratorCreateImageRequestStyle style,
            string? idempotencyKey = default,
            string? name = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}