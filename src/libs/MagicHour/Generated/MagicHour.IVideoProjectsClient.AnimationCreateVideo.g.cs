#nullable enable

namespace MagicHour
{
    public partial interface IVideoProjectsClient
    {
        /// <summary>
        /// Animation<br/>
        /// Create a Animation video. The estimated frame cost is calculated based on the `fps` and `end_seconds` input.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/animation \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header 'authorization: Bearer &lt;token&gt;' \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Animation video",<br/>
        ///   "fps": 12,<br/>
        ///   "end_seconds": 15,<br/>
        ///   "height": 960,<br/>
        ///   "width": 512,<br/>
        ///   "style": {<br/>
        ///     "art_style": "Painterly Illustration",<br/>
        ///     "art_style_custom": "string",<br/>
        ///     "camera_effect": "Simple Zoom In",<br/>
        ///     "prompt_type": "custom",<br/>
        ///     "prompt": "Cyberpunk city",<br/>
        ///     "transition_speed": 5<br/>
        ///   },<br/>
        ///   "assets": {<br/>
        ///     "audio_source": "file",<br/>
        ///     "audio_file_path": "api-assets/id/1234.mp3",<br/>
        ///     "youtube_url": "string",<br/>
        ///     "image_file_path": "api-assets/id/1234.png"<br/>
        ///   }<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.AnimationCreateVideoResponse> AnimationCreateVideoAsync(

            global::MagicHour.AnimationCreateVideoRequest request,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Animation<br/>
        /// Create a Animation video. The estimated frame cost is calculated based on the `fps` and `end_seconds` input.
        /// </summary>
        /// <param name="name">
        /// Give your video a custom name for easy identification.<br/>
        /// Default Value: Animation - dateTime<br/>
        /// Example: My Animation video
        /// </param>
        /// <param name="fps">
        /// The desire output video frame rate<br/>
        /// Example: 12
        /// </param>
        /// <param name="endSeconds">
        /// This value determines the duration of the output video.<br/>
        /// Example: 15
        /// </param>
        /// <param name="height">
        /// The height of the final output video. The maximum height depends on your subscription. Please refer to our [pricing page](https://magichour.ai/pricing) for more details<br/>
        /// Example: 960
        /// </param>
        /// <param name="width">
        /// The width of the final output video. The maximum width depends on your subscription. Please refer to our [pricing page](https://magichour.ai/pricing) for more details<br/>
        /// Example: 512
        /// </param>
        /// <param name="style">
        /// Defines the style of the output video
        /// </param>
        /// <param name="assets">
        /// Provide the assets for animation.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MagicHour.AnimationCreateVideoResponse> AnimationCreateVideoAsync(
            double fps,
            float endSeconds,
            int height,
            int width,
            global::MagicHour.AnimationCreateVideoRequestStyle style,
            global::MagicHour.AnimationCreateVideoRequestAssets assets,
            string? name = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}