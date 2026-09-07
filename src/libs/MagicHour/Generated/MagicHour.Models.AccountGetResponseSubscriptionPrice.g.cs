
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AccountGetResponseSubscriptionPrice
    {
        /// <summary>
        /// Price charged per billing interval, in the smallest unit of the currency (e.g. 4900 is $49.00 for `usd`). Discounts are not applied.<br/>
        /// Example: 4900
        /// </summary>
        /// <example>4900</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Amount { get; set; }

        /// <summary>
        /// Three-letter ISO 4217 currency code, lowercase.<br/>
        /// Example: usd
        /// </summary>
        /// <example>usd</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("currency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Currency { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountGetResponseSubscriptionPrice" /> class.
        /// </summary>
        /// <param name="amount">
        /// Price charged per billing interval, in the smallest unit of the currency (e.g. 4900 is $49.00 for `usd`). Discounts are not applied.<br/>
        /// Example: 4900
        /// </param>
        /// <param name="currency">
        /// Three-letter ISO 4217 currency code, lowercase.<br/>
        /// Example: usd
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccountGetResponseSubscriptionPrice(
            int amount,
            string currency)
        {
            this.Amount = amount;
            this.Currency = currency ?? throw new global::System.ArgumentNullException(nameof(currency));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountGetResponseSubscriptionPrice" /> class.
        /// </summary>
        public AccountGetResponseSubscriptionPrice()
        {
        }

    }
}