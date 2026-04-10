#nullable enable

namespace MagicHour
{
    public partial interface IImageProjectsClient
    {
        /// <summary>
        /// AI Headshot Generator<br/>
        /// Create an AI headshot. Each headshot costs 50 credits.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/ai-headshot-generator \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header 'authorization: Bearer &lt;token&gt;' \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Ai Headshot image",<br/>
        ///   "style": {<br/>
        ///     "prompt": "string"<br/>
        ///   },<br/>
        ///   "assets": {<br/>
        ///     "image_file_path": "api-assets/id/1234.png"<br/>
        ///   }<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.AiHeadshotGeneratorCreateImageResponse> AiHeadshotGeneratorCreateImageAsync(

            global::MagicHour.AiHeadshotGeneratorCreateImageRequest request,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// AI Headshot Generator<br/>
        /// Create an AI headshot. Each headshot costs 50 credits.
        /// </summary>
        /// <param name="name">
        /// Give your image a custom name for easy identification.<br/>
        /// Default Value: Ai Headshot - dateTime<br/>
        /// Example: My Ai Headshot image
        /// </param>
        /// <param name="style"></param>
        /// <param name="assets">
        /// Provide the assets for headshot photo
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MagicHour.AiHeadshotGeneratorCreateImageResponse> AiHeadshotGeneratorCreateImageAsync(
            global::MagicHour.AiHeadshotGeneratorCreateImageRequestAssets assets,
            string? name = default,
            global::MagicHour.AiHeadshotGeneratorCreateImageRequestStyle? style = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}