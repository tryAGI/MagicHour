
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AiFaceEditorEditImageRequest
    {
        /// <summary>
        /// Give your image a custom name for easy identification.<br/>
        /// Default Value: Face Editor - dateTime<br/>
        /// Example: My Face Editor image
        /// </summary>
        /// <example>My Face Editor image</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Provide the assets for face editor
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.AiFaceEditorEditImageRequestAssets Assets { get; set; }

        /// <summary>
        /// Face editing parameters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.AiFaceEditorEditImageRequestStyle Style { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiFaceEditorEditImageRequest" /> class.
        /// </summary>
        /// <param name="assets">
        /// Provide the assets for face editor
        /// </param>
        /// <param name="style">
        /// Face editing parameters
        /// </param>
        /// <param name="name">
        /// Give your image a custom name for easy identification.<br/>
        /// Default Value: Face Editor - dateTime<br/>
        /// Example: My Face Editor image
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiFaceEditorEditImageRequest(
            global::MagicHour.AiFaceEditorEditImageRequestAssets assets,
            global::MagicHour.AiFaceEditorEditImageRequestStyle style,
            string? name)
        {
            this.Name = name;
            this.Assets = assets ?? throw new global::System.ArgumentNullException(nameof(assets));
            this.Style = style ?? throw new global::System.ArgumentNullException(nameof(style));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiFaceEditorEditImageRequest" /> class.
        /// </summary>
        public AiFaceEditorEditImageRequest()
        {
        }

    }
}