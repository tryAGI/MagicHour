
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Provide the assets for image-to-video. Sora 2 only supports images with an aspect ratio of `9:16` or `16:9`.
    /// </summary>
    public sealed partial class ImageToVideoCreateVideoRequestAssets
    {
        /// <summary>
        /// The path of the image file. This value is either<br/>
        /// - a direct URL to the video file<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// Example: api-assets/id/1234.png
        /// </summary>
        /// <example>api-assets/id/1234.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_file_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageFilePath { get; set; }

        /// <summary>
        /// The image to use as the last frame of the video.<br/>
        /// * **`kling-2.6`**: Supports 1080p.<br/>
        /// * **`kling-3.0`**: Supports 720p, 1080p, 4k.<br/>
        /// * **`ltx-2.3`**: Supports 480p, 720p, 1080p.<br/>
        /// * **`minimax-h3`**: Not supported<br/>
        /// * **`seedance-1.5`**: Supports 480p, 720p, 1080p.<br/>
        /// * **`seedance-2.0`**: Supports 480p, 720p.<br/>
        /// * **`seedance-2.0-mini`**: Supports 480p, 720p.<br/>
        /// * **`seedance-2.5`**: Supports 480p, 720p.<br/>
        /// * **`sora-2`**: Not supported<br/>
        /// * **`veo3.1`**: Supports 720p, 1080p. Requires a duration of 8 seconds or less.<br/>
        /// * **`veo3.1-lite`**: Supports 720p, 1080p. Requires a duration of 8 seconds or less.<br/>
        /// * **`wan-2.2`**: Not supported<br/>
        /// Example: api-assets/id/1234.png
        /// </summary>
        /// <example>api-assets/id/1234.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_image_file_path")]
        public string? EndImageFilePath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageToVideoCreateVideoRequestAssets" /> class.
        /// </summary>
        /// <param name="imageFilePath">
        /// The path of the image file. This value is either<br/>
        /// - a direct URL to the video file<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// Example: api-assets/id/1234.png
        /// </param>
        /// <param name="endImageFilePath">
        /// The image to use as the last frame of the video.<br/>
        /// * **`kling-2.6`**: Supports 1080p.<br/>
        /// * **`kling-3.0`**: Supports 720p, 1080p, 4k.<br/>
        /// * **`ltx-2.3`**: Supports 480p, 720p, 1080p.<br/>
        /// * **`minimax-h3`**: Not supported<br/>
        /// * **`seedance-1.5`**: Supports 480p, 720p, 1080p.<br/>
        /// * **`seedance-2.0`**: Supports 480p, 720p.<br/>
        /// * **`seedance-2.0-mini`**: Supports 480p, 720p.<br/>
        /// * **`seedance-2.5`**: Supports 480p, 720p.<br/>
        /// * **`sora-2`**: Not supported<br/>
        /// * **`veo3.1`**: Supports 720p, 1080p. Requires a duration of 8 seconds or less.<br/>
        /// * **`veo3.1-lite`**: Supports 720p, 1080p. Requires a duration of 8 seconds or less.<br/>
        /// * **`wan-2.2`**: Not supported<br/>
        /// Example: api-assets/id/1234.png
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageToVideoCreateVideoRequestAssets(
            string imageFilePath,
            string? endImageFilePath)
        {
            this.ImageFilePath = imageFilePath ?? throw new global::System.ArgumentNullException(nameof(imageFilePath));
            this.EndImageFilePath = endImageFilePath;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageToVideoCreateVideoRequestAssets" /> class.
        /// </summary>
        public ImageToVideoCreateVideoRequestAssets()
        {
        }

    }
}