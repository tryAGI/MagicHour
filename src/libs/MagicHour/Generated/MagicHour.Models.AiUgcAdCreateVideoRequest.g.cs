
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AiUgcAdCreateVideoRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.AiUgcAdCreateVideoRequestAssets Assets { get; set; }

        /// <summary>
        /// The words the actor should speak. Character limits apply after trimming:<br/>
        /// * kling-3.0: 2304 characters.<br/>
        /// * ltx-2.5: 1804 characters.<br/>
        /// * veo3.1: 2500 characters.<br/>
        /// LTX and Kling dialogue wrappers count toward their model prompt limit.<br/>
        /// Example: Meet your new everyday essential.
        /// </summary>
        /// <example>Meet your new everyday essential.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("script")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Script { get; set; }

        /// <summary>
        /// Video duration in seconds. Supported values by model:<br/>
        /// * kling-3.0: 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 seconds.<br/>
        /// * ltx-2.5: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60 seconds.<br/>
        /// * veo3.1: 4, 6, 8, 15, 22, 29, 36, 43, 50, 57, 64, 71, 78, 85, 92, 99, 106, 113, 120, 127, 134, 141 seconds.<br/>
        /// Free plans are limited to 5 seconds unless a credit pack has been purchased.<br/>
        /// Example: 4
        /// </summary>
        /// <example>4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double EndSeconds { get; set; }

        /// <summary>
        /// Defaults to kling-3.0 on paid plans and ltx-2.5 on free plans.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.AiUgcAdCreateVideoRequestModelJsonConverter))]
        public global::MagicHour.AiUgcAdCreateVideoRequestModel? Model { get; set; }

        /// <summary>
        /// Defaults to 720p on paid plans and 480p on free plans. Unsupported model/resolution combinations and resolutions unavailable for your plan are rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.AiUgcAdCreateVideoRequestResolutionJsonConverter))]
        public global::MagicHour.AiUgcAdCreateVideoRequestResolution? Resolution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiUgcAdCreateVideoRequest" /> class.
        /// </summary>
        /// <param name="assets"></param>
        /// <param name="script">
        /// The words the actor should speak. Character limits apply after trimming:<br/>
        /// * kling-3.0: 2304 characters.<br/>
        /// * ltx-2.5: 1804 characters.<br/>
        /// * veo3.1: 2500 characters.<br/>
        /// LTX and Kling dialogue wrappers count toward their model prompt limit.<br/>
        /// Example: Meet your new everyday essential.
        /// </param>
        /// <param name="endSeconds">
        /// Video duration in seconds. Supported values by model:<br/>
        /// * kling-3.0: 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 seconds.<br/>
        /// * ltx-2.5: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60 seconds.<br/>
        /// * veo3.1: 4, 6, 8, 15, 22, 29, 36, 43, 50, 57, 64, 71, 78, 85, 92, 99, 106, 113, 120, 127, 134, 141 seconds.<br/>
        /// Free plans are limited to 5 seconds unless a credit pack has been purchased.<br/>
        /// Example: 4
        /// </param>
        /// <param name="model">
        /// Defaults to kling-3.0 on paid plans and ltx-2.5 on free plans.
        /// </param>
        /// <param name="resolution">
        /// Defaults to 720p on paid plans and 480p on free plans. Unsupported model/resolution combinations and resolutions unavailable for your plan are rejected.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiUgcAdCreateVideoRequest(
            global::MagicHour.AiUgcAdCreateVideoRequestAssets assets,
            string script,
            double endSeconds,
            global::MagicHour.AiUgcAdCreateVideoRequestModel? model,
            global::MagicHour.AiUgcAdCreateVideoRequestResolution? resolution)
        {
            this.Assets = assets ?? throw new global::System.ArgumentNullException(nameof(assets));
            this.Script = script ?? throw new global::System.ArgumentNullException(nameof(script));
            this.EndSeconds = endSeconds;
            this.Model = model;
            this.Resolution = resolution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiUgcAdCreateVideoRequest" /> class.
        /// </summary>
        public AiUgcAdCreateVideoRequest()
        {
        }

    }
}