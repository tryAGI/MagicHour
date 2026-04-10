#nullable enable

namespace MagicHour
{
    public partial interface IVideoProjectsClient
    {
        /// <summary>
        /// Text-to-Video<br/>
        /// **What this API does**<br/>
        /// Create the same Text To Video you can make in the browser, but programmatically, so you can automate it, run it at scale, or connect it to your own app or workflow.<br/>
        ///     <br/>
        /// **Good for**<br/>
        /// - Automation and batch processing  <br/>
        /// - Adding text to video into apps, pipelines, or tools  <br/>
        /// **How it works (3 steps)**<br/>
        /// 1) Upload your inputs (video, image, or audio) with [Generate Upload URLs](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls) and copy the `file_path`.  <br/>
        /// 2) Send a request to create a text to video job with the basic fields.  <br/>
        /// 3) Check the job status until it's `complete`, then download the result from `downloads`.<br/>
        /// **Key options**<br/>
        /// - Inputs: usually a file, sometimes a YouTube link, depending on project type  <br/>
        /// - Resolution: free users are limited to 576px; higher plans unlock HD and larger sizes  <br/>
        /// - Extra fields: e.g. `face_swap_mode`, `start_seconds`/`end_seconds`, or a text prompt  <br/>
        /// **Cost**  <br/>
        /// Credits are only charged for the frames that actually render. You'll see an estimate when the job is queued, and the final total after it's done.<br/>
        /// For detailed examples, see the [product page](https://magichour.ai/products/text-to-video).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/text-to-video \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header 'authorization: Bearer &lt;token&gt;' \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Text To Video video",<br/>
        ///   "end_seconds": 5,<br/>
        ///   "aspect_ratio": "16:9",<br/>
        ///   "resolution": "720p",<br/>
        ///   "model": "kling-3.0",<br/>
        ///   "audio": true,<br/>
        ///   "style": {<br/>
        ///     "prompt": "a dog running"<br/>
        ///   }<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.TextToVideoCreateVideoResponse> TextToVideoCreateVideoAsync(

