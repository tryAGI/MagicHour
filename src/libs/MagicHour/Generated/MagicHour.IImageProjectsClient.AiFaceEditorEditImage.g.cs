#nullable enable

namespace MagicHour
{
    public partial interface IImageProjectsClient
    {
        /// <summary>
        /// AI Face Editor<br/>
        /// Edit facial features of an image using AI. Each edit costs 1 frame. The height/width of the output image depends on your subscription. Please refer to our [pricing](https://magichour.ai/pricing) page for more details
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/ai-face-editor \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header 'authorization: Bearer &lt;token&gt;' \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Face Editor image",<br/>
        ///   "assets": {<br/>
        ///     "image_file_path": "api-assets/id/1234.png"<br/>
        ///   },<br/>
        ///   "style": {<br/>
        ///     "enhance_face": false,<br/>
        ///     "eyebrow_direction": 0,<br/>
        ///     "eye_gaze_horizontal": 0,<br/>
        ///     "eye_gaze_vertical": 0,<br/>
        ///     "eye_open_ratio": 0,<br/>
        ///     "lip_open_ratio": 0,<br/>
        ///     "head_roll": 0,<br/>
        ///     "mouth_grim": 0,<br/>
        ///     "mouth_pout": 0,<br/>
        ///     "mouth_purse": 0,<br/>
        ///     "mouth_smile": 0,<br/>
        ///     "mouth_position_horizontal": 0,<br/>
        ///     "mouth_position_vertical": 0,<br/>
        ///     "head_pitch": 0,<br/>
        ///     "head_yaw": 0<br/>
        ///   }<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.AiFaceEditorEditImageResponse> AiFaceEditorEditImageAsync(

            global::MagicHour.AiFaceEditorEditImageRequest request,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// AI Face Editor<br/>
        /// Edit facial features of an image using AI. Each edit costs 1 frame. The height/width of the output image depends on your subscription. Please refer to our [pricing](https://magichour.ai/pricing) page for more details
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/ai-face-editor \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header 'authorization: Bearer &lt;token&gt;' \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Face Editor image",<br/>
        ///   "assets": {<br/>
        ///     "image_file_path": "api-assets/id/1234.png"<br/>
        ///   },<br/>
        ///   "style": {<br/>
        ///     "enhance_face": false,<br/>
        ///     "eyebrow_direction": 0,<br/>
        ///     "eye_gaze_horizontal": 0,<br/>
        ///     "eye_gaze_vertical": 0,<br/>
        ///     "eye_open_ratio": 0,<br/>
        ///     "lip_open_ratio": 0,<br/>
        ///     "head_roll": 0,<br/>
        ///     "mouth_grim": 0,<br/>
        ///     "mouth_pout": 0,<br/>
        ///     "mouth_purse": 0,<br/>
        ///     "mouth_smile": 0,<br/>
        ///     "mouth_position_horizontal": 0,<br/>
        ///     "mouth_position_vertical": 0,<br/>
        ///     "head_pitch": 0,<br/>
        ///     "head_yaw": 0<br/>
        ///   }<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.AutoSDKHttpResponse<global::MagicHour.AiFaceEditorEditImageResponse>> AiFaceEditorEditImageAsResponseAsync(

            global::MagicHour.AiFaceEditorEditImageRequest request,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// AI Face Editor<br/>
        /// Edit facial features of an image using AI. Each edit costs 1 frame. The height/width of the output image depends on your subscription. Please refer to our [pricing](https://magichour.ai/pricing) page for more details
        /// </summary>
        /// <param name="name">
        /// Give your image a custom name for easy identification.<br/>
        /// Default Value: Face Editor - dateTime<br/>
        /// Example: My Face Editor image
        /// </param>
        /// <param name="assets">
        /// Provide the assets for face editor
        /// </param>
        /// <param name="style">
        /// Face editing parameters
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MagicHour.AiFaceEditorEditImageResponse> AiFaceEditorEditImageAsync(
            global::MagicHour.AiFaceEditorEditImageRequestAssets assets,
            global::MagicHour.AiFaceEditorEditImageRequestStyle style,
            string? name = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}