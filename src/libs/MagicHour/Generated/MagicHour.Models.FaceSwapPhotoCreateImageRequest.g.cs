
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FaceSwapPhotoCreateImageRequest
    {
        /// <summary>
        /// Give your image a custom name for easy identification.<br/>
        /// Default Value: Face Swap - dateTime<br/>
        /// Example: My Face Swap image
        /// </summary>
        /// <example>My Face Swap image</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Provide the assets for face swap photo
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.FaceSwapPhotoCreateImageRequestAssets Assets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceSwapPhotoCreateImageRequest" /> class.
        /// </summary>
        /// <param name="assets">
        /// Provide the assets for face swap photo
        /// </param>
        /// <param name="name">
        /// Give your image a custom name for easy identification.<br/>
        /// Default Value: Face Swap - dateTime<br/>
        /// Example: My Face Swap image
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FaceSwapPhotoCreateImageRequest(
            global::MagicHour.FaceSwapPhotoCreateImageRequestAssets assets,
            string? name)
        {
            this.Name = name;
            this.Assets = assets ?? throw new global::System.ArgumentNullException(nameof(assets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceSwapPhotoCreateImageRequest" /> class.
        /// </summary>
        public FaceSwapPhotoCreateImageRequest()
        {
        }

    }
}