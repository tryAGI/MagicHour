
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum HeadSwapCreateImageResponseNextActionReason
    {
        /// <summary>
        ///
        /// </summary>
        AutoReloadPending,
        /// <summary>
        ///
        /// </summary>
        PaymentFailed,
        /// <summary>
        ///
        /// </summary>
        SpendingLimitReached,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HeadSwapCreateImageResponseNextActionReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HeadSwapCreateImageResponseNextActionReason value)
        {
            return value switch
            {
                HeadSwapCreateImageResponseNextActionReason.AutoReloadPending => "auto_reload_pending",
                HeadSwapCreateImageResponseNextActionReason.PaymentFailed => "payment_failed",
                HeadSwapCreateImageResponseNextActionReason.SpendingLimitReached => "spending_limit_reached",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HeadSwapCreateImageResponseNextActionReason? ToEnum(string value)
        {
            return value switch
            {
                "auto_reload_pending" => HeadSwapCreateImageResponseNextActionReason.AutoReloadPending,
                "payment_failed" => HeadSwapCreateImageResponseNextActionReason.PaymentFailed,
                "spending_limit_reached" => HeadSwapCreateImageResponseNextActionReason.SpendingLimitReached,
                _ => null,
            };
        }
    }
}