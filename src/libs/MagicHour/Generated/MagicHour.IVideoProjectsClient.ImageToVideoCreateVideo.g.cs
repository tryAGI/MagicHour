#nullable enable

namespace MagicHour
{
    public partial interface IVideoProjectsClient
    {
        /// <summary>
        /// Image-to-Video<br/>
        /// **What this API does**<br/>
        /// Create the same Image To Video you can make in the browser, but programmatically, so you can automate it, run it at scale, or connect it to your own app or workflow.<br/>
        ///     <br/>
        /// **Good for**<br/>
        /// - Automation and batch processing  <br/>
        /// - Adding image to video into apps, pipelines, or tools  <br/>
        /// **How it works (3 steps)**<br/>
        /// 1) Upload your inputs (video, image, or audio) with [Generate Upload URLs](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls) and copy the `file_path`.  <br/>
        /// 2) Send a request to create a image to video job with the basic fields.  <br/>
        /// 3) Check the job status until it's `complete`, then download the result from `downloads`.<br/>
        /// **Key options**<br/>
        /// - Inputs: usually a file, sometimes a YouTube link, depending on project type  <br/>
        /// - Resolution: free users are limited to 576px; higher plans unlock HD and larger sizes  <br/>
        /// - Extra fields: e.g. `face_swap_mode`, `start_seconds`/`end_seconds`, or a text prompt  <br/>
        /// **Cost**  <br/>
        /// Credits are only charged for the frames that actually render. You'll see an estimate when the job is queued, and the final total after it's done.<br/>
        /// For detailed examples, see the [product page](https://magichour.ai/products/image-to-video).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/image-to-video \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header 'authorization: Bearer &lt;token&gt;' \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Image To Video video",<br/>
        ///   "end_seconds": 5,<br/>
        ///   "model": "kling-3.0",<br/>
        ///   "resolution": "720p",<br/>
        ///   "audio": true,<br/>
        ///   "style": {<br/>
        ///     "prompt": "a dog running"<br/>
        ///   },<br/>
        ///   "assets": {<br/>
        ///     "image_file_path": "api-assets/id/1234.png",<br/>
        ///     "end_image_file_path": "api-assets/id/1234.png"<br/>
        ///   }<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.ImageToVideoCreateVideoResponse> ImageToVideoCreateVideoAsync(

            global::MagicHour.ImageToVideoCreateVideoRequest request,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Image-to-Video<br/>
        /// **What this API does**<br/>
        /// Create the same Image To Video you can make in the browser, but programmatically, so you can automate it, run it at scale, or connect it to your own app or workflow.<br/>
        ///     <br/>
        /// **Good for**<br/>
        /// - Automation and batch processing  <br/>
        /// - Adding image to video into apps, pipelines, or tools  <br/>
        /// **How it works (3 steps)**<br/>
        /// 1) Upload your inputs (video, image, or audio) with [Generate Upload URLs](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls) and copy the `file_path`.  <br/>
        /// 2) Send a request to create a image to video job with the basic fields.  <br/>
        /// 3) Check the job status until it's `complete`, then download the result from `downloads`.<br/>
        /// **Key options**<br/>
        /// - Inputs: usually a file, sometimes a YouTube link, depending on project type  <br/>
        /// - Resolution: free users are limited to 576px; higher plans unlock HD and larger sizes  <br/>
        /// - Extra fields: e.g. `face_swap_mode`, `start_seconds`/`end_seconds`, or a text prompt  <br/>
        /// **Cost**  <br/>
        /// Credits are only charged for the frames that actually render. You'll see an estimate when the job is queued, and the final total after it's done.<br/>
        /// For detailed examples, see the [product page](https://magichour.ai/products/image-to-video).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/image-to-video \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header 'authorization: Bearer &lt;token&gt;' \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Image To Video video",<br/>
        ///   "end_seconds": 5,<br/>
        ///   "model": "kling-3.0",<br/>
        ///   "resolution": "720p",<br/>
        ///   "audio": true,<br/>
        ///   "style": {<br/>
        ///     "prompt": "a dog running"<br/>
        ///   },<br/>
        ///   "assets": {<br/>
        ///     "image_file_path": "api-assets/id/1234.png",<br/>
        ///     "end_image_file_path": "api-assets/id/1234.png"<br/>
        ///   }<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.AutoSDKHttpResponse<global::MagicHour.ImageToVideoCreateVideoResponse>> ImageToVideoCreateVideoAsResponseAsync(

