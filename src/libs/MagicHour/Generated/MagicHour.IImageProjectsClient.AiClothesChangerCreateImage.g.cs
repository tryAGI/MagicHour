#nullable enable

namespace MagicHour
{
    public partial interface IImageProjectsClient
    {
        /// <summary>
        /// AI Clothes Changer<br/>
        /// Change outfits in photos in seconds with just a photo reference. Each photo costs 25 credits.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/ai-clothes-changer \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header 'authorization: Bearer &lt;token&gt;' \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Clothes Changer image",<br/>
        ///   "assets": {<br/>
        ///     "person_file_path": "api-assets/id/model.png",<br/>
        ///     "garment_file_path": "api-assets/id/outfit.png",<br/>
        ///     "garment_type": "entire_outfit"<br/>
        ///   }<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.AiClothesChangerCreateImageResponse> AiClothesChangerCreateImageAsync(

            global::MagicHour.AiClothesChangerCreateImageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// AI Clothes Changer<br/>
        /// Change outfits in photos in seconds with just a photo reference. Each photo costs 25 credits.
        /// </summary>
        /// <param name="name">
        /// Give your image a custom name for easy identification.<br/>
        /// Default Value: Clothes Changer - dateTime<br/>
        /// Example: My Clothes Changer image
        /// </param>
        /// <param name="assets">
        /// Provide the assets for clothes changer
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MagicHour.AiClothesChangerCreateImageResponse> AiClothesChangerCreateImageAsync(
            global::MagicHour.AiClothesChangerCreateImageRequestAssets assets,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}