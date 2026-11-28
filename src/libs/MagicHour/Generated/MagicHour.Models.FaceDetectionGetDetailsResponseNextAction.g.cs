
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// What the account owner can do about the rejection, when the API knows more than the error code says. Currently only present for `insufficient_credits` on image-to-video requests from an account with Auto Reload on. `check_balance`: a refill is processing; resubmit the same request once the account balance covers it.
    /// </summary>
    public sealed partial class FaceDetectionGetDetailsResponseNextAction
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.FaceDetectionGetDetailsResponseNextActionTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.FaceDetectionGetDetailsResponseNextActionType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.FaceDetectionGetDetailsResponseNextActionReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.FaceDetectionGetDetailsResponseNextActionReason Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceDetectionGetDetailsResponseNextAction" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="reason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FaceDetectionGetDetailsResponseNextAction(
            global::MagicHour.FaceDetectionGetDetailsResponseNextActionType type,
            global::MagicHour.FaceDetectionGetDetailsResponseNextActionReason reason)
        {
            this.Type = type;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceDetectionGetDetailsResponseNextAction" /> class.
        /// </summary>
        public FaceDetectionGetDetailsResponseNextAction()
        {
        }

    }
}