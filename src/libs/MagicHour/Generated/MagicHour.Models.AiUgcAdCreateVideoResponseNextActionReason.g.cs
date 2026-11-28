
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum AiUgcAdCreateVideoResponseNextActionReason
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
    public static class AiUgcAdCreateVideoResponseNextActionReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiUgcAdCreateVideoResponseNextActionReason value)
        {
            return value switch
            {
                AiUgcAdCreateVideoResponseNextActionReason.AutoReloadPending => "auto_reload_pending",
                AiUgcAdCreateVideoResponseNextActionReason.PaymentFailed => "payment_failed",
                AiUgcAdCreateVideoResponseNextActionReason.SpendingLimitReached => "spending_limit_reached",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiUgcAdCreateVideoResponseNextActionReason? ToEnum(string value)
        {
            return value switch
            {
                "auto_reload_pending" => AiUgcAdCreateVideoResponseNextActionReason.AutoReloadPending,
                "payment_failed" => AiUgcAdCreateVideoResponseNextActionReason.PaymentFailed,
                "spending_limit_reached" => AiUgcAdCreateVideoResponseNextActionReason.SpendingLimitReached,
                _ => null,
            };
        }
    }
}