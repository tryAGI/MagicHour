#nullable enable

namespace MagicHour
{
    public partial interface IVideoProjectsClient
    {
        /// <summary>
        /// Audio-to-Video<br/>
        /// **What this API does**<br/>
        /// Create the same Audio To Video you can make in the browser, but programmatically, so you can automate it, run it at scale, or connect it to your own app or workflow.<br/>
        ///     <br/>
        /// **Good for**<br/>
        /// - Automation and batch processing  <br/>
        /// - Adding audio to video into apps, pipelines, or tools  <br/>
        /// **How it works (3 steps)**<br/>
        /// 1) Upload your inputs (video, image, or audio) with [Generate Upload URLs](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls) and copy the `file_path`.  <br/>
        /// 2) Send a request to create a audio to video job with the basic fields.  <br/>
        /// 3) Check the job status until it's `complete`, then download the result from `downloads`.<br/>
        /// **Key options**<br/>
        /// - Inputs: see the request schema for endpoint-specific assets  <br/>
        /// - Resolution: free users default to 480p; higher plans unlock HD and larger sizes  <br/>
        /// - Extra fields: see the request schema for endpoint-specific options  <br/>
        /// **Cost**  <br/>
        /// Credits are only charged for the frames that actually render. You'll see an estimate when the job is queued, and the final total after it's done.<br/>
        /// For detailed examples, see the [product page](https://magichour.ai/products/audio-to-video).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/audio-to-video \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header 'authorization: Bearer &lt;token&gt;' \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Audio To Video video",<br/>
        ///   "start_seconds": 0,<br/>
        ///   "end_seconds": 15,<br/>
        ///   "resolution": "720p",<br/>
        ///   "assets": {<br/>
        ///     "audio_file_path": "api-assets/id/1234.mp3",<br/>
        ///     "image_file_path": "api-assets/id/1234.png"<br/>
        ///   },<br/>
        ///   "style": {<br/>
        ///     "prompt": "Car driving through a city"<br/>
        ///   }<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.AudioToVideoCreateVideoResponse> AudioToVideoCreateVideoAsync(

            global::MagicHour.AudioToVideoCreateVideoRequest request,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Audio-to-Video<br/>
        /// **What this API does**<br/>
        /// Create the same Audio To Video you can make in the browser, but programmatically, so you can automate it, run it at scale, or connect it to your own app or workflow.<br/>
        ///     <br/>
        /// **Good for**<br/>
        /// - Automation and batch processing  <br/>
        /// - Adding audio to video into apps, pipelines, or tools  <br/>
        /// **How it works (3 steps)**<br/>
        /// 1) Upload your inputs (video, image, or audio) with [Generate Upload URLs](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls) and copy the `file_path`.  <br/>
        /// 2) Send a request to create a audio to video job with the basic fields.  <br/>
        /// 3) Check the job status until it's `complete`, then download the result from `downloads`.<br/>
        /// **Key options**<br/>
        /// - Inputs: see the request schema for endpoint-specific assets  <br/>
        /// - Resolution: free users default to 480p; higher plans unlock HD and larger sizes  <br/>
        /// - Extra fields: see the request schema for endpoint-specific options  <br/>
        /// **Cost**  <br/>
        /// Credits are only charged for the frames that actually render. You'll see an estimate when the job is queued, and the final total after it's done.<br/>
        /// For detailed examples, see the [product page](https://magichour.ai/products/audio-to-video).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/audio-to-video \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header 'authorization: Bearer &lt;token&gt;' \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Audio To Video video",<br/>
        ///   "start_seconds": 0,<br/>
        ///   "end_seconds": 15,<br/>
        ///   "resolution": "720p",<br/>
        ///   "assets": {<br/>
        ///     "audio_file_path": "api-assets/id/1234.mp3",<br/>
        ///     "image_file_path": "api-assets/id/1234.png"<br/>
        ///   },<br/>
        ///   "style": {<br/>
        ///     "prompt": "Car driving through a city"<br/>
        ///   }<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.AutoSDKHttpResponse<global::MagicHour.AudioToVideoCreateVideoResponse>> AudioToVideoCreateVideoAsResponseAsync(

            global::MagicHour.AudioToVideoCreateVideoRequest request,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Audio-to-Video<br/>
        /// **What this API does**<br/>
        /// Create the same Audio To Video you can make in the browser, but programmatically, so you can automate it, run it at scale, or connect it to your own app or workflow.<br/>
        ///     <br/>
        /// **Good for**<br/>
        /// - Automation and batch processing  <br/>
        /// - Adding audio to video into apps, pipelines, or tools  <br/>
        /// **How it works (3 steps)**<br/>
        /// 1) Upload your inputs (video, image, or audio) with [Generate Upload URLs](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls) and copy the `file_path`.  <br/>
        /// 2) Send a request to create a audio to video job with the basic fields.  <br/>
        /// 3) Check the job status until it's `complete`, then download the result from `downloads`.<br/>
        /// **Key options**<br/>
        /// - Inputs: see the request schema for endpoint-specific assets  <br/>
        /// - Resolution: free users default to 480p; higher plans unlock HD and larger sizes  <br/>
        /// - Extra fields: see the request schema for endpoint-specific options  <br/>
        /// **Cost**  <br/>
        /// Credits are only charged for the frames that actually render. You'll see an estimate when the job is queued, and the final total after it's done.<br/>
        /// For detailed examples, see the [product page](https://magichour.ai/products/audio-to-video).
        /// </summary>
        /// <param name="name">
        /// Give your video a custom name for easy identification.<br/>
        /// Default Value: Audio To Video - dateTime<br/>
        /// Example: My Audio To Video video
        /// </param>
        /// <param name="startSeconds">
        /// Start time of your clip (seconds). Must be ≥ 0.<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="endSeconds">
        /// End time of your clip (seconds). Must be greater than start_seconds.<br/>
        /// Example: 15
        /// </param>
        /// <param name="resolution">
        /// Output video resolution. Defaults to `720p` on paid tiers and `480p` on free tiers.<br/>
        /// Example: 720p
        /// </param>
        /// <param name="assets">
        /// Provide the audio file and an optional reference image.
        /// </param>
        /// <param name="style">
        /// Attributes used to dictate the style of the output
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MagicHour.AudioToVideoCreateVideoResponse> AudioToVideoCreateVideoAsync(
            float endSeconds,
            global::MagicHour.AudioToVideoCreateVideoRequestAssets assets,
            string? name = default,
            float? startSeconds = default,
            global::MagicHour.AudioToVideoCreateVideoRequestResolution? resolution = default,
            global::MagicHour.AudioToVideoCreateVideoRequestStyle? style = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}