
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Attributes used to dictate the style of the output
    /// </summary>
    public sealed partial class LipSyncCreateVideoRequestStyle
    {
        /// <summary>
        /// A specific version of our lip sync system, optimized for different needs.<br/>
        /// * `lite` -  Fast and affordable lip sync - best for simple videos. Costs 1 credit per frame of video.<br/>
        /// * `standard` -  Natural, accurate lip sync - best for most creators. Costs 1 credit per frame of video.<br/>
        /// * `pro` -  Premium fidelity with enhanced detail - best for professionals. Costs 2 credits per frame of video.<br/>
        /// Note: `standard` and `pro` are only available for users on Creator, Pro, and Business tiers.<br/>
        ///               <br/>
        /// Default Value: lite<br/>
        /// Example: lite
        /// </summary>
        /// <example>lite</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.LipSyncCreateVideoRequestStyleGenerationModeJsonConverter))]
        public global::MagicHour.LipSyncCreateVideoRequestStyleGenerationMode? GenerationMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LipSyncCreateVideoRequestStyle" /> class.
        /// </summary>
        /// <param name="generationMode">
        /// A specific version of our lip sync system, optimized for different needs.<br/>
        /// * `lite` -  Fast and affordable lip sync - best for simple videos. Costs 1 credit per frame of video.<br/>
        /// * `standard` -  Natural, accurate lip sync - best for most creators. Costs 1 credit per frame of video.<br/>
        /// * `pro` -  Premium fidelity with enhanced detail - best for professionals. Costs 2 credits per frame of video.<br/>
        /// Note: `standard` and `pro` are only available for users on Creator, Pro, and Business tiers.<br/>
        ///               <br/>
        /// Default Value: lite<br/>
        /// Example: lite
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LipSyncCreateVideoRequestStyle(
            global::MagicHour.LipSyncCreateVideoRequestStyleGenerationMode? generationMode)
        {
            this.GenerationMode = generationMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LipSyncCreateVideoRequestStyle" /> class.
        /// </summary>
        public LipSyncCreateVideoRequestStyle()
        {
        }
    }
}