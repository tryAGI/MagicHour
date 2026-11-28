
#nullable enable

namespace MagicHour
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
    public enum AccountGetResponseAutoReloadStatus
    {
        /// <summary>
        /// on, with no refill processing or blocked.
        /// </summary>
        Active,
        /// <summary>
        /// a refill is processing. Check again shortly.
        /// </summary>
        AutoReloadPending,
        /// <summary>
        /// off or never set up.
        /// </summary>
        Disabled,
        /// <summary>
        /// the last refill payment failed and paused Auto Reload until the payment method is updated.
        /// </summary>
        PaymentFailed,
        /// <summary>
        /// the monthly limit blocked the last refill.
        /// </summary>
        SpendingLimitReached,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AccountGetResponseAutoReloadStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AccountGetResponseAutoReloadStatus value)
        {
            return value switch
            {
                AccountGetResponseAutoReloadStatus.Active => "active",
                AccountGetResponseAutoReloadStatus.AutoReloadPending => "auto_reload_pending",
                AccountGetResponseAutoReloadStatus.Disabled => "disabled",
                AccountGetResponseAutoReloadStatus.PaymentFailed => "payment_failed",
                AccountGetResponseAutoReloadStatus.SpendingLimitReached => "spending_limit_reached",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AccountGetResponseAutoReloadStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => AccountGetResponseAutoReloadStatus.Active,
                "auto_reload_pending" => AccountGetResponseAutoReloadStatus.AutoReloadPending,
                "disabled" => AccountGetResponseAutoReloadStatus.Disabled,
                "payment_failed" => AccountGetResponseAutoReloadStatus.PaymentFailed,
                "spending_limit_reached" => AccountGetResponseAutoReloadStatus.SpendingLimitReached,
                _ => null,
            };
        }
    }
}