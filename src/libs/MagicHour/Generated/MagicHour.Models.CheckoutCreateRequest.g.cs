
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CheckoutCreateRequest
    {
        /// <summary>
        /// What to buy. `credit_pack` is a one-time credit purchase.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MagicHour.JsonConverters.CheckoutCreateRequestTypeJsonConverter))]
        public global::MagicHour.CheckoutCreateRequestType Type { get; set; }

        /// <summary>
        /// Number of credit packs the checkout starts with. Takes priority over `credit_shortfall`.<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pack_count")]
        public int? PackCount { get; set; }

        /// <summary>
        /// Credits a blocked request is missing, e.g. `credit_shortfall` from a 402 response. The checkout starts with enough packs to cover it. Defaults to one pack.<br/>
        /// Example: 150
        /// </summary>
        /// <example>150</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("credit_shortfall")]
        public double? CreditShortfall { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutCreateRequest" /> class.
        /// </summary>
        /// <param name="type">
        /// What to buy. `credit_pack` is a one-time credit purchase.
        /// </param>
        /// <param name="packCount">
        /// Number of credit packs the checkout starts with. Takes priority over `credit_shortfall`.<br/>
        /// Example: 3
        /// </param>
        /// <param name="creditShortfall">
        /// Credits a blocked request is missing, e.g. `credit_shortfall` from a 402 response. The checkout starts with enough packs to cover it. Defaults to one pack.<br/>
        /// Example: 150
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CheckoutCreateRequest(
            global::MagicHour.CheckoutCreateRequestType type,
            int? packCount,
            double? creditShortfall)
        {
            this.Type = type;
            this.PackCount = packCount;
            this.CreditShortfall = creditShortfall;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutCreateRequest" /> class.
        /// </summary>
        public CheckoutCreateRequest()
        {
        }

    }
}