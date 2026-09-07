
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AccountGetResponse
    {
        /// <summary>
        /// Unique ID of the account that owns the API key.<br/>
        /// Example: cuid-example
        /// </summary>
        /// <example>cuid-example</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Email address of the account.<br/>
        /// Example: user@example.com
        /// </summary>
        /// <example>user@example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Subscription tier in effect for the account. `free` if there is no active subscription, including while a subscription is `past_due`.<br/>
        /// Example: pro
        /// </summary>
        /// <example>pro</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.AccountGetResponseTierJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MagicHour.AccountGetResponseTier Tier { get; set; }

        /// <summary>
        /// Credits currently available to spend. Includes subscription credits and any purchased credit packs.<br/>
        /// Example: 12500
        /// </summary>
        /// <example>12500</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Credits { get; set; }

        /// <summary>
        /// Details of the account's subscription plan. `null` if the account has no subscription, e.g. a free account, an account that only purchased credit packs, or an account on usage-based API pricing.<br/>
        /// Reflects the plan currently configured on the subscription. If a plan change is scheduled, `tier` stays on the current plan until the next payment succeeds, so `tier` and `name` can briefly disagree.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription")]
        public global::MagicHour.AccountGetResponseSubscription? Subscription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountGetResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique ID of the account that owns the API key.<br/>
        /// Example: cuid-example
        /// </param>
        /// <param name="tier">
        /// Subscription tier in effect for the account. `free` if there is no active subscription, including while a subscription is `past_due`.<br/>
        /// Example: pro
        /// </param>
        /// <param name="credits">
        /// Credits currently available to spend. Includes subscription credits and any purchased credit packs.<br/>
        /// Example: 12500
        /// </param>
        /// <param name="email">
        /// Email address of the account.<br/>
        /// Example: user@example.com
        /// </param>
        /// <param name="subscription">
        /// Details of the account's subscription plan. `null` if the account has no subscription, e.g. a free account, an account that only purchased credit packs, or an account on usage-based API pricing.<br/>
        /// Reflects the plan currently configured on the subscription. If a plan change is scheduled, `tier` stays on the current plan until the next payment succeeds, so `tier` and `name` can briefly disagree.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccountGetResponse(
            string id,
            global::MagicHour.AccountGetResponseTier tier,
            int credits,
            string? email,
            global::MagicHour.AccountGetResponseSubscription? subscription)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Email = email;
            this.Tier = tier;
            this.Credits = credits;
            this.Subscription = subscription;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountGetResponse" /> class.
        /// </summary>
        public AccountGetResponse()
        {
        }

    }
}