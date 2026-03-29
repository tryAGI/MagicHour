#nullable enable

namespace MagicHour
{
    public partial interface IImageProjectsClient
    {
        /// <summary>
        /// Delete image<br/>
        /// Permanently delete the rendered image(s). This action is not reversible, please be sure before deleting.
        /// </summary>
        /// <param name="id">
        /// Example: cuid-example
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request DELETE \<br/>
        ///      --url https://api.magichour.ai/v1/image-projects/id \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header 'authorization: Bearer &lt;token&gt;'
        /// </remarks>
        global::System.Threading.Tasks.Task ImageProjectsDeleteAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}