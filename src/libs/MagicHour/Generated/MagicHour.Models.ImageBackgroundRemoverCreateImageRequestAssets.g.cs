
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Provide the assets for background removal
    /// </summary>
    public sealed partial class ImageBackgroundRemoverCreateImageRequestAssets
    {
        /// <summary>
        /// The image to remove the background. This value is either<br/>
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
        /// The image used as the new background for the image_file_path. This image will be resized to match the image in image_file_path. Please make sure the resolution between the images are similar.<br/>
        /// This value is either<br/>
        /// - a direct URL to the video file<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// Example: api-assets/id/1234.png
        /// </summary>
        /// <example>api-assets/id/1234.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_image_file_path")]
        public string? BackgroundImageFilePath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageBackgroundRemoverCreateImageRequestAssets" /> class.
        /// </summary>
        /// <param name="imageFilePath">
        /// The image to remove the background. This value is either<br/>
        /// - a direct URL to the video file<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// Example: api-assets/id/1234.png
        /// </param>
        /// <param name="backgroundImageFilePath">
        /// The image used as the new background for the image_file_path. This image will be resized to match the image in image_file_path. Please make sure the resolution between the images are similar.<br/>
        /// This value is either<br/>
        /// - a direct URL to the video file<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// Example: api-assets/id/1234.png
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageBackgroundRemoverCreateImageRequestAssets(
            string imageFilePath,
            string? backgroundImageFilePath)
        {
            this.ImageFilePath = imageFilePath ?? throw new global::System.ArgumentNullException(nameof(imageFilePath));
            this.BackgroundImageFilePath = backgroundImageFilePath;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageBackgroundRemoverCreateImageRequestAssets" /> class.
        /// </summary>
        public ImageBackgroundRemoverCreateImageRequestAssets()
        {
        }

    }
}