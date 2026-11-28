
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum VideoToVideoCreateVideoResponseNextActionReason
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
    public static class VideoToVideoCreateVideoResponseNextActionReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoToVideoCreateVideoResponseNextActionReason value)
        {
            return value switch
            {
                VideoToVideoCreateVideoResponseNextActionReason.AutoReloadPending => "auto_reload_pending",
                VideoToVideoCreateVideoResponseNextActionReason.PaymentFailed => "payment_failed",
                VideoToVideoCreateVideoResponseNextActionReason.SpendingLimitReached => "spending_limit_reached",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoToVideoCreateVideoResponseNextActionReason? ToEnum(string value)
        {
            return value switch
            {
                "auto_reload_pending" => VideoToVideoCreateVideoResponseNextActionReason.AutoReloadPending,
                "payment_failed" => VideoToVideoCreateVideoResponseNextActionReason.PaymentFailed,
                "spending_limit_reached" => VideoToVideoCreateVideoResponseNextActionReason.SpendingLimitReached,
                _ => null,
            };
        }
    }
}