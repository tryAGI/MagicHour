
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VoicesListResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::MagicHour.VoicesListResponseVoice> Voices { get; set; }

        /// <summary>
        /// Cursor for the next page, or null when there are no more voices.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicesListResponse" /> class.
        /// </summary>
        /// <param name="voices"></param>
        /// <param name="nextCursor">
        /// Cursor for the next page, or null when there are no more voices.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoicesListResponse(
            global::System.Collections.Generic.IList<global::MagicHour.VoicesListResponseVoice> voices,
            string? nextCursor)
        {
            this.Voices = voices ?? throw new global::System.ArgumentNullException(nameof(voices));
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicesListResponse" /> class.
        /// </summary>
        public VoicesListResponse()
        {
        }

    }
}