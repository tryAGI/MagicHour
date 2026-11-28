
#nullable enable

namespace MagicHour
{
    /// <summary>
    ///
    /// </summary>
    public enum TextToVideoCreateVideoResponseNextActionReason
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
    public static class TextToVideoCreateVideoResponseNextActionReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextToVideoCreateVideoResponseNextActionReason value)
        {
            return value switch
            {
                TextToVideoCreateVideoResponseNextActionReason.AutoReloadPending => "auto_reload_pending",
                TextToVideoCreateVideoResponseNextActionReason.PaymentFailed => "payment_failed",
                TextToVideoCreateVideoResponseNextActionReason.SpendingLimitReached => "spending_limit_reached",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextToVideoCreateVideoResponseNextActionReason? ToEnum(string value)
        {
            return value switch
            {
                "auto_reload_pending" => TextToVideoCreateVideoResponseNextActionReason.AutoReloadPending,
                "payment_failed" => TextToVideoCreateVideoResponseNextActionReason.PaymentFailed,
                "spending_limit_reached" => TextToVideoCreateVideoResponseNextActionReason.SpendingLimitReached,
                _ => null,
            };
        }
    }
}