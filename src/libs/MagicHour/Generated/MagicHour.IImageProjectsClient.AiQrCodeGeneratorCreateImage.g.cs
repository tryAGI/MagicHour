#nullable enable

namespace MagicHour
{
    public partial interface IImageProjectsClient
    {
        /// <summary>
        /// AI QR Code Generator<br/>
        /// Create an AI QR code. Each QR code costs 0 credits.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/ai-qr-code-generator \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header 'authorization: Bearer &lt;token&gt;' \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Qr Code image",<br/>
        ///   "content": "https://magichour.ai",<br/>
        ///   "style": {<br/>
        ///     "art_style": "Watercolor"<br/>
        ///   }<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.AiQrCodeGeneratorCreateImageResponse> AiQrCodeGeneratorCreateImageAsync(

            global::MagicHour.AiQrCodeGeneratorCreateImageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// AI QR Code Generator<br/>
        /// Create an AI QR code. Each QR code costs 0 credits.
        /// </summary>
        /// <param name="name">
        /// Give your image a custom name for easy identification.<br/>
        /// Default Value: Qr Code - dateTime<br/>
        /// Example: My Qr Code image
        /// </param>
        /// <param name="content">
        /// The content of the QR code.<br/>
        /// Example: https://magichour.ai
        /// </param>
        /// <param name="style"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MagicHour.AiQrCodeGeneratorCreateImageResponse> AiQrCodeGeneratorCreateImageAsync(
            string content,
            global::MagicHour.AiQrCodeGeneratorCreateImageRequestStyle style,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}