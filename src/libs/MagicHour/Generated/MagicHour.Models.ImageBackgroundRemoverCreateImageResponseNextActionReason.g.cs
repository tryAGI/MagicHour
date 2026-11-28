
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum ImageBackgroundRemoverCreateImageResponseNextActionReason
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
    public static class ImageBackgroundRemoverCreateImageResponseNextActionReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageBackgroundRemoverCreateImageResponseNextActionReason value)
        {
            return value switch
            {
                ImageBackgroundRemoverCreateImageResponseNextActionReason.AutoReloadPending => "auto_reload_pending",
                ImageBackgroundRemoverCreateImageResponseNextActionReason.PaymentFailed => "payment_failed",
                ImageBackgroundRemoverCreateImageResponseNextActionReason.SpendingLimitReached => "spending_limit_reached",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageBackgroundRemoverCreateImageResponseNextActionReason? ToEnum(string value)
        {
            return value switch
            {
                "auto_reload_pending" => ImageBackgroundRemoverCreateImageResponseNextActionReason.AutoReloadPending,
                "payment_failed" => ImageBackgroundRemoverCreateImageResponseNextActionReason.PaymentFailed,
                "spending_limit_reached" => ImageBackgroundRemoverCreateImageResponseNextActionReason.SpendingLimitReached,
                _ => null,
            };
        }
    }
}