
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HeadSwapCreateImageRequest
    {
        /// <summary>
        /// Give your image a custom name for easy identification.<br/>
        /// Default Value: Head Swap - dateTime<br/>
        /// Example: My Head Swap image
        /// </summary>
        /// <example>My Head Swap image</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Constrains the larger dimension (height or width) of the output. Omit to use the maximum allowed for your plan (capped at 2048px). Values above your plan maximum are clamped down to your plan's maximum.<br/>
        /// Example: 1024
        /// </summary>
        /// <example>1024</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_resolution")]
        public int? MaxResolution { get; set; }

        /// <summary>
        /// Provide the body and head images for head swap
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.HeadSwapCreateImageRequestAssets Assets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HeadSwapCreateImageRequest" /> class.
        /// </summary>
        /// <param name="assets">
        /// Provide the body and head images for head swap
        /// </param>
        /// <param name="name">
        /// Give your image a custom name for easy identification.<br/>
        /// Default Value: Head Swap - dateTime<br/>
        /// Example: My Head Swap image
        /// </param>
        /// <param name="maxResolution">
        /// Constrains the larger dimension (height or width) of the output. Omit to use the maximum allowed for your plan (capped at 2048px). Values above your plan maximum are clamped down to your plan's maximum.<br/>
        /// Example: 1024
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HeadSwapCreateImageRequest(
            global::MagicHour.HeadSwapCreateImageRequestAssets assets,
            string? name,
            int? maxResolution)
        {
            this.Name = name;
            this.MaxResolution = maxResolution;
            this.Assets = assets ?? throw new global::System.ArgumentNullException(nameof(assets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HeadSwapCreateImageRequest" /> class.
        /// </summary>
        public HeadSwapCreateImageRequest()
        {
        }

    }
}