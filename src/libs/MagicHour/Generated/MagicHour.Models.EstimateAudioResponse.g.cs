
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Success
    /// </summary>
    public sealed partial class EstimateAudioResponse
    {
        /// <summary>
        /// Credits a create request with these fields charges.<br/>
        /// Example: 150
        /// </summary>
        /// <example>150</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimated_credits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EstimatedCredits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EstimateAudioResponse" /> class.
        /// </summary>
        /// <param name="estimatedCredits">
        /// Credits a create request with these fields charges.<br/>
        /// Example: 150
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EstimateAudioResponse(
            int estimatedCredits)
        {
            this.EstimatedCredits = estimatedCredits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EstimateAudioResponse" /> class.
        /// </summary>
        public EstimateAudioResponse()
        {
        }

    }
}