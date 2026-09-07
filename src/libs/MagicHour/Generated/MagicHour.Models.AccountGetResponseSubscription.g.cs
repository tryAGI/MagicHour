
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Details of the account's subscription plan. `null` if the account has no subscription, e.g. a free account, an account that only purchased credit packs, or an account on usage-based API pricing.<br/>
    /// Reflects the plan currently configured on the subscription. If a plan change is scheduled, `tier` stays on the current plan until the next payment succeeds, so `tier` and `name` can briefly disagree.
    /// </summary>
    public sealed partial class AccountGetResponseSubscription
    {
        /// <summary>
        /// Name of the current subscription plan, e.g. `Creator`, `Pro`, `Pro Plus`, `Business`. `null` if the plan cannot be determined. Use `tier` for a machine-readable value.<br/>
        /// Example: Pro
        /// </summary>
        /// <example>Pro</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Status of the subscription.<br/>
        /// - `active`: payments are up to date.<br/>
        /// - `past_due`: the latest payment failed. `tier` is `free` until payment succeeds. The subscription is canceled if payment keeps failing.<br/>
        /// Example: active
        /// </summary>
        /// <example>active</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.AccountGetResponseSubscriptionStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.AccountGetResponseSubscriptionStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.AccountGetResponseSubscriptionPrice Price { get; set; }

        /// <summary>
        /// Discount applied to the subscription. `null` if no discount is applied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discount")]
        public global::MagicHour.AccountGetResponseSubscriptionDiscount? Discount { get; set; }

        /// <summary>
        /// How often the subscription is billed. `null` if unknown.<br/>
        /// Example: month
        /// </summary>
        /// <example>month</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing_interval")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.AccountGetResponseSubscriptionBillingIntervalJsonConverter))]
        public global::MagicHour.AccountGetResponseSubscriptionBillingInterval? BillingInterval { get; set; }

        /// <summary>
        /// End of the current billing period, in ISO 8601 format. The subscription renews at this time, or ends if `cancel_at_period_end` is `true`.<br/>
        /// Example: 2026-10-01T00:00:00.000Z
        /// </summary>
        /// <example>2026-10-01T00:00:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_period_end")]
        public global::System.DateTime? CurrentPeriodEnd { get; set; }

        /// <summary>
        /// Whether the subscription is scheduled to end at `current_period_end` instead of renewing. The subscription stays usable until then.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancel_at_period_end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CancelAtPeriodEnd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountGetResponseSubscription" /> class.
        /// </summary>
        /// <param name="status">
        /// Status of the subscription.<br/>
        /// - `active`: payments are up to date.<br/>
        /// - `past_due`: the latest payment failed. `tier` is `free` until payment succeeds. The subscription is canceled if payment keeps failing.<br/>
        /// Example: active
        /// </param>
        /// <param name="price"></param>
        /// <param name="cancelAtPeriodEnd">
        /// Whether the subscription is scheduled to end at `current_period_end` instead of renewing. The subscription stays usable until then.<br/>
        /// Example: false
        /// </param>
        /// <param name="name">
        /// Name of the current subscription plan, e.g. `Creator`, `Pro`, `Pro Plus`, `Business`. `null` if the plan cannot be determined. Use `tier` for a machine-readable value.<br/>
        /// Example: Pro
        /// </param>
        /// <param name="discount">
        /// Discount applied to the subscription. `null` if no discount is applied.
        /// </param>
        /// <param name="billingInterval">
        /// How often the subscription is billed. `null` if unknown.<br/>
        /// Example: month
        /// </param>
        /// <param name="currentPeriodEnd">
        /// End of the current billing period, in ISO 8601 format. The subscription renews at this time, or ends if `cancel_at_period_end` is `true`.<br/>
        /// Example: 2026-10-01T00:00:00.000Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccountGetResponseSubscription(
            global::MagicHour.AccountGetResponseSubscriptionStatus status,
            global::MagicHour.AccountGetResponseSubscriptionPrice price,
            bool cancelAtPeriodEnd,
            string? name,
            global::MagicHour.AccountGetResponseSubscriptionDiscount? discount,
            global::MagicHour.AccountGetResponseSubscriptionBillingInterval? billingInterval,
            global::System.DateTime? currentPeriodEnd)
        {
            this.Name = name;
            this.Status = status;
            this.Price = price ?? throw new global::System.ArgumentNullException(nameof(price));
            this.Discount = discount;
            this.BillingInterval = billingInterval;
            this.CurrentPeriodEnd = currentPeriodEnd;
            this.CancelAtPeriodEnd = cancelAtPeriodEnd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountGetResponseSubscription" /> class.
        /// </summary>
        public AccountGetResponseSubscription()
        {
        }

    }
}