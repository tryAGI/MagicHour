
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CheckoutCreateResponse
    {
        /// <summary>
        /// Open in a browser to complete the purchase.<br/>
        /// Example: https://pay.magichour.ai/c/pay/cs_live_...
        /// </summary>
        /// <example>https://pay.magichour.ai/c/pay/cs_live_...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkout_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CheckoutUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutCreateResponse" /> class.
        /// </summary>
        /// <param name="checkoutUrl">
        /// Open in a browser to complete the purchase.<br/>
        /// Example: https://pay.magichour.ai/c/pay/cs_live_...
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CheckoutCreateResponse(
            string checkoutUrl)
        {
            this.CheckoutUrl = checkoutUrl ?? throw new global::System.ArgumentNullException(nameof(checkoutUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutCreateResponse" /> class.
        /// </summary>
        public CheckoutCreateResponse()
        {
        }

    }
}