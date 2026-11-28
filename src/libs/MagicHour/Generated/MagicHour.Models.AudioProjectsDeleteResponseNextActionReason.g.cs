
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum AudioProjectsDeleteResponseNextActionReason
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
    public static class AudioProjectsDeleteResponseNextActionReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioProjectsDeleteResponseNextActionReason value)
        {
            return value switch
            {
                AudioProjectsDeleteResponseNextActionReason.AutoReloadPending => "auto_reload_pending",
                AudioProjectsDeleteResponseNextActionReason.PaymentFailed => "payment_failed",
                AudioProjectsDeleteResponseNextActionReason.SpendingLimitReached => "spending_limit_reached",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioProjectsDeleteResponseNextActionReason? ToEnum(string value)
        {
            return value switch
            {
                "auto_reload_pending" => AudioProjectsDeleteResponseNextActionReason.AutoReloadPending,
                "payment_failed" => AudioProjectsDeleteResponseNextActionReason.PaymentFailed,
                "spending_limit_reached" => AudioProjectsDeleteResponseNextActionReason.SpendingLimitReached,
                _ => null,
            };
        }
    }
}