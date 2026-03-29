
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AiClothesChangerCreateImageRequest
    {
        /// <summary>
        /// Give your image a custom name for easy identification.<br/>
        /// Default Value: Clothes Changer - dateTime<br/>
        /// Example: My Clothes Changer image
        /// </summary>
        /// <example>My Clothes Changer image</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Provide the assets for clothes changer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.AiClothesChangerCreateImageRequestAssets Assets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiClothesChangerCreateImageRequest" /> class.
        /// </summary>
        /// <param name="assets">
        /// Provide the assets for clothes changer
        /// </param>
        /// <param name="name">
        /// Give your image a custom name for easy identification.<br/>
        /// Default Value: Clothes Changer - dateTime<br/>
        /// Example: My Clothes Changer image
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiClothesChangerCreateImageRequest(
            global::MagicHour.AiClothesChangerCreateImageRequestAssets assets,
            string? name)
        {
            this.Name = name;
            this.Assets = assets ?? throw new global::System.ArgumentNullException(nameof(assets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiClothesChangerCreateImageRequest" /> class.
        /// </summary>
        public AiClothesChangerCreateImageRequest()
        {
        }
    }
}