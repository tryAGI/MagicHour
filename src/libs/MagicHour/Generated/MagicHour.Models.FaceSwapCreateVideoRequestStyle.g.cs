
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Style of the face swap video.<br/>
    /// Example: {"version":"default"}
    /// </summary>
    public sealed partial class FaceSwapCreateVideoRequestStyle
    {
        /// <summary>
        /// * `v1` - May preserve skin detail and texture better, but weaker identity preservation.<br/>
        /// * `v2` - Faster, sharper, better handling of hair and glasses. stronger identity preservation.<br/>
        /// * `default` - Use the version we recommend, which will change over time. This is recommended unless you need a specific earlier version. This is the default behavior.<br/>
        /// Example: default
        /// </summary>
        /// <example>default</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.FaceSwapCreateVideoRequestStyleVersionJsonConverter))]
        public global::MagicHour.FaceSwapCreateVideoRequestStyleVersion? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceSwapCreateVideoRequestStyle" /> class.
        /// </summary>
        /// <param name="version">
        /// * `v1` - May preserve skin detail and texture better, but weaker identity preservation.<br/>
        /// * `v2` - Faster, sharper, better handling of hair and glasses. stronger identity preservation.<br/>
        /// * `default` - Use the version we recommend, which will change over time. This is recommended unless you need a specific earlier version. This is the default behavior.<br/>
        /// Example: default
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FaceSwapCreateVideoRequestStyle(
            global::MagicHour.FaceSwapCreateVideoRequestStyleVersion? version)
        {
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceSwapCreateVideoRequestStyle" /> class.
        /// </summary>
        public FaceSwapCreateVideoRequestStyle()
        {
        }

    }
}