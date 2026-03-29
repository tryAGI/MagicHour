#nullable enable

namespace MagicHour
{
    public partial interface IVideoProjectsClient
    {
        /// <summary>
        /// Delete video<br/>
        /// Permanently delete the rendered video. This action is not reversible, please be sure before deleting.
        /// </summary>
        /// <param name="id">
        /// Example: cuid-example
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request DELETE \<br/>
        ///      --url https://api.magichour.ai/v1/video-projects/id \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header 'authorization: Bearer &lt;token&gt;'
        /// </remarks>
        global::System.Threading.Tasks.Task VideoProjectsDeleteAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}