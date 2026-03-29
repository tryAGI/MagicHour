#nullable enable

namespace MagicHour
{
    public partial interface IImageProjectsClient
    {
        /// <summary>
        /// Image Background Remover<br/>
        /// Remove background from image. Each image costs 5 credits.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/image-background-remover \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header 'authorization: Bearer &lt;token&gt;' \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Background Remover image",<br/>
        ///   "assets": {<br/>
        ///     "image_file_path": "api-assets/id/1234.png",<br/>
        ///     "background_image_file_path": "api-assets/id/1234.png"<br/>
        ///   }<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.ImageBackgroundRemoverCreateImageResponse> ImageBackgroundRemoverCreateImageAsync(

            global::MagicHour.ImageBackgroundRemoverCreateImageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Image Background Remover<br/>
        /// Remove background from image. Each image costs 5 credits.
        /// </summary>
        /// <param name="name">
        /// Give your image a custom name for easy identification.<br/>
        /// Default Value: Background Remover - dateTime<br/>
        /// Example: My Background Remover image
        /// </param>
        /// <param name="assets">
        /// Provide the assets for background removal
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MagicHour.ImageBackgroundRemoverCreateImageResponse> ImageBackgroundRemoverCreateImageAsync(
            global::MagicHour.ImageBackgroundRemoverCreateImageRequestAssets assets,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}