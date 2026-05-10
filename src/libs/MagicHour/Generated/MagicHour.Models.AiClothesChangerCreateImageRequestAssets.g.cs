
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Provide the assets for clothes changer
    /// </summary>
    public sealed partial class AiClothesChangerCreateImageRequestAssets
    {
        /// <summary>
        /// The image with the person. This value is either<br/>
        /// - a direct URL to the video file<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// Example: api-assets/id/model.png
        /// </summary>
        /// <example>api-assets/id/model.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("person_file_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PersonFilePath { get; set; }

        /// <summary>
        /// The image of the outfit. This value is either<br/>
        /// - a direct URL to the video file<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// Example: api-assets/id/outfit.png
        /// </summary>
        /// <example>api-assets/id/outfit.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("garment_file_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GarmentFilePath { get; set; }

        /// <summary>
        /// Type of garment to swap. If not provided, swaps the entire outfit. <br/>
        /// * `upper_body` - for shirts/jackets <br/>
        /// * `lower_body` - for pants/skirts <br/>
        /// * `dresses` - for entire outfit (deprecated, use `entire_outfit` instead) <br/>
        /// * `entire_outfit` - for entire outfit<br/>
        /// Example: entire_outfit
        /// </summary>
        /// <example>entire_outfit</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("garment_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.AiClothesChangerCreateImageRequestAssetsGarmentTypeJsonConverter))]
        public global::MagicHour.AiClothesChangerCreateImageRequestAssetsGarmentType? GarmentType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiClothesChangerCreateImageRequestAssets" /> class.
        /// </summary>
        /// <param name="personFilePath">
        /// The image with the person. This value is either<br/>
        /// - a direct URL to the video file<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// Example: api-assets/id/model.png
        /// </param>
        /// <param name="garmentFilePath">
        /// The image of the outfit. This value is either<br/>
        /// - a direct URL to the video file<br/>
        /// - `file_path` field from the response of the [upload urls API](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls).<br/>
        /// See the [file upload guide](https://docs.magichour.ai/api-reference/files/generate-asset-upload-urls#input-file) for details.<br/>
        /// Example: api-assets/id/outfit.png
        /// </param>
        /// <param name="garmentType">
        /// Type of garment to swap. If not provided, swaps the entire outfit. <br/>
        /// * `upper_body` - for shirts/jackets <br/>
        /// * `lower_body` - for pants/skirts <br/>
        /// * `dresses` - for entire outfit (deprecated, use `entire_outfit` instead) <br/>
        /// * `entire_outfit` - for entire outfit<br/>
        /// Example: entire_outfit
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiClothesChangerCreateImageRequestAssets(
            string personFilePath,
            string garmentFilePath,
            global::MagicHour.AiClothesChangerCreateImageRequestAssetsGarmentType? garmentType)
        {
            this.PersonFilePath = personFilePath ?? throw new global::System.ArgumentNullException(nameof(personFilePath));
            this.GarmentFilePath = garmentFilePath ?? throw new global::System.ArgumentNullException(nameof(garmentFilePath));
            this.GarmentType = garmentType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiClothesChangerCreateImageRequestAssets" /> class.
        /// </summary>
        public AiClothesChangerCreateImageRequestAssets()
        {
        }

    }
}