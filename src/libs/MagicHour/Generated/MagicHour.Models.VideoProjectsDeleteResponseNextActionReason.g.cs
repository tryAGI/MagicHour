
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum VideoProjectsDeleteResponseNextActionReason
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
    public static class VideoProjectsDeleteResponseNextActionReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoProjectsDeleteResponseNextActionReason value)
        {
            return value switch
            {
                VideoProjectsDeleteResponseNextActionReason.AutoReloadPending => "auto_reload_pending",
                VideoProjectsDeleteResponseNextActionReason.PaymentFailed => "payment_failed",
                VideoProjectsDeleteResponseNextActionReason.SpendingLimitReached => "spending_limit_reached",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoProjectsDeleteResponseNextActionReason? ToEnum(string value)
        {
            return value switch
            {
                "auto_reload_pending" => VideoProjectsDeleteResponseNextActionReason.AutoReloadPending,
                "payment_failed" => VideoProjectsDeleteResponseNextActionReason.PaymentFailed,
                "spending_limit_reached" => VideoProjectsDeleteResponseNextActionReason.SpendingLimitReached,
                _ => null,
            };
        }
    }
}