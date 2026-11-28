
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BodySwapCreateImageResponse4
    {
        /// <summary>
        /// Machine-readable error code.<br/>
        /// - `insufficient_credits`: Purchase credits before retrying.<br/>
        /// - `subscription_required`: Start a subscription before retrying.<br/>
        /// - `plan_upgrade_required`: Upgrade the subscription plan before retrying.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.BodySwapCreateImageResponseCode3JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.BodySwapCreateImageResponseCode3 Code { get; set; }

        /// <summary>
        /// Human-readable error message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Credits missing from the account balance for this request. Only present for `insufficient_credits`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credit_shortfall")]
        public double? CreditShortfall { get; set; }

        /// <summary>
        /// Account balance when the request was checked. Only present for `insufficient_credits`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits_available")]
        public double? CreditsAvailable { get; set; }

        /// <summary>
        /// Credits the request costs. Resubmit the same request once the account balance from `GET /v1/account` reaches this. Only present for `insufficient_credits`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits_required")]
        public double? CreditsRequired { get; set; }

        /// <summary>
        /// What the account owner can do about the rejection, when the API knows more than the error code says. Currently only present for `insufficient_credits` on image-to-video requests from an account with Auto Reload on. `check_balance`: a refill is processing; resubmit the same request once the account balance covers it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_action")]
        public global::MagicHour.BodySwapCreateImageResponseNextAction? NextAction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodySwapCreateImageResponse4" /> class.
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
        /// <param name="creditShortfall">
        /// Credits missing from the account balance for this request. Only present for `insufficient_credits`.
        /// </param>
        /// <param name="creditsAvailable">
        /// Account balance when the request was checked. Only present for `insufficient_credits`.
        /// </param>
        /// <param name="creditsRequired">
        /// Credits the request costs. Resubmit the same request once the account balance from `GET /v1/account` reaches this. Only present for `insufficient_credits`.
        /// </param>
        /// <param name="nextAction">
        /// What the account owner can do about the rejection, when the API knows more than the error code says. Currently only present for `insufficient_credits` on image-to-video requests from an account with Auto Reload on. `check_balance`: a refill is processing; resubmit the same request once the account balance covers it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodySwapCreateImageResponse4(
            global::MagicHour.BodySwapCreateImageResponseCode3 code,
            string message,
            double? creditShortfall,
            double? creditsAvailable,
            double? creditsRequired,
            global::MagicHour.BodySwapCreateImageResponseNextAction? nextAction)
        {
            this.Code = code;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.CreditShortfall = creditShortfall;
            this.CreditsAvailable = creditsAvailable;
            this.CreditsRequired = creditsRequired;
            this.NextAction = nextAction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodySwapCreateImageResponse4" /> class.
        /// </summary>
        public BodySwapCreateImageResponse4()
        {
        }

    }
}