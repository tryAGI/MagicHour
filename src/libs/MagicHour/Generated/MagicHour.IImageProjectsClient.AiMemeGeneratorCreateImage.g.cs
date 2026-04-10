#nullable enable

namespace MagicHour
{
    public partial interface IImageProjectsClient
    {
        /// <summary>
        /// AI Meme Generator<br/>
        /// Create an AI generated meme. Each meme costs 10 credits.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/ai-meme-generator \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header 'authorization: Bearer &lt;token&gt;' \<br/>
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
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// AI Meme Generator<br/>
        /// Create an AI generated meme. Each meme costs 10 credits.
        /// </summary>
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
            string? name = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}