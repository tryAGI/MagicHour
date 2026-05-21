#nullable enable

namespace MagicHour
{
    public partial interface IImageProjectsClient
    {
        /// <summary>
        /// AI GIF Generator<br/>
        /// Create an AI GIF. Each GIF costs 50 credits.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/ai-gif-generator \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header 'authorization: Bearer &lt;token&gt;' \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Ai Gif gif",<br/>
        ///   "style": {<br/>
        ///     "prompt": "Cute dancing cat, pixel art"<br/>
        ///   },<br/>
        ///   "output_format": "gif"<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.AiGifGeneratorCreateImageResponse> AiGifGeneratorCreateImageAsync(

            global::MagicHour.AiGifGeneratorCreateImageRequest request,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// AI GIF Generator<br/>
        /// Create an AI GIF. Each GIF costs 50 credits.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/ai-gif-generator \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header 'authorization: Bearer &lt;token&gt;' \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Ai Gif gif",<br/>
        ///   "style": {<br/>
        ///     "prompt": "Cute dancing cat, pixel art"<br/>
        ///   },<br/>
        ///   "output_format": "gif"<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.AutoSDKHttpResponse<global::MagicHour.AiGifGeneratorCreateImageResponse>> AiGifGeneratorCreateImageAsResponseAsync(

            global::MagicHour.AiGifGeneratorCreateImageRequest request,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// AI GIF Generator<br/>
        /// Create an AI GIF. Each GIF costs 50 credits.
        /// </summary>
        /// <param name="name">
        /// Give your gif a custom name for easy identification.<br/>
        /// Default Value: Ai Gif - dateTime<br/>
        /// Example: My Ai Gif gif
        /// </param>
        /// <param name="style"></param>
        /// <param name="outputFormat">
        /// The output file format for the generated animation.<br/>
        /// Default Value: gif<br/>
        /// Example: gif
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MagicHour.AiGifGeneratorCreateImageResponse> AiGifGeneratorCreateImageAsync(
            global::MagicHour.AiGifGeneratorCreateImageRequestStyle style,
            string? name = default,
            global::MagicHour.AiGifGeneratorCreateImageRequestOutputFormat? outputFormat = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}