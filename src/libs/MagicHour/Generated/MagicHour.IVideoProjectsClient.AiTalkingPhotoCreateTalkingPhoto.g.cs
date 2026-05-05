#nullable enable

namespace MagicHour
{
    public partial interface IVideoProjectsClient
    {
        /// <summary>
        /// AI Talking Photo<br/>
        /// Create a talking photo from an image and audio or text input.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/ai-talking-photo \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header 'authorization: Bearer &lt;token&gt;' \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Talking Photo image",<br/>
        ///   "start_seconds": 0,<br/>
        ///   "end_seconds": 15,<br/>
        ///   "assets": {<br/>
        ///     "image_file_path": "api-assets/id/1234.png",<br/>
        ///     "audio_file_path": "api-assets/id/1234.mp3"<br/>
        ///   },<br/>
        ///   "style": {<br/>
        ///     "generation_mode": "realistic",<br/>
        ///     "prompt": "string"<br/>
        ///   },<br/>
        ///   "max_resolution": 1024<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponse> AiTalkingPhotoCreateTalkingPhotoAsync(

            global::MagicHour.AiTalkingPhotoCreateTalkingPhotoRequest request,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// AI Talking Photo<br/>
        /// Create a talking photo from an image and audio or text input.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/ai-talking-photo \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header 'authorization: Bearer &lt;token&gt;' \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Talking Photo image",<br/>
        ///   "start_seconds": 0,<br/>
        ///   "end_seconds": 15,<br/>
        ///   "assets": {<br/>
        ///     "image_file_path": "api-assets/id/1234.png",<br/>
        ///     "audio_file_path": "api-assets/id/1234.mp3"<br/>
        ///   },<br/>
        ///   "style": {<br/>
        ///     "generation_mode": "realistic",<br/>
        ///     "prompt": "string"<br/>
        ///   },<br/>
        ///   "max_resolution": 1024<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.AutoSDKHttpResponse<global::MagicHour.AiTalkingPhotoCreateTalkingPhotoResponse>> AiTalkingPhotoCreateTalkingPhotoAsResponseAsync(

            global::MagicHour.AiTalkingPhotoCreateTalkingPhotoRequest request,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// AI Talking Photo<br/>
        /// Create a talking photo from an image and audio or text input.
        /// </summary>
        /// <param name="name">
        /// Give your image a custom name for easy identification.<br/>
        /// Default Value: Talking Photo - dateTime<br/>
        /// Example: My Talking Photo image
        /// </param>
        /// <param name="startSeconds">
        /// The start time of the input audio in seconds. The maximum duration allowed is 60 seconds.<br/>
        /// Example: 0
        /// </param>
        /// <param name="endSeconds">
        /// The end time of the input audio in seconds. The maximum duration allowed is 60 seconds.<br/>
        /// Example: 15
        /// </param>
        /// <param name="assets">
        /// Provide the assets for creating a talking photo
        /// </param>
        /// <param name="style">
        /// Attributes used to dictate the style of the output
        /// </param>
        /// <param name="maxResolution">
        /// Constrains the larger dimension (height or width) of the output video. Allows you to set a lower resolution than your plan's maximum if desired. The value is capped by your plan's max resolution.<br/>
        /// Example: 1024
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
            int? maxResolution = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}