
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
        /// * `lite` -  Fast lip sync - best for simple videos. Costs 1 credit per frame of video.<br/>
        /// * `standard` -  Natural, accurate lip sync - best for most creators. Requires visible mouth movement in the opening seconds of the input video. Costs 1 credit per frame of video.<br/>
        /// * `pro` -  Premium fidelity with enhanced detail - best for professionals. Requires visible mouth movement in the opening seconds of the input video. Costs 2 credits per frame of video.<br/>
        /// If your source is a still image, including a still image saved as a static video, use [AI Talking Photo](https://docs.magichour.ai/api-reference/video-projects/ai-talking-photo) with the original image and your audio instead.<br/>
        /// Note: `pro` is only available for users on Creator, Pro, and Business tiers.<br/>
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
        /// * `lite` -  Fast lip sync - best for simple videos. Costs 1 credit per frame of video.<br/>
        /// * `standard` -  Natural, accurate lip sync - best for most creators. Requires visible mouth movement in the opening seconds of the input video. Costs 1 credit per frame of video.<br/>
        /// * `pro` -  Premium fidelity with enhanced detail - best for professionals. Requires visible mouth movement in the opening seconds of the input video. Costs 2 credits per frame of video.<br/>
        /// If your source is a still image, including a still image saved as a static video, use [AI Talking Photo](https://docs.magichour.ai/api-reference/video-projects/ai-talking-photo) with the original image and your audio instead.<br/>
        /// Note: `pro` is only available for users on Creator, Pro, and Business tiers.<br/>
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