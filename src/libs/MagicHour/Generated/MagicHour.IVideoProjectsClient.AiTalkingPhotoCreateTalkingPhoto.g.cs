#nullable enable

namespace MagicHour
{
    public partial interface IVideoProjectsClient
    {
        /// <summary>
        /// AI Talking Photo<br/>
        /// Create a talking photo video from an image and an audio file.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/ai-talking-photo \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header "authorization: Bearer $MAGIC_HOUR_API_KEY" \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Talking Photo video",<br/>
        ///   "start_seconds": 0,<br/>
        ///   "end_seconds": 5,<br/>
        ///   "assets": {<br/>
        ///     "image_file_path": "api-assets/id/1234.png",<br/>
        ///     "audio_file_path": "api-assets/id/1234.mp3"<br/>
        ///   },<br/>
        ///   "style": {<br/>
        ///     "generation_mode": "realistic",<br/>
        ///     "prompt": "A person smiling and speaking naturally to the camera"<br/>
        ///   },<br/>
        ///   "resolution": "480p"<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponse> AiTalkingPhotoCreateTalkingPhotoAsync(

            global::MagicHour.AiTalkingPhotoCreateTalkingPhotoRequest request,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// AI Talking Photo<br/>
        /// Create a talking photo video from an image and an audio file.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/ai-talking-photo \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header "authorization: Bearer $MAGIC_HOUR_API_KEY" \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Talking Photo video",<br/>
        ///   "start_seconds": 0,<br/>
        ///   "end_seconds": 5,<br/>
        ///   "assets": {<br/>
        ///     "image_file_path": "api-assets/id/1234.png",<br/>
        ///     "audio_file_path": "api-assets/id/1234.mp3"<br/>
        ///   },<br/>
        ///   "style": {<br/>
        ///     "generation_mode": "realistic",<br/>
        ///     "prompt": "A person smiling and speaking naturally to the camera"<br/>
        ///   },<br/>
        ///   "resolution": "480p"<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.AutoSDKHttpResponse<global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponse>> AiTalkingPhotoCreateTalkingPhotoAsResponseAsync(

            global::MagicHour.AiTalkingPhotoCreateTalkingPhotoRequest request,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// AI Talking Photo<br/>
        /// Create a talking photo video from an image and an audio file.
        /// </summary>
        /// <param name="name">
        /// Give your video a custom name for easy identification.<br/>
        /// Default Value: Talking Photo - dateTime<br/>
        /// Example: My Talking Photo video
        /// </param>
        /// <param name="startSeconds">
        /// The start time of the input audio in seconds. Maximum clip length depends on style.generation_mode: realistic 300s, prompted 60s.<br/>
        /// Example: 0
        /// </param>
        /// <param name="endSeconds">
        /// The end time of the input audio in seconds. Maximum clip length depends on style.generation_mode: realistic 300s, prompted 60s.<br/>
        /// Example: 5
        /// </param>
        /// <param name="assets">
        /// Provide the assets for creating a talking photo
        /// </param>
        /// <param name="style">
        /// Attributes used to dictate the style of the output
        /// </param>
        /// <param name="resolution">
        /// Output preset. Overrides `max_resolution`. Defaults to 480p in prompted mode; realistic mode uses the mapped plan maximum.<br/>
        /// Example: 480p
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponse> AiTalkingPhotoCreateTalkingPhotoAsync(
            float startSeconds,
            float endSeconds,
            global::MagicHour.AiTalkingPhotoCreateTalkingPhotoRequestAssets assets,
            string? name = default,
            global::MagicHour.AiTalkingPhotoCreateTalkingPhotoRequestStyle? style = default,
            global::MagicHour.AiTalkingPhotoCreateTalkingPhotoRequestResolution? resolution = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}