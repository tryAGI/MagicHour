#nullable enable

namespace MagicHour
{
    public partial interface IVideoProjectsClient
    {
        /// <summary>
        /// Character Replace<br/>
        /// **What this API does**<br/>
        /// Create the same Character Replace you can make in the browser, but programmatically, so you can automate it, run it at scale, or connect it to your own app or workflow.<br/>
        ///     <br/>
        /// **Good for**<br/>
        /// - Automation and batch processing  <br/>
        /// - Adding character replace into apps, pipelines, or tools  <br/>
        /// **How it works (3 steps)**<br/>
        /// 1) Upload your inputs (video, image, or audio) with [Generate Upload URLs](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls) and copy the `file_path`.  <br/>
        /// 2) Send a request to create a character replace job with the basic fields.  <br/>
        /// 3) Check the job status until it's `complete`, then download the result from `downloads`.<br/>
        /// **Key options**<br/>
        /// - Inputs: usually a file, sometimes a YouTube link, depending on project type  <br/>
        /// - Resolution: output size and plan requirements vary by workflow and model. Some workflows derive output size from the input video.<br/>
        /// - Extra fields: e.g. `face_swap_mode`, `start_seconds`/`end_seconds`, or a text prompt  <br/>
        /// **Cost**  <br/>
        /// Credits are charged when the job is queued (`credits_charged` in the response). Tools billed per frame charge an estimate and settle to the frames that actually render once the job finishes; tools billed per second charge the final amount upfront. Failed jobs are refunded.<br/>
        /// For detailed examples, see the [product page](https://magichour.ai/products/character-replace).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/character-replace \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header "authorization: Bearer $MAGIC_HOUR_API_KEY" \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Character Replace video",<br/>
        ///   "start_seconds": 0,<br/>
        ///   "end_seconds": 5,<br/>
        ///   "model": "wan-animate",<br/>
        ///   "resolution": "480p",<br/>
        ///   "assets": {<br/>
        ///     "video_file_path": "api-assets/id/1234.mp4",<br/>
        ///     "image_file_path": "api-assets/id/5678.png"<br/>
        ///   },<br/>
        ///   "style": {<br/>
        ///     "mode": "replace",<br/>
        ///     "selection_mode": "auto"<br/>
        ///   }<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.CharacterReplaceCreateVideoResponse> CharacterReplaceCreateVideoAsync(

            global::MagicHour.CharacterReplaceCreateVideoRequest request,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Character Replace<br/>
        /// **What this API does**<br/>
        /// Create the same Character Replace you can make in the browser, but programmatically, so you can automate it, run it at scale, or connect it to your own app or workflow.<br/>
        ///     <br/>
        /// **Good for**<br/>
        /// - Automation and batch processing  <br/>
        /// - Adding character replace into apps, pipelines, or tools  <br/>
        /// **How it works (3 steps)**<br/>
        /// 1) Upload your inputs (video, image, or audio) with [Generate Upload URLs](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls) and copy the `file_path`.  <br/>
        /// 2) Send a request to create a character replace job with the basic fields.  <br/>
        /// 3) Check the job status until it's `complete`, then download the result from `downloads`.<br/>
        /// **Key options**<br/>
        /// - Inputs: usually a file, sometimes a YouTube link, depending on project type  <br/>
        /// - Resolution: output size and plan requirements vary by workflow and model. Some workflows derive output size from the input video.<br/>
        /// - Extra fields: e.g. `face_swap_mode`, `start_seconds`/`end_seconds`, or a text prompt  <br/>
        /// **Cost**  <br/>
        /// Credits are charged when the job is queued (`credits_charged` in the response). Tools billed per frame charge an estimate and settle to the frames that actually render once the job finishes; tools billed per second charge the final amount upfront. Failed jobs are refunded.<br/>
        /// For detailed examples, see the [product page](https://magichour.ai/products/character-replace).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/character-replace \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header "authorization: Bearer $MAGIC_HOUR_API_KEY" \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Character Replace video",<br/>
        ///   "start_seconds": 0,<br/>
        ///   "end_seconds": 5,<br/>
        ///   "model": "wan-animate",<br/>
        ///   "resolution": "480p",<br/>
        ///   "assets": {<br/>
        ///     "video_file_path": "api-assets/id/1234.mp4",<br/>
        ///     "image_file_path": "api-assets/id/5678.png"<br/>
        ///   },<br/>
        ///   "style": {<br/>
        ///     "mode": "replace",<br/>
        ///     "selection_mode": "auto"<br/>
        ///   }<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.AutoSDKHttpResponse<global::MagicHour.CharacterReplaceCreateVideoResponse>> CharacterReplaceCreateVideoAsResponseAsync(

