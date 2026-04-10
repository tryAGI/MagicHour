#nullable enable

namespace MagicHour
{
    public partial interface IVideoProjectsClient
    {
        /// <summary>
        /// Lip Sync<br/>
        /// **What this API does**<br/>
        /// Create the same Lip Sync you can make in the browser, but programmatically, so you can automate it, run it at scale, or connect it to your own app or workflow.<br/>
        ///     <br/>
        /// **Good for**<br/>
        /// - Automation and batch processing  <br/>
        /// - Adding lip sync into apps, pipelines, or tools  <br/>
        /// **How it works (3 steps)**<br/>
        /// 1) Upload your inputs (video, image, or audio) with [Generate Upload URLs](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls) and copy the `file_path`.  <br/>
        /// 2) Send a request to create a lip sync job with the basic fields.  <br/>
        /// 3) Check the job status until it's `complete`, then download the result from `downloads`.<br/>
        /// **Key options**<br/>
        /// - Inputs: usually a file, sometimes a YouTube link, depending on project type  <br/>
        /// - Resolution: free users are limited to 576px; higher plans unlock HD and larger sizes  <br/>
        /// - Extra fields: e.g. `face_swap_mode`, `start_seconds`/`end_seconds`, or a text prompt  <br/>
        /// **Cost**  <br/>
        /// Credits are only charged for the frames that actually render. You'll see an estimate when the job is queued, and the final total after it's done.<br/>
        /// For detailed examples, see the [product page](https://magichour.ai/products/lip-sync).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/lip-sync \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header 'authorization: Bearer &lt;token&gt;' \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Lip Sync video",<br/>
        ///   "start_seconds": 0,<br/>
        ///   "end_seconds": 15,<br/>
        ///   "max_fps_limit": 12,<br/>
        ///   "assets": {<br/>
        ///     "audio_file_path": "api-assets/id/1234.mp3",<br/>
        ///     "video_source": "file",<br/>
        ///     "video_file_path": "api-assets/id/1234.mp4",<br/>
        ///     "youtube_url": "string"<br/>
        ///   },<br/>
        ///   "style": {<br/>
        ///     "generation_mode": "lite"<br/>
        ///   }<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.LipSyncCreateVideoResponse> LipSyncCreateVideoAsync(

            global::MagicHour.LipSyncCreateVideoRequest request,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Lip Sync<br/>
        /// **What this API does**<br/>
        /// Create the same Lip Sync you can make in the browser, but programmatically, so you can automate it, run it at scale, or connect it to your own app or workflow.<br/>
        ///     <br/>
        /// **Good for**<br/>
        /// - Automation and batch processing  <br/>
        /// - Adding lip sync into apps, pipelines, or tools  <br/>
        /// **How it works (3 steps)**<br/>
        /// 1) Upload your inputs (video, image, or audio) with [Generate Upload URLs](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls) and copy the `file_path`.  <br/>
        /// 2) Send a request to create a lip sync job with the basic fields.  <br/>
        /// 3) Check the job status until it's `complete`, then download the result from `downloads`.<br/>
        /// **Key options**<br/>
        /// - Inputs: usually a file, sometimes a YouTube link, depending on project type  <br/>
        /// - Resolution: free users are limited to 576px; higher plans unlock HD and larger sizes  <br/>
        /// - Extra fields: e.g. `face_swap_mode`, `start_seconds`/`end_seconds`, or a text prompt  <br/>
        /// **Cost**  <br/>
        /// Credits are only charged for the frames that actually render. You'll see an estimate when the job is queued, and the final total after it's done.<br/>
        /// For detailed examples, see the [product page](https://magichour.ai/products/lip-sync).
        /// </summary>
        /// <param name="name">
        /// Give your video a custom name for easy identification.<br/>
        /// Default Value: Lip Sync - dateTime<br/>
        /// Example: My Lip Sync video
        /// </param>
        /// <param name="startSeconds">
        /// Start time of your clip (seconds). Must be ≥ 0.<br/>
        /// Example: 0
        /// </param>
        /// <param name="endSeconds">
        /// End time of your clip (seconds). Must be greater than start_seconds.<br/>
        /// Example: 15
        /// </param>
        /// <param name="maxFpsLimit">
        /// Defines the maximum FPS (frames per second) for the output video. If the input video's FPS is lower than this limit, the output video will retain the input FPS. This is useful for reducing unnecessary frame usage in scenarios where high FPS is not required.<br/>
        /// Example: 12
        /// </param>
        /// <param name="assets">
        /// Provide the assets for lip-sync. For video, The `video_source` field determines whether `video_file_path` or `youtube_url` field is used
        /// </param>
        /// <param name="style">
        /// Attributes used to dictate the style of the output
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MagicHour.LipSyncCreateVideoResponse> LipSyncCreateVideoAsync(
            float startSeconds,
            float endSeconds,
            global::MagicHour.LipSyncCreateVideoRequestAssets assets,
            string? name = default,
            double? maxFpsLimit = default,
            global::MagicHour.LipSyncCreateVideoRequestStyle? style = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}