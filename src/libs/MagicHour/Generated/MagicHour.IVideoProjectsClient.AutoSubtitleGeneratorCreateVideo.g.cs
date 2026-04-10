#nullable enable

namespace MagicHour
{
    public partial interface IVideoProjectsClient
    {
        /// <summary>
        /// Auto Subtitle Generator<br/>
        /// Automatically generate subtitles for your video in multiple languages.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///      --url https://api.magichour.ai/v1/auto-subtitle-generator \<br/>
        ///      --header 'accept: application/json' \<br/>
        ///      --header 'authorization: Bearer &lt;token&gt;' \<br/>
        ///      --header 'content-type: application/json' \<br/>
        ///      --data '<br/>
        /// {<br/>
        ///   "name": "My Auto Subtitle video",<br/>
        ///   "start_seconds": 0,<br/>
        ///   "end_seconds": 15,<br/>
        ///   "assets": {<br/>
        ///     "video_file_path": "api-assets/id/1234.mp4"<br/>
        ///   },<br/>
        ///   "style": {<br/>
        ///     "template": "karaoke",<br/>
        ///     "custom_config": {<br/>
        ///       "font": "Noto Sans",<br/>
        ///       "font_size": 24,<br/>
        ///       "font_style": "normal",<br/>
        ///       "text_color": "#FFFFFF",<br/>
        ///       "highlighted_text_color": "#FFD700",<br/>
        ///       "stroke_color": "#000000",<br/>
        ///       "stroke_width": 1,<br/>
        ///       "vertical_position": "bottom",<br/>
        ///       "horizontal_position": "center"<br/>
        ///     }<br/>
        ///   }<br/>
        /// }<br/>
        /// '
        /// </remarks>
        global::System.Threading.Tasks.Task<global::MagicHour.AutoSubtitleGeneratorCreateVideoResponse> AutoSubtitleGeneratorCreateVideoAsync(

            global::MagicHour.AutoSubtitleGeneratorCreateVideoRequest request,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Auto Subtitle Generator<br/>
        /// Automatically generate subtitles for your video in multiple languages.
        /// </summary>
        /// <param name="name">
        /// Give your video a custom name for easy identification.<br/>
        /// Default Value: Auto Subtitle - dateTime<br/>
        /// Example: My Auto Subtitle video
        /// </param>
        /// <param name="startSeconds">
        /// Start time of your clip (seconds). Must be ≥ 0.<br/>
        /// Example: 0
        /// </param>
        /// <param name="endSeconds">
        /// End time of your clip (seconds). Must be greater than start_seconds.<br/>
        /// Example: 15
        /// </param>
        /// <param name="assets">
        /// Provide the assets for auto subtitle generator
        /// </param>
        /// <param name="style">
        /// Style of the subtitle. At least one of `.style.template` or `.style.custom_config` must be provided. <br/>
        /// * If only `.style.template` is provided, default values for the template will be used.<br/>
        /// * If both are provided, the fields in `.style.custom_config` will be used to overwrite the fields in `.style.template`.<br/>
        /// * If only `.style.custom_config` is provided, then all fields in `.style.custom_config` will be used.<br/>
        /// To use custom config only, the following `custom_config` params are required:<br/>
        /// * `.style.custom_config.font`<br/>
        /// * `.style.custom_config.text_color`<br/>
        /// * `.style.custom_config.vertical_position`<br/>
        /// * `.style.custom_config.horizontal_position`
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MagicHour.AutoSubtitleGeneratorCreateVideoResponse> AutoSubtitleGeneratorCreateVideoAsync(
            float startSeconds,
            float endSeconds,
            global::MagicHour.AutoSubtitleGeneratorCreateVideoRequestAssets assets,
            global::MagicHour.AutoSubtitleGeneratorCreateVideoRequestStyle style,
            string? name = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}