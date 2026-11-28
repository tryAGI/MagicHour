#nullable enable

namespace MagicHour
{
    public partial interface IVideoProjectsClient
    {
        /// <summary>
        /// Estimate video credits<br/>
        /// Get the credits a video create request charges when it is submitted. Pass `tool`, then the fields below that the tool's create request uses, with the same values. Tools billed per frame charge an estimate at submission, assuming 30 fps for an uploaded video, and settle to the frames that render. Does not create a project or spend credits. It prices the fields passed here. It does not check your plan, your balance or the rest of the create request.
        /// </summary>
        /// <param name="tool">
        /// Example: image-to-video
        /// </param>
        /// <param name="endSeconds">
        /// Example: 5
        /// </param>
        /// <param name="startSeconds"></param>
        /// <param name="model">
        /// Example: kling-3.0
        /// </param>
        /// <param name="resolution">
        /// Example: 720p
        /// </param>
        /// <param name="audio"></param>
        /// <param name="hasVideoReference"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::MagicHour.EstimateVideoResponse> EstimateVideoAsync(
            global::MagicHour.EstimateVideoTool tool,
            double endSeconds,
            double? startSeconds = default,
            string? model = default,
            string? resolution = default,
            bool? audio = default,
            bool? hasVideoReference = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Estimate video credits<br/>
        /// Get the credits a video create request charges when it is submitted. Pass `tool`, then the fields below that the tool's create request uses, with the same values. Tools billed per frame charge an estimate at submission, assuming 30 fps for an uploaded video, and settle to the frames that render. Does not create a project or spend credits. It prices the fields passed here. It does not check your plan, your balance or the rest of the create request.
        /// </summary>
        /// <param name="tool">
        /// Example: image-to-video
        /// </param>
        /// <param name="endSeconds">
        /// Example: 5
        /// </param>
        /// <param name="startSeconds"></param>
        /// <param name="model">
        /// Example: kling-3.0
        /// </param>
        /// <param name="resolution">
        /// Example: 720p
        /// </param>
        /// <param name="audio"></param>
        /// <param name="hasVideoReference"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::MagicHour.AutoSDKHttpResponse<global::MagicHour.EstimateVideoResponse>> EstimateVideoAsResponseAsync(
            global::MagicHour.EstimateVideoTool tool,
            double endSeconds,
            double? startSeconds = default,
            string? model = default,
            string? resolution = default,
            bool? audio = default,
            bool? hasVideoReference = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}