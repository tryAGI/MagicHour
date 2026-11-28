
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AccountGetResponseAutoReload
    {
        /// <summary>
        /// State of Auto Reload on the account.<br/>
        /// - `disabled`: off or never set up.<br/>
        /// - `active`: on, with no refill processing or blocked.<br/>
        /// - `auto_reload_pending`: a refill is processing. Check again shortly.<br/>
        /// - `payment_failed`: the last refill payment failed and paused Auto Reload until the payment method is updated.<br/>
        /// - `spending_limit_reached`: the monthly limit blocked the last refill.<br/>
        /// After an `insufficient_credits` rejection, resubmit the same request once `credits` reaches that rejection's `credits_required`.<br/>
        /// Example: active
        /// </summary>
        /// <example>active</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.AccountGetResponseAutoReloadStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.AccountGetResponseAutoReloadStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountGetResponseAutoReload" /> class.
        /// </summary>
        /// <param name="status">
        /// State of Auto Reload on the account.<br/>
        /// - `disabled`: off or never set up.<br/>
        /// - `active`: on, with no refill processing or blocked.<br/>
        /// - `auto_reload_pending`: a refill is processing. Check again shortly.<br/>
        /// - `payment_failed`: the last refill payment failed and paused Auto Reload until the payment method is updated.<br/>
        /// - `spending_limit_reached`: the monthly limit blocked the last refill.<br/>
        /// After an `insufficient_credits` rejection, resubmit the same request once `credits` reaches that rejection's `credits_required`.<br/>
        /// Example: active
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccountGetResponseAutoReload(
            global::MagicHour.AccountGetResponseAutoReloadStatus status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountGetResponseAutoReload" /> class.
        /// </summary>
        public AccountGetResponseAutoReload()
        {
        }

    }
}