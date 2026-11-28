
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum ImageToVideoCreateVideoResponseNextActionReason
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
    public static class ImageToVideoCreateVideoResponseNextActionReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageToVideoCreateVideoResponseNextActionReason value)
        {
            return value switch
            {
                ImageToVideoCreateVideoResponseNextActionReason.AutoReloadPending => "auto_reload_pending",
                ImageToVideoCreateVideoResponseNextActionReason.PaymentFailed => "payment_failed",
                ImageToVideoCreateVideoResponseNextActionReason.SpendingLimitReached => "spending_limit_reached",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageToVideoCreateVideoResponseNextActionReason? ToEnum(string value)
        {
            return value switch
            {
                "auto_reload_pending" => ImageToVideoCreateVideoResponseNextActionReason.AutoReloadPending,
                "payment_failed" => ImageToVideoCreateVideoResponseNextActionReason.PaymentFailed,
                "spending_limit_reached" => ImageToVideoCreateVideoResponseNextActionReason.SpendingLimitReached,
                _ => null,
            };
        }
    }
}