
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LipSyncCreateVideoResponse7
    {
        /// <summary>
        /// Machine-readable error code.<br/>
        /// - `internal_server_error`: Retry later or contact support if the error continues.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.LipSyncCreateVideoResponseCode6JsonConverter))]
        public global::MagicHour.LipSyncCreateVideoResponseCode6 Code { get; set; }

        /// <summary>
        /// Human-readable error message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LipSyncCreateVideoResponse7" /> class.
        /// </summary>
        /// <param name="message">
        /// Human-readable error message.
        /// </param>
        /// <param name="code">
        /// Machine-readable error code.<br/>
        /// - `internal_server_error`: Retry later or contact support if the error continues.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LipSyncCreateVideoResponse7(
            string message,
            global::MagicHour.LipSyncCreateVideoResponseCode6 code)
        {
            this.Code = code;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LipSyncCreateVideoResponse7" /> class.
        /// </summary>
        public LipSyncCreateVideoResponse7()
        {
        }

    }
}