#nullable enable

namespace MagicHour
{
    public partial interface IImageProjectsClient
    {
        /// <summary>
        /// Estimate image credits<br/>
        /// Get the credits an image create request charges. Pass `tool`, then the fields below that the tool's create request uses, with the same values. Does not create a project or spend credits. It prices the fields passed here. It does not check your plan, your balance or the rest of the create request.
        /// </summary>
        /// <param name="tool">
        /// Example: ai-image-editor
        /// </param>
        /// <param name="model">
        /// Example: nano-banana-2.1
        /// </param>
        /// <param name="resolution">
        /// Example: 2k
        /// </param>
        /// <param name="imageCount">
        /// Example: 4
        /// </param>
        /// <param name="scaleFactor"></param>
        /// <param name="mode"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::MagicHour.EstimateImageResponse> EstimateImageAsync(
            global::MagicHour.EstimateImageTool tool,
            string? model = default,
            string? resolution = default,
            int? imageCount = default,
            double? scaleFactor = default,
            string? mode = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Estimate image credits<br/>
        /// Get the credits an image create request charges. Pass `tool`, then the fields below that the tool's create request uses, with the same values. Does not create a project or spend credits. It prices the fields passed here. It does not check your plan, your balance or the rest of the create request.
        /// </summary>
        /// <param name="tool">
        /// Example: ai-image-editor
        /// </param>
        /// <param name="model">
        /// Example: nano-banana-2.1
        /// </param>
        /// <param name="resolution">
        /// Example: 2k
        /// </param>
        /// <param name="imageCount">
        /// Example: 4
        /// </param>
        /// <param name="scaleFactor"></param>
        /// <param name="mode"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::MagicHour.AutoSDKHttpResponse<global::MagicHour.EstimateImageResponse>> EstimateImageAsResponseAsync(
            global::MagicHour.EstimateImageTool tool,
            string? model = default,
            string? resolution = default,
            int? imageCount = default,
            double? scaleFactor = default,
            string? mode = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}