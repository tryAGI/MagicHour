
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// Discount applied to the subscription. `null` if no discount is applied.
    /// </summary>
    public sealed partial class AccountGetResponseSubscriptionDiscount
    {
        /// <summary>
        /// Percentage taken off `price.amount` each billing interval. `null` if the discount is a fixed amount.<br/>
        /// Example: 20
        /// </summary>
        /// <example>20</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("percent_off")]
        public double? PercentOff { get; set; }

        /// <summary>
        /// Fixed amount taken off `price.amount` each billing interval, in the smallest unit of the currency. `null` if the discount is a percentage.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount_off")]
        public int? AmountOff { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountGetResponseSubscriptionDiscount" /> class.
        /// </summary>
        /// <param name="percentOff">
        /// Percentage taken off `price.amount` each billing interval. `null` if the discount is a fixed amount.<br/>
        /// Example: 20
        /// </param>
        /// <param name="amountOff">
        /// Fixed amount taken off `price.amount` each billing interval, in the smallest unit of the currency. `null` if the discount is a percentage.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccountGetResponseSubscriptionDiscount(
            double? percentOff,
            int? amountOff)
        {
            this.PercentOff = percentOff;
            this.AmountOff = amountOff;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountGetResponseSubscriptionDiscount" /> class.
        /// </summary>
        public AccountGetResponseSubscriptionDiscount()
        {
        }

    }
}