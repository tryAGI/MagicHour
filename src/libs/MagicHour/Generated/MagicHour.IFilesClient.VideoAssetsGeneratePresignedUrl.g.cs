#nullable enable

namespace MagicHour
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Generate asset upload urls<br/>
        /// Generates a list of pre-signed upload URLs for the assets required. This API is only necessary if you want to upload to Magic Hour's storage. Refer to the [Input Files Guide](/integration/input-files) for more details.<br/>
        /// The response array will match the order of items in the request body.<br/>
        /// **Valid file extensions per asset type**:<br/>
        /// - video: mp4, m4v, mov, webm<br/>
        /// - audio: mp3, wav, aac, flac, webm, m4a<br/>
        /// - image: png, jpg, jpeg, heic, heif, webp, avif, jp2, tiff, bmp<br/>
        /// - gif: gif, webp, webm<br/>
        /// &gt; Note: `gif` is only supported for face swap API `video_file_path` field.<br/>
        /// Once you receive an upload URL, send a `PUT` request to upload the file directly.<br/>
        /// Example:<br/>
        /// ```<br/>
        /// curl -X PUT --data '@/path/to/file/video.mp4' \<br/>
        ///   https://videos.magichour.ai/api-assets/id/video.mp4?&lt;auth params from the API response&gt;<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/files/upload-urls \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header 'authorization: Bearer &lt;token&gt;' \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "items": [<br/>
        ///     {<br/>
        ///       "type": "video",<br/>
        ///       "extension": "mp4"<br/>
        ///     },<br/>
        ///     {<br/>
        ///       "type": "audio",<br/>
        ///       "extension": "mp3"<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.VideoAssetsGeneratePresignedUrlResponse> VideoAssetsGeneratePresignedUrlAsync(

            global::MagicHour.VideoAssetsGeneratePresignedUrlRequest request,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate asset upload urls<br/>
        /// Generates a list of pre-signed upload URLs for the assets required. This API is only necessary if you want to upload to Magic Hour's storage. Refer to the [Input Files Guide](/integration/input-files) for more details.<br/>
        /// The response array will match the order of items in the request body.<br/>
        /// **Valid file extensions per asset type**:<br/>
        /// - video: mp4, m4v, mov, webm<br/>
        /// - audio: mp3, wav, aac, flac, webm, m4a<br/>
        /// - image: png, jpg, jpeg, heic, heif, webp, avif, jp2, tiff, bmp<br/>
        /// - gif: gif, webp, webm<br/>
        /// &gt; Note: `gif` is only supported for face swap API `video_file_path` field.<br/>
        /// Once you receive an upload URL, send a `PUT` request to upload the file directly.<br/>
        /// Example:<br/>
        /// ```<br/>
        /// curl -X PUT --data '@/path/to/file/video.mp4' \<br/>
        ///   https://videos.magichour.ai/api-assets/id/video.mp4?&lt;auth params from the API response&gt;<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/files/upload-urls \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header 'authorization: Bearer &lt;token&gt;' \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "items": [<br/>
        ///     {<br/>
        ///       "type": "video",<br/>
        ///       "extension": "mp4"<br/>
        ///     },<br/>
        ///     {<br/>
        ///       "type": "audio",<br/>
        ///       "extension": "mp3"<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.AutoSDKHttpResponse<global::MagicHour.VideoAssetsGeneratePresignedUrlResponse>> VideoAssetsGeneratePresignedUrlAsResponseAsync(

            global::MagicHour.VideoAssetsGeneratePresignedUrlRequest request,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate asset upload urls<br/>
        /// Generates a list of pre-signed upload URLs for the assets required. This API is only necessary if you want to upload to Magic Hour's storage. Refer to the [Input Files Guide](/integration/input-files) for more details.<br/>
        /// The response array will match the order of items in the request body.<br/>
        /// **Valid file extensions per asset type**:<br/>
        /// - video: mp4, m4v, mov, webm<br/>
        /// - audio: mp3, wav, aac, flac, webm, m4a<br/>
        /// - image: png, jpg, jpeg, heic, heif, webp, avif, jp2, tiff, bmp<br/>
        /// - gif: gif, webp, webm<br/>
        /// &gt; Note: `gif` is only supported for face swap API `video_file_path` field.<br/>
        /// Once you receive an upload URL, send a `PUT` request to upload the file directly.<br/>
        /// Example:<br/>
        /// ```<br/>
        /// curl -X PUT --data '@/path/to/file/video.mp4' \<br/>
        ///   https://videos.magichour.ai/api-assets/id/video.mp4?&lt;auth params from the API response&gt;<br/>
        /// ```
        /// </summary>
        /// <param name="items">
        /// The list of assets to upload. The response array will match the order of items in the request body.<br/>
        /// Example: [{"type":"video","extension":"mp4"}, {"type":"audio","extension":"mp3"}]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MagicHour.VideoAssetsGeneratePresignedUrlResponse> VideoAssetsGeneratePresignedUrlAsync(
            global::System.Collections.Generic.IList<global::MagicHour.VideoAssetsGeneratePresignedUrlRequestItem> items,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}