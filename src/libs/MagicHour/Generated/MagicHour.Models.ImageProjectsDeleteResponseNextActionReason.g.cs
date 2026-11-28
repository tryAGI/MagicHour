
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum ImageProjectsDeleteResponseNextActionReason
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
    public static class ImageProjectsDeleteResponseNextActionReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageProjectsDeleteResponseNextActionReason value)
        {
            return value switch
            {
                ImageProjectsDeleteResponseNextActionReason.AutoReloadPending => "auto_reload_pending",
                ImageProjectsDeleteResponseNextActionReason.PaymentFailed => "payment_failed",
                ImageProjectsDeleteResponseNextActionReason.SpendingLimitReached => "spending_limit_reached",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageProjectsDeleteResponseNextActionReason? ToEnum(string value)
        {
            return value switch
            {
                "auto_reload_pending" => ImageProjectsDeleteResponseNextActionReason.AutoReloadPending,
                "payment_failed" => ImageProjectsDeleteResponseNextActionReason.PaymentFailed,
                "spending_limit_reached" => ImageProjectsDeleteResponseNextActionReason.SpendingLimitReached,
                _ => null,
            };
        }
    }
}