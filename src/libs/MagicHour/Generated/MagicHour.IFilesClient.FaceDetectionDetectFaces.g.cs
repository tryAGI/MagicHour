#nullable enable

namespace MagicHour
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Face Detection<br/>
        /// Detect faces in an image or video. <br/>
        ///       <br/>
        /// Use this API to get the list of faces detected in the image or video to use in the [face swap photo](https://docs.magichour.ai/api-reference/image-projects/face-swap-photo) or [face swap video](https://docs.magichour.ai/api-reference/video-projects/face-swap-video) API calls for multi-face swaps.<br/>
        /// Note: Face detection is free to use for the near future. Pricing may change in the future.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/face-detection \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header 'authorization: Bearer &lt;token&gt;' \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "confidence_score": 0.5,<br/>
        ///   "assets": {<br/>
        ///     "target_file_path": "api-assets/id/1234.png"<br/>
        ///   }<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.FaceDetectionDetectFacesResponse> FaceDetectionDetectFacesAsync(

            global::MagicHour.FaceDetectionDetectFacesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Face Detection<br/>
        /// Detect faces in an image or video. <br/>
        ///       <br/>
        /// Use this API to get the list of faces detected in the image or video to use in the [face swap photo](https://docs.magichour.ai/api-reference/image-projects/face-swap-photo) or [face swap video](https://docs.magichour.ai/api-reference/video-projects/face-swap-video) API calls for multi-face swaps.<br/>
        /// Note: Face detection is free to use for the near future. Pricing may change in the future.
        /// </summary>
        /// <param name="confidenceScore">
        /// Confidence threshold for filtering detected faces. <br/>
        /// * Higher values (e.g., 0.9) include only faces detected with high certainty, reducing false positives. <br/>
        /// * Lower values (e.g., 0.3) include more faces, but may increase the chance of incorrect detections.<br/>
        /// Default Value: 0.5F<br/>
        /// Example: 0.5F
        /// </param>
        /// <param name="assets">
        /// Provide the assets for face detection
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MagicHour.FaceDetectionDetectFacesResponse> FaceDetectionDetectFacesAsync(
            global::MagicHour.FaceDetectionDetectFacesRequestAssets assets,
            double? confidenceScore = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}