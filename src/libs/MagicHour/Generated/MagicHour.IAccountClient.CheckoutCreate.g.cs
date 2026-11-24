#nullable enable

namespace MagicHour
{
    public partial interface IAccountClient
    {
        /// <summary>
        /// Create checkout<br/>
        /// Create a Stripe Checkout link for the account that owns the API key. Nothing is charged until the checkout is completed in a browser.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::MagicHour.CheckoutCreateResponse> CheckoutCreateAsync(

            global::MagicHour.CheckoutCreateRequest request,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create checkout<br/>
        /// Create a Stripe Checkout link for the account that owns the API key. Nothing is charged until the checkout is completed in a browser.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MagicHour.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::MagicHour.AutoSDKHttpResponse<global::MagicHour.CheckoutCreateResponse>> CheckoutCreateAsResponseAsync(

            global::MagicHour.CheckoutCreateRequest request,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create checkout<br/>
        /// Create a Stripe Checkout link for the account that owns the API key. Nothing is charged until the checkout is completed in a browser.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MagicHour.CheckoutCreateResponse> CheckoutCreateAsync(
            global::MagicHour.CheckoutCreateRequestType type = default,
            int? packCount = default,
            double? creditShortfall = default,
            global::MagicHour.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}