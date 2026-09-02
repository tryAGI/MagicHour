
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnimationCreateVideoResponse4
    {
        /// <summary>
        /// Machine-readable error code.<br/>
        /// - `insufficient_credits`: Purchase credits before retrying.<br/>
        /// - `subscription_required`: Start a subscription before retrying.<br/>
        /// - `plan_upgrade_required`: Upgrade the subscription plan before retrying.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.AnimationCreateVideoResponseCode3JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.AnimationCreateVideoResponseCode3 Code { get; set; }

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
        /// Initializes a new instance of the <see cref="AnimationCreateVideoResponse4" /> class.
        /// </summary>
        /// <param name="code">
        /// Machine-readable error code.<br/>
        /// - `insufficient_credits`: Purchase credits before retrying.<br/>
        /// - `subscription_required`: Start a subscription before retrying.<br/>
        /// - `plan_upgrade_required`: Upgrade the subscription plan before retrying.
        /// </param>
        /// <param name="message">
        /// Human-readable error message.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnimationCreateVideoResponse4(
            global::MagicHour.AnimationCreateVideoResponseCode3 code,
            string message)
        {
            this.Code = code;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnimationCreateVideoResponse4" /> class.
        /// </summary>
        public AnimationCreateVideoResponse4()
        {
        }

    }
}