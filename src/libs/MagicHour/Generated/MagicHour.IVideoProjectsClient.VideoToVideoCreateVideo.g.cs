#nullable enable

namespace MagicHour
{
    public partial interface IVideoProjectsClient
    {
        /// <summary>
        /// Video-to-Video<br/>
        /// **What this API does**<br/>
        /// Create the same Video To Video you can make in the browser, but programmatically, so you can automate it, run it at scale, or connect it to your own app or workflow.<br/>
        ///     <br/>
        /// **Good for**<br/>
        /// - Automation and batch processing  <br/>
        /// - Adding video to video into apps, pipelines, or tools  <br/>
        /// **How it works (3 steps)**<br/>
        /// 1) Upload your inputs (video, image, or audio) with [Generate Upload URLs](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls) and copy the `file_path`.  <br/>
        /// 2) Send a request to create a video to video job with the basic fields.  <br/>
        /// 3) Check the job status until it's `complete`, then download the result from `downloads`.<br/>
        /// **Key options**<br/>
        /// - Inputs: usually a file, sometimes a YouTube link, depending on project type  <br/>
        /// - Resolution: output size and plan requirements vary by workflow and model. Some workflows derive output size from the input video.<br/>
        /// - Extra fields: e.g. `face_swap_mode`, `start_seconds`/`end_seconds`, or a text prompt  <br/>
        /// **Cost**  <br/>
        /// Credits are charged when the job is queued (`credits_charged` in the response). Tools billed per frame charge an estimate and settle to the frames that actually render once the job finishes; tools billed per second charge the final amount upfront. Failed jobs are refunded.<br/>
        /// For detailed examples, see the [product page](https://magichour.ai/products/video-to-video).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/video-to-video \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header "authorization: Bearer $MAGIC_HOUR_API_KEY" \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Video To Video video",<br/>
        ///   "start_seconds": 0,<br/>
        ///   "end_seconds": 5,<br/>
        ///   "fps_resolution": "HALF",<br/>
        ///   "style": {<br/>
        ///     "art_style": "Minecraft",<br/>
        ///     "version": "default",<br/>
        ///     "prompt_type": "default",<br/>
        ///     "prompt": "A cinematic scene with warm lighting",<br/>
        ///     "model": "default"<br/>
        ///   },<br/>
        ///   "assets": {<br/>
        ///     "video_source": "file",<br/>
        ///     "video_file_path": "api-assets/id/1234.mp4"<br/>
        ///   }<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.VideoToVideoCreateVideoResponse> VideoToVideoCreateVideoAsync(

            global::MagicHour.VideoToVideoCreateVideoRequest request,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Video-to-Video<br/>
        /// **What this API does**<br/>
        /// Create the same Video To Video you can make in the browser, but programmatically, so you can automate it, run it at scale, or connect it to your own app or workflow.<br/>
        ///     <br/>
        /// **Good for**<br/>
        /// - Automation and batch processing  <br/>
        /// - Adding video to video into apps, pipelines, or tools  <br/>
        /// **How it works (3 steps)**<br/>
        /// 1) Upload your inputs (video, image, or audio) with [Generate Upload URLs](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls) and copy the `file_path`.  <br/>
        /// 2) Send a request to create a video to video job with the basic fields.  <br/>
        /// 3) Check the job status until it's `complete`, then download the result from `downloads`.<br/>
        /// **Key options**<br/>
        /// - Inputs: usually a file, sometimes a YouTube link, depending on project type  <br/>
        /// - Resolution: output size and plan requirements vary by workflow and model. Some workflows derive output size from the input video.<br/>
        /// - Extra fields: e.g. `face_swap_mode`, `start_seconds`/`end_seconds`, or a text prompt  <br/>
        /// **Cost**  <br/>
        /// Credits are charged when the job is queued (`credits_charged` in the response). Tools billed per frame charge an estimate and settle to the frames that actually render once the job finishes; tools billed per second charge the final amount upfront. Failed jobs are refunded.<br/>
        /// For detailed examples, see the [product page](https://magichour.ai/products/video-to-video).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/video-to-video \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header "authorization: Bearer $MAGIC_HOUR_API_KEY" \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Video To Video video",<br/>
        ///   "start_seconds": 0,<br/>
        ///   "end_seconds": 5,<br/>
        ///   "fps_resolution": "HALF",<br/>
        ///   "style": {<br/>
        ///     "art_style": "Minecraft",<br/>
        ///     "version": "default",<br/>
        ///     "prompt_type": "default",<br/>
        ///     "prompt": "A cinematic scene with warm lighting",<br/>
        ///     "model": "default"<br/>
        ///   },<br/>
        ///   "assets": {<br/>
        ///     "video_source": "file",<br/>
        ///     "video_file_path": "api-assets/id/1234.mp4"<br/>
        ///   }<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.AutoSDKHttpResponse<global::MagicHour.VideoToVideoCreateVideoResponse>> VideoToVideoCreateVideoAsResponseAsync(