            global::MagicHour.CharacterReplaceCreateVideoRequest request,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Character Replace<br/>
        /// **What this API does**<br/>
        /// Create the same Character Replace you can make in the browser, but programmatically, so you can automate it, run it at scale, or connect it to your own app or workflow.<br/>
        ///     <br/>
        /// **Good for**<br/>
        /// - Automation and batch processing  <br/>
        /// - Adding character replace into apps, pipelines, or tools  <br/>
        /// **How it works (3 steps)**<br/>
        /// 1) Upload your inputs (video, image, or audio) with [Generate Upload URLs](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls) and copy the `file_path`.  <br/>
        /// 2) Send a request to create a character replace job with the basic fields.  <br/>
        /// 3) Check the job status until it's `complete`, then download the result from `downloads`.<br/>
        /// **Key options**<br/>
        /// - Inputs: usually a file, sometimes a YouTube link, depending on project type  <br/>
        /// - Resolution: output size and plan requirements vary by workflow and model. Some workflows derive output size from the input video.<br/>
        /// - Extra fields: e.g. `face_swap_mode`, `start_seconds`/`end_seconds`, or a text prompt  <br/>
        /// **Cost**  <br/>
        /// Credits are charged when the job is queued (`credits_charged` in the response). Tools billed per frame charge an estimate and settle to the frames that actually render once the job finishes; tools billed per second charge the final amount upfront. Failed jobs are refunded.<br/>
        /// For detailed examples, see the [product page](https://magichour.ai/products/character-replace).
        /// </summary>
        /// <param name="name">
        /// Give your video a custom name for easy identification.<br/>
        /// Default Value: Character Replace - dateTime<br/>
        /// Example: My Character Replace video
        /// </param>
        /// <param name="startSeconds">
        /// Start time of your clip (seconds). Must be ≥ 0.<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="endSeconds">
        /// End time of your clip (seconds). Must be greater than start_seconds.<br/>
        /// Example: 5
        /// </param>
        /// <param name="model">
        /// Model to use. Defaults to `wan-animate`.<br/>
        /// * **`wan-animate`**: 480p, 720p. Supports `points` subject selection.<br/>
        /// * **`kling-3.0`**: 720p, 1080p. Clips of 3–10 seconds in `replace` mode or 3–30 seconds in `animate` mode. Picks the main person automatically, so `points` are rejected.<br/>
        /// * **`minimax-h3`**: 480p, 720p, 1080p. Clips of 1–60 seconds in `replace` mode or 1–60 seconds in `animate` mode. Subject `points` are `replace`-only; `animate` with `selection_mode` `point` returns 422, and with `auto` or no `selection_mode` the points are ignored.<br/>
        /// Default Value: wan-animate<br/>
        /// Example: wan-animate
        /// </param>
        /// <param name="resolution">
        /// Output video resolution. Must be supported by `model`. Defaults to the lowest resolution available on your plan for that model.<br/>
        /// Example: 480p
        /// </param>
        /// <param name="assets">
        /// Source video and reference character image for the job.
        /// </param>
        /// <param name="style">
        /// Optional style controls for replace vs animate mode and subject selection.<br/>
        /// Example: {"mode":"replace","selection_mode":"auto"}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MagicHour.CharacterReplaceCreateVideoResponse> CharacterReplaceCreateVideoAsync(
            float endSeconds,
            global::MagicHour.CharacterReplaceCreateVideoRequestAssets assets,
            string? name = default,
            float? startSeconds = default,
            global::MagicHour.CharacterReplaceCreateVideoRequestModel? model = default,
            global::MagicHour.CharacterReplaceCreateVideoRequestResolution? resolution = default,
            global::MagicHour.CharacterReplaceCreateVideoRequestStyle? style = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}