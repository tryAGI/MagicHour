
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum BodySwapCreateImageResponseNextActionReason
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
    public static class BodySwapCreateImageResponseNextActionReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodySwapCreateImageResponseNextActionReason value)
        {
            return value switch
            {
                BodySwapCreateImageResponseNextActionReason.AutoReloadPending => "auto_reload_pending",
                BodySwapCreateImageResponseNextActionReason.PaymentFailed => "payment_failed",
                BodySwapCreateImageResponseNextActionReason.SpendingLimitReached => "spending_limit_reached",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodySwapCreateImageResponseNextActionReason? ToEnum(string value)
        {
            return value switch
            {
                "auto_reload_pending" => BodySwapCreateImageResponseNextActionReason.AutoReloadPending,
                "payment_failed" => BodySwapCreateImageResponseNextActionReason.PaymentFailed,
                "spending_limit_reached" => BodySwapCreateImageResponseNextActionReason.SpendingLimitReached,
                _ => null,
            };
        }
    }
}