            global::MagicHour.VideoToVideoCreateVideoRequest request,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Video-to-Video<br/>
        /// **What this API does**<br/>
        /// Create the same Video To Video you can make in the browser, but programmatically, so you can automate it, run it at scale, or connect it to your own app or workflow.<br/>
        ///     <br/>
        /// **Good for**<br/>
        /// - Automation and batch processing  <br/>
        /// - Adding video to video into apps, pipelines, or tools  <br/>
        /// **How it works (3 steps)**<br/>
        /// 1) Upload your inputs (video, image, or audio) with [Generate Upload URLs](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls) and copy the `file_path`.  <br/>
        /// 2) Send a request to create a video to video job with the basic fields.  <br/>
        /// 3) Check the job status until it's `complete`, then download the result from `downloads`.<br/>
        /// **Key options**<br/>
        /// - Inputs: usually a file, sometimes a YouTube link, depending on project type  <br/>
        /// - Resolution: output size and plan requirements vary by workflow and model. Some workflows derive output size from the input video.<br/>
        /// - Extra fields: e.g. `face_swap_mode`, `start_seconds`/`end_seconds`, or a text prompt  <br/>
        /// **Cost**  <br/>
        /// Credits are charged when the job is queued (`credits_charged` in the response). Tools billed per frame charge an estimate and settle to the frames that actually render once the job finishes; tools billed per second charge the final amount upfront. Failed jobs are refunded.<br/>
        /// For detailed examples, see the [product page](https://magichour.ai/products/video-to-video).
        /// </summary>
        /// <param name="name">
        /// Give your video a custom name for easy identification.<br/>
        /// Default Value: Video To Video - dateTime<br/>
        /// Example: My Video To Video video
        /// </param>
        /// <param name="startSeconds">
        /// Start time of your clip (seconds). Must be ≥ 0.<br/>
        /// Example: 0
        /// </param>
        /// <param name="endSeconds">
        /// End time of your clip (seconds). Must be greater than start_seconds.<br/>
        /// Example: 5
        /// </param>
        /// <param name="fpsResolution">
        /// Determines whether the resulting video will have the same frame per second as the original video, or half.<br/>
        /// * `FULL` - the result video will have the same FPS as the input video<br/>
        /// * `HALF` - the result video will have half the FPS as the input video<br/>
        /// Default Value: HALF<br/>
        /// Example: HALF
        /// </param>
        /// <param name="style"></param>
        /// <param name="assets">
        /// Provide the assets for video-to-video. For video, The `video_source` field determines whether `video_file_path` or `youtube_url` field is used<br/>
        /// Example: {"video_source":"file","video_file_path":"api-assets/id/1234.mp4"}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MagicHour.VideoToVideoCreateVideoResponse> VideoToVideoCreateVideoAsync(
            float startSeconds,
            float endSeconds,
            global::MagicHour.VideoToVideoCreateVideoRequestStyle style,
            global::MagicHour.VideoToVideoCreateVideoRequestAssets assets,
            string? name = default,
            global::MagicHour.VideoToVideoCreateVideoRequestFpsResolution? fpsResolution = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}