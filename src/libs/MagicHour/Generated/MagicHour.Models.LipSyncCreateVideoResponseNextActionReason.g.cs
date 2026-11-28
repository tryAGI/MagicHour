
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum LipSyncCreateVideoResponseNextActionReason
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
    public static class LipSyncCreateVideoResponseNextActionReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LipSyncCreateVideoResponseNextActionReason value)
        {
            return value switch
            {
                LipSyncCreateVideoResponseNextActionReason.AutoReloadPending => "auto_reload_pending",
                LipSyncCreateVideoResponseNextActionReason.PaymentFailed => "payment_failed",
                LipSyncCreateVideoResponseNextActionReason.SpendingLimitReached => "spending_limit_reached",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LipSyncCreateVideoResponseNextActionReason? ToEnum(string value)
        {
            return value switch
            {
                "auto_reload_pending" => LipSyncCreateVideoResponseNextActionReason.AutoReloadPending,
                "payment_failed" => LipSyncCreateVideoResponseNextActionReason.PaymentFailed,
                "spending_limit_reached" => LipSyncCreateVideoResponseNextActionReason.SpendingLimitReached,
                _ => null,
            };
        }
    }
}