            global::MagicHour.ImageToVideoCreateVideoRequest request,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Image-to-Video<br/>
        /// **What this API does**<br/>
        /// Create the same Image To Video you can make in the browser, but programmatically, so you can automate it, run it at scale, or connect it to your own app or workflow.<br/>
        ///     <br/>
        /// **Good for**<br/>
        /// - Automation and batch processing  <br/>
        /// - Adding image to video into apps, pipelines, or tools  <br/>
        /// **How it works (3 steps)**<br/>
        /// 1) Upload your inputs (video, image, or audio) with [Generate Upload URLs](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls) and copy the `file_path`.  <br/>
        /// 2) Send a request to create a image to video job with the basic fields.  <br/>
        /// 3) Check the job status until it's `complete`, then download the result from `downloads`.<br/>
        /// **Key options**<br/>
        /// - Inputs: usually a file, sometimes a YouTube link, depending on project type  <br/>
        /// - Resolution: free users are limited to 576px; higher plans unlock HD and larger sizes  <br/>
        /// - Extra fields: e.g. `face_swap_mode`, `start_seconds`/`end_seconds`, or a text prompt  <br/>
        /// **Cost**  <br/>
        /// Credits are only charged for the frames that actually render. You'll see an estimate when the job is queued, and the final total after it's done.<br/>
        /// For detailed examples, see the [product page](https://magichour.ai/products/image-to-video).
        /// </summary>
        /// <param name="name">
        /// Give your video a custom name for easy identification.<br/>
        /// Default Value: Image To Video - dateTime<br/>
        /// Example: My Image To Video video
        /// </param>
        /// <param name="endSeconds">
        /// The total duration of the output video in seconds. Supported durations depend on the chosen model:<br/>
        /// * **`gemini-omni-1.1`**: 3, 4, 5, 6, 7, 8, 9, 10<br/>
        /// * **`kling-2.6`**: 5, 10<br/>
        /// * **`kling-3.0`**: 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15<br/>
        /// * **`ltx-2.3`**: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 15, 20, 25, 30<br/>
        /// * **`ltx-2.5`**: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60<br/>
        /// * **`minimax-h3`**: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 15, 20, 25, 30<br/>
        /// * **`seedance-1.5`**: 4, 5, 6, 7, 8, 9, 10, 11, 12<br/>
        /// * **`seedance-2.0`**: 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15<br/>
        /// * **`seedance-2.0-mini`**: 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15<br/>
        /// * **`seedance-2.5`**: 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30<br/>
        /// * **`sora-2`**: 4, 8, 12, 24, 36, 48, 60<br/>
        /// * **`veo3.1`**: 4, 6, 8, 16, 24, 32, 40, 48, 56<br/>
        /// * **`veo3.1-lite`**: 4, 6, 8, 16, 24, 32, 40, 48, 56<br/>
        /// * **`wan-2.2`**: 3, 4, 5, 6, 7, 8, 9, 10, 15<br/>
        /// Example: 5
        /// </param>
        /// <param name="model">
        /// The AI model to use for video generation.<br/>
        /// * `default`: uses our currently recommended model for general use. For paid tiers, defaults to `kling-3.0`. For free tiers, it defaults to `ltx-2.3`.<br/>
        /// * `gemini-omni-1.1`: Best for precise short clips, first/last frames, and high-resolution output.<br/>
        /// * `kling-2.6`: Best for action, motion blur, and controlled camera moves.<br/>
        /// * `kling-3.0`: Best for cinematic stories, references, and optional audio.<br/>
        /// * `ltx-2.3`: Fastest for general scenes, long clips, audio, and rapid iteration.<br/>
        /// * `ltx-2.5`: Fastest for general scenes, long clips, audio, and rapid iteration.<br/>
        /// * `minimax-h3`: Great for reference-driven clips with native audio and longer durations.<br/>
        /// * `seedance-1.5`: Best for smooth, consistent motion with an end frame.<br/>
        /// * `seedance-2.0`: Best for reference-led clips with precise subject control.<br/>
        /// * `seedance-2.0-mini`: Faster reference-led clips with consistent motion and audio.<br/>
        /// * `seedance-2.5`: Best for premium realism, detail, and natural motion.<br/>
        /// * `sora-2`: Best for creative concepts and longer clips with audio.<br/>
        /// * `veo3.1`: Best for romantic interactions and expressive action, with realistic detail.<br/>
        /// * `veo3.1-lite`: Balanced realism and audio at a lower cost than Veo 3.1.<br/>
        /// * `wan-2.2`: Best for physical motion, action, and camera movement.<br/>
        /// If you specify the deprecated model value that includes the `-audio` suffix, this will be the same as included `audio` as `true`.<br/>
        /// Default Value: default<br/>
        /// Example: kling-3.0
        /// </param>
        /// <param name="resolution">
        /// Controls the output video resolution. Defaults to `720p` on paid tiers and `480p` on free tiers.<br/>
        /// * **`gemini-omni-1.1`**: Supports 360p, 720p, 1080p, 4k.<br/>
        /// * **`kling-2.6`**: Supports 720p, 1080p.<br/>
        /// * **`kling-3.0`**: Supports 720p, 1080p, 4k.<br/>
        /// * **`ltx-2.3`**: Supports 480p, 720p, 1080p.<br/>
        /// * **`ltx-2.5`**: Supports 480p, 720p, 1080p.<br/>
        /// * **`minimax-h3`**: Supports 480p, 720p, 1080p.<br/>
        /// * **`seedance-1.5`**: Supports 480p, 720p, 1080p.<br/>
        /// * **`seedance-2.0`**: Supports 480p, 720p.<br/>
        /// * **`seedance-2.0-mini`**: Supports 480p, 720p.<br/>
        /// * **`seedance-2.5`**: Supports 480p, 720p.<br/>
        /// * **`sora-2`**: Supports 720p.<br/>
        /// * **`veo3.1`**: Supports 720p, 1080p.<br/>
        /// * **`veo3.1-lite`**: Supports 720p, 1080p.<br/>
        /// * **`wan-2.2`**: Supports 480p, 720p, 1080p.<br/>
        /// Example: 720p
        /// </param>
        /// <param name="audio">
        /// Whether to include audio in the video. Defaults to `false` if not specified.<br/>
        /// Audio support varies by model:<br/>
        /// * **`gemini-omni-1.1`**: Not supported<br/>
        /// * **`kling-2.6`**: Not supported<br/>
        /// * **`kling-3.0`**: Toggle-able: audio adds extra credits when enabled<br/>
        /// * **`ltx-2.3`**: Toggle-able: no additional credits for audio<br/>
        /// * **`ltx-2.5`**: Toggle-able: no additional credits for audio<br/>
        /// * **`minimax-h3`**: Toggle-able: no additional credits for audio<br/>
        /// * **`seedance-1.5`**: Toggle-able: audio adds extra credits when enabled<br/>
        /// * **`seedance-2.0`**: Toggle-able: no additional credits for audio<br/>
        /// * **`seedance-2.0-mini`**: Toggle-able: no additional credits for audio<br/>
        /// * **`seedance-2.5`**: Toggle-able: no additional credits for audio<br/>
        /// * **`sora-2`**: Toggle-able: no additional credits for audio<br/>
        /// * **`veo3.1`**: Toggle-able: audio adds extra credits when enabled<br/>
        /// * **`veo3.1-lite`**: Toggle-able: audio adds extra credits when enabled<br/>
        /// * **`wan-2.2`**: Not supported<br/>
        /// Example: true
        /// </param>
        /// <param name="style">
        /// Attributed used to dictate the style of the output
        /// </param>
        /// <param name="assets">
        /// Provide the assets for image-to-video. Sora 2 only supports images with an aspect ratio of `9:16` or `16:9`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MagicHour.ImageToVideoCreateVideoResponse> ImageToVideoCreateVideoAsync(
            float endSeconds,
            global::MagicHour.ImageToVideoCreateVideoRequestAssets assets,
            string? name = default,
            global::MagicHour.ImageToVideoCreateVideoRequestModel? model = default,
            global::MagicHour.ImageToVideoCreateVideoRequestResolution? resolution = default,
            bool? audio = default,
            global::MagicHour.ImageToVideoCreateVideoRequestStyle? style = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}