            global::MagicHour.TextToVideoCreateVideoRequest request,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Text-to-Video<br/>
        /// **What this API does**<br/>
        /// Create the same Text To Video you can make in the browser, but programmatically, so you can automate it, run it at scale, or connect it to your own app or workflow.<br/>
        ///     <br/>
        /// **Good for**<br/>
        /// - Automation and batch processing  <br/>
        /// - Adding text to video into apps, pipelines, or tools  <br/>
        /// **How it works (3 steps)**<br/>
        /// 1) Upload your inputs (video, image, or audio) with [Generate Upload URLs](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls) and copy the `file_path`.  <br/>
        /// 2) Send a request to create a text to video job with the basic fields.  <br/>
        /// 3) Check the job status until it's `complete`, then download the result from `downloads`.<br/>
        /// **Key options**<br/>
        /// - Inputs: usually a file, sometimes a YouTube link, depending on project type  <br/>
        /// - Resolution: free users are limited to 576px; higher plans unlock HD and larger sizes  <br/>
        /// - Extra fields: e.g. `face_swap_mode`, `start_seconds`/`end_seconds`, or a text prompt  <br/>
        /// **Cost**  <br/>
        /// Credits are only charged for the frames that actually render. You'll see an estimate when the job is queued, and the final total after it's done.<br/>
        /// For detailed examples, see the [product page](https://magichour.ai/products/text-to-video).
        /// </summary>
        /// <param name="name">
        /// Give your video a custom name for easy identification.<br/>
        /// Default Value: Text To Video - dateTime<br/>
        /// Example: My Text To Video video
        /// </param>
        /// <param name="endSeconds">
        /// The total duration of the output video in seconds. Supported durations depend on the chosen model:<br/>
        /// * **`ltx-2`**: 3, 4, 5, 6, 7, 8, 9, 10, 15, 20, 25, 30<br/>
        /// * **`wan-2.2`**: 3, 4, 5, 6, 7, 8, 9, 10, 15<br/>
        /// * **`seedance`**: 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12<br/>
        /// * **`seedance-2.0`**: 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15<br/>
        /// * **`kling-2.5`**: 5, 10<br/>
        /// * **`kling-3.0`**: 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15<br/>
        /// * **`sora-2`**: 4, 8, 12, 24, 36, 48, 60<br/>
        /// * **`veo3.1`**: 4, 6, 8, 16, 24, 32, 40, 48, 56<br/>
        /// * **`veo3.1-lite`**: 4, 6, 8, 16, 24, 32, 40, 48, 56<br/>
        /// Legacy models:<br/>
        /// * **`kling-1.6`**: 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60<br/>
        /// Example: 5
        /// </param>
        /// <param name="aspectRatio">
        /// Determines the aspect ratio of the output video.<br/>
        /// * **`ltx-2`**: Supports 9:16, 16:9, 1:1.<br/>
        /// * **`wan-2.2`**: Supports 9:16, 16:9, 1:1.<br/>
        /// * **`seedance`**: Supports 9:16, 16:9, 1:1.<br/>
        /// * **`seedance-2.0`**: Supports 9:16, 16:9, 1:1.<br/>
        /// * **`kling-2.5`**: Supports 9:16, 16:9, 1:1.<br/>
        /// * **`kling-3.0`**: Supports 9:16, 16:9, 1:1.<br/>
        /// * **`sora-2`**: Supports 9:16, 16:9.<br/>
        /// * **`veo3.1`**: Supports 9:16, 16:9.<br/>
        /// * **`veo3.1-lite`**: Supports 9:16, 16:9.<br/>
        /// Legacy models:<br/>
        /// * **`kling-1.6`**: Supports 9:16, 16:9, 1:1.<br/>
        /// Example: 16:9
        /// </param>
        /// <param name="resolution">
        /// Controls the output video resolution. Defaults to `720p` on paid tiers and `480p` on free tiers.<br/>
        /// * **`ltx-2`**: Supports 480p, 720p, 1080p.<br/>
        /// * **`wan-2.2`**: Supports 480p, 720p, 1080p.<br/>
        /// * **`seedance`**: Supports 480p, 720p, 1080p.<br/>
        /// * **`seedance-2.0`**: Supports 480p, 720p.<br/>
        /// * **`kling-2.5`**: Supports 720p, 1080p.<br/>
        /// * **`kling-3.0`**: Supports 720p, 1080p.<br/>
        /// * **`sora-2`**: Supports 720p.<br/>
        /// * **`veo3.1`**: Supports 720p, 1080p.<br/>
        /// * **`veo3.1-lite`**: Supports 720p, 1080p.<br/>
        /// Legacy models:<br/>
        /// * **`kling-1.6`**: Supports 720p, 1080p.<br/>
        /// Example: 720p
        /// </param>
        /// <param name="model">
        /// The AI model to use for video generation.<br/>
        /// * `default`: uses our currently recommended model for general use. For paid tiers, defaults to `kling-3.0`. For free tiers, it defaults to `ltx-2`.<br/>
        /// * `ltx-2`: Fast iteration with audio and lip-sync<br/>
        /// * `wan-2.2`: Fast, strong visuals with effects<br/>
        /// * `seedance`: Fast iteration and start/end frames<br/>
        /// * `seedance-2.0`: State-of-the-art quality and consistency<br/>
        /// * `kling-2.5`: Motion, action, and camera control<br/>
        /// * `kling-3.0`: Cinematic, multi-scene storytelling<br/>
        /// * `sora-2`: Story-first concepts and creativity<br/>
        /// * `veo3.1`: Realistic visuals and prompt adherence<br/>
        /// * `veo3.1-lite`: Good for fast, affordable, high-quality daily generation.<br/>
        /// Legacy models:<br/>
        /// * `kling-1.6`: Reliable baseline with smooth motion<br/>
        /// If you specify the deprecated model value that includes the `-audio` suffix, this will be the same as included `audio` as `true`.<br/>
        /// Default Value: default<br/>
        /// Example: kling-3.0
        /// </param>
        /// <param name="audio">
        /// Whether to include audio in the video. Defaults to `false` if not specified.<br/>
        /// Audio support varies by model:<br/>
        /// * **`ltx-2`**: Automatically included with no extra credits<br/>
        /// * **`wan-2.2`**: Not supported<br/>
        /// * **`seedance`**: Not supported<br/>
        /// * **`seedance-2.0`**: Not supported<br/>
        /// * **`kling-2.5`**: Automatically included with no extra credits<br/>
        /// * **`kling-3.0`**: Toggle-able (can enable/disable)<br/>
        /// * **`sora-2`**: Automatically included with no extra credits<br/>
        /// * **`veo3.1`**: Toggle-able (can enable/disable)<br/>
        /// * **`veo3.1-lite`**: Automatically included with no extra credits<br/>
        /// Legacy models:<br/>
        /// * **`kling-1.6`**: Not supported<br/>
        /// Example: true
        /// </param>
        /// <param name="style"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MagicHour.TextToVideoCreateVideoResponse> TextToVideoCreateVideoAsync(
            float endSeconds,
            global::MagicHour.TextToVideoCreateVideoRequestStyle style,
            string? name = default,
            global::MagicHour.TextToVideoCreateVideoRequestAspectRatio? aspectRatio = default,
            global::MagicHour.TextToVideoCreateVideoRequestResolution? resolution = default,
            global::MagicHour.TextToVideoCreateVideoRequestModel? model = default,
            bool? audio = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}