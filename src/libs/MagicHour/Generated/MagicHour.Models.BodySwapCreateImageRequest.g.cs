
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodySwapCreateImageRequest
    {
        /// <summary>
        /// Give your image a custom name for easy identification.<br/>
        /// Default Value: Body Swap - dateTime<br/>
        /// Example: My Body Swap image
        /// </summary>
        /// <example>My Body Swap image</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Output resolution. Determines credits charged for the run.<br/>
        /// Example: 1k
        /// </summary>
        /// <example>1k</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.BodySwapCreateImageRequestResolutionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.BodySwapCreateImageRequestResolution Resolution { get; set; }

        /// <summary>
        /// Person image and scene image for body swap
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.BodySwapCreateImageRequestAssets Assets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodySwapCreateImageRequest" /> class.
        /// </summary>
        /// <param name="resolution">
        /// Output resolution. Determines credits charged for the run.<br/>
        /// Example: 1k
        /// </param>
        /// <param name="assets">
        /// Person image and scene image for body swap
        /// </param>
        /// <param name="name">
        /// Give your image a custom name for easy identification.<br/>
        /// Default Value: Body Swap - dateTime<br/>
        /// Example: My Body Swap image
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodySwapCreateImageRequest(
            global::MagicHour.BodySwapCreateImageRequestResolution resolution,
            global::MagicHour.BodySwapCreateImageRequestAssets assets,
            string? name)
        {
            this.Name = name;
            this.Resolution = resolution;
            this.Assets = assets ?? throw new global::System.ArgumentNullException(nameof(assets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodySwapCreateImageRequest" /> class.
        /// </summary>
        public BodySwapCreateImageRequest()
        {
        }

    